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
    //panel.Anchor = System.Windows.Forms.AnchorStyles.None;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (String item in lstQueryItems.Items)
            {
                Label label = new Label();
                TableLayoutPanel panel = new TableLayoutPanel();
                panel.ColumnCount = 1;
                panel.RowCount = 2;
                
                //panel.Anchor = System.Windows.Forms.AnchorStyles.None;
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                panel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                label.Text = item;
                panel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                panel.Controls.Add(label, 1, 1);

                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.Size = new Size(320, 100);


                

                flpMain.Controls.Add(panel);
            }

             tbcfse.SelectedIndex = 1;

        }

        private void flpMain_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
