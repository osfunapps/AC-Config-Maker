using System.Windows.Forms;

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
            this.tempUpBtn = new System.Windows.Forms.Button();
            this.swingBtn = new System.Windows.Forms.Button();
            this.modesBtn = new System.Windows.Forms.Button();
            this.tempDownBtn = new System.Windows.Forms.Button();
            this.fanSpeedBtn = new System.Windows.Forms.Button();
            this.powerBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.acDisplayCB = new System.Windows.Forms.CheckBox();
            this.degreesGB = new System.Windows.Forms.GroupBox();
            this.degreeTypeCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maxDegreeDUD = new System.Windows.Forms.DomainUpDown();
            this.minDegreeDUD = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modesGB = new System.Windows.Forms.GroupBox();
            this.aiCB = new System.Windows.Forms.CheckBox();
            this.windCB = new System.Windows.Forms.CheckBox();
            this.hotCB = new System.Windows.Forms.CheckBox();
            this.coldCB = new System.Windows.Forms.CheckBox();
            this.fanSpeedGB = new System.Windows.Forms.GroupBox();
            this.fanSpeedTB = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.degreesGB.SuspendLayout();
            this.modesGB.SuspendLayout();
            this.fanSpeedGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fanSpeedTB)).BeginInit();
            this.SuspendLayout();
            // 
            // foldersRTB
            // 
            this.foldersRTB.AllowDrop = true;
            this.foldersRTB.EnableAutoDragDrop = true;
            this.foldersRTB.Font = new System.Drawing.Font("Consolas", 9F);
            this.foldersRTB.Location = new System.Drawing.Point(15, 18);
            this.foldersRTB.Name = "foldersRTB";
            this.foldersRTB.Size = new System.Drawing.Size(343, 148);
            this.foldersRTB.TabIndex = 1;
            this.foldersRTB.Text = "";
            this.foldersRTB.TextChanged += new System.EventHandler(this.foldersRTB_TextChanged);
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(251, 437);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(107, 55);
            this.GoBtn.TabIndex = 7;
            this.GoBtn.Text = "Go";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // outputFolderBrowseBtn
            // 
            this.outputFolderBrowseBtn.Location = new System.Drawing.Point(433, 398);
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
            this.outputFolderTB.Location = new System.Drawing.Point(156, 400);
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
            this.label2.Location = new System.Drawing.Point(77, 402);
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
            this.logBtn.Location = new System.Drawing.Point(548, 479);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(29, 13);
            this.logBtn.TabIndex = 19;
            this.logBtn.TabStop = true;
            this.logBtn.Text = "LOG";
            this.logBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logBtn_LinkClicked);
            // 
            // tempUpBtn
            // 
            this.tempUpBtn.Location = new System.Drawing.Point(120, 156);
            this.tempUpBtn.Name = "tempUpBtn";
            this.tempUpBtn.Size = new System.Drawing.Size(75, 32);
            this.tempUpBtn.TabIndex = 20;
            this.tempUpBtn.Text = "Temp Up";
            this.tempUpBtn.UseVisualStyleBackColor = true;
            this.tempUpBtn.Click += new System.EventHandler(this.TempUpBtn_Click);
            // 
            // swingBtn
            // 
            this.swingBtn.Location = new System.Drawing.Point(120, 209);
            this.swingBtn.Name = "swingBtn";
            this.swingBtn.Size = new System.Drawing.Size(75, 30);
            this.swingBtn.TabIndex = 21;
            this.swingBtn.Text = "Swing";
            this.swingBtn.UseVisualStyleBackColor = true;
            this.swingBtn.Click += new System.EventHandler(this.Swing_Click);
            // 
            // modesBtn
            // 
            this.modesBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.modesBtn.ForeColor = System.Drawing.Color.Transparent;
            this.modesBtn.Location = new System.Drawing.Point(74, 110);
            this.modesBtn.Name = "modesBtn";
            this.modesBtn.Size = new System.Drawing.Size(63, 37);
            this.modesBtn.TabIndex = 22;
            this.modesBtn.Text = "Mode";
            this.modesBtn.UseVisualStyleBackColor = false;
            this.modesBtn.Click += new System.EventHandler(this.modesBtn_Click);
            // 
            // tempDownBtn
            // 
            this.tempDownBtn.Location = new System.Drawing.Point(17, 156);
            this.tempDownBtn.Name = "tempDownBtn";
            this.tempDownBtn.Size = new System.Drawing.Size(75, 32);
            this.tempDownBtn.TabIndex = 23;
            this.tempDownBtn.Text = "Temp Down";
            this.tempDownBtn.UseVisualStyleBackColor = true;
            this.tempDownBtn.Click += new System.EventHandler(this.TempDownBtn_Click);
            // 
            // fanSpeedBtn
            // 
            this.fanSpeedBtn.Location = new System.Drawing.Point(17, 205);
            this.fanSpeedBtn.Name = "fanSpeedBtn";
            this.fanSpeedBtn.Size = new System.Drawing.Size(75, 47);
            this.fanSpeedBtn.TabIndex = 24;
            this.fanSpeedBtn.Text = "Fan Speed";
            this.fanSpeedBtn.UseVisualStyleBackColor = true;
            this.fanSpeedBtn.Click += new System.EventHandler(this.FanSpeed_Click);
            // 
            // powerBtn
            // 
            this.powerBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.powerBtn.BackColor = System.Drawing.Color.Red;
            this.powerBtn.Location = new System.Drawing.Point(17, 68);
            this.powerBtn.Name = "powerBtn";
            this.powerBtn.Size = new System.Drawing.Size(60, 36);
            this.powerBtn.TabIndex = 25;
            this.powerBtn.Text = "Power";
            this.powerBtn.UseVisualStyleBackColor = false;
            this.powerBtn.Click += new System.EventHandler(this.PowerBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.swingBtn);
            this.groupBox2.Controls.Add(this.powerBtn);
            this.groupBox2.Controls.Add(this.fanSpeedBtn);
            this.groupBox2.Controls.Add(this.modesBtn);
            this.groupBox2.Controls.Add(this.tempDownBtn);
            this.groupBox2.Controls.Add(this.tempUpBtn);
            this.groupBox2.Location = new System.Drawing.Point(364, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 266);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.acDisplayCB);
            this.panel1.Location = new System.Drawing.Point(42, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 42);
            this.panel1.TabIndex = 26;
            // 
            // acDisplayCB
            // 
            this.acDisplayCB.AutoSize = true;
            this.acDisplayCB.Checked = true;
            this.acDisplayCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.acDisplayCB.Location = new System.Drawing.Point(40, 10);
            this.acDisplayCB.Name = "acDisplayCB";
            this.acDisplayCB.Size = new System.Drawing.Size(60, 17);
            this.acDisplayCB.TabIndex = 3;
            this.acDisplayCB.Text = "Display";
            this.acDisplayCB.UseVisualStyleBackColor = true;
            this.acDisplayCB.CheckedChanged += new System.EventHandler(this.acDisplayCB_CheckedChanged);
            // 
            // degreesGB
            // 
            this.degreesGB.Controls.Add(this.degreeTypeCB);
            this.degreesGB.Controls.Add(this.label4);
            this.degreesGB.Controls.Add(this.maxDegreeDUD);
            this.degreesGB.Controls.Add(this.minDegreeDUD);
            this.degreesGB.Controls.Add(this.label3);
            this.degreesGB.Controls.Add(this.label1);
            this.degreesGB.Location = new System.Drawing.Point(15, 172);
            this.degreesGB.Name = "degreesGB";
            this.degreesGB.Size = new System.Drawing.Size(343, 106);
            this.degreesGB.TabIndex = 30;
            this.degreesGB.TabStop = false;
            this.degreesGB.Text = "Degrees";
            this.degreesGB.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // degreeTypeCB
            // 
            this.degreeTypeCB.DisplayMember = "C";
            this.degreeTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.degreeTypeCB.FormattingEnabled = true;
            this.degreeTypeCB.Items.AddRange(new object[] {
            "C",
            "F"});
            this.degreeTypeCB.Location = new System.Drawing.Point(255, 51);
            this.degreeTypeCB.Name = "degreeTypeCB";
            this.degreeTypeCB.Size = new System.Drawing.Size(46, 21);
            this.degreeTypeCB.TabIndex = 1;
            this.degreeTypeCB.ValueMember = "C";
            this.degreeTypeCB.SelectedIndexChanged += new System.EventHandler(this.degreeTypeCB_SelectedIndexChanged);
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
            // modesGB
            // 
            this.modesGB.Controls.Add(this.aiCB);
            this.modesGB.Controls.Add(this.windCB);
            this.modesGB.Controls.Add(this.hotCB);
            this.modesGB.Controls.Add(this.coldCB);
            this.modesGB.Location = new System.Drawing.Point(15, 287);
            this.modesGB.Name = "modesGB";
            this.modesGB.Size = new System.Drawing.Size(343, 93);
            this.modesGB.TabIndex = 31;
            this.modesGB.TabStop = false;
            this.modesGB.Text = "Modes";
            // 
            // aiCB
            // 
            this.aiCB.AutoSize = true;
            this.aiCB.Checked = true;
            this.aiCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aiCB.Location = new System.Drawing.Point(252, 32);
            this.aiCB.Name = "aiCB";
            this.aiCB.Size = new System.Drawing.Size(36, 17);
            this.aiCB.TabIndex = 3;
            this.aiCB.Text = "AI";
            this.aiCB.UseVisualStyleBackColor = true;
            // 
            // windCB
            // 
            this.windCB.AutoSize = true;
            this.windCB.Checked = true;
            this.windCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.windCB.Location = new System.Drawing.Point(184, 32);
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
            this.hotCB.Location = new System.Drawing.Point(120, 32);
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
            this.coldCB.Location = new System.Drawing.Point(51, 32);
            this.coldCB.Name = "coldCB";
            this.coldCB.Size = new System.Drawing.Size(47, 17);
            this.coldCB.TabIndex = 0;
            this.coldCB.Text = "Cold";
            this.coldCB.UseVisualStyleBackColor = true;
            // 
            // fanSpeedGB
            // 
            this.fanSpeedGB.Controls.Add(this.label11);
            this.fanSpeedGB.Controls.Add(this.label9);
            this.fanSpeedGB.Controls.Add(this.label10);
            this.fanSpeedGB.Controls.Add(this.label7);
            this.fanSpeedGB.Controls.Add(this.label8);
            this.fanSpeedGB.Controls.Add(this.label6);
            this.fanSpeedGB.Controls.Add(this.label5);
            this.fanSpeedGB.Controls.Add(this.fanSpeedTB);
            this.fanSpeedGB.Location = new System.Drawing.Point(364, 289);
            this.fanSpeedGB.Name = "fanSpeedGB";
            this.fanSpeedGB.Size = new System.Drawing.Size(213, 91);
            this.fanSpeedGB.TabIndex = 32;
            this.fanSpeedGB.TabStop = false;
            this.fanSpeedGB.Text = "Fan Speed Max";
            // 
            // fanSpeedTB
            // 
            this.fanSpeedTB.LargeChange = 1;
            this.fanSpeedTB.Location = new System.Drawing.Point(24, 19);
            this.fanSpeedTB.Maximum = 7;
            this.fanSpeedTB.Minimum = 1;
            this.fanSpeedTB.Name = "fanSpeedTB";
            this.fanSpeedTB.Size = new System.Drawing.Size(168, 45);
            this.fanSpeedTB.TabIndex = 0;
            this.fanSpeedTB.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.fanSpeedTB.Value = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label5.Location = new System.Drawing.Point(31, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label6.Location = new System.Drawing.Point(55, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label7.Location = new System.Drawing.Point(103, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label8.Location = new System.Drawing.Point(79, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label9.Location = new System.Drawing.Point(149, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "6";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label10.Location = new System.Drawing.Point(125, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label11.Location = new System.Drawing.Point(173, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 507);
            this.Controls.Add(this.fanSpeedGB);
            this.Controls.Add(this.modesGB);
            this.Controls.Add(this.degreesGB);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.degreesGB.ResumeLayout(false);
            this.degreesGB.PerformLayout();
            this.modesGB.ResumeLayout(false);
            this.modesGB.PerformLayout();
            this.fanSpeedGB.ResumeLayout(false);
            this.fanSpeedGB.PerformLayout();
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
        private System.Windows.Forms.Button tempUpBtn;
        private System.Windows.Forms.Button swingBtn;
        private System.Windows.Forms.Button modesBtn;
        private System.Windows.Forms.Button tempDownBtn;
        private System.Windows.Forms.Button fanSpeedBtn;
        private System.Windows.Forms.Button powerBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox degreesGB;
        private System.Windows.Forms.DomainUpDown maxDegreeDUD;
        private System.Windows.Forms.DomainUpDown minDegreeDUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox modesGB;
        private System.Windows.Forms.CheckBox windCB;
        private System.Windows.Forms.CheckBox hotCB;
        private System.Windows.Forms.CheckBox coldCB;
        private System.Windows.Forms.GroupBox fanSpeedGB;
        private System.Windows.Forms.TrackBar fanSpeedTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox acDisplayCB;
        public ComboBox degreeTypeCB;
        private CheckBox aiCB;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label11;
    }
}

