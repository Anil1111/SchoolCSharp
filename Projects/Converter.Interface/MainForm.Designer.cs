namespace Converter.Interface
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
            this.fieldNum2 = new System.Windows.Forms.NumericUpDown();
            this.fieldBase2 = new System.Windows.Forms.NumericUpDown();
            this.fieldNum1 = new System.Windows.Forms.NumericUpDown();
            this.fieldBase1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fieldNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBase2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBase1)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldNum2
            // 
            this.fieldNum2.Location = new System.Drawing.Point(149, 12);
            this.fieldNum2.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.fieldNum2.Name = "fieldNum2";
            this.fieldNum2.Size = new System.Drawing.Size(120, 20);
            this.fieldNum2.TabIndex = 1;
            this.fieldNum2.ValueChanged += new System.EventHandler(this.OnCompute);
            // 
            // fieldBase2
            // 
            this.fieldBase2.Location = new System.Drawing.Point(149, 38);
            this.fieldBase2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fieldBase2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fieldBase2.Name = "fieldBase2";
            this.fieldBase2.Size = new System.Drawing.Size(120, 20);
            this.fieldBase2.TabIndex = 1;
            this.fieldBase2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fieldBase2.ValueChanged += new System.EventHandler(this.OnCompute);
            // 
            // fieldNum1
            // 
            this.fieldNum1.Location = new System.Drawing.Point(12, 12);
            this.fieldNum1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.fieldNum1.Name = "fieldNum1";
            this.fieldNum1.Size = new System.Drawing.Size(120, 20);
            this.fieldNum1.TabIndex = 1;
            this.fieldNum1.ValueChanged += new System.EventHandler(this.OnCompute);
            // 
            // fieldBase1
            // 
            this.fieldBase1.Location = new System.Drawing.Point(12, 38);
            this.fieldBase1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fieldBase1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fieldBase1.Name = "fieldBase1";
            this.fieldBase1.Size = new System.Drawing.Size(120, 20);
            this.fieldBase1.TabIndex = 1;
            this.fieldBase1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fieldBase1.ValueChanged += new System.EventHandler(this.OnCompute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 75);
            this.Controls.Add(this.fieldBase1);
            this.Controls.Add(this.fieldBase2);
            this.Controls.Add(this.fieldNum1);
            this.Controls.Add(this.fieldNum2);
            this.Name = "MainForm";
            this.Text = "Convertitore";
            ((System.ComponentModel.ISupportInitialize)(this.fieldNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBase2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBase1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown fieldNum2;
        private System.Windows.Forms.NumericUpDown fieldBase2;
        private System.Windows.Forms.NumericUpDown fieldNum1;
        private System.Windows.Forms.NumericUpDown fieldBase1;
    }
}

