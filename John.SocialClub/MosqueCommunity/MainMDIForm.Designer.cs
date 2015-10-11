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
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonSeparator2 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonSeparator3 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonComboBox1 = new System.Windows.Forms.RibbonComboBox();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.ribbonCheckBox1 = new System.Windows.Forms.RibbonCheckBox();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbOptionButton1 = new System.Windows.Forms.RibbonOrbOptionButton();
            this.ribbonOrbRecentItem1 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.ribbonOrbRecentItem2 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.ribbonOrbRecentItem3 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonStudentsButton = new System.Windows.Forms.RibbonButton();
            this.ribbonTeachersButton = new System.Windows.Forms.RibbonButton();
            this.ribbonParentsButton = new System.Windows.Forms.RibbonButton();
            this.ribbonLessonsButton = new System.Windows.Forms.RibbonButton();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelNewItem = new System.Windows.Forms.RibbonPanel();
            this.NewItemButtonList = new System.Windows.Forms.RibbonButtonList();
            this.ribbonButtonNewStudent = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonNewParent = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonNewMosque = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonNewMember = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonNewContributor = new System.Windows.Forms.RibbonButton();
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
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "Mosque";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanelNewItem);
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
            // ribbonComboBox1
            // 
            this.ribbonComboBox1.TextBoxText = "";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Text = "Zakat";
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
            // ribbonPanelNewItem
            // 
            this.ribbonPanelNewItem.Items.Add(this.NewItemButtonList);
            this.ribbonPanelNewItem.Text = "New Item";
            // 
            // NewItemButtonList
            // 
            this.NewItemButtonList.Buttons.Add(this.ribbonButtonNewStudent);
            this.NewItemButtonList.Buttons.Add(this.ribbonButtonNewParent);
            this.NewItemButtonList.Buttons.Add(this.ribbonButtonNewMosque);
            this.NewItemButtonList.Buttons.Add(this.ribbonButtonNewMember);
            this.NewItemButtonList.Buttons.Add(this.ribbonButtonNewContributor);
            this.NewItemButtonList.Buttons.Add(this.ribbonButton8);
            this.NewItemButtonList.ButtonsSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.NewItemButtonList.FlowToBottom = false;
            this.NewItemButtonList.ItemsSizeInDropwDownMode = new System.Drawing.Size(7, 5);
            // 
            // ribbonButtonNewStudent
            // 
            this.ribbonButtonNewStudent.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewStudent.Image")));
            this.ribbonButtonNewStudent.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewStudent.SmallImage")));
            // 
            // ribbonButtonNewParent
            // 
            this.ribbonButtonNewParent.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewParent.Image")));
            this.ribbonButtonNewParent.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewParent.SmallImage")));
            // 
            // ribbonButtonNewMosque
            // 
            this.ribbonButtonNewMosque.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewMosque.Image")));
            this.ribbonButtonNewMosque.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewMosque.SmallImage")));
            // 
            // ribbonButtonNewMember
            // 
            this.ribbonButtonNewMember.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewMember.Image")));
            this.ribbonButtonNewMember.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewMember.SmallImage")));
            // 
            // ribbonButtonNewContributor
            // 
            this.ribbonButtonNewContributor.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewContributor.Image")));
            this.ribbonButtonNewContributor.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewContributor.SmallImage")));
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.Image")));
            this.ribbonButton8.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.SmallImage")));
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
            this.ResumeLayout(false);

        }

      

        #endregion

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
        private RibbonPanel ribbonPanelNewItem;
        private RibbonButtonList NewItemButtonList;
        private RibbonButton ribbonButtonNewStudent;
        private RibbonButton ribbonButtonNewParent;
        private RibbonButton ribbonButtonNewMosque;
        private RibbonButton ribbonButtonNewMember;
        private RibbonButton ribbonButtonNewContributor;
        private RibbonButton ribbonButton8;
    }
}

