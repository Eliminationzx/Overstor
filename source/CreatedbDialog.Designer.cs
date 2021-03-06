﻿namespace Overstor
{
    partial class CreatedbDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatedbDialog));
            this.cols_del = new System.Windows.Forms.Button();
            this.cols_add = new System.Windows.Forms.Button();
            this.lb_column_name = new System.Windows.Forms.Label();
            this.tb_cols_name = new System.Windows.Forms.TextBox();
            this.cols_list = new System.Windows.Forms.ListBox();
            this.lb_table_name = new System.Windows.Forms.Label();
            this.tb_table_name = new System.Windows.Forms.TextBox();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cols_del
            // 
            this.cols_del.Image = ((System.Drawing.Image)(resources.GetObject("cols_del.Image")));
            this.cols_del.Location = new System.Drawing.Point(271, 45);
            this.cols_del.Name = "cols_del";
            this.cols_del.Size = new System.Drawing.Size(71, 27);
            this.cols_del.TabIndex = 15;
            this.cols_del.Text = "Delete";
            this.cols_del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cols_del.UseVisualStyleBackColor = true;
            this.cols_del.Click += new System.EventHandler(this.cols_del_Click);
            // 
            // cols_add
            // 
            this.cols_add.Image = ((System.Drawing.Image)(resources.GetObject("cols_add.Image")));
            this.cols_add.Location = new System.Drawing.Point(194, 45);
            this.cols_add.Name = "cols_add";
            this.cols_add.Size = new System.Drawing.Size(71, 27);
            this.cols_add.TabIndex = 14;
            this.cols_add.Text = "Add";
            this.cols_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cols_add.UseVisualStyleBackColor = true;
            this.cols_add.Click += new System.EventHandler(this.cols_add_Click);
            // 
            // lb_column_name
            // 
            this.lb_column_name.AutoSize = true;
            this.lb_column_name.Location = new System.Drawing.Point(2, 52);
            this.lb_column_name.Name = "lb_column_name";
            this.lb_column_name.Size = new System.Drawing.Size(74, 13);
            this.lb_column_name.TabIndex = 13;
            this.lb_column_name.Text = "Column name:";
            // 
            // tb_cols_name
            // 
            this.tb_cols_name.Location = new System.Drawing.Point(84, 49);
            this.tb_cols_name.Name = "tb_cols_name";
            this.tb_cols_name.Size = new System.Drawing.Size(104, 20);
            this.tb_cols_name.TabIndex = 12;
            // 
            // cols_list
            // 
            this.cols_list.FormattingEnabled = true;
            this.cols_list.Location = new System.Drawing.Point(5, 78);
            this.cols_list.MultiColumn = true;
            this.cols_list.Name = "cols_list";
            this.cols_list.Size = new System.Drawing.Size(339, 43);
            this.cols_list.TabIndex = 11;
            // 
            // lb_table_name
            // 
            this.lb_table_name.AutoSize = true;
            this.lb_table_name.Location = new System.Drawing.Point(3, 15);
            this.lb_table_name.Name = "lb_table_name";
            this.lb_table_name.Size = new System.Drawing.Size(38, 13);
            this.lb_table_name.TabIndex = 10;
            this.lb_table_name.Text = "Name:";
            // 
            // tb_table_name
            // 
            this.tb_table_name.Location = new System.Drawing.Point(47, 12);
            this.tb_table_name.Name = "tb_table_name";
            this.tb_table_name.Size = new System.Drawing.Size(282, 20);
            this.tb_table_name.TabIndex = 9;
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(84, 138);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_accept.TabIndex = 16;
            this.btn_accept.Text = "OK";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(190, 138);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // CreatedbDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 173);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.cols_del);
            this.Controls.Add(this.cols_add);
            this.Controls.Add(this.lb_column_name);
            this.Controls.Add(this.tb_cols_name);
            this.Controls.Add(this.cols_list);
            this.Controls.Add(this.lb_table_name);
            this.Controls.Add(this.tb_table_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatedbDialog";
            this.Text = "Create database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cols_del;
        private System.Windows.Forms.Button cols_add;
        private System.Windows.Forms.Label lb_column_name;
        private System.Windows.Forms.TextBox tb_cols_name;
        private System.Windows.Forms.ListBox cols_list;
        private System.Windows.Forms.Label lb_table_name;
        private System.Windows.Forms.TextBox tb_table_name;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_cancel;
    }
}