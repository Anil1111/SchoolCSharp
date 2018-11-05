namespace Fotocopie.Interface
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
            this.infoText1 = new System.Windows.Forms.Label();
            this.infoText2 = new System.Windows.Forms.Label();
            this.lblPhotocopies = new System.Windows.Forms.Label();
            this.lblWhiteAndBlackPrice = new System.Windows.Forms.Label();
            this.whiteBlacksPhotocopies = new System.Windows.Forms.NumericUpDown();
            this.coloredPhotocopies = new System.Windows.Forms.NumericUpDown();
            this.lblColoredPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBlacksPhotocopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloredPhotocopies)).BeginInit();
            this.SuspendLayout();
            // 
            // infoText1
            // 
            this.infoText1.AutoSize = true;
            this.infoText1.Location = new System.Drawing.Point(16, 14);
            this.infoText1.Name = "infoText1";
            this.infoText1.Size = new System.Drawing.Size(133, 13);
            this.infoText1.TabIndex = 3;
            this.infoText1.Text = "Fotocopie in bianco e nero";
            // 
            // infoText2
            // 
            this.infoText2.AutoSize = true;
            this.infoText2.Location = new System.Drawing.Point(16, 57);
            this.infoText2.Name = "infoText2";
            this.infoText2.Size = new System.Drawing.Size(92, 13);
            this.infoText2.TabIndex = 3;
            this.infoText2.Text = "Fotocopie a Colori";
            // 
            // lblPhotocopies
            // 
            this.lblPhotocopies.AutoSize = true;
            this.lblPhotocopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotocopies.Location = new System.Drawing.Point(149, 45);
            this.lblPhotocopies.Name = "lblPhotocopies";
            this.lblPhotocopies.Size = new System.Drawing.Size(124, 16);
            this.lblPhotocopies.TabIndex = 4;
            this.lblPhotocopies.Text = "Numero fotocopie...";
            // 
            // lblWhiteAndBlackPrice
            // 
            this.lblWhiteAndBlackPrice.AutoSize = true;
            this.lblWhiteAndBlackPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhiteAndBlackPrice.Location = new System.Drawing.Point(149, 61);
            this.lblWhiteAndBlackPrice.Name = "lblWhiteAndBlackPrice";
            this.lblWhiteAndBlackPrice.Size = new System.Drawing.Size(215, 16);
            this.lblWhiteAndBlackPrice.TabIndex = 4;
            this.lblWhiteAndBlackPrice.Text = "Prezzo fotocopie in bianco e nero...";
            // 
            // whiteBlacksPhotocopies
            // 
            this.whiteBlacksPhotocopies.Location = new System.Drawing.Point(19, 30);
            this.whiteBlacksPhotocopies.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.whiteBlacksPhotocopies.Name = "whiteBlacksPhotocopies";
            this.whiteBlacksPhotocopies.Size = new System.Drawing.Size(100, 20);
            this.whiteBlacksPhotocopies.TabIndex = 0;
            this.whiteBlacksPhotocopies.ValueChanged += new System.EventHandler(this.OnCompute);
            // 
            // coloredPhotocopies
            // 
            this.coloredPhotocopies.Location = new System.Drawing.Point(19, 73);
            this.coloredPhotocopies.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.coloredPhotocopies.Name = "coloredPhotocopies";
            this.coloredPhotocopies.Size = new System.Drawing.Size(100, 20);
            this.coloredPhotocopies.TabIndex = 1;
            this.coloredPhotocopies.ValueChanged += new System.EventHandler(this.OnCompute);
            // 
            // lblColoredPrice
            // 
            this.lblColoredPrice.AutoSize = true;
            this.lblColoredPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColoredPrice.Location = new System.Drawing.Point(149, 77);
            this.lblColoredPrice.Name = "lblColoredPrice";
            this.lblColoredPrice.Size = new System.Drawing.Size(164, 16);
            this.lblColoredPrice.TabIndex = 4;
            this.lblColoredPrice.Text = "Prezzo fotocopie a colori...";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(149, 93);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(94, 16);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Prezzo totale...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcola";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnCompute);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 146);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.coloredPhotocopies);
            this.Controls.Add(this.whiteBlacksPhotocopies);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblColoredPrice);
            this.Controls.Add(this.lblWhiteAndBlackPrice);
            this.Controls.Add(this.lblPhotocopies);
            this.Controls.Add(this.infoText2);
            this.Controls.Add(this.infoText1);
            this.Name = "MainForm";
            this.Text = "Printer Window";
            ((System.ComponentModel.ISupportInitialize)(this.whiteBlacksPhotocopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloredPhotocopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label infoText1;
        private System.Windows.Forms.Label infoText2;
        private System.Windows.Forms.Label lblPhotocopies;
        private System.Windows.Forms.Label lblWhiteAndBlackPrice;
        private System.Windows.Forms.NumericUpDown whiteBlacksPhotocopies;
        private System.Windows.Forms.NumericUpDown coloredPhotocopies;
        private System.Windows.Forms.Label lblColoredPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button button1;
    }
}

