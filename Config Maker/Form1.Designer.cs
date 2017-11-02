namespace AC_Config_Maker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.foldersRTB = new System.Windows.Forms.RichTextBox();
            this.GoBtn = new System.Windows.Forms.Button();
            this.outputFolderBrowseBtn = new System.Windows.Forms.Button();
            this.outputFolderTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.irCodesFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.logBtn = new System.Windows.Forms.LinkLabel();
            this.navigationBtn = new System.Windows.Forms.Button();
            this.numbersBtn = new System.Windows.Forms.Button();
            this.colorsBrn = new System.Windows.Forms.Button();
            this.channelBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.volumeBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxDegreeDUD = new System.Windows.Forms.DomainUpDown();
            this.minDegreeDUD = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.windCB = new System.Windows.Forms.CheckBox();
            this.hotCB = new System.Windows.Forms.CheckBox();
            this.coldCB = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fanSpeedTB = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.degreeTypeCB = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fanSpeedTB)).BeginInit();
            this.SuspendLayout();
            // 
            // foldersRTB
            // 
            this.foldersRTB.AllowDrop = true;
            this.foldersRTB.EnableAutoDragDrop = true;
            this.foldersRTB.Font = new System.Drawing.Font("Consolas", 13F);
            this.foldersRTB.Location = new System.Drawing.Point(15, 18);
            this.foldersRTB.Name = "foldersRTB";
            this.foldersRTB.Size = new System.Drawing.Size(343, 148);
            this.foldersRTB.TabIndex = 1;
            this.foldersRTB.Text = "";
            this.foldersRTB.TextChanged += new System.EventHandler(this.foldersRTB_TextChanged);
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(251, 419);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(107, 55);
            this.GoBtn.TabIndex = 7;
            this.GoBtn.Text = "Go";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // outputFolderBrowseBtn
            // 
            this.outputFolderBrowseBtn.Location = new System.Drawing.Point(433, 380);
            this.outputFolderBrowseBtn.Name = "outputFolderBrowseBtn";
            this.outputFolderBrowseBtn.Size = new System.Drawing.Size(79, 25);
            this.outputFolderBrowseBtn.TabIndex = 12;
            this.outputFolderBrowseBtn.Text = "Browse...";
            this.outputFolderBrowseBtn.UseVisualStyleBackColor = true;
            this.outputFolderBrowseBtn.Click += new System.EventHandler(this.outputFolderBrowseBtn_Click);
            // 
            // outputFolderTB
            // 
            this.outputFolderTB.AllowDrop = true;
            this.outputFolderTB.Location = new System.Drawing.Point(156, 382);
            this.outputFolderTB.Name = "outputFolderTB";
            this.outputFolderTB.Size = new System.Drawing.Size(271, 20);
            this.outputFolderTB.TabIndex = 11;
            this.outputFolderTB.TextChanged += new System.EventHandler(this.outputFolderTB_TextChanged);
            this.outputFolderTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.IrCodesPathDropHandler);
            this.outputFolderTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterHandler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Output Folder";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // outputFolderDialog
            // 
            this.outputFolderDialog.HelpRequest += new System.EventHandler(this.outputFolderDialog_HelpRequest);
            // 
            // logBtn
            // 
            this.logBtn.AutoSize = true;
            this.logBtn.Location = new System.Drawing.Point(548, 461);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(29, 13);
            this.logBtn.TabIndex = 19;
            this.logBtn.TabStop = true;
            this.logBtn.Text = "LOG";
            this.logBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logBtn_LinkClicked);
            // 
            // navigationBtn
            // 
            this.navigationBtn.Location = new System.Drawing.Point(17, 118);
            this.navigationBtn.Name = "navigationBtn";
            this.navigationBtn.Size = new System.Drawing.Size(75, 32);
            this.navigationBtn.TabIndex = 20;
            this.navigationBtn.Text = "Temp Up";
            this.navigationBtn.UseVisualStyleBackColor = true;
            this.navigationBtn.Click += new System.EventHandler(this.navigationBtn_Click);
            // 
            // numbersBtn
            // 
            this.numbersBtn.Location = new System.Drawing.Point(67, 219);
            this.numbersBtn.Name = "numbersBtn";
            this.numbersBtn.Size = new System.Drawing.Size(75, 30);
            this.numbersBtn.TabIndex = 21;
            this.numbersBtn.Text = "Swing";
            this.numbersBtn.UseVisualStyleBackColor = true;
            this.numbersBtn.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // colorsBrn
            // 
            this.colorsBrn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.colorsBrn.ForeColor = System.Drawing.Color.Transparent;
            this.colorsBrn.Location = new System.Drawing.Point(74, 68);
            this.colorsBrn.Name = "colorsBrn";
            this.colorsBrn.Size = new System.Drawing.Size(63, 37);
            this.colorsBrn.TabIndex = 22;
            this.colorsBrn.Text = "Mode";
            this.colorsBrn.UseVisualStyleBackColor = false;
            this.colorsBrn.Click += new System.EventHandler(this.colorsBrn_Click);
            // 
            // channelBtn
            // 
            this.channelBtn.Location = new System.Drawing.Point(120, 118);
            this.channelBtn.Name = "channelBtn";
            this.channelBtn.Size = new System.Drawing.Size(75, 32);
            this.channelBtn.TabIndex = 23;
            this.channelBtn.Text = "Temp Down";
            this.channelBtn.UseVisualStyleBackColor = true;
            this.channelBtn.Click += new System.EventHandler(this.channelBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 24;
            this.button2.Text = "Fan Speed";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // volumeBtn
            // 
            this.volumeBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.volumeBtn.BackColor = System.Drawing.Color.Red;
            this.volumeBtn.Location = new System.Drawing.Point(17, 23);
            this.volumeBtn.Name = "volumeBtn";
            this.volumeBtn.Size = new System.Drawing.Size(60, 36);
            this.volumeBtn.TabIndex = 25;
            this.volumeBtn.Text = "Power";
            this.volumeBtn.UseVisualStyleBackColor = false;
            this.volumeBtn.Click += new System.EventHandler(this.volumeBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numbersBtn);
            this.groupBox2.Controls.Add(this.volumeBtn);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.colorsBrn);
            this.groupBox2.Controls.Add(this.channelBtn);
            this.groupBox2.Controls.Add(this.navigationBtn);
            this.groupBox2.Location = new System.Drawing.Point(364, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 266);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.degreeTypeCB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.maxDegreeDUD);
            this.groupBox1.Controls.Add(this.minDegreeDUD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 106);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Degrees";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maxDegreeDUD
            // 
            this.maxDegreeDUD.Items.Add("35");
            this.maxDegreeDUD.Items.Add("34");
            this.maxDegreeDUD.Items.Add("33");
            this.maxDegreeDUD.Items.Add("32");
            this.maxDegreeDUD.Items.Add("31");
            this.maxDegreeDUD.Items.Add("30");
            this.maxDegreeDUD.Items.Add("29");
            this.maxDegreeDUD.Items.Add("28");
            this.maxDegreeDUD.Items.Add("27");
            this.maxDegreeDUD.Items.Add("26");
            this.maxDegreeDUD.Items.Add("25");
            this.maxDegreeDUD.Items.Add("24");
            this.maxDegreeDUD.Items.Add("23");
            this.maxDegreeDUD.Items.Add("22");
            this.maxDegreeDUD.Items.Add("21");
            this.maxDegreeDUD.Items.Add("20");
            this.maxDegreeDUD.Items.Add("19");
            this.maxDegreeDUD.Items.Add("18");
            this.maxDegreeDUD.Items.Add("17");
            this.maxDegreeDUD.Items.Add("16");
            this.maxDegreeDUD.Items.Add("15");
            this.maxDegreeDUD.Items.Add("14");
            this.maxDegreeDUD.Items.Add("13");
            this.maxDegreeDUD.Items.Add("12");
            this.maxDegreeDUD.Items.Add("11");
            this.maxDegreeDUD.Items.Add("10");
            this.maxDegreeDUD.Items.Add("9");
            this.maxDegreeDUD.Items.Add("8");
            this.maxDegreeDUD.Items.Add("7");
            this.maxDegreeDUD.Items.Add("6");
            this.maxDegreeDUD.Items.Add("5");
            this.maxDegreeDUD.Items.Add("4");
            this.maxDegreeDUD.Items.Add("3");
            this.maxDegreeDUD.Items.Add("2");
            this.maxDegreeDUD.Items.Add("1");
            this.maxDegreeDUD.Location = new System.Drawing.Point(141, 70);
            this.maxDegreeDUD.Name = "maxDegreeDUD";
            this.maxDegreeDUD.Size = new System.Drawing.Size(40, 20);
            this.maxDegreeDUD.TabIndex = 3;
            this.maxDegreeDUD.Text = "31";
            // 
            // minDegreeDUD
            // 
            this.minDegreeDUD.Items.Add("35");
            this.minDegreeDUD.Items.Add("34");
            this.minDegreeDUD.Items.Add("33");
            this.minDegreeDUD.Items.Add("32");
            this.minDegreeDUD.Items.Add("31");
            this.minDegreeDUD.Items.Add("30");
            this.minDegreeDUD.Items.Add("29");
            this.minDegreeDUD.Items.Add("28");
            this.minDegreeDUD.Items.Add("27");
            this.minDegreeDUD.Items.Add("26");
            this.minDegreeDUD.Items.Add("25");
            this.minDegreeDUD.Items.Add("24");
            this.minDegreeDUD.Items.Add("23");
            this.minDegreeDUD.Items.Add("22");
            this.minDegreeDUD.Items.Add("21");
            this.minDegreeDUD.Items.Add("20");
            this.minDegreeDUD.Items.Add("19");
            this.minDegreeDUD.Items.Add("18");
            this.minDegreeDUD.Items.Add("17");
            this.minDegreeDUD.Items.Add("16");
            this.minDegreeDUD.Items.Add("15");
            this.minDegreeDUD.Items.Add("14");
            this.minDegreeDUD.Items.Add("13");
            this.minDegreeDUD.Items.Add("12");
            this.minDegreeDUD.Items.Add("11");
            this.minDegreeDUD.Items.Add("10");
            this.minDegreeDUD.Items.Add("9");
            this.minDegreeDUD.Items.Add("8");
            this.minDegreeDUD.Items.Add("7");
            this.minDegreeDUD.Items.Add("6");
            this.minDegreeDUD.Items.Add("5");
            this.minDegreeDUD.Items.Add("4");
            this.minDegreeDUD.Items.Add("3");
            this.minDegreeDUD.Items.Add("2");
            this.minDegreeDUD.Items.Add("1");
            this.minDegreeDUD.Location = new System.Drawing.Point(141, 33);
            this.minDegreeDUD.Name = "minDegreeDUD";
            this.minDegreeDUD.Size = new System.Drawing.Size(40, 20);
            this.minDegreeDUD.TabIndex = 2;
            this.minDegreeDUD.Text = "16";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.windCB);
            this.groupBox3.Controls.Add(this.hotCB);
            this.groupBox3.Controls.Add(this.coldCB);
            this.groupBox3.Location = new System.Drawing.Point(15, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 75);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modes";
            // 
            // windCB
            // 
            this.windCB.AutoSize = true;
            this.windCB.Checked = true;
            this.windCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.windCB.Location = new System.Drawing.Point(216, 32);
            this.windCB.Name = "windCB";
            this.windCB.Size = new System.Drawing.Size(51, 17);
            this.windCB.TabIndex = 2;
            this.windCB.Text = "Wind";
            this.windCB.UseVisualStyleBackColor = true;
            // 
            // hotCB
            // 
            this.hotCB.AutoSize = true;
            this.hotCB.Checked = true;
            this.hotCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hotCB.Location = new System.Drawing.Point(152, 32);
            this.hotCB.Name = "hotCB";
            this.hotCB.Size = new System.Drawing.Size(43, 17);
            this.hotCB.TabIndex = 1;
            this.hotCB.Text = "Hot";
            this.hotCB.UseVisualStyleBackColor = true;
            // 
            // coldCB
            // 
            this.coldCB.AutoSize = true;
            this.coldCB.Checked = true;
            this.coldCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.coldCB.Location = new System.Drawing.Point(83, 32);
            this.coldCB.Name = "coldCB";
            this.coldCB.Size = new System.Drawing.Size(47, 17);
            this.coldCB.TabIndex = 0;
            this.coldCB.Text = "Cold";
            this.coldCB.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fanSpeedTB);
            this.groupBox4.Location = new System.Drawing.Point(364, 289);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 73);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fan Speed Max";
            // 
            // fanSpeedTB
            // 
            this.fanSpeedTB.LargeChange = 1;
            this.fanSpeedTB.Location = new System.Drawing.Point(24, 19);
            this.fanSpeedTB.Maximum = 4;
            this.fanSpeedTB.Minimum = 1;
            this.fanSpeedTB.Name = "fanSpeedTB";
            this.fanSpeedTB.Size = new System.Drawing.Size(168, 45);
            this.fanSpeedTB.TabIndex = 0;
            this.fanSpeedTB.Value = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type";
            // 
            // degreeTypeCB
            // 
            this.degreeTypeCB.DisplayMember = "C";
            this.degreeTypeCB.FormattingEnabled = true;
            this.degreeTypeCB.Items.AddRange(new object[] {"C","F"});
            this.degreeTypeCB.SelectedIndex = 0;
            this.degreeTypeCB.Location = new System.Drawing.Point(255, 51);
            this.degreeTypeCB.Name = "degreeTypeCB";
            this.degreeTypeCB.Size = new System.Drawing.Size(46, 21);
            this.degreeTypeCB.TabIndex = 0;
            this.degreeTypeCB.ValueMember = "C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 490);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.outputFolderBrowseBtn);
            this.Controls.Add(this.outputFolderTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.foldersRTB);
            this.Name = "Form1";
            this.Text = "AC Config Maker";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fanSpeedTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox foldersRTB;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.Button outputFolderBrowseBtn;
        private System.Windows.Forms.TextBox outputFolderTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog irCodesFileDialog;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;
        private System.Windows.Forms.LinkLabel logBtn;
        private System.Windows.Forms.Button navigationBtn;
        private System.Windows.Forms.Button numbersBtn;
        private System.Windows.Forms.Button colorsBrn;
        private System.Windows.Forms.Button channelBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button volumeBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DomainUpDown maxDegreeDUD;
        private System.Windows.Forms.DomainUpDown minDegreeDUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox windCB;
        private System.Windows.Forms.CheckBox hotCB;
        private System.Windows.Forms.CheckBox coldCB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar fanSpeedTB;
        private System.Windows.Forms.ComboBox degreeTypeCB;
        private System.Windows.Forms.Label label4;
    }
}

