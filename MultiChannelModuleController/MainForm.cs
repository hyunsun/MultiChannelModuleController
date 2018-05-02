using System;
using System.Drawing;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace MultiChannelModuleController
{
    public partial class MainForm : Form
    {
        private SerialPort _SerialPort;
        private SerialPort SerialPort
        {
            get
            {
                if (_SerialPort == null)
                {
                    _SerialPort = new SerialPort();
                    _SerialPort.BaudRate = 115200;
                    _SerialPort.DataBits = 8;
                    _SerialPort.Parity = Parity.None;
                    _SerialPort.Handshake = Handshake.None;
                    _SerialPort.StopBits = StopBits.One;
                }
                return _SerialPort;
            }
        }
        private Boolean IsOpen
        {
            set
            {
                if (value)
                {
                    ResumePollStatus();

                    pbSerialPort.Image = Properties.Resources.green;
                    cbSerialPort.Enabled = false;
                    btnConnect.Text = "CLOSE";
                    btnModeSend.Enabled = true;
                    btnStcSendSelected.Enabled = true;
                    btnStcSendManual.Enabled = true;
                    btnAgcSendSelected.Enabled = true;
                    btnAgcSendManual.Enabled = true;
                }
                else
                {
                    PausePollStatus();

                    pbSerialPort.Image = Properties.Resources.red;
                    pbLo1.Image = Properties.Resources.black;
                    pbLo2.Image = Properties.Resources.black;
                    cbSerialPort.Enabled = true;
                    btnConnect.Text = "CONNECT";
                    btnModeSend.Enabled = false;
                    btnStcSendSelected.Enabled = false;
                    btnStcSendManual.Enabled = false;
                    btnAgcSendSelected.Enabled = false;
                    btnAgcSendManual.Enabled = false;
                }
            }
            get
            {
                return SerialPort.IsOpen;
            }
        }

        private static string Caption = "다채널 수신 모듈";
        private static ManualResetEvent ReplyReceivedEvent = new ManualResetEvent(false);
        private static int ReplyTimeout = 3000; // 1 seconds
        private byte[] ReplyFrameBuffer = new byte[FrameConstants.ReplyMessageLength];
        private int ReplyReceived = 0;
        private bool ReplyFrameStarted = false;
        private bool ReplyFrameEnded = false;

        private static object RequestLock = new object(); 
        private static Thread StatusPollingThread;
        private static ManualResetEvent ConnectedEvent = new ManualResetEvent(false);  
        private static int StatusPollingDelay = 10000; // 10 seconds


        public MainForm()
        {
            InitializeComponent();

            StatusPollingThread = new Thread(new ThreadStart(PollStatus));
            StatusPollingThread.IsBackground = true;
            StatusPollingThread.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitSerialPortGroup();
            InitAlarmModeGroup();
            InitStcGroup();
            InitAgcGroup();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsOpen)
            {
                SerialPort.Close();
            }
        }

        private void InitSerialPortGroup()
        {
            cbSerialPort.Items.Clear();
            cbSerialPort.Items.Add("Select port");
            foreach (string portName in SerialPort.GetPortNames())
            {
                cbSerialPort.Items.Add(portName);
            }
            cbSerialPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSerialPort.SelectedIndex = 0;
        }

        private void InitAlarmModeGroup()
        {
            rbNormal.Select();
        }

        private void InitStcGroup()
        {
            PrivateFontCollection digitalFont = new PrivateFontCollection();
            digitalFont.AddFontFile("digital_font.ttf");
            Font textFont;

            textFont = new Font(digitalFont.Families[0], 28f);
            tbStcSelected.Font = textFont;
            tbStcManual.Font = textFont;
            tbStcManual.Text = "0.00";

            textFont = new Font(digitalFont.Families[0], 14f);
            dbm1.Font = textFont;
            textFont = new Font(digitalFont.Families[0], 12f);
            dbm2.Font = textFont;

            double value = 0.0;
            for (int i = 0; i <= 128; i++)
            {
                String item = String.Format("{0:D3} :   {1:F}   dBm", i, value);
                lbStc.Items.Add(item);
                value += 0.5;
            }
            lbStc.SelectedIndex = 0;
        }

        private void InitAgcGroup()
        {
            PrivateFontCollection digitalFont = new PrivateFontCollection();
            digitalFont.AddFontFile("digital_font.ttf");
            Font textFont;

            textFont = new Font(digitalFont.Families[0], 28f);
            tbAgcSelected.Font = textFont;
            tbAgcManual.Font = textFont;
            tbAgcManual.Text = "0.00";

            textFont = new Font(digitalFont.Families[0], 14f);
            dbm3.Font = textFont;
            textFont = new Font(digitalFont.Families[0], 12f);
            dbm4.Font = textFont;

            double value = 0.0;
            for (int i = 0; i <= 128; i++)
            {
                String item = String.Format("{0:D3} :   {1:F}   dBm", i, value);
                lbAgc.Items.Add(item);
                value += 0.5;
            }
            lbAgc.SelectedIndex = 0;
        }
   
        // Event handlers for serial port connection group      
        private void cbSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialPort.PortName = cbSerialPort.Text;
            IsOpen = SerialPort.IsOpen; // should be always false here
            if (cbSerialPort.SelectedIndex == 0)
            {
                pbSerialPort.Image = Properties.Resources.black;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cbSerialPort.SelectedIndex == 0)
            {
                return;
            }

            if (!IsOpen)
            {
                try
                {
                    SerialPort.Open();
                }
                catch (Exception ex)
                {                   
                    MessageBox.Show("연결에 실패했습니다\n" + ex.Message,
                        Caption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                SerialPort.Close();
            }

            IsOpen = SerialPort.IsOpen;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                SerialPort.Close();
            }
            this.Close();
        }

        // Event handlers for alarm and mode group 
        private void btnModeSend_Click(object sender, EventArgs e)
        {
            byte mode = rbNormal.Checked ? (byte)ModeType.Normal : (byte)ModeType.High;

            Request request = new Request(CommandType.ModeRequest, mode);
            RequestResult reqResult;
            bool result = SendRequest(request, out reqResult);

            if (result)
            {
                MessageBox.Show("모드가 설정되었습니다.", Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("모드를 설정하지 못했습니다.\n" +
                    reqResult.ErrorMessage,
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Event handlers for STC group
        private void lbStc_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbStcSelected.Text = String.Format("{0:F}", 0.5 * lbStc.SelectedIndex);
        }

        private void tbStcManual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) ||
                e.KeyChar == '.' ||
                e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btnStcSendSelected_Click(object sender, EventArgs e)
        {
            byte data = Convert.ToByte(lbStc.SelectedIndex + 1);

            Request request = new Request(CommandType.StcRequest, data);
            RequestResult reqResult;
            bool result = SendRequest(request, out reqResult);

            if (result)
            {
                MessageBox.Show("STC 값이 설정되었습니다.", Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("STC 값을 설정하지 못했습니다.\n" +
                    reqResult.ErrorMessage,
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSendManual_Click(object sender, EventArgs e)
        {
            double doubleValue = Convert.ToDouble(tbStcManual.Text);
            if (!ValidateControlValue(doubleValue))
            {
                MessageBox.Show("유효하지 않은 값입니다.", Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            int integerValue;
            if (doubleValue == 0.0)
            {
                integerValue = 1;
            }
            else
            {
                integerValue = (int)(doubleValue / 0.5) + 1;
            }
            byte data = Convert.ToByte(integerValue);

            Request request = new Request(CommandType.StcRequest, data);
            RequestResult reqResult;
            bool result = SendRequest(request, out reqResult);

            if (result)
            {
                MessageBox.Show("STC 값이 설정되었습니다.", Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("STC 값을 설정하지 못했습니다.\n" +
                    reqResult.ErrorMessage,
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Event handlers for AGC group
        private void lbAgc_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbAgcSelected.Text = String.Format("{0:F}", 0.5 * lbAgc.SelectedIndex);
        }

        private void tbAgcManual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) ||
                e.KeyChar == '.' ||
                e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btnAgcSendSelected_Click(object sender, EventArgs e)
        {
            byte data = Convert.ToByte(lbAgc.SelectedIndex + 1);

            Request request = new Request(CommandType.AgcRequest, data);
            RequestResult reqResult;
            bool result = SendRequest(request, out reqResult);

            if (result)
            {
                MessageBox.Show("AGC 값이 설정되었습니다.", Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("AGC 값을 설정하지 못했습니다.\n" +
                    reqResult.ErrorMessage,
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAgcSendManual_Click(object sender, EventArgs e)
        {
            double doubleValue = Convert.ToDouble(tbStcManual.Text);
            if (!ValidateControlValue(doubleValue))
            {
                MessageBox.Show("유효하지 않은 값입니다.", Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            int integerValue;
            if (doubleValue == 0.0)
            {
                integerValue = 1;
            }
            else
            {
                integerValue = (int)(doubleValue / 0.5) + 1;
            }
            byte data = Convert.ToByte(integerValue);

            Request request = new Request(CommandType.AgcRequest, data);
            RequestResult reqResult;
            bool result = SendRequest(request, out reqResult);

            if (result)
            {
                MessageBox.Show("AGC 값이 설정되었습니다.", Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("AGC 값을 설정하지 못했습니다.\n" +
                    reqResult.ErrorMessage,
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidateControlValue(double value)
        {
            // TODO: validate STC and AGC user input value
            return true;
        }

        private void UpdateLo1Status(bool isActive)
        {
            pbLo1.Image = isActive ?
                Properties.Resources.green : Properties.Resources.red;
        }

        private void UpdateLo2Status(bool isActive)
        {
            pbLo2.Image = isActive ?
                Properties.Resources.green : Properties.Resources.red;
        }

        private RequestResult GetCurrentStatus()
        {
            Request request = new Request(CommandType.StatusRequest);
            RequestResult reqResult;
            bool result = SendRequest(request, out reqResult);

            if (!result)
            {
                return null;
            }
            return reqResult;
        }

        private delegate void UpdateStatus(bool isActive);

        private void PollStatus()
        {
            while (ConnectedEvent.WaitOne())
            {
                RequestResult result = GetCurrentStatus();
                if (result != null)
                {
                    pbLo1.Invoke(new UpdateStatus(UpdateLo1Status),
                        new object[] { result.Lo1Status });
                    pbLo2.Invoke(new UpdateStatus(UpdateLo2Status),
                        new object[] { result.Lo2Status });
                }
                // TODO: 응답을 제대로 받지 못 한 경우 RED로 업데이트?

                Thread.Sleep(StatusPollingDelay);
            }
        }

        private void PausePollStatus()
        {
            ConnectedEvent.Reset();
        }

        private void ResumePollStatus()
        {
            ConnectedEvent.Set();
        }

        private bool SendRequest(Request request, out RequestResult reqResult)
        {
            lock (RequestLock)
            {
                bool result = false;
                ReplyReceivedEvent.Reset();

                // Restore variables to default to handle the new request
                ReplyFrameBuffer = new byte[FrameConstants.ReplyMessageLength];
                ReplyReceived = 0;
                ReplyFrameStarted = false;
                ReplyFrameEnded = false;

                SerialPort.DiscardOutBuffer();
                SerialPort.DiscardInBuffer();
                SerialPort.DataReceived += Port_DataReceived;

                SerialPort.Write(request.FrameBuffer, 0, request.FrameLength);

                // Block main form until it gets reply
                ReplyReceivedEvent.WaitOne(ReplyTimeout);
                SerialPort.DataReceived -= Port_DataReceived;

                // Handle reply if valid reply received or
                // just return false when timed out
                if (ReplyFrameEnded)
                {
                    result = request.GetReply(ReplyFrameBuffer, out reqResult);
                }
                else
                {
                    reqResult = new RequestResult();
                    reqResult.ErrorMessage = "응답을 받지 못했습니다(reply was not received)";
                }
                return result;
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (SerialPort.BytesToRead > 0 && !ReplyFrameEnded)
            {
                byte read = (byte)SerialPort.ReadByte();
                if (read == FrameConstants.StartCode)
                {
                    ReplyFrameStarted = true;
                }
                else if (read == FrameConstants.EndCode)
                {
                    // Release main form when receiving reply complete
                    ReplyFrameEnded = true;
                    ReplyReceivedEvent.Set();
                }
                else if (ReplyFrameStarted &&
                    ReplyReceived < FrameConstants.ReplyMessageLength)
                {
                    ReplyFrameBuffer[ReplyReceived++] = read;
                }
            }
        }
    }
}
