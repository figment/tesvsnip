namespace TESsnip {
    partial class MainView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.PluginTree = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertSubrecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useNewSubrecordEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookupFormidsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanitizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripEDIDsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDuplicatedFormIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpEDIDListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanEspToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNonconformingRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateLLXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeEsmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.martigensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStringsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reorderSubrecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenModDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.SaveModDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStripSubRecord = new System.Windows.Forms.ToolStrip();
            this.toolStripInsertRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripDeleteRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripMoveRecordUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripMoveRecordDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditSubrecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditSubrecordHex = new System.Windows.Forms.ToolStripButton();
            this.toolStripPasteSubrecord = new System.Windows.Forms.ToolStripButton();
            this.listSubrecord = new TESsnip.Windows.Controls.BindingListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.SaveEdidListDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripCopySubrecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStripSubRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // PluginTree
            // 
            this.PluginTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginTree.HideSelection = false;
            this.PluginTree.Location = new System.Drawing.Point(0, 0);
            this.PluginTree.Name = "PluginTree";
            this.PluginTree.Size = new System.Drawing.Size(221, 226);
            this.PluginTree.TabIndex = 0;
            this.PluginTree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PluginTree_MouseDoubleClick);
            this.PluginTree.Enter += new System.EventHandler(this.PluginTree_Enter);
            this.PluginTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.PluginTree_AfterSelect);
            this.PluginTree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.PluginTree_AfterExpand);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.spellsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openNewPluginToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.reloadXmlToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openNewPluginToolStripMenuItem
            // 
            this.openNewPluginToolStripMenuItem.Name = "openNewPluginToolStripMenuItem";
            this.openNewPluginToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openNewPluginToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openNewPluginToolStripMenuItem.Text = "Open";
            this.openNewPluginToolStripMenuItem.Click += new System.EventHandler(this.openNewPluginToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.closeAllToolStripMenuItem.Text = "Close all";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // reloadXmlToolStripMenuItem
            // 
            this.reloadXmlToolStripMenuItem.Name = "reloadXmlToolStripMenuItem";
            this.reloadXmlToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.reloadXmlToolStripMenuItem.Text = "Reload xml";
            this.reloadXmlToolStripMenuItem.Click += new System.EventHandler(this.reloadXmlToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.insertRecordToolStripMenuItem,
            this.insertSubrecordToolStripMenuItem,
            this.findToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // insertRecordToolStripMenuItem
            // 
            this.insertRecordToolStripMenuItem.Enabled = false;
            this.insertRecordToolStripMenuItem.Name = "insertRecordToolStripMenuItem";
            this.insertRecordToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.insertRecordToolStripMenuItem.Text = "New record";
            this.insertRecordToolStripMenuItem.Click += new System.EventHandler(this.insertRecordToolStripMenuItem_Click);
            // 
            // insertSubrecordToolStripMenuItem
            // 
            this.insertSubrecordToolStripMenuItem.Enabled = false;
            this.insertSubrecordToolStripMenuItem.Name = "insertSubrecordToolStripMenuItem";
            this.insertSubrecordToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.insertSubrecordToolStripMenuItem.Text = "New subrecord";
            this.insertSubrecordToolStripMenuItem.Click += new System.EventHandler(this.insertSubrecordToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hexModeToolStripMenuItem,
            this.useNewSubrecordEditorToolStripMenuItem,
            this.lookupFormidsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // hexModeToolStripMenuItem
            // 
            this.hexModeToolStripMenuItem.Checked = true;
            this.hexModeToolStripMenuItem.CheckOnClick = true;
            this.hexModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hexModeToolStripMenuItem.Name = "hexModeToolStripMenuItem";
            this.hexModeToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.hexModeToolStripMenuItem.Text = "Hex mode";
            // 
            // useNewSubrecordEditorToolStripMenuItem
            // 
            this.useNewSubrecordEditorToolStripMenuItem.Checked = true;
            this.useNewSubrecordEditorToolStripMenuItem.CheckOnClick = true;
            this.useNewSubrecordEditorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useNewSubrecordEditorToolStripMenuItem.Name = "useNewSubrecordEditorToolStripMenuItem";
            this.useNewSubrecordEditorToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.useNewSubrecordEditorToolStripMenuItem.Text = "Use new subrecord editor";
            // 
            // lookupFormidsToolStripMenuItem
            // 
            this.lookupFormidsToolStripMenuItem.Checked = true;
            this.lookupFormidsToolStripMenuItem.CheckOnClick = true;
            this.lookupFormidsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lookupFormidsToolStripMenuItem.Name = "lookupFormidsToolStripMenuItem";
            this.lookupFormidsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.lookupFormidsToolStripMenuItem.Text = "Lookup formids";
            // 
            // spellsToolStripMenuItem
            // 
            this.spellsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sanitizeToolStripMenuItem,
            this.stripEDIDsToolStripMenuItem,
            this.findDuplicatedFormIDToolStripMenuItem,
            this.dumpEDIDListToolStripMenuItem,
            this.cleanEspToolStripMenuItem,
            this.findNonconformingRecordToolStripMenuItem,
            this.compileScriptToolStripMenuItem,
            this.compileAllToolStripMenuItem,
            this.generateLLXmlToolStripMenuItem,
            this.makeEsmToolStripMenuItem,
            this.martigensToolStripMenuItem,
            this.editStringsToolStripMenuItem,
            this.reorderSubrecordsToolStripMenuItem});
            this.spellsToolStripMenuItem.Name = "spellsToolStripMenuItem";
            this.spellsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.spellsToolStripMenuItem.Text = "Spells";
            // 
            // sanitizeToolStripMenuItem
            // 
            this.sanitizeToolStripMenuItem.Name = "sanitizeToolStripMenuItem";
            this.sanitizeToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.sanitizeToolStripMenuItem.Text = "Sanitize";
            this.sanitizeToolStripMenuItem.Click += new System.EventHandler(this.sanitizeToolStripMenuItem_Click);
            // 
            // stripEDIDsToolStripMenuItem
            // 
            this.stripEDIDsToolStripMenuItem.Name = "stripEDIDsToolStripMenuItem";
            this.stripEDIDsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.stripEDIDsToolStripMenuItem.Text = "Strip EDIDs";
            this.stripEDIDsToolStripMenuItem.Click += new System.EventHandler(this.stripEDIDsToolStripMenuItem_Click);
            // 
            // findDuplicatedFormIDToolStripMenuItem
            // 
            this.findDuplicatedFormIDToolStripMenuItem.Name = "findDuplicatedFormIDToolStripMenuItem";
            this.findDuplicatedFormIDToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.findDuplicatedFormIDToolStripMenuItem.Text = "Find duplicated FormID";
            this.findDuplicatedFormIDToolStripMenuItem.Click += new System.EventHandler(this.findDuplicatedFormIDToolStripMenuItem_Click);
            // 
            // dumpEDIDListToolStripMenuItem
            // 
            this.dumpEDIDListToolStripMenuItem.Name = "dumpEDIDListToolStripMenuItem";
            this.dumpEDIDListToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.dumpEDIDListToolStripMenuItem.Text = "Dump EDID list";
            this.dumpEDIDListToolStripMenuItem.Click += new System.EventHandler(this.dumpEDIDListToolStripMenuItem_Click);
            // 
            // cleanEspToolStripMenuItem
            // 
            this.cleanEspToolStripMenuItem.Name = "cleanEspToolStripMenuItem";
            this.cleanEspToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.cleanEspToolStripMenuItem.Text = "Clean esp";
            this.cleanEspToolStripMenuItem.Click += new System.EventHandler(this.cleanEspToolStripMenuItem_Click);
            // 
            // findNonconformingRecordToolStripMenuItem
            // 
            this.findNonconformingRecordToolStripMenuItem.Name = "findNonconformingRecordToolStripMenuItem";
            this.findNonconformingRecordToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.findNonconformingRecordToolStripMenuItem.Text = "Find nonconforming record";
            this.findNonconformingRecordToolStripMenuItem.Click += new System.EventHandler(this.findNonconformingRecordToolStripMenuItem_Click);
            // 
            // compileScriptToolStripMenuItem
            // 
            this.compileScriptToolStripMenuItem.Name = "compileScriptToolStripMenuItem";
            this.compileScriptToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.compileScriptToolStripMenuItem.Text = "Compile script";
            this.compileScriptToolStripMenuItem.Click += new System.EventHandler(this.compileScriptToolStripMenuItem_Click);
            // 
            // compileAllToolStripMenuItem
            // 
            this.compileAllToolStripMenuItem.Name = "compileAllToolStripMenuItem";
            this.compileAllToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.compileAllToolStripMenuItem.Text = "Compile all";
            this.compileAllToolStripMenuItem.Click += new System.EventHandler(this.compileAllToolStripMenuItem_Click);
            // 
            // generateLLXmlToolStripMenuItem
            // 
            this.generateLLXmlToolStripMenuItem.Name = "generateLLXmlToolStripMenuItem";
            this.generateLLXmlToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.generateLLXmlToolStripMenuItem.Text = "Generate LL xml";
            this.generateLLXmlToolStripMenuItem.Click += new System.EventHandler(this.generateLLXmlToolStripMenuItem_Click);
            // 
            // makeEsmToolStripMenuItem
            // 
            this.makeEsmToolStripMenuItem.Name = "makeEsmToolStripMenuItem";
            this.makeEsmToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.makeEsmToolStripMenuItem.Text = "Make esm";
            this.makeEsmToolStripMenuItem.Click += new System.EventHandler(this.makeEsmToolStripMenuItem_Click);
            // 
            // martigensToolStripMenuItem
            // 
            this.martigensToolStripMenuItem.Name = "martigensToolStripMenuItem";
            this.martigensToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.martigensToolStripMenuItem.Text = "SCTX replacer";
            this.martigensToolStripMenuItem.Click += new System.EventHandler(this.martigensToolStripMenuItem_Click);
            // 
            // editStringsToolStripMenuItem
            // 
            this.editStringsToolStripMenuItem.Name = "editStringsToolStripMenuItem";
            this.editStringsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.editStringsToolStripMenuItem.Text = "Edit Strings";
            this.editStringsToolStripMenuItem.Click += new System.EventHandler(this.editStringsToolStripMenuItem_Click);
            // 
            // reorderSubrecordsToolStripMenuItem
            // 
            this.reorderSubrecordsToolStripMenuItem.Name = "reorderSubrecordsToolStripMenuItem";
            this.reorderSubrecordsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.reorderSubrecordsToolStripMenuItem.Text = "Reorder Subrecords";
            this.reorderSubrecordsToolStripMenuItem.Click += new System.EventHandler(this.reorderSubrecordsToolStripMenuItem_Click);
            // 
            // OpenModDialog
            // 
            this.OpenModDialog.Filter = "Skyrim plugin (*.esm, *.esp)|*.esm;*.esp";
            this.OpenModDialog.Multiselect = true;
            this.OpenModDialog.RestoreDirectory = true;
            this.OpenModDialog.Title = "Select plugin(s) to open";
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.SystemColors.Window;
            this.tbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInfo.Location = new System.Drawing.Point(0, 0);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo.ShortcutsEnabled = false;
            this.tbInfo.Size = new System.Drawing.Size(442, 461);
            this.tbInfo.TabIndex = 2;
            this.tbInfo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbInfo_PreviewKeyDown);
            // 
            // SaveModDialog
            // 
            this.SaveModDialog.DefaultExt = "esp";
            this.SaveModDialog.Filter = "Skyrim plugin (*.esp)|*.esp|Master file|*.esm";
            this.SaveModDialog.RestoreDirectory = true;
            this.SaveModDialog.Title = "Select path to save to";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbInfo);
            this.splitContainer1.Size = new System.Drawing.Size(667, 461);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.PluginTree);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.toolStripSubRecord);
            this.splitContainer2.Panel2.Controls.Add(this.listSubrecord);
            this.splitContainer2.Size = new System.Drawing.Size(221, 461);
            this.splitContainer2.SplitterDistance = 226;
            this.splitContainer2.TabIndex = 1;
            // 
            // toolStripSubRecord
            // 
            this.toolStripSubRecord.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripSubRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripInsertRecord,
            this.toolStripDeleteRecord,
            this.toolStripSeparator1,
            this.toolStripMoveRecordUp,
            this.toolStripMoveRecordDown,
            this.toolStripButton1,
            this.toolStripEditSubrecord,
            this.toolStripEditSubrecordHex,
            this.toolStripPasteSubrecord,
            this.toolStripCopySubrecord,
            this.toolStripSeparator2});
            this.toolStripSubRecord.Location = new System.Drawing.Point(0, 0);
            this.toolStripSubRecord.Name = "toolStripSubRecord";
            this.toolStripSubRecord.Size = new System.Drawing.Size(221, 25);
            this.toolStripSubRecord.TabIndex = 1;
            // 
            // toolStripInsertRecord
            // 
            this.toolStripInsertRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripInsertRecord.Image = global::TESsnip.Properties.Resources.insertcell;
            this.toolStripInsertRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripInsertRecord.Name = "toolStripInsertRecord";
            this.toolStripInsertRecord.Size = new System.Drawing.Size(23, 22);
            this.toolStripInsertRecord.Text = "Insert Record";
            this.toolStripInsertRecord.Click += new System.EventHandler(this.toolStripInsertRecord_Click);
            // 
            // toolStripDeleteRecord
            // 
            this.toolStripDeleteRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDeleteRecord.Image = global::TESsnip.Properties.Resources.deletecell;
            this.toolStripDeleteRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDeleteRecord.Name = "toolStripDeleteRecord";
            this.toolStripDeleteRecord.Size = new System.Drawing.Size(23, 22);
            this.toolStripDeleteRecord.Text = "Delete Record";
            this.toolStripDeleteRecord.Click += new System.EventHandler(this.toolStripDeleteRecord_Click);
            // 
            // toolStripMoveRecordUp
            // 
            this.toolStripMoveRecordUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMoveRecordUp.Image = global::TESsnip.Properties.Resources.move_task_up;
            this.toolStripMoveRecordUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMoveRecordUp.Name = "toolStripMoveRecordUp";
            this.toolStripMoveRecordUp.Size = new System.Drawing.Size(23, 22);
            this.toolStripMoveRecordUp.Text = "Move Record Up";
            this.toolStripMoveRecordUp.Click += new System.EventHandler(this.toolStripMoveRecordUp_Click);
            // 
            // toolStripMoveRecordDown
            // 
            this.toolStripMoveRecordDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMoveRecordDown.Image = global::TESsnip.Properties.Resources.move_task_down;
            this.toolStripMoveRecordDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMoveRecordDown.Name = "toolStripMoveRecordDown";
            this.toolStripMoveRecordDown.Size = new System.Drawing.Size(23, 22);
            this.toolStripMoveRecordDown.Text = "Move Record Down";
            this.toolStripMoveRecordDown.Click += new System.EventHandler(this.toolStripMoveRecordDown_Click);
            // 
            // toolStripEditSubrecord
            // 
            this.toolStripEditSubrecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEditSubrecord.Image = global::TESsnip.Properties.Resources.editclear;
            this.toolStripEditSubrecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditSubrecord.Name = "toolStripEditSubrecord";
            this.toolStripEditSubrecord.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.toolStripEditSubrecord.Size = new System.Drawing.Size(23, 22);
            this.toolStripEditSubrecord.Text = "Edit Subrecord";
            this.toolStripEditSubrecord.Click += new System.EventHandler(this.toolStripEditSubrecord_Click);
            // 
            // toolStripEditSubrecordHex
            // 
            this.toolStripEditSubrecordHex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEditSubrecordHex.Image = global::TESsnip.Properties.Resources.xdays;
            this.toolStripEditSubrecordHex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditSubrecordHex.Name = "toolStripEditSubrecordHex";
            this.toolStripEditSubrecordHex.Size = new System.Drawing.Size(23, 22);
            this.toolStripEditSubrecordHex.Text = "Hex Edit";
            this.toolStripEditSubrecordHex.Click += new System.EventHandler(this.toolStripEditSubrecordHex_Click);
            // 
            // toolStripPasteSubrecord
            // 
            this.toolStripPasteSubrecord.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripPasteSubrecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPasteSubrecord.Image = global::TESsnip.Properties.Resources.Paste;
            this.toolStripPasteSubrecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPasteSubrecord.Name = "toolStripPasteSubrecord";
            this.toolStripPasteSubrecord.Size = new System.Drawing.Size(23, 22);
            this.toolStripPasteSubrecord.Text = "Paste";
            this.toolStripPasteSubrecord.Click += new System.EventHandler(this.toolStripPasteSubrecord_Click);
            // 
            // listSubrecord
            // 
            this.listSubrecord.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listSubrecord.AllowDrop = true;
            this.listSubrecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listSubrecord.AutoScroll = false;
            this.listSubrecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listSubrecord.DataSource = null;
            this.listSubrecord.FullRowSelect = true;
            this.listSubrecord.GridLines = true;
            this.listSubrecord.HideSelection = false;
            this.listSubrecord.HoverSelection = true;
            this.listSubrecord.ItemCount = 0;
            this.listSubrecord.Location = new System.Drawing.Point(0, 28);
            this.listSubrecord.MultiSelect = false;
            this.listSubrecord.Name = "listSubrecord";
            this.listSubrecord.ShowItemToolTips = true;
            this.listSubrecord.Size = new System.Drawing.Size(221, 203);
            this.listSubrecord.TabIndex = 0;
            this.listSubrecord.UseCompatibleStateImageBehavior = false;
            this.listSubrecord.View = System.Windows.Forms.View.Details;
            this.listSubrecord.VirtualMode = true;
            this.listSubrecord.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listSubrecord.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listSubrecord.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSubrecord_MouseDoubleClick);
            this.listSubrecord.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView1_ItemDrag);
            this.listSubrecord.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.listView1_GiveFeedback);
            this.listSubrecord.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listSubrecord.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            // 
            // SaveEdidListDialog
            // 
            this.SaveEdidListDialog.DefaultExt = "txt";
            this.SaveEdidListDialog.Filter = "Text file (*.txt)|*.txt";
            this.SaveEdidListDialog.RestoreDirectory = true;
            this.SaveEdidListDialog.Title = "Save file as";
            // 
            // toolStripCopySubrecord
            // 
            this.toolStripCopySubrecord.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripCopySubrecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopySubrecord.Image = global::TESsnip.Properties.Resources.Copy;
            this.toolStripCopySubrecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopySubrecord.Name = "toolStripCopySubrecord";
            this.toolStripCopySubrecord.Size = new System.Drawing.Size(23, 22);
            this.toolStripCopySubrecord.Text = "Copy Element";
            this.toolStripCopySubrecord.Click += new System.EventHandler(this.toolStripCopySubrecord_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 485);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(380, 300);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TESsnip (Skyrim edition)";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TESsnip_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.toolStripSubRecord.ResumeLayout(false);
            this.toolStripSubRecord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView PluginTree;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewPluginToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenModDialog;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexModeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveModDialog;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private TESsnip.Windows.Controls.BindingListView listSubrecord;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripMenuItem insertRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertSubrecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanitizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripEDIDsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findDuplicatedFormIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useNewSubrecordEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpEDIDListToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveEdidListDialog;
        private System.Windows.Forms.ToolStripMenuItem reloadXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookupFormidsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanEspToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNonconformingRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateLLXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeEsmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem martigensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStringsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripSubRecord;
        private System.Windows.Forms.ToolStripButton toolStripInsertRecord;
        private System.Windows.Forms.ToolStripButton toolStripDeleteRecord;
        private System.Windows.Forms.ToolStripButton toolStripMoveRecordUp;
        private System.Windows.Forms.ToolStripButton toolStripMoveRecordDown;
        private System.Windows.Forms.ToolStripButton toolStripEditSubrecord;
        private System.Windows.Forms.ToolStripButton toolStripEditSubrecordHex;
        private System.Windows.Forms.ToolStripMenuItem reorderSubrecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripPasteSubrecord;
        private System.Windows.Forms.ToolStripButton toolStripCopySubrecord;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}