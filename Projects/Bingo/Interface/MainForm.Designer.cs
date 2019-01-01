namespace Bingo.Interface
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
            this.lblInfoText = new System.Windows.Forms.Label();
            this.txtLastExtracted = new System.Windows.Forms.RichTextBox();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.billboard = new Bingo.Interface.Billboard();
            this.lblInfoText1 = new System.Windows.Forms.Label();
            this.sortNumber = new System.Windows.Forms.RadioButton();
            this.sortExtraction = new System.Windows.Forms.RadioButton();
            this.groupBoxSortBy = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.groupBoxSortBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExtract
            // 
            this.btnExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExtract.Location = new System.Drawing.Point(120, 357);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(136, 38);
            this.btnExtract.TabIndex = 1;
            this.btnExtract.Text = "Estrai";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.OnExtract);
            // 
            // lblInfoText
            // 
            this.lblInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblInfoText.Location = new System.Drawing.Point(127, 9);
            this.lblInfoText.Name = "lblInfoText";
            this.lblInfoText.Size = new System.Drawing.Size(129, 18);
            this.lblInfoText.TabIndex = 2;
            this.lblInfoText.Text = "Ultima estrazione:";
            this.lblInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLastExtracted
            // 
            this.txtLastExtracted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastExtracted.DetectUrls = false;
            this.txtLastExtracted.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.txtLastExtracted.Location = new System.Drawing.Point(150, 30);
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
            this.lstNumbers.Location = new System.Drawing.Point(12, 27);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.ScrollAlwaysVisible = true;
            this.lstNumbers.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstNumbers.Size = new System.Drawing.Size(102, 370);
            this.lstNumbers.TabIndex = 4;
            this.lstNumbers.UseTabStops = false;
            // 
            // billboard
            // 
            this.billboard.CellSize = 30;
            this.billboard.CellSpacing = 10;
            this.billboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.billboard.ForeColor = System.Drawing.Color.White;
            this.billboard.Free = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.billboard.LastShown = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.billboard.Location = new System.Drawing.Point(262, 10);
            this.billboard.Name = "billboard";
            this.billboard.Shown = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.billboard.Size = new System.Drawing.Size(409, 385);
            this.billboard.TabIndex = 0;
            this.billboard.TabStop = false;
            this.billboard.Extracted += new System.EventHandler<Bingo.Events.ExtractedEventArgs>(this.OnExtracted);
            // 
            // lblInfoText1
            // 
            this.lblInfoText1.Location = new System.Drawing.Point(12, 9);
            this.lblInfoText1.Name = "lblInfoText1";
            this.lblInfoText1.Size = new System.Drawing.Size(102, 15);
            this.lblInfoText1.TabIndex = 6;
            this.lblInfoText1.Text = "Estrazione - Numero";
            this.lblInfoText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortNumber
            // 
            this.sortNumber.AutoSize = true;
            this.sortNumber.Location = new System.Drawing.Point(20, 25);
            this.sortNumber.Name = "sortNumber";
            this.sortNumber.Size = new System.Drawing.Size(62, 17);
            this.sortNumber.TabIndex = 7;
            this.sortNumber.Text = "Numero";
            this.sortNumber.UseVisualStyleBackColor = true;
            // 
            // sortExtraction
            // 
            this.sortExtraction.AutoSize = true;
            this.sortExtraction.Checked = true;
            this.sortExtraction.Location = new System.Drawing.Point(20, 48);
            this.sortExtraction.Name = "sortExtraction";
            this.sortExtraction.Size = new System.Drawing.Size(74, 17);
            this.sortExtraction.TabIndex = 7;
            this.sortExtraction.TabStop = true;
            this.sortExtraction.Text = "Estrazione";
            this.sortExtraction.UseVisualStyleBackColor = true;
            this.sortExtraction.CheckedChanged += new System.EventHandler(this.OnSortChanged);
            // 
            // groupBoxSortBy
            // 
            this.groupBoxSortBy.Controls.Add(this.sortNumber);
            this.groupBoxSortBy.Controls.Add(this.sortExtraction);
            this.groupBoxSortBy.Location = new System.Drawing.Point(130, 159);
            this.groupBoxSortBy.Name = "groupBoxSortBy";
            this.groupBoxSortBy.Size = new System.Drawing.Size(113, 78);
            this.groupBoxSortBy.TabIndex = 9;
            this.groupBoxSortBy.TabStop = false;
            this.groupBoxSortBy.Text = "Ordina per";
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRestore.Location = new System.Drawing.Point(120, 313);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(136, 38);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Ripristina";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.OnRestore);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 407);
            this.Controls.Add(this.groupBoxSortBy);
            this.Controls.Add(this.lblInfoText1);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.txtLastExtracted);
            this.Controls.Add(this.lblInfoText);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.billboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bingo";
            this.groupBoxSortBy.ResumeLayout(false);
            this.groupBoxSortBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bingo.Interface.Billboard billboard;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Label lblInfoText;
        private System.Windows.Forms.RichTextBox txtLastExtracted;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Label lblInfoText1;
        private System.Windows.Forms.RadioButton sortNumber;
        private System.Windows.Forms.RadioButton sortExtraction;
        private System.Windows.Forms.GroupBox groupBoxSortBy;
        private System.Windows.Forms.Button btnRestore;
    }
}

