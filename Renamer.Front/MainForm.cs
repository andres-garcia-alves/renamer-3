using System.Text;

using Renamer.Engine;
using Renamer.Engine.Entities;
using Renamer.Front.Helpers;

namespace Renamer.Front
{
    public partial class MainForm : Form
    {
        private string fullPath = String.Empty;
        private Enums.SortType sortType = Enums.SortType.Ascending;
        private Enums.SortColumn sortColumn = Enums.SortColumn.FirstColumn;

        private readonly StringBuilder sbActivityLogs = new();
        private List<NamingResult> namingResults = new();

        public MainForm()
        {
            InitializeComponent();

            this.Text = "Renamer v" + Application.ProductVersion;
            this.LoadDrives();
        }

        #region MenuButtons events

        private async void menuBtnRename_Click(object sender, EventArgs e)
        {
            try
            {
                this.menuBtnRename.Enabled = false;
                this.toolStripProgressBar.Value = 0;
                this.toolStripProgressBar.Visible = true;

                // start the renaming process
                await this.RenameWorkAsync();

                this.menuBtnUndo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.menuBtnRename.Enabled = true;
                this.toolStripProgressBar.Visible = false;
                this.txtActivityLogs.Text = this.sbActivityLogs.ToString();
            }
        }

        private async void menuBtnUndo_Click(object sender, EventArgs e)
        {
            try
            {
                this.menuBtnRename.Enabled = false;
                this.menuBtnUndo.Enabled = false;
                this.toolStripProgressBar.Value = 100;
                this.toolStripProgressBar.Visible = true;

                // start the undo process
                await this.UndoWorkAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.menuBtnRename.Enabled = true;
                this.toolStripProgressBar.Visible = false;
                this.txtActivityLogs.Text = this.sbActivityLogs.ToString();
            }
        }

        private void menuBtnQuickAccess_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == null) { return; }
            Cursor = Cursors.WaitCursor;

            // retrieve full path of selected quick-access folder
            if (e.ClickedItem.Name == nameof(this.toolStripMenuItemUserFolder))
                this.fullPath = DirectoryHelper.GetPath(Enums.QuickAccess.UserFolder);
            else if (e.ClickedItem.Name == nameof(this.toolStripMenuItemDesktop))
                this.fullPath = DirectoryHelper.GetPath(Enums.QuickAccess.Desktop);
            else if (e.ClickedItem.Name == nameof(this.toolStripMenuItemDocuments))
                this.fullPath = DirectoryHelper.GetPath(Enums.QuickAccess.Documents);
            else if (e.ClickedItem.Name == nameof(this.toolStripMenuItemDownloads))
                this.fullPath = DirectoryHelper.GetPath(Enums.QuickAccess.Downloads);
            else if (e.ClickedItem.Name == nameof(this.toolStripMenuItemMusic))
                this.fullPath = DirectoryHelper.GetPath(Enums.QuickAccess.Music);
            else if (e.ClickedItem.Name == nameof(this.toolStripMenuItemPictures))
                this.fullPath = DirectoryHelper.GetPath(Enums.QuickAccess.Pictures);
            else if (e.ClickedItem.Name == nameof(this.toolStripMenuItemVideos))
                this.fullPath = DirectoryHelper.GetPath(Enums.QuickAccess.Videos);

            // clear controls first
            this.treeViewFolderPick.Nodes.Clear();
            this.listViewFilePick.Items.Clear();
            this.listViewFilePick.Refresh();

            // load the quick-access folders & files structure
            this.LoadDrives();
            this.LoadDirectoriesTree(this.fullPath);
            this.LoadFiles(this.fullPath);

            this.statusStripLabelPath.Text = this.fullPath;

