using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace FindSelectExport
{
    public partial class frmQuerySettings : Form
    {

        private frmFSE mainForm = null;

        public frmQuerySettings()
        {

            InitializeComponent();

        }

        public frmQuerySettings(Form callingForm)
        {
            mainForm = callingForm as frmFSE;
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
                txtSearchItem.Focus();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstQueryItems.Items.Count != 0 && lstQueryItems.SelectedIndex != -1)
            {
                lstQueryItems.Items.RemoveAt(lstQueryItems.SelectedIndex);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (String item in this.lstQueryItems.Items)
            {
                mainForm.getMainTreeView.Nodes.Add(FileResults.GetDataPanel(this.txtFolderInput.Text, item));

            }
            mainForm.getMainTreeView.Refresh();

        }

        private void Query_Settings_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmQuerySettings_Load(object sender, EventArgs e)
        {

        }

    }
}
