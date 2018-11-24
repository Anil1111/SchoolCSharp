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
            this.lblTitleInfoText = new System.Windows.Forms.Label();
            this.imgCoffee = new System.Windows.Forms.Panel();
            this.lblCoffeePrice = new System.Windows.Forms.Label();
            this.imgBrioche = new System.Windows.Forms.Panel();
            this.lblBriochePrice = new System.Windows.Forms.Label();
            this.imgSaltyBrioche = new System.Windows.Forms.Panel();
            this.lblSaltyBriochePrice = new System.Windows.Forms.Label();
            this.chkSaltyBrioche = new System.Windows.Forms.CheckBox();
            this.imgCappuccino = new System.Windows.Forms.Panel();
            this.lblCappuccinoPrice = new System.Windows.Forms.Label();
            this.imgJuice = new System.Windows.Forms.Panel();
            this.lblJuicePrice = new System.Windows.Forms.Label();
            this.groupPanel = new System.Windows.Forms.Panel();
            this.chkBrioche = new System.Windows.Forms.CheckBox();
            this.chkCappuccino = new System.Windows.Forms.CheckBox();
            this.chkCoffee = new System.Windows.Forms.CheckBox();
            this.chkJuice = new System.Windows.Forms.CheckBox();
            this.lblInfoText = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.imgCoffee.SuspendLayout();
            this.imgBrioche.SuspendLayout();
            this.imgSaltyBrioche.SuspendLayout();
            this.imgCappuccino.SuspendLayout();
            this.imgJuice.SuspendLayout();
            this.groupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleInfoText
            // 
            this.lblTitleInfoText.AutoSize = true;
            this.lblTitleInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleInfoText.ForeColor = System.Drawing.Color.Red;
            this.lblTitleInfoText.Location = new System.Drawing.Point(50, 9);
            this.lblTitleInfoText.Name = "lblTitleInfoText";
            this.lblTitleInfoText.Size = new System.Drawing.Size(197, 24);
            this.lblTitleInfoText.TabIndex = 0;
            this.lblTitleInfoText.Text = "Scegli la tua colazione";
            // 
            // imgCoffee
            // 
            this.imgCoffee.BackgroundImage = global::Merende.Properties.Resources.coffee;
            this.imgCoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCoffee.Controls.Add(this.lblCoffeePrice);
            this.imgCoffee.Location = new System.Drawing.Point(12, 53);
            this.imgCoffee.Name = "imgCoffee";
            this.imgCoffee.Size = new System.Drawing.Size(117, 83);
            this.imgCoffee.TabIndex = 1;
            // 
            // lblCoffeePrice
            // 
            this.lblCoffeePrice.AutoSize = true;
            this.lblCoffeePrice.Location = new System.Drawing.Point(80, 0);
            this.lblCoffeePrice.Name = "lblCoffeePrice";
            this.lblCoffeePrice.Size = new System.Drawing.Size(37, 13);
            this.lblCoffeePrice.TabIndex = 5;
            this.lblCoffeePrice.Text = "1,00 €";
            // 
            // imgBrioche
            // 
            this.imgBrioche.BackgroundImage = global::Merende.Properties.Resources.brioche;
            this.imgBrioche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBrioche.Controls.Add(this.lblBriochePrice);
            this.imgBrioche.Location = new System.Drawing.Point(156, 53);
            this.imgBrioche.Name = "imgBrioche";
            this.imgBrioche.Size = new System.Drawing.Size(120, 100);
            this.imgBrioche.TabIndex = 1;
            // 
            // lblBriochePrice
            // 
            this.lblBriochePrice.AutoSize = true;
            this.lblBriochePrice.Location = new System.Drawing.Point(83, 0);
            this.lblBriochePrice.Name = "lblBriochePrice";
            this.lblBriochePrice.Size = new System.Drawing.Size(37, 13);
            this.lblBriochePrice.TabIndex = 5;
            this.lblBriochePrice.Text = "1,10 €";
            // 
            // imgSaltyBrioche
            // 
            this.imgSaltyBrioche.BackgroundImage = global::Merende.Properties.Resources.saltybrioche;
            this.imgSaltyBrioche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgSaltyBrioche.Controls.Add(this.lblSaltyBriochePrice);
            this.imgSaltyBrioche.Location = new System.Drawing.Point(156, 182);
            this.imgSaltyBrioche.Name = "imgSaltyBrioche";
            this.imgSaltyBrioche.Size = new System.Drawing.Size(136, 95);
            this.imgSaltyBrioche.TabIndex = 1;
            // 
            // lblSaltyBriochePrice
            // 
            this.lblSaltyBriochePrice.AutoSize = true;
            this.lblSaltyBriochePrice.Location = new System.Drawing.Point(99, 1);
            this.lblSaltyBriochePrice.Name = "lblSaltyBriochePrice";
            this.lblSaltyBriochePrice.Size = new System.Drawing.Size(37, 13);
            this.lblSaltyBriochePrice.TabIndex = 5;
            this.lblSaltyBriochePrice.Text = "1,20 €";
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
            // imgCappuccino
            // 
            this.imgCappuccino.BackgroundImage = global::Merende.Properties.Resources.cappuccino;
            this.imgCappuccino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgCappuccino.Controls.Add(this.lblCappuccinoPrice);
            this.imgCappuccino.Location = new System.Drawing.Point(12, 180);
            this.imgCappuccino.Name = "imgCappuccino";
            this.imgCappuccino.Size = new System.Drawing.Size(133, 112);
            this.imgCappuccino.TabIndex = 1;
            // 
            // lblCappuccinoPrice
            // 
            this.lblCappuccinoPrice.AutoSize = true;
            this.lblCappuccinoPrice.Location = new System.Drawing.Point(96, 0);
            this.lblCappuccinoPrice.Name = "lblCappuccinoPrice";
            this.lblCappuccinoPrice.Size = new System.Drawing.Size(37, 13);
            this.lblCappuccinoPrice.TabIndex = 5;
            this.lblCappuccinoPrice.Text = "1,50 €";
            // 
            // imgJuice
            // 
            this.imgJuice.BackgroundImage = global::Merende.Properties.Resources.juice;
            this.imgJuice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgJuice.Controls.Add(this.lblJuicePrice);
            this.imgJuice.Location = new System.Drawing.Point(12, 321);
            this.imgJuice.Name = "imgJuice";
            this.imgJuice.Size = new System.Drawing.Size(117, 112);
            this.imgJuice.TabIndex = 1;
            // 
            // lblJuicePrice
            // 
            this.lblJuicePrice.AutoSize = true;
            this.lblJuicePrice.Location = new System.Drawing.Point(80, 0);
            this.lblJuicePrice.Name = "lblJuicePrice";
            this.lblJuicePrice.Size = new System.Drawing.Size(37, 13);
            this.lblJuicePrice.TabIndex = 5;
            this.lblJuicePrice.Text = "2,50 €";
            // 
            // groupPanel
            // 
            this.groupPanel.Controls.Add(this.chkBrioche);
            this.groupPanel.Controls.Add(this.chkCappuccino);
            this.groupPanel.Controls.Add(this.chkCoffee);
            this.groupPanel.Controls.Add(this.chkJuice);
            this.groupPanel.Controls.Add(this.chkSaltyBrioche);
            this.groupPanel.Controls.Add(this.btnSubmit);
            this.groupPanel.Location = new System.Drawing.Point(0, 0);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.Size = new System.Drawing.Size(304, 461);
            this.groupPanel.TabIndex = 1;
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
            // lblInfoText
            // 
            this.lblInfoText.AutoSize = true;
            this.lblInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblInfoText.Location = new System.Drawing.Point(170, 332);
            this.lblInfoText.Name = "lblInfoText";
            this.lblInfoText.Size = new System.Drawing.Size(106, 22);
            this.lblInfoText.TabIndex = 3;
            this.lblInfoText.Text = "Costo totale";
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
            this.Controls.Add(this.lblTitleInfoText);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInfoText);
            this.Controls.Add(this.imgJuice);
            this.Controls.Add(this.imgCappuccino);
            this.Controls.Add(this.imgSaltyBrioche);
            this.Controls.Add(this.imgBrioche);
            this.Controls.Add(this.imgCoffee);
            this.Controls.Add(this.groupPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Merenda 2.0";
            this.imgCoffee.ResumeLayout(false);
            this.imgCoffee.PerformLayout();
            this.imgBrioche.ResumeLayout(false);
            this.imgBrioche.PerformLayout();
            this.imgSaltyBrioche.ResumeLayout(false);
            this.imgSaltyBrioche.PerformLayout();
            this.imgCappuccino.ResumeLayout(false);
            this.imgCappuccino.PerformLayout();
            this.imgJuice.ResumeLayout(false);
            this.imgJuice.PerformLayout();
            this.groupPanel.ResumeLayout(false);
            this.groupPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleInfoText;
        private System.Windows.Forms.Panel imgCoffee;
        private System.Windows.Forms.Panel imgBrioche;
        private System.Windows.Forms.Panel imgSaltyBrioche;
        private System.Windows.Forms.Panel imgCappuccino;
        private System.Windows.Forms.Panel imgJuice;
        private System.Windows.Forms.Panel groupPanel;
        private System.Windows.Forms.CheckBox chkSaltyBrioche;
        private System.Windows.Forms.CheckBox chkCoffee;
        private System.Windows.Forms.CheckBox chkBrioche;
        private System.Windows.Forms.CheckBox chkCappuccino;
        private System.Windows.Forms.CheckBox chkJuice;
        private System.Windows.Forms.Label lblInfoText;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblBriochePrice;
        private System.Windows.Forms.Label lblCoffeePrice;
        private System.Windows.Forms.Label lblSaltyBriochePrice;
        private System.Windows.Forms.Label lblCappuccinoPrice;
        private System.Windows.Forms.Label lblJuicePrice;
    }
}