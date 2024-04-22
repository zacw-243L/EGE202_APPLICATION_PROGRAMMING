using System.Drawing;

namespace Calculator
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(16, 27);
            this.txtResults.Margin = new System.Windows.Forms.Padding(7);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(345, 48);
            this.txtResults.TabIndex = 0;
            this.txtResults.Text = "0";
            this.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(16, 122);
            this.btn1.Margin = new System.Windows.Forms.Padding(5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 55);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(81, 122);
            this.btn2.Margin = new System.Windows.Forms.Padding(5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 55);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(146, 122);
            this.btn3.Margin = new System.Windows.Forms.Padding(5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 55);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(16, 187);
            this.btn4.Margin = new System.Windows.Forms.Padding(5);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 55);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(81, 187);
            this.btn5.Margin = new System.Windows.Forms.Padding(5);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 55);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(146, 187);
            this.btn6.Margin = new System.Windows.Forms.Padding(5);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 55);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(16, 252);
            this.btn7.Margin = new System.Windows.Forms.Padding(5);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 55);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(81, 252);
            this.btn8.Margin = new System.Windows.Forms.Padding(5);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 55);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(146, 252);
            this.btn9.Margin = new System.Windows.Forms.Padding(5);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 55);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.Black;
            this.btnDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.White;
            this.btnDot.Location = new System.Drawing.Point(146, 325);
            this.btnDot.Margin = new System.Windows.Forms.Padding(7);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(55, 55);
            this.btnDot.TabIndex = 10;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Black;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(16, 325);
            this.btn0.Margin = new System.Windows.Forms.Padding(7);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(120, 55);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.numPad_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Black;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(237, 122);
            this.Add.Margin = new System.Windows.Forms.Padding(7);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(55, 55);
            this.Add.TabIndex = 12;
            this.Add.Tag = "Add";
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.operator_Click);
            // 
            // Subtract
            // 
            this.Subtract.BackColor = System.Drawing.Color.Black;
            this.Subtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Subtract.FlatAppearance.BorderSize = 0;
            this.Subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.ForeColor = System.Drawing.Color.White;
            this.Subtract.Location = new System.Drawing.Point(237, 187);
            this.Subtract.Margin = new System.Windows.Forms.Padding(7);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(55, 55);
            this.Subtract.TabIndex = 13;
            this.Subtract.Tag = "Subtract";
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = false;
            this.Subtract.Click += new System.EventHandler(this.operator_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.Black;
            this.multiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiply.FlatAppearance.BorderSize = 0;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.ForeColor = System.Drawing.Color.White;
            this.multiply.Location = new System.Drawing.Point(237, 252);
            this.multiply.Margin = new System.Windows.Forms.Padding(7);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(55, 55);
            this.multiply.TabIndex = 14;
            this.multiply.Tag = "Multiply";
            this.multiply.Text = "×";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.Black;
            this.divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divide.FlatAppearance.BorderSize = 0;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.ForeColor = System.Drawing.Color.White;
            this.divide.Location = new System.Drawing.Point(237, 325);
            this.divide.Margin = new System.Windows.Forms.Padding(7);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(55, 55);
            this.divide.TabIndex = 15;
            this.divide.Tag = "Divide";
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.operator_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.Black;
            this.equal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equal.FlatAppearance.BorderSize = 0;
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.ForeColor = System.Drawing.Color.White;
            this.equal.Location = new System.Drawing.Point(306, 325);
            this.equal.Margin = new System.Windows.Forms.Padding(7);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(55, 55);
            this.equal.TabIndex = 16;
            this.equal.Tag = "Equ";
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.Yellow;
            this.CE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CE.FlatAppearance.BorderSize = 0;
            this.CE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.ForeColor = System.Drawing.Color.Black;
            this.CE.Location = new System.Drawing.Point(306, 122);
            this.CE.Margin = new System.Windows.Forms.Padding(7);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(55, 55);
            this.CE.TabIndex = 17;
            this.CE.Tag = "CE";
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.Black;
            this.btnSqrt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSqrt.FlatAppearance.BorderSize = 0;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.Color.White;
            this.btnSqrt.Location = new System.Drawing.Point(306, 187);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(7);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(55, 55);
            this.btnSqrt.TabIndex = 18;
            this.btnSqrt.Tag = "Sqrt";
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.u_operatorClick);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.Black;
            this.btnSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.ForeColor = System.Drawing.Color.White;
            this.btnSquare.Location = new System.Drawing.Point(306, 252);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(7);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(55, 55);
            this.btnSquare.TabIndex = 19;
            this.btnSquare.Tag = "Square";
            this.btnSquare.Text = "x²\r\n";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.Square_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(377, 453);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Calculator";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSquare;
    }
}

