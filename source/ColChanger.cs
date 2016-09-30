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
    public partial class ColChanger : Form
    {
        public ColChanger()
        {
            InitializeComponent();
        }

        public string col_name
        {
            get
            {
                return tb_col_name.Text;
            }
            protected set
            {
                col_name = tb_col_name.Text;
            }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_col_name.Text))
            {
                MessageBox.Show("Please fill required forms!");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
