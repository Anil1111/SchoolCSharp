namespace Calendar
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
            this.infoLabelYear = new System.Windows.Forms.Label();
            this.infoLabelSeparator1 = new System.Windows.Forms.Label();
            this.infoLabelSeparator2 = new System.Windows.Forms.Label();
            this.lblElapsedDays = new System.Windows.Forms.Label();
            this.lblWeekDay = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.fieldMonth = new System.Windows.Forms.NumericUpDown();
            this.fieldDay = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fieldMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldDay)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabelYear
            // 
            this.infoLabelYear.AutoSize = true;
            this.infoLabelYear.Location = new System.Drawing.Point(228, 14);
            this.infoLabelYear.Name = "infoLabelYear";
            this.infoLabelYear.Size = new System.Drawing.Size(31, 13);
            this.infoLabelYear.TabIndex = 1;
            this.infoLabelYear.Text = "2018";
            // 
            // infoLabelSeparator1
            // 
            this.infoLabelSeparator1.AutoSize = true;
            this.infoLabelSeparator1.Location = new System.Drawing.Point(145, 14);
            this.infoLabelSeparator1.Name = "infoLabelSeparator1";
            this.infoLabelSeparator1.Size = new System.Drawing.Size(12, 13);
            this.infoLabelSeparator1.TabIndex = 1;
            this.infoLabelSeparator1.Text = "/";
            // 
            // infoLabelSeparator2
            // 
            this.infoLabelSeparator2.AutoSize = true;
            this.infoLabelSeparator2.Location = new System.Drawing.Point(210, 14);
            this.infoLabelSeparator2.Name = "infoLabelSeparator2";
            this.infoLabelSeparator2.Size = new System.Drawing.Size(12, 13);
            this.infoLabelSeparator2.TabIndex = 1;
            this.infoLabelSeparator2.Text = "/";
            // 
            // lblElapsedDays
            // 
            this.lblElapsedDays.Location = new System.Drawing.Point(24, 34);
            this.lblElapsedDays.Name = "lblElapsedDays";
            this.lblElapsedDays.Size = new System.Drawing.Size(235, 28);
            this.lblElapsedDays.TabIndex = 3;
            this.lblElapsedDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeekDay
            // 
            this.lblWeekDay.AutoSize = true;
            this.lblWeekDay.Location = new System.Drawing.Point(24, 14);
            this.lblWeekDay.Name = "lblWeekDay";
            this.lblWeekDay.Size = new System.Drawing.Size(43, 13);
            this.lblWeekDay.TabIndex = 3;
            this.lblWeekDay.Text = "Venerdi";
            // 
            // datePicker
            // 
            this.datePicker.Checked = false;
            this.datePicker.Location = new System.Drawing.Point(27, 65);
            this.datePicker.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(230, 20);
            this.datePicker.TabIndex = 4;
            this.datePicker.ValueChanged += new System.EventHandler(this.OnDateChange);
            // 
            // fieldMonth
            // 
            this.fieldMonth.Location = new System.Drawing.Point(163, 11);
            this.fieldMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.fieldMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fieldMonth.Name = "fieldMonth";
            this.fieldMonth.Size = new System.Drawing.Size(41, 20);
            this.fieldMonth.TabIndex = 5;
            this.fieldMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fieldMonth.ValueChanged += new System.EventHandler(this.OnDateChange);
            // 
            // fieldDay
            // 
            this.fieldDay.Location = new System.Drawing.Point(98, 11);
            this.fieldDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.fieldDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fieldDay.Name = "fieldDay";
            this.fieldDay.Size = new System.Drawing.Size(41, 20);
            this.fieldDay.TabIndex = 5;
            this.fieldDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fieldDay.ValueChanged += new System.EventHandler(this.OnDateChange);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 94);
            this.Controls.Add(this.fieldDay);
            this.Controls.Add(this.fieldMonth);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblWeekDay);
            this.Controls.Add(this.lblElapsedDays);
            this.Controls.Add(this.infoLabelSeparator2);
            this.Controls.Add(this.infoLabelSeparator1);
            this.Controls.Add(this.infoLabelYear);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.fieldMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label infoLabelYear;
        private System.Windows.Forms.Label infoLabelSeparator1;
        private System.Windows.Forms.Label infoLabelSeparator2;
        private System.Windows.Forms.Label lblElapsedDays;
        private System.Windows.Forms.Label lblWeekDay;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.NumericUpDown fieldMonth;
        private System.Windows.Forms.NumericUpDown fieldDay;
    }
}

