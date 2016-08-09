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
        private int page_size;
        private int current_page_index;
        private int total_pages;
        private SearchDialog sdiag;
        private CreatedbDialog cdb;
        private SettingsDialog settings;
        
        public Overstorapp()
        {
            InitializeComponent();
            InitializeExtentions();
        }

        private void InitializeExtentions()
        {
            db = new DataBase();
            page_size = Convert.ToInt32(cmb_page_size.Text);
            current_page_index = 1;
            total_pages = 0;
            dataView.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Init other forms
            sdiag = new SearchDialog();
            cdb = new CreatedbDialog();
            settings = new SettingsDialog();
        }

        private void CalculateTotalPages()
        {
            total_pages = Convert.ToInt32(Math.Ceiling(bind_source.Count * 1.0 / page_size));
        }

        public void SearchTagListInit()
        {
            // Cleanup search parameters
            sdiag.tag_list.Items.Clear();

            for (int i = 0; i < dataView.ColumnCount; i++)
            {
                // Set column auto size mode
                dataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                sdiag.tag_list.Items.Add(dataView.Columns[i].Name);
            }

            // Select first parameter by default
            sdiag.tag_list.SelectedIndex = 0;
        }

        private void BindPageToGrid()
        {
            int start_index = (current_page_index - 1) * page_size;
            BindingSource tmp_bind = new BindingSource();
            for (int i = start_index; i < start_index + page_size; i++)
            {
                if (i >= bind_source.Count)
                    break;

                tmp_bind.Add(bind_source[i]);
            }

            dataView.DataSource = tmp_bind;
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

                    // Cleanup before adding new
                    dataView.DataSource = null;
                    bind_source.DataSource = null;
                    bind_source.Clear();

                    bind_source.DataMember = db.Tables[0].ToString();
                    bind_source.DataSource = db.Tables[0];

                    bind_nav.BindingSource = bind_source;

                    BindPageToGrid();
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
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (sdiag.ShowDialog() == DialogResult.OK)
            {
                DataView dv = new DataView(db.Tables[0]);
                dv.RowFilter = sdiag.filter_text;
                bind_source.DataSource = dv;
                BindPageToGrid();
            }
        }

        private void TableCreate(string table_name, ListBox list)
        {
            List<string> cols_name = new List<string>(list.Items.Count);
            for (int i = 0; i < list.Items.Count; i++)
                cols_name.Add(list.Items[i].ToString());

            db.CreateDB(table_name, cols_name);

            // Cleanup before adding new
            dataView.DataSource = null;
            bind_source.DataSource = null;
            bind_source.Clear();

            bind_source.DataMember = db.Tables[0].ToString();
            bind_source.DataSource = db.Tables[0];

            bind_nav.BindingSource = bind_source;

            BindPageToGrid();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (cdb.ShowDialog() == DialogResult.OK)
            {
                TableCreate(cdb.table_name, cdb.list);
            }
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
                    RedirectStandardInput = true,
                    RedirectStandardOutput = false,
                    RedirectStandardError = true,
                    UseShellExecute = false
                }
            };

            trigger.Start();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            current_page_index = 1;
            BindPageToGrid();
            RefreshPagination();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
           current_page_index--;

           if (current_page_index < 1)
               current_page_index = 1;

           BindPageToGrid();
           RefreshPagination();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
             current_page_index++;

             if (current_page_index > total_pages)
                 current_page_index = total_pages;

             BindPageToGrid();
             RefreshPagination();
        }

        private void RefreshPagination()
        {
            btn_prev.Enabled = btn_first.Enabled = current_page_index != 1;
            btn_next.Enabled = btn_last.Enabled = current_page_index != total_pages;
            lb_pages.Text = "Page " + current_page_index + " / " + total_pages;
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            current_page_index = total_pages;
            BindPageToGrid();
            RefreshPagination();
        }

        private void dataView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            btn_save.Enabled = db.Tables[0] != null;
            btn_search.Enabled = db.Tables[0] != null;
            btn_refresh.Enabled = db.Tables[0] != null;
            btn_search.Enabled = db.Tables[0] != null;
            cmb_page_size.Enabled = db.Tables[0] != null;
        }

        private void bind_source_CurrentChanged(object sender, EventArgs e)
        {
            CalculateTotalPages();
            RefreshPagination();
        }

        private void cmb_page_size_TextChanged(object sender, EventArgs e)
        {
            page_size = Convert.ToInt32(cmb_page_size.Text);
            RefreshPagination();
            CalculateTotalPages();
            BindPageToGrid();
        }

        private void bind_source_AddingNew(object sender, AddingNewEventArgs e)
        {
            BindPageToGrid();
            //    trigger.StandardInput.WriteLine("New event");
        }

        private void dataView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            SearchTagListInit();
        }
    }
}



