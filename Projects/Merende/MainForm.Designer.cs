namespace Merende
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkSaltyBrioche = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkCoffee = new System.Windows.Forms.CheckBox();
            this.chkBrioche = new System.Windows.Forms.CheckBox();
            this.chkCappuccino = new System.Windows.Forms.CheckBox();
            this.chkJuice = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scegli la tua colazione";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Merende.Properties.Resources.coffee;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 83);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Merende.Properties.Resources.brioche;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(156, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Merende.Properties.Resources.saltybrioche;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(156, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 95);
            this.panel3.TabIndex = 1;
            // 
            // chkSaltyBrioche
            // 
            this.chkSaltyBrioche.AutoSize = true;
            this.chkSaltyBrioche.Location = new System.Drawing.Point(156, 283);
            this.chkSaltyBrioche.Name = "chkSaltyBrioche";
            this.chkSaltyBrioche.Size = new System.Drawing.Size(93, 17);
            this.chkSaltyBrioche.TabIndex = 2;
            this.chkSaltyBrioche.Text = "Brioche salata";
            this.chkSaltyBrioche.UseVisualStyleBackColor = true;
            this.chkSaltyBrioche.CheckedChanged += new System.EventHandler(this.OnSelectionChange);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Merende.Properties.Resources.cappuccino;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(12, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(133, 112);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Merende.Properties.Resources.juice;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(12, 321);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(117, 112);
            this.panel5.TabIndex = 1;
            // 
            // chkCoffee
            // 
            this.chkCoffee.AutoSize = true;
            this.chkCoffee.Location = new System.Drawing.Point(12, 142);
            this.chkCoffee.Name = "chkCoffee";
            this.chkCoffee.Size = new System.Drawing.Size(51, 17);
            this.chkCoffee.TabIndex = 2;
            this.chkCoffee.Text = "Caffè";
            this.chkCoffee.UseVisualStyleBackColor = true;
            this.chkCoffee.CheckedChanged += new System.EventHandler(this.OnSelectionChange);
            // 
            // chkBrioche
            // 
            this.chkBrioche.AutoSize = true;
            this.chkBrioche.Location = new System.Drawing.Point(156, 159);
            this.chkBrioche.Name = "chkBrioche";
            this.chkBrioche.Size = new System.Drawing.Size(62, 17);
            this.chkBrioche.TabIndex = 2;
            this.chkBrioche.Text = "Brioche";
            this.chkBrioche.UseVisualStyleBackColor = true;
            this.chkBrioche.CheckedChanged += new System.EventHandler(this.OnSelectionChange);
            // 
            // chkCappuccino
            // 
            this.chkCappuccino.AutoSize = true;
            this.chkCappuccino.Location = new System.Drawing.Point(12, 298);
            this.chkCappuccino.Name = "chkCappuccino";
            this.chkCappuccino.Size = new System.Drawing.Size(83, 17);
            this.chkCappuccino.TabIndex = 2;
            this.chkCappuccino.Text = "Cappuccino";
            this.chkCappuccino.UseVisualStyleBackColor = true;
            this.chkCappuccino.CheckedChanged += new System.EventHandler(this.OnSelectionChange);
            // 
            // chkJuice
            // 
            this.chkJuice.AutoSize = true;
            this.chkJuice.Location = new System.Drawing.Point(12, 439);
            this.chkJuice.Name = "chkJuice";
            this.chkJuice.Size = new System.Drawing.Size(71, 17);
            this.chkJuice.TabIndex = 2;
            this.chkJuice.Text = "Spremuta";
            this.chkJuice.UseVisualStyleBackColor = true;
            this.chkJuice.CheckedChanged += new System.EventHandler(this.OnSelectionChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(170, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Costo totale";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPrice.Location = new System.Drawing.Point(170, 354);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(106, 22);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "0,00 €";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(156, 389);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 37);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Invia";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.OnSubmit);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 461);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkJuice);
            this.Controls.Add(this.chkCappuccino);
            this.Controls.Add(this.chkBrioche);
            this.Controls.Add(this.chkCoffee);
            this.Controls.Add(this.chkSaltyBrioche);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Merenda 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chkSaltyBrioche;
        private System.Windows.Forms.CheckBox chkCoffee;
        private System.Windows.Forms.CheckBox chkBrioche;
        private System.Windows.Forms.CheckBox chkCappuccino;
        private System.Windows.Forms.CheckBox chkJuice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnSubmit;
    }
}