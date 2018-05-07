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
                    ResumeStatusPolling();

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
                    PauseStatusPolling();

                    pbSerialPort.Image = Properties.Resources.red;
                    pbLo1.Image = Properties.Resources.black_small;
                    pbLo2.Image = Properties.Resources.black_small;
                    cbSerialPort.Enabled = true;
                    btnConnect.Text = "OPEN";
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
        private static ManualResetEvent ResponseReceivedEvent = new ManualResetEvent(false);
        private static int ResponseTimeout = 1000; // 1 seconds
        private byte[] ResponseFrameBuffer = new byte[FrameConstants.MessageBufferLength];
        private int ResponseReceived = 0;
        private bool ResponseFrameStarted = false;
        private bool ResponseFrameEnded = false;

        private static object RequestLock = new object(); 
        private static Thread StatusPollingThread;
        private static ManualResetEvent ConnectedEvent = new ManualResetEvent(false);  
        private static int StatusPollingDelay = 1000; // 1 seconds
        private delegate void UpdateStatus(bool isActive);

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private static PrivateFontCollection DigitalFont = new PrivateFontCollection();

        public MainForm()
        {
            InitializeComponent();

            StatusPollingThread = new Thread(new ThreadStart(PollStatus));
            StatusPollingThread.IsBackground = true;
            StatusPollingThread.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitDigitalFont();
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

        private void InitDigitalFont()
        {
            byte[] fontData = Properties.Resources.digital_font;
            uint dummy = 0;

            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            DigitalFont.AddMemoryFont(fontPtr, Properties.Resources.digital_font.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.digital_font.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
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
            Font digitalFont;

            digitalFont = new Font(DigitalFont.Families[0], 60f);
            tbStcSelected.Font = digitalFont;
            digitalFont = new Font(DigitalFont.Families[0], 48f);
            tbStcManual.Font = digitalFont;
            tbStcManual.Text = "0.00";

            digitalFont = new Font(DigitalFont.Families[0], 28f);
            dbm1.Font = digitalFont;
            digitalFont = new Font(DigitalFont.Families[0], 28f);
            dbm2.Font = digitalFont;

            double value = 0.0;
            for (int i = 1; i <= 128; i++)
            {
                String item = String.Format("{0:D3} :   {1:F}   dBm", i, value);
                lbStc.Items.Add(item);
                value += 0.5;
            }
            lbStc.SelectedIndex = 0;
        }

        private void InitAgcGroup()
        {
            Font digitalFont;

            digitalFont = new Font(DigitalFont.Families[0], 60f);
            tbAgcSelected.Font = digitalFont;
            digitalFont = new Font(DigitalFont.Families[0], 48f);
            tbAgcManual.Font = digitalFont;
            tbAgcManual.Text = "0.00";

            digitalFont = new Font(DigitalFont.Families[0], 28f);
            dbm3.Font = digitalFont;
            digitalFont = new Font(DigitalFont.Families[0], 28f);
            dbm4.Font = digitalFont;

            double value = 0.0;
            for (int i = 1; i <= 128; i++)
            {
                String item = String.Format("{0:D3}:   {1:F}   dBm", i, value);
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
                    MessageBox.Show("연결에 실패했습니다, 다시 시도해 주세요.\n" +
                        ex.Message,
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

            if (!result)
            {
                MessageBox.Show("모드를 설정하지 못했습니다, 다시 시도해 주세요.\n" +
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

            if (!result)
            {
                MessageBox.Show("STC 값을 설정하지 못했습니다, 다시 시도해 주세요.\n" +
                    reqResult.ErrorMessage,
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSendManual_Click(object sender, EventArgs e)
        {
            double doubleValue = Convert.ToDouble(tbStcManual.Text);
            string valueError;
            if (!ValidateControlValue(doubleValue, out valueError))
            {
                MessageBox.Show("유효하지 않은 값입니다, 다시 시도해 주세요.\n" +
                    valueError,
                    Caption,
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

            if (!result)
            {
                MessageBox.Show("STC 값을 설정하지 못했습니다, 다시 시도해 주세요.\n" +
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

            if (!result)
            {
                MessageBox.Show("AGC 값을 설정하지 못했습니다, 다시 시도해 주세요.\n" +
                    reqResult.ErrorMessage,
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAgcSendManual_Click(object sender, EventArgs e)
        {
            double doubleValue = Convert.ToDouble(tbAgcManual.Text);
            string valueError;
            if (!ValidateControlValue(doubleValue, out valueError))
            {
                MessageBox.Show("유효하지 않은 값입니다, 다시 시도해 주세요.\n" +
                    valueError,
                    Caption,
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

            if (!result)
            {
                MessageBox.Show("AGC 값을 설정하지 못했습니다, 다시 시도해 주세요.\n" +
                    reqResult.ErrorMessage,
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidateControlValue(double value, out string error)
        {
            if (value < 0.0 || value > 63.5)
            {
                error = "오류: 0.0 ~ 63.5 사이의 값을 넣어 주세요.";
                return false;
            }
            if ((int)(value * 10) % 5 != 0)
            {
                error = "오류: 0.5의 배수만 입력 가능합니다.";
                return false;
            }

            error = "";
            return true;
        }

        private void UpdateLo1Status(bool isActive)
        {
            pbLo1.Image = isActive ?
                Properties.Resources.green_small : Properties.Resources.red_small;
        }

        private void UpdateLo2Status(bool isActive)
        {
            pbLo2.Image = isActive ?
                Properties.Resources.green_small : Properties.Resources.red_small;
        }

        private RequestResult GetCurrentStatus()
        {
            Request request = new Request(CommandType.StatusRequest);
            RequestResult reqResult;
            bool result = SendRequest(request, out reqResult);

            return result ? reqResult : null;
        }

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
                Thread.Sleep(StatusPollingDelay);
            }
        }

        private void PauseStatusPolling()
        {
            ConnectedEvent.Reset();
        }

        private void ResumeStatusPolling()
        {
            ConnectedEvent.Set();
        }

        private bool SendRequest(Request request, out RequestResult reqResult)
        {
            lock (RequestLock)
            {
                bool result = false;
                ResponseReceivedEvent.Reset();

                // Restore variables to default to handle the new request
                ResponseFrameBuffer = new byte[FrameConstants.MessageBufferLength];
                ResponseReceived = 0;
                ResponseFrameStarted = false;
                ResponseFrameEnded = false;

                SerialPort.DiscardOutBuffer();
                SerialPort.DiscardInBuffer();
                SerialPort.DataReceived += Port_DataReceived;

                SerialPort.Write(request.FrameBuffer, 0, request.FrameLength);

                // Block main form until it gets response
                ResponseReceivedEvent.WaitOne(ResponseTimeout);
                SerialPort.DataReceived -= Port_DataReceived;

                // Handle response if valid resonse received or
                // just return false when timed out
                if (ResponseFrameEnded)
                {
                    // Trim trailing NULLs
                    byte[] responseFrame = new byte[ResponseReceived];
                    Array.Copy(ResponseFrameBuffer, responseFrame, ResponseReceived);
                    result = request.GetResult(responseFrame, out reqResult);
                }
                else
                {
                    reqResult = new RequestResult();
                    reqResult.ErrorMessage = "오류: 응답을 받지 못했습니다";
                }
                return result;
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (SerialPort.BytesToRead > 0 && !ResponseFrameEnded)
            {
                byte read = (byte)SerialPort.ReadByte();
                if (read == FrameConstants.StartCode)
                {
                    ResponseFrameStarted = true;
                }
                else if (read == FrameConstants.EndCode)
                {
                    // Release main form when receiving response complete
                    ResponseFrameEnded = true;
                    ResponseReceivedEvent.Set();
                }
                else if (ResponseFrameStarted &&
                    ResponseReceived < FrameConstants.MessageBufferLength)
                {
                    ResponseFrameBuffer[ResponseReceived++] = read;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pbLo1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pbLo2_Click(object sender, EventArgs e)
        {

        }
    }
}
