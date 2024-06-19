namespace MyCheckBox
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
            this.chkSel = new System.Windows.Forms.CheckBox();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.PB1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSel
            // 
            this.chkSel.AutoSize = true;
            this.chkSel.Checked = true;
            this.chkSel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSel.Location = new System.Drawing.Point(12, 106);
            this.chkSel.Name = "chkSel";
            this.chkSel.Size = new System.Drawing.Size(128, 20);
            this.chkSel.TabIndex = 0;
            this.chkSel.Text = "Show Calculator ";
            this.chkSel.UseVisualStyleBackColor = true;
            this.chkSel.CheckedChanged += new System.EventHandler(this.chkSel_CheckedChanged);
            // 
            // picImg
            // 
            this.picImg.Image = global::MyCheckBox.Properties.Resources._1aawd;
            this.picImg.Location = new System.Drawing.Point(12, 166);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(367, 381);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 1;
            this.picImg.TabStop = false;
            // 
            // PB1
            // 
            this.PB1.Image = global::MyCheckBox.Properties.Resources.awdwa2c;
            this.PB1.Location = new System.Drawing.Point(12, 166);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(367, 381);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB1.TabIndex = 2;
            this.PB1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 559);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.picImg);
            this.Controls.Add(this.chkSel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSel;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.PictureBox PB1;
    }
}

