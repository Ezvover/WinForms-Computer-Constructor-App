namespace laba2
{
    partial class Form3
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchOutput = new System.Windows.Forms.RichTextBox();
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.PartRadioSearch = new System.Windows.Forms.RadioButton();
            this.CreatorRadioSearch = new System.Windows.Forms.RadioButton();
            this.ModelRadioSearch = new System.Windows.Forms.RadioButton();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(79, 322);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(207, 64);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchOutput
            // 
            this.SearchOutput.Location = new System.Drawing.Point(383, 12);
            this.SearchOutput.Name = "SearchOutput";
            this.SearchOutput.Size = new System.Drawing.Size(516, 461);
            this.SearchOutput.TabIndex = 2;
            this.SearchOutput.Text = "";
            // 
            // TextSearch
            // 
            this.TextSearch.Location = new System.Drawing.Point(79, 88);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(229, 23);
            this.TextSearch.TabIndex = 4;
            // 
            // PartRadioSearch
            // 
            this.PartRadioSearch.AutoSize = true;
            this.PartRadioSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PartRadioSearch.Location = new System.Drawing.Point(89, 151);
            this.PartRadioSearch.Name = "PartRadioSearch";
            this.PartRadioSearch.Size = new System.Drawing.Size(183, 29);
            this.PartRadioSearch.TabIndex = 5;
            this.PartRadioSearch.TabStop = true;
            this.PartRadioSearch.Text = "Частичный поиск";
            this.PartRadioSearch.UseVisualStyleBackColor = true;
            // 
            // CreatorRadioSearch
            // 
            this.CreatorRadioSearch.AutoSize = true;
            this.CreatorRadioSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreatorRadioSearch.Location = new System.Drawing.Point(89, 186);
            this.CreatorRadioSearch.Name = "CreatorRadioSearch";
            this.CreatorRadioSearch.Size = new System.Drawing.Size(253, 29);
            this.CreatorRadioSearch.TabIndex = 6;
            this.CreatorRadioSearch.TabStop = true;
            this.CreatorRadioSearch.Text = "Поиск по производителю";
            this.CreatorRadioSearch.UseVisualStyleBackColor = true;
            // 
            // ModelRadioSearch
            // 
            this.ModelRadioSearch.AutoSize = true;
            this.ModelRadioSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelRadioSearch.Location = new System.Drawing.Point(89, 221);
            this.ModelRadioSearch.Name = "ModelRadioSearch";
            this.ModelRadioSearch.Size = new System.Drawing.Size(181, 29);
            this.ModelRadioSearch.TabIndex = 7;
            this.ModelRadioSearch.TabStop = true;
            this.ModelRadioSearch.Text = "Поиск по модели";
            this.ModelRadioSearch.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(129, 417);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(106, 38);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Очистка";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 494);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ModelRadioSearch);
            this.Controls.Add(this.CreatorRadioSearch);
            this.Controls.Add(this.PartRadioSearch);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.SearchOutput);
            this.Controls.Add(this.SearchButton);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SearchButton;
        private RichTextBox SearchOutput;
        private TextBox TextSearch;
        private RadioButton PartRadioSearch;
        private RadioButton CreatorRadioSearch;
        private RadioButton ModelRadioSearch;
        private Button ClearButton;
    }
}