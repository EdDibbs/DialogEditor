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
            //We're adding a new Display Text node to the convTree
            TreeNode selectedNode = convTree.SelectedNode;
            dialogTreeDisplayText newNode = new dialogTreeDisplayText();


            newNode.Text = "Display Text";
            newNode.dispText = "123";
            selectedNode.Nodes.Add(newNode);
            
            selectedNode.Expand();
            
        }


        private void convTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            //save what the user typed in the textbox, associate with the selected node

        }


        private void convTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //after we change focus in our convTree we need to clean up a bit
            textBox1.Clear();
            dialogTreeNode dNode = (dialogTreeNode)convTree.SelectedNode;

            //based on what kind of node we have, change our display accordingly
            switch (dNode.sType)
            {
                case dNodeType.displayText:
                    dialogTreeDisplayText selectedNode = (dialogTreeDisplayText)convTree.SelectedNode;
                    textBox1.Text = selectedNode.dispText;
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Start the user with a root node
            convTree.Nodes.Add(new dialogTreeNode(dNodeType.root));
            convTree.Nodes[0].Text = "Conversation Root";
        }




    }


    public partial class dialogTreeNode : TreeNode
    {
        public dialogTreeNode(dNodeType type) { sType = type; }

        public dNodeType sType { get; set; } //sType will allow us to typecast to get all our info back
    }

    public class dialogTreeDisplayText : dialogTreeNode
    {
        public dialogTreeDisplayText() 
            : base(dNodeType.displayText) {}

        public string dispText
        { get; set; }

    }
}
