namespace VPC_GXT2Editor
{
    partial class Main
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
            this.itemView = new ComponentOwl.BetterListView.BetterListView();
            this.betterListViewColumnHeader2 = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
            this.betterListViewColumnHeader3 = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newB = new System.Windows.Forms.ToolStripMenuItem();
            this.openB = new System.Windows.Forms.ToolStripMenuItem();
            this.closeB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveB = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentB = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNewB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportB = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.itemView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemView
            // 
            this.itemView.Columns.Add(this.betterListViewColumnHeader2);
            this.itemView.Columns.Add(this.betterListViewColumnHeader3);
            this.itemView.ContextMenuStrip = this.contextMenuStrip1;
            this.itemView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemView.Enabled = false;
            this.itemView.FontItems = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemView.GridLines = ComponentOwl.BetterListView.BetterListViewGridLines.Grid;
            this.itemView.Location = new System.Drawing.Point(0, 29);
            this.itemView.MultiSelect = false;
            this.itemView.Name = "itemView";
            this.itemView.Size = new System.Drawing.Size(537, 388);
            this.itemView.TabIndex = 0;
            this.itemView.DoubleClick += new System.EventHandler(this.itemView_DoubleClick);
            // 
            // betterListViewColumnHeader2
            // 
            this.betterListViewColumnHeader2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterListViewColumnHeader2.Name = "betterListViewColumnHeader2";
            this.betterListViewColumnHeader2.Text = "Item Name";
            this.betterListViewColumnHeader2.Width = 173;
            // 
            // betterListViewColumnHeader3
            // 
            this.betterListViewColumnHeader3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterListViewColumnHeader3.Name = "betterListViewColumnHeader3";
            this.betterListViewColumnHeader3.Text = "Item Text";
            this.betterListViewColumnHeader3.Width = 346;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.removeItemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 78);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newB,
            this.openB,
            this.closeB,
            this.toolStripSeparator1,
            this.saveB,
            this.toolStripSeparator2,
            this.exportB});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newB
            // 
            this.newB.Name = "newB";
            this.newB.Size = new System.Drawing.Size(124, 26);
            this.newB.Text = "New";
            this.newB.Click += new System.EventHandler(this.newB_Click);
            // 
            // openB
            // 
            this.openB.Name = "openB";
            this.openB.Size = new System.Drawing.Size(124, 26);
            this.openB.Text = "Open";
            this.openB.Click += new System.EventHandler(this.openB_Click);
            // 
            // closeB
            // 
            this.closeB.Enabled = false;
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(124, 26);
            this.closeB.Text = "Close";
            this.closeB.Click += new System.EventHandler(this.closeB_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // saveB
            // 
            this.saveB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCurrentB,
            this.saveNewB});
            this.saveB.Enabled = false;
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(124, 26);
            this.saveB.Text = "Save..";
            // 
            // saveCurrentB
            // 
            this.saveCurrentB.Name = "saveCurrentB";
            this.saveCurrentB.Size = new System.Drawing.Size(161, 26);
            this.saveCurrentB.Text = "Current File";
            this.saveCurrentB.Click += new System.EventHandler(this.saveCurrentB_Click);
            // 
            // saveNewB
            // 
            this.saveNewB.Name = "saveNewB";
            this.saveNewB.Size = new System.Drawing.Size(161, 26);
            this.saveNewB.Text = "New File";
            this.saveNewB.Click += new System.EventHandler(this.saveNewB_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // exportB
            // 
            this.exportB.Enabled = false;
            this.exportB.Name = "exportB";
            this.exportB.Size = new System.Drawing.Size(124, 26);
            this.exportB.Text = "Export";
            this.exportB.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.removeItemToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 417);
            this.Controls.Add(this.itemView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "VPC GXT2 Editor";
            ((System.ComponentModel.ISupportInitialize)(this.itemView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentOwl.BetterListView.BetterListView itemView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newB;
        private System.Windows.Forms.ToolStripMenuItem openB;
        private System.Windows.Forms.ToolStripMenuItem closeB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveB;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentB;
        private System.Windows.Forms.ToolStripMenuItem saveNewB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportB;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private ComponentOwl.BetterListView.BetterListViewColumnHeader betterListViewColumnHeader2;
        private ComponentOwl.BetterListView.BetterListViewColumnHeader betterListViewColumnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
    }
}

