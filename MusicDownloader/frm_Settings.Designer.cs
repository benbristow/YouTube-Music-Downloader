namespace MusicDownloader
{
    partial class frm_Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SaveDirectoryBrowse = new System.Windows.Forms.Button();
            this.txt_SaveDirectory = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SaveDirectoryBrowse);
            this.groupBox1.Controls.Add(this.txt_SaveDirectory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save Directory";
            // 
            // btn_SaveDirectoryBrowse
            // 
            this.btn_SaveDirectoryBrowse.Location = new System.Drawing.Point(331, 45);
            this.btn_SaveDirectoryBrowse.Name = "btn_SaveDirectoryBrowse";
            this.btn_SaveDirectoryBrowse.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveDirectoryBrowse.TabIndex = 1;
            this.btn_SaveDirectoryBrowse.Text = "Browse...";
            this.btn_SaveDirectoryBrowse.UseVisualStyleBackColor = true;
            this.btn_SaveDirectoryBrowse.Click += new System.EventHandler(this.btn_SaveDirectoryBrowse_Click);
            // 
            // txt_SaveDirectory
            // 
            this.txt_SaveDirectory.Location = new System.Drawing.Point(6, 19);
            this.txt_SaveDirectory.Name = "txt_SaveDirectory";
            this.txt_SaveDirectory.Size = new System.Drawing.Size(400, 20);
            this.txt_SaveDirectory.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(349, 101);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(268, 101);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 132);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frm_Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SaveDirectoryBrowse;
        private System.Windows.Forms.TextBox txt_SaveDirectory;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
    }
}