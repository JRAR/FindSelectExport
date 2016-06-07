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

           public TreeView getMainTreeView
           {
               get
               {
                   return this.tvResults;
               }
           }


           private void frmFSE_Load(object sender, EventArgs e)
        {
            frmQuerySettings settings = new frmQuerySettings(this);
            settings.Show();
        }

        public void loadQueries()
        {
            
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        
        }

        private void querySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuerySettings settings = new frmQuerySettings();
            settings.Show(this);
        }





    }
}
