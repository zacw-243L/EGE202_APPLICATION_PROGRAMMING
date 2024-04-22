namespace Converter
{
    partial class Converter
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblSquare = new System.Windows.Forms.Label();
            this.lblEql = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(163, 203);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 30);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblSquare
            // 
            this.lblSquare.AutoSize = true;
            this.lblSquare.Location = new System.Drawing.Point(55, 68);
            this.lblSquare.Name = "lblSquare";
            this.lblSquare.Size = new System.Drawing.Size(65, 16);
            this.lblSquare.TabIndex = 1;
            this.lblSquare.Text = "Square of";
            // 
            // lblEql
            // 
            this.lblEql.AutoSize = true;
            this.lblEql.Location = new System.Drawing.Point(232, 68);
            this.lblEql.Name = "lblEql";
            this.lblEql.Size = new System.Drawing.Size(14, 16);
            this.lblEql.TabIndex = 2;
            this.lblEql.Text = "=";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(126, 65);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 3;
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(252, 65);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(100, 22);
            this.txtResults.TabIndex = 4;
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 403);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblEql);
            this.Controls.Add(this.lblSquare);
            this.Controls.Add(this.btnConvert);
            this.Name = "Converter";
            this.Text = "Converter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblSquare;
        private System.Windows.Forms.Label lblEql;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtResults;
    }
}

