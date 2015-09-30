using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MosqueCommunity
{
    public partial class Form1 : Form
    {
        Dictionary<TreeNode, GroupBox> showControls;
        public Form1()
        {
            InitializeComponent();
            showControls = new Dictionary<TreeNode, GroupBox>();
            InitializeDictionary();
        }

        private void InitializeDictionary()
        {

            // Add some elements to the dictionary. There are no  
            // duplicate keys, but some of the values are duplicates.
            this.showControls.Add(this.trvwMainTree.Nodes.Find("ndRegister", true)[0], this.grpbxRegisterMembers);
            this.showControls.Add(this.trvwMainTree.Nodes.Find("ndReport", true)[0], this.grpbxReportMembers);
            this.showControls.Add(this.trvwMainTree.Nodes.Find("ndMember", true)[0], this.grpbxMembers);
        }

        private void trvwMainTree_Click(object sender, EventArgs e)
        {
            //if (trvwMainTree.SelectedNode.Name == "Members") 
            ShowContainerFromDictionary(trvwMainTree.SelectedNode);
        }
        private void ShowContainer (String Name)
        {
            grpbxMembers.Hide();
            grpbxRegisterMembers.Hide();
            grpbxReportMembers.Hide();

            switch (Name)
            {
                case "Members":
                    grpbxMembers.Show();
                    break;
                case "Register":
                    grpbxRegisterMembers.Show();
                    break;
                case "Report":
                    grpbxReportMembers.Show();
                    break;
                default:
                    grpbxReportMembers.Show();
                    break;  
            }
        }
        private void ShowContainerFromDictionary(TreeNode Node)
        {
            //grpbxMembers.Hide();
            //grpbxRegisterMembers.Hide();
            //grpbxReportMembers.Hide();

            // When you use foreach to enumerate dictionary elements, 
            // the elements are retrieved as KeyValuePair objects.
            foreach (KeyValuePair<TreeNode, GroupBox> kvp in showControls)
            {
                kvp.Value.Hide();
                if (kvp.Key == Node)
                    kvp.Value.Show();
            }

           
        }

        private void trvwMainTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void grpbxRegisterMembers_Enter(object sender, EventArgs e)
        {

        }

        private void ribbon1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonButton_form1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(StudentsForm))
                {
                    f.Activate();
                    return;
                }
            }
            Form studentsForm = new StudentsForm();
            studentsForm.MdiParent = this;
            studentsForm.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
