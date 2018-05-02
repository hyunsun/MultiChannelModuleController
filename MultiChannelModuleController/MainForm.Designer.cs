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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnModeSend = new System.Windows.Forms.Button();
            this.rbHighResolution = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.pbLo2 = new System.Windows.Forms.PictureBox();
            this.pbLo1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnStcSendManual = new System.Windows.Forms.Button();
            this.dbm2 = new System.Windows.Forms.Label();
            this.btnStcSendSelected = new System.Windows.Forms.Button();
            this.tbStcManual = new System.Windows.Forms.TextBox();
            this.lbStc = new System.Windows.Forms.ListBox();
            this.dbm1 = new System.Windows.Forms.Label();
            this.tbStcSelected = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAgcSendManual = new System.Windows.Forms.Button();
            this.btnAgcSendSelected = new System.Windows.Forms.Button();
            this.dbm4 = new System.Windows.Forms.Label();
            this.tbAgcSelected = new System.Windows.Forms.TextBox();
            this.dbm3 = new System.Windows.Forms.Label();
            this.tbAgcManual = new System.Windows.Forms.TextBox();
            this.lbAgc = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerialPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLo1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbSerialPort);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cbSerialPort);
            this.groupBox1.Controls.Add(this.pbLogo);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "통신";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(483, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "통신상태";
            // 
            // pbSerialPort
            // 
            this.pbSerialPort.Image = global::MultiChannelModuleController.Properties.Resources.black;
            this.pbSerialPort.Location = new System.Drawing.Point(500, 30);
            this.pbSerialPort.Name = "pbSerialPort";
            this.pbSerialPort.Size = new System.Drawing.Size(16, 16);
            this.pbSerialPort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSerialPort.TabIndex = 4;
            this.pbSerialPort.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(541, 30);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(380, 28);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(95, 32);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(227, 30);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(147, 27);
            this.cbSerialPort.TabIndex = 1;
            this.cbSerialPort.SelectedIndexChanged += new System.EventHandler(this.cbSerialPort_SelectedIndexChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::MultiChannelModuleController.Properties.Resources.sample_logo;
            this.pbLogo.Location = new System.Drawing.Point(12, 24);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(178, 39);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(4, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(193, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "다채널 수신 모듈 V1.0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnModeSend);
            this.groupBox3.Controls.Add(this.rbHighResolution);
            this.groupBox3.Controls.Add(this.rbNormal);
            this.groupBox3.Controls.Add(this.pbLo2);
            this.groupBox3.Controls.Add(this.pbLo1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(3, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(641, 102);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "알람/모드 설정";
            // 
            // btnModeSend
            // 
            this.btnModeSend.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeSend.Location = new System.Drawing.Point(555, 32);
            this.btnModeSend.Name = "btnModeSend";
            this.btnModeSend.Size = new System.Drawing.Size(80, 57);
            this.btnModeSend.TabIndex = 14;
            this.btnModeSend.Text = "SEND";
            this.btnModeSend.UseVisualStyleBackColor = true;
            this.btnModeSend.Click += new System.EventHandler(this.btnModeSend_Click);
            // 
            // rbHighResolution
            // 
            this.rbHighResolution.AutoSize = true;
            this.rbHighResolution.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHighResolution.Location = new System.Drawing.Point(345, 62);
            this.rbHighResolution.Name = "rbHighResolution";
            this.rbHighResolution.Size = new System.Drawing.Size(138, 22);
            this.rbHighResolution.TabIndex = 12;
            this.rbHighResolution.TabStop = true;
            this.rbHighResolution.Text = "HIGH RESOLUTION";
            this.rbHighResolution.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNormal.Location = new System.Drawing.Point(345, 35);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(81, 22);
            this.rbNormal.TabIndex = 11;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "NORMAL";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // pbLo2
            // 
            this.pbLo2.Image = global::MultiChannelModuleController.Properties.Resources.black;
            this.pbLo2.Location = new System.Drawing.Point(216, 67);
            this.pbLo2.Name = "pbLo2";
            this.pbLo2.Size = new System.Drawing.Size(16, 16);
            this.pbLo2.TabIndex = 10;
            this.pbLo2.TabStop = false;
            // 
            // pbLo1
            // 
            this.pbLo1.Image = global::MultiChannelModuleController.Properties.Resources.black;
            this.pbLo1.Location = new System.Drawing.Point(72, 67);
            this.pbLo1.Name = "pbLo1";
            this.pbLo1.Size = new System.Drawing.Size(16, 16);
            this.pbLo1.TabIndex = 9;
            this.pbLo1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "LO2_BIT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "LO1_BIT";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnStcSendManual);
            this.groupBox4.Controls.Add(this.dbm2);
            this.groupBox4.Controls.Add(this.btnStcSendSelected);
            this.groupBox4.Controls.Add(this.tbStcManual);
            this.groupBox4.Controls.Add(this.lbStc);
            this.groupBox4.Controls.Add(this.dbm1);
            this.groupBox4.Controls.Add(this.tbStcSelected);
            this.groupBox4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(4, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 449);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "STC 설정";
            // 
            // btnStcSendManual
            // 
            this.btnStcSendManual.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStcSendManual.Location = new System.Drawing.Point(227, 378);
            this.btnStcSendManual.Name = "btnStcSendManual";
            this.btnStcSendManual.Size = new System.Drawing.Size(80, 57);
            this.btnStcSendManual.TabIndex = 6;
            this.btnStcSendManual.Text = "SEND";
            this.btnStcSendManual.UseVisualStyleBackColor = true;
            this.btnStcSendManual.Click += new System.EventHandler(this.btnSendManual_Click);
            // 
            // dbm2
            // 
            this.dbm2.AutoSize = true;
            this.dbm2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dbm2.Location = new System.Drawing.Point(175, 411);
            this.dbm2.Name = "dbm2";
            this.dbm2.Size = new System.Drawing.Size(51, 25);
            this.dbm2.TabIndex = 5;
            this.dbm2.Text = "dBm";
            // 
            // btnStcSendSelected
            // 
            this.btnStcSendSelected.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStcSendSelected.Location = new System.Drawing.Point(227, 93);
            this.btnStcSendSelected.Name = "btnStcSendSelected";
            this.btnStcSendSelected.Size = new System.Drawing.Size(80, 276);
            this.btnStcSendSelected.TabIndex = 4;
            this.btnStcSendSelected.Text = "SEND";
            this.btnStcSendSelected.UseVisualStyleBackColor = true;
            this.btnStcSendSelected.Click += new System.EventHandler(this.btnStcSendSelected_Click);
            // 
            // tbStcManual
            // 
            this.tbStcManual.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbStcManual.Location = new System.Drawing.Point(6, 378);
            this.tbStcManual.Name = "tbStcManual";
            this.tbStcManual.Size = new System.Drawing.Size(166, 57);
            this.tbStcManual.TabIndex = 3;
            this.tbStcManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbStcManual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStcManual_KeyPress);
            // 
            // lbStc
            // 
            this.lbStc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStc.FormattingEnabled = true;
            this.lbStc.ItemHeight = 15;
            this.lbStc.Location = new System.Drawing.Point(6, 93);
            this.lbStc.Name = "lbStc";
            this.lbStc.ScrollAlwaysVisible = true;
            this.lbStc.Size = new System.Drawing.Size(215, 274);
            this.lbStc.TabIndex = 2;
            this.lbStc.SelectedIndexChanged += new System.EventHandler(this.lbStc_SelectedIndexChanged);
            // 
            // dbm1
            // 
            this.dbm1.AutoSize = true;
            this.dbm1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dbm1.Location = new System.Drawing.Point(222, 60);
            this.dbm1.Name = "dbm1";
            this.dbm1.Size = new System.Drawing.Size(51, 25);
            this.dbm1.TabIndex = 1;
            this.dbm1.Text = "dBm";
            // 
            // tbStcSelected
            // 
            this.tbStcSelected.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbStcSelected.Location = new System.Drawing.Point(6, 28);
            this.tbStcSelected.Name = "tbStcSelected";
            this.tbStcSelected.ReadOnly = true;
            this.tbStcSelected.Size = new System.Drawing.Size(215, 57);
            this.tbStcSelected.TabIndex = 0;
            this.tbStcSelected.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAgcSendManual);
            this.groupBox5.Controls.Add(this.btnAgcSendSelected);
            this.groupBox5.Controls.Add(this.dbm4);
            this.groupBox5.Controls.Add(this.tbAgcSelected);
            this.groupBox5.Controls.Add(this.dbm3);
            this.groupBox5.Controls.Add(this.tbAgcManual);
            this.groupBox5.Controls.Add(this.lbAgc);
            this.groupBox5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(327, 245);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(317, 449);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "AGC 설정";
            // 
            // btnAgcSendManual
            // 
            this.btnAgcSendManual.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgcSendManual.Location = new System.Drawing.Point(231, 379);
            this.btnAgcSendManual.Name = "btnAgcSendManual";
            this.btnAgcSendManual.Size = new System.Drawing.Size(80, 57);
            this.btnAgcSendManual.TabIndex = 13;
            this.btnAgcSendManual.Text = "SEND";
            this.btnAgcSendManual.UseVisualStyleBackColor = true;
            this.btnAgcSendManual.Click += new System.EventHandler(this.btnAgcSendManual_Click);
            // 
            // btnAgcSendSelected
            // 
            this.btnAgcSendSelected.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgcSendSelected.Location = new System.Drawing.Point(231, 94);
            this.btnAgcSendSelected.Name = "btnAgcSendSelected";
            this.btnAgcSendSelected.Size = new System.Drawing.Size(80, 276);
            this.btnAgcSendSelected.TabIndex = 11;
            this.btnAgcSendSelected.Text = "SEND";
            this.btnAgcSendSelected.UseVisualStyleBackColor = true;
            this.btnAgcSendSelected.Click += new System.EventHandler(this.btnAgcSendSelected_Click);
            // 
            // dbm4
            // 
            this.dbm4.AutoSize = true;
            this.dbm4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dbm4.Location = new System.Drawing.Point(179, 412);
            this.dbm4.Name = "dbm4";
            this.dbm4.Size = new System.Drawing.Size(51, 25);
            this.dbm4.TabIndex = 12;
            this.dbm4.Text = "dBm";
            // 
            // tbAgcSelected
            // 
            this.tbAgcSelected.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAgcSelected.Location = new System.Drawing.Point(10, 29);
            this.tbAgcSelected.Name = "tbAgcSelected";
            this.tbAgcSelected.ReadOnly = true;
            this.tbAgcSelected.Size = new System.Drawing.Size(215, 57);
            this.tbAgcSelected.TabIndex = 7;
            this.tbAgcSelected.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dbm3
            // 
            this.dbm3.AutoSize = true;
            this.dbm3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dbm3.Location = new System.Drawing.Point(226, 61);
            this.dbm3.Name = "dbm3";
            this.dbm3.Size = new System.Drawing.Size(51, 25);
            this.dbm3.TabIndex = 8;
            this.dbm3.Text = "dBm";
            // 
            // tbAgcManual
            // 
            this.tbAgcManual.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAgcManual.Location = new System.Drawing.Point(10, 379);
            this.tbAgcManual.Name = "tbAgcManual";
            this.tbAgcManual.Size = new System.Drawing.Size(166, 57);
            this.tbAgcManual.TabIndex = 10;
            this.tbAgcManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAgcManual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAgcManual_KeyPress);
            // 
            // lbAgc
            // 
            this.lbAgc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgc.FormattingEnabled = true;
            this.lbAgc.ItemHeight = 15;
            this.lbAgc.Location = new System.Drawing.Point(10, 94);
            this.lbAgc.Name = "lbAgc";
            this.lbAgc.ScrollAlwaysVisible = true;
            this.lbAgc.Size = new System.Drawing.Size(215, 274);
            this.lbAgc.TabIndex = 9;
            this.lbAgc.SelectedIndexChanged += new System.EventHandler(this.lbAgc_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 704);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "다채널 수신 모듈";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerialPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLo1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.PictureBox pbLogo;
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
        private System.Windows.Forms.Button btnModeSend;
        private System.Windows.Forms.RadioButton rbHighResolution;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.PictureBox pbLo2;
        private System.Windows.Forms.PictureBox pbLo1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}

