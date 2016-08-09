namespace Overstor
{
    partial class Overstorapp
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overstorapp));
            this.dataView = new System.Windows.Forms.DataGridView();
            this.btn_create = new System.Windows.Forms.ToolStripButton();
            this.btn_save = new System.Windows.Forms.ToolStripButton();
            this.btn_ins = new System.Windows.Forms.ToolStripButton();
            this.btn_settings = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.btn_refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_search = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_first = new System.Windows.Forms.ToolStripButton();
            this.bind_nav = new System.Windows.Forms.BindingNavigator(this.components);
            this.lb_pgsize = new System.Windows.Forms.ToolStripLabel();
            this.btn_prev = new System.Windows.Forms.ToolStripButton();
            this.lb_pages = new System.Windows.Forms.ToolStripLabel();
            this.btn_next = new System.Windows.Forms.ToolStripButton();
            this.btn_last = new System.Windows.Forms.ToolStripButton();
            this.bind_source = new System.Windows.Forms.BindingSource(this.components);
            this.tb_page_size = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind_nav)).BeginInit();
            this.bind_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bind_source)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.AllowUserToOrderColumns = true;
            this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Enabled = false;
            this.dataView.Location = new System.Drawing.Point(12, 28);
            this.dataView.Name = "dataView";
            this.dataView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataView.Size = new System.Drawing.Size(837, 467);
            this.dataView.TabIndex = 0;
            this.dataView.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataView_ColumnAdded);
            this.dataView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataView_DataBindingComplete);
            // 
            // btn_create
            // 
            this.btn_create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_create.Image = ((System.Drawing.Image)(resources.GetObject("btn_create.Image")));
            this.btn_create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(23, 22);
            this.btn_create.Text = "Create";
            this.btn_create.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_save.Enabled = false;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeftAutoMirrorImage = true;
            this.btn_save.Size = new System.Drawing.Size(23, 22);
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_exp_Click);
            // 
            // btn_ins
            // 
            this.btn_ins.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ins.Image = ((System.Drawing.Image)(resources.GetObject("btn_ins.Image")));
            this.btn_ins.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ins.Name = "btn_ins";
            this.btn_ins.RightToLeftAutoMirrorImage = true;
            this.btn_ins.Size = new System.Drawing.Size(23, 22);
            this.btn_ins.Text = "Insert";
            this.btn_ins.Click += new System.EventHandler(this.btn_imp_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.Image")));
            this.btn_settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(23, 22);
            this.btn_settings.Text = "Settings";
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // btn_refresh
            // 
            this.btn_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_refresh.Enabled = false;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.RightToLeftAutoMirrorImage = true;
            this.btn_refresh.Size = new System.Drawing.Size(23, 22);
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_search
            // 
            this.btn_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_search.Enabled = false;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(23, 22);
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_first
            // 
            this.btn_first.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_first.Enabled = false;
            this.btn_first.Image = ((System.Drawing.Image)(resources.GetObject("btn_first.Image")));
            this.btn_first.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(23, 22);
            this.btn_first.Text = "First";
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // bind_nav
            // 
            this.bind_nav.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bind_nav.CountItem = null;
            this.bind_nav.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bind_nav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_create,
            this.btn_save,
            this.btn_ins,
            this.btn_settings,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.btn_refresh,
            this.toolStripSeparator1,
            this.btn_search,
            this.toolStripSeparator3,
            this.lb_pgsize,
            this.tb_page_size,
            this.btn_first,
            this.btn_prev,
            this.lb_pages,
            this.btn_next,
            this.btn_last});
            this.bind_nav.Location = new System.Drawing.Point(0, 0);
            this.bind_nav.MoveFirstItem = null;
            this.bind_nav.MoveLastItem = null;
            this.bind_nav.MoveNextItem = null;
            this.bind_nav.MovePreviousItem = null;
            this.bind_nav.Name = "bind_nav";
            this.bind_nav.PositionItem = null;
            this.bind_nav.Size = new System.Drawing.Size(861, 25);
            this.bind_nav.TabIndex = 1;
            this.bind_nav.Text = "Binding navigator";
            this.bind_nav.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.bind_nav_ItemAdded);
            // 
            // lb_pgsize
            // 
            this.lb_pgsize.Name = "lb_pgsize";
            this.lb_pgsize.Size = new System.Drawing.Size(58, 22);
            this.lb_pgsize.Text = "Page size:";
            // 
            // btn_prev
            // 
            this.btn_prev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_prev.Enabled = false;
            this.btn_prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_prev.Image")));
            this.btn_prev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(23, 22);
            this.btn_prev.Text = "Previous";
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // lb_pages
            // 
            this.lb_pages.Name = "lb_pages";
            this.lb_pages.Size = new System.Drawing.Size(38, 22);
            this.lb_pages.Text = "Pages";
            // 
            // btn_next
            // 
            this.btn_next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_next.Enabled = false;
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(23, 22);
            this.btn_next.Text = "Next";
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_last.Enabled = false;
            this.btn_last.Image = ((System.Drawing.Image)(resources.GetObject("btn_last.Image")));
            this.btn_last.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(23, 22);
            this.btn_last.Text = "Last";
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // bind_source
            // 
            this.bind_source.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bind_source_AddingNew);
            this.bind_source.CurrentChanged += new System.EventHandler(this.bind_source_CurrentChanged);
            // 
            // tb_page_size
            // 
            this.tb_page_size.Name = "tb_page_size";
            this.tb_page_size.ReadOnly = true;
            this.tb_page_size.Size = new System.Drawing.Size(100, 25);
            this.tb_page_size.Text = "10";
            this.tb_page_size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_page_size_KeyPress);
            this.tb_page_size.TextChanged += new System.EventHandler(this.tb_page_size_TextChanged);
            // 
            // Overstorapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 507);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.bind_nav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Overstorapp";
            this.Text = "Overstor";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind_nav)).EndInit();
            this.bind_nav.ResumeLayout(false);
            this.bind_nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bind_source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.BindingSource bind_source;
        private System.Windows.Forms.ToolStripButton btn_create;
        private System.Windows.Forms.ToolStripButton btn_save;
        private System.Windows.Forms.ToolStripButton btn_ins;
        private System.Windows.Forms.ToolStripButton btn_settings;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton btn_refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_search;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_first;
        private System.Windows.Forms.BindingNavigator bind_nav;
        private System.Windows.Forms.ToolStripButton btn_prev;
        private System.Windows.Forms.ToolStripLabel lb_pages;
        private System.Windows.Forms.ToolStripButton btn_next;
        private System.Windows.Forms.ToolStripButton btn_last;
        private System.Windows.Forms.ToolStripLabel lb_pgsize;
        private System.Windows.Forms.ToolStripTextBox tb_page_size;
    }
}

