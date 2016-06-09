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


        public frmFSE()
        {

            InitializeComponent();

            this.tvResults.CheckBoxes = true;
            this.tvResults.DrawMode = TreeViewDrawMode.OwnerDrawText;
            this.tvResults.DrawNode += new DrawTreeNodeEventHandler(tree_DrawNode);
            queryList = new List<String>();
       

        }

        private void frmFSE_Load(object sender, EventArgs e)
        {
            frmQuerySettings settings = new frmQuerySettings(this, this.fileInput, this.fileDestination, this.queryList);
            settings.Show();
            settings.TopMost = true;
        }

        

        void treeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            this.tvResults.Invalidate();
        }

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

        private void tree_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node.Level != 2)
            {
                HideCheckBox(e.Node);
                e.DrawDefault = true;
            }
            else
            {
                e.Graphics.DrawString(e.Node.Text, e.Node.TreeView.Font,
                  Brushes.Black, e.Node.Bounds.X, e.Node.Bounds.Y);
            }
        }

        private void querySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuerySettings settings = new frmQuerySettings(this, this.fileInput, this.fileDestination, this.queryList);
            settings.Show(this);
        }

    }
}
