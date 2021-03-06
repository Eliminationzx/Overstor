﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Overstor
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
        }

        public string trigger_path
        {
            get
            {
                return tb_trigger_path.Text;
            }
            protected set
            {
                trigger_path = tb_trigger_path.Text;
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "EXE Files(.exe)|*.exe";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tb_trigger_path.Text = ofd.FileName;
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_trigger_path.Text))
            {
                MessageBox.Show("Please fill required forms!");
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
