namespace FindSelectExport
{
    partial class frmQuerySettings
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
            this.grpboxSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstQueryItems = new System.Windows.Forms.ListBox();
            this.lblExport = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnTarget = new System.Windows.Forms.Button();
            this.txtExportPath = new System.Windows.Forms.TextBox();
            this.txtFolderInput = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.fbdDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.grpboxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxSearch
            // 
            this.grpboxSearch.Controls.Add(this.txtSearchItem);
            this.grpboxSearch.Controls.Add(this.btnRemove);
            this.grpboxSearch.Controls.Add(this.btnAdd);
            this.grpboxSearch.Controls.Add(this.lstQueryItems);
            this.grpboxSearch.Controls.Add(this.lblExport);
            this.grpboxSearch.Controls.Add(this.lblTarget);
            this.grpboxSearch.Controls.Add(this.btnExport);
            this.grpboxSearch.Controls.Add(this.btnTarget);
            this.grpboxSearch.Controls.Add(this.txtExportPath);
            this.grpboxSearch.Controls.Add(this.txtFolderInput);
            this.grpboxSearch.Location = new System.Drawing.Point(7, 12);
            this.grpboxSearch.Name = "grpboxSearch";
            this.grpboxSearch.Size = new System.Drawing.Size(340, 250);
            this.grpboxSearch.TabIndex = 6;
            this.grpboxSearch.TabStop = false;
            this.grpboxSearch.Text = "Search Properties";
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Location = new System.Drawing.Point(84, 194);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(160, 20);
            this.txtSearchItem.TabIndex = 14;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(164, 220);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 21);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(85, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 21);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstQueryItems
            // 
            this.lstQueryItems.FormattingEnabled = true;
            this.lstQueryItems.Location = new System.Drawing.Point(85, 106);
            this.lstQueryItems.Name = "lstQueryItems";
            this.lstQueryItems.Size = new System.Drawing.Size(160, 82);
            this.lstQueryItems.TabIndex = 11;
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Location = new System.Drawing.Point(17, 74);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(65, 13);
            this.lblExport.TabIndex = 10;
            this.lblExport.Text = "Export Path:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(16, 48);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(66, 13);
            this.lblTarget.TabIndex = 9;
            this.lblTarget.Text = "Target Path:";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(249, 70);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 20);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Browse";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnTarget
            // 
            this.btnTarget.Location = new System.Drawing.Point(250, 44);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(75, 20);
            this.btnTarget.TabIndex = 8;
            this.btnTarget.Text = "Browse";
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // txtExportPath
            // 
            this.txtExportPath.Location = new System.Drawing.Point(85, 70);
            this.txtExportPath.Name = "txtExportPath";
            this.txtExportPath.Size = new System.Drawing.Size(160, 20);
            this.txtExportPath.TabIndex = 5;
            // 
            // txtFolderInput
            // 
            this.txtFolderInput.Location = new System.Drawing.Point(85, 44);
            this.txtFolderInput.Name = "txtFolderInput";
            this.txtFolderInput.Size = new System.Drawing.Size(160, 20);
            this.txtFolderInput.TabIndex = 6;
            this.txtFolderInput.Text = "C:\\Users\\Jesse\\Documents\\Archieve";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(171, 268);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(96, 23);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(77, 268);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmQuerySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 305);
            this.ControlBox = false;
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpboxSearch);
            this.Name = "frmQuerySettings";
            this.Text = "Query_Settings";
            this.Load += new System.EventHandler(this.frmQuerySettings_Load);
            this.grpboxSearch.ResumeLayout(false);
            this.grpboxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxSearch;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstQueryItems;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.TextBox txtExportPath;
        private System.Windows.Forms.TextBox txtFolderInput;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FolderBrowserDialog fbdDirectory;
    }
}