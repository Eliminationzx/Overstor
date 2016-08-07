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
        private Process trigger;
        private DataBase db;
        
        public Overstorapp()
        {
            InitializeComponent();
            InitializeExtentions();
        }

        private void InitializeExtentions()
        {
            db = new DataBase();

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
            bindingSource.DataSource = db.Tables[0];
            bindingNavigator1.BindingSource = bindingSource;
            dataView.DataSource = bindingSource;
            dataView.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void dataView_DataSourceChanged(object sender, EventArgs e)
        {
            // Enable or disable some functionals
            btn_save.Enabled = db.Tables != null;
            btn_search.Enabled = db.Tables != null;
            btn_refresh.Enabled = db.Tables != null;
            btn_search.Enabled = db.Tables != null;
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

        private void btn_settings_Click(object sender, EventArgs e)
        {
            using (SettingsDialog settings = new SettingsDialog())
            {
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    init_trigger(settings.trigger_path);
                }
            }
        }

        private void init_trigger(string path)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Please fill required forms!");
                return;
            }

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

        private void dataView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                Console.WriteLine("{0} is active: {1}", trigger.Id, !trigger.HasExited);
                trigger.StandardInput.WriteLine("New event");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}



