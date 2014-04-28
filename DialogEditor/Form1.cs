using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DialogEditor
{
    public enum dNodeType { root, displayText }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SaveFilePath = "";
            saveFileDialog1.Filter = "XML Files | *.xml";
            saveFileDialog1.DefaultExt = "xml";

            //Start the user with a root node
            convTree.Nodes.Add(new dialogTreeNode(dNodeType.root));
            convTree.Nodes[0].Text = "Conversation Root";

        }

        private string SaveFilePath;
        private string SaveFileName;

        private void addDisplayTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //We're adding a new Display Text node to the convTree
            TreeNode selectedNode = convTree.SelectedNode;
            dialogTreeNode dNode = (dialogTreeNode)selectedNode;
            dNodeDisplayText newNode = new dNodeDisplayText();


            newNode.Text = "[Display Text]";
            newNode.dispText = "";

            //if we're currently selecting a Display Text node then just place this node after
            //the current node, instead of as a child.
            if (dNode.sType == dNodeType.displayText)
                selectedNode.Parent.Nodes.Add(newNode);
            else
                selectedNode.Nodes.Add(newNode);
            
            selectedNode.Expand();
            
        }


        private void convTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            //if we didn't have anything selected (form just loaded) don't bother doing anything
            if (convTree.SelectedNode == null) return;

            //save what the user typed in the textbox, associate with the selected node
            dialogTreeNode dNode = (dialogTreeNode)convTree.SelectedNode;


            //based on what kind of node we have we'll save accordingly
            switch (dNode.sType)
            {
                case dNodeType.displayText:
                    dNodeDisplayText dispTextNode = (dNodeDisplayText)dNode;
                    dispTextNode.dispText = textBox1.Text;
                    if (textBox1.Text.Trim() != "")
                        dispTextNode.Text = textBox1.Text;
                    else
                        dispTextNode.Text = "[Display Text]";
                    break;
            }
            
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
                    dNodeDisplayText selectedNode = (dNodeDisplayText)convTree.SelectedNode;
                    textBox1.Text = selectedNode.dispText;

                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        


        private void saveFile(object sender, EventArgs e)
        {
            //if we don't already have a save path then get one
            if (SaveFilePath == "")
            {
                SaveFileAs(sender, e);
                return;
            }
            
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(SaveFilePath + SaveFileName,settings);
            writer.WriteStartDocument();

            //recursively go through the tree           


            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();


            statusStripLabel.Text = "File Saved to " + SaveFilePath + SaveFileName;
        }

        private void SaveFileAs(object sender, EventArgs e)
        {


            //Get the save path from them
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                string SavePathTemp = saveFileDialog1.FileName;
 
                //split the path and the filename into two separate strings
                string[] result;
                result = SavePathTemp.Split('\\');
                int dirCount = result.GetLength(0);

                for (int i = 0; i < dirCount - 1; i++)
                {
                    SaveFilePath += result[i];
                    SaveFilePath += '\\';
                }
                SaveFileName = result[dirCount - 1];

                
            }
            else //we clicked cancel on the save location
            {
                statusStripLabel.Text = "No path selected. Save operation canceled.";
                return;
            }

            saveFile(sender, e);
        }

    }


    public partial class dialogTreeNode : TreeNode
    {
        public dialogTreeNode(dNodeType type) { sType = type; }

        public dNodeType sType { get; set; } //sType will allow us to typecast to get all our info back
    }

    public class dNodeDisplayText : dialogTreeNode
    {
        public dNodeDisplayText() 
            : base(dNodeType.displayText) {}

        public string dispText
        { get; set; }

    }
}
