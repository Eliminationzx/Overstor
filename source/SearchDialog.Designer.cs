namespace Overstor
{
    partial class SearchDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDialog));
            this.tb_search = new System.Windows.Forms.TextBox();
            this.cmb_tag_list = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_search.Location = new System.Drawing.Point(12, 13);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(323, 20);
            this.tb_search.TabIndex = 3;
            this.tb_search.Text = "Enter your search here...";
            // 
            // cmb_tag_list
            // 
            this.cmb_tag_list.FormattingEnabled = true;
            this.cmb_tag_list.Location = new System.Drawing.Point(341, 12);
            this.cmb_tag_list.Name = "cmb_tag_list";
            this.cmb_tag_list.Size = new System.Drawing.Size(121, 21);
            this.cmb_tag_list.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(469, 13);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // SearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 51);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cmb_tag_list);
            this.Controls.Add(this.tb_search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchDialog";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ComboBox cmb_tag_list;
        private System.Windows.Forms.Button btn_search;
    }
}