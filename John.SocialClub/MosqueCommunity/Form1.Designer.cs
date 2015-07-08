using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace MosqueCommunity
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
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Register");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Report");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Members", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Friday Preaches");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Compose Preach");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Hadith Pool");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Preaching", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Purchases");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Due Payments");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Balance Sheet");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("General Report");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Accounting", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Start", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode20,
            treeNode25});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trvwMainTree = new System.Windows.Forms.TreeView();
            this.imgLstTreeview = new System.Windows.Forms.ImageList(this.components);
            this.grpbxMembers = new System.Windows.Forms.GroupBox();
            this.grpbxRegisterMembers = new System.Windows.Forms.GroupBox();
            this.grpbxReportMembers = new System.Windows.Forms.GroupBox();
            this.grpbxRegisterMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvwMainTree
            // 
            this.trvwMainTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trvwMainTree.ImageIndex = 0;
            this.trvwMainTree.ImageList = this.imgLstTreeview;
            this.trvwMainTree.Location = new System.Drawing.Point(34, 32);
            this.trvwMainTree.Name = "trvwMainTree";
            treeNode14.Name = "ndRegister";
            treeNode14.Text = "Register";
            treeNode15.Name = "ndReport";
            treeNode15.Text = "Report";
            treeNode16.Name = "ndMember";
            treeNode16.Text = "Members";
            treeNode17.Name = "ndFridayPreaches";
            treeNode17.Text = "Friday Preaches";
            treeNode18.Name = "ndComposePreach";
            treeNode18.Text = "Compose Preach";
            treeNode19.Name = "ndHadithPool";
            treeNode19.Text = "Hadith Pool";
            treeNode20.Name = "ndPreach";
            treeNode20.Text = "Preaching";
            treeNode21.Name = "ndPurchases";
            treeNode21.Text = "Purchases";
            treeNode22.Name = "ndPayments";
            treeNode22.Text = "Due Payments";
            treeNode23.Name = "ndBalanceSheet";
            treeNode23.Text = "Balance Sheet";
            treeNode24.Name = "ndGeneralReport";
            treeNode24.Text = "General Report";
            treeNode25.Name = "ndAccounting";
            treeNode25.Text = "Accounting";
            treeNode26.Name = "ndStart";
            treeNode26.Text = "Start";
            this.trvwMainTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26});
            this.trvwMainTree.SelectedImageIndex = 0;
            this.trvwMainTree.Size = new System.Drawing.Size(357, 531);
            this.trvwMainTree.TabIndex = 0;
            this.trvwMainTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvwMainTree_AfterSelect);
            this.trvwMainTree.Click += new System.EventHandler(this.trvwMainTree_Click);
            // 
            // imgLstTreeview
            // 
            this.imgLstTreeview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstTreeview.ImageStream")));
            this.imgLstTreeview.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstTreeview.Images.SetKeyName(0, "Folder.jpg");
            // 
            // grpbxMembers
            // 
            this.grpbxMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxMembers.Location = new System.Drawing.Point(397, 30);
            this.grpbxMembers.Name = "grpbxMembers";
            this.grpbxMembers.Size = new System.Drawing.Size(722, 437);
            this.grpbxMembers.TabIndex = 1;
            this.grpbxMembers.TabStop = false;
            this.grpbxMembers.Text = "Members";
            // 
            // grpbxRegisterMembers
            // 
            this.grpbxRegisterMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxRegisterMembers.Controls.Add(this.grpbxReportMembers);
            this.grpbxRegisterMembers.Location = new System.Drawing.Point(397, 31);
            this.grpbxRegisterMembers.Name = "grpbxRegisterMembers";
            this.grpbxRegisterMembers.Size = new System.Drawing.Size(722, 437);
            this.grpbxRegisterMembers.TabIndex = 2;
            this.grpbxRegisterMembers.TabStop = false;
            this.grpbxRegisterMembers.Text = "Register Members";
            this.grpbxRegisterMembers.Enter += new System.EventHandler(this.grpbxRegisterMembers_Enter);
            // 
            // grpbxReportMembers
            // 
            this.grpbxReportMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxReportMembers.Location = new System.Drawing.Point(0, 1);
            this.grpbxReportMembers.Name = "grpbxReportMembers";
            this.grpbxReportMembers.Size = new System.Drawing.Size(722, 531);
            this.grpbxReportMembers.TabIndex = 3;
            this.grpbxReportMembers.TabStop = false;
            this.grpbxReportMembers.Text = "Report Members";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 593);
            this.Controls.Add(this.grpbxRegisterMembers);
            this.Controls.Add(this.grpbxMembers);
            this.Controls.Add(this.trvwMainTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Community Software";
            this.grpbxRegisterMembers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.TreeView trvwMainTree;
        private System.Windows.Forms.GroupBox grpbxMembers;
        private System.Windows.Forms.GroupBox grpbxRegisterMembers;
        private System.Windows.Forms.GroupBox grpbxReportMembers;
        private System.Windows.Forms.ImageList imgLstTreeview;
    }
}

