using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace MosqueCommunity
{
    partial class MainMDIForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Register");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Report");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Members", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Friday Preaches");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Compose Preach");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Hadith Pool");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Preaching", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Purchases");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Due Payments");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Balance Sheet");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("General Report");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Accounting", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Start", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7,
            treeNode12});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMDIForm));
            this.trvwMainTree = new System.Windows.Forms.TreeView();
            this.imgLstTreeview = new System.Windows.Forms.ImageList(this.components);
            this.grpbxMembers = new System.Windows.Forms.GroupBox();
            this.grpbxRegisterMembers = new System.Windows.Forms.GroupBox();
            this.grpbxReportMembers = new System.Windows.Forms.GroupBox();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonSeparator2 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonSeparator3 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonOrbOptionButton1 = new System.Windows.Forms.RibbonOrbOptionButton();
            this.ribbonOrbRecentItem1 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.ribbonOrbRecentItem2 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.ribbonOrbRecentItem3 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonStudentsButton = new System.Windows.Forms.RibbonButton();
            this.ribbonTeachersButton = new System.Windows.Forms.RibbonButton();
            this.ribbonParentsButton = new System.Windows.Forms.RibbonButton();
            this.ribbonLessonsButton = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
            this.ribbonComboBox1 = new System.Windows.Forms.RibbonComboBox();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.ribbonCheckBox1 = new System.Windows.Forms.RibbonCheckBox();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.grpbxRegisterMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvwMainTree
            // 
            this.trvwMainTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trvwMainTree.ImageIndex = 0;
            this.trvwMainTree.ImageList = this.imgLstTreeview;
            this.trvwMainTree.Location = new System.Drawing.Point(15, 197);
            this.trvwMainTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trvwMainTree.Name = "trvwMainTree";
            treeNode1.Name = "ndRegister";
            treeNode1.Text = "Register";
            treeNode2.Name = "ndReport";
            treeNode2.Text = "Report";
            treeNode3.Name = "ndMember";
            treeNode3.Text = "Members";
            treeNode4.Name = "ndFridayPreaches";
            treeNode4.Text = "Friday Preaches";
            treeNode5.Name = "ndComposePreach";
            treeNode5.Text = "Compose Preach";
            treeNode6.Name = "ndHadithPool";
            treeNode6.Text = "Hadith Pool";
            treeNode7.Name = "ndPreach";
            treeNode7.Text = "Preaching";
            treeNode8.Name = "ndPurchases";
            treeNode8.Text = "Purchases";
            treeNode9.Name = "ndPayments";
            treeNode9.Text = "Due Payments";
            treeNode10.Name = "ndBalanceSheet";
            treeNode10.Text = "Balance Sheet";
            treeNode11.Name = "ndGeneralReport";
            treeNode11.Text = "General Report";
            treeNode12.Name = "ndAccounting";
            treeNode12.Text = "Accounting";
            treeNode13.Name = "ndStart";
            treeNode13.Text = "Start";
            this.trvwMainTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.trvwMainTree.SelectedImageIndex = 0;
            this.trvwMainTree.Size = new System.Drawing.Size(357, 382);
            this.trvwMainTree.TabIndex = 0;
            this.trvwMainTree.Visible = false;
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
            this.grpbxMembers.Location = new System.Drawing.Point(397, 231);
            this.grpbxMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxMembers.Name = "grpbxMembers";
            this.grpbxMembers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxMembers.Size = new System.Drawing.Size(723, 297);
            this.grpbxMembers.TabIndex = 1;
            this.grpbxMembers.TabStop = false;
            this.grpbxMembers.Text = "Members";
            this.grpbxMembers.Visible = false;
            // 
            // grpbxRegisterMembers
            // 
            this.grpbxRegisterMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxRegisterMembers.Controls.Add(this.grpbxReportMembers);
            this.grpbxRegisterMembers.Location = new System.Drawing.Point(392, 256);
            this.grpbxRegisterMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxRegisterMembers.Name = "grpbxRegisterMembers";
            this.grpbxRegisterMembers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxRegisterMembers.Size = new System.Drawing.Size(723, 277);
            this.grpbxRegisterMembers.TabIndex = 2;
            this.grpbxRegisterMembers.TabStop = false;
            this.grpbxRegisterMembers.Text = "Register Members";
            this.grpbxRegisterMembers.Visible = false;
            this.grpbxRegisterMembers.Enter += new System.EventHandler(this.grpbxRegisterMembers_Enter);
            // 
            // grpbxReportMembers
            // 
            this.grpbxReportMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxReportMembers.Location = new System.Drawing.Point(0, 38);
            this.grpbxReportMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxReportMembers.Name = "grpbxReportMembers";
            this.grpbxReportMembers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxReportMembers.Size = new System.Drawing.Size(723, 334);
            this.grpbxReportMembers.TabIndex = 3;
            this.grpbxReportMembers.TabStop = false;
            this.grpbxReportMembers.Text = "Report Members";
            this.grpbxReportMembers.Visible = false;
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ribbon1.OrbDropDown.BackgroundImage")));
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem1);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSeparator1);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem2);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSeparator2);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSeparator3);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.OptionItems.Add(this.ribbonOrbOptionButton1);
            this.ribbon1.OrbDropDown.RecentItems.Add(this.ribbonOrbRecentItem1);
            this.ribbon1.OrbDropDown.RecentItems.Add(this.ribbonOrbRecentItem2);
            this.ribbon1.OrbDropDown.RecentItems.Add(this.ribbonOrbRecentItem3);
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 169);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton1);
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton2);
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1131, 185);
            this.ribbon1.TabIndex = 3;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "Mosque";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "New";
            // 
            // ribbonOrbMenuItem2
            // 
            this.ribbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.Image")));
            this.ribbonOrbMenuItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.SmallImage")));
            this.ribbonOrbMenuItem2.Text = "Print to PDF";
            // 
            // ribbonOrbOptionButton1
            // 
            this.ribbonOrbOptionButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.Image")));
            this.ribbonOrbOptionButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.SmallImage")));
            this.ribbonOrbOptionButton1.Text = "Select Mosque";
            // 
            // ribbonOrbRecentItem1
            // 
            this.ribbonOrbRecentItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.Image")));
            this.ribbonOrbRecentItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.SmallImage")));
            this.ribbonOrbRecentItem1.Text = "Export database";
            // 
            // ribbonOrbRecentItem2
            // 
            this.ribbonOrbRecentItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem2.Image")));
            this.ribbonOrbRecentItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem2.SmallImage")));
            this.ribbonOrbRecentItem2.Text = "Import from Excel";
            // 
            // ribbonOrbRecentItem3
            // 
            this.ribbonOrbRecentItem3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem3.Image")));
            this.ribbonOrbRecentItem3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem3.SmallImage")));
            this.ribbonOrbRecentItem3.Text = "Synchronze with server";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "ribbonButton2";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Units";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.ribbonStudentsButton);
            this.ribbonPanel1.Items.Add(this.ribbonTeachersButton);
            this.ribbonPanel1.Items.Add(this.ribbonParentsButton);
            this.ribbonPanel1.Items.Add(this.ribbonLessonsButton);
            this.ribbonPanel1.Text = "Madrasah";
            // 
            // ribbonStudentsButton
            // 
            this.ribbonStudentsButton.Image = ((System.Drawing.Image)(resources.GetObject("ribbonStudentsButton.Image")));
            this.ribbonStudentsButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonStudentsButton.SmallImage")));
            this.ribbonStudentsButton.Text = "Students";
            this.ribbonStudentsButton.Click += new System.EventHandler(this.ribbonStudentsButton_Click);
            // 
            // ribbonTeachersButton
            // 
            this.ribbonTeachersButton.Image = ((System.Drawing.Image)(resources.GetObject("ribbonTeachersButton.Image")));
            this.ribbonTeachersButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonTeachersButton.SmallImage")));
            this.ribbonTeachersButton.Text = "Teachers";
            this.ribbonTeachersButton.Click += new System.EventHandler(this.ribbonTeachersButton_Click);
            // 
            // ribbonParentsButton
            // 
            this.ribbonParentsButton.Image = ((System.Drawing.Image)(resources.GetObject("ribbonParentsButton.Image")));
            this.ribbonParentsButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonParentsButton.SmallImage")));
            this.ribbonParentsButton.Text = "Parents";
            this.ribbonParentsButton.Click += new System.EventHandler(this.ribbonParentsButton_Click);
            // 
            // ribbonLessonsButton
            // 
            this.ribbonLessonsButton.Image = ((System.Drawing.Image)(resources.GetObject("ribbonLessonsButton.Image")));
            this.ribbonLessonsButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonLessonsButton.SmallImage")));
            this.ribbonLessonsButton.Text = "Lessons";
            this.ribbonLessonsButton.Click += new System.EventHandler(this.ribbonLessonsButton_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Text = "Prayers";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Panels.Add(this.ribbonPanel3);
            this.ribbonTab2.Panels.Add(this.ribbonPanel4);
            this.ribbonTab2.Text = "Activities";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.ribbonButton5);
            this.ribbonPanel3.Items.Add(this.ribbonButton6);
            this.ribbonPanel3.Items.Add(this.ribbonButton7);
            this.ribbonPanel3.Items.Add(this.ribbonComboBox1);
            this.ribbonPanel3.Text = "Membership";
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.Image")));
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Text = "New Member";
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.Image")));
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            this.ribbonButton6.Text = "Active Members";
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.Image")));
            this.ribbonButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.SmallImage")));
            this.ribbonButton7.Text = "Event";
            // 
            // ribbonComboBox1
            // 
            this.ribbonComboBox1.TextBoxText = "";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Text = "Zakat";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            // 
            // MainMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1131, 593);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.grpbxRegisterMembers);
            this.Controls.Add(this.grpbxMembers);
            this.Controls.Add(this.trvwMainTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMDIForm";
            this.Text = "Community Software";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.grpbxRegisterMembers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.TreeView trvwMainTree;
        private System.Windows.Forms.GroupBox grpbxMembers;
        private System.Windows.Forms.GroupBox grpbxRegisterMembers;
        private System.Windows.Forms.GroupBox grpbxReportMembers;
        private System.Windows.Forms.ImageList imgLstTreeview;
        private Ribbon ribbon1;
        private RibbonOrbMenuItem ribbonOrbMenuItem1;
        private RibbonSeparator ribbonSeparator1;
        private RibbonOrbMenuItem ribbonOrbMenuItem2;
        private RibbonOrbOptionButton ribbonOrbOptionButton1;
        private RibbonOrbRecentItem ribbonOrbRecentItem1;
        private RibbonOrbRecentItem ribbonOrbRecentItem2;
        private RibbonOrbRecentItem ribbonOrbRecentItem3;
        private RibbonButton ribbonButton1;
        private RibbonButton ribbonButton2;
        private RibbonTab ribbonTab1;
        private RibbonPanel ribbonPanel1;
        private RibbonPanel ribbonPanel2;
        private RibbonTab ribbonTab2;
        private RibbonPanel ribbonPanel3;
        private RibbonButton ribbonButton5;
        private RibbonButton ribbonButton6;
        private RibbonButton ribbonButton7;
        private RibbonComboBox ribbonComboBox1;
        private RibbonPanel ribbonPanel4;
        private RibbonCheckBox ribbonCheckBox1;
        private RibbonButton ribbonButton3;
        private RibbonButton ribbonButton4;
        private RibbonButton ribbonStudentsButton;
        private RibbonButton ribbonTeachersButton;
        private RibbonButton ribbonParentsButton;
        private RibbonButton ribbonLessonsButton;
        private RibbonSeparator ribbonSeparator2;
        private RibbonSeparator ribbonSeparator3;
    }
}

