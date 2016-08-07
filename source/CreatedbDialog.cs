using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overstor
{
    public partial class CreatedbDialog : Form
    {
        public CreatedbDialog()
        {
            InitializeComponent();
        }

        public string table_name
        {
            get
            {
                return tb_table_name.Text;
            }
            protected set
            {
                table_name = tb_table_name.Text;
            }
        }

        public ListBox list
        {
            get
            {
                return cols_list;
            }
            protected set
            {
                list = cols_list;
            }
        }

        private void cols_add_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < cols_list.Items.Count; i++)
                {
                    // Don't allow to add columns with same name
                    if (cols_list.GetItemText(cols_list.Items[i]) == tb_cols_name.Text)
                    {
                        MessageBox.Show("Column with this name already exist!");
                        return;
                    }
                }
                cols_list.Items.Add(tb_cols_name.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cols_del_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < cols_list.Items.Count; i++)
                {
                    // Don't allow to add columns with same name
                    if (cols_list.GetItemText(cols_list.Items[i]) != tb_cols_name.Text)
                    {
                        MessageBox.Show("Column with this name doesn't exist!");
                        return;
                    }
                }
                cols_list.Items.Remove(tb_cols_name.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
