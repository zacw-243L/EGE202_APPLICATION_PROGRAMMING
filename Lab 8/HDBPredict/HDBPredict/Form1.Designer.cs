
namespace HDBPredict
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.panelPredict = new System.Windows.Forms.Panel();
            this.txtLeaseCommence = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFlatModel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFloorArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStoreyRange = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFlatType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPredict = new System.Windows.Forms.Label();
            this.btnPredict = new System.Windows.Forms.Button();
            this.panelPredict.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "HDB Resale Price Prediction";
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.Location = new System.Drawing.Point(49, 81);
            this.chkShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(62, 20);
            this.chkShow.TabIndex = 4;
            this.chkShow.Text = "Show";
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // panelPredict
            // 
            this.panelPredict.Controls.Add(this.txtLeaseCommence);
            this.panelPredict.Controls.Add(this.label7);
            this.panelPredict.Controls.Add(this.txtFlatModel);
            this.panelPredict.Controls.Add(this.label8);
            this.panelPredict.Controls.Add(this.txtFloorArea);
            this.panelPredict.Controls.Add(this.label5);
            this.panelPredict.Controls.Add(this.txtStoreyRange);
            this.panelPredict.Controls.Add(this.label6);
            this.panelPredict.Controls.Add(this.txtFlatType);
            this.panelPredict.Controls.Add(this.label4);
            this.panelPredict.Controls.Add(this.txtTown);
            this.panelPredict.Controls.Add(this.label3);
            this.panelPredict.Controls.Add(this.lblPredict);
            this.panelPredict.Controls.Add(this.btnPredict);
            this.panelPredict.Location = new System.Drawing.Point(49, 110);
            this.panelPredict.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPredict.Name = "panelPredict";
            this.panelPredict.Size = new System.Drawing.Size(568, 374);
            this.panelPredict.TabIndex = 3;
            this.panelPredict.Visible = false;
            // 
            // txtLeaseCommence
            // 
            this.txtLeaseCommence.Location = new System.Drawing.Point(195, 202);
            this.txtLeaseCommence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLeaseCommence.Name = "txtLeaseCommence";
            this.txtLeaseCommence.Size = new System.Drawing.Size(132, 22);
            this.txtLeaseCommence.TabIndex = 13;
            this.txtLeaseCommence.Text = "1979";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lease Commence";
            // 
            // txtFlatModel
            // 
            this.txtFlatModel.Location = new System.Drawing.Point(195, 170);
            this.txtFlatModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlatModel.Name = "txtFlatModel";
            this.txtFlatModel.Size = new System.Drawing.Size(132, 22);
            this.txtFlatModel.TabIndex = 11;
            this.txtFlatModel.Text = "Improved";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Flat Model";
            // 
            // txtFloorArea
            // 
            this.txtFloorArea.Location = new System.Drawing.Point(195, 138);
            this.txtFloorArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFloorArea.Name = "txtFloorArea";
            this.txtFloorArea.Size = new System.Drawing.Size(132, 22);
            this.txtFloorArea.TabIndex = 9;
            this.txtFloorArea.Text = "44";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Floor Area";
            // 
            // txtStoreyRange
            // 
            this.txtStoreyRange.Location = new System.Drawing.Point(195, 106);
            this.txtStoreyRange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStoreyRange.Name = "txtStoreyRange";
            this.txtStoreyRange.Size = new System.Drawing.Size(132, 22);
            this.txtStoreyRange.TabIndex = 7;
            this.txtStoreyRange.Text = "10 TO 12";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Storey Range";
            // 
            // txtFlatType
            // 
            this.txtFlatType.Location = new System.Drawing.Point(195, 71);
            this.txtFlatType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlatType.Name = "txtFlatType";
            this.txtFlatType.Size = new System.Drawing.Size(132, 22);
            this.txtFlatType.TabIndex = 5;
            this.txtFlatType.Text = "2 ROOM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Flat Type";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(195, 39);
            this.txtTown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(132, 22);
            this.txtTown.TabIndex = 3;
            this.txtTown.Text = "ANG MO KIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Town";
            // 
            // lblPredict
            // 
            this.lblPredict.AutoSize = true;
            this.lblPredict.Location = new System.Drawing.Point(177, 332);
            this.lblPredict.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPredict.Name = "lblPredict";
            this.lblPredict.Size = new System.Drawing.Size(105, 16);
            this.lblPredict.TabIndex = 1;
            this.lblPredict.Text = "Predicted Price: ";
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(36, 326);
            this.btnPredict.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(100, 28);
            this.btnPredict.TabIndex = 0;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.panelPredict);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelPredict.ResumeLayout(false);
            this.panelPredict.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Panel panelPredict;
        private System.Windows.Forms.TextBox txtLeaseCommence;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFlatModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFloorArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStoreyRange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFlatType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPredict;
        private System.Windows.Forms.Button btnPredict;
    }
}

