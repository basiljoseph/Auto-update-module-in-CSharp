namespace auto_update
{
    partial class UpdateWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateWindow));
            this.textBox_changeLog = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_change = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_changeLog
            // 
            this.textBox_changeLog.Location = new System.Drawing.Point(13, 29);
            this.textBox_changeLog.Multiline = true;
            this.textBox_changeLog.Name = "textBox_changeLog";
            this.textBox_changeLog.Size = new System.Drawing.Size(459, 191);
            this.textBox_changeLog.TabIndex = 0;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(397, 226);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(316, 226);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_change
            // 
            this.label_change.AutoSize = true;
            this.label_change.Location = new System.Drawing.Point(13, 13);
            this.label_change.Name = "label_change";
            this.label_change.Size = new System.Drawing.Size(65, 13);
            this.label_change.TabIndex = 3;
            this.label_change.Text = "Change Log";
            // 
            // UpdateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.label_change);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_changeLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "UpdateWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "A new version available";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_changeLog;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_change;
    }
}