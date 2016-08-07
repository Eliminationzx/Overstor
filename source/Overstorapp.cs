using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Overstor
{
    public partial class Overstorapp : Form
    {
        private DataBase db;
        private Process ind_proc;
        
        public Overstorapp()
        {
            InitializeComponent();
            InitializeExtentions();
        }

        private void InitializeExtentions()
        {
            db = new DataBase();
        }

        private void bindingSource1_AddingNew(object sender, AddingNewEventArgs e)
        {
            /*if (String.IsNullOrEmpty(tb_ind_path.Text) || ind_proc == null)
                return;

            ind_proc.StandardInput.WriteLine("-e");*/
        }

        private void btn_imp_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of_diag = new OpenFileDialog())
            {
                if (of_diag.ShowDialog() == DialogResult.OK)
                {
                    // Load database
                    if (!db.LoadDB(of_diag.FileName))
                    {
                        MessageBox.Show("File is corrupted!");
                        return;
                    }

                    bindingSource.DataMember = db.Tables[0].ToString();
                    bindingSource.DataSource = db.Tables[0];

                    bindingNavigator1.BindingSource = bindingSource;
                    dataView.DataSource = bindingSource;
                    dataView.EditMode = DataGridViewEditMode.EditOnEnter;
                }
            }
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf_diag = new SaveFileDialog())
            {
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

        private void btn_browse_Click(object sender, EventArgs e)
        {
            /*using (OpenFileDialog of_diag = new OpenFileDialog())
            { 
                if(of_diag.ShowDialog() == DialogResult.OK)
                {
                    tb_ind_path.Text = of_diag.FileName;
                }

                ind_proc = Process.Start(tb_ind_path.Text, null);
                ind_proc.BeginOutputReadLine();
            }*/
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = db.Tables[0];
            bindingNavigator1.BindingSource = bindingSource;
            dataView.DataSource = bindingSource;
            dataView.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void dataView_DataSourceChanged(object sender, EventArgs e)
        {
            // Enable or disable some functionals
            btn_exp.Enabled = db.Tables[0] != null;
            btn_search.Enabled = db.Tables[0] != null;
            btn_refresh.Enabled = db.Tables[0] != null;
            btn_search.Enabled = db.Tables[0] != null;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_search.Text))
            {
                MessageBox.Show("Please fill search form!");
                return;
            }

            DataView dv = new DataView(db.Tables[0]);
            string text = tb_search.Text;

            dv.RowFilter = cmb_tag.SelectedItem.ToString() + "='" + text + "'";
            bindingSource.DataSource = dv;
            bindingNavigator1.BindingSource = bindingSource;
            dataView.DataSource = bindingSource;
            dataView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            // Cleanup search parameters
            cmb_tag.Items.Clear();

            for (int i = 0; i < dataView.ColumnCount; i++)
            {
                // Set column auto size mode
                dataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                cmb_tag.Items.Add(dataView.Columns[i].Name);
            }

            // Select first parameter by default
            cmb_tag.SelectedIndex = 0;
        }

        private void create_table(string table_name, ListBox list)
        {
            if (String.IsNullOrWhiteSpace(table_name) || list.Items == null)
            {
                MessageBox.Show("Please fill required forms!");
                return;
            }

            List<string> cols_name = new List<string>(list.Items.Count);
            for (int i = 0; i < list.Items.Count; i++)
                cols_name.Add(list.Items[i].ToString());

            db.CreateDB(table_name, cols_name);

            BindingSource bindingSource_new = new BindingSource();

            bindingSource_new.DataMember = db.Tables[0].ToString();
            bindingSource_new.DataSource = db.Tables[0];

            bindingSource = bindingSource_new;

            bindingNavigator1.BindingSource = bindingSource;

            dataView.DataSource = bindingSource;
            dataView.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            using (CreatedbDialog cdb = new CreatedbDialog())
            {
                if (cdb.ShowDialog() == DialogResult.OK)
                {
                    create_table(cdb.table_name, cdb.list);
                }
            }
        }
    }
}



