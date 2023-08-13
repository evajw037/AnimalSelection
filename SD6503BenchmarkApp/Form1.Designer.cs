namespace SD6503BenchmarkApp
{
    partial class Form1
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
            this.gbxLoadSort = new System.Windows.Forms.GroupBox();
            this.lbxCreatures = new System.Windows.Forms.ListBox();
            this.btnZA = new System.Windows.Forms.Button();
            this.btnAZ = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gbxSearchSave = new System.Windows.Forms.GroupBox();
            this.lbxSearchResults = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxOwner = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.mnsMenuLoadSort = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenuSaveSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttpToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.gbxLoadSort.SuspendLayout();
            this.gbxSearchSave.SuspendLayout();
            this.mnsMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLoadSort
            // 
            this.gbxLoadSort.Controls.Add(this.lbxCreatures);
            this.gbxLoadSort.Controls.Add(this.btnZA);
            this.gbxLoadSort.Controls.Add(this.btnAZ);
            this.gbxLoadSort.Controls.Add(this.btnLoad);
            this.gbxLoadSort.Location = new System.Drawing.Point(29, 59);
            this.gbxLoadSort.Name = "gbxLoadSort";
            this.gbxLoadSort.Size = new System.Drawing.Size(254, 251);
            this.gbxLoadSort.TabIndex = 0;
            this.gbxLoadSort.TabStop = false;
            this.gbxLoadSort.Text = "Load and Sort";
            // 
            // lbxCreatures
            // 
            this.lbxCreatures.FormattingEnabled = true;
            this.lbxCreatures.ItemHeight = 12;
            this.lbxCreatures.Location = new System.Drawing.Point(26, 98);
            this.lbxCreatures.Name = "lbxCreatures";
            this.lbxCreatures.Size = new System.Drawing.Size(204, 112);
            this.lbxCreatures.TabIndex = 3;
            this.ttpToolTips.SetToolTip(this.lbxCreatures, "Display a list of creatures");
            this.lbxCreatures.SelectedIndexChanged += new System.EventHandler(this.lbxCreatures_SelectedIndexChanged);
            // 
            // btnZA
            // 
            this.btnZA.Location = new System.Drawing.Point(168, 40);
            this.btnZA.Name = "btnZA";
            this.btnZA.Size = new System.Drawing.Size(75, 23);
            this.btnZA.TabIndex = 2;
            this.btnZA.Text = "ZA";
            this.ttpToolTips.SetToolTip(this.btnZA, "Sort creatures ZA");
            this.btnZA.UseVisualStyleBackColor = true;
            this.btnZA.Click += new System.EventHandler(this.btnZA_Click);
            // 
            // btnAZ
            // 
            this.btnAZ.Location = new System.Drawing.Point(87, 40);
            this.btnAZ.Name = "btnAZ";
            this.btnAZ.Size = new System.Drawing.Size(75, 23);
            this.btnAZ.TabIndex = 1;
            this.btnAZ.Text = "AZ";
            this.ttpToolTips.SetToolTip(this.btnAZ, "Sort creatures AZ");
            this.btnAZ.UseVisualStyleBackColor = true;
            this.btnAZ.Click += new System.EventHandler(this.btnAZ_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 40);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.ttpToolTips.SetToolTip(this.btnLoad, "Loads a list of Creatures\r\n");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gbxSearchSave
            // 
            this.gbxSearchSave.Controls.Add(this.lbxSearchResults);
            this.gbxSearchSave.Controls.Add(this.btnSearch);
            this.gbxSearchSave.Controls.Add(this.tbxSearch);
            this.gbxSearchSave.Location = new System.Drawing.Point(300, 59);
            this.gbxSearchSave.Name = "gbxSearchSave";
            this.gbxSearchSave.Size = new System.Drawing.Size(237, 251);
            this.gbxSearchSave.TabIndex = 1;
            this.gbxSearchSave.TabStop = false;
            this.gbxSearchSave.Text = "Search and Save";
            // 
            // lbxSearchResults
            // 
            this.lbxSearchResults.FormattingEnabled = true;
            this.lbxSearchResults.ItemHeight = 12;
            this.lbxSearchResults.Location = new System.Drawing.Point(18, 93);
            this.lbxSearchResults.Name = "lbxSearchResults";
            this.lbxSearchResults.Size = new System.Drawing.Size(193, 112);
            this.lbxSearchResults.TabIndex = 2;
            this.ttpToolTips.SetToolTip(this.lbxSearchResults, "Display a list of creatures");
            this.lbxSearchResults.SelectedIndexChanged += new System.EventHandler(this.lbxCreatures_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(136, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.ttpToolTips.SetToolTip(this.btnSearch, "Search creatures list");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(20, 32);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 21);
            this.tbxSearch.TabIndex = 0;
            this.ttpToolTips.SetToolTip(this.tbxSearch, "Enter a search term");
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(562, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(568, 157);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(23, 12);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            this.lblAge.Click += new System.EventHandler(this.lblAge_Click);
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(562, 201);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(35, 12);
            this.lblOwner.TabIndex = 4;
            this.lblOwner.Text = "Owner";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(630, 108);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(100, 21);
            this.tbxName.TabIndex = 5;
            this.ttpToolTips.SetToolTip(this.tbxName, "Name of selected creature");
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(630, 157);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.ReadOnly = true;
            this.tbxAge.Size = new System.Drawing.Size(100, 21);
            this.tbxAge.TabIndex = 6;
            this.ttpToolTips.SetToolTip(this.tbxAge, "Age of selected creature");
            // 
            // tbxOwner
            // 
            this.tbxOwner.Location = new System.Drawing.Point(630, 201);
            this.tbxOwner.Name = "tbxOwner";
            this.tbxOwner.ReadOnly = true;
            this.tbxOwner.Size = new System.Drawing.Size(100, 21);
            this.tbxOwner.TabIndex = 7;
            this.ttpToolTips.SetToolTip(this.tbxOwner, "Owner of selected creature");
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(641, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.ttpToolTips.SetToolTip(this.btnSave, "Save selected creature");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsMenuLoadSort,
            this.mnsMenuSaveSearch});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(800, 25);
            this.mnsMenu.TabIndex = 9;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // mnsMenuLoadSort
            // 
            this.mnsMenuLoadSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.sortAZToolStripMenuItem,
            this.sortZAToolStripMenuItem});
            this.mnsMenuLoadSort.Name = "mnsMenuLoadSort";
            this.mnsMenuLoadSort.Size = new System.Drawing.Size(103, 21);
            this.mnsMenuLoadSort.Text = "Load and Sort";
            this.mnsMenuLoadSort.Click += new System.EventHandler(this.lbxCreatures_SelectedIndexChanged);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // sortAZToolStripMenuItem
            // 
            this.sortAZToolStripMenuItem.Name = "sortAZToolStripMenuItem";
            this.sortAZToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sortAZToolStripMenuItem.Text = "Sort AZ";
            this.sortAZToolStripMenuItem.Click += new System.EventHandler(this.btnAZ_Click);
            // 
            // sortZAToolStripMenuItem
            // 
            this.sortZAToolStripMenuItem.Name = "sortZAToolStripMenuItem";
            this.sortZAToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sortZAToolStripMenuItem.Text = "Sort ZA";
            this.sortZAToolStripMenuItem.Click += new System.EventHandler(this.btnZA_Click);
            // 
            // mnsMenuSaveSearch
            // 
            this.mnsMenuSaveSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.mnsMenuSaveSearch.Name = "mnsMenuSaveSearch";
            this.mnsMenuSaveSearch.Size = new System.Drawing.Size(116, 21);
            this.mnsMenuSaveSearch.Text = "Save and Search";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.tbnSave_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(44, 17);
            this.tslStatus.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxOwner);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.gbxSearchSave);
            this.Controls.Add(this.gbxLoadSort);
            this.Controls.Add(this.mnsMenu);
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxLoadSort.ResumeLayout(false);
            this.gbxSearchSave.ResumeLayout(false);
            this.gbxSearchSave.PerformLayout();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLoadSort;
        private System.Windows.Forms.Button btnZA;
        private System.Windows.Forms.Button btnAZ;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lbxCreatures;
        private System.Windows.Forms.GroupBox gbxSearchSave;
        private System.Windows.Forms.ListBox lbxSearchResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxOwner;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem mnsMenuLoadSort;
        private System.Windows.Forms.ToolStripMenuItem sortAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortZAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsMenuSaveSearch;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.ToolTip ttpToolTips;
    }
}

