namespace Language_Translator
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
            this.lblInstructionLabel = new System.Windows.Forms.Label();
            this.italianBtn = new System.Windows.Forms.Button();
            this.spanishBtn = new System.Windows.Forms.Button();
            this.germanBtn = new System.Windows.Forms.Button();
            this.lblTranslationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructionLabel
            // 
            this.lblInstructionLabel.AutoSize = true;
            this.lblInstructionLabel.Location = new System.Drawing.Point(195, 9);
            this.lblInstructionLabel.Name = "lblInstructionLabel";
            this.lblInstructionLabel.Size = new System.Drawing.Size(229, 13);
            this.lblInstructionLabel.TabIndex = 1;
            this.lblInstructionLabel.Text = "Select a language, and I will say Good Morning";
            // 
            // italianBtn
            // 
            this.italianBtn.Location = new System.Drawing.Point(38, 101);
            this.italianBtn.Name = "italianBtn";
            this.italianBtn.Size = new System.Drawing.Size(75, 23);
            this.italianBtn.TabIndex = 2;
            this.italianBtn.Text = "Italian";
            this.italianBtn.UseVisualStyleBackColor = true;
            this.italianBtn.Click += new System.EventHandler(this.italianBtn_Click);
            // 
            // spanishBtn
            // 
            this.spanishBtn.Location = new System.Drawing.Point(220, 101);
            this.spanishBtn.Name = "spanishBtn";
            this.spanishBtn.Size = new System.Drawing.Size(75, 23);
            this.spanishBtn.TabIndex = 3;
            this.spanishBtn.Text = "Spanish";
            this.spanishBtn.UseVisualStyleBackColor = true;
            this.spanishBtn.Click += new System.EventHandler(this.spanishBtn_Click);
            // 
            // germanBtn
            // 
            this.germanBtn.Location = new System.Drawing.Point(420, 101);
            this.germanBtn.Name = "germanBtn";
            this.germanBtn.Size = new System.Drawing.Size(75, 23);
            this.germanBtn.TabIndex = 4;
            this.germanBtn.Text = "German";
            this.germanBtn.UseVisualStyleBackColor = true;
            this.germanBtn.Click += new System.EventHandler(this.germanBtn_Click);
            // 
            // lblTranslationLabel
            // 
            this.lblTranslationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTranslationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranslationLabel.Location = new System.Drawing.Point(184, 34);
            this.lblTranslationLabel.Name = "lblTranslationLabel";
            this.lblTranslationLabel.Size = new System.Drawing.Size(183, 42);
            this.lblTranslationLabel.TabIndex = 5;
            this.lblTranslationLabel.Text = "(The contents of the texbox has been erased)";
            this.lblTranslationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 192);
            this.Controls.Add(this.lblTranslationLabel);
            this.Controls.Add(this.germanBtn);
            this.Controls.Add(this.spanishBtn);
            this.Controls.Add(this.italianBtn);
            this.Controls.Add(this.lblInstructionLabel);
            this.Name = "Form1";
            this.Text = "Language Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructionLabel;
        private System.Windows.Forms.Button italianBtn;
        private System.Windows.Forms.Button spanishBtn;
        private System.Windows.Forms.Button germanBtn;
        private System.Windows.Forms.Label lblTranslationLabel;
    }
}

