namespace Temperature
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
            this.infoText2 = new System.Windows.Forms.Label();
            this.infoText1 = new System.Windows.Forms.Label();
            this.infoText3 = new System.Windows.Forms.Label();
            this.tempCityAField = new System.Windows.Forms.NumericUpDown();
            this.tempCityBField = new System.Windows.Forms.NumericUpDown();
            this.tempCityCField = new System.Windows.Forms.NumericUpDown();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblAboveAverage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tempCityAField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempCityBField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempCityCField)).BeginInit();
            this.SuspendLayout();
            // 
            // infoText2
            // 
            this.infoText2.AutoSize = true;
            this.infoText2.Location = new System.Drawing.Point(10, 50);
            this.infoText2.Name = "infoText2";
            this.infoText2.Size = new System.Drawing.Size(100, 13);
            this.infoText2.TabIndex = 0;
            this.infoText2.Text = "City B Temperature:";
            // 
            // infoText1
            // 
            this.infoText1.AutoSize = true;
            this.infoText1.Location = new System.Drawing.Point(10, 11);
            this.infoText1.Name = "infoText1";
            this.infoText1.Size = new System.Drawing.Size(100, 13);
            this.infoText1.TabIndex = 1;
            this.infoText1.Text = "City A Temperature:";
            // 
            // infoText3
            // 
            this.infoText3.AutoSize = true;
            this.infoText3.Location = new System.Drawing.Point(10, 89);
            this.infoText3.Name = "infoText3";
            this.infoText3.Size = new System.Drawing.Size(100, 13);
            this.infoText3.TabIndex = 2;
            this.infoText3.Text = "City C Temperature:";
            // 
            // tempCityAField
            // 
            this.tempCityAField.DecimalPlaces = 2;
            this.tempCityAField.Location = new System.Drawing.Point(12, 27);
            this.tempCityAField.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.tempCityAField.Name = "tempCityAField";
            this.tempCityAField.Size = new System.Drawing.Size(120, 20);
            this.tempCityAField.TabIndex = 3;
            this.tempCityAField.ValueChanged += new System.EventHandler(this.OnCompute);
            // 
            // tempCityBField
            // 
            this.tempCityBField.DecimalPlaces = 2;
            this.tempCityBField.Location = new System.Drawing.Point(12, 66);
            this.tempCityBField.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.tempCityBField.Name = "tempCityBField";
            this.tempCityBField.Size = new System.Drawing.Size(120, 20);
            this.tempCityBField.TabIndex = 4;
            this.tempCityBField.ValueChanged += new System.EventHandler(this.OnCompute);
            // 
            // tempCityCField
            // 
            this.tempCityCField.DecimalPlaces = 2;
            this.tempCityCField.Location = new System.Drawing.Point(13, 105);
            this.tempCityCField.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.tempCityCField.Name = "tempCityCField";
            this.tempCityCField.Size = new System.Drawing.Size(120, 20);
            this.tempCityCField.TabIndex = 5;
            this.tempCityCField.ValueChanged += new System.EventHandler(this.OnCompute);
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.Location = new System.Drawing.Point(146, 34);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(38, 16);
            this.lblMaxTemp.TabIndex = 6;
            this.lblMaxTemp.Text = "label";
            this.lblMaxTemp.Visible = false;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(146, 58);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(38, 16);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.Text = "label";
            this.lblAverage.Visible = false;
            // 
            // lblAboveAverage
            // 
            this.lblAboveAverage.AutoSize = true;
            this.lblAboveAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboveAverage.Location = new System.Drawing.Point(146, 82);
            this.lblAboveAverage.Name = "lblAboveAverage";
            this.lblAboveAverage.Size = new System.Drawing.Size(38, 16);
            this.lblAboveAverage.TabIndex = 8;
            this.lblAboveAverage.Text = "label";
            this.lblAboveAverage.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 131);
            this.Controls.Add(this.lblAboveAverage);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblMaxTemp);
            this.Controls.Add(this.tempCityCField);
            this.Controls.Add(this.tempCityBField);
            this.Controls.Add(this.tempCityAField);
            this.Controls.Add(this.infoText3);
            this.Controls.Add(this.infoText1);
            this.Controls.Add(this.infoText2);
            this.Name = "MainForm";
            this.Text = "Temperature";
            ((System.ComponentModel.ISupportInitialize)(this.tempCityAField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempCityBField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempCityCField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoText2;
        private System.Windows.Forms.Label infoText1;
        private System.Windows.Forms.Label infoText3;
        private System.Windows.Forms.NumericUpDown tempCityAField;
        private System.Windows.Forms.NumericUpDown tempCityBField;
        private System.Windows.Forms.NumericUpDown tempCityCField;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblAboveAverage;
    }
}

