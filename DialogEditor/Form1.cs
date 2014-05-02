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
    public enum dNodeType { root, displayText, responseContainer, userResponse}

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


            switch (dNode.sType)
            { 

                case dNodeType.displayText:
                    //if we're currently selecting a Display Text node then just place this node after
                    //the current node, instead of as a child.
                    selectedNode.Parent.Nodes.Add(newNode);
                    break;

                case dNodeType.responseContainer:
                    //we shouldn't be adding anything to this node
                    statusStripLabel.Text = "Can't add items other than options to an option container.";
                    return;
                    break;

                default:
                    selectedNode.Nodes.Add(newNode);
                    break;
            }

            selectedNode.Expand();
            convTree.SelectedNode = newNode;
            
        }

        private void addDialogOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = convTree.SelectedNode;
            dialogTreeNode dNode = (dialogTreeNode)selectedNode;

            //add a container for our responses if we don't already have one
            switch (dNode.sType)
            {
                case dNodeType.responseContainer:
                    //we don't need to do anything extra
                    break;
                case dNodeType.userResponse:
                    //we need to select the parent (the response container node) first
                    selectedNode = selectedNode.Parent;
                    break;


                default:
                    //if we had a display text node, we need to selecte the parent before
                    //making the response container
                    if (dNode.sType == dNodeType.displayText) selectedNode = selectedNode.Parent;

                    //we need to make a response container first
                    dialogTreeNode container = new dialogTreeNode(dNodeType.responseContainer);
                    container.Text = "[Display Options]";
                    selectedNode.Nodes.Add(container);
                    selectedNode.Expand();
                    selectedNode = container;
                    break;
            }

            //add a dialog option now
            dNodeUserResponse responseNode = new dNodeUserResponse();
            //responseNode.NodeFont = new Font(SystemFonts.DefaultFont, FontStyle.Bold);
            int index = selectedNode.Nodes.Add(responseNode);
            selectedNode.Expand();
            convTree.SelectedNode = selectedNode.Nodes[index];
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
                    dispTextNode.dispText = propTextBox.Text;

                    //if the text box is empty, we'll set the treeview text to default
                    //otherwise we'll set it to what the response is
                    if (propTextBox.Text.Trim() != "")
                        dispTextNode.Text = propTextBox.Text;
                    else
                        dispTextNode.Text = "[Display Text]";
                    break;

                case dNodeType.userResponse:
                    dNodeUserResponse responseNode = (dNodeUserResponse)dNode;
                    responseNode.responseText = propTextBox.Text;
                    if (propTextBox.Text.Trim() != "")
                        responseNode.Text = propTextBox.Text;
                    else
                        responseNode.Text = "[User Response]";
                    break;
            }
            
        }


        private void convTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //after we change focus in our convTree we need to clean up a bit
            propTextBox.Clear();
            dialogTreeNode dNode = (dialogTreeNode)convTree.SelectedNode;

            //based on what kind of node we have, change our display accordingly
            switch (dNode.sType)
            {
                case dNodeType.displayText:
                    dNodeDisplayText dispText = (dNodeDisplayText)convTree.SelectedNode;
                    propTextBox.Text = dispText.dispText;
                    nodePropBox.Text = "NPC Text";
                    propTextBox.Show();
                    break;

                case dNodeType.userResponse:
                    dNodeUserResponse userResponse = (dNodeUserResponse)convTree.SelectedNode;
                    propTextBox.Text = userResponse.responseText;
                    nodePropBox.Text = "Player Response Text";
                    propTextBox.Show();
                    break;

                case dNodeType.root:
                    propTextBox.Hide();
                    nodePropBox.Text = "";
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
            SaveNode(ref writer, convTree.Nodes[0]);

            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();


            statusStripLabel.Text = "File Saved to " + SaveFilePath + SaveFileName;
        }

        private void SaveNode(ref XmlWriter writer, TreeNode node)
        {
            //we will loop through the tree using Depth First Search
            dialogTreeNode dNode = (dialogTreeNode)node;

            //print the start element e.g. <text>
            switch (dNode.sType)
            {
                case dNodeType.root:
                    writer.WriteStartElement("conversation");
                    break;

                case dNodeType.displayText:
                    writer.WriteStartElement("text");
                    break;

                case dNodeType.responseContainer:
                    writer.WriteStartElement("option_container");
                    break;

                case dNodeType.userResponse:
                    string responseText = ((dNodeUserResponse)dNode).responseText;
                    writer.WriteStartElement("option");
                    writer.WriteAttributeString("text", responseText);
                    break;

            }

            //go deeper if we need to
            if (node.Nodes != null)
                foreach (TreeNode childNode in node.Nodes)
                {
                    SaveNode(ref writer, childNode);
                }

            //print the content and end the element e.g. "foobar"<\text>
            switch (dNode.sType)
            {
                case dNodeType.root:
                    writer.WriteEndElement();
                    break;

                case dNodeType.displayText:
                    string text = ((dNodeDisplayText)dNode).dispText;
                    writer.WriteRaw("\"" + text + "\"");
                    writer.WriteEndElement();
                    break;

                case dNodeType.responseContainer:
                    writer.WriteEndElement();
                    break;

                case dNodeType.userResponse:
                    //don't need to do anything else
                    writer.WriteEndElement();
                    break;
            }


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
            : base(dNodeType.displayText) { dispText = ""; Text = "[Display Text]"; }

        public string dispText  { get; set; }

    }

    public class dNodeUserResponse : dialogTreeNode
    {
        public dNodeUserResponse()
            : base(dNodeType.userResponse) { responseText = ""; Text = "[User Response]"; }

        public string responseText { get; set; }
    }

}
