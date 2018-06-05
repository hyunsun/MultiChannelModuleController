namespace MultiChannelModuleController
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSerialPort = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnStcSendSelected = new System.Windows.Forms.Button();
            this.lbStc = new System.Windows.Forms.ListBox();
            this.dbm1 = new System.Windows.Forms.Label();
            this.tbStcSelected = new System.Windows.Forms.TextBox();
            this.btnStcSendManual = new System.Windows.Forms.Button();
            this.dbm2 = new System.Windows.Forms.Label();
            this.tbStcManual = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAgcSendSelected = new System.Windows.Forms.Button();
            this.tbAgcSelected = new System.Windows.Forms.TextBox();
            this.dbm3 = new System.Windows.Forms.Label();
            this.lbAgc = new System.Windows.Forms.ListBox();
            this.btnAgcSendManual = new System.Windows.Forms.Button();
            this.dbm4 = new System.Windows.Forms.Label();
            this.tbAgcManual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbLo1 = new System.Windows.Forms.PictureBox();
            this.pbLo2 = new System.Windows.Forms.PictureBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbHighResolution = new System.Windows.Forms.RadioButton();
            this.btnModeSend = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerialPort)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLo2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbSerialPort);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cbSerialPort);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(346, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "통신";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(411, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "통신상태";
            // 
            // pbSerialPort
            // 
            this.pbSerialPort.Image = global::MultiChannelModuleController.Properties.Resources.black;
            this.pbSerialPort.InitialImage = null;
            this.pbSerialPort.Location = new System.Drawing.Point(428, 28);
            this.pbSerialPort.Name = "pbSerialPort";
            this.pbSerialPort.Size = new System.Drawing.Size(32, 32);
            this.pbSerialPort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSerialPort.TabIndex = 4;
            this.pbSerialPort.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(486, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 48);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(282, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(123, 49);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "OPEN";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(21, 30);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(242, 44);
            this.cbSerialPort.TabIndex = 1;
            this.cbSerialPort.SelectedIndexChanged += new System.EventHandler(this.cbSerialPort_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(22, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "다채널 수신 모듈 V1.0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnStcSendSelected);
            this.groupBox4.Controls.Add(this.lbStc);
            this.groupBox4.Controls.Add(this.dbm1);
            this.groupBox4.Controls.Add(this.tbStcSelected);
            this.groupBox4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(19, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(460, 473);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "STC 설정";
            // 
            // btnStcSendSelected
            // 
            this.btnStcSendSelected.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStcSendSelected.Location = new System.Drawing.Point(332, 40);
            this.btnStcSendSelected.Name = "btnStcSendSelected";
            this.btnStcSendSelected.Size = new System.Drawing.Size(121, 90);
            this.btnStcSendSelected.TabIndex = 4;
            this.btnStcSendSelected.Text = "SEND";
            this.btnStcSendSelected.UseVisualStyleBackColor = true;
            this.btnStcSendSelected.Click += new System.EventHandler(this.btnStcSendSelected_Click);
            // 
            // lbStc
            // 
            this.lbStc.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStc.FormattingEnabled = true;
            this.lbStc.ItemHeight = 24;
            this.lbStc.Location = new System.Drawing.Point(10, 142);
            this.lbStc.Name = "lbStc";
            this.lbStc.ScrollAlwaysVisible = true;
            this.lbStc.Size = new System.Drawing.Size(305, 316);
            this.lbStc.TabIndex = 2;
            this.lbStc.SelectedIndexChanged += new System.EventHandler(this.lbStc_SelectedIndexChanged);
            // 
            // dbm1
            // 
            this.dbm1.AutoSize = true;
            this.dbm1.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dbm1.Location = new System.Drawing.Point(240, 85);
            this.dbm1.Name = "dbm1";
            this.dbm1.Size = new System.Drawing.Size(86, 45);
            this.dbm1.TabIndex = 1;
            this.dbm1.Text = "dBm";
            // 
            // tbStcSelected
            // 
            this.tbStcSelected.Font = new System.Drawing.Font("맑은 고딕", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbStcSelected.Location = new System.Drawing.Point(10, 40);
            this.tbStcSelected.Multiline = true;
            this.tbStcSelected.Name = "tbStcSelected";
            this.tbStcSelected.ReadOnly = true;
            this.tbStcSelected.Size = new System.Drawing.Size(225, 90);
            this.tbStcSelected.TabIndex = 0;
            this.tbStcSelected.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnStcSendManual
            // 
            this.btnStcSendManual.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStcSendManual.Location = new System.Drawing.Point(332, 40);
            this.btnStcSendManual.Name = "btnStcSendManual";
            this.btnStcSendManual.Size = new System.Drawing.Size(121, 90);
            this.btnStcSendManual.TabIndex = 6;
            this.btnStcSendManual.Text = "SEND";
            this.btnStcSendManual.UseVisualStyleBackColor = true;
            this.btnStcSendManual.Click += new System.EventHandler(this.btnSendManual_Click);
            // 
            // dbm2
            // 
            this.dbm2.AutoSize = true;
            this.dbm2.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dbm2.Location = new System.Drawing.Point(240, 85);
            this.dbm2.Name = "dbm2";
            this.dbm2.Size = new System.Drawing.Size(86, 45);
            this.dbm2.TabIndex = 5;
            this.dbm2.Text = "dBm";
            // 
            // tbStcManual
            // 
            this.tbStcManual.Font = new System.Drawing.Font("맑은 고딕", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbStcManual.Location = new System.Drawing.Point(10, 40);
            this.tbStcManual.Multiline = true;
            this.tbStcManual.Name = "tbStcManual";
            this.tbStcManual.Size = new System.Drawing.Size(225, 90);
            this.tbStcManual.TabIndex = 3;
            this.tbStcManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbStcManual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStcManual_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAgcSendSelected);
            this.groupBox5.Controls.Add(this.tbAgcSelected);
            this.groupBox5.Controls.Add(this.dbm3);
            this.groupBox5.Controls.Add(this.lbAgc);
            this.groupBox5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(499, 211);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(460, 473);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "AGC 설정";
            // 
            // btnAgcSendSelected
            // 
            this.btnAgcSendSelected.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgcSendSelected.Location = new System.Drawing.Point(332, 40);
            this.btnAgcSendSelected.Name = "btnAgcSendSelected";
            this.btnAgcSendSelected.Size = new System.Drawing.Size(122, 90);
            this.btnAgcSendSelected.TabIndex = 11;
            this.btnAgcSendSelected.Text = "SEND";
            this.btnAgcSendSelected.UseVisualStyleBackColor = true;
            this.btnAgcSendSelected.Click += new System.EventHandler(this.btnAgcSendSelected_Click);
            // 
            // tbAgcSelected
            // 
            this.tbAgcSelected.Font = new System.Drawing.Font("맑은 고딕", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAgcSelected.Location = new System.Drawing.Point(10, 40);
            this.tbAgcSelected.Multiline = true;
            this.tbAgcSelected.Name = "tbAgcSelected";
            this.tbAgcSelected.ReadOnly = true;
            this.tbAgcSelected.Size = new System.Drawing.Size(225, 90);
            this.tbAgcSelected.TabIndex = 7;
            this.tbAgcSelected.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dbm3
            // 
            this.dbm3.AutoSize = true;
            this.dbm3.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dbm3.Location = new System.Drawing.Point(240, 85);
            this.dbm3.Name = "dbm3";
            this.dbm3.Size = new System.Drawing.Size(86, 45);
            this.dbm3.TabIndex = 8;
            this.dbm3.Text = "dBm";
            // 
            // lbAgc
            // 
            this.lbAgc.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgc.FormattingEnabled = true;
            this.lbAgc.ItemHeight = 24;
            this.lbAgc.Location = new System.Drawing.Point(10, 142);
            this.lbAgc.Name = "lbAgc";
            this.lbAgc.ScrollAlwaysVisible = true;
            this.lbAgc.Size = new System.Drawing.Size(305, 316);
            this.lbAgc.TabIndex = 9;
            this.lbAgc.SelectedIndexChanged += new System.EventHandler(this.lbAgc_SelectedIndexChanged);
            // 
            // btnAgcSendManual
            // 
            this.btnAgcSendManual.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgcSendManual.Location = new System.Drawing.Point(332, 40);
            this.btnAgcSendManual.Name = "btnAgcSendManual";
            this.btnAgcSendManual.Size = new System.Drawing.Size(121, 90);
            this.btnAgcSendManual.TabIndex = 13;
            this.btnAgcSendManual.Text = "SEND";
            this.btnAgcSendManual.UseVisualStyleBackColor = true;
            this.btnAgcSendManual.Click += new System.EventHandler(this.btnAgcSendManual_Click);
            // 
            // dbm4
            // 
            this.dbm4.AutoSize = true;
            this.dbm4.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dbm4.Location = new System.Drawing.Point(240, 85);
            this.dbm4.Name = "dbm4";
            this.dbm4.Size = new System.Drawing.Size(86, 45);
            this.dbm4.TabIndex = 12;
            this.dbm4.Text = "dBm";
            // 
            // tbAgcManual
            // 
            this.tbAgcManual.Font = new System.Drawing.Font("맑은 고딕", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAgcManual.Location = new System.Drawing.Point(10, 40);
            this.tbAgcManual.Multiline = true;
            this.tbAgcManual.Name = "tbAgcManual";
            this.tbAgcManual.Size = new System.Drawing.Size(225, 90);
            this.tbAgcManual.TabIndex = 10;
            this.tbAgcManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAgcManual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAgcManual_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "LO1_BIT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "LO2_BIT";
            // 
            // pbLo1
            // 
            this.pbLo1.Image = global::MultiChannelModuleController.Properties.Resources.black_small;
            this.pbLo1.Location = new System.Drawing.Point(153, 70);
            this.pbLo1.Name = "pbLo1";
            this.pbLo1.Size = new System.Drawing.Size(16, 16);
            this.pbLo1.TabIndex = 9;
            this.pbLo1.TabStop = false;
            // 
            // pbLo2
            // 
            this.pbLo2.Image = global::MultiChannelModuleController.Properties.Resources.black_small;
            this.pbLo2.Location = new System.Drawing.Point(298, 70);
            this.pbLo2.Name = "pbLo2";
            this.pbLo2.Size = new System.Drawing.Size(16, 16);
            this.pbLo2.TabIndex = 10;
            this.pbLo2.TabStop = false;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNormal.Location = new System.Drawing.Point(26, 29);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(108, 30);
            this.rbNormal.TabIndex = 11;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "NORMAL";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbHighResolution
            // 
            this.rbHighResolution.AutoSize = true;
            this.rbHighResolution.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHighResolution.Location = new System.Drawing.Point(26, 60);
            this.rbHighResolution.Name = "rbHighResolution";
            this.rbHighResolution.Size = new System.Drawing.Size(189, 30);
            this.rbHighResolution.TabIndex = 12;
            this.rbHighResolution.TabStop = true;
            this.rbHighResolution.Text = "HIGH RESOLUTION";
            this.rbHighResolution.UseVisualStyleBackColor = true;
            // 
            // btnModeSend
            // 
            this.btnModeSend.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeSend.Location = new System.Drawing.Point(332, 32);
            this.btnModeSend.Name = "btnModeSend";
            this.btnModeSend.Size = new System.Drawing.Size(121, 48);
            this.btnModeSend.TabIndex = 14;
            this.btnModeSend.Text = "SEND";
            this.btnModeSend.UseVisualStyleBackColor = true;
            this.btnModeSend.Click += new System.EventHandler(this.btnModeSend_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbLo2);
            this.groupBox3.Controls.Add(this.pbLo1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(19, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 99);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "알람";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbHighResolution);
            this.groupBox2.Controls.Add(this.btnModeSend);
            this.groupBox2.Controls.Add(this.rbNormal);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(499, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 98);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "모드 설정";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnStcSendManual);
            this.groupBox6.Controls.Add(this.tbStcManual);
            this.groupBox6.Controls.Add(this.dbm2);
            this.groupBox6.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.Location = new System.Drawing.Point(19, 692);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(460, 143);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "STC 설정값 수동 입력";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnAgcSendManual);
            this.groupBox7.Controls.Add(this.tbAgcManual);
            this.groupBox7.Controls.Add(this.dbm4);
            this.groupBox7.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox7.Location = new System.Drawing.Point(499, 692);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(460, 143);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "AGC 설정값 수동 입력";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 859);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "다채널 수신 모듈";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerialPort)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLo2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnStcSendManual;
        private System.Windows.Forms.Label dbm2;
        private System.Windows.Forms.Button btnStcSendSelected;
        private System.Windows.Forms.TextBox tbStcManual;
        private System.Windows.Forms.ListBox lbStc;
        private System.Windows.Forms.Label dbm1;
        private System.Windows.Forms.TextBox tbStcSelected;
        private System.Windows.Forms.Button btnAgcSendManual;
        private System.Windows.Forms.Button btnAgcSendSelected;
        private System.Windows.Forms.Label dbm4;
        private System.Windows.Forms.TextBox tbAgcSelected;
        private System.Windows.Forms.Label dbm3;
        private System.Windows.Forms.TextBox tbAgcManual;
        private System.Windows.Forms.ListBox lbAgc;
        private System.Windows.Forms.PictureBox pbSerialPort;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbLo1;
        private System.Windows.Forms.PictureBox pbLo2;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbHighResolution;
        private System.Windows.Forms.Button btnModeSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

