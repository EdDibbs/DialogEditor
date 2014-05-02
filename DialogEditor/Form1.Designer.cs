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
            this.contextStripTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDisplayTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDialogOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convTree = new System.Windows.Forms.TreeView();
            this.nodePropBox = new System.Windows.Forms.GroupBox();
            this.propTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.contextStripTree.SuspendLayout();
            this.nodePropBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveFile);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveFileAs);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.displayTextToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.displayTextToolStripMenuItem.Text = "Display Text";
            this.displayTextToolStripMenuItem.Click += new System.EventHandler(this.addDisplayTextToolStripMenuItem_Click);
            // 
            // dialogOptionToolStripMenuItem
            // 
            this.dialogOptionToolStripMenuItem.Name = "dialogOptionToolStripMenuItem";
            this.dialogOptionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dialogOptionToolStripMenuItem.Text = "Option";
            // 
            // contextStripTree
            // 
            this.contextStripTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDisplayTextToolStripMenuItem,
            this.addDialogOptionToolStripMenuItem});
            this.contextStripTree.Name = "contextMenuStrip1";
            this.contextStripTree.Size = new System.Drawing.Size(174, 48);
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
            this.addDialogOptionToolStripMenuItem.Click += new System.EventHandler(this.addDialogOptionToolStripMenuItem_Click);
            // 
            // convTree
            // 
            this.convTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convTree.ContextMenuStrip = this.contextStripTree;
            this.convTree.FullRowSelect = true;
            this.convTree.HideSelection = false;
            this.convTree.Location = new System.Drawing.Point(13, 28);
            this.convTree.Name = "convTree";
            this.convTree.Size = new System.Drawing.Size(713, 203);
            this.convTree.TabIndex = 2;
            this.convTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.convTree_BeforeSelect);
            this.convTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.convTree_AfterSelect);
            // 
            // nodePropBox
            // 
            this.nodePropBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nodePropBox.Controls.Add(this.propTextBox);
            this.nodePropBox.Location = new System.Drawing.Point(13, 238);
            this.nodePropBox.Name = "nodePropBox";
            this.nodePropBox.Size = new System.Drawing.Size(713, 100);
            this.nodePropBox.TabIndex = 3;
            this.nodePropBox.TabStop = false;
            this.nodePropBox.Text = "Properties";
            // 
            // propTextBox
            // 
            this.propTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propTextBox.Location = new System.Drawing.Point(7, 20);
            this.propTextBox.Multiline = true;
            this.propTextBox.Name = "propTextBox";
            this.propTextBox.Size = new System.Drawing.Size(700, 74);
            this.propTextBox.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(738, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 362);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.nodePropBox);
            this.Controls.Add(this.convTree);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextStripTree;
        private System.Windows.Forms.TreeView convTree;
        private System.Windows.Forms.ToolStripMenuItem addDisplayTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDialogOptionToolStripMenuItem;
        private System.Windows.Forms.GroupBox nodePropBox;
        private System.Windows.Forms.TextBox propTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
    }
}

