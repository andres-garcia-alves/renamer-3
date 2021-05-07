using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Renamer.Front.Helpers
{
    internal class TreeNodeHelper
    {
        public static TreeNode BuildItem(string path)
        {
            var treeNode = new TreeNode
            {
                Name = path,
                Text = path,
                ImageIndex = Constants.IMG_INDEX_CLOSE_DIR,
                SelectedImageIndex = Constants.IMG_INDEX_OPEN_DIR
            };

            return treeNode;
        }

        /// <summary>
        /// Returns a List<TreeNode> with the unit drives at root of MiComputer.
        /// </summary>
        public static List<TreeNode> GetItemsAtRoot()
        {
            var treeNodes = new List<TreeNode>();
            var drivesInfo = DriveInfo.GetDrives();

            foreach (var driveInfo in drivesInfo)
            {
                if ((driveInfo.DriveType == DriveType.Fixed || driveInfo.DriveType == DriveType.Network ||
                    driveInfo.DriveType == DriveType.Ram || driveInfo.DriveType == DriveType.Removable) && driveInfo.IsReady)
                {
                    var treeNode = new TreeNode()
                    {
                        Name = driveInfo.Name,
                        Text = driveInfo.Name,
                        ImageIndex = Constants.IMG_INDEX_DRIVE
                    };

                    try {
                        if (driveInfo.RootDirectory.GetDirectories().Length > 0)
                            treeNode.Nodes.Add(key: Constants.TEMP_KEY, text: string.Empty);
                    } catch { }

                    treeNodes.Add(treeNode);
                }
            }

            return treeNodes;
        }

        /// <summary>
        /// Returns a List<TreeNode> with the sub-directories of received path.
        /// </summary>
        public static List<TreeNode> GetItemsAtPath(string path)
        {
            var treeNodes = new List<TreeNode>();
            var directoriesInfo = new DirectoryInfo[0];

            try {
                directoriesInfo = new DirectoryInfo(path).GetDirectories();
            } catch { }

            foreach (var dirInfo in directoriesInfo)
            {
                var treeNode = new TreeNode
                {
                    Name = Path.Combine(path, dirInfo.Name),
                    Text = dirInfo.Name,
                    ImageIndex = Constants.IMG_INDEX_CLOSE_DIR,
                    SelectedImageIndex = Constants.IMG_INDEX_OPEN_DIR
                };

                try {
                    if (dirInfo.GetDirectories().Length > 0)
                        treeNode.Nodes.Add(key: Constants.TEMP_KEY, text: string.Empty);
                } catch { }

                treeNodes.Add(treeNode);
            }

            return treeNodes;
        }
    }
}
