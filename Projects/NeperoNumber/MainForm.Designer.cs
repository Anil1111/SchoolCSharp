namespace NeperoNumber
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
            this.fieldIterations = new System.Windows.Forms.NumericUpDown();
            this.lblValue = new System.Windows.Forms.Label();
            this.infoText1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fieldIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldIterations
            // 
            this.fieldIterations.Location = new System.Drawing.Point(132, 12);
            this.fieldIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fieldIterations.Name = "fieldIterations";
            this.fieldIterations.Size = new System.Drawing.Size(120, 20);
            this.fieldIterations.TabIndex = 0;
            this.fieldIterations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fieldIterations.ValueChanged += new System.EventHandler(this.OnIterationsChanged);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(12, 32);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(19, 13);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "e: ";
            // 
            // infoText1
            // 
            this.infoText1.AutoSize = true;
            this.infoText1.Location = new System.Drawing.Point(12, 14);
            this.infoText1.Name = "infoText1";
            this.infoText1.Size = new System.Drawing.Size(104, 13);
            this.infoText1.TabIndex = 1;
            this.infoText1.Text = "Number of iterations:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 54);
            this.Controls.Add(this.infoText1);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.fieldIterations);
            this.Name = "MainForm";
            this.Text = "Nepero Number";
            this.Load += new System.EventHandler(this.OnIterationsChanged);
            ((System.ComponentModel.ISupportInitialize)(this.fieldIterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown fieldIterations;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label infoText1;
    }
}

