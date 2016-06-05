using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace FindSelectExport
{
    static class FileResults
    {
      static public  List<String> rawFilePaths;
      static public List<String> distictFiles;


            struct FilePath
            {
                public String file;
                public List<String> paths = new List<String>(); //Contains all the paths of the common file
                public List<String> distictFiles = new List<String>(); 
            }

            struct GridConfiguration
            {
                    public DataTable table = new DataTable("Test table");
                    public DataGridView dataGrid = new DataGridView();

                    public void generateValues()
                    {
                        dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGrid.RowHeadersVisible = false;
                        dataGrid.DataSource = table;

                        table.Columns.Add("PATH");
                        table.Columns.Add(new DataColumn("Action", typeof(bool)));
                    }


            }
            struct PanelConfiguration
            {
                public TableLayoutPanel panelResults = new TableLayoutPanel();
                public Label lblresults = new Label();
                

               public void generateValues()
                {
                    panelResults.Anchor = AnchorStyles.None;
                    panelResults.Dock = DockStyle.None;
                    panelResults.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                    panelResults.AutoSize = true;

                    lblresults.Anchor = AnchorStyles.None;
                    lblresults.BorderStyle = BorderStyle.Fixed3D;
                    lblresults.AutoSize = true;

                    panelResults.Controls.Add(lblresults, 0, 0);
                }


            }

        public Panel FileResults(string initTargetPath,string keyword)
        {
            rawFilePaths = new List<string>();

            List<String> files = new List<String>();
            rawFilePaths =  Directory.GetFiles(initTargetPath, keyword, SearchOption.AllDirectories).ToList();
            distictFiles = rawFilePaths.OrderBy(o => Path.GetFileName(o)).Distinct().ToList();
        }



        private Panel createGrid()
        {
            List<FilePath> results = new List<FilePath>();
            PanelConfiguration panel = new PanelConfiguration();
            int i = 0;
            panel.generateValues();


            foreach (String item in distictFiles)
            {
                FilePath targetFile = new FilePath();
                targetFile.file = item;
                targetFile.distictFiles = rawFilePaths.OrderBy(o => o.Contains(item)).ToList();
                results.Add(targetFile);
            }

            foreach (FilePath result in results)
            {
                foreach (String path in result.distictFiles)
                {
                    GridConfiguration grid = new GridConfiguration();
                    grid.generateValues();

                    grid.table.Rows.Add(path, i);
                    panel.panelResults.Controls.Add(grid.dataGrid);
                    i += 1;
                }
                
                i = 0;
                
            }
            return panel.panelResults;


        }


    }
}
