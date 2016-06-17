using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace FindSelectExport
{
    public partial class frmQuerySettings : Form
    {

        /// <summary>
        /// Query Settings form is design to give the user options to modify search queries, and specify a input and 
        /// export file.
        /// </summary>

        private frmFSE mainForm = null;

        public frmQuerySettings()
        {

            InitializeComponent();

        }

        /// <summary>
        /// Initiation method created from main form
        /// </summary>
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
           


            if (fieldsAreValid())
            {
                //Send fields to main form for external memory
                mainForm.fileInput = this.txtFolderInput.Text;
                mainForm.fileDestination = this.txtExportPath.Text;
                mainForm.queryList = this.lstQueryItems.Items.Cast<String>().ToList();
                mainForm.exportList.Clear();

                //Clear the tree of any entrees
                mainForm.getMainTreeView.Nodes.Clear();
                //Put the curser on wait to alert the user of calculation
                Cursor.Current = Cursors.WaitCursor;
                foreach (String item in this.lstQueryItems.Items) // For each query
                {
                    //Get file results
                    mainForm.getMainTreeView.Nodes.Add(FileManager.GetTreeData(this.txtFolderInput.Text, item));
                }
                Cursor.Current = Cursors.Default; //Set curser back to defult

                mainForm.Focus();
                this.Close();
            }
        }

        /// <summary>
        /// Check if all the fields for sanity
        /// </summary>
        private bool fieldsAreValid()
        {
            String errorMessages = "";

            if (!Directory.Exists(this.txtFolderInput.Text))
            {
                errorMessages += "File input path does not exist\n";

            }

            if (!Directory.Exists(this.txtExportPath.Text))
            {
                errorMessages += "File Export path does not exist\n";

            }

            if (lstQueryItems.Items.Count == 0)
            {
                errorMessages += "There are no items to query\n";

            }

            if (!String.IsNullOrEmpty(errorMessages))
            {
                errorMessages += "\nPlease fix any errors before proceding.";
                errorMessages = "The following errors have occured:\n\n" + errorMessages;
                MessageBox.Show(errorMessages,"Error: Missing field",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void frmQuerySettings_Load(object sender, EventArgs e)
        {

        }


    }
}
