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
            this.CreatePC = new System.Windows.Forms.Button();
            this.OutputTextbox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoadButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePC
            // 
            this.CreatePC.Location = new System.Drawing.Point(530, 31);
            this.CreatePC.Name = "CreatePC";
            this.CreatePC.Size = new System.Drawing.Size(208, 133);
            this.CreatePC.TabIndex = 1;
            this.CreatePC.Text = "Создать ПК";
            this.CreatePC.UseVisualStyleBackColor = true;
            this.CreatePC.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputTextbox.Location = new System.Drawing.Point(28, 12);
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.Size = new System.Drawing.Size(466, 806);
            this.OutputTextbox.TabIndex = 5;
            this.OutputTextbox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(530, 191);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(208, 124);
            this.LoadButton.TabIndex = 8;
            this.LoadButton.Text = "Загрузить ПК";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(530, 348);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(208, 137);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Очистить форму";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 844);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.CreatePC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Button CreatePC;
        private RichTextBox OutputTextbox;
        private ContextMenuStrip contextMenuStrip1;
        private Button LoadButton;
        private Button ClearButton;
    }
}