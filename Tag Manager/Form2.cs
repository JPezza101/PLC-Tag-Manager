using libplctag.DataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tag_Manager
{
    public partial class Form2 : Form
    {
        Form1 mainForm;
        TreeView unfilteredTagList = new TreeView();

        public Form2(Form1 incomingForm)
        {
            mainForm = incomingForm;
            InitializeComponent();
        }

        private void LoadTagList()
        {
            var fullTagList = Mappers.ReadControllerTagInfo();

            foreach (var tag in fullTagList)
            {
                int colonIndex = tag.Name.IndexOf(':');
                
                if (colonIndex > 0)
                {
                    string nonTagIndicator = tag.Name.Substring(0, colonIndex);
                    if (nonTagIndicator == "Program")
                    {
                        treeView1.Nodes.Add(tag.Name);
                        unfilteredTagList.Nodes.Add(tag.Name);

                        var programTags = Mappers.ReadProgramTagInfo(tag.Name);
                        foreach (var subtag in programTags)
                        {
                            if (!subtag.Name.Contains(':'))
                            {
                                treeView1.Nodes[treeView1.GetNodeCount(false) - 1].Nodes.Add(tag.Name + '.' + subtag.Name);
                                unfilteredTagList.Nodes[treeView1.GetNodeCount(false) - 1].Nodes.Add(tag.Name + "." + subtag.Name);
                            }
                        }
                    }
                }
                else
                {
                    treeView1.Nodes.Add(tag.Name);
                    unfilteredTagList.Nodes.Add(tag.Name);
                }
            }
            treeView1.Sort();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadTagList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReadTags_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectTag_Click(object sender, EventArgs e)
        {
            mainForm.enteredTagName = treeView1.SelectedNode.Text;
            mainForm.populateFormSelectedTag();
            this.Close();
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            mainForm.enteredTagName = treeView1.SelectedNode.Text;
            mainForm.populateFormSelectedTag();
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search tags...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Search tags...";
                textBox1.ForeColor = Color.Gray;
                foreach (TreeNode node in unfilteredTagList.Nodes)
                {
                    treeView1.Nodes.Add(node.Text);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || textBox1.Text != "")
            {
                treeView1.Nodes.Clear();

                foreach (TreeNode node in unfilteredTagList.Nodes)
                {
                    if (node.Text.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        treeView1.Nodes.Add(node.Text);
                    }
                }
            }            
        }
    }
}
