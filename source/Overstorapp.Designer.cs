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
            this.bind_nav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.btn_create = new System.Windows.Forms.ToolStripButton();
            this.btn_save = new System.Windows.Forms.ToolStripButton();
            this.btn_ins = new System.Windows.Forms.ToolStripButton();
            this.btn_settings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmb_tag = new System.Windows.Forms.ToolStripComboBox();
            this.btn_search = new System.Windows.Forms.ToolStripButton();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bind_source = new System.Windows.Forms.BindingSource(this.components);
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.lb_pages = new System.Windows.Forms.Label();
            this.cmb_page_size = new System.Windows.Forms.ComboBox();
            this.lb_page_size = new System.Windows.Forms.Label();
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
            this.dataView.Location = new System.Drawing.Point(12, 55);
            this.dataView.Name = "dataView";
            this.dataView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataView.Size = new System.Drawing.Size(777, 414);
            this.dataView.TabIndex = 0;
            this.dataView.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataView_ColumnAdded);
            this.dataView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataView_DataBindingComplete);
            this.dataView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataView_RowsAdded);
            // 
            // bind_nav
            // 
            this.bind_nav.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bind_nav.CountItem = this.bindingNavigatorCountItem;
            this.bind_nav.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bind_nav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_create,
            this.btn_save,
            this.btn_ins,
            this.btn_settings,
            this.toolStripSeparator2,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.btn_refresh,
            this.toolStripSeparator1,
            this.cmb_tag,
            this.btn_search});
            this.bind_nav.Location = new System.Drawing.Point(0, 0);
            this.bind_nav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bind_nav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bind_nav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bind_nav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bind_nav.Name = "bind_nav";
            this.bind_nav.PositionItem = this.bindingNavigatorPositionItem;
            this.bind_nav.Size = new System.Drawing.Size(801, 25);
            this.bind_nav.TabIndex = 1;
            this.bind_nav.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.btn_refresh.Text = "Обновить";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cmb_tag
            // 
            this.cmb_tag.Name = "cmb_tag";
            this.cmb_tag.Size = new System.Drawing.Size(121, 25);
            // 
            // btn_search
            // 
            this.btn_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_search.Enabled = false;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(23, 22);
            this.btn_search.Text = "toolStripButton1";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.Location = new System.Drawing.Point(12, 29);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(777, 20);
            this.tb_search.TabIndex = 2;
            // 
            // bind_source
            // 
            this.bind_source.CurrentChanged += new System.EventHandler(this.bind_source_CurrentChanged);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(403, 475);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(74, 20);
            this.btn_first.TabIndex = 3;
            this.btn_first.Text = "First";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(483, 475);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(74, 20);
            this.btn_prev.TabIndex = 4;
            this.btn_prev.Text = "Previous";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(635, 475);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(74, 20);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(715, 475);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(74, 20);
            this.btn_last.TabIndex = 6;
            this.btn_last.Text = "Last";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // lb_pages
            // 
            this.lb_pages.AutoSize = true;
            this.lb_pages.Location = new System.Drawing.Point(563, 479);
            this.lb_pages.Name = "lb_pages";
            this.lb_pages.Size = new System.Drawing.Size(37, 13);
            this.lb_pages.TabIndex = 7;
            this.lb_pages.Text = "Pages";
            // 
            // cmb_page_size
            // 
            this.cmb_page_size.FormattingEnabled = true;
            this.cmb_page_size.Items.AddRange(new object[] {
            "5",
            "10",
            "100",
            "25",
            "50"});
            this.cmb_page_size.Location = new System.Drawing.Point(335, 475);
            this.cmb_page_size.Name = "cmb_page_size";
            this.cmb_page_size.Size = new System.Drawing.Size(62, 21);
            this.cmb_page_size.TabIndex = 8;
            this.cmb_page_size.Text = "10";
            this.cmb_page_size.SelectedValueChanged += new System.EventHandler(this.cmb_page_size_SelectedValueChanged);
            // 
            // lb_page_size
            // 
            this.lb_page_size.AutoSize = true;
            this.lb_page_size.Location = new System.Drawing.Point(273, 478);
            this.lb_page_size.Name = "lb_page_size";
            this.lb_page_size.Size = new System.Drawing.Size(56, 13);
            this.lb_page_size.TabIndex = 9;
            this.lb_page_size.Text = "Page size:";
            // 
            // Overstorapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 507);
            this.Controls.Add(this.lb_page_size);
            this.Controls.Add(this.cmb_page_size);
            this.Controls.Add(this.lb_pages);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.bind_nav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.BindingNavigator bind_nav;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bind_source;
        private System.Windows.Forms.ToolStripButton btn_ins;
        private System.Windows.Forms.ToolStripButton btn_save;
        private System.Windows.Forms.ToolStripButton btn_refresh;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ToolStripComboBox cmb_tag;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_search;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_create;
        private System.Windows.Forms.ToolStripButton btn_settings;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Label lb_pages;
        private System.Windows.Forms.ComboBox cmb_page_size;
        private System.Windows.Forms.Label lb_page_size;
    }
}