            Cursor = Cursors.Default;
        }

        private void menuBtnAbout_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        #endregion

        #region TreeView & ListView events

        private void treeViewFolderPick_BeforeExpand(object? sender, TreeViewCancelEventArgs e)
        {
            if (e.Node == null) { return; }
            this.fullPath = Path.GetFullPath(e.Node.FullPath);
            
            this.statusStripLabelPath.Text = this.fullPath;
            this.LoadSubDirectories(this.fullPath);
            this.LoadFiles(this.fullPath);
        }

        private void treeViewFolderPick_BeforeSelect(object? sender, TreeViewCancelEventArgs e)
        {
            if (e.Node == null) { return; }
            this.fullPath = Path.GetFullPath(e.Node.FullPath);

            this.statusStripLabelPath.Text = this.fullPath;
            this.LoadSubDirectories(this.fullPath);
            this.LoadFiles(this.fullPath);
        }

        private void listViewFilePick_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if ((int)this.sortColumn == e.Column)
            {
                this.sortType = (this.sortType == Enums.SortType.Ascending) ? Enums.SortType.Descending : Enums.SortType.Ascending;
            }
            else 
            {
                this.sortColumn = (Enums.SortColumn)e.Column;
                this.sortType = Enums.SortType.Ascending;
            }

            this.LoadFiles(this.fullPath, this.sortColumn, this.sortType);
        }

        #endregion

        #region ToolStrip sort events

        private void toolStripBtnTile_Click(object sender, EventArgs e)
        {
            this.listViewFilePick.View = View.Tile;
        }

        private void toolStripBtnLargeIcon_Click(object sender, EventArgs e)
        {
            this.listViewFilePick.View = View.LargeIcon;
        }

        private void toolStripBtnSmallIcon_Click(object sender, EventArgs e)
        {
            this.listViewFilePick.View = View.SmallIcon;
        }

        private void toolStripBtnList_Click(object sender, EventArgs e)
        {
            this.listViewFilePick.View = View.List;
        }

        private void toolStripBtnDetails_Click(object sender, EventArgs e)
        {
            this.listViewFilePick.View = View.Details;
        }

        #endregion

        #region Add/Remove items events

        private void btnAddSingle_Click(object sender, EventArgs e)
        {
            if (this.listViewFilePick.SelectedItems.Count > 0) // selected files
                foreach (ListViewItem item in this.listViewFilePick.SelectedItems)
                    ListViewHelper.AddItem(this.listViewSelectedItems, ObjectType.File, Path.Combine(this.fullPath, item.Text));
            else // selected directory
                if (this.fullPath != Path.GetPathRoot(this.fullPath))
                ListViewHelper.AddItem(this.listViewSelectedItems, ObjectType.Directory, this.fullPath);
        }

        private void btnAddMany_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.listViewFilePick.Items)
                ListViewHelper.AddItem(this.listViewSelectedItems, ObjectType.File, Path.Combine(this.fullPath, item.Text));
        }

        private void btnAddTree_Click(object sender, EventArgs e)
        {
            if (this.treeViewFolderPick.SelectedNode == null) { return; }

            var dirInfo = new DirectoryInfo(this.fullPath);
            FileInfo[] filesInfo = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);

            foreach (var fileInfo in filesInfo)
                ListViewHelper.AddItem(this.listViewSelectedItems, ObjectType.File, fileInfo.FullName);
        }

        private void btnRemoveSingle_Click(object sender, EventArgs e)
        {
            for (int i = this.listViewSelectedItems.SelectedItems.Count; i > 0; i--)
                this.listViewSelectedItems.Items.Remove(this.listViewSelectedItems.SelectedItems[i - 1]);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            this.listViewSelectedItems.Items.Clear();
        }

        private void listViewSelectedItems_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
                for (int i = this.listViewSelectedItems.SelectedItems.Count; i > 0; i--)
                    this.listViewSelectedItems.Items.Remove(this.listViewSelectedItems.SelectedItems[i - 1]);
        }

        #endregion

        #region RadioButtons events

        private void radBySimpleMatch_CheckedChanged(object sender, EventArgs e)
        {
            bool status = ((RadioButton)sender).Checked;
            this.txtMatchSearch.Enabled = status;
            this.txtMatchReplacement.Enabled = status;
        }

        private void radByPattern_CheckedChanged(object sender, EventArgs e)
        {
            bool status = ((RadioButton)sender).Checked;
            this.txtBeginnigText.Enabled = status;
            this.txtStartIndex.Enabled = status;
            this.txtIncrement.Enabled = status;
            this.txtNumericPad.Enabled = status;
        }

        private void radPositionalReplace_CheckedChanged(object sender, EventArgs e)
        {
            bool status = ((RadioButton)sender).Checked;
            this.txtPositionalReplaceIndex.Enabled = status;
            this.txtPositionalReplaceText.Enabled = status;
        }

        private void radPositionalAppend_CheckedChanged(object sender, EventArgs e)
        {
            bool status = ((RadioButton)sender).Checked;
            this.txtPositionalAppendIndex.Enabled = status;
            this.txtPositionalAppendText.Enabled = status;
        }

        #endregion

        #region Others events

        private void tabPagePreview_Enter(object sender, EventArgs e)
        {
            this.listViewPreview.Items.Clear();
            this.statusStripLabelPreview.Text = "";

            this.PreviewWork();
        }

        private void btnClearActivityLogs_Click(object sender, EventArgs e)
        {
            this.sbActivityLogs.Clear();
            this.txtActivityLogs.Text = this.sbActivityLogs.ToString();
        }

        #endregion

        #region Renamer.Engine generated events

        private void RenameEngine_NamingProcessed(object? sender, NamingProcessedEventArgs e)
        {
            try
            {
                // update menues & tabs
                this.toolStripProgressBar.Value = (e.Operation == Operation.Rename) ? e.Progress : 100 - e.Progress;

                if (e.NamingResult.Success)
                {
                    var listViewItem = this.listViewSelectedItems.Items.Find(e.NamingResult.OldName, false)[0];
                    listViewItem.Name = listViewItem.Text = e.NamingResult.NewName;
                }

                // logs
                var status = $"* { e.NamingResult.OldName.Truncate(120) }{ Environment.NewLine } --> { e.NamingResult.NewName.Truncate(120) }{ Environment.NewLine }{ Environment.NewLine }";

                this.sbActivityLogs.Append(status);
                LogHelper.LogInfo(status);

                Application.DoEvents();
            }
            catch (Exception) { throw; }
        }

        #endregion


        #region LoadDirectories & LoadFiles methods

        /// <summary>
        /// Load into TreeView the entire directory tree of received path.
        /// </summary>
        /// <param name="path">Path to load into the treeview</param>
        private void LoadDirectoriesTree(string path)
        {
            try
            {
                // suspend control's update event
                this.treeViewFolderPick.BeforeSelect -= treeViewFolderPick_BeforeSelect;
                this.treeViewFolderPick.BeforeExpand -= treeViewFolderPick_BeforeExpand;

                var pathSegments = path.Split('\\');

                var partialPath = $"{ pathSegments[0] }\\";
                this.LoadSubDirectories(partialPath);

                for (int i = 1; i < pathSegments.Length; i++)
                {
                    partialPath = Path.Combine(partialPath, pathSegments[i]);
                    this.LoadSubDirectories(partialPath);
                }

                // navigate to received path
                this.treeViewFolderPick.SelectedNode = this.treeViewFolderPick.Nodes.Find(path, true)[0];
                this.treeViewFolderPick.SelectedNode.Expand();
            }
            catch (Exception) { }
            finally
            {
                // resume control's update event
                this.treeViewFolderPick.BeforeSelect += treeViewFolderPick_BeforeSelect;
                this.treeViewFolderPick.BeforeExpand += treeViewFolderPick_BeforeExpand;
            }
        }

        /// <summary>
        /// Load into treeview the unit drives at root of MiComputer.
        /// </summary>
        private void LoadDrives()
        {
            try
            {
                // get childs of root node
                var treeNodes = TreeNodeHelper.GetItemsAtRoot();

                this.treeViewFolderPick.Nodes.Clear();
                this.treeViewFolderPick.Nodes.AddRange(treeNodes.ToArray());
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Load into treeview the sub-directories of received path.
        /// </summary>
        /// <param name="path">Path to load into the treeview</param>
        private void LoadSubDirectories(string path)
        {
            try
            {
                // get as childs of current path node
                var treeNodes = TreeNodeHelper.GetItemsAtPath(path);

                var currentNode = this.treeViewFolderPick.Nodes.Find(path, true)[0];
                currentNode.Nodes.Clear();
                currentNode.Nodes.AddRange(treeNodes.ToArray());
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Load into listview the files that belongs to the path received
        /// A empty path string means MiComputer (default location)
        /// </summary>
        /// <param name="path">Path to load into the listview</param>
        private void LoadFiles(string path)
        {
            try
            {
                LoadFiles(path, Enums.SortColumn.FirstColumn, Enums.SortType.Ascending);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Load into the ListView the files that belongs to the path received
        /// A empty path string means MiComputer (default location)
        /// </summary>
        /// <param name="path">Path to load into the listview</param>
        /// <param name="column">Sorting column of the items to load into the listview</param>
        /// <param name="type">Sort order of items to load into the listview</param>
        private void LoadFiles(string path, Enums.SortColumn column, Enums.SortType type)
        {
            try
            {
                this.lblFoundFiles.Visible = false;

                List<ListViewItem> listViewItems = ListViewHelper.GetItemsAtPath(path, column, type);

                // add list to ListView control
                this.listViewFilePick.Items.Clear();
                this.listViewFilePick.Items.AddRange(listViewItems.ToArray());

                this.lblFoundFiles.Text = listViewItems.Count.ToString() + " files found";
                this.lblFoundFiles.Visible = true;
            }
            catch (Exception) { }
        }

        #endregion

        #region Preview, Rename & Undo Process methods

        /// <summary>
        /// Previews changes on selected files according to the selected settings.
        /// </summary>
        private void PreviewWork()
        {
            try
            {
                // get NamingRequest items
                var listViewItems = ListViewHelper.GetCollectionItems(this.listViewSelectedItems.Items);
                var namingRequests = listViewItems.Select(a => new NamingRequest((ObjectType)a.Tag, a.Text)).ToList();

                // send the files/directories to calculate rename changes
                var renameSettings = this.BuildRenameSettings();
                var renameEngine = new RenameEngine(renameSettings);
                var namingResults = renameEngine.Preview(namingRequests);

                // refresh UI
                foreach (var namingResult in namingResults)
                    ListViewHelper.AddItem(this.listViewPreview, namingResult.ObjectType, namingResult.OldName, namingResult.NewName);
            }
            catch (Exception ex) { this.statusStripLabelPreview.Text = ex.Message; }
        }

        /// <summary>
        /// Renames the selected files according to the selected settings.
        /// </summary>
        private async Task RenameWorkAsync()
        {
            try
            {
                var renameSettings = this.BuildRenameSettings();

                var renameEngine = new RenameEngine(renameSettings, RenameEngine_NamingProcessed);

                LogHelper.LogHeader(renameSettings);

                // get NamingRequest items
                var listViewItems = ListViewHelper.GetCollectionItems(this.listViewSelectedItems.Items);
                var namingRequests = listViewItems.Select(a => new NamingRequest((ObjectType)a.Tag, a.Text)).ToList();

                // send the files/directories to rename, save results
                this.namingResults = await renameEngine.Rename(namingRequests);

                // refresh UI
                this.LoadFiles(this.fullPath);
            }
            catch (Exception ex)
            {
                LogHelper.LogException(ex); throw;
            }
            finally
            {
                await LogHelper.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Reverts a previous files renaming operation based on generated 'NamingResult'.
        /// </summary>
        private async Task UndoWorkAsync()
        {
            try
            {
                var renameSettings = new RenameSettings(RenameType.Unknown); // , new List<string>(), default

                var renameEngine = new RenameEngine(renameSettings, RenameEngine_NamingProcessed);

                LogHelper.LogHeader(renameSettings);

                // send the files/directories to undo rename
                this.namingResults = await renameEngine.Undo(this.namingResults);

                // refresh UI
                this.LoadFiles(this.fullPath);
            }
            catch (Exception ex)
            {
                LogHelper.LogException(ex); throw;
            }
            finally
            {
                await LogHelper.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Builds a RenameSettings object with the user selections
        /// </summary>
        private RenameSettings BuildRenameSettings()
        {
            if (this.radSentenceCase.Checked)
                return RenameSettingsFactory.SentenceCase(this.chkIncludeExtension.Checked);
            else if (this.radTitleCase.Checked)
                return RenameSettingsFactory.TitleCase(this.chkIncludeExtension.Checked);
            else if (this.radUpperCase.Checked)
                return RenameSettingsFactory.UpperCase(this.chkIncludeExtension.Checked);
            else if (this.radLowerCase.Checked)
                return RenameSettingsFactory.LowerCase(this.chkIncludeExtension.Checked);
            else if (this.radInvertedCase.Checked)
                return RenameSettingsFactory.InvertedCase(this.chkIncludeExtension.Checked);
            else if (this.radRemoveTildes.Checked)
                return RenameSettingsFactory.RemoveTildes(this.chkIncludeExtension.Checked);
            else if (this.radBySimpleMatch.Checked)
                return RenameSettingsFactory.BySimpleMatch(this.txtMatchSearch.Text, this.txtMatchReplacement.Text, this.chkIncludeExtension.Checked);
            else if (this.radByPattern.Checked)
                return RenameSettingsFactory.ByPattern(this.txtBeginnigText.Text, this.txtStartIndex.Text, this.txtIncrement.Text, this.txtNumericPad.Text, this.chkIncludeExtension.Checked);
            else if (this.radPositionalReplace.Checked)
                return RenameSettingsFactory.PositionalReplace(this.txtPositionalReplaceIndex.Text, this.txtPositionalReplaceText.Text, this.chkIncludeExtension.Checked);
            else if (this.radPositionalAppend.Checked)
                return RenameSettingsFactory.PositionalAppend(this.txtPositionalAppendIndex.Text, this.txtPositionalAppendText.Text, this.chkIncludeExtension.Checked);
            else
                return RenameSettingsFactory.Unknown();
        }

        #endregion
    }
}
