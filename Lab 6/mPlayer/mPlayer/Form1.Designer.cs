namespace mPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wmpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbMedia = new System.Windows.Forms.ListBox();
            this.rRadio = new System.Windows.Forms.RadioButton();
            this.rMedia = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpPlayer
            // 
            this.wmpPlayer.Enabled = true;
            this.wmpPlayer.Location = new System.Drawing.Point(186, 16);
            this.wmpPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wmpPlayer.Name = "wmpPlayer";
            this.wmpPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpPlayer.OcxState")));
            this.wmpPlayer.Size = new System.Drawing.Size(570, 380);
            this.wmpPlayer.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(9, 337);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 60);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbMedia
            // 
            this.lbMedia.FormattingEnabled = true;
            this.lbMedia.ItemHeight = 16;
            this.lbMedia.Location = new System.Drawing.Point(9, 58);
            this.lbMedia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMedia.Name = "lbMedia";
            this.lbMedia.Size = new System.Drawing.Size(183, 276);
            this.lbMedia.TabIndex = 2;
            this.lbMedia.SelectedIndexChanged += new System.EventHandler(this.lbMedia_SelectedIndexChanged);
            // 
            // rRadio
            // 
            this.rRadio.AutoSize = true;
            this.rRadio.Location = new System.Drawing.Point(12, 11);
            this.rRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rRadio.Name = "rRadio";
            this.rRadio.Size = new System.Drawing.Size(114, 20);
            this.rRadio.TabIndex = 3;
            this.rRadio.Text = "Internet Radio ";
            this.rRadio.UseVisualStyleBackColor = true;
            this.rRadio.CheckedChanged += new System.EventHandler(this.rRadio_CheckedChanged);
            // 
            // rMedia
            // 
            this.rMedia.AutoSize = true;
            this.rMedia.Checked = true;
            this.rMedia.Location = new System.Drawing.Point(10, 35);
            this.rMedia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rMedia.Name = "rMedia";
            this.rMedia.Size = new System.Drawing.Size(111, 20);
            this.rMedia.TabIndex = 4;
            this.rMedia.TabStop = true;
            this.rMedia.Text = "Media Player ";
            this.rMedia.UseVisualStyleBackColor = true;
            this.rMedia.CheckedChanged += new System.EventHandler(this.rMedia_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 393);
            this.Controls.Add(this.rMedia);
            this.Controls.Add(this.rRadio);
            this.Controls.Add(this.lbMedia);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.wmpPlayer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "mPlayer";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpPlayer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbMedia;
        private System.Windows.Forms.RadioButton rRadio;
        private System.Windows.Forms.RadioButton rMedia;
    }
}

