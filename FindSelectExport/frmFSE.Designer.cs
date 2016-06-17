namespace FindSelectExport
{
    partial class frmFSE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fbdDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ftmsMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.querySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvResults = new System.Windows.Forms.TreeView();
            this.btnExport = new System.Windows.Forms.Button();
            this.grpExport = new System.Windows.Forms.GroupBox();
            this.chkDeleteDestination = new System.Windows.Forms.CheckBox();
            this.lblSelectIndex = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ftmsMainMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ftmsMainMenu
            // 
            this.ftmsMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.querySettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ftmsMainMenu.Name = "ftmsMainMenu";
            this.ftmsMainMenu.Size = new System.Drawing.Size(37, 20);
            this.ftmsMainMenu.Text = "File";
            // 
            // querySettingsToolStripMenuItem
            // 
            this.querySettingsToolStripMenuItem.Name = "querySettingsToolStripMenuItem";
            this.querySettingsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.querySettingsToolStripMenuItem.Text = "Query Settings";
            this.querySettingsToolStripMenuItem.Click += new System.EventHandler(this.querySettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tvResults
            // 
            this.tvResults.CheckBoxes = true;
            this.tvResults.Location = new System.Drawing.Point(12, 27);
            this.tvResults.Name = "tvResults";
            this.tvResults.Size = new System.Drawing.Size(506, 198);
            this.tvResults.TabIndex = 2;
            this.tvResults.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView_After_Check);
            this.tvResults.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterExpand);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(6, 61);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(106, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export Files";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // grpExport
            // 
            this.grpExport.Controls.Add(this.chkDeleteDestination);
            this.grpExport.Controls.Add(this.lblSelectIndex);
            this.grpExport.Controls.Add(this.btnExport);
            this.grpExport.Location = new System.Drawing.Point(106, 231);
            this.grpExport.Name = "grpExport";
            this.grpExport.Size = new System.Drawing.Size(338, 101);
            this.grpExport.TabIndex = 4;
            this.grpExport.TabStop = false;
            this.grpExport.Text = "Export Options";
            // 
            // chkDeleteDestination
            // 
            this.chkDeleteDestination.AutoSize = true;
            this.chkDeleteDestination.Location = new System.Drawing.Point(185, 65);
            this.chkDeleteDestination.Name = "chkDeleteDestination";
            this.chkDeleteDestination.Size = new System.Drawing.Size(120, 17);
            this.chkDeleteDestination.TabIndex = 5;
            this.chkDeleteDestination.Text = "Delete Old Location";
            this.chkDeleteDestination.UseVisualStyleBackColor = true;
            // 
            // lblSelectIndex
            // 
            this.lblSelectIndex.AutoSize = true;
            this.lblSelectIndex.Location = new System.Drawing.Point(86, 25);
            this.lblSelectIndex.Name = "lblSelectIndex";
            this.lblSelectIndex.Size = new System.Drawing.Size(85, 13);
            this.lblSelectIndex.TabIndex = 4;
            this.lblSelectIndex.Text = "Selected Files: 0";
            // 
            // frmFSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 344);
            this.Controls.Add(this.grpExport);
            this.Controls.Add(this.tvResults);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFSE";
            this.Text = "FSE";
            this.Load += new System.EventHandler(this.frmFSE_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpExport.ResumeLayout(false);
            this.grpExport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdDirectory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ftmsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem querySettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TreeView tvResults;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox grpExport;
        private System.Windows.Forms.CheckBox chkDeleteDestination;
        private System.Windows.Forms.Label lblSelectIndex;


    }
}

