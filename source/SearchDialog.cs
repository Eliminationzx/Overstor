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
    public partial class SearchDialog : Form
    {
        public SearchDialog()
        {
            InitializeComponent();
            cmb_tag_list = tag_list;
        }

        public string search_text
        {
            get
            {
                return tb_search.Text;
            }
            private set
            {
                search_text = tb_search.Text;
            }
        }

        public string filter_text
        {
            get
            {
                return cmb_tag_list.SelectedItem.ToString() + "='" + tb_search.Text + "'";
            }
            private set
            {
                filter_text = cmb_tag_list.SelectedItem.ToString() + "='" + tb_search.Text + "'";
            }
        }

        public ComboBox tag_list
        {
            get
            {
                return cmb_tag_list;
            }
            private set
            {
                tag_list = cmb_tag_list;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_search.Text))
            {
                MessageBox.Show("Please fill search form!");
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
