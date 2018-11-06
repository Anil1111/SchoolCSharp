using System.Drawing;

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
            this.txtNumberLeft = new System.Windows.Forms.TextBox();
            this.txtNumberRight = new System.Windows.Forms.TextBox();
            this.infoText1 = new System.Windows.Forms.Label();
            this.infoText2 = new System.Windows.Forms.Label();
            this.infoText3 = new System.Windows.Forms.Label();
            this.infoText4 = new System.Windows.Forms.Label();
            this.btnLeftToRight = new System.Windows.Forms.Button();
            this.btnRightToLeft = new System.Windows.Forms.Button();
            this.fieldBaseLeft = new System.Windows.Forms.NumericUpDown();
            this.fieldBaseRight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBaseLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBaseRight)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumberLeft
            // 
            this.txtNumberLeft.Location = new System.Drawing.Point(10, 23);
            this.txtNumberLeft.Name = "txtNumberLeft";
            this.txtNumberLeft.Size = new System.Drawing.Size(110, 20);
            this.txtNumberLeft.TabIndex = 0;
            this.txtNumberLeft.TextChanged += new System.EventHandler(this.OnValidatingLeft);
            this.txtNumberLeft.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingLeft);
            // 
            // txtNumberRight
            // 
            this.txtNumberRight.Location = new System.Drawing.Point(200, 23);
            this.txtNumberRight.Name = "txtNumberRight";
            this.txtNumberRight.Size = new System.Drawing.Size(110, 20);
            this.txtNumberRight.TabIndex = 0;
            this.txtNumberRight.TextChanged += new System.EventHandler(this.OnValidatingRight);
            // 
            // infoText1
            // 
            this.infoText1.Location = new System.Drawing.Point(10, 10);
            this.infoText1.Name = "infoText1";
            this.infoText1.Size = new System.Drawing.Size(110, 13);
            this.infoText1.TabIndex = 1;
            this.infoText1.Text = "Numero da convertire";
            this.infoText1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // infoText2
            // 
            this.infoText2.Location = new System.Drawing.Point(10, 47);
            this.infoText2.Name = "infoText2";
            this.infoText2.Size = new System.Drawing.Size(110, 13);
            this.infoText2.TabIndex = 1;
            this.infoText2.Text = "Base";
            this.infoText2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // infoText3
            // 
            this.infoText3.Location = new System.Drawing.Point(200, 10);
            this.infoText3.Name = "infoText3";
            this.infoText3.Size = new System.Drawing.Size(110, 13);
            this.infoText3.TabIndex = 1;
            this.infoText3.Text = "Numero da convertire";
            this.infoText3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // infoText4
            // 
            this.infoText4.Location = new System.Drawing.Point(200, 47);
            this.infoText4.Name = "infoText4";
            this.infoText4.Size = new System.Drawing.Size(110, 13);
            this.infoText4.TabIndex = 1;
            this.infoText4.Text = "Base";
            this.infoText4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnLeftToRight
            // 
            this.btnLeftToRight.Enabled = false;
            this.btnLeftToRight.Location = new System.Drawing.Point(126, 26);
            this.btnLeftToRight.Name = "btnLeftToRight";
            this.btnLeftToRight.Size = new System.Drawing.Size(68, 20);
            this.btnLeftToRight.TabIndex = 2;
            this.btnLeftToRight.Text = "->";
            this.btnLeftToRight.UseVisualStyleBackColor = true;
            this.btnLeftToRight.Click += new System.EventHandler(this.OnLeftToRight);
            // 
            // btnRightToLeft
            // 
            this.btnRightToLeft.Enabled = false;
            this.btnRightToLeft.Location = new System.Drawing.Point(126, 51);
            this.btnRightToLeft.Name = "btnRightToLeft";
            this.btnRightToLeft.Size = new System.Drawing.Size(68, 20);
            this.btnRightToLeft.TabIndex = 2;
            this.btnRightToLeft.Text = "<-";
            this.btnRightToLeft.UseVisualStyleBackColor = true;
            this.btnRightToLeft.Click += new System.EventHandler(this.OnRightToLeft);
            // 
            // fieldBaseLeft
            // 
            this.fieldBaseLeft.Location = new System.Drawing.Point(10, 60);
            this.fieldBaseLeft.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.fieldBaseLeft.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fieldBaseLeft.Name = "fieldBaseLeft";
            this.fieldBaseLeft.Size = new System.Drawing.Size(110, 20);
            this.fieldBaseLeft.TabIndex = 3;
            this.fieldBaseLeft.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fieldBaseLeft.ValueChanged += new System.EventHandler(this.OnValidatingLeft);
            // 
            // fieldBaseRight
            // 
            this.fieldBaseRight.Location = new System.Drawing.Point(200, 60);
            this.fieldBaseRight.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.fieldBaseRight.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fieldBaseRight.Name = "fieldBaseRight";
            this.fieldBaseRight.Size = new System.Drawing.Size(110, 20);
            this.fieldBaseRight.TabIndex = 3;
            this.fieldBaseRight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fieldBaseRight.ValueChanged += new System.EventHandler(this.OnValidatingRight);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 95);
            this.Controls.Add(this.fieldBaseLeft);
            this.Controls.Add(this.fieldBaseRight);
            this.Controls.Add(this.btnRightToLeft);
            this.Controls.Add(this.btnLeftToRight);
            this.Controls.Add(this.infoText4);
            this.Controls.Add(this.infoText2);
            this.Controls.Add(this.infoText3);
            this.Controls.Add(this.infoText1);
            this.Controls.Add(this.txtNumberLeft);
            this.Controls.Add(this.txtNumberRight);
            this.Name = "MainForm";
            this.Text = "Convertitore";
            ((System.ComponentModel.ISupportInitialize)(this.fieldBaseLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBaseRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberLeft;
        private System.Windows.Forms.TextBox txtNumberRight;
        private System.Windows.Forms.NumericUpDown fieldBaseLeft;
        private System.Windows.Forms.NumericUpDown fieldBaseRight;
        private System.Windows.Forms.Label infoText1;
        private System.Windows.Forms.Label infoText2;
        private System.Windows.Forms.Label infoText3;
        private System.Windows.Forms.Label infoText4;
        private System.Windows.Forms.Button btnLeftToRight;
        private System.Windows.Forms.Button btnRightToLeft;
    }
}

