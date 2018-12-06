namespace FiscalCodeValidator
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
            this.txtFiscalCode = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblPlaceOfBirth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFiscalCode
            // 
            this.txtFiscalCode.Location = new System.Drawing.Point(12, 12);
            this.txtFiscalCode.Name = "txtFiscalCode";
            this.txtFiscalCode.Size = new System.Drawing.Size(233, 20);
            this.txtFiscalCode.TabIndex = 0;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(252, 12);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 19);
            this.btnCompute.TabIndex = 1;
            this.btnCompute.Text = "Calcola";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.OnCompute);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(12, 44);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(35, 13);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "label1";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(12, 57);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(35, 13);
            this.lblDateOfBirth.TabIndex = 2;
            this.lblDateOfBirth.Text = "label1";
            // 
            // lblPlaceOfBirth
            // 
            this.lblPlaceOfBirth.AutoSize = true;
            this.lblPlaceOfBirth.Location = new System.Drawing.Point(12, 70);
            this.lblPlaceOfBirth.Name = "lblPlaceOfBirth";
            this.lblPlaceOfBirth.Size = new System.Drawing.Size(35, 13);
            this.lblPlaceOfBirth.TabIndex = 2;
            this.lblPlaceOfBirth.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 42);
            this.Controls.Add(this.lblPlaceOfBirth);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtFiscalCode);
            this.Name = "MainForm";
            this.Text = "Fiscal Code Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiscalCode;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblPlaceOfBirth;
    }
}

