using libplctag.DataTypes;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

                        var programTags = Mappers.ReadProgramTagInfo(tag.Name);
                        foreach (var subtag in programTags)
                        {
                            if (!subtag.Name.Contains(':'))
                            {
                                treeView1.Nodes[treeView1.GetNodeCount(false) - 1].Nodes.Add(tag.Name + '.' + subtag.Name);
                            }
                        }
                    }
                }
                else
                {
                    treeView1.Nodes.Add(tag.Name);
                }
            }
            treeView1.Sort();

            //Copy tag list into a backup TreeView to refresh complete list without rescanning tags
            foreach (TreeNode node in treeView1.Nodes)
            {
                unfilteredTagList.Nodes.Add((TreeNode)node.Clone());
            }

        }
        public delegate void FunctionDelegate();

        private void Form2_Load(object sender, EventArgs e)
        {
            treeView1.BeginInvoke(new FunctionDelegate(LoadTagList));

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
            if (textBox1.Text == "" || textBox1.Text == string.Empty)
            {
                textBox1.Text = "Search tags...";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox1.Text != "" && textBox1.Text != "Search tags...")
            {
                treeView1.Nodes.Clear();

                for (int i = 0; i < unfilteredTagList.GetNodeCount(false); i++)
                {
                    if (unfilteredTagList.Nodes[i].ToString().Contains("Program:"))
                    {
                        bool parentNodeAdded = false;
                        for (int j = 0; j < unfilteredTagList.Nodes[i].GetNodeCount(false); j++)
                        {
                            string nodeString = unfilteredTagList.Nodes[i].Nodes[j].Text;
                            string nodeSubstring = nodeString.Substring(nodeString.LastIndexOf('.') + 1);
                            if (nodeSubstring.ToLower().Contains(textBox1.Text.ToLower()))
                            {
                                if (!parentNodeAdded)
                                {
                                    treeView1.Nodes.Add(unfilteredTagList.Nodes[i].Text);
                                    parentNodeAdded = true;
                                }
                                treeView1.Nodes[treeView1.GetNodeCount(false) - 1].Nodes.Add((TreeNode)unfilteredTagList.Nodes[i].Nodes[j].Clone());
                            }
                        }
                    }
                    else
                    {
                        if (unfilteredTagList.Nodes[i].ToString().ToLower().Contains(textBox1.Text.ToLower()))
                        {
                            treeView1.Nodes.Add((TreeNode)unfilteredTagList.Nodes[i].Clone());
                        }
                    }
                }
            }
            else
            {
                treeView1.Nodes.Clear();
                foreach (TreeNode node in unfilteredTagList.Nodes)
                {
                    treeView1.Nodes.Add((TreeNode)node.Clone());
                }
            }
        }
    }
}
