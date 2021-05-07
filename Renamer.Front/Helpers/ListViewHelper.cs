using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using Renamer.Engine;
using Renamer.Front.Comparers;

namespace Renamer.Front.Helpers
{
    internal class ListViewHelper
    {
        /// <summary>
        /// Returns a sorted List<ListViewItem> with the files of received path.
        /// </summary>
        public static List<ListViewItem> GetItemsAtPath(string path, Enums.SortColumn column, Enums.SortType type)
        {
            var listViewItems = new List<ListViewItem>();
            var filesInfo = new FileInfo[0];

            try
            {
                filesInfo = new DirectoryInfo(path).GetFiles();
            }
            catch { }

            foreach (var fileInfo in filesInfo)
            {
                var listViewItem = new ListViewItem
                {
                    Text = fileInfo.Name,
                    ImageIndex = Constants.IMG_INDEX_FILE
                };
                listViewItem.SubItems.Add(Math.Ceiling((double)fileInfo.Length / 1024).ToString() + " KB");

                listViewItems.Add(listViewItem);
            }

            // custom sort
            listViewItems.Sort(new ColumnComparer(column, type));

            return listViewItems;
        }

        public static IEnumerable<ListViewItem> GetCollectionItems(ListView.ListViewItemCollection listViewItemCollection)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();

            // build the new list
            foreach (ListViewItem listViewItem in listViewItemCollection)
                listViewItems.Add(listViewItem);

            // custom sorting
            listViewItems.Sort(new ObjectTypeComparer());

            return listViewItems;
        }

        public static void AddItem(ListView listView, ObjectType type, string itemName, string newName = null)
        {
            // return if item allready exist
            if (listView.Items.IndexOfKey(itemName) != -1) { return; }

            ListViewItem listViewItem = new ListViewItem { Name = itemName, Text = itemName };
            listViewItem.SubItems.Add(newName);

            if (type == ObjectType.File)
            {
                listViewItem.Group = listView.Groups["lstViewGroupFiles"];
                listViewItem.ImageIndex = Constants.IMG_INDEX_FILE;
                listViewItem.Tag = ObjectType.File;
            }
            else if (type == ObjectType.Directory)
            {
                listViewItem.Group = listView.Groups["lstViewGroupDirectories"];
                listViewItem.ImageIndex = Constants.IMG_INDEX_CLOSE_DIR;
                listViewItem.Tag = ObjectType.Directory;
            }

            listView.Items.Add(listViewItem); // add at last position
        }
    }
}
