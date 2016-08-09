namespace Overstor
{
    partial class SettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.tb_trigger_path = new System.Windows.Forms.TextBox();
            this.lb_trigger_path = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_trigger_path
            // 
            this.tb_trigger_path.Location = new System.Drawing.Point(85, 12);
            this.tb_trigger_path.Name = "tb_trigger_path";
            this.tb_trigger_path.Size = new System.Drawing.Size(180, 20);
            this.tb_trigger_path.TabIndex = 0;
            // 
            // lb_trigger_path
            // 
            this.lb_trigger_path.AutoSize = true;
            this.lb_trigger_path.Location = new System.Drawing.Point(12, 15);
            this.lb_trigger_path.Name = "lb_trigger_path";
            this.lb_trigger_path.Size = new System.Drawing.Size(67, 13);
            this.lb_trigger_path.TabIndex = 1;
            this.lb_trigger_path.Text = "Trigger path:";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(274, 9);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(35, 24);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "...";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(181, 64);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(75, 64);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_accept.TabIndex = 18;
            this.btn_accept.Text = "OK";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 100);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.lb_trigger_path);
            this.Controls.Add(this.tb_trigger_path);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsDialog";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_trigger_path;
        private System.Windows.Forms.Label lb_trigger_path;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_accept;
    }
}