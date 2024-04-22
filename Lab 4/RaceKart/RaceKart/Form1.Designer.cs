namespace RaceKart
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.line2 = new System.Windows.Forms.PictureBox();
            this.line4 = new System.Windows.Forms.PictureBox();
            this.line3 = new System.Windows.Forms.PictureBox();
            this.line1 = new System.Windows.Forms.PictureBox();
            this.lineR = new System.Windows.Forms.PictureBox();
            this.lineL = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbCoin1 = new System.Windows.Forms.PictureBox();
            this.pbCoin2 = new System.Windows.Forms.PictureBox();
            this.lblCoins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCar
            // 
            this.pbCar.BackColor = System.Drawing.Color.Transparent;
            this.pbCar.Image = global::RaceKart.Properties.Resources.car2;
            this.pbCar.Location = new System.Drawing.Point(62, 309);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(40, 70);
            this.pbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar.TabIndex = 6;
            this.pbCar.TabStop = false;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.White;
            this.line2.Location = new System.Drawing.Point(190, 135);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(10, 50);
            this.line2.TabIndex = 5;
            this.line2.TabStop = false;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.White;
            this.line4.Location = new System.Drawing.Point(190, 405);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(10, 50);
            this.line4.TabIndex = 4;
            this.line4.TabStop = false;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.White;
            this.line3.Location = new System.Drawing.Point(190, 270);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(10, 50);
            this.line3.TabIndex = 3;
            this.line3.TabStop = false;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.Location = new System.Drawing.Point(190, 0);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 50);
            this.line1.TabIndex = 2;
            this.line1.TabStop = false;
            // 
            // lineR
            // 
            this.lineR.BackColor = System.Drawing.Color.White;
            this.lineR.Location = new System.Drawing.Point(372, 0);
            this.lineR.Name = "lineR";
            this.lineR.Size = new System.Drawing.Size(10, 460);
            this.lineR.TabIndex = 1;
            this.lineR.TabStop = false;
            // 
            // lineL
            // 
            this.lineL.BackColor = System.Drawing.Color.White;
            this.lineL.Location = new System.Drawing.Point(0, 0);
            this.lineL.Name = "lineL";
            this.lineL.Size = new System.Drawing.Size(10, 460);
            this.lineL.TabIndex = 0;
            this.lineL.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbCoin1
            // 
            this.pbCoin1.BackColor = System.Drawing.Color.Transparent;
            this.pbCoin1.Image = global::RaceKart.Properties.Resources.coins;
            this.pbCoin1.Location = new System.Drawing.Point(96, 80);
            this.pbCoin1.Name = "pbCoin1";
            this.pbCoin1.Size = new System.Drawing.Size(30, 30);
            this.pbCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoin1.TabIndex = 7;
            this.pbCoin1.TabStop = false;
            // 
            // pbCoin2
            // 
            this.pbCoin2.BackColor = System.Drawing.Color.Transparent;
            this.pbCoin2.Image = global::RaceKart.Properties.Resources.coins;
            this.pbCoin2.Location = new System.Drawing.Point(268, 135);
            this.pbCoin2.Name = "pbCoin2";
            this.pbCoin2.Size = new System.Drawing.Size(30, 30);
            this.pbCoin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoin2.TabIndex = 8;
            this.pbCoin2.TabStop = false;
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.BackColor = System.Drawing.Color.Transparent;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.Color.Gold;
            this.lblCoins.Location = new System.Drawing.Point(21, 9);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(81, 29);
            this.lblCoins.TabIndex = 9;
            this.lblCoins.Text = "Coins:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.pbCoin2);
            this.Controls.Add(this.pbCoin1);
            this.Controls.Add(this.pbCar);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.lineR);
            this.Controls.Add(this.lineL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RaceKart";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lineL;
        private System.Windows.Forms.PictureBox lineR;
        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.PictureBox line3;
        private System.Windows.Forms.PictureBox line4;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.PictureBox pbCar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbCoin1;
        private System.Windows.Forms.PictureBox pbCoin2;
        private System.Windows.Forms.Label lblCoins;
    }
}

