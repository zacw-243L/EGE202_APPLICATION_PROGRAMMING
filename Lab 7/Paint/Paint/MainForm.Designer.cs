namespace Paint
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
            this.panelColor = new System.Windows.Forms.Panel();
            this.picBoxSave = new System.Windows.Forms.PictureBox();
            this.picBoxBlue = new System.Windows.Forms.PictureBox();
            this.picBoxGreen = new System.Windows.Forms.PictureBox();
            this.picBoxRed = new System.Windows.Forms.PictureBox();
            this.picBoxBlack = new System.Windows.Forms.PictureBox();
            this.picBoxBrushColor = new System.Windows.Forms.PictureBox();
            this.picBoxMain = new System.Windows.Forms.PictureBox();
            this.picBoxClear = new System.Windows.Forms.PictureBox();
            this.picBoxErase = new System.Windows.Forms.PictureBox();
            this.picBoxText = new System.Windows.Forms.PictureBox();
            this.txtBoxText = new System.Windows.Forms.TextBox();
            this.panelColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBrushColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxErase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxText)).BeginInit();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.picBoxBlue);
            this.panelColor.Controls.Add(this.picBoxGreen);
            this.panelColor.Controls.Add(this.picBoxRed);
            this.panelColor.Controls.Add(this.picBoxBlack);
            this.panelColor.Controls.Add(this.picBoxBrushColor);
            this.panelColor.Location = new System.Drawing.Point(290, 304);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(310, 70);
            this.panelColor.TabIndex = 1;
            // 
            // picBoxSave
            // 
            this.picBoxSave.Image = global::Paint.Properties.Resources.save;
            this.picBoxSave.Location = new System.Drawing.Point(2, 323);
            this.picBoxSave.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.picBoxSave.Name = "picBoxSave";
            this.picBoxSave.Size = new System.Drawing.Size(40, 40);
            this.picBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSave.TabIndex = 2;
            this.picBoxSave.TabStop = false;
            this.picBoxSave.Click += new System.EventHandler(this.picBoxSave_Click);
            // 
            // picBoxBlue
            // 
            this.picBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.picBoxBlue.Location = new System.Drawing.Point(233, 23);
            this.picBoxBlue.Margin = new System.Windows.Forms.Padding(7);
            this.picBoxBlue.Name = "picBoxBlue";
            this.picBoxBlue.Size = new System.Drawing.Size(40, 40);
            this.picBoxBlue.TabIndex = 4;
            this.picBoxBlue.TabStop = false;
            this.picBoxBlue.Click += new System.EventHandler(this.picBoxBlue_Click);
            // 
            // picBoxGreen
            // 
            this.picBoxGreen.BackColor = System.Drawing.Color.Green;
            this.picBoxGreen.Location = new System.Drawing.Point(179, 23);
            this.picBoxGreen.Margin = new System.Windows.Forms.Padding(7);
            this.picBoxGreen.Name = "picBoxGreen";
            this.picBoxGreen.Size = new System.Drawing.Size(40, 40);
            this.picBoxGreen.TabIndex = 3;
            this.picBoxGreen.TabStop = false;
            this.picBoxGreen.Click += new System.EventHandler(this.picBoxGreen_Click);
            // 
            // picBoxRed
            // 
            this.picBoxRed.BackColor = System.Drawing.Color.Red;
            this.picBoxRed.Location = new System.Drawing.Point(125, 23);
            this.picBoxRed.Margin = new System.Windows.Forms.Padding(7);
            this.picBoxRed.Name = "picBoxRed";
            this.picBoxRed.Size = new System.Drawing.Size(40, 40);
            this.picBoxRed.TabIndex = 2;
            this.picBoxRed.TabStop = false;
            this.picBoxRed.Click += new System.EventHandler(this.picBoxRed_Click);
            // 
            // picBoxBlack
            // 
            this.picBoxBlack.BackColor = System.Drawing.Color.Black;
            this.picBoxBlack.Location = new System.Drawing.Point(71, 23);
            this.picBoxBlack.Margin = new System.Windows.Forms.Padding(7);
            this.picBoxBlack.Name = "picBoxBlack";
            this.picBoxBlack.Size = new System.Drawing.Size(40, 40);
            this.picBoxBlack.TabIndex = 1;
            this.picBoxBlack.TabStop = false;
            this.picBoxBlack.Click += new System.EventHandler(this.picBoxBlack_Click);
            // 
            // picBoxBrushColor
            // 
            this.picBoxBrushColor.BackColor = System.Drawing.Color.Black;
            this.picBoxBrushColor.Location = new System.Drawing.Point(7, 13);
            this.picBoxBrushColor.Margin = new System.Windows.Forms.Padding(7);
            this.picBoxBrushColor.Name = "picBoxBrushColor";
            this.picBoxBrushColor.Size = new System.Drawing.Size(50, 50);
            this.picBoxBrushColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBrushColor.TabIndex = 0;
            this.picBoxBrushColor.TabStop = false;
            // 
            // picBoxMain
            // 
            this.picBoxMain.BackColor = System.Drawing.Color.GhostWhite;
            this.picBoxMain.Location = new System.Drawing.Point(1, 3);
            this.picBoxMain.Name = "picBoxMain";
            this.picBoxMain.Size = new System.Drawing.Size(600, 300);
            this.picBoxMain.TabIndex = 0;
            this.picBoxMain.TabStop = false;
            this.picBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxMain_MouseDown);
            this.picBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxMain_MouseMove);
            this.picBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBoxMain_MouseUp);
            // 
            // picBoxClear
            // 
            this.picBoxClear.Image = global::Paint.Properties.Resources.clear;
            this.picBoxClear.Location = new System.Drawing.Point(48, 323);
            this.picBoxClear.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.picBoxClear.Name = "picBoxClear";
            this.picBoxClear.Size = new System.Drawing.Size(40, 40);
            this.picBoxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxClear.TabIndex = 3;
            this.picBoxClear.TabStop = false;
            this.picBoxClear.Click += new System.EventHandler(this.picBoxClear_Click);
            // 
            // picBoxErase
            // 
            this.picBoxErase.Image = global::Paint.Properties.Resources.erasor;
            this.picBoxErase.Location = new System.Drawing.Point(94, 323);
            this.picBoxErase.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.picBoxErase.Name = "picBoxErase";
            this.picBoxErase.Size = new System.Drawing.Size(40, 40);
            this.picBoxErase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxErase.TabIndex = 4;
            this.picBoxErase.TabStop = false;
            this.picBoxErase.Click += new System.EventHandler(this.picBoxErase_Click);
            // 
            // picBoxText
            // 
            this.picBoxText.Image = global::Paint.Properties.Resources.text;
            this.picBoxText.Location = new System.Drawing.Point(140, 323);
            this.picBoxText.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.picBoxText.Name = "picBoxText";
            this.picBoxText.Size = new System.Drawing.Size(40, 40);
            this.picBoxText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxText.TabIndex = 5;
            this.picBoxText.TabStop = false;
            this.picBoxText.Click += new System.EventHandler(this.picBoxText_Click);
            // 
            // txtBoxText
            // 
            this.txtBoxText.Location = new System.Drawing.Point(187, 333);
            this.txtBoxText.Name = "txtBoxText";
            this.txtBoxText.Size = new System.Drawing.Size(95, 22);
            this.txtBoxText.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 373);
            this.Controls.Add(this.txtBoxText);
            this.Controls.Add(this.picBoxText);
            this.Controls.Add(this.picBoxErase);
            this.Controls.Add(this.picBoxClear);
            this.Controls.Add(this.picBoxSave);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.picBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Paint";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBrushColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxErase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxMain;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.PictureBox picBoxBlue;
        private System.Windows.Forms.PictureBox picBoxGreen;
        private System.Windows.Forms.PictureBox picBoxRed;
        private System.Windows.Forms.PictureBox picBoxBlack;
        private System.Windows.Forms.PictureBox picBoxBrushColor;
        private System.Windows.Forms.PictureBox picBoxSave;
        private System.Windows.Forms.PictureBox picBoxClear;
        private System.Windows.Forms.PictureBox picBoxErase;
        private System.Windows.Forms.PictureBox picBoxText;
        private System.Windows.Forms.TextBox txtBoxText;
    }
}

