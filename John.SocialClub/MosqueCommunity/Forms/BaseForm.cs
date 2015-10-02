using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MosqueCommunity.Forms;
using MosqueCommunity.GroupBox_Control_Container;

namespace MosqueCommunity
{
    public partial class BaseForm : Form
    {
        grpbxMembers grpbxMembers1;
        grpbxRegisterMembers gpbxRegisterMembers1;
        grpbxReportMembers grpbxReportMembers1;

        private MosqueForm myMosqueForm;
        private Form MosqueCouncil;
        private Form PrayerCommunity;
        private Form Madrasah;
        private Form MosqueFinance;
        private Form Deceised;
        List<Form> myForms;

        public Dictionary<TreeNode, GroupBox> showControls;
        public BaseForm()
        {
            InitializeComponent();
            showControls = new Dictionary<TreeNode, GroupBox>();
            
            grpbxReportMembers1 = new grpbxReportMembers(this);
            grpbxMembers1 = new grpbxMembers(this);
            gpbxRegisterMembers1 = new grpbxRegisterMembers(this);
            InitializeDictionary();

            myMosqueForm = new MosqueForm();
            myForms = new List<Form> { (Form) myMosqueForm};
        }

        public void HideAllForms()
        {
            //Form form;
            foreach(Form form in myForms)
                form.Hide();
        }
        //public Form1()
        //{
        //    InitializeComponent();
        //    showControls = new Dictionary<TreeNode, GroupBox>();

        //    grpbxMembers1 = new grpbxMembers(this);
        //    InitializeDictionary();
        //}

        //public Form1()
        //{
        //    InitializeComponent();
        //    showControls = new Dictionary<TreeNode, GroupBox>();

        //    gpbxRegisterMembers1 = new grpbxRegisterMembers(this);
        //    InitializeDictionary();
        //}

        private void InitializeDictionary()
        {

            // Add some elements to the dictionary. There are no  
            // duplicate keys, but some of the values are duplicates.
            this.showControls.Add(this.trvwMainTree.Nodes.Find("ndRegister", true)[0], this.grpbxRegisterMembers);
            this.showControls.Add(this.trvwMainTree.Nodes.Find("ndReport", true)[0], this.grpbxReportMembers);
            this.showControls.Add(this.trvwMainTree.Nodes.Find("ndMember", true)[0], this.grpbxMembers);
        }

        //private void trvwMainTree_Click(object sender, EventArgs e)
        //{
        //    //if (trvwMainTree.SelectedNode.Name == "Members") 
        //    ShowContainerFromDictionary(trvwMainTree.SelectedNode);
        //}
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

            // When you use foreach to enumerate dictionary elements, 
            // the elements are retrieved as KeyValuePair objects.
            foreach (KeyValuePair<TreeNode, GroupBox> kvp in showControls)
            {
                kvp.Value.Hide();
                if (kvp.Key == Node)
                    kvp.Value.Show();
            }

           
        }
        private void trvwMainTree_AfterSelect(object sender, EventArgs e)
        {
            //if (trvwMainTree.SelectedNode.Name == "Members") 
            ShowContainerFromDictionary(trvwMainTree.SelectedNode);
        }

        private void grpbxRegisterMembers_Enter(object sender, EventArgs e)
        {

        }
        private void grpbxMembers_Enter(Object sender, EventArgs m)
        {

        }

        private void grpbxReportMembers_Enter(Object sender, EventArgs r)
        {
        
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trvwMainTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            HideAllForms();
            var selected = listView1.SelectedItems[0];
            
           switch (selected.Text)
           {
               case "Mosque":
                   if (myMosqueForm.IsDisposed)
                        myMosqueForm = new MosqueForm();
                
                        myMosqueForm.Show(); 
                        break;
               //case "Madrasah":
                        //if (myMosqueForm.IsDisposed)
                            //myMosqueForm = new MosqueForm();

                        //myMosqueForm.Show();
                        //break;
           }


            

        }
    }

}
