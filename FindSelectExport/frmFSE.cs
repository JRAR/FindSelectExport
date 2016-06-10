using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;



namespace FindSelectExport
{
    public partial class frmFSE : Form
    {

        #region TV DLL Settings
        public const int TVIF_STATE = 0x8;
        public const int TVIS_STATEIMAGEMASK = 0xF000;
        public const int TV_FIRST = 0x1100;
        public const int TVM_SETITEM = TV_FIRST + 63;

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam,
        IntPtr lParam);

        // struct used to set node properties
        public struct TVITEM
        {
            public int mask;
            public IntPtr hItem;
            public int state;
            public int stateMask;
            [MarshalAs(UnmanagedType.LPTStr)]
            public String lpszText;
            public int cchTextMax;
            public int iImage;
            public int iSelectedImage;
            public int cChildren;
            public IntPtr lParam;

        }

        #endregion

        //Accessors and  mutators for FSE settings
        public String fileInput { set; get; }

        public String fileDestination {set;get;}

        public List<String> queryList { set; get; }

        public TreeView getMainTreeView
        {
            get
            {
                return this.tvResults;

            }
        }

        //Export list of items for each individual item checked on the tree
        public List<String> exportList { set; get; }

        public frmFSE()
        {

            InitializeComponent();
            //Adding custom events for child-only checkboxes
            this.tvResults.CheckBoxes = true;
            this.tvResults.DrawMode = TreeViewDrawMode.OwnerDrawText;
            this.tvResults.DrawNode += new DrawTreeNodeEventHandler(tree_DrawNode);
            //Initiate lists
            queryList = new List<String>();
            exportList = new List<String>();
       

        }

        private void frmFSE_Load(object sender, EventArgs e)
        {
            //On load, have the user load FSE settings via menu
            frmQuerySettings settings = new frmQuerySettings(this, this.fileInput, this.fileDestination, this.queryList);
            settings.Show();
            settings.TopMost = true;
        }

        
        /// <summary>
        /// Workaround to prevent Treeview graphical glitch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void treeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            this.tvResults.Invalidate();
        }

        /// <summary>
        /// Custom after check event - will check for other nodes with the same file path & add to export list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void treeView_After_Check(object sender, TreeViewEventArgs e)
        {
            //Removing handler to prevent recursion, giving a nasty stackoverflow error
            this.tvResults.AfterCheck -= new System.Windows.Forms.TreeViewEventHandler(this.treeView_After_Check);

                if (e.Node.Checked == true) //Is the node already checked
                {
                    checkSameNodes(e.Node, true);
                    exportList.Add(e.Node.Text); //Add to list
                }
                else if (e.Node.Checked == false) // If nose isn't checked
                {
                    checkSameNodes(e.Node, false);
                    exportList.Remove(e.Node.Text);//Remove from list
                }

            //Add handler back to Tree
            this.tvResults.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView_After_Check);
            //Label to specify how many items are checked
            lblSelectIndex.Text = String.Format("Selected Files: {0}", exportList.Count());

        }

        /// <summary>
        ///This method will check for any like nodes with same Text. If found,
        ///it will automatically check it's checkbox
        /// </summary>
        /// <param name="toCheck"></param>
        /// <param name="check"></param>
        void checkSameNodes(TreeNode toCheck, bool check)
        {

            List<TreeNode> likeNodes = tvResults.FlattenTree()
                                    .Cast<TreeNode>()
                                    .Where(r => r.Text == toCheck.Text)
                                    .ToList(); 

            foreach (TreeNode node in likeNodes)
            {
                if (toCheck.Text.Equals(node.Text))
                {
                    node.Checked = check;

                }

            }

        }

        /// <summary>
        /// Part of child-only checkbox workaround
        /// </summary>
        /// <param name="node"></param>
        private void HideCheckBox(TreeNode node)
        {
            TVITEM tvi = new TVITEM();
            tvi.hItem = node.Handle;
            tvi.mask = TVIF_STATE;
            tvi.stateMask = TVIS_STATEIMAGEMASK;
            tvi.state = 0;
            IntPtr lparam = Marshal.AllocHGlobal(Marshal.SizeOf(tvi));
            Marshal.StructureToPtr(tvi, lparam, false);
            SendMessage(node.TreeView.Handle, TVM_SETITEM, IntPtr.Zero, lparam);

        }


        /// <summary>
        /// Part of child-only checkbox workaround
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tree_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node.Level != 2) //Draw normally
            {
                HideCheckBox(e.Node);
                e.DrawDefault = true;
            }
            else //Otherwise...
            {
                // Only give the children checkboxes
                e.Graphics.DrawString(e.Node.Text, e.Node.TreeView.Font,
                  Brushes.Black, e.Node.Bounds.X, e.Node.Bounds.Y);
            }
        }

        /// <summary>
        /// Menustrip - will create a new mene and pass settings stored on this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void querySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuerySettings settings = new frmQuerySettings(this, this.fileInput, this.fileDestination, this.queryList);
            settings.Show(this);
        }
        /// <summary>
        /// Export file button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            foreach(String path in exportList) {

                FileManager.MoveFile(path, fileDestination, chkDeleteDestination.Checked);              
            }
            MessageBox.Show("All files have been moved");
            tvResults.Nodes.Clear();
        }

    }
}
