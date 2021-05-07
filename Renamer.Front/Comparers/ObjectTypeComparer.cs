using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using Renamer.Engine;

namespace Renamer.Front.Comparers
{
    internal sealed class ObjectTypeComparer : IComparer<ListViewItem>
    {
        ObjectType objectTypeOne, objectTypeTwo;

        int IComparer<ListViewItem>.Compare(ListViewItem itemOne, ListViewItem itemTwo)
        {
            objectTypeOne = (ObjectType)itemOne.Tag;
            objectTypeTwo = (ObjectType)itemTwo.Tag;

            if (objectTypeOne == ObjectType.File && objectTypeTwo == Renamer.Engine.ObjectType.File)
                return String.Compare(itemOne.Text, itemTwo.Text);

            else if (objectTypeOne == ObjectType.File && objectTypeTwo == Renamer.Engine.ObjectType.Directory)
                return -1;

            else if (objectTypeOne == Renamer.Engine.ObjectType.Directory && objectTypeTwo == Renamer.Engine.ObjectType.File)
                return 1;

            // more specific directory have precedence above less specific directory
            else if (objectTypeOne == Renamer.Engine.ObjectType.Directory && objectTypeTwo == Renamer.Engine.ObjectType.Directory)
                return CountDirectoryLevelsFromRoot(itemTwo.Text) - CountDirectoryLevelsFromRoot(itemOne.Text);

            else
                return 0;
        }

        private int CountDirectoryLevelsFromRoot(string fullPath)
        {
            string[] directories = fullPath.Replace(Path.GetPathRoot(fullPath), "").Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
            return directories.Length;
        }
    }
}
