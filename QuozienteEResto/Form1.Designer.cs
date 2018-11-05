namespace QuozienteEResto
{
    partial class Form1
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
            this.numberField1 = new System.Windows.Forms.NumericUpDown();
            this.lblRemainder = new System.Windows.Forms.Label();
            this.lblQuotient = new System.Windows.Forms.Label();
            this.numberField2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberField1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberField2)).BeginInit();
            this.SuspendLayout();
            // 
            // numberField1
            // 
            this.numberField1.DecimalPlaces = 2;
            this.numberField1.Location = new System.Drawing.Point(12, 12);
            this.numberField1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numberField1.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numberField1.Name = "numberField1";
            this.numberField1.Size = new System.Drawing.Size(120, 20);
            this.numberField1.TabIndex = 0;
            this.numberField1.ValueChanged += new System.EventHandler(this.OnCompute);
            // 
            // lblRemainder
            // 
            this.lblRemainder.AutoSize = true;
            this.lblRemainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainder.Location = new System.Drawing.Point(9, 56);
            this.lblRemainder.Name = "lblRemainder";
            this.lblRemainder.Size = new System.Drawing.Size(41, 15);
            this.lblRemainder.TabIndex = 1;
            this.lblRemainder.Text = "label1";
            this.lblRemainder.Visible = false;
            // 
            // lblQuotient
            // 
            this.lblQuotient.AutoSize = true;
            this.lblQuotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuotient.Location = new System.Drawing.Point(9, 38);
            this.lblQuotient.Name = "lblQuotient";
            this.lblQuotient.Size = new System.Drawing.Size(41, 15);
            this.lblQuotient.TabIndex = 1;
            this.lblQuotient.Text = "label1";
            this.lblQuotient.Visible = false;
            // 
            // numberField2
            // 
            this.numberField2.DecimalPlaces = 2;
            this.numberField2.Location = new System.Drawing.Point(136, 12);
            this.numberField2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numberField2.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numberField2.Name = "numberField2";
            this.numberField2.Size = new System.Drawing.Size(120, 20);
            this.numberField2.TabIndex = 1;
            this.numberField2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberField2.ValueChanged += new System.EventHandler(this.OnCompute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 84);
            this.Controls.Add(this.lblQuotient);
            this.Controls.Add(this.lblRemainder);
            this.Controls.Add(this.numberField2);
            this.Controls.Add(this.numberField1);
            this.Name = "Form1";
            this.Text = "Divisione senza diviso";
            ((System.ComponentModel.ISupportInitialize)(this.numberField1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberField2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numberField1;
        private System.Windows.Forms.Label lblRemainder;
        private System.Windows.Forms.Label lblQuotient;
        private System.Windows.Forms.NumericUpDown numberField2;
    }
}

