namespace Bingo
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
            this.btnExtract = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastExtracted = new System.Windows.Forms.RichTextBox();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.chkSort = new System.Windows.Forms.CheckBox();
            this.billboard = new Bingo.Billboard();
            this.SuspendLayout();
            // 
            // btnExtract
            // 
            this.btnExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExtract.Location = new System.Drawing.Point(12, 365);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(102, 38);
            this.btnExtract.TabIndex = 1;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.OnExtract);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last extracted:";
            // 
            // txtLastExtracted
            // 
            this.txtLastExtracted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastExtracted.DetectUrls = false;
            this.txtLastExtracted.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.txtLastExtracted.Location = new System.Drawing.Point(21, 37);
            this.txtLastExtracted.MaxLength = 2;
            this.txtLastExtracted.Multiline = false;
            this.txtLastExtracted.Name = "txtLastExtracted";
            this.txtLastExtracted.ReadOnly = true;
            this.txtLastExtracted.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtLastExtracted.Size = new System.Drawing.Size(80, 80);
            this.txtLastExtracted.TabIndex = 3;
            this.txtLastExtracted.TabStop = false;
            this.txtLastExtracted.Text = "00";
            this.txtLastExtracted.WordWrap = false;
            // 
            // lstNumbers
            // 
            this.lstNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstNumbers.ItemHeight = 16;
            this.lstNumbers.Location = new System.Drawing.Point(12, 123);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.ScrollAlwaysVisible = true;
            this.lstNumbers.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstNumbers.Size = new System.Drawing.Size(102, 210);
            this.lstNumbers.TabIndex = 4;
            this.lstNumbers.UseTabStops = false;
            // 
            // chkSort
            // 
            this.chkSort.AutoSize = true;
            this.chkSort.Location = new System.Drawing.Point(12, 339);
            this.chkSort.Name = "chkSort";
            this.chkSort.Size = new System.Drawing.Size(45, 17);
            this.chkSort.TabIndex = 5;
            this.chkSort.Text = "Sort";
            this.chkSort.UseVisualStyleBackColor = true;
            this.chkSort.CheckedChanged += new System.EventHandler(this.OnSortChanged);
            // 
            // billboard
            // 
            this.billboard.CellSize = 30;
            this.billboard.CellSpacing = 10;
            this.billboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.billboard.ForeColor = System.Drawing.Color.White;
            this.billboard.Free = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.billboard.LastShown = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.billboard.Location = new System.Drawing.Point(174, 12);
            this.billboard.Name = "billboard";
            this.billboard.Shown = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.billboard.Size = new System.Drawing.Size(410, 391);
            this.billboard.TabIndex = 0;
            this.billboard.TabStop = false;
            this.billboard.Extracted += new System.EventHandler<Bingo.ExtractedEventArgs>(this.OnExtracted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 415);
            this.Controls.Add(this.chkSort);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.txtLastExtracted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.billboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bingo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Billboard billboard;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtLastExtracted;
        private System.Windows.Forms.CheckBox chkSort;
        private System.Windows.Forms.ListBox lstNumbers;
    }
}

