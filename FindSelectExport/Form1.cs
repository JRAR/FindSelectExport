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
    
        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (String item in lstQueryItems.Items)
            {
                TableLayoutPanel panelSearch = new TableLayoutPanel();
                TableLayoutPanel panelResults = new TableLayoutPanel();

                Label lblSearchQuery = new Label();
                Label lblresults = new Label();


                lblSearchQuery = configureLabel(lblSearchQuery);
                lblresults = configureLabel(lblresults);

                panelSearch = GenerateTable(panelSearch, 0, 1);
                panelResults = GenerateTable(panelResults, 0, 2);

                panelResults.Anchor = AnchorStyles.None; // Center table

                lblSearchQuery.Text = item;
                lblresults.Text = "This is a test";

                panelResults.Controls.Add(lblresults, 0, 0);

                panelSearch.Controls.Add(lblSearchQuery, 0, 0);
                panelSearch.Controls.Add(panelResults, 0, 1);

                panelSearch.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                panelSearch.Size = new Size(320, 100);

                panelResults.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                panelResults.Size = new Size(160, 50);


                flpMain.Controls.Add(panelSearch);
            }

             tbcfse.SelectedIndex = 1;

        }


        private Label configureLabel(Label label)
        {
            label.Anchor = AnchorStyles.None;
            label.BorderStyle = BorderStyle.Fixed3D;
            label.AutoSize = true;

            return label;

        }

        private TableLayoutPanel GenerateTable(TableLayoutPanel panel, int columnCount, int rowCount)
        {
            //Clear out the existing controls, we are generating a new table layout
            panel.Controls.Clear();

            //Clear out the existing row and column styles
            panel.ColumnStyles.Clear();
            panel.RowStyles.Clear();

            //Now we will generate the table, setting up the row and column counts first
            panel.ColumnCount = columnCount;
            panel.RowCount = rowCount;

            for (int x = 0; x < columnCount; x++)
            {
                //First add a column
                panel.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.AutoSize));

                for (int y = 0; y < rowCount; y++)
                {
                    //Next, add a row.  Only do this when once, when creating the first column
                    if (x == 0)
                    {
                        panel.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.AutoSize));
                        Button cmd = new Button();
                        Label lbl = new Label();
                        //lbl.Text = "test";
                        //cmd.Text = string.Format("({0}, {1})", x, y);         //Finally, add the control to the correct location in the table
                        panel.Controls.Add(lbl);

                    }

                    //Create the control, in this case we will add a button
                }
            }
            return panel;
        }



        private void flpMain_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
