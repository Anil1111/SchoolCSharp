namespace ProductLister
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
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.filterMachineNum = new System.Windows.Forms.NumericUpDown();
            this.filterTypeAll = new System.Windows.Forms.RadioButton();
            this.filterTypeS = new System.Windows.Forms.RadioButton();
            this.filterTypeR = new System.Windows.Forms.RadioButton();
            this.filterTypeC = new System.Windows.Forms.RadioButton();
            this.lblInfoText1 = new System.Windows.Forms.Label();
            this.lblInfoText3 = new System.Windows.Forms.Label();
            this.lblInfoText2 = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.filterMachineNum)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(99, 9);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductCode.Size = new System.Drawing.Size(57, 20);
            this.txtProductCode.MaxLength = 2;
            this.txtProductCode.TabIndex = 0;
            this.txtProductCode.TextChanged += new System.EventHandler(this.OnValidate);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(204, 195);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Text = "0";
            this.txtTotal.Size = new System.Drawing.Size(34, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(163, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "INSERISCI";
            this.btnAdd.Enabled = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OnAdd);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(11, 192);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(75, 23);
            this.btnEmpty.TabIndex = 3;
            this.btnEmpty.Text = "SVUOTA";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.OnEmpty);
            // 
            // filterMachineNum
            // 
            this.filterMachineNum.Location = new System.Drawing.Point(11, 162);
            this.filterMachineNum.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.filterMachineNum.Name = "filterMachineNum";
            this.filterMachineNum.Size = new System.Drawing.Size(75, 20);
            this.filterMachineNum.TabIndex = 4;
            this.filterMachineNum.ValueChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // filterTypeAll
            // 
            this.filterTypeAll.AutoSize = true;
            this.filterTypeAll.Checked = true;
            this.filterTypeAll.Location = new System.Drawing.Point(11, 48);
            this.filterTypeAll.Name = "filterTypeAll";
            this.filterTypeAll.Size = new System.Drawing.Size(46, 17);
            this.filterTypeAll.TabIndex = 5;
            this.filterTypeAll.TabStop = true;
            this.filterTypeAll.Text = "Tutti";
            this.filterTypeAll.UseVisualStyleBackColor = true;
            this.filterTypeAll.CheckedChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // filterTypeS
            // 
            this.filterTypeS.AutoSize = true;
            this.filterTypeS.Location = new System.Drawing.Point(11, 117);
            this.filterTypeS.Name = "filterTypeS";
            this.filterTypeS.Size = new System.Drawing.Size(56, 17);
            this.filterTypeS.TabIndex = 6;
            this.filterTypeS.Text = "Scarto";
            this.filterTypeS.UseVisualStyleBackColor = true;
            this.filterTypeS.CheckedChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // filterTypeR
            // 
            this.filterTypeR.AutoSize = true;
            this.filterTypeR.Location = new System.Drawing.Point(11, 71);
            this.filterTypeR.Name = "filterTypeR";
            this.filterTypeR.Size = new System.Drawing.Size(72, 17);
            this.filterTypeR.TabIndex = 7;
            this.filterTypeR.Text = "Revisione";
            this.filterTypeR.UseVisualStyleBackColor = true;
            this.filterTypeR.CheckedChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // filterTypeC
            // 
            this.filterTypeC.AutoSize = true;
            this.filterTypeC.Location = new System.Drawing.Point(11, 94);
            this.filterTypeC.Name = "filterTypeC";
            this.filterTypeC.Size = new System.Drawing.Size(70, 17);
            this.filterTypeC.TabIndex = 8;
            this.filterTypeC.Text = "Conforme";
            this.filterTypeC.UseVisualStyleBackColor = true;
            this.filterTypeC.CheckedChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // lblInfoText1
            // 
            this.lblInfoText1.AutoSize = true;
            this.lblInfoText1.Location = new System.Drawing.Point(12, 13);
            this.lblInfoText1.Name = "lblInfoText1";
            this.lblInfoText1.Size = new System.Drawing.Size(86, 13);
            this.lblInfoText1.TabIndex = 9;
            this.lblInfoText1.Text = "Codice Prodotto:";
            // 
            // lblInfoText3
            // 
            this.lblInfoText3.AutoSize = true;
            this.lblInfoText3.Location = new System.Drawing.Point(162, 198);
            this.lblInfoText3.Name = "lblInfoText3";
            this.lblInfoText3.Size = new System.Drawing.Size(40, 13);
            this.lblInfoText3.TabIndex = 10;
            this.lblInfoText3.Text = "Totale:";
            // 
            // lblInfoText2
            // 
            this.lblInfoText2.AutoSize = true;
            this.lblInfoText2.Location = new System.Drawing.Point(11, 146);
            this.lblInfoText2.Name = "lblInfoText2";
            this.lblInfoText2.Size = new System.Drawing.Size(68, 13);
            this.lblInfoText2.TabIndex = 11;
            this.lblInfoText2.Text = "Macchinario:";
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(108, 39);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(130, 147);
            this.lstProducts.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 224);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.lblInfoText2);
            this.Controls.Add(this.lblInfoText3);
            this.Controls.Add(this.lblInfoText1);
            this.Controls.Add(this.filterTypeC);
            this.Controls.Add(this.filterTypeR);
            this.Controls.Add(this.filterTypeS);
            this.Controls.Add(this.filterTypeAll);
            this.Controls.Add(this.filterMachineNum);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtProductCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Produzione";
            ((System.ComponentModel.ISupportInitialize)(this.filterMachineNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.NumericUpDown filterMachineNum;
        private System.Windows.Forms.RadioButton filterTypeAll;
        private System.Windows.Forms.RadioButton filterTypeS;
        private System.Windows.Forms.RadioButton filterTypeR;
        private System.Windows.Forms.RadioButton filterTypeC;
        private System.Windows.Forms.Label lblInfoText1;
        private System.Windows.Forms.Label lblInfoText3;
        private System.Windows.Forms.Label lblInfoText2;
        private System.Windows.Forms.ListBox lstProducts;
    }
}

