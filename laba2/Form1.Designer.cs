namespace laba2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OutputTextbox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AboutButton = new System.Windows.Forms.ToolStripButton();
            this.CreateComputer = new System.Windows.Forms.ToolStripButton();
            this.OutputPc = new System.Windows.Forms.ToolStripButton();
            this.SortRam = new System.Windows.Forms.ToolStripButton();
            this.SortClock = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ClearButton = new System.Windows.Forms.ToolStripButton();
            this.PredLabel = new System.Windows.Forms.ToolStripLabel();
            this.amountLabel = new System.Windows.Forms.ToolStripLabel();
            this.dataLabel = new System.Windows.Forms.ToolStripLabel();
            this.HideButton = new System.Windows.Forms.ToolStripButton();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.ShowToolBar = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputTextbox.Location = new System.Drawing.Point(28, 63);
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.Size = new System.Drawing.Size(587, 755);
            this.OutputTextbox.TabIndex = 5;
            this.OutputTextbox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutButton,
            this.CreateComputer,
            this.OutputPc,
            this.SortRam,
            this.SortClock,
            this.toolStripButton1,
            this.ClearButton,
            this.PredLabel,
            this.amountLabel,
            this.dataLabel,
            this.HideButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(913, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AboutButton
            // 
            this.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            this.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(23, 22);
            this.AboutButton.Text = "Об программе";
            this.AboutButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // CreateComputer
            // 
            this.CreateComputer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateComputer.Image = ((System.Drawing.Image)(resources.GetObject("CreateComputer.Image")));
            this.CreateComputer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateComputer.Name = "CreateComputer";
            this.CreateComputer.Size = new System.Drawing.Size(23, 22);
            this.CreateComputer.Text = "Создать устройство";
            this.CreateComputer.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // OutputPc
            // 
            this.OutputPc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OutputPc.Image = ((System.Drawing.Image)(resources.GetObject("OutputPc.Image")));
            this.OutputPc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OutputPc.Name = "OutputPc";
            this.OutputPc.Size = new System.Drawing.Size(23, 22);
            this.OutputPc.Text = "Вывод устройства";
            this.OutputPc.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // SortRam
            // 
            this.SortRam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SortRam.Image = ((System.Drawing.Image)(resources.GetObject("SortRam.Image")));
            this.SortRam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortRam.Name = "SortRam";
            this.SortRam.Size = new System.Drawing.Size(23, 22);
            this.SortRam.Text = "Сортировка по ОЗУ";
            this.SortRam.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // SortClock
            // 
            this.SortClock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SortClock.Image = ((System.Drawing.Image)(resources.GetObject("SortClock.Image")));
            this.SortClock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortClock.Name = "SortClock";
            this.SortClock.Size = new System.Drawing.Size(23, 22);
            this.SortClock.Text = "Сортировка по частоте";
            this.SortClock.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // ClearButton
            // 
            this.ClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(23, 22);
            this.ClearButton.Text = "Очистка формы";
            this.ClearButton.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // PredLabel
            // 
            this.PredLabel.Name = "PredLabel";
            this.PredLabel.Size = new System.Drawing.Size(131, 22);
            this.PredLabel.Text = "Предыдущее действие";
            // 
            // amountLabel
            // 
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(100, 22);
            this.amountLabel.Text = "Кол-во объектов";
            // 
            // dataLabel
            // 
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(32, 22);
            this.dataLabel.Text = "Дата";
            // 
            // HideButton
            // 
            this.HideButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HideButton.Image = ((System.Drawing.Image)(resources.GetObject("HideButton.Image")));
            this.HideButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(23, 22);
            this.HideButton.Text = "Спрятать меню";
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // DateTimer
            // 
            this.DateTimer.Interval = 1000;
            this.DateTimer.Tick += new System.EventHandler(this.DateTimer_Tick);
            // 
            // ShowToolBar
            // 
            this.ShowToolBar.Location = new System.Drawing.Point(192, 12);
            this.ShowToolBar.Name = "ShowToolBar";
            this.ShowToolBar.Size = new System.Drawing.Size(259, 43);
            this.ShowToolBar.TabIndex = 16;
            this.ShowToolBar.Text = "Показать меню";
            this.ShowToolBar.UseVisualStyleBackColor = true;
            this.ShowToolBar.Visible = false;
            this.ShowToolBar.Click += new System.EventHandler(this.ShowToolBar_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(667, 254);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(210, 122);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "Добавить ПК";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(667, 448);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(210, 122);
            this.ShowButton.TabIndex = 18;
            this.ShowButton.Text = "Показать ПК";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 844);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ShowToolBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.OutputTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBox OutputTextbox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton AboutButton;
        private ToolStripButton CreateComputer;
        private ToolStripButton OutputPc;
        private ToolStripButton SortRam;
        private ToolStripButton SortClock;
        private ToolStripButton ClearButton;
        private ToolStripLabel PredLabel;
        private ToolStripLabel amountLabel;
        private ToolStripLabel dataLabel;
        private System.Windows.Forms.Timer DateTimer;
        private ToolStripButton HideButton;
        private Button ShowToolBar;
        private ToolStripButton toolStripButton1;
        private Button AddButton;
        private Button ShowButton;
    }
}