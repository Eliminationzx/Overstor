using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;


namespace Overstor
{
    public partial class Overstorapp : Form
    {
        private Process trigger;
        private DataBase db;
        private int current_page_index;
        private int total_pages;
        private SearchDialog sdiag;
        private SettingsDialog settings;
        
        public Overstorapp()
        {
            InitializeComponent();
            InitializeExtentions();
        }

        private void InitializeExtentions()
        {
            db = new DataBase();
            sdiag = new SearchDialog();
            settings = new SettingsDialog();

            current_page_index = 1;
            total_pages = 0;
        }

        private void CalculateTotalPages()
        {
            int page_size = Convert.ToInt32(cmb_pagesize.Text);
            total_pages = (int)Math.Ceiling((double)bind_source.Count / page_size);
        }

        public void SearchTagListInit()
        {
            // Cleanup search parameters
            sdiag.tag_list.Items.Clear();

            for (int i = 0; i < dataView.ColumnCount; i++)
            {
                sdiag.tag_list.Items.Add(dataView.Columns[i].Name);
            }

            // Select first parameter by default
            sdiag.tag_list.SelectedIndex = 0;
        }

        private void BindSourceToNav()
        {
            // Cleanup before adding new
            dataView.DataSource = null;
            bind_source.DataSource = null;
            bind_source.Clear();

            bind_source.DataMember = db.Tables[0].ToString();
            bind_source.DataSource = db.Tables[0];
            bind_nav.BindingSource = bind_source;
        }

        private void BindPageToGrid()
        {
            try
            {
                int page_size = Convert.ToInt32(cmb_pagesize.Text);
                int start_index = (current_page_index - 1) * page_size;
                BindingSource tmp_bind = new BindingSource();

                for (int i = start_index; i < start_index + page_size; i++)
                {
                    if (i >= bind_source.Count)
                        break;

                    tmp_bind.Add(bind_source[i]);
                }

                dataView.DataSource = tmp_bind;

                RefreshPagination();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void btn_imp_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of_diag = new OpenFileDialog())
            {
                of_diag.Filter = "XML files (.xml)|*.xml";

                if (of_diag.ShowDialog() == DialogResult.OK)
                {
                    // Load database
                    if (!db.LoadDB(of_diag.FileName))
                    {
                        MessageBox.Show("File is corrupted!");
                        return;
                    }

                    BindSourceToNav();
                }
            }
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf_diag = new SaveFileDialog())
            {
                sf_diag.Filter = "XML files (.xml)|*.xml";

                if (sf_diag.ShowDialog() == DialogResult.OK)
                {
                    if (!db.SaveDB(sf_diag.FileName))
                    {
                        MessageBox.Show("File is corrupted!");
                        return;
                    }
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            BindPageToGrid();
            RefreshPagination();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (sdiag.ShowDialog() == DialogResult.OK)
            {
                DataView dv = new DataView(db.Tables[0]);
                dv.RowFilter = sdiag.filter_text;

                try
                {
                    int page_size = Convert.ToInt32(cmb_pagesize.Text);
                    int start_index = (current_page_index - 1) * page_size;
                    BindingSource tmp_bind = new BindingSource();

                    for (int i = start_index; i < start_index + page_size; i++)
                    {
                        if (i >= dv.Count)
                            break;

                        tmp_bind.Add(dv[i]);
                    }

                    dataView.DataSource = tmp_bind;

                    RefreshPagination();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void RefreshPagination()
        {
            // Refresh pagination
            btn_prev.Enabled = btn_first.Enabled = current_page_index != 1;
            btn_next.Enabled = btn_last.Enabled = current_page_index != total_pages;
            lb_pages.Text = "Page " + current_page_index.ToString() + " / " + total_pages.ToString();
        }

        private void TableCreate(string table_name, ListBox list)
        {
            List<string> cols_name = new List<string>(list.Items.Count);
            for (int i = 0; i < list.Items.Count; i++)
                cols_name.Add(list.Items[i].ToString());

            db.CreateDB(table_name, cols_name);
            BindSourceToNav();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            CreatedbDialog cdb = new CreatedbDialog();
            if (cdb.ShowDialog() == DialogResult.OK)
            {
                TableCreate(cdb.table_name, cdb.list);
            }
            cdb.Dispose();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            if (settings.ShowDialog() == DialogResult.OK)
            {
                TriggerInit(settings.trigger_path);
            }
        }

        private void TriggerInit(string path)
        {
            trigger = new Process
            {
                StartInfo =
                {
                    FileName = path,
                    RedirectStandardInput = false,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    UseShellExecute = false
                }
            };
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            current_page_index = 1;
            BindPageToGrid();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
           current_page_index--;

           if (current_page_index < 1)
               current_page_index = 1;

           BindPageToGrid();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
             current_page_index++;

             if (current_page_index > total_pages)
                 current_page_index = total_pages;

             BindPageToGrid();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            current_page_index = total_pages;
            BindPageToGrid();
        }

        private void dataView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataView.Enabled = db.Tables[0] != null;
            btn_save.Enabled = db.Tables[0] != null;
            btn_search.Enabled = db.Tables[0] != null;
            btn_refresh.Enabled = db.Tables[0] != null;
            btn_search.Enabled = db.Tables[0] != null;
            cmb_pagesize.Enabled = db.Tables[0] != null;
        }

        private void bind_source_CurrentChanged(object sender, EventArgs e)
        {
            CalculateTotalPages();
            BindPageToGrid();
            RefreshPagination();
        }

        private void dataView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            SearchTagListInit();
        }

        private void cmb_pagesize_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotalPages();
            BindPageToGrid();
        }

        private void dataView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (ColChanger cch = new ColChanger())
            {
                if (cch.ShowDialog() == DialogResult.OK)
                {
                    dataView.Columns[e.ColumnIndex].HeaderCell.Value = cch.col_name;
                }
                cch.Dispose();
            }
        }

        private void bind_source_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (trigger != null)
                trigger.Start();
        }
    }
}



