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

        public frmQuerySettings(Form callingForm, String fileInput, String fileTarget, List<String> queryItems)
        {
            mainForm = callingForm as frmFSE;
            InitializeComponent();

            this.txtFolderInput.Text = fileInput;
            this.txtExportPath.Text = fileTarget;
            this.lstQueryItems.Items.AddRange(queryItems.ToArray());

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
            mainForm.getMainTreeView.Nodes.Clear();
            foreach (String item in this.lstQueryItems.Items)
            {
                mainForm.getMainTreeView.Nodes.Add(FileResults.GetDataPanel(this.txtFolderInput.Text, item));
            }
            mainForm.Focus();

            mainForm.fileInput = this.txtFolderInput.Text;
            mainForm.fileDestination = this.txtExportPath.Text;
            mainForm.queryList = this.lstQueryItems.Items.Cast<String>().ToList();



            this.Close();

        }

        private void frmQuerySettings_Load(object sender, EventArgs e)
        {

        }


    }
}
