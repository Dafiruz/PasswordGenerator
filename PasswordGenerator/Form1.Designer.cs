namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelOptions = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textSize = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.checkboxLowercase = new System.Windows.Forms.CheckBox();
            this.checkboxUppercase = new System.Windows.Forms.CheckBox();
            this.checkboxNumbers = new System.Windows.Forms.CheckBox();
            this.checkboxSymbols = new System.Windows.Forms.CheckBox();
            this.buttonCopyToClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Location = new System.Drawing.Point(13, 10);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(43, 13);
            this.labelOptions.TabIndex = 1;
            this.labelOptions.Text = "Options";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonGenerate.Location = new System.Drawing.Point(107, 84);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textPassword.Location = new System.Drawing.Point(12, 113);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(265, 20);
            this.textPassword.TabIndex = 6;
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(212, 48);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(34, 20);
            this.textSize.TabIndex = 7;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(176, 51);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(30, 13);
            this.labelSize.TabIndex = 8;
            this.labelSize.Text = "Size:";
            // 
            // checkboxLowercase
            // 
            this.checkboxLowercase.AutoSize = true;
            this.checkboxLowercase.Location = new System.Drawing.Point(16, 27);
            this.checkboxLowercase.Name = "checkboxLowercase";
            this.checkboxLowercase.Size = new System.Drawing.Size(113, 17);
            this.checkboxLowercase.TabIndex = 9;
            this.checkboxLowercase.Text = "Lowercase Letters";
            this.checkboxLowercase.UseVisualStyleBackColor = true;
            // 
            // checkboxUppercase
            // 
            this.checkboxUppercase.AutoSize = true;
            this.checkboxUppercase.Location = new System.Drawing.Point(133, 27);
            this.checkboxUppercase.Name = "checkboxUppercase";
            this.checkboxUppercase.Size = new System.Drawing.Size(113, 17);
            this.checkboxUppercase.TabIndex = 10;
            this.checkboxUppercase.Text = "Uppercase Letters";
            this.checkboxUppercase.UseVisualStyleBackColor = true;
            // 
            // checkboxNumbers
            // 
            this.checkboxNumbers.AutoSize = true;
            this.checkboxNumbers.Location = new System.Drawing.Point(16, 50);
            this.checkboxNumbers.Name = "checkboxNumbers";
            this.checkboxNumbers.Size = new System.Drawing.Size(68, 17);
            this.checkboxNumbers.TabIndex = 11;
            this.checkboxNumbers.Text = "Numbers";
            this.checkboxNumbers.UseVisualStyleBackColor = true;
            // 
            // checkboxSymbols
            // 
            this.checkboxSymbols.AutoSize = true;
            this.checkboxSymbols.Location = new System.Drawing.Point(105, 50);
            this.checkboxSymbols.Name = "checkboxSymbols";
            this.checkboxSymbols.Size = new System.Drawing.Size(65, 17);
            this.checkboxSymbols.TabIndex = 12;
            this.checkboxSymbols.Text = "Symbols";
            this.checkboxSymbols.UseVisualStyleBackColor = true;
            // 
            // buttonCopyToClipboard
            // 
            this.buttonCopyToClipboard.Location = new System.Drawing.Point(91, 139);
            this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            this.buttonCopyToClipboard.Size = new System.Drawing.Size(101, 23);
            this.buttonCopyToClipboard.TabIndex = 13;
            this.buttonCopyToClipboard.Text = "Copy to Clipboard";
            this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyToClipboard.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(289, 168);
            this.Controls.Add(this.buttonCopyToClipboard);
            this.Controls.Add(this.checkboxSymbols);
            this.Controls.Add(this.checkboxNumbers);
            this.Controls.Add(this.checkboxUppercase);
            this.Controls.Add(this.checkboxLowercase);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.textSize);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelOptions);
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textPassword;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.CheckBox checkboxLowercase;
        private System.Windows.Forms.CheckBox checkboxUppercase;
        private System.Windows.Forms.CheckBox checkboxNumbers;
        private System.Windows.Forms.CheckBox checkboxSymbols;
        private System.Windows.Forms.Button buttonCopyToClipboard;
    }
}

