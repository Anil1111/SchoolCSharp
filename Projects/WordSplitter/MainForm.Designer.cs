namespace WordSplitter
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtInputText = new System.Windows.Forms.RichTextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lsbWords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtInputText
            // 
            this.txtInputText.Location = new System.Drawing.Point(12, 12);
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(668, 60);
            this.txtInputText.TabIndex = 0;
            this.txtInputText.Text = resources.GetString("txtInputText.Text");
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(686, 12);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(86, 60);
            this.btnCompute.TabIndex = 1;
            this.btnCompute.Text = "Separa";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.OnCompute);
            // 
            // lsbWords
            // 
            this.lsbWords.FormattingEnabled = true;
            this.lsbWords.Location = new System.Drawing.Point(12, 78);
            this.lsbWords.Name = "lsbWords";
            this.lsbWords.Size = new System.Drawing.Size(760, 368);
            this.lsbWords.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lsbWords);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtInputText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "WordSplitter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInputText;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.ListBox lsbWords;
    }
}

