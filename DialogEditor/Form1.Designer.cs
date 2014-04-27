namespace DialogEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new System.Windows.Forms.Label();
            this.contextStripTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDisplayTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDialogOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convTree = new System.Windows.Forms.TreeView();
            this.nodePropBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.contextStripTree.SuspendLayout();
            this.nodePropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayTextToolStripMenuItem,
            this.dialogOptionToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // displayTextToolStripMenuItem
            // 
            this.displayTextToolStripMenuItem.Name = "displayTextToolStripMenuItem";
            this.displayTextToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.displayTextToolStripMenuItem.Text = "Display Text";
            // 
            // dialogOptionToolStripMenuItem
            // 
            this.dialogOptionToolStripMenuItem.Name = "dialogOptionToolStripMenuItem";
            this.dialogOptionToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.dialogOptionToolStripMenuItem.Text = "Option";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(2, 346);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(110, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status stuff goes here";
            // 
            // contextStripTree
            // 
            this.contextStripTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDisplayTextToolStripMenuItem,
            this.addDialogOptionToolStripMenuItem});
            this.contextStripTree.Name = "contextMenuStrip1";
            this.contextStripTree.Size = new System.Drawing.Size(174, 48);
            this.contextStripTree.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addDisplayTextToolStripMenuItem
            // 
            this.addDisplayTextToolStripMenuItem.Name = "addDisplayTextToolStripMenuItem";
            this.addDisplayTextToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addDisplayTextToolStripMenuItem.Text = "Add Display Text";
            this.addDisplayTextToolStripMenuItem.Click += new System.EventHandler(this.addDisplayTextToolStripMenuItem_Click);
            // 
            // addDialogOptionToolStripMenuItem
            // 
            this.addDialogOptionToolStripMenuItem.Name = "addDialogOptionToolStripMenuItem";
            this.addDialogOptionToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addDialogOptionToolStripMenuItem.Text = "Add Dialog Option";
            // 
            // convTree
            // 
            this.convTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convTree.ContextMenuStrip = this.contextStripTree;
            this.convTree.Location = new System.Drawing.Point(13, 28);
            this.convTree.Name = "convTree";
            this.convTree.Size = new System.Drawing.Size(713, 203);
            this.convTree.TabIndex = 2;
            this.convTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.convTree_AfterSelect);
            // 
            // nodePropBox
            // 
            this.nodePropBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nodePropBox.Controls.Add(this.textBox1);
            this.nodePropBox.Location = new System.Drawing.Point(13, 238);
            this.nodePropBox.Name = "nodePropBox";
            this.nodePropBox.Size = new System.Drawing.Size(713, 100);
            this.nodePropBox.TabIndex = 3;
            this.nodePropBox.TabStop = false;
            this.nodePropBox.Text = "Properties";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(700, 74);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 362);
            this.Controls.Add(this.nodePropBox);
            this.Controls.Add(this.convTree);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Text = "Conversation Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextStripTree.ResumeLayout(false);
            this.nodePropBox.ResumeLayout(false);
            this.nodePropBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialogOptionToolStripMenuItem;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip contextStripTree;
        private System.Windows.Forms.TreeView convTree;
        private System.Windows.Forms.ToolStripMenuItem addDisplayTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDialogOptionToolStripMenuItem;
        private System.Windows.Forms.GroupBox nodePropBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

