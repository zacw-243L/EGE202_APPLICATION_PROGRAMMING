namespace NoteApp
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.RichTextBox();
            this.lblMesg = new System.Windows.Forms.Label();
            this.txtMesg = new System.Windows.Forms.RichTextBox();
            this.dgvMesg = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(22, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(25, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(263, 28);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "";
            // 
            // lblMesg
            // 
            this.lblMesg.AutoSize = true;
            this.lblMesg.Location = new System.Drawing.Point(22, 89);
            this.lblMesg.Name = "lblMesg";
            this.lblMesg.Size = new System.Drawing.Size(67, 16);
            this.lblMesg.TabIndex = 2;
            this.lblMesg.Text = "Message ";
            // 
            // txtMesg
            // 
            this.txtMesg.Location = new System.Drawing.Point(25, 117);
            this.txtMesg.Name = "txtMesg";
            this.txtMesg.Size = new System.Drawing.Size(263, 184);
            this.txtMesg.TabIndex = 3;
            this.txtMesg.Text = "";
            // 
            // dgvMesg
            // 
            this.dgvMesg.AllowUserToAddRows = false;
            this.dgvMesg.AllowUserToDeleteRows = false;
            this.dgvMesg.AllowUserToResizeColumns = false;
            this.dgvMesg.AllowUserToResizeRows = false;
            this.dgvMesg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesg.ColumnHeadersVisible = false;
            this.dgvMesg.Location = new System.Drawing.Point(362, 38);
            this.dgvMesg.Name = "dgvMesg";
            this.dgvMesg.RowHeadersVisible = false;
            this.dgvMesg.RowHeadersWidth = 51;
            this.dgvMesg.RowTemplate.Height = 24;
            this.dgvMesg.Size = new System.Drawing.Size(318, 263);
            this.dgvMesg.TabIndex = 4;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(25, 307);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(102, 43);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(186, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 43);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(362, 307);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(102, 43);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(470, 307);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 43);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(578, 307);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(102, 43);
            this.btnSync.TabIndex = 9;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 371);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvMesg);
            this.Controls.Add(this.txtMesg);
            this.Controls.Add(this.lblMesg);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox txtTitle;
        private System.Windows.Forms.Label lblMesg;
        private System.Windows.Forms.RichTextBox txtMesg;
        private System.Windows.Forms.DataGridView dgvMesg;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSync;
    }
}

