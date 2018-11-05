namespace Discoteca
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
            this.adultField = new System.Windows.Forms.NumericUpDown();
            this.underageField = new System.Windows.Forms.NumericUpDown();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.computeButton = new System.Windows.Forms.Button();
            this.lblUnderagePrice = new System.Windows.Forms.Label();
            this.lblAdultPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adultField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underageField)).BeginInit();
            this.SuspendLayout();
            // 
            // adultField
            // 
            this.adultField.Location = new System.Drawing.Point(10, 25);
            this.adultField.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.adultField.Name = "adultField";
            this.adultField.Size = new System.Drawing.Size(120, 20);
            this.adultField.TabIndex = 0;
            this.adultField.ValueChanged += new System.EventHandler(this.OnCompute);
            // 
            // underageField
            // 
            this.underageField.Location = new System.Drawing.Point(10, 67);
            this.underageField.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.underageField.Name = "underageField";
            this.underageField.Size = new System.Drawing.Size(120, 20);
            this.underageField.TabIndex = 1;
            this.underageField.ValueChanged += new System.EventHandler(this.OnCompute);
            // 
            // infoLabel1
            // 
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.Location = new System.Drawing.Point(7, 9);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(83, 13);
            this.infoLabel1.TabIndex = 2;
            this.infoLabel1.Text = "Numero di adulti";
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.Location = new System.Drawing.Point(7, 51);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(103, 13);
            this.infoLabel2.TabIndex = 3;
            this.infoLabel2.Text = "Numero di minorenni";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.Location = new System.Drawing.Point(145, 37);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(45, 16);
            this.lblTotalCount.TabIndex = 4;
            this.lblTotalCount.Text = "label1";
            this.lblTotalCount.Visible = false;
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(10, 93);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(120, 28);
            this.computeButton.TabIndex = 5;
            this.computeButton.Text = "Compute";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.OnCompute);
            // 
            // lblUnderagePrice
            // 
            this.lblUnderagePrice.AutoSize = true;
            this.lblUnderagePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnderagePrice.Location = new System.Drawing.Point(145, 52);
            this.lblUnderagePrice.Name = "lblUnderagePrice";
            this.lblUnderagePrice.Size = new System.Drawing.Size(45, 16);
            this.lblUnderagePrice.TabIndex = 4;
            this.lblUnderagePrice.Text = "label1";
            this.lblUnderagePrice.Visible = false;
            // 
            // lblAdultPrice
            // 
            this.lblAdultPrice.AutoSize = true;
            this.lblAdultPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultPrice.Location = new System.Drawing.Point(145, 67);
            this.lblAdultPrice.Name = "lblAdultPrice";
            this.lblAdultPrice.Size = new System.Drawing.Size(45, 16);
            this.lblAdultPrice.TabIndex = 4;
            this.lblAdultPrice.Text = "label1";
            this.lblAdultPrice.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 126);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.lblAdultPrice);
            this.Controls.Add(this.lblUnderagePrice);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.infoLabel1);
            this.Controls.Add(this.underageField);
            this.Controls.Add(this.adultField);
            this.Name = "MainForm";
            this.Text = "Entrate Discoteca";
            ((System.ComponentModel.ISupportInitialize)(this.adultField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underageField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown adultField;
        private System.Windows.Forms.NumericUpDown underageField;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Label lblUnderagePrice;
        private System.Windows.Forms.Label lblAdultPrice;
    }
}

