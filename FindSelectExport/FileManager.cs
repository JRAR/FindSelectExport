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
    public static class SOExtension
    {
        //This class will assist with consolidating or "flattining" all the data in a Treeview node for
        //easy data access.
        public static IEnumerable<TreeNode> FlattenTree(this TreeView tv)
        {
            return FlattenTree(tv.Nodes);
        }

        public static IEnumerable<TreeNode> FlattenTree(this TreeNodeCollection coll)
        {
            return coll.Cast<TreeNode>()
                        .Concat(coll.Cast<TreeNode>()
                                    .SelectMany(x => FlattenTree(x.Nodes)));
        }
    }

    public static class FileManager

    /// <summary>
    /// Programmer: Jesse T Hemphill
    /// Date: 6/9/2016
    /// This static class will assist with the main FileSelectExport mainframe, and will assist with the functionality
    /// </summary>

    {

        struct FilePath
        {
            public String file;
            public List<String> paths; //Contains all the paths of the common file
            public List<String> distictFiles;
        }


        /// <summary>
        /// GetTreeData is the heart of the static class. When invoked, it will calulate all files in 
        /// a neatly nested Node tree.
        /// </summary>
        /// <remarks>
        /// Add more details here.
        /// </remarks>
        public static TreeNode GetTreeData(string initTargetPath, string keyword)
        {
            List<String> rawFilePaths = new List<string>();
            List<String> distictFiles = new List<string>();

            rawFilePaths = new List<string>();
            //Get ALL the files in the requested folder.
            rawFilePaths = Directory.GetFiles(initTargetPath, keyword, SearchOption.AllDirectories).ToList();
            //Consolidate all the query files so they only occur once in the list
            distictFiles = rawFilePaths.Select(i => Path.GetFileName(i)).Distinct().ToList();

            return createTree(rawFilePaths, distictFiles, keyword);
        }

        public static void MoveFile(string filePath, string destination, bool deleteOldLocation)
        {
            String moo;
            try
            {
                if (deleteOldLocation)
                {
                    File.Move(filePath, String.Format("{0}\\{1}", destination, Path.GetFileName(filePath)));
                }
                else
                {
                    moo = String.Format("{0}\\{1}", destination, Path.GetFileName(filePath));
                    File.Copy(filePath, String.Format("{0}\\{1}", destination, Path.GetFileName(filePath)));
                }

            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("This application does not have permission to Move/Copy file"
                                 , String.Format("Error - Unauthorized file Access"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static TreeNode createTree(List<String> rawFileList, List<String> distictFileList, String keyword)
        {
            List<FilePath> results = new List<FilePath>();
            TreeNode tNode = new TreeNode();

            //Main parent tree string format, the search query followed by the numeric results
            tNode.Text = (String.Format("Query '{0}' ({1} Result(s))", keyword, distictFileList.Count()));
            int fileIndex = 0;

            //Phase 1 - link all the files with paths
            foreach (String item in distictFileList)
            {
                FilePath targetFile = new FilePath();
                targetFile.file = item;
                //Consolidate all the query files so they only occur once in the list
                targetFile.distictFiles = rawFileList.Where(stringToCheck => Path.GetFileName(stringToCheck).Equals(item)).ToList();
                results.Add(targetFile);
            }

            //Phase 2 - build all treeview nodes
            foreach (FilePath result in results)
            {
                //Add the individual file to the search query
                tNode.Nodes.Add(String.Format("{0} - ({1})", result.file, result.distictFiles.Count()));

                foreach (String path in result.distictFiles)
                {
                    //Add all the possible paths for this one file
                    tNode.Nodes[fileIndex].Nodes.Add(path);

                }
                fileIndex += 1; // Index for each file to iterate through
            }
            return tNode;
        }

    }
}

