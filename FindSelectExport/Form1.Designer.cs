﻿namespace FindSelectExport
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
            this.tbqueries = new System.Windows.Forms.TabPage();
            this.Exit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.tbcfse = new System.Windows.Forms.TabControl();
            this.fbdDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.tbSearch = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbqueries.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbcfse.SuspendLayout();
            this.tbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbqueries
            // 
            this.tbqueries.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbqueries.Controls.Add(this.Exit);
            this.tbqueries.Controls.Add(this.btnSearch);
            this.tbqueries.Controls.Add(this.groupBox1);
            this.tbqueries.Location = new System.Drawing.Point(4, 22);
            this.tbqueries.Name = "tbqueries";
            this.tbqueries.Padding = new System.Windows.Forms.Padding(3);
            this.tbqueries.Size = new System.Drawing.Size(352, 311);
            this.tbqueries.TabIndex = 0;
            this.tbqueries.Text = "Queries";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(170, 267);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(96, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(76, 267);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchItem);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lstQueryItems);
            this.groupBox1.Controls.Add(this.lblExport);
            this.groupBox1.Controls.Add(this.lblTarget);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnTarget);
            this.groupBox1.Controls.Add(this.txtExportPath);
            this.groupBox1.Controls.Add(this.txtFolderInput);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Properties";
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
            // 
            // tbcfse
            // 
            this.tbcfse.Controls.Add(this.tbqueries);
            this.tbcfse.Controls.Add(this.tbSearch);
            this.tbcfse.Location = new System.Drawing.Point(12, 12);
            this.tbcfse.Name = "tbcfse";
            this.tbcfse.SelectedIndex = 0;
            this.tbcfse.Size = new System.Drawing.Size(360, 337);
            this.tbcfse.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Controls.Add(this.flowLayoutPanel1);
            this.tbSearch.Location = new System.Drawing.Point(4, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbSearch.Size = new System.Drawing.Size(352, 311);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.Text = "Search";
            this.tbSearch.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(352, 314);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // frmFSE
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcfse);
            this.Name = "frmFSE";
            this.Text = "FSE";
            this.tbqueries.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbcfse.ResumeLayout(false);
            this.tbSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbqueries;
        private System.Windows.Forms.TabControl tbcfse;
        private System.Windows.Forms.FolderBrowserDialog fbdDirectory;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstQueryItems;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.TextBox txtExportPath;
        private System.Windows.Forms.TextBox txtFolderInput;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.TabPage tbSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;


    }
}

