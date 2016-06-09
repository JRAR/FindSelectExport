using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Drawing;



namespace FindSelectExport
{

    public class DataPanel
    {
        public DataTable table;
        public DataGridView dataGrid;

        public DataPanel()
        {
            table = new DataTable("Data Table");
            dataGrid = new DataGridView();

            dataGrid.Dock = DockStyle.Fill;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.RowHeadersVisible = false;
            dataGrid.DataSource = table;

            table.Columns.Add("PATH");
            table.Columns.Add(new DataColumn("Export", typeof(bool)));
        }
    }

    public class PanelConfiguration
    {
        public TableLayoutPanel panelResults;
        public Label lblresults;


        public PanelConfiguration(string title)
        {
            panelResults = new TableLayoutPanel();
            lblresults = new Label();

            lblresults.Text = title;
            panelResults.Anchor = AnchorStyles.None;
            panelResults.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            panelResults.Size = new Size(400, 400);


            lblresults.Anchor = AnchorStyles.None;
            lblresults.BorderStyle = BorderStyle.Fixed3D;
            lblresults.AutoSize = true;

            panelResults.Controls.Add(lblresults, 0, 0);
        }


    }

    public static class FileResults
    {


        struct FilePath
        {
            public String file;
            public List<String> paths; //Contains all the paths of the common file
            public List<String> distictFiles;
        }

        public static TreeNode GetDataPanel(string initTargetPath, string keyword)
        {
            List<String> rawFilePaths = new List<string>();
            List<String> distictFiles = new List<string>();

            rawFilePaths = new List<string>();

            rawFilePaths = Directory.GetFiles(initTargetPath, keyword, SearchOption.AllDirectories).ToList();
            distictFiles = rawFilePaths.Select(i => Path.GetFileName(i)).Distinct().ToList(); // Get this working properly

            return createTree(rawFilePaths, distictFiles, keyword);
        }

        private static TreeNode createTree(List<String> rawFileList, List<String> distictFileList, String keyword)
        {
            List<FilePath> results = new List<FilePath>();
            PanelConfiguration panel = new PanelConfiguration(keyword);
            TreeNode tNode = new TreeNode();

            tNode.Text = (String.Format("Query '{0}' ({1} Result(s))", keyword, distictFileList.Count()));
            int fileIndex = 0;

            //Phase 1 - link all the files with paths
            foreach (String item in distictFileList)
            {
                FilePath targetFile = new FilePath();
                targetFile.file = item;
                targetFile.distictFiles = rawFileList.Where(stringToCheck => Path.GetFileName(stringToCheck).Equals(item)).ToList();
                results.Add(targetFile);
            }

            //Phase 2 - build all treeview nodes
            foreach (FilePath result in results)
            {
                tNode.Nodes.Add(String.Format("{0} - ({1})",result.file,result.distictFiles.Count()));
                
                foreach (String path in result.distictFiles)
                {
                    tNode.Nodes[fileIndex].Nodes.Add(path);
           
                }
                fileIndex += 1;
            }
            return tNode;

        }

    }
}

