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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ArchitectureX64 = new System.Windows.Forms.RadioButton();
            this.ArchitectureX32 = new System.Windows.Forms.RadioButton();
            this.ClockChoose = new System.Windows.Forms.ComboBox();
            this.CoresLabel = new System.Windows.Forms.Label();
            this.CoresChoose = new System.Windows.Forms.TrackBar();
            this.SeriesChoose = new System.Windows.Forms.ComboBox();
            this.CreatorAMD = new System.Windows.Forms.RadioButton();
            this.CreatorIntel = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ARchitectureGr = new System.Windows.Forms.GroupBox();
            this.NvidiaGPU = new System.Windows.Forms.RadioButton();
            this.AmdGPU = new System.Windows.Forms.RadioButton();
            this.GPUCreatorGR = new System.Windows.Forms.GroupBox();
            this.GPUSeries = new System.Windows.Forms.ComboBox();
            this.GpuClock = new System.Windows.Forms.TrackBar();
            this.DiretXYes = new System.Windows.Forms.RadioButton();
            this.DiretXNo = new System.Windows.Forms.RadioButton();
            this.GpuRAM = new System.Windows.Forms.TrackBar();
            this.DiretXGroop = new System.Windows.Forms.GroupBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.DriveLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SeriesCPU = new System.Windows.Forms.Label();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GPUSeriesLabel = new System.Windows.Forms.Label();
            this.ModelGPULabel = new System.Windows.Forms.Label();
            this.ClockGpuLabel = new System.Windows.Forms.Label();
            this.GpuRamGr = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RamAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoresChoose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ARchitectureGr.SuspendLayout();
            this.GPUCreatorGR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GpuClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GpuRAM)).BeginInit();
            this.DiretXGroop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "ОЗУ:";
            // 
            // RamAmount
            // 
            this.RamAmount.Location = new System.Drawing.Point(88, 337);
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
            "Pro W6800"});
            this.GPUModel.Location = new System.Drawing.Point(666, 484);
            this.GPUModel.Name = "GPUModel";
            this.GPUModel.Size = new System.Drawing.Size(121, 23);
            this.GPUModel.TabIndex = 12;
            // 
            // MicroRadio
            // 
            this.MicroRadio.AutoSize = true;
            this.MicroRadio.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MicroRadio.Location = new System.Drawing.Point(88, 473);
            this.MicroRadio.Name = "MicroRadio";
            this.MicroRadio.Size = new System.Drawing.Size(87, 34);
            this.MicroRadio.TabIndex = 13;
            this.MicroRadio.TabStop = true;
            this.MicroRadio.Text = "Micro";
            this.MicroRadio.UseVisualStyleBackColor = true;
            // 
            // PortableRadio
            // 
            this.PortableRadio.AutoSize = true;
            this.PortableRadio.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PortableRadio.Location = new System.Drawing.Point(88, 513);
            this.PortableRadio.Name = "PortableRadio";
            this.PortableRadio.Size = new System.Drawing.Size(111, 34);
            this.PortableRadio.TabIndex = 14;
            this.PortableRadio.TabStop = true;
            this.PortableRadio.Text = "Portable";
            this.PortableRadio.UseVisualStyleBackColor = true;
            // 
            // StandartRadio
            // 
            this.StandartRadio.AutoSize = true;
            this.StandartRadio.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StandartRadio.Location = new System.Drawing.Point(88, 553);
            this.StandartRadio.Name = "StandartRadio";
            this.StandartRadio.Size = new System.Drawing.Size(111, 34);
            this.StandartRadio.TabIndex = 15;
            this.StandartRadio.TabStop = true;
            this.StandartRadio.Text = "Standart";
            this.StandartRadio.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(88, 677);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 34);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "HDD";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(88, 717);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 34);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "SSD";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 849);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 36);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // ComputerType
            // 
            this.ComputerType.FormattingEnabled = true;
            this.ComputerType.Items.AddRange(new object[] {
            "ПК",
            "Ноутбук",
            "Сервер"});
            this.ComputerType.Location = new System.Drawing.Point(88, 214);
            this.ComputerType.Name = "ComputerType";
            this.ComputerType.Size = new System.Drawing.Size(121, 23);
            this.ComputerType.TabIndex = 22;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.Location = new System.Drawing.Point(953, 45);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(419, 691);
            this.richTextBox2.TabIndex = 25;
            this.richTextBox2.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(406, 911);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 30);
            this.label4.TabIndex = 40;
            this.label4.Text = "L3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(406, 852);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 30);
            this.label3.TabIndex = 39;
            this.label3.Text = "L2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(406, 793);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 30);
            this.label2.TabIndex = 38;
            this.label2.Text = "L1";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(997, 763);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(157, 86);
            this.SaveButton.TabIndex = 37;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(457, 911);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 36;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(457, 859);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(457, 800);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 34;
            // 
            // ArchitectureX64
            // 
            this.ArchitectureX64.AutoSize = true;
            this.ArchitectureX64.Location = new System.Drawing.Point(24, 69);
            this.ArchitectureX64.Name = "ArchitectureX64";
            this.ArchitectureX64.Size = new System.Drawing.Size(65, 34);
            this.ArchitectureX64.TabIndex = 33;
            this.ArchitectureX64.TabStop = true;
            this.ArchitectureX64.Text = "x64";
            this.ArchitectureX64.UseVisualStyleBackColor = true;
            // 
            // ArchitectureX32
            // 
            this.ArchitectureX32.AutoSize = true;
            this.ArchitectureX32.Location = new System.Drawing.Point(24, 34);
            this.ArchitectureX32.Name = "ArchitectureX32";
            this.ArchitectureX32.Size = new System.Drawing.Size(65, 34);
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
            this.ClockChoose.Location = new System.Drawing.Point(406, 596);
            this.ClockChoose.Name = "ClockChoose";
            this.ClockChoose.Size = new System.Drawing.Size(121, 23);
            this.ClockChoose.TabIndex = 31;
            // 
            // CoresLabel
            // 
            this.CoresLabel.AutoSize = true;
            this.CoresLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CoresLabel.Location = new System.Drawing.Point(406, 449);
            this.CoresLabel.Name = "CoresLabel";
            this.CoresLabel.Size = new System.Drawing.Size(67, 30);
            this.CoresLabel.TabIndex = 30;
            this.CoresLabel.Text = "Ядра:";
            // 
            // CoresChoose
            // 
            this.CoresChoose.LargeChange = 16;
            this.CoresChoose.Location = new System.Drawing.Point(406, 488);
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
            this.SeriesChoose.Location = new System.Drawing.Point(406, 393);
            this.SeriesChoose.Name = "SeriesChoose";
            this.SeriesChoose.Size = new System.Drawing.Size(121, 23);
            this.SeriesChoose.TabIndex = 28;
            // 
            // CreatorAMD
            // 
            this.CreatorAMD.AutoSize = true;
            this.CreatorAMD.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreatorAMD.Location = new System.Drawing.Point(17, 96);
            this.CreatorAMD.Name = "CreatorAMD";
            this.CreatorAMD.Size = new System.Drawing.Size(80, 34);
            this.CreatorAMD.TabIndex = 27;
            this.CreatorAMD.TabStop = true;
            this.CreatorAMD.Text = "AMD";
            this.CreatorAMD.UseVisualStyleBackColor = true;
            // 
            // CreatorIntel
            // 
            this.CreatorIntel.AutoSize = true;
            this.CreatorIntel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreatorIntel.Location = new System.Drawing.Point(17, 56);
            this.CreatorIntel.Name = "CreatorIntel";
            this.CreatorIntel.Size = new System.Drawing.Size(73, 34);
            this.CreatorIntel.TabIndex = 26;
            this.CreatorIntel.TabStop = true;
            this.CreatorIntel.Text = "Intel";
            this.CreatorIntel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreatorAMD);
            this.groupBox1.Controls.Add(this.CreatorIntel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(406, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 143);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Производитель:";
            // 
            // ARchitectureGr
            // 
            this.ARchitectureGr.Controls.Add(this.ArchitectureX32);
            this.ARchitectureGr.Controls.Add(this.ArchitectureX64);
            this.ARchitectureGr.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ARchitectureGr.Location = new System.Drawing.Point(406, 648);
            this.ARchitectureGr.Name = "ARchitectureGr";
            this.ARchitectureGr.Size = new System.Drawing.Size(240, 109);
            this.ARchitectureGr.TabIndex = 42;
            this.ARchitectureGr.TabStop = false;
            this.ARchitectureGr.Text = "Архитектура";
            // 
            // NvidiaGPU
            // 
            this.NvidiaGPU.AutoSize = true;
            this.NvidiaGPU.Location = new System.Drawing.Point(12, 35);
            this.NvidiaGPU.Name = "NvidiaGPU";
            this.NvidiaGPU.Size = new System.Drawing.Size(92, 34);
            this.NvidiaGPU.TabIndex = 43;
            this.NvidiaGPU.TabStop = true;
            this.NvidiaGPU.Text = "Nvidia";
            this.NvidiaGPU.UseVisualStyleBackColor = true;
            // 
            // AmdGPU
            // 
            this.AmdGPU.AutoSize = true;
            this.AmdGPU.Location = new System.Drawing.Point(14, 87);
            this.AmdGPU.Name = "AmdGPU";
            this.AmdGPU.Size = new System.Drawing.Size(77, 34);
            this.AmdGPU.TabIndex = 44;
            this.AmdGPU.TabStop = true;
            this.AmdGPU.Text = "Amd";
            this.AmdGPU.UseVisualStyleBackColor = true;
            // 
            // GPUCreatorGR
            // 
            this.GPUCreatorGR.Controls.Add(this.NvidiaGPU);
            this.GPUCreatorGR.Controls.Add(this.AmdGPU);
            this.GPUCreatorGR.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GPUCreatorGR.Location = new System.Drawing.Point(681, 162);
            this.GPUCreatorGR.Name = "GPUCreatorGR";
            this.GPUCreatorGR.Size = new System.Drawing.Size(231, 134);
            this.GPUCreatorGR.TabIndex = 45;
            this.GPUCreatorGR.TabStop = false;
            this.GPUCreatorGR.Text = "Производитель";
            // 
            // GPUSeries
            // 
            this.GPUSeries.FormattingEnabled = true;
            this.GPUSeries.Items.AddRange(new object[] {
            "RTX",
            "Radeon"});
            this.GPUSeries.Location = new System.Drawing.Point(671, 378);
            this.GPUSeries.Name = "GPUSeries";
            this.GPUSeries.Size = new System.Drawing.Size(121, 23);
            this.GPUSeries.TabIndex = 46;
            // 
            // GpuClock
            // 
            this.GpuClock.LargeChange = 100;
            this.GpuClock.Location = new System.Drawing.Point(677, 581);
            this.GpuClock.Maximum = 2000;
            this.GpuClock.Minimum = 1000;
            this.GpuClock.Name = "GpuClock";
            this.GpuClock.Size = new System.Drawing.Size(104, 45);
            this.GpuClock.SmallChange = 100;
            this.GpuClock.TabIndex = 47;
            this.GpuClock.Value = 1000;
            this.GpuClock.Scroll += new System.EventHandler(this.GpuClock_Scroll);
            // 
            // DiretXYes
            // 
            this.DiretXYes.AutoSize = true;
            this.DiretXYes.Location = new System.Drawing.Point(6, 35);
            this.DiretXYes.Name = "DiretXYes";
            this.DiretXYes.Size = new System.Drawing.Size(72, 34);
            this.DiretXYes.TabIndex = 48;
            this.DiretXYes.TabStop = true;
            this.DiretXYes.Text = "Есть";
            this.DiretXYes.UseVisualStyleBackColor = true;
            // 
            // DiretXNo
            // 
            this.DiretXNo.AutoSize = true;
            this.DiretXNo.Location = new System.Drawing.Point(7, 74);
            this.DiretXNo.Name = "DiretXNo";
            this.DiretXNo.Size = new System.Drawing.Size(79, 34);
            this.DiretXNo.TabIndex = 49;
            this.DiretXNo.TabStop = true;
            this.DiretXNo.Text = "Нету";
            this.DiretXNo.UseVisualStyleBackColor = true;
            // 
            // GpuRAM
            // 
            this.GpuRAM.Location = new System.Drawing.Point(695, 840);
            this.GpuRAM.Maximum = 24;
            this.GpuRAM.Minimum = 8;
            this.GpuRAM.Name = "GpuRAM";
            this.GpuRAM.Size = new System.Drawing.Size(104, 45);
            this.GpuRAM.SmallChange = 2;
            this.GpuRAM.TabIndex = 50;
            this.GpuRAM.Value = 8;
            // 
            // DiretXGroop
            // 
            this.DiretXGroop.Controls.Add(this.DiretXYes);
            this.DiretXGroop.Controls.Add(this.DiretXNo);
            this.DiretXGroop.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiretXGroop.Location = new System.Drawing.Point(671, 642);
            this.DiretXGroop.Name = "DiretXGroop";
            this.DiretXGroop.Size = new System.Drawing.Size(247, 127);
            this.DiretXGroop.TabIndex = 51;
            this.DiretXGroop.TabStop = false;
            this.DiretXGroop.Text = "Наличие DiretX";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeLabel.Location = new System.Drawing.Point(88, 162);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(173, 30);
            this.TypeLabel.TabIndex = 52;
            this.TypeLabel.Text = "Тип устройства:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeLabel.Location = new System.Drawing.Point(88, 434);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(208, 30);
            this.SizeLabel.TabIndex = 53;
            this.SizeLabel.Text = "Размер устройства:";
            // 
            // DriveLabel
            // 
            this.DriveLabel.AutoSize = true;
            this.DriveLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DriveLabel.Location = new System.Drawing.Point(88, 630);
            this.DriveLabel.Name = "DriveLabel";
            this.DriveLabel.Size = new System.Drawing.Size(170, 30);
            this.DriveLabel.TabIndex = 54;
            this.DriveLabel.Text = "Наличие диска:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(88, 796);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(155, 30);
            this.DateLabel.TabIndex = 55;
            this.DateLabel.Text = "Дата покупки:";
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsLabel.Location = new System.Drawing.Point(84, 66);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(244, 30);
            this.SettingsLabel.TabIndex = 56;
            this.SettingsLabel.Text = "Настройки устройства:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(406, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 30);
            this.label6.TabIndex = 57;
            this.label6.Text = "Настройки ЦП:";
            // 
            // SeriesCPU
            // 
            this.SeriesCPU.AutoSize = true;
            this.SeriesCPU.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeriesCPU.Location = new System.Drawing.Point(406, 352);
            this.SeriesCPU.Name = "SeriesCPU";
            this.SeriesCPU.Size = new System.Drawing.Size(119, 30);
            this.SeriesCPU.TabIndex = 58;
            this.SeriesCPU.Text = "Серия ЦП:";
            // 
            // ClockLabel
            // 
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClockLabel.Location = new System.Drawing.Point(406, 556);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(134, 30);
            this.ClockLabel.TabIndex = 59;
            this.ClockLabel.Text = "Частота ЦП:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(682, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 30);
            this.label5.TabIndex = 60;
            this.label5.Text = "Настройки ГК:";
            // 
            // GPUSeriesLabel
            // 
            this.GPUSeriesLabel.AutoSize = true;
            this.GPUSeriesLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GPUSeriesLabel.Location = new System.Drawing.Point(681, 337);
            this.GPUSeriesLabel.Name = "GPUSeriesLabel";
            this.GPUSeriesLabel.Size = new System.Drawing.Size(110, 30);
            this.GPUSeriesLabel.TabIndex = 61;
            this.GPUSeriesLabel.Text = "Серия ГК:";
            // 
            // ModelGPULabel
            // 
            this.ModelGPULabel.AutoSize = true;
            this.ModelGPULabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelGPULabel.Location = new System.Drawing.Point(671, 434);
            this.ModelGPULabel.Name = "ModelGPULabel";
            this.ModelGPULabel.Size = new System.Drawing.Size(127, 30);
            this.ModelGPULabel.TabIndex = 62;
            this.ModelGPULabel.Text = "Модель ГК:";
            // 
            // ClockGpuLabel
            // 
            this.ClockGpuLabel.AutoSize = true;
            this.ClockGpuLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClockGpuLabel.Location = new System.Drawing.Point(674, 541);
            this.ClockGpuLabel.Name = "ClockGpuLabel";
            this.ClockGpuLabel.Size = new System.Drawing.Size(125, 30);
            this.ClockGpuLabel.TabIndex = 63;
            this.ClockGpuLabel.Text = "Частота ГК:";
            // 
            // GpuRamGr
            // 
            this.GpuRamGr.AutoSize = true;
            this.GpuRamGr.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GpuRamGr.Location = new System.Drawing.Point(693, 796);
            this.GpuRamGr.Name = "GpuRamGr";
            this.GpuRamGr.Size = new System.Drawing.Size(197, 30);
            this.GpuRamGr.TabIndex = 64;
            this.GpuRamGr.Text = "Кол-во памяти ГК:";
            this.GpuRamGr.Click += new System.EventHandler(this.GpuRamGr_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.Location = new System.Drawing.Point(1205, 765);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(150, 86);
            this.CloseButton.TabIndex = 65;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelLabel.Location = new System.Drawing.Point(408, 277);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(136, 30);
            this.ModelLabel.TabIndex = 67;
            this.ModelLabel.Text = "Модель ЦП:";
            // 
            // ModelCombobox
            // 
            this.ModelCombobox.FormattingEnabled = true;
            this.ModelCombobox.Items.AddRange(new object[] {
            "Overclocked",
            "Unclocked"});
            this.ModelCombobox.Location = new System.Drawing.Point(408, 318);
            this.ModelCombobox.Name = "ModelCombobox";
            this.ModelCombobox.Size = new System.Drawing.Size(121, 23);
            this.ModelCombobox.TabIndex = 66;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 937);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.ModelCombobox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.GpuRamGr);
            this.Controls.Add(this.ClockGpuLabel);
            this.Controls.Add(this.ModelGPULabel);
            this.Controls.Add(this.GPUSeriesLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.SeriesCPU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SettingsLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DriveLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.DiretXGroop);
            this.Controls.Add(this.GpuRAM);
            this.Controls.Add(this.GpuClock);
            this.Controls.Add(this.GPUSeries);
            this.Controls.Add(this.GPUCreatorGR);
            this.Controls.Add(this.ARchitectureGr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClockChoose);
            this.Controls.Add(this.CoresLabel);
            this.Controls.Add(this.CoresChoose);
            this.Controls.Add(this.SeriesChoose);
            this.Controls.Add(this.richTextBox2);
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
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.RamAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoresChoose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ARchitectureGr.ResumeLayout(false);
            this.ARchitectureGr.PerformLayout();
            this.GPUCreatorGR.ResumeLayout(false);
            this.GPUCreatorGR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GpuClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GpuRAM)).EndInit();
            this.DiretXGroop.ResumeLayout(false);
            this.DiretXGroop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private RichTextBox richTextBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button SaveButton;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private ComboBox comboBox4;
        private Label CoresLabel;
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
        private GroupBox ARchitectureGr;
        private RadioButton NvidiaGPU;
        private RadioButton AmdGPU;
        private GroupBox GPUCreatorGR;
        private ComboBox GPUSeries;
        private TrackBar GpuClock;
        private RadioButton DiretXYes;
        private RadioButton DiretXNo;
        private TrackBar GpuRAM;
        private GroupBox DiretXGroop;
        private Label TypeLabel;
        private Label SizeLabel;
        private Label DriveLabel;
        private Label DateLabel;
        private Label SettingsLabel;
        private Label label6;
        private Label SeriesCPU;
        private Label ClockLabel;
        private Label label5;
        private Label GPUSeriesLabel;
        private Label ModelGPULabel;
        private Label ClockGpuLabel;
        private Label GpuRamGr;
        private Button CloseButton;
        private Label ModelLabel;
        private ComboBox ModelCombobox;
    }
}