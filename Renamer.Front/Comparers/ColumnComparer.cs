using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Renamer.Front.Comparers
{
    internal sealed class ColumnComparer : IComparer<ListViewItem>
    {
        private readonly Enums.SortColumn sortColumn;
        private readonly Enums.SortType sortType;

        public ColumnComparer(Enums.SortColumn sortColumn, Enums.SortType sortType)
        {
            this.sortColumn = sortColumn;
            this.sortType = sortType;
        }

        int IComparer<ListViewItem>.Compare(ListViewItem itemOne, ListViewItem itemTwo)
        {
            int x, y;

            if (this.sortColumn == Enums.SortColumn.FirstColumn && this.sortType == Enums.SortType.Ascending)
            {
                return String.Compare(itemOne.Text, itemTwo.Text);
            }
            else if (this.sortColumn == Enums.SortColumn.FirstColumn && this.sortType == Enums.SortType.Descending)
            {
                return String.Compare(itemTwo.Text, itemOne.Text);
            }
            else if (this.sortColumn == Enums.SortColumn.SecondColumn && this.sortType == Enums.SortType.Ascending)
            {
                x = Convert.ToInt32(itemOne.SubItems[1].Text.Replace(" KB", ""));
                y = Convert.ToInt32(itemTwo.SubItems[1].Text.Replace(" KB", ""));
                return x - y;
            }
            else if (this.sortColumn == Enums.SortColumn.SecondColumn && this.sortType == Enums.SortType.Descending)
            {
                x = Convert.ToInt32(itemOne.SubItems[1].Text.Replace(" KB", ""));
                y = Convert.ToInt32(itemTwo.SubItems[1].Text.Replace(" KB", ""));
                return y - x;
            }
            else
            {
                return 0;
            }
        }
    }
}
