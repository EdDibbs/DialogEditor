using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogEditor
{
    public enum dNodeType { root, displayText }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void addDisplayTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = convTree.SelectedNode;
            dialogTreeDisplayText newNode = new dialogTreeDisplayText();
            newNode.Text = "Display Text";
            newNode.dispText = "123";
            selectedNode.Nodes.Add(newNode);
            
            selectedNode.Expand();
            
        }

        private void convTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Clear();
            dialogTreeNode dNode = (dialogTreeNode)convTree.SelectedNode;
            if (dNode.sType == dNodeType.displayText)
            {
                dialogTreeDisplayText selectedNode = (dialogTreeDisplayText)convTree.SelectedNode;
                textBox1.Text = selectedNode.dispText;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            convTree.Nodes.Add(new dialogTreeNode(dNodeType.root));
            convTree.Nodes[0].Text = "Conversation Root";
        }


    }


    public partial class dialogTreeNode : TreeNode
    {
        public dialogTreeNode(dNodeType type) { sType = type; }

        public dNodeType sType { get; set; }
    }

    public class dialogTreeDisplayText : dialogTreeNode
    {
        public dialogTreeDisplayText() 
            : base(dNodeType.displayText) {}

        public string dispText
        {
            get;
            set;
        }

    }
}
