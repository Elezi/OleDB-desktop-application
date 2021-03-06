﻿using System;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMDIForm));
            this.imgLstTreeview = new System.Windows.Forms.ImageList(this.components);
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
            this.ribbonTabUnits = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelMadrasah = new System.Windows.Forms.RibbonPanel();
            this.ribbonStudentsButton = new System.Windows.Forms.RibbonButton();
            this.ribbonTeachersButton = new System.Windows.Forms.RibbonButton();
            this.ribbonParentsButton = new System.Windows.Forms.RibbonButton();
            this.ribbonLessonsButton = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelPrayers = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanelNewItems = new System.Windows.Forms.RibbonPanel();
            this.ribbonComboAddNewItem = new System.Windows.Forms.RibbonComboBox();
            this.ribbonButtonNewStudent = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonNewMember = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonNewContributor = new System.Windows.Forms.RibbonButton();
            this.ribbonTabActivities = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelMembership = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
            this.ribbonComboBox1 = new System.Windows.Forms.RibbonComboBox();
            this.ribbonPanelZakat = new System.Windows.Forms.RibbonPanel();
            this.ribbonCheckBox1 = new System.Windows.Forms.RibbonCheckBox();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton9 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton8 = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // imgLstTreeview
            // 
            this.imgLstTreeview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstTreeview.ImageStream")));
            this.imgLstTreeview.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstTreeview.Images.SetKeyName(0, "Folder.jpg");
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Margin = new System.Windows.Forms.Padding(4);
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
            this.ribbon1.Tabs.Add(this.ribbonTabUnits);
            this.ribbon1.Tabs.Add(this.ribbonTabActivities);
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
            // ribbonTabUnits
            // 
            this.ribbonTabUnits.Panels.Add(this.ribbonPanelMadrasah);
            this.ribbonTabUnits.Panels.Add(this.ribbonPanelPrayers);
            this.ribbonTabUnits.Panels.Add(this.ribbonPanelNewItems);
            this.ribbonTabUnits.Text = "Units";
            // 
            // ribbonPanelMadrasah
            // 
            this.ribbonPanelMadrasah.Items.Add(this.ribbonStudentsButton);
            this.ribbonPanelMadrasah.Items.Add(this.ribbonTeachersButton);
            this.ribbonPanelMadrasah.Items.Add(this.ribbonParentsButton);
            this.ribbonPanelMadrasah.Items.Add(this.ribbonLessonsButton);
            this.ribbonPanelMadrasah.Text = "Madrasah";
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
            // ribbonPanelPrayers
            // 
            this.ribbonPanelPrayers.Text = "Prayers";
            // 
            // ribbonPanelNewItems
            // 
            this.ribbonPanelNewItems.FlowsTo = System.Windows.Forms.RibbonPanelFlowDirection.Right;
            this.ribbonPanelNewItems.Items.Add(this.ribbonComboAddNewItem);
            this.ribbonPanelNewItems.Text = "New Items";
            // 
            // ribbonComboAddNewItem
            // 
            this.ribbonComboAddNewItem.DropDownItems.Add(this.ribbonButtonNewStudent);
            this.ribbonComboAddNewItem.DropDownItems.Add(this.ribbonButtonNewMember);
            this.ribbonComboAddNewItem.DropDownItems.Add(this.ribbonButtonNewContributor);
            this.ribbonComboAddNewItem.DropDownResizable = true;
            this.ribbonComboAddNewItem.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonComboAddNewItem.Text = "Click to add new";
            this.ribbonComboAddNewItem.TextBoxText = "Click to add new";
            this.ribbonComboAddNewItem.TextBoxWidth = 130;
            // 
            // ribbonButtonNewStudent
            // 
            this.ribbonButtonNewStudent.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewStudent.Image")));
            this.ribbonButtonNewStudent.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewStudent.SmallImage")));
            this.ribbonButtonNewStudent.Text = "New Student";
            this.ribbonButtonNewStudent.Click += new System.EventHandler(this.ribbonButtonNewStudent_Click);
            // 
            // ribbonButtonNewMember
            // 
            this.ribbonButtonNewMember.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewMember.Image")));
            this.ribbonButtonNewMember.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewMember.SmallImage")));
            this.ribbonButtonNewMember.Text = "New Member";
            this.ribbonButtonNewMember.Click += new System.EventHandler(this.ribbonButtonNewMember_Click);
            // 
            // ribbonButtonNewContributor
            // 
            this.ribbonButtonNewContributor.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewContributor.Image")));
            this.ribbonButtonNewContributor.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewContributor.SmallImage")));
            this.ribbonButtonNewContributor.Text = "New Contributor";
            this.ribbonButtonNewContributor.Click += new System.EventHandler(this.ribbonButtonNewContributor_Click);
            // 
            // ribbonTabActivities
            // 
            this.ribbonTabActivities.Panels.Add(this.ribbonPanelMembership);
            this.ribbonTabActivities.Panels.Add(this.ribbonPanelZakat);
            this.ribbonTabActivities.Text = "Activities";
            // 
            // ribbonPanelMembership
            // 
            this.ribbonPanelMembership.Items.Add(this.ribbonButton5);
            this.ribbonPanelMembership.Items.Add(this.ribbonButton6);
            this.ribbonPanelMembership.Items.Add(this.ribbonButton7);
            this.ribbonPanelMembership.Items.Add(this.ribbonComboBox1);
            this.ribbonPanelMembership.Text = "Membership";
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
            // ribbonPanelZakat
            // 
            this.ribbonPanelZakat.Text = "Zakat";
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
            // ribbonButton9
            // 
            this.ribbonButton9.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.Image")));
            this.ribbonButton9.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.SmallImage")));
            this.ribbonButton9.Text = "Button2";
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.Image")));
            this.ribbonButton8.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.SmallImage")));
            this.ribbonButton8.Text = "Button1";
            // 
            // MainMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1131, 593);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMDIForm";
            this.Text = "Community Software";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.MainMDIForm_Load);
            this.ResumeLayout(false);

        }

      

        #endregion

        //private System.Windows.Forms.TreeView trvwMainTree;
        //private System.Windows.Forms.GroupBox grpbxMembers;
        //private System.Windows.Forms.GroupBox grpbxRegisterMembers;
        //private System.Windows.Forms.GroupBox grpbxReportMembers;
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
        private RibbonTab ribbonTabUnits;
        private RibbonPanel ribbonPanelMadrasah;
        private RibbonPanel ribbonPanelPrayers;
        private RibbonTab ribbonTabActivities;
        private RibbonPanel ribbonPanelMembership;
        private RibbonButton ribbonButton5;
        private RibbonButton ribbonButton6;
        private RibbonButton ribbonButton7;
        private RibbonComboBox ribbonComboBox1;
        private RibbonPanel ribbonPanelZakat;
        private RibbonCheckBox ribbonCheckBox1;
        private RibbonButton ribbonButton3;
        private RibbonButton ribbonButton4;
        private RibbonButton ribbonStudentsButton;
        private RibbonButton ribbonTeachersButton;
        private RibbonButton ribbonParentsButton;
        private RibbonButton ribbonLessonsButton;
        private RibbonSeparator ribbonSeparator2;
        private RibbonSeparator ribbonSeparator3;
        private RibbonPanel ribbonPanelNewItems;
        private RibbonButton ribbonButton9;
        private RibbonButton ribbonButton8;
        private RibbonComboBox ribbonComboAddNewItem;
        private RibbonButton ribbonButtonNewStudent;
        private RibbonButton ribbonButtonNewMember;
        private RibbonButton ribbonButtonNewContributor;
    }
}

