using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FindSelectExport
{
    public partial class frmFSE : Form
    {
        public frmFSE()
        {
            InitializeComponent();

        }

        private void btnTarget_Click(object sender, System.EventArgs e)
        {
            if (fbdDirectory.ShowDialog() == DialogResult.OK)
            {
                txtFolderInput.Text = fbdDirectory.SelectedPath;
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (fbdDirectory.ShowDialog() == DialogResult.OK)
            {
                txtExportPath.Text = fbdDirectory.SelectedPath;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSearchItem.Text != "")
            {
                lstQueryItems.Items.Add(txtSearchItem.Text);
                txtSearchItem.Clear();
            }
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstQueryItems.Items.Count != 0) {
                lstQueryItems.Items.RemoveAt(lstQueryItems.SelectedIndex);
            }
        }
    }
}
