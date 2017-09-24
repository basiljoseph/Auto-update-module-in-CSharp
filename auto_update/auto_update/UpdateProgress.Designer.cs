namespace auto_update
{
    partial class UpdateProgress
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
            this.checkBox_download = new System.Windows.Forms.CheckBox();
            this.checkBox_extract = new System.Windows.Forms.CheckBox();
            this.checkBox_update = new System.Windows.Forms.CheckBox();
            this.checkBox_complete = new System.Windows.Forms.CheckBox();
            this.checkBox_restart = new System.Windows.Forms.CheckBox();
            this.checkBox_backup = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox_download
            // 
            this.checkBox_download.AutoSize = true;
            this.checkBox_download.Location = new System.Drawing.Point(13, 13);
            this.checkBox_download.Name = "checkBox_download";
            this.checkBox_download.Size = new System.Drawing.Size(187, 17);
            this.checkBox_download.TabIndex = 0;
            this.checkBox_download.Text = "Downloading the update package";
            this.checkBox_download.UseVisualStyleBackColor = true;
            // 
            // checkBox_extract
            // 
            this.checkBox_extract.AutoSize = true;
            this.checkBox_extract.Location = new System.Drawing.Point(12, 36);
            this.checkBox_extract.Name = "checkBox_extract";
            this.checkBox_extract.Size = new System.Drawing.Size(127, 17);
            this.checkBox_extract.TabIndex = 0;
            this.checkBox_extract.Text = "Extracting the update";
            this.checkBox_extract.UseVisualStyleBackColor = true;
            // 
            // checkBox_update
            // 
            this.checkBox_update.AutoSize = true;
            this.checkBox_update.Location = new System.Drawing.Point(13, 83);
            this.checkBox_update.Name = "checkBox_update";
            this.checkBox_update.Size = new System.Drawing.Size(128, 17);
            this.checkBox_update.TabIndex = 0;
            this.checkBox_update.Text = "Updating the program";
            this.checkBox_update.UseVisualStyleBackColor = true;
            // 
            // checkBox_complete
            // 
            this.checkBox_complete.AutoSize = true;
            this.checkBox_complete.Location = new System.Drawing.Point(13, 106);
            this.checkBox_complete.Name = "checkBox_complete";
            this.checkBox_complete.Size = new System.Drawing.Size(107, 17);
            this.checkBox_complete.TabIndex = 0;
            this.checkBox_complete.Text = "Update complete";
            this.checkBox_complete.UseVisualStyleBackColor = true;
            // 
            // checkBox_restart
            // 
            this.checkBox_restart.AutoSize = true;
            this.checkBox_restart.Location = new System.Drawing.Point(13, 129);
            this.checkBox_restart.Name = "checkBox_restart";
            this.checkBox_restart.Size = new System.Drawing.Size(83, 17);
            this.checkBox_restart.TabIndex = 0;
            this.checkBox_restart.Text = "Restarting...";
            this.checkBox_restart.UseVisualStyleBackColor = true;
            // 
            // checkBox_backup
            // 
            this.checkBox_backup.AutoSize = true;
            this.checkBox_backup.Location = new System.Drawing.Point(13, 59);
            this.checkBox_backup.Name = "checkBox_backup";
            this.checkBox_backup.Size = new System.Drawing.Size(82, 17);
            this.checkBox_backup.TabIndex = 0;
            this.checkBox_backup.Text = "Backing Up";
            this.checkBox_backup.UseVisualStyleBackColor = true;
            // 
            // UpdateProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 166);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox_restart);
            this.Controls.Add(this.checkBox_complete);
            this.Controls.Add(this.checkBox_update);
            this.Controls.Add(this.checkBox_backup);
            this.Controls.Add(this.checkBox_extract);
            this.Controls.Add(this.checkBox_download);
            this.MaximumSize = new System.Drawing.Size(263, 205);
            this.MinimumSize = new System.Drawing.Size(263, 205);
            this.Name = "UpdateProgress";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updating...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_download;
        private System.Windows.Forms.CheckBox checkBox_extract;
        private System.Windows.Forms.CheckBox checkBox_update;
        private System.Windows.Forms.CheckBox checkBox_complete;
        private System.Windows.Forms.CheckBox checkBox_restart;
        private System.Windows.Forms.CheckBox checkBox_backup;

    }
}