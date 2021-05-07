namespace Renamer.Front
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Directories", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Files", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Directories", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Files", System.Windows.Forms.HorizontalAlignment.Left);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageFilesFolders = new System.Windows.Forms.TabPage();
            this.statusStripPath = new System.Windows.Forms.StatusStrip();
            this.statusStripLabelPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewSelectedItems = new System.Windows.Forms.ListView();
            this.columnFullPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgListObjectTypes = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxSelection = new System.Windows.Forms.GroupBox();
            this.lblFoundFiles = new System.Windows.Forms.Label();
            this.toolStripViews = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnTile = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLargeIcons = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSmallIcons = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnList = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDetails = new System.Windows.Forms.ToolStripButton();
            this.treeViewFolderPick = new System.Windows.Forms.TreeView();
            this.listViewFilePick = new System.Windows.Forms.ListView();
            this.headerFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemoveSingle = new System.Windows.Forms.Button();
            this.btnAddTree = new System.Windows.Forms.Button();
            this.btnAddMany = new System.Windows.Forms.Button();
            this.btnAddSingle = new System.Windows.Forms.Button();
            this.tabPageRenameSettings = new System.Windows.Forms.TabPage();
            this.lblRemoveTildesExample = new System.Windows.Forms.Label();
            this.radRemoveTildes = new System.Windows.Forms.RadioButton();
            this.radPositionalAppend = new System.Windows.Forms.RadioButton();
            this.txtPositionalAppendIndex = new System.Windows.Forms.TextBox();
            this.txtPositionalAppendText = new System.Windows.Forms.TextBox();
            this.lblPositionalAppend = new System.Windows.Forms.Label();
            this.lblPositionalAppendExample = new System.Windows.Forms.Label();
            this.chkIncludeExtension = new System.Windows.Forms.CheckBox();
            this.lblGeneralOptions = new System.Windows.Forms.Label();
            this.lblByPatternExample = new System.Windows.Forms.Label();
            this.txtNumericPad = new System.Windows.Forms.TextBox();
            this.lblNumericPad = new System.Windows.Forms.Label();
            this.txtIncrement = new System.Windows.Forms.TextBox();
            this.lblIncrement = new System.Windows.Forms.Label();
            this.lblStartIndex = new System.Windows.Forms.Label();
            this.txtStartIndex = new System.Windows.Forms.TextBox();
            this.txtBeginnigText = new System.Windows.Forms.TextBox();
            this.lblBeginnigText = new System.Windows.Forms.Label();
            this.radByPattern = new System.Windows.Forms.RadioButton();
            this.lblByPattern = new System.Windows.Forms.Label();
            this.lblByMatchExample = new System.Windows.Forms.Label();
            this.lblPositionalReplaceExample = new System.Windows.Forms.Label();
            this.lblPositionalReplace = new System.Windows.Forms.Label();
            this.txtPositionalReplaceText = new System.Windows.Forms.TextBox();
            this.txtPositionalReplaceIndex = new System.Windows.Forms.TextBox();
            this.radPositionalReplace = new System.Windows.Forms.RadioButton();
            this.lblByMatch = new System.Windows.Forms.Label();
            this.lblByPosition = new System.Windows.Forms.Label();
            this.lblChangeCase = new System.Windows.Forms.Label();
            this.radSentenceCase = new System.Windows.Forms.RadioButton();
            this.lblInvertedCaseExample = new System.Windows.Forms.Label();
            this.txtMatchReplacement = new System.Windows.Forms.TextBox();
            this.radTitleCase = new System.Windows.Forms.RadioButton();
            this.lblMatchReplacement = new System.Windows.Forms.Label();
            this.radUpperCase = new System.Windows.Forms.RadioButton();
            this.txtMatchSearch = new System.Windows.Forms.TextBox();
            this.lblLowerCaseExample = new System.Windows.Forms.Label();
            this.lblMatchSeach = new System.Windows.Forms.Label();
            this.radLowerCase = new System.Windows.Forms.RadioButton();
            this.radBySimpleMatch = new System.Windows.Forms.RadioButton();
            this.radInvertedCase = new System.Windows.Forms.RadioButton();
            this.lblUpperCaseExample = new System.Windows.Forms.Label();
            this.lblTitleCaseExample = new System.Windows.Forms.Label();
            this.lblSentenceCaseExample = new System.Windows.Forms.Label();
            this.tabPagePreview = new System.Windows.Forms.TabPage();
            this.statusStripPreview = new System.Windows.Forms.StatusStrip();
            this.statusStripLabelPreview = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewPreview = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNewName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageActivityLogs = new System.Windows.Forms.TabPage();
            this.btnClearActivityLogs = new System.Windows.Forms.Button();
            this.txtActivityLogs = new System.Windows.Forms.TextBox();
            this.imgListTabs = new System.Windows.Forms.ImageList(this.components);
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.menuBtnRename = new System.Windows.Forms.ToolStripButton();
            this.menuBtnUndo = new System.Windows.Forms.ToolStripButton();
            this.menuBtnQuickAccess = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItemUserFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemDesktop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDocuments = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDownloads = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPictures = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVideos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuBtnAbout = new System.Windows.Forms.ToolStripButton();
            this.tabMain.SuspendLayout();
            this.tabPageFilesFolders.SuspendLayout();
            this.statusStripPath.SuspendLayout();
            this.groupBoxSelection.SuspendLayout();
            this.toolStripViews.SuspendLayout();
            this.tabPageRenameSettings.SuspendLayout();
            this.tabPagePreview.SuspendLayout();
            this.statusStripPreview.SuspendLayout();
            this.tabPageActivityLogs.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabPageFilesFolders);
            this.tabMain.Controls.Add(this.tabPageRenameSettings);
            this.tabMain.Controls.Add(this.tabPagePreview);
            this.tabMain.Controls.Add(this.tabPageActivityLogs);
            this.tabMain.ImageList = this.imgListTabs;
            this.tabMain.ItemSize = new System.Drawing.Size(117, 24);
            this.tabMain.Location = new System.Drawing.Point(0, 38);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1086, 742);
            this.tabMain.TabIndex = 1;
            // 
            // tabPageFilesFolders
            // 
            this.tabPageFilesFolders.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPageFilesFolders.Controls.Add(this.statusStripPath);
            this.tabPageFilesFolders.Controls.Add(this.listViewSelectedItems);
            this.tabPageFilesFolders.Controls.Add(this.groupBoxSelection);
            this.tabPageFilesFolders.Controls.Add(this.btnRemoveAll);
            this.tabPageFilesFolders.Controls.Add(this.btnRemoveSingle);
            this.tabPageFilesFolders.Controls.Add(this.btnAddTree);
            this.tabPageFilesFolders.Controls.Add(this.btnAddMany);
            this.tabPageFilesFolders.Controls.Add(this.btnAddSingle);
            this.tabPageFilesFolders.ImageKey = "Tabs-FilesFolders.png";
            this.tabPageFilesFolders.Location = new System.Drawing.Point(4, 28);
            this.tabPageFilesFolders.Name = "tabPageFilesFolders";
            this.tabPageFilesFolders.Size = new System.Drawing.Size(1078, 710);
            this.tabPageFilesFolders.TabIndex = 0;
            this.tabPageFilesFolders.Text = "Files & Folders  ";
            // 
            // statusStripPath
            // 
            this.statusStripPath.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabelPath});
            this.statusStripPath.Location = new System.Drawing.Point(0, 688);
            this.statusStripPath.Name = "statusStripPath";
            this.statusStripPath.Size = new System.Drawing.Size(1078, 22);
            this.statusStripPath.SizingGrip = false;
            this.statusStripPath.TabIndex = 7;
            this.statusStripPath.Text = "statusStrip1";
            // 
            // statusStripLabelPath
            // 
            this.statusStripLabelPath.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripLabelPath.Name = "statusStripLabelPath";
            this.statusStripLabelPath.Size = new System.Drawing.Size(0, 17);
            // 
            // listViewSelectedItems
            // 
            this.listViewSelectedItems.AllowColumnReorder = true;
            this.listViewSelectedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSelectedItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFullPath});
            listViewGroup3.Header = "Directories";
            listViewGroup3.Name = "lstViewGroupDirectories";
            listViewGroup4.Header = "Files";
            listViewGroup4.Name = "lstViewGroupFiles";
            this.listViewSelectedItems.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.listViewSelectedItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSelectedItems.HideSelection = false;
            this.listViewSelectedItems.LargeImageList = this.imgListObjectTypes;
            this.listViewSelectedItems.Location = new System.Drawing.Point(559, 12);
            this.listViewSelectedItems.Name = "listViewSelectedItems";
            this.listViewSelectedItems.ShowItemToolTips = true;
            this.listViewSelectedItems.Size = new System.Drawing.Size(505, 660);
            this.listViewSelectedItems.SmallImageList = this.imgListObjectTypes;
            this.listViewSelectedItems.TabIndex = 9;
            this.listViewSelectedItems.TileSize = new System.Drawing.Size(184, 34);
            this.listViewSelectedItems.UseCompatibleStateImageBehavior = false;
            this.listViewSelectedItems.View = System.Windows.Forms.View.Details;
            this.listViewSelectedItems.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewSelectedItems_KeyUp);
            // 
            // columnFullPath
            // 
            this.columnFullPath.Tag = "Name";
            this.columnFullPath.Text = "Full Path";
            this.columnFullPath.Width = 480;
            // 
            // imgListObjectTypes
            // 
            this.imgListObjectTypes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListObjectTypes.ImageStream")));
            this.imgListObjectTypes.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListObjectTypes.Images.SetKeyName(0, "ObjectType-Drive.png");
            this.imgListObjectTypes.Images.SetKeyName(1, "ObjectType-CloseFolder.png");
            this.imgListObjectTypes.Images.SetKeyName(2, "ObjectType-OpenFolder.png");
            this.imgListObjectTypes.Images.SetKeyName(3, "ObjectType-Files.png");
            // 
            // groupBoxSelection
            // 
            this.groupBoxSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSelection.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxSelection.Controls.Add(this.lblFoundFiles);
            this.groupBoxSelection.Controls.Add(this.toolStripViews);
            this.groupBoxSelection.Controls.Add(this.treeViewFolderPick);
            this.groupBoxSelection.Controls.Add(this.listViewFilePick);
            this.groupBoxSelection.Location = new System.Drawing.Point(13, 12);
            this.groupBoxSelection.Name = "groupBoxSelection";
            this.groupBoxSelection.Size = new System.Drawing.Size(405, 660);
            this.groupBoxSelection.TabIndex = 3;
            this.groupBoxSelection.TabStop = false;
            this.groupBoxSelection.Text = "Path Selection";
            // 
            // lblFoundFiles
            // 
            this.lblFoundFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFoundFiles.Location = new System.Drawing.Point(207, 639);
            this.lblFoundFiles.Name = "lblFoundFiles";
            this.lblFoundFiles.Size = new System.Drawing.Size(180, 14);
            this.lblFoundFiles.TabIndex = 8;
            this.lblFoundFiles.Text = "files found";
            this.lblFoundFiles.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFoundFiles.Visible = false;
            // 
            // toolStripViews
            // 
            this.toolStripViews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripViews.AutoSize = false;
            this.toolStripViews.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripViews.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripViews.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripViews.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnTile,
            this.toolStripBtnLargeIcons,
            this.toolStripBtnSmallIcons,
            this.toolStripBtnList,
            this.toolStripBtnDetails});
            this.toolStripViews.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripViews.Location = new System.Drawing.Point(273, 288);
            this.toolStripViews.Name = "toolStripViews";
            this.toolStripViews.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripViews.Size = new System.Drawing.Size(121, 27);
            this.toolStripViews.TabIndex = 1;
            this.toolStripViews.Text = "toolStrip1";
            // 
            // toolStripBtnTile
            // 
            this.toolStripBtnTile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnTile.Image = global::Renamer.Front.Properties.Resources.View_Tile;
            this.toolStripBtnTile.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripBtnTile.Name = "toolStripBtnTile";
            this.toolStripBtnTile.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnTile.ToolTipText = "Tile";
            this.toolStripBtnTile.Click += new System.EventHandler(this.toolStripBtnTile_Click);
            // 
            // toolStripBtnLargeIcons
            // 
            this.toolStripBtnLargeIcons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnLargeIcons.Image = global::Renamer.Front.Properties.Resources.View_LargeIcons;
            this.toolStripBtnLargeIcons.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripBtnLargeIcons.Name = "toolStripBtnLargeIcons";
            this.toolStripBtnLargeIcons.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnLargeIcons.ToolTipText = "Large icons";
            this.toolStripBtnLargeIcons.Click += new System.EventHandler(this.toolStripBtnLargeIcon_Click);
            // 
            // toolStripBtnSmallIcons
            // 
            this.toolStripBtnSmallIcons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSmallIcons.Image = global::Renamer.Front.Properties.Resources.View_SmallIcons;
            this.toolStripBtnSmallIcons.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripBtnSmallIcons.Name = "toolStripBtnSmallIcons";
            this.toolStripBtnSmallIcons.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnSmallIcons.ToolTipText = "Small icons";
            this.toolStripBtnSmallIcons.Click += new System.EventHandler(this.toolStripBtnSmallIcon_Click);
            // 
            // toolStripBtnList
            // 
            this.toolStripBtnList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnList.Image")));
            this.toolStripBtnList.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripBtnList.Name = "toolStripBtnList";
            this.toolStripBtnList.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnList.ToolTipText = "List";
            this.toolStripBtnList.Click += new System.EventHandler(this.toolStripBtnList_Click);
            // 
            // toolStripBtnDetails
            // 
            this.toolStripBtnDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnDetails.Image = global::Renamer.Front.Properties.Resources.View_Details;
            this.toolStripBtnDetails.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripBtnDetails.Name = "toolStripBtnDetails";
            this.toolStripBtnDetails.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnDetails.ToolTipText = "Details";
            this.toolStripBtnDetails.Click += new System.EventHandler(this.toolStripBtnDetails_Click);
            // 
            // treeViewFolderPick
            // 
            this.treeViewFolderPick.HideSelection = false;
            this.treeViewFolderPick.ImageIndex = 0;
            this.treeViewFolderPick.ImageList = this.imgListObjectTypes;
            this.treeViewFolderPick.Location = new System.Drawing.Point(12, 21);
            this.treeViewFolderPick.Name = "treeViewFolderPick";
            this.treeViewFolderPick.SelectedImageIndex = 0;
            this.treeViewFolderPick.Size = new System.Drawing.Size(381, 258);
            this.treeViewFolderPick.TabIndex = 2;
            this.treeViewFolderPick.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewFolderPick_BeforeExpand);
            this.treeViewFolderPick.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewFolderPick_BeforeSelect);
            // 
            // listViewFilePick
            // 
            this.listViewFilePick.AllowColumnReorder = true;
            this.listViewFilePick.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerFileName,
            this.headerFileSize});
            this.listViewFilePick.HideSelection = false;
            this.listViewFilePick.LargeImageList = this.imgListObjectTypes;
            this.listViewFilePick.Location = new System.Drawing.Point(12, 316);
            this.listViewFilePick.Name = "listViewFilePick";
            this.listViewFilePick.ShowItemToolTips = true;
            this.listViewFilePick.Size = new System.Drawing.Size(381, 320);
            this.listViewFilePick.SmallImageList = this.imgListObjectTypes;
            this.listViewFilePick.TabIndex = 3;
            this.listViewFilePick.TileSize = new System.Drawing.Size(184, 34);
            this.listViewFilePick.UseCompatibleStateImageBehavior = false;
            this.listViewFilePick.View = System.Windows.Forms.View.Details;
            this.listViewFilePick.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewFilePick_ColumnClick);
            // 
            // headerFileName
            // 
            this.headerFileName.Tag = "Name";
            this.headerFileName.Text = "File Name";
            this.headerFileName.Width = 295;
            // 
            // headerFileSize
            // 
            this.headerFileSize.Text = "File Size (KB)";
            this.headerFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.headerFileSize.Width = 79;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemoveAll.Location = new System.Drawing.Point(438, 332);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(100, 25);
            this.btnRemoveAll.TabIndex = 8;
            this.btnRemoveAll.Text = "<< Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemoveSingle
            // 
            this.btnRemoveSingle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemoveSingle.Location = new System.Drawing.Point(438, 301);
            this.btnRemoveSingle.Name = "btnRemoveSingle";
            this.btnRemoveSingle.Size = new System.Drawing.Size(100, 25);
            this.btnRemoveSingle.TabIndex = 7;
            this.btnRemoveSingle.Text = "< Remove Single";
            this.btnRemoveSingle.UseVisualStyleBackColor = true;
            this.btnRemoveSingle.Click += new System.EventHandler(this.btnRemoveSingle_Click);
            // 
            // btnAddTree
            // 
            this.btnAddTree.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddTree.Location = new System.Drawing.Point(438, 252);
            this.btnAddTree.Name = "btnAddTree";
            this.btnAddTree.Size = new System.Drawing.Size(100, 25);
            this.btnAddTree.TabIndex = 6;
            this.btnAddTree.Text = "Add Tree >>>";
            this.btnAddTree.UseVisualStyleBackColor = true;
            this.btnAddTree.Click += new System.EventHandler(this.btnAddTree_Click);
            // 
            // btnAddMany
            // 
            this.btnAddMany.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddMany.Location = new System.Drawing.Point(438, 221);
            this.btnAddMany.Name = "btnAddMany";
            this.btnAddMany.Size = new System.Drawing.Size(100, 25);
            this.btnAddMany.TabIndex = 5;
            this.btnAddMany.Text = "Add Many >>";
            this.btnAddMany.UseVisualStyleBackColor = true;
            this.btnAddMany.Click += new System.EventHandler(this.btnAddMany_Click);
            // 
            // btnAddSingle
            // 
            this.btnAddSingle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddSingle.Location = new System.Drawing.Point(438, 190);
            this.btnAddSingle.Name = "btnAddSingle";
            this.btnAddSingle.Size = new System.Drawing.Size(100, 25);
            this.btnAddSingle.TabIndex = 4;
            this.btnAddSingle.Text = "Add Single >";
            this.btnAddSingle.UseVisualStyleBackColor = true;
            this.btnAddSingle.Click += new System.EventHandler(this.btnAddSingle_Click);
            // 
            // tabPageRenameSettings
            // 
            this.tabPageRenameSettings.AutoScroll = true;
            this.tabPageRenameSettings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPageRenameSettings.Controls.Add(this.lblRemoveTildesExample);
            this.tabPageRenameSettings.Controls.Add(this.radRemoveTildes);
            this.tabPageRenameSettings.Controls.Add(this.radPositionalAppend);
            this.tabPageRenameSettings.Controls.Add(this.txtPositionalAppendIndex);
            this.tabPageRenameSettings.Controls.Add(this.txtPositionalAppendText);
            this.tabPageRenameSettings.Controls.Add(this.lblPositionalAppend);
            this.tabPageRenameSettings.Controls.Add(this.lblPositionalAppendExample);
            this.tabPageRenameSettings.Controls.Add(this.chkIncludeExtension);
            this.tabPageRenameSettings.Controls.Add(this.lblGeneralOptions);
            this.tabPageRenameSettings.Controls.Add(this.lblByPatternExample);
            this.tabPageRenameSettings.Controls.Add(this.txtNumericPad);
            this.tabPageRenameSettings.Controls.Add(this.lblNumericPad);
            this.tabPageRenameSettings.Controls.Add(this.txtIncrement);
            this.tabPageRenameSettings.Controls.Add(this.lblIncrement);
            this.tabPageRenameSettings.Controls.Add(this.lblStartIndex);
            this.tabPageRenameSettings.Controls.Add(this.txtStartIndex);
            this.tabPageRenameSettings.Controls.Add(this.txtBeginnigText);
            this.tabPageRenameSettings.Controls.Add(this.lblBeginnigText);
            this.tabPageRenameSettings.Controls.Add(this.radByPattern);
            this.tabPageRenameSettings.Controls.Add(this.lblByPattern);
            this.tabPageRenameSettings.Controls.Add(this.lblByMatchExample);
            this.tabPageRenameSettings.Controls.Add(this.lblPositionalReplaceExample);
            this.tabPageRenameSettings.Controls.Add(this.lblPositionalReplace);
            this.tabPageRenameSettings.Controls.Add(this.txtPositionalReplaceText);
            this.tabPageRenameSettings.Controls.Add(this.txtPositionalReplaceIndex);
            this.tabPageRenameSettings.Controls.Add(this.radPositionalReplace);
            this.tabPageRenameSettings.Controls.Add(this.lblByMatch);
            this.tabPageRenameSettings.Controls.Add(this.lblByPosition);
            this.tabPageRenameSettings.Controls.Add(this.lblChangeCase);
            this.tabPageRenameSettings.Controls.Add(this.radSentenceCase);
            this.tabPageRenameSettings.Controls.Add(this.lblInvertedCaseExample);
            this.tabPageRenameSettings.Controls.Add(this.txtMatchReplacement);
            this.tabPageRenameSettings.Controls.Add(this.radTitleCase);
            this.tabPageRenameSettings.Controls.Add(this.lblMatchReplacement);
            this.tabPageRenameSettings.Controls.Add(this.radUpperCase);
            this.tabPageRenameSettings.Controls.Add(this.txtMatchSearch);
            this.tabPageRenameSettings.Controls.Add(this.lblLowerCaseExample);
            this.tabPageRenameSettings.Controls.Add(this.lblMatchSeach);
            this.tabPageRenameSettings.Controls.Add(this.radLowerCase);
            this.tabPageRenameSettings.Controls.Add(this.radBySimpleMatch);
            this.tabPageRenameSettings.Controls.Add(this.radInvertedCase);
            this.tabPageRenameSettings.Controls.Add(this.lblUpperCaseExample);
            this.tabPageRenameSettings.Controls.Add(this.lblTitleCaseExample);
            this.tabPageRenameSettings.Controls.Add(this.lblSentenceCaseExample);
            this.tabPageRenameSettings.ImageKey = "Tabs-RenameSettings.png";
            this.tabPageRenameSettings.Location = new System.Drawing.Point(4, 28);
            this.tabPageRenameSettings.Name = "tabPageRenameSettings";
            this.tabPageRenameSettings.Size = new System.Drawing.Size(1078, 710);
            this.tabPageRenameSettings.TabIndex = 1;
            this.tabPageRenameSettings.Text = "Rename Settings  ";
            // 
            // lblRemoveTildesExample
            // 
            this.lblRemoveTildesExample.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRemoveTildesExample.AutoSize = true;
            this.lblRemoveTildesExample.Location = new System.Drawing.Point(210, 271);
            this.lblRemoveTildesExample.Name = "lblRemoveTildesExample";
            this.lblRemoveTildesExample.Size = new System.Drawing.Size(126, 13);
            this.lblRemoveTildesExample.TabIndex = 17;
            this.lblRemoveTildesExample.Text = "Eg:  \'Áéíóu\'     -->  \'Aeiou\'";
            // 
            // radRemoveTildes
            // 
            this.radRemoveTildes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radRemoveTildes.AutoSize = true;
            this.radRemoveTildes.Location = new System.Drawing.Point(63, 271);
            this.radRemoveTildes.Name = "radRemoveTildes";
            this.radRemoveTildes.Size = new System.Drawing.Size(92, 17);
            this.radRemoveTildes.TabIndex = 16;
            this.radRemoveTildes.Text = "Remove tildes";
            this.radRemoveTildes.UseVisualStyleBackColor = true;
            // 
            // radPositionalAppend
            // 
            this.radPositionalAppend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radPositionalAppend.AutoSize = true;
            this.radPositionalAppend.Location = new System.Drawing.Point(65, 624);
            this.radPositionalAppend.Name = "radPositionalAppend";
            this.radPositionalAppend.Size = new System.Drawing.Size(74, 17);
            this.radPositionalAppend.TabIndex = 20;
            this.radPositionalAppend.Text = "At position";
            this.radPositionalAppend.UseVisualStyleBackColor = true;
            this.radPositionalAppend.CheckedChanged += new System.EventHandler(this.radPositionalAppend_CheckedChanged);
            // 
            // txtPositionalAppendIndex
            // 
            this.txtPositionalAppendIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPositionalAppendIndex.Enabled = false;
            this.txtPositionalAppendIndex.Location = new System.Drawing.Point(154, 627);
            this.txtPositionalAppendIndex.MaxLength = 3;
            this.txtPositionalAppendIndex.Name = "txtPositionalAppendIndex";
            this.txtPositionalAppendIndex.Size = new System.Drawing.Size(59, 20);
            this.txtPositionalAppendIndex.TabIndex = 29;
            this.txtPositionalAppendIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPositionalAppendText
            // 
            this.txtPositionalAppendText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPositionalAppendText.Enabled = false;
            this.txtPositionalAppendText.Location = new System.Drawing.Point(391, 630);
            this.txtPositionalAppendText.MaxLength = 128;
            this.txtPositionalAppendText.Name = "txtPositionalAppendText";
            this.txtPositionalAppendText.Size = new System.Drawing.Size(118, 20);
            this.txtPositionalAppendText.TabIndex = 30;
            // 
            // lblPositionalAppend
            // 
            this.lblPositionalAppend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPositionalAppend.AutoSize = true;
            this.lblPositionalAppend.Location = new System.Drawing.Point(293, 627);
            this.lblPositionalAppend.Name = "lblPositionalAppend";
            this.lblPositionalAppend.Size = new System.Drawing.Size(67, 13);
            this.lblPositionalAppend.TabIndex = 0;
            this.lblPositionalAppend.Text = "Text append";
            // 
            // lblPositionalAppendExample
            // 
            this.lblPositionalAppendExample.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPositionalAppendExample.AutoSize = true;
            this.lblPositionalAppendExample.Location = new System.Drawing.Point(569, 627);
            this.lblPositionalAppendExample.Name = "lblPositionalAppendExample";
            this.lblPositionalAppendExample.Size = new System.Drawing.Size(196, 13);
            this.lblPositionalAppendExample.TabIndex = 2;
            this.lblPositionalAppendExample.Text = "Eg: pos 3 = \'Z\':  \'abc def\'  -->  \'AbZc def\'";
            // 
            // chkIncludeExtension
            // 
            this.chkIncludeExtension.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkIncludeExtension.AutoSize = true;
            this.chkIncludeExtension.Location = new System.Drawing.Point(63, 73);
            this.chkIncludeExtension.Name = "chkIncludeExtension";
            this.chkIncludeExtension.Size = new System.Drawing.Size(179, 17);
            this.chkIncludeExtension.TabIndex = 10;
            this.chkIncludeExtension.Text = "Include file extension. Eg: (.mp3)";
            this.chkIncludeExtension.UseVisualStyleBackColor = true;
            // 
            // lblGeneralOptions
            // 
            this.lblGeneralOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGeneralOptions.AutoSize = true;
            this.lblGeneralOptions.Location = new System.Drawing.Point(51, 36);
            this.lblGeneralOptions.Name = "lblGeneralOptions";
            this.lblGeneralOptions.Size = new System.Drawing.Size(83, 13);
            this.lblGeneralOptions.TabIndex = 3;
            this.lblGeneralOptions.Text = "General Options";
            // 
            // lblByPatternExample
            // 
            this.lblByPatternExample.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblByPatternExample.AutoSize = true;
            this.lblByPatternExample.Location = new System.Drawing.Point(116, 528);
            this.lblByPatternExample.Name = "lblByPatternExample";
            this.lblByPatternExample.Size = new System.Drawing.Size(552, 13);
            this.lblByPatternExample.TabIndex = 2;
            this.lblByPatternExample.Text = "Eg: beginnig with text = \'Photo \', Start = \'1\', Increment = \'2\', Pad = \'4\'  -->  " +
    "\'Photo 0001\', \'Photo 0003\', \'Photo 0005\' ...";
            // 
            // txtNumericPad
            // 
            this.txtNumericPad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumericPad.Enabled = false;
            this.txtNumericPad.Location = new System.Drawing.Point(701, 496);
            this.txtNumericPad.MaxLength = 2;
            this.txtNumericPad.Name = "txtNumericPad";
            this.txtNumericPad.Size = new System.Drawing.Size(59, 20);
            this.txtNumericPad.TabIndex = 26;
            this.txtNumericPad.Text = "1";
            this.txtNumericPad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNumericPad
            // 
            this.lblNumericPad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumericPad.AutoSize = true;
            this.lblNumericPad.Location = new System.Drawing.Point(620, 496);
            this.lblNumericPad.Name = "lblNumericPad";
            this.lblNumericPad.Size = new System.Drawing.Size(67, 13);
            this.lblNumericPad.TabIndex = 6;
            this.lblNumericPad.Text = "Numeric pad";
            // 
            // txtIncrement
            // 
            this.txtIncrement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIncrement.Enabled = false;
            this.txtIncrement.Location = new System.Drawing.Point(534, 496);
            this.txtIncrement.MaxLength = 3;
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(59, 20);
            this.txtIncrement.TabIndex = 25;
            this.txtIncrement.Text = "1";
            this.txtIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIncrement
            // 
            this.lblIncrement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIncrement.AutoSize = true;
            this.lblIncrement.Location = new System.Drawing.Point(471, 496);
            this.lblIncrement.Name = "lblIncrement";
            this.lblIncrement.Size = new System.Drawing.Size(54, 13);
            this.lblIncrement.TabIndex = 6;
            this.lblIncrement.Text = "Increment";
            // 
            // lblStartIndex
            // 
            this.lblStartIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStartIndex.AutoSize = true;
            this.lblStartIndex.Location = new System.Drawing.Point(326, 496);
            this.lblStartIndex.Name = "lblStartIndex";
            this.lblStartIndex.Size = new System.Drawing.Size(57, 13);
            this.lblStartIndex.TabIndex = 6;
            this.lblStartIndex.Text = "Start index";
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStartIndex.Enabled = false;
            this.txtStartIndex.Location = new System.Drawing.Point(392, 496);
            this.txtStartIndex.MaxLength = 10;
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(59, 20);
            this.txtStartIndex.TabIndex = 24;
            this.txtStartIndex.Text = "1";
            this.txtStartIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBeginnigText
            // 
            this.txtBeginnigText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBeginnigText.Enabled = false;
            this.txtBeginnigText.Location = new System.Drawing.Point(187, 496);
            this.txtBeginnigText.MaxLength = 128;
            this.txtBeginnigText.Name = "txtBeginnigText";
            this.txtBeginnigText.Size = new System.Drawing.Size(118, 20);
            this.txtBeginnigText.TabIndex = 23;
            // 
            // lblBeginnigText
            // 
            this.lblBeginnigText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBeginnigText.AutoSize = true;
            this.lblBeginnigText.Location = new System.Drawing.Point(88, 493);
            this.lblBeginnigText.Name = "lblBeginnigText";
            this.lblBeginnigText.Size = new System.Drawing.Size(90, 13);
            this.lblBeginnigText.TabIndex = 6;
            this.lblBeginnigText.Text = "Beginnig with text";
            // 
            // radByPattern
            // 
            this.radByPattern.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radByPattern.AutoSize = true;
            this.radByPattern.Location = new System.Drawing.Point(63, 461);
            this.radByPattern.Name = "radByPattern";
            this.radByPattern.Size = new System.Drawing.Size(93, 17);
            this.radByPattern.TabIndex = 18;
            this.radByPattern.Text = "Simple Pattern";
            this.radByPattern.UseVisualStyleBackColor = true;
            this.radByPattern.CheckedChanged += new System.EventHandler(this.radByPattern_CheckedChanged);
            // 
            // lblByPattern
            // 
            this.lblByPattern.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblByPattern.AutoSize = true;
            this.lblByPattern.Location = new System.Drawing.Point(51, 429);
            this.lblByPattern.Name = "lblByPattern";
            this.lblByPattern.Size = new System.Drawing.Size(56, 13);
            this.lblByPattern.TabIndex = 3;
            this.lblByPattern.Text = "By Pattern";
            // 
            // lblByMatchExample
            // 
            this.lblByMatchExample.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblByMatchExample.AutoSize = true;
            this.lblByMatchExample.Location = new System.Drawing.Point(567, 382);
            this.lblByMatchExample.Name = "lblByMatchExample";
            this.lblByMatchExample.Size = new System.Drawing.Size(269, 13);
            this.lblByMatchExample.TabIndex = 2;
            this.lblByMatchExample.Text = "Eg: match = \'def\', replace = \'YZ\':  \'abc def\'  -->  \'abc YZ\'";
            // 
            // lblPositionalReplaceExample
            // 
            this.lblPositionalReplaceExample.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPositionalReplaceExample.AutoSize = true;
            this.lblPositionalReplaceExample.Location = new System.Drawing.Point(569, 604);
            this.lblPositionalReplaceExample.Name = "lblPositionalReplaceExample";
            this.lblPositionalReplaceExample.Size = new System.Drawing.Size(190, 13);
            this.lblPositionalReplaceExample.TabIndex = 2;
            this.lblPositionalReplaceExample.Text = "Eg: pos 3 = \'Z\':  \'abc def\'  -->  \'AbZ def\'";
            // 
            // lblPositionalReplace
            // 
            this.lblPositionalReplace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPositionalReplace.AutoSize = true;
            this.lblPositionalReplace.Location = new System.Drawing.Point(293, 604);
            this.lblPositionalReplace.Name = "lblPositionalReplace";
            this.lblPositionalReplace.Size = new System.Drawing.Size(89, 13);
            this.lblPositionalReplace.TabIndex = 0;
            this.lblPositionalReplace.Text = "Text replacement";
            // 
            // txtPositionalReplaceText
            // 
            this.txtPositionalReplaceText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPositionalReplaceText.Enabled = false;
            this.txtPositionalReplaceText.Location = new System.Drawing.Point(391, 607);
            this.txtPositionalReplaceText.MaxLength = 128;
            this.txtPositionalReplaceText.Name = "txtPositionalReplaceText";
            this.txtPositionalReplaceText.Size = new System.Drawing.Size(118, 20);
            this.txtPositionalReplaceText.TabIndex = 28;
            // 
            // txtPositionalReplaceIndex
            // 
            this.txtPositionalReplaceIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPositionalReplaceIndex.Enabled = false;
            this.txtPositionalReplaceIndex.Location = new System.Drawing.Point(154, 604);
            this.txtPositionalReplaceIndex.MaxLength = 3;
            this.txtPositionalReplaceIndex.Name = "txtPositionalReplaceIndex";
            this.txtPositionalReplaceIndex.Size = new System.Drawing.Size(59, 20);
            this.txtPositionalReplaceIndex.TabIndex = 27;
            this.txtPositionalReplaceIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radPositionalReplace
            // 
            this.radPositionalReplace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radPositionalReplace.AutoSize = true;
            this.radPositionalReplace.Location = new System.Drawing.Point(65, 601);
            this.radPositionalReplace.Name = "radPositionalReplace";
            this.radPositionalReplace.Size = new System.Drawing.Size(74, 17);
            this.radPositionalReplace.TabIndex = 19;
            this.radPositionalReplace.Text = "At position";
            this.radPositionalReplace.UseVisualStyleBackColor = true;
            this.radPositionalReplace.CheckedChanged += new System.EventHandler(this.radPositionalReplace_CheckedChanged);
            // 
            // lblByMatch
            // 
            this.lblByMatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblByMatch.AutoSize = true;
            this.lblByMatch.Location = new System.Drawing.Point(49, 321);
            this.lblByMatch.Name = "lblByMatch";
            this.lblByMatch.Size = new System.Drawing.Size(52, 13);
            this.lblByMatch.TabIndex = 3;
            this.lblByMatch.Text = "By Match";
            // 
            // lblByPosition
            // 
            this.lblByPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblByPosition.AutoSize = true;
            this.lblByPosition.Location = new System.Drawing.Point(51, 568);
            this.lblByPosition.Name = "lblByPosition";
            this.lblByPosition.Size = new System.Drawing.Size(59, 13);
            this.lblByPosition.TabIndex = 3;
            this.lblByPosition.Text = "By Position";
            // 
            // lblChangeCase
            // 
            this.lblChangeCase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChangeCase.AutoSize = true;
            this.lblChangeCase.Location = new System.Drawing.Point(51, 126);
            this.lblChangeCase.Name = "lblChangeCase";
            this.lblChangeCase.Size = new System.Drawing.Size(71, 13);
            this.lblChangeCase.TabIndex = 3;
            this.lblChangeCase.Text = "Change Case";
            // 
            // radSentenceCase
            // 
            this.radSentenceCase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radSentenceCase.AutoSize = true;
            this.radSentenceCase.Location = new System.Drawing.Point(63, 156);
            this.radSentenceCase.Name = "radSentenceCase";
            this.radSentenceCase.Size = new System.Drawing.Size(97, 17);
            this.radSentenceCase.TabIndex = 11;
            this.radSentenceCase.Text = "Sentence case";
            this.radSentenceCase.UseVisualStyleBackColor = true;
            // 
            // lblInvertedCaseExample
            // 
            this.lblInvertedCaseExample.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvertedCaseExample.AutoSize = true;
            this.lblInvertedCaseExample.Location = new System.Drawing.Point(210, 248);
            this.lblInvertedCaseExample.Name = "lblInvertedCaseExample";
            this.lblInvertedCaseExample.Size = new System.Drawing.Size(142, 13);
            this.lblInvertedCaseExample.TabIndex = 2;
            this.lblInvertedCaseExample.Text = "Eg:  \'Abc Def\'  -->  \'aBC dEF\'";
            // 
            // txtMatchReplacement
            // 
            this.txtMatchReplacement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMatchReplacement.Enabled = false;
            this.txtMatchReplacement.Location = new System.Drawing.Point(389, 385);
            this.txtMatchReplacement.MaxLength = 128;
            this.txtMatchReplacement.Name = "txtMatchReplacement";
            this.txtMatchReplacement.Size = new System.Drawing.Size(118, 20);
            this.txtMatchReplacement.TabIndex = 22;
            // 
            // radTitleCase
            // 
            this.radTitleCase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radTitleCase.AutoSize = true;
            this.radTitleCase.Location = new System.Drawing.Point(63, 179);
            this.radTitleCase.Name = "radTitleCase";
            this.radTitleCase.Size = new System.Drawing.Size(71, 17);
            this.radTitleCase.TabIndex = 12;
            this.radTitleCase.Text = "Title case";
            this.radTitleCase.UseVisualStyleBackColor = true;
            // 
            // lblMatchReplacement
            // 
            this.lblMatchReplacement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMatchReplacement.AutoSize = true;
            this.lblMatchReplacement.Location = new System.Drawing.Point(291, 382);
            this.lblMatchReplacement.Name = "lblMatchReplacement";
            this.lblMatchReplacement.Size = new System.Drawing.Size(89, 13);
            this.lblMatchReplacement.TabIndex = 0;
            this.lblMatchReplacement.Text = "Text replacement";
            // 
            // radUpperCase
            // 
            this.radUpperCase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radUpperCase.AutoSize = true;
            this.radUpperCase.Location = new System.Drawing.Point(63, 202);
            this.radUpperCase.Name = "radUpperCase";
            this.radUpperCase.Size = new System.Drawing.Size(80, 17);
            this.radUpperCase.TabIndex = 13;
            this.radUpperCase.Text = "Upper case";
            this.radUpperCase.UseVisualStyleBackColor = true;
            // 
            // txtMatchSearch
            // 
            this.txtMatchSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMatchSearch.Enabled = false;
            this.txtMatchSearch.Location = new System.Drawing.Point(154, 385);
            this.txtMatchSearch.MaxLength = 128;
            this.txtMatchSearch.Name = "txtMatchSearch";
            this.txtMatchSearch.Size = new System.Drawing.Size(118, 20);
            this.txtMatchSearch.TabIndex = 21;
            // 
            // lblLowerCaseExample
            // 
            this.lblLowerCaseExample.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLowerCaseExample.AutoSize = true;
            this.lblLowerCaseExample.Location = new System.Drawing.Point(210, 225);
            this.lblLowerCaseExample.Name = "lblLowerCaseExample";
            this.lblLowerCaseExample.Size = new System.Drawing.Size(134, 13);
            this.lblLowerCaseExample.TabIndex = 2;
            this.lblLowerCaseExample.Text = "Eg:  \'Abc def\'  -->  \'abc def\'";
            // 
            // lblMatchSeach
            // 
            this.lblMatchSeach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMatchSeach.AutoSize = true;
            this.lblMatchSeach.Location = new System.Drawing.Point(83, 382);
            this.lblMatchSeach.Name = "lblMatchSeach";
            this.lblMatchSeach.Size = new System.Drawing.Size(63, 13);
            this.lblMatchSeach.TabIndex = 0;
            this.lblMatchSeach.Text = "Text search";
            // 
            // radLowerCase
            // 
            this.radLowerCase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLowerCase.AutoSize = true;
            this.radLowerCase.Location = new System.Drawing.Point(63, 225);
            this.radLowerCase.Name = "radLowerCase";
            this.radLowerCase.Size = new System.Drawing.Size(80, 17);
            this.radLowerCase.TabIndex = 14;
            this.radLowerCase.Text = "Lower case";
            this.radLowerCase.UseVisualStyleBackColor = true;
            // 
            // radBySimpleMatch
            // 
            this.radBySimpleMatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBySimpleMatch.AutoSize = true;
            this.radBySimpleMatch.Location = new System.Drawing.Point(63, 353);
            this.radBySimpleMatch.Name = "radBySimpleMatch";
            this.radBySimpleMatch.Size = new System.Drawing.Size(117, 17);
            this.radBySimpleMatch.TabIndex = 17;
            this.radBySimpleMatch.Text = "Simple coincidence";
            this.radBySimpleMatch.UseVisualStyleBackColor = true;
            this.radBySimpleMatch.CheckedChanged += new System.EventHandler(this.radBySimpleMatch_CheckedChanged);
            // 
            // radInvertedCase
            // 
            this.radInvertedCase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radInvertedCase.AutoSize = true;
            this.radInvertedCase.Location = new System.Drawing.Point(63, 248);
            this.radInvertedCase.Name = "radInvertedCase";
            this.radInvertedCase.Size = new System.Drawing.Size(90, 17);
            this.radInvertedCase.TabIndex = 15;
            this.radInvertedCase.Text = "Inverted case";
            this.radInvertedCase.UseVisualStyleBackColor = true;
            // 
            // lblUpperCaseExample
            // 
            this.lblUpperCaseExample.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpperCaseExample.AutoSize = true;
            this.lblUpperCaseExample.Location = new System.Drawing.Point(210, 202);
            this.lblUpperCaseExample.Name = "lblUpperCaseExample";
            this.lblUpperCaseExample.Size = new System.Drawing.Size(142, 13);
            this.lblUpperCaseExample.TabIndex = 2;
            this.lblUpperCaseExample.Text = "Eg:  \'abc def\'  -->  \'ABC DEF\'";
            // 
            // lblTitleCaseExample
            // 
            this.lblTitleCaseExample.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitleCaseExample.AutoSize = true;
            this.lblTitleCaseExample.Location = new System.Drawing.Point(210, 179);
            this.lblTitleCaseExample.Name = "lblTitleCaseExample";
            this.lblTitleCaseExample.Size = new System.Drawing.Size(136, 13);
            this.lblTitleCaseExample.TabIndex = 2;
            this.lblTitleCaseExample.Text = "Eg:  \'abc def\'  -->  \'Abc Def\'";
            // 
            // lblSentenceCaseExample
            // 
            this.lblSentenceCaseExample.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSentenceCaseExample.AutoSize = true;
            this.lblSentenceCaseExample.Location = new System.Drawing.Point(210, 156);
            this.lblSentenceCaseExample.Name = "lblSentenceCaseExample";
            this.lblSentenceCaseExample.Size = new System.Drawing.Size(134, 13);
            this.lblSentenceCaseExample.TabIndex = 2;
            this.lblSentenceCaseExample.Text = "Eg:  \'abc def\'  -->  \'Abc def\'";
            // 
            // tabPagePreview
            // 
            this.tabPagePreview.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPagePreview.Controls.Add(this.statusStripPreview);
            this.tabPagePreview.Controls.Add(this.listViewPreview);
            this.tabPagePreview.ImageKey = "Tabs-Preview.png";
            this.tabPagePreview.Location = new System.Drawing.Point(4, 28);
            this.tabPagePreview.Name = "tabPagePreview";
            this.tabPagePreview.Size = new System.Drawing.Size(1078, 710);
            this.tabPagePreview.TabIndex = 3;
            this.tabPagePreview.Text = "Preview  ";
            this.tabPagePreview.Enter += new System.EventHandler(this.tabPagePreview_Enter);
            // 
            // statusStripPreview
            // 
            this.statusStripPreview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabelPreview});
            this.statusStripPreview.Location = new System.Drawing.Point(0, 688);
            this.statusStripPreview.Name = "statusStripPreview";
            this.statusStripPreview.Size = new System.Drawing.Size(1078, 22);
            this.statusStripPreview.SizingGrip = false;
            this.statusStripPreview.TabIndex = 8;
            this.statusStripPreview.Text = "statusStrip1";
            // 
            // statusStripLabelPreview
            // 
            this.statusStripLabelPreview.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripLabelPreview.ForeColor = System.Drawing.Color.Red;
            this.statusStripLabelPreview.Name = "statusStripLabelPreview";
            this.statusStripLabelPreview.Size = new System.Drawing.Size(0, 17);
            // 
            // listViewPreview
            // 
            this.listViewPreview.AllowColumnReorder = true;
            this.listViewPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPreview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnNewName});
            listViewGroup5.Header = "Directories";
            listViewGroup5.Name = "lstViewGroupDirectories";
            listViewGroup6.Header = "Files";
            listViewGroup6.Name = "lstViewGroupFiles";
            this.listViewPreview.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6});
            this.listViewPreview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPreview.HideSelection = false;
            this.listViewPreview.LargeImageList = this.imgListObjectTypes;
            this.listViewPreview.Location = new System.Drawing.Point(13, 12);
            this.listViewPreview.Name = "listViewPreview";
            this.listViewPreview.ShowItemToolTips = true;
            this.listViewPreview.Size = new System.Drawing.Size(1051, 660);
            this.listViewPreview.SmallImageList = this.imgListObjectTypes;
            this.listViewPreview.TabIndex = 31;
            this.listViewPreview.TileSize = new System.Drawing.Size(184, 34);
            this.listViewPreview.UseCompatibleStateImageBehavior = false;
            this.listViewPreview.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Tag = "";
            this.columnName.Text = "Current Name";
            this.columnName.Width = 513;
            // 
            // columnNewName
            // 
            this.columnNewName.Text = "New Name";
            this.columnNewName.Width = 513;
            // 
            // tabPageActivityLogs
            // 
            this.tabPageActivityLogs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPageActivityLogs.Controls.Add(this.btnClearActivityLogs);
            this.tabPageActivityLogs.Controls.Add(this.txtActivityLogs);
            this.tabPageActivityLogs.ImageKey = "Tabs-ActivityLogs.png";
            this.tabPageActivityLogs.Location = new System.Drawing.Point(4, 28);
            this.tabPageActivityLogs.Name = "tabPageActivityLogs";
            this.tabPageActivityLogs.Size = new System.Drawing.Size(1078, 710);
            this.tabPageActivityLogs.TabIndex = 2;
            this.tabPageActivityLogs.Text = " Activity Logs  ";
            // 
            // btnClearActivityLogs
            // 
            this.btnClearActivityLogs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClearActivityLogs.Location = new System.Drawing.Point(938, 27);
            this.btnClearActivityLogs.Name = "btnClearActivityLogs";
            this.btnClearActivityLogs.Size = new System.Drawing.Size(100, 25);
            this.btnClearActivityLogs.TabIndex = 32;
            this.btnClearActivityLogs.Text = "Clear";
            this.btnClearActivityLogs.UseVisualStyleBackColor = true;
            this.btnClearActivityLogs.Click += new System.EventHandler(this.btnClearActivityLogs_Click);
            // 
            // txtActivityLogs
            // 
            this.txtActivityLogs.BackColor = System.Drawing.Color.White;
            this.txtActivityLogs.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivityLogs.Location = new System.Drawing.Point(38, 58);
            this.txtActivityLogs.Multiline = true;
            this.txtActivityLogs.Name = "txtActivityLogs";
            this.txtActivityLogs.ReadOnly = true;
            this.txtActivityLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtActivityLogs.Size = new System.Drawing.Size(1000, 616);
            this.txtActivityLogs.TabIndex = 33;
            // 
            // imgListTabs
            // 
            this.imgListTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListTabs.ImageStream")));
            this.imgListTabs.TransparentColor = System.Drawing.Color.Empty;
            this.imgListTabs.Images.SetKeyName(0, "Tabs-FilesFolders.png");
            this.imgListTabs.Images.SetKeyName(1, "Tabs-RenameSettings.png");
            this.imgListTabs.Images.SetKeyName(2, "Tabs-Preview.png");
            this.imgListTabs.Images.SetKeyName(3, "Tabs-ActivityLogs.png");
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnRename,
            this.menuBtnUndo,
            this.menuBtnQuickAccess,
            this.toolStripProgressBar,
            this.menuBtnAbout});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 2, 20, 2);
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMenu.Size = new System.Drawing.Size(1084, 35);
            this.toolStripMenu.TabIndex = 0;
            // 
            // menuBtnRename
            // 
            this.menuBtnRename.AutoSize = false;
            this.menuBtnRename.Image = global::Renamer.Front.Properties.Resources.MainMenu_Rename;
            this.menuBtnRename.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuBtnRename.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.menuBtnRename.Name = "menuBtnRename";
            this.menuBtnRename.Size = new System.Drawing.Size(140, 27);
            this.menuBtnRename.Text = " &Rename";
            this.menuBtnRename.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuBtnRename.ToolTipText = "Start remane";
            this.menuBtnRename.Click += new System.EventHandler(this.menuBtnRename_Click);
            // 
            // menuBtnUndo
            // 
            this.menuBtnUndo.AutoSize = false;
            this.menuBtnUndo.Enabled = false;
            this.menuBtnUndo.Image = global::Renamer.Front.Properties.Resources.MainMenu_Undo;
            this.menuBtnUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuBtnUndo.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.menuBtnUndo.Name = "menuBtnUndo";
            this.menuBtnUndo.Size = new System.Drawing.Size(140, 27);
            this.menuBtnUndo.Text = " &Undo";
            this.menuBtnUndo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuBtnUndo.ToolTipText = "Undo last rename";
            this.menuBtnUndo.Click += new System.EventHandler(this.menuBtnUndo_Click);
            // 
            // menuBtnQuickAccess
            // 
            this.menuBtnQuickAccess.AutoSize = false;
            this.menuBtnQuickAccess.DropDownButtonWidth = 22;
            this.menuBtnQuickAccess.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUserFolder,
            this.toolStripSeparator,
            this.toolStripMenuItemDesktop,
            this.toolStripMenuItemDocuments,
            this.toolStripMenuItemDownloads,
            this.toolStripMenuItemMusic,
            this.toolStripMenuItemPictures,
            this.toolStripMenuItemVideos});
            this.menuBtnQuickAccess.Image = global::Renamer.Front.Properties.Resources.MainMenu_QuickAccess;
            this.menuBtnQuickAccess.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuBtnQuickAccess.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.menuBtnQuickAccess.Name = "menuBtnQuickAccess";
            this.menuBtnQuickAccess.Size = new System.Drawing.Size(180, 27);
            this.menuBtnQuickAccess.Text = "Quick Access";
            this.menuBtnQuickAccess.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.menuBtnQuickAccess.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuBtnQuickAccess_DropDownItemClicked);
            // 
            // toolStripMenuItemUserFolder
            // 
            this.toolStripMenuItemUserFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemUserFolder.Image = global::Renamer.Front.Properties.Resources.UserFolder_Home;
            this.toolStripMenuItemUserFolder.Name = "toolStripMenuItemUserFolder";
            this.toolStripMenuItemUserFolder.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemUserFolder.Text = "User\'s Folder";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItemDesktop
            // 
            this.toolStripMenuItemDesktop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemDesktop.Image = global::Renamer.Front.Properties.Resources.UserFolder_Desktop;
            this.toolStripMenuItemDesktop.Name = "toolStripMenuItemDesktop";
            this.toolStripMenuItemDesktop.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemDesktop.Text = "Desktop";
            // 
            // toolStripMenuItemDocuments
            // 
            this.toolStripMenuItemDocuments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemDocuments.Image = global::Renamer.Front.Properties.Resources.UserFolder_Documents;
            this.toolStripMenuItemDocuments.Name = "toolStripMenuItemDocuments";
            this.toolStripMenuItemDocuments.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemDocuments.Text = "Documents";
            // 
            // toolStripMenuItemDownloads
            // 
            this.toolStripMenuItemDownloads.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemDownloads.Image = global::Renamer.Front.Properties.Resources.UserFolder_Downloads;
            this.toolStripMenuItemDownloads.Name = "toolStripMenuItemDownloads";
            this.toolStripMenuItemDownloads.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemDownloads.Text = "Downloads";
            // 
            // toolStripMenuItemMusic
            // 
            this.toolStripMenuItemMusic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemMusic.Image = global::Renamer.Front.Properties.Resources.UserFolder_Music;
            this.toolStripMenuItemMusic.Name = "toolStripMenuItemMusic";
            this.toolStripMenuItemMusic.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemMusic.Text = "Music";
            // 
            // toolStripMenuItemPictures
            // 
            this.toolStripMenuItemPictures.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemPictures.Image = global::Renamer.Front.Properties.Resources.UserFolder_Pictures;
            this.toolStripMenuItemPictures.Name = "toolStripMenuItemPictures";
            this.toolStripMenuItemPictures.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemPictures.Text = "Pictures";
            // 
            // toolStripMenuItemVideos
            // 
            this.toolStripMenuItemVideos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemVideos.Image = global::Renamer.Front.Properties.Resources.UserFolder_Videos;
            this.toolStripMenuItemVideos.Name = "toolStripMenuItemVideos";
            this.toolStripMenuItemVideos.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemVideos.Text = "Videos";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.AutoSize = false;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(220, 20);
            this.toolStripProgressBar.Visible = false;
            // 
            // menuBtnAbout
            // 
            this.menuBtnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuBtnAbout.AutoSize = false;
            this.menuBtnAbout.Image = global::Renamer.Front.Properties.Resources.MainMenu_About;
            this.menuBtnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuBtnAbout.Name = "menuBtnAbout";
            this.menuBtnAbout.Size = new System.Drawing.Size(110, 28);
            this.menuBtnAbout.Text = "About";
            this.menuBtnAbout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuBtnAbout.Click += new System.EventHandler(this.menuBtnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 778);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1320, 920);
            this.MinimumSize = new System.Drawing.Size(1100, 817);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renamer";
            this.tabMain.ResumeLayout(false);
            this.tabPageFilesFolders.ResumeLayout(false);
            this.tabPageFilesFolders.PerformLayout();
            this.statusStripPath.ResumeLayout(false);
            this.statusStripPath.PerformLayout();
            this.groupBoxSelection.ResumeLayout(false);
            this.toolStripViews.ResumeLayout(false);
            this.toolStripViews.PerformLayout();
            this.tabPageRenameSettings.ResumeLayout(false);
            this.tabPageRenameSettings.PerformLayout();
            this.tabPagePreview.ResumeLayout(false);
            this.tabPagePreview.PerformLayout();
            this.statusStripPreview.ResumeLayout(false);
            this.statusStripPreview.PerformLayout();
            this.tabPageActivityLogs.ResumeLayout(false);
            this.tabPageActivityLogs.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageFilesFolders;
        private System.Windows.Forms.TabPage tabPageRenameSettings;
        private System.Windows.Forms.TabPage tabPageActivityLogs;
        private System.Windows.Forms.TreeView treeViewFolderPick;
        private System.Windows.Forms.ImageList imgListTabs;
        private System.Windows.Forms.ListView listViewFilePick;
        private System.Windows.Forms.ColumnHeader headerFileName;
        private System.Windows.Forms.GroupBox groupBoxSelection;
        private System.Windows.Forms.Button btnAddSingle;
        private System.Windows.Forms.ToolStrip toolStripViews;
        private System.Windows.Forms.ToolStripButton toolStripBtnLargeIcons;
        private System.Windows.Forms.ToolStripButton toolStripBtnDetails;
        private System.Windows.Forms.ToolStripButton toolStripBtnSmallIcons;
        private System.Windows.Forms.ToolStripButton toolStripBtnList;
        private System.Windows.Forms.ToolStripButton toolStripBtnTile;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemoveSingle;
        private System.Windows.Forms.Button btnAddMany;
        private System.Windows.Forms.ImageList imgListObjectTypes;
        private System.Windows.Forms.ColumnHeader headerFileSize;
        private System.Windows.Forms.ListView listViewSelectedItems;
        private System.Windows.Forms.ColumnHeader columnFullPath;
        private System.Windows.Forms.RadioButton radBySimpleMatch;
        private System.Windows.Forms.TextBox txtMatchReplacement;
        private System.Windows.Forms.Label lblMatchReplacement;
        private System.Windows.Forms.TextBox txtMatchSearch;
        private System.Windows.Forms.Label lblMatchSeach;
        private System.Windows.Forms.RadioButton radTitleCase;
        private System.Windows.Forms.Label lblTitleCaseExample;
        private System.Windows.Forms.Label lblUpperCaseExample;
        private System.Windows.Forms.RadioButton radUpperCase;
        private System.Windows.Forms.Label lblLowerCaseExample;
        private System.Windows.Forms.RadioButton radLowerCase;
        private System.Windows.Forms.Label lblInvertedCaseExample;
        private System.Windows.Forms.RadioButton radInvertedCase;
        private System.Windows.Forms.RadioButton radSentenceCase;
        private System.Windows.Forms.Label lblSentenceCaseExample;
        private System.Windows.Forms.Label lblChangeCase;
        private System.Windows.Forms.Label lblByPosition;
        private System.Windows.Forms.Label lblByMatch;
        private System.Windows.Forms.Label lblPositionalReplace;
        private System.Windows.Forms.TextBox txtPositionalReplaceText;
        private System.Windows.Forms.TextBox txtPositionalReplaceIndex;
        private System.Windows.Forms.RadioButton radPositionalReplace;
        private System.Windows.Forms.Label lblPositionalReplaceExample;
        private System.Windows.Forms.Label lblByMatchExample;
        private System.Windows.Forms.Label lblByPattern;
        private System.Windows.Forms.RadioButton radByPattern;
        private System.Windows.Forms.Label lblStartIndex;
        private System.Windows.Forms.TextBox txtStartIndex;
        private System.Windows.Forms.TextBox txtBeginnigText;
        private System.Windows.Forms.Label lblBeginnigText;
        private System.Windows.Forms.TextBox txtIncrement;
        private System.Windows.Forms.Label lblIncrement;
        private System.Windows.Forms.Label lblByPatternExample;
        private System.Windows.Forms.TextBox txtNumericPad;
        private System.Windows.Forms.Label lblNumericPad;
        private System.Windows.Forms.CheckBox chkIncludeExtension;
        private System.Windows.Forms.Label lblGeneralOptions;
        private System.Windows.Forms.TextBox txtActivityLogs;
        private System.Windows.Forms.RadioButton radPositionalAppend;
        private System.Windows.Forms.TextBox txtPositionalAppendIndex;
        private System.Windows.Forms.TextBox txtPositionalAppendText;
        private System.Windows.Forms.Label lblPositionalAppend;
        private System.Windows.Forms.Label lblPositionalAppendExample;
        private System.Windows.Forms.Button btnAddTree;
        private System.Windows.Forms.Label lblRemoveTildesExample;
        private System.Windows.Forms.RadioButton radRemoveTildes;
        private System.Windows.Forms.Label lblFoundFiles;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton menuBtnRename;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripButton menuBtnUndo;
        private System.Windows.Forms.ToolStripButton menuBtnAbout;
        private System.Windows.Forms.StatusStrip statusStripPath;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabelPath;
        private System.Windows.Forms.TabPage tabPagePreview;
        private System.Windows.Forms.ListView listViewPreview;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnNewName;
        private System.Windows.Forms.StatusStrip statusStripPreview;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabelPreview;
        private System.Windows.Forms.Button btnClearActivityLogs;
        private System.Windows.Forms.ToolStripSplitButton menuBtnQuickAccess;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDesktop;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUserFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDocuments;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDownloads;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMusic;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPictures;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVideos;
    }
}

