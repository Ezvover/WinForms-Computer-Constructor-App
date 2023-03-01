namespace laba2
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RamAmount = new System.Windows.Forms.TrackBar();
            this.GPUModel = new System.Windows.Forms.ComboBox();
            this.MicroRadio = new System.Windows.Forms.RadioButton();
            this.PortableRadio = new System.Windows.Forms.RadioButton();
            this.StandartRadio = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ComputerType = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ArchitectureX64 = new System.Windows.Forms.RadioButton();
            this.ArchitectureX32 = new System.Windows.Forms.RadioButton();
            this.ClockChoose = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CoresChoose = new System.Windows.Forms.TrackBar();
            this.SeriesChoose = new System.Windows.Forms.ComboBox();
            this.CreatorAMD = new System.Windows.Forms.RadioButton();
            this.CreatorIntel = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NvidiaGPU = new System.Windows.Forms.RadioButton();
            this.AmdGPU = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GPUSeries = new System.Windows.Forms.ComboBox();
            this.GpuClock = new System.Windows.Forms.TrackBar();
            this.DiretXYes = new System.Windows.Forms.RadioButton();
            this.DiretXNo = new System.Windows.Forms.RadioButton();
            this.GpuRAM = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.RamAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoresChoose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GpuClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GpuRAM)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(114, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(97, 26);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Intel Core i5",
            "Intel Core i7",
            "Intel Core i9",
            "Intel Xeon",
            "AMD Ryzen Threadripper",
            "AMD Ryzen 5",
            "AMD Ryzen 7",
            "AMD Ryzen 9"});
            this.comboBox1.Location = new System.Drawing.Point(111, 282);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ОЗУ:";
            // 
            // RamAmount
            // 
            this.RamAmount.Location = new System.Drawing.Point(111, 513);
            this.RamAmount.Maximum = 1024;
            this.RamAmount.Minimum = 8;
            this.RamAmount.Name = "RamAmount";
            this.RamAmount.Size = new System.Drawing.Size(85, 45);
            this.RamAmount.TabIndex = 11;
            this.RamAmount.Value = 8;
            this.RamAmount.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // GPUModel
            // 
            this.GPUModel.FormattingEnabled = true;
            this.GPUModel.Items.AddRange(new object[] {
            "2050",
            "2060",
            "2070",
            "2080",
            "4060",
            "4070",
            "4080",
            "A5000",
            "A5500",
            "A6000",
            "A6500 ADA",
            "Radeon Pro W6800"});
            this.GPUModel.Location = new System.Drawing.Point(1214, 224);
            this.GPUModel.Name = "GPUModel";
            this.GPUModel.Size = new System.Drawing.Size(121, 23);
            this.GPUModel.TabIndex = 12;
            // 
            // MicroRadio
            // 
            this.MicroRadio.AutoSize = true;
            this.MicroRadio.Location = new System.Drawing.Point(111, 579);
            this.MicroRadio.Name = "MicroRadio";
            this.MicroRadio.Size = new System.Drawing.Size(56, 19);
            this.MicroRadio.TabIndex = 13;
            this.MicroRadio.TabStop = true;
            this.MicroRadio.Text = "Micro";
            this.MicroRadio.UseVisualStyleBackColor = true;
            // 
            // PortableRadio
            // 
            this.PortableRadio.AutoSize = true;
            this.PortableRadio.Location = new System.Drawing.Point(111, 604);
            this.PortableRadio.Name = "PortableRadio";
            this.PortableRadio.Size = new System.Drawing.Size(69, 19);
            this.PortableRadio.TabIndex = 14;
            this.PortableRadio.TabStop = true;
            this.PortableRadio.Text = "Portable";
            this.PortableRadio.UseVisualStyleBackColor = true;
            // 
            // StandartRadio
            // 
            this.StandartRadio.AutoSize = true;
            this.StandartRadio.Location = new System.Drawing.Point(111, 628);
            this.StandartRadio.Name = "StandartRadio";
            this.StandartRadio.Size = new System.Drawing.Size(69, 19);
            this.StandartRadio.TabIndex = 15;
            this.StandartRadio.TabStop = true;
            this.StandartRadio.Text = "Standart";
            this.StandartRadio.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(108, 702);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 19);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "HDD";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(108, 727);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(46, 19);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "SSD";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 787);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // ComputerType
            // 
            this.ComputerType.FormattingEnabled = true;
            this.ComputerType.Items.AddRange(new object[] {
            "ПК",
            "Ноутбук",
            "Сервер"});
            this.ComputerType.Location = new System.Drawing.Point(114, 44);
            this.ComputerType.Name = "ComputerType";
            this.ComputerType.Size = new System.Drawing.Size(121, 23);
            this.ComputerType.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(648, 159);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(399, 441);
            this.richTextBox2.TabIndex = 25;
            this.richTextBox2.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1703, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "L3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1703, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "L2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1703, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "L1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1721, 577);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 37;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1700, 509);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 36;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1700, 461);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1700, 398);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 34;
            // 
            // ArchitectureX64
            // 
            this.ArchitectureX64.AutoSize = true;
            this.ArchitectureX64.Location = new System.Drawing.Point(81, 47);
            this.ArchitectureX64.Name = "ArchitectureX64";
            this.ArchitectureX64.Size = new System.Drawing.Size(43, 19);
            this.ArchitectureX64.TabIndex = 33;
            this.ArchitectureX64.TabStop = true;
            this.ArchitectureX64.Text = "x64";
            this.ArchitectureX64.UseVisualStyleBackColor = true;
            // 
            // ArchitectureX32
            // 
            this.ArchitectureX32.AutoSize = true;
            this.ArchitectureX32.Location = new System.Drawing.Point(81, 22);
            this.ArchitectureX32.Name = "ArchitectureX32";
            this.ArchitectureX32.Size = new System.Drawing.Size(43, 19);
            this.ArchitectureX32.TabIndex = 32;
            this.ArchitectureX32.TabStop = true;
            this.ArchitectureX32.Text = "x32";
            this.ArchitectureX32.UseVisualStyleBackColor = true;
            // 
            // ClockChoose
            // 
            this.ClockChoose.FormattingEnabled = true;
            this.ClockChoose.Items.AddRange(new object[] {
            "2.2",
            "2.4",
            "2.6",
            "2.8",
            "3.0",
            "3.2",
            "3.4",
            "3.6",
            "3.8",
            "4.0"});
            this.ClockChoose.Location = new System.Drawing.Point(1686, 243);
            this.ClockChoose.Name = "ClockChoose";
            this.ClockChoose.Size = new System.Drawing.Size(121, 23);
            this.ClockChoose.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1721, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "label5";
            // 
            // CoresChoose
            // 
            this.CoresChoose.LargeChange = 16;
            this.CoresChoose.Location = new System.Drawing.Point(1686, 192);
            this.CoresChoose.Maximum = 16;
            this.CoresChoose.Minimum = 4;
            this.CoresChoose.Name = "CoresChoose";
            this.CoresChoose.Size = new System.Drawing.Size(121, 45);
            this.CoresChoose.TabIndex = 29;
            this.CoresChoose.Value = 4;
            this.CoresChoose.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // SeriesChoose
            // 
            this.SeriesChoose.FormattingEnabled = true;
            this.SeriesChoose.Items.AddRange(new object[] {
            "5",
            "7",
            "9",
            "Server"});
            this.SeriesChoose.Location = new System.Drawing.Point(1686, 122);
            this.SeriesChoose.Name = "SeriesChoose";
            this.SeriesChoose.Size = new System.Drawing.Size(121, 23);
            this.SeriesChoose.TabIndex = 28;
            // 
            // CreatorAMD
            // 
            this.CreatorAMD.AutoSize = true;
            this.CreatorAMD.Location = new System.Drawing.Point(17, 62);
            this.CreatorAMD.Name = "CreatorAMD";
            this.CreatorAMD.Size = new System.Drawing.Size(52, 19);
            this.CreatorAMD.TabIndex = 27;
            this.CreatorAMD.TabStop = true;
            this.CreatorAMD.Text = "AMD";
            this.CreatorAMD.UseVisualStyleBackColor = true;
            // 
            // CreatorIntel
            // 
            this.CreatorIntel.AutoSize = true;
            this.CreatorIntel.Location = new System.Drawing.Point(17, 37);
            this.CreatorIntel.Name = "CreatorIntel";
            this.CreatorIntel.Size = new System.Drawing.Size(48, 19);
            this.CreatorIntel.TabIndex = 26;
            this.CreatorIntel.TabStop = true;
            this.CreatorIntel.Text = "Intel";
            this.CreatorIntel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreatorAMD);
            this.groupBox1.Controls.Add(this.CreatorIntel);
            this.groupBox1.Location = new System.Drawing.Point(1700, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 102);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ArchitectureX32);
            this.groupBox2.Controls.Add(this.ArchitectureX64);
            this.groupBox2.Location = new System.Drawing.Point(1634, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 69);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // NvidiaGPU
            // 
            this.NvidiaGPU.AutoSize = true;
            this.NvidiaGPU.Location = new System.Drawing.Point(60, 22);
            this.NvidiaGPU.Name = "NvidiaGPU";
            this.NvidiaGPU.Size = new System.Drawing.Size(59, 19);
            this.NvidiaGPU.TabIndex = 43;
            this.NvidiaGPU.TabStop = true;
            this.NvidiaGPU.Text = "Nvidia";
            this.NvidiaGPU.UseVisualStyleBackColor = true;
            // 
            // AmdGPU
            // 
            this.AmdGPU.AutoSize = true;
            this.AmdGPU.Location = new System.Drawing.Point(63, 62);
            this.AmdGPU.Name = "AmdGPU";
            this.AmdGPU.Size = new System.Drawing.Size(51, 19);
            this.AmdGPU.TabIndex = 44;
            this.AmdGPU.TabStop = true;
            this.AmdGPU.Text = "Amd";
            this.AmdGPU.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NvidiaGPU);
            this.groupBox3.Controls.Add(this.AmdGPU);
            this.groupBox3.Location = new System.Drawing.Point(1221, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // GPUSeries
            // 
            this.GPUSeries.FormattingEnabled = true;
            this.GPUSeries.Items.AddRange(new object[] {
            "RTX",
            "Radeon"});
            this.GPUSeries.Location = new System.Drawing.Point(1214, 162);
            this.GPUSeries.Name = "GPUSeries";
            this.GPUSeries.Size = new System.Drawing.Size(121, 23);
            this.GPUSeries.TabIndex = 46;
            // 
            // GpuClock
            // 
            this.GpuClock.LargeChange = 100;
            this.GpuClock.Location = new System.Drawing.Point(1221, 303);
            this.GpuClock.Maximum = 2000;
            this.GpuClock.Minimum = 1000;
            this.GpuClock.Name = "GpuClock";
            this.GpuClock.Size = new System.Drawing.Size(104, 45);
            this.GpuClock.SmallChange = 100;
            this.GpuClock.TabIndex = 47;
            this.GpuClock.Value = 1000;
            // 
            // DiretXYes
            // 
            this.DiretXYes.AutoSize = true;
            this.DiretXYes.Location = new System.Drawing.Point(6, 15);
            this.DiretXYes.Name = "DiretXYes";
            this.DiretXYes.Size = new System.Drawing.Size(94, 19);
            this.DiretXYes.TabIndex = 48;
            this.DiretXYes.TabStop = true;
            this.DiretXYes.Text = "radioButton6";
            this.DiretXYes.UseVisualStyleBackColor = true;
            // 
            // DiretXNo
            // 
            this.DiretXNo.AutoSize = true;
            this.DiretXNo.Location = new System.Drawing.Point(5, 48);
            this.DiretXNo.Name = "DiretXNo";
            this.DiretXNo.Size = new System.Drawing.Size(94, 19);
            this.DiretXNo.TabIndex = 49;
            this.DiretXNo.TabStop = true;
            this.DiretXNo.Text = "radioButton7";
            this.DiretXNo.UseVisualStyleBackColor = true;
            // 
            // GpuRAM
            // 
            this.GpuRAM.Location = new System.Drawing.Point(1230, 430);
            this.GpuRAM.Maximum = 24;
            this.GpuRAM.Minimum = 8;
            this.GpuRAM.Name = "GpuRAM";
            this.GpuRAM.Size = new System.Drawing.Size(104, 45);
            this.GpuRAM.SmallChange = 2;
            this.GpuRAM.TabIndex = 50;
            this.GpuRAM.Value = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DiretXYes);
            this.groupBox4.Controls.Add(this.DiretXNo);
            this.groupBox4.Location = new System.Drawing.Point(1221, 347);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 74);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2030, 937);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GpuRAM);
            this.Controls.Add(this.GpuClock);
            this.Controls.Add(this.GPUSeries);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClockChoose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CoresChoose);
            this.Controls.Add(this.SeriesChoose);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ComputerType);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.StandartRadio);
            this.Controls.Add(this.PortableRadio);
            this.Controls.Add(this.MicroRadio);
            this.Controls.Add(this.GPUModel);
            this.Controls.Add(this.RamAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.RamAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoresChoose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GpuClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GpuRAM)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private Label label1;
        private TrackBar trackBar1;
        private ComboBox comboBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private DateTimePicker dateTimePicker1;
        private ComboBox ComputerType;
        private Button button2;
        private RichTextBox richTextBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private ComboBox comboBox4;
        private Label label5;
        private TrackBar CoresChoose;
        private ComboBox SeriesChoose;
        private RadioButton CreatorAMD;
        private RadioButton CreatorIntel;
        private ComboBox ClockChoose;
        private RadioButton ArchitectureX64;
        private RadioButton ArchitectureX32;
        private TrackBar RamAmount;
        private ComboBox GPUModel;
        private RadioButton MicroRadio;
        private RadioButton PortableRadio;
        private RadioButton StandartRadio;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton NvidiaGPU;
        private RadioButton AmdGPU;
        private GroupBox groupBox3;
        private ComboBox GPUSeries;
        private TrackBar GpuClock;
        private RadioButton DiretXYes;
        private RadioButton DiretXNo;
        private TrackBar GpuRAM;
        private GroupBox groupBox4;
    }
}