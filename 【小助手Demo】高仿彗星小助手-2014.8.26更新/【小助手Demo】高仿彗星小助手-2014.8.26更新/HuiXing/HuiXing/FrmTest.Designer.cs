/********************************************************************
 * *
 * * 使本项目源码或本项目生成的DLL前请仔细阅读以下协议内容，如果你同意以下协议才能使用本项目所有的功能，
 * * 否则如果你违反了以下协议，有可能陷入法律纠纷和赔偿，作者保留追究法律责任的权利。
 * *
 * * 1、你可以在开发的软件产品中使用和修改本项目的源码和DLL，但是请保留所有相关的版权信息。
 * * 2、不能将本项目源码与作者的其他项目整合作为一个单独的软件售卖给他人使用。
 * * 3、不能传播本项目的源码和DLL，包括上传到网上、拷贝给他人等方式。
 * * 4、以上协议暂时定制，由于还不完善，作者保留以后修改协议的权利。
 * *
 * * Copyright (C) 2013-? cskin Corporation All rights reserved.
 * * 网站：CSkin界面库 http://www.cskin.net 论坛 http://bbs.cskin.net
 * * 作者： 乔克斯 QQ：345015918 .Net项目技术组群：306485590
 * * 请保留以上版权信息，否则作者将保留追究法律责任。
 * *
 * * 创建时间：2014-08-26
 * * 说明：FrmTest.Designer.cs
 * *
********************************************************************/

namespace HuiXing
{
    partial class FrmTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            CCWin.SkinControl.ChatListItem chatListItem1 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem1 = new CCWin.SkinControl.ChatListSubItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTest));
            CCWin.SkinControl.ChatListSubItem chatListSubItem2 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem3 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem4 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem5 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListItem chatListItem2 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem6 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem7 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem8 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem9 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListItem chatListItem3 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem10 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem11 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem12 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem13 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            this.chatListBox1 = new CCWin.SkinControl.ChatListBox();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.skinRadioButton2 = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButton4 = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButton3 = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButton1 = new CCWin.SkinControl.SkinRadioButton();
            this.skinCheckBox3 = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBox2 = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBox4 = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBox1 = new CCWin.SkinControl.SkinCheckBox();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatListBox1
            // 
            this.chatListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chatListBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox1.ForeColor = System.Drawing.Color.Black;
            this.chatListBox1.FriendsMobile = true;
            chatListItem1.Bounds = new System.Drawing.Rectangle(0, 1, 150, 25);
            chatListItem1.IsTwinkleHide = false;
            chatListItem1.OwnerChatListBox = this.chatListBox1;
            chatListSubItem1.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem1.DisplayName = "displayName";
            chatListSubItem1.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem1.HeadImage")));
            chatListSubItem1.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem1.ID = ((uint)(0u));
            chatListSubItem1.IpAddress = null;
            chatListSubItem1.IsTwinkle = false;
            chatListSubItem1.IsTwinkleHide = false;
            chatListSubItem1.IsVip = false;
            chatListSubItem1.NicName = "nicName";
            chatListSubItem1.OwnerListItem = chatListItem1;
            chatListSubItem1.PersonalMsg = "Personal Message ...";
            chatListSubItem1.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem1.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem1.Tag = null;
            chatListSubItem1.TcpPort = 0;
            chatListSubItem1.UpdPort = 0;
            chatListSubItem2.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem2.DisplayName = "displayName";
            chatListSubItem2.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem2.HeadImage")));
            chatListSubItem2.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem2.ID = ((uint)(0u));
            chatListSubItem2.IpAddress = null;
            chatListSubItem2.IsTwinkle = false;
            chatListSubItem2.IsTwinkleHide = false;
            chatListSubItem2.IsVip = false;
            chatListSubItem2.NicName = "nicName";
            chatListSubItem2.OwnerListItem = chatListItem1;
            chatListSubItem2.PersonalMsg = "Personal Message ...";
            chatListSubItem2.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem2.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem2.Tag = null;
            chatListSubItem2.TcpPort = 0;
            chatListSubItem2.UpdPort = 0;
            chatListSubItem3.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem3.DisplayName = "displayName";
            chatListSubItem3.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem3.HeadImage")));
            chatListSubItem3.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem3.ID = ((uint)(0u));
            chatListSubItem3.IpAddress = null;
            chatListSubItem3.IsTwinkle = false;
            chatListSubItem3.IsTwinkleHide = false;
            chatListSubItem3.IsVip = false;
            chatListSubItem3.NicName = "nicName";
            chatListSubItem3.OwnerListItem = chatListItem1;
            chatListSubItem3.PersonalMsg = "Personal Message ...";
            chatListSubItem3.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem3.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem3.Tag = null;
            chatListSubItem3.TcpPort = 0;
            chatListSubItem3.UpdPort = 0;
            chatListSubItem4.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem4.DisplayName = "displayName";
            chatListSubItem4.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem4.HeadImage")));
            chatListSubItem4.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem4.ID = ((uint)(0u));
            chatListSubItem4.IpAddress = null;
            chatListSubItem4.IsTwinkle = false;
            chatListSubItem4.IsTwinkleHide = false;
            chatListSubItem4.IsVip = false;
            chatListSubItem4.NicName = "nicName";
            chatListSubItem4.OwnerListItem = chatListItem1;
            chatListSubItem4.PersonalMsg = "Personal Message ...";
            chatListSubItem4.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem4.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem4.Tag = null;
            chatListSubItem4.TcpPort = 0;
            chatListSubItem4.UpdPort = 0;
            chatListSubItem5.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem5.DisplayName = "displayName";
            chatListSubItem5.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem5.HeadImage")));
            chatListSubItem5.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem5.ID = ((uint)(0u));
            chatListSubItem5.IpAddress = null;
            chatListSubItem5.IsTwinkle = false;
            chatListSubItem5.IsTwinkleHide = false;
            chatListSubItem5.IsVip = false;
            chatListSubItem5.NicName = "nicName";
            chatListSubItem5.OwnerListItem = chatListItem1;
            chatListSubItem5.PersonalMsg = "Personal Message ...";
            chatListSubItem5.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem5.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem5.Tag = null;
            chatListSubItem5.TcpPort = 0;
            chatListSubItem5.UpdPort = 0;
            chatListItem1.SubItems.AddRange(new CCWin.SkinControl.ChatListSubItem[] {
            chatListSubItem1,
            chatListSubItem2,
            chatListSubItem3,
            chatListSubItem4,
            chatListSubItem5});
            chatListItem1.Text = "Item";
            chatListItem1.TwinkleSubItemNumber = 0;
            chatListItem2.Bounds = new System.Drawing.Rectangle(0, 27, 150, 25);
            chatListItem2.IsTwinkleHide = false;
            chatListItem2.OwnerChatListBox = this.chatListBox1;
            chatListSubItem6.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem6.DisplayName = "123";
            chatListSubItem6.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem6.HeadImage")));
            chatListSubItem6.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem6.ID = ((uint)(0u));
            chatListSubItem6.IpAddress = null;
            chatListSubItem6.IsTwinkle = false;
            chatListSubItem6.IsTwinkleHide = false;
            chatListSubItem6.IsVip = false;
            chatListSubItem6.NicName = "12313";
            chatListSubItem6.OwnerListItem = chatListItem2;
            chatListSubItem6.PersonalMsg = "Personal Message ...";
            chatListSubItem6.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem6.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem6.Tag = null;
            chatListSubItem6.TcpPort = 0;
            chatListSubItem6.UpdPort = 0;
            chatListSubItem7.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem7.DisplayName = "displayName";
            chatListSubItem7.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem7.HeadImage")));
            chatListSubItem7.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem7.ID = ((uint)(0u));
            chatListSubItem7.IpAddress = null;
            chatListSubItem7.IsTwinkle = false;
            chatListSubItem7.IsTwinkleHide = false;
            chatListSubItem7.IsVip = false;
            chatListSubItem7.NicName = "nicName";
            chatListSubItem7.OwnerListItem = chatListItem2;
            chatListSubItem7.PersonalMsg = "Personal Message ...";
            chatListSubItem7.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem7.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem7.Tag = null;
            chatListSubItem7.TcpPort = 0;
            chatListSubItem7.UpdPort = 0;
            chatListSubItem8.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem8.DisplayName = "displayName";
            chatListSubItem8.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem8.HeadImage")));
            chatListSubItem8.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem8.ID = ((uint)(0u));
            chatListSubItem8.IpAddress = null;
            chatListSubItem8.IsTwinkle = false;
            chatListSubItem8.IsTwinkleHide = false;
            chatListSubItem8.IsVip = false;
            chatListSubItem8.NicName = "nicName";
            chatListSubItem8.OwnerListItem = chatListItem2;
            chatListSubItem8.PersonalMsg = "Personal Message ...";
            chatListSubItem8.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem8.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem8.Tag = null;
            chatListSubItem8.TcpPort = 0;
            chatListSubItem8.UpdPort = 0;
            chatListSubItem9.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem9.DisplayName = "displayName";
            chatListSubItem9.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem9.HeadImage")));
            chatListSubItem9.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem9.ID = ((uint)(0u));
            chatListSubItem9.IpAddress = null;
            chatListSubItem9.IsTwinkle = false;
            chatListSubItem9.IsTwinkleHide = false;
            chatListSubItem9.IsVip = false;
            chatListSubItem9.NicName = "nicName";
            chatListSubItem9.OwnerListItem = chatListItem2;
            chatListSubItem9.PersonalMsg = "Personal Message ...";
            chatListSubItem9.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem9.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem9.Tag = null;
            chatListSubItem9.TcpPort = 0;
            chatListSubItem9.UpdPort = 0;
            chatListItem2.SubItems.AddRange(new CCWin.SkinControl.ChatListSubItem[] {
            chatListSubItem6,
            chatListSubItem7,
            chatListSubItem8,
            chatListSubItem9});
            chatListItem2.Text = "Item";
            chatListItem2.TwinkleSubItemNumber = 0;
            chatListItem3.Bounds = new System.Drawing.Rectangle(0, 53, 150, 25);
            chatListItem3.IsTwinkleHide = false;
            chatListItem3.OwnerChatListBox = this.chatListBox1;
            chatListSubItem10.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem10.DisplayName = "displayName";
            chatListSubItem10.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem10.HeadImage")));
            chatListSubItem10.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem10.ID = ((uint)(0u));
            chatListSubItem10.IpAddress = null;
            chatListSubItem10.IsTwinkle = false;
            chatListSubItem10.IsTwinkleHide = false;
            chatListSubItem10.IsVip = false;
            chatListSubItem10.NicName = "nicName";
            chatListSubItem10.OwnerListItem = chatListItem3;
            chatListSubItem10.PersonalMsg = "Personal Message ...";
            chatListSubItem10.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem10.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem10.Tag = null;
            chatListSubItem10.TcpPort = 0;
            chatListSubItem10.UpdPort = 0;
            chatListSubItem11.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem11.DisplayName = "displayName";
            chatListSubItem11.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem11.HeadImage")));
            chatListSubItem11.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem11.ID = ((uint)(0u));
            chatListSubItem11.IpAddress = null;
            chatListSubItem11.IsTwinkle = false;
            chatListSubItem11.IsTwinkleHide = false;
            chatListSubItem11.IsVip = false;
            chatListSubItem11.NicName = "nicName";
            chatListSubItem11.OwnerListItem = chatListItem3;
            chatListSubItem11.PersonalMsg = "Personal Message ...";
            chatListSubItem11.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem11.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem11.Tag = null;
            chatListSubItem11.TcpPort = 0;
            chatListSubItem11.UpdPort = 0;
            chatListSubItem12.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem12.DisplayName = "displayName";
            chatListSubItem12.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem12.HeadImage")));
            chatListSubItem12.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem12.ID = ((uint)(0u));
            chatListSubItem12.IpAddress = null;
            chatListSubItem12.IsTwinkle = false;
            chatListSubItem12.IsTwinkleHide = false;
            chatListSubItem12.IsVip = false;
            chatListSubItem12.NicName = "nicName";
            chatListSubItem12.OwnerListItem = chatListItem3;
            chatListSubItem12.PersonalMsg = "Personal Message ...";
            chatListSubItem12.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem12.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem12.Tag = null;
            chatListSubItem12.TcpPort = 0;
            chatListSubItem12.UpdPort = 0;
            chatListSubItem13.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem13.DisplayName = "displayName";
            chatListSubItem13.HeadImage = ((System.Drawing.Image)(resources.GetObject("chatListSubItem13.HeadImage")));
            chatListSubItem13.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem13.ID = ((uint)(0u));
            chatListSubItem13.IpAddress = null;
            chatListSubItem13.IsTwinkle = false;
            chatListSubItem13.IsTwinkleHide = false;
            chatListSubItem13.IsVip = false;
            chatListSubItem13.NicName = "nicName";
            chatListSubItem13.OwnerListItem = chatListItem3;
            chatListSubItem13.PersonalMsg = "Personal Message ...";
            chatListSubItem13.PlatformTypes = CCWin.SkinControl.PlatformType.PC;
            chatListSubItem13.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem13.Tag = null;
            chatListSubItem13.TcpPort = 0;
            chatListSubItem13.UpdPort = 0;
            chatListItem3.SubItems.AddRange(new CCWin.SkinControl.ChatListSubItem[] {
            chatListSubItem10,
            chatListSubItem11,
            chatListSubItem12,
            chatListSubItem13});
            chatListItem3.Text = "Item";
            chatListItem3.TwinkleSubItemNumber = 0;
            this.chatListBox1.Items.AddRange(new CCWin.SkinControl.ChatListItem[] {
            chatListItem1,
            chatListItem2,
            chatListItem3});
            this.chatListBox1.ListHadOpenGroup = null;
            this.chatListBox1.ListSubItemMenu = null;
            this.chatListBox1.Location = new System.Drawing.Point(12, 12);
            this.chatListBox1.Name = "chatListBox1";
            this.chatListBox1.SelectSubItem = null;
            this.chatListBox1.Size = new System.Drawing.Size(150, 250);
            this.chatListBox1.SubItemMenu = null;
            this.chatListBox1.TabIndex = 0;
            this.chatListBox1.Text = "chatListBox1";
            this.chatListBox1.DownSubItem += new CCWin.SkinControl.ChatListBox.ChatListClickEventHandler(this.chatListBox1_DownSubItem);
            this.chatListBox1.UpSubItem += new CCWin.SkinControl.ChatListBox.ChatListClickEventHandler(this.chatListBox1_UpSubItem);
            this.chatListBox1.ClickSubItem += new CCWin.SkinControl.ChatListBox.ChatListClickEventHandler(this.chatListBox1_ClickSubItem);
            // 
            // skinTabControl1
            // 
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.skinTabControl1.Animation = animation1;
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.tabPage1);
            this.skinTabControl1.Controls.Add(this.tabPage2);
            this.skinTabControl1.Controls.Add(this.tabPage3);
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(314, 12);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageCloseVisble = true;
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(255, 242);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 10;
            this.skinTabControl1.TabePageClosed += new CCWin.SkinControl.SkinTabControl.ClosedTabePageHandler(this.skinTabControl1_TabePageClosed);
            this.skinTabControl1.TabePageClosing += new CCWin.SkinControl.SkinTabControl.ClosingTabePageHandler(this.skinTabControl1_TabePageClosing);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(255, 206);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "测试关闭事件";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(255, 206);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(255, 206);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // skinRadioButton2
            // 
            this.skinRadioButton2.AutoSize = true;
            this.skinRadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton2.DownBack = null;
            this.skinRadioButton2.Enabled = false;
            this.skinRadioButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton2.IsEnabledDraw = false;
            this.skinRadioButton2.Location = new System.Drawing.Point(168, 169);
            this.skinRadioButton2.MouseBack = null;
            this.skinRadioButton2.Name = "skinRadioButton2";
            this.skinRadioButton2.NormlBack = null;
            this.skinRadioButton2.SelectedDownBack = null;
            this.skinRadioButton2.SelectedMouseBack = null;
            this.skinRadioButton2.SelectedNormlBack = null;
            this.skinRadioButton2.Size = new System.Drawing.Size(128, 21);
            this.skinRadioButton2.TabIndex = 9;
            this.skinRadioButton2.TabStop = true;
            this.skinRadioButton2.Text = "skinRadioButton1";
            this.skinRadioButton2.UseVisualStyleBackColor = false;
            // 
            // skinRadioButton4
            // 
            this.skinRadioButton4.AutoSize = true;
            this.skinRadioButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton4.DownBack = global::HuiXing.Properties.Resources.ImgColor;
            this.skinRadioButton4.Enabled = false;
            this.skinRadioButton4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton4.IsEnabledDraw = false;
            this.skinRadioButton4.Location = new System.Drawing.Point(168, 233);
            this.skinRadioButton4.MouseBack = global::HuiXing.Properties.Resources.ImgNorml;
            this.skinRadioButton4.Name = "skinRadioButton4";
            this.skinRadioButton4.NormlBack = global::HuiXing.Properties.Resources.imgXz;
            this.skinRadioButton4.SelectedDownBack = global::HuiXing.Properties.Resources.ImgPer;
            this.skinRadioButton4.SelectedMouseBack = global::HuiXing.Properties.Resources.ImgColor;
            this.skinRadioButton4.SelectedNormlBack = global::HuiXing.Properties.Resources.ImgNorml;
            this.skinRadioButton4.Size = new System.Drawing.Size(128, 21);
            this.skinRadioButton4.TabIndex = 9;
            this.skinRadioButton4.TabStop = true;
            this.skinRadioButton4.Text = "skinRadioButton1";
            this.skinRadioButton4.UseVisualStyleBackColor = false;
            // 
            // skinRadioButton3
            // 
            this.skinRadioButton3.AutoSize = true;
            this.skinRadioButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton3.DownBack = global::HuiXing.Properties.Resources.ImgColor;
            this.skinRadioButton3.Enabled = false;
            this.skinRadioButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton3.Location = new System.Drawing.Point(168, 206);
            this.skinRadioButton3.MouseBack = global::HuiXing.Properties.Resources.ImgNorml;
            this.skinRadioButton3.Name = "skinRadioButton3";
            this.skinRadioButton3.NormlBack = global::HuiXing.Properties.Resources.imgXz;
            this.skinRadioButton3.SelectedDownBack = global::HuiXing.Properties.Resources.ImgPer;
            this.skinRadioButton3.SelectedMouseBack = global::HuiXing.Properties.Resources.ImgColor;
            this.skinRadioButton3.SelectedNormlBack = global::HuiXing.Properties.Resources.ImgNorml;
            this.skinRadioButton3.Size = new System.Drawing.Size(128, 21);
            this.skinRadioButton3.TabIndex = 9;
            this.skinRadioButton3.TabStop = true;
            this.skinRadioButton3.Text = "skinRadioButton1";
            this.skinRadioButton3.UseVisualStyleBackColor = false;
            // 
            // skinRadioButton1
            // 
            this.skinRadioButton1.AutoSize = true;
            this.skinRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton1.DownBack = null;
            this.skinRadioButton1.Enabled = false;
            this.skinRadioButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton1.Location = new System.Drawing.Point(168, 142);
            this.skinRadioButton1.MouseBack = null;
            this.skinRadioButton1.Name = "skinRadioButton1";
            this.skinRadioButton1.NormlBack = null;
            this.skinRadioButton1.SelectedDownBack = null;
            this.skinRadioButton1.SelectedMouseBack = null;
            this.skinRadioButton1.SelectedNormlBack = null;
            this.skinRadioButton1.Size = new System.Drawing.Size(128, 21);
            this.skinRadioButton1.TabIndex = 9;
            this.skinRadioButton1.TabStop = true;
            this.skinRadioButton1.Text = "skinRadioButton1";
            this.skinRadioButton1.UseVisualStyleBackColor = false;
            // 
            // skinCheckBox3
            // 
            this.skinCheckBox3.AutoSize = true;
            this.skinCheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox3.DownBack = null;
            this.skinCheckBox3.Enabled = false;
            this.skinCheckBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox3.IsEnabledDraw = false;
            this.skinCheckBox3.Location = new System.Drawing.Point(168, 115);
            this.skinCheckBox3.MouseBack = null;
            this.skinCheckBox3.Name = "skinCheckBox3";
            this.skinCheckBox3.NormlBack = null;
            this.skinCheckBox3.SelectedDownBack = null;
            this.skinCheckBox3.SelectedMouseBack = null;
            this.skinCheckBox3.SelectedNormlBack = null;
            this.skinCheckBox3.Size = new System.Drawing.Size(114, 21);
            this.skinCheckBox3.TabIndex = 8;
            this.skinCheckBox3.Text = "skinCheckBox2";
            this.skinCheckBox3.UseVisualStyleBackColor = false;
            // 
            // skinCheckBox2
            // 
            this.skinCheckBox2.AutoSize = true;
            this.skinCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox2.DownBack = null;
            this.skinCheckBox2.Enabled = false;
            this.skinCheckBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox2.Location = new System.Drawing.Point(168, 78);
            this.skinCheckBox2.MouseBack = null;
            this.skinCheckBox2.Name = "skinCheckBox2";
            this.skinCheckBox2.NormlBack = null;
            this.skinCheckBox2.SelectedDownBack = null;
            this.skinCheckBox2.SelectedMouseBack = null;
            this.skinCheckBox2.SelectedNormlBack = null;
            this.skinCheckBox2.Size = new System.Drawing.Size(114, 21);
            this.skinCheckBox2.TabIndex = 8;
            this.skinCheckBox2.Text = "skinCheckBox2";
            this.skinCheckBox2.UseVisualStyleBackColor = false;
            // 
            // skinCheckBox4
            // 
            this.skinCheckBox4.AutoSize = true;
            this.skinCheckBox4.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox4.DefaultCheckButtonWidth = 25;
            this.skinCheckBox4.DownBack = global::HuiXing.Properties.Resources.imgXz;
            this.skinCheckBox4.Enabled = false;
            this.skinCheckBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox4.Location = new System.Drawing.Point(168, 12);
            this.skinCheckBox4.MouseBack = global::HuiXing.Properties.Resources.ImgColor;
            this.skinCheckBox4.Name = "skinCheckBox4";
            this.skinCheckBox4.NormlBack = global::HuiXing.Properties.Resources.ImgNorml;
            this.skinCheckBox4.SelectedDownBack = global::HuiXing.Properties.Resources.imgXz;
            this.skinCheckBox4.SelectedMouseBack = global::HuiXing.Properties.Resources.ImgColor;
            this.skinCheckBox4.SelectedNormlBack = global::HuiXing.Properties.Resources.ImgNorml;
            this.skinCheckBox4.Size = new System.Drawing.Size(114, 21);
            this.skinCheckBox4.TabIndex = 7;
            this.skinCheckBox4.Text = "skinCheckBox1";
            this.skinCheckBox4.UseVisualStyleBackColor = false;
            // 
            // skinCheckBox1
            // 
            this.skinCheckBox1.AutoSize = true;
            this.skinCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox1.DefaultCheckButtonWidth = 25;
            this.skinCheckBox1.DownBack = global::HuiXing.Properties.Resources.imgXz;
            this.skinCheckBox1.Enabled = false;
            this.skinCheckBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox1.IsEnabledDraw = false;
            this.skinCheckBox1.Location = new System.Drawing.Point(168, 39);
            this.skinCheckBox1.MouseBack = global::HuiXing.Properties.Resources.ImgColor;
            this.skinCheckBox1.Name = "skinCheckBox1";
            this.skinCheckBox1.NormlBack = global::HuiXing.Properties.Resources.ImgNorml;
            this.skinCheckBox1.SelectedDownBack = global::HuiXing.Properties.Resources.imgXz;
            this.skinCheckBox1.SelectedMouseBack = global::HuiXing.Properties.Resources.ImgColor;
            this.skinCheckBox1.SelectedNormlBack = global::HuiXing.Properties.Resources.ImgNorml;
            this.skinCheckBox1.Size = new System.Drawing.Size(114, 21);
            this.skinCheckBox1.TabIndex = 7;
            this.skinCheckBox1.Text = "skinCheckBox1";
            this.skinCheckBox1.UseVisualStyleBackColor = false;
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.InheritColor = false;
            this.skinButton3.Location = new System.Drawing.Point(185, 291);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(75, 23);
            this.skinButton3.TabIndex = 6;
            this.skinButton3.Text = "闪烁选中项";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.InheritColor = false;
            this.skinButton2.Location = new System.Drawing.Point(104, 291);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(75, 23);
            this.skinButton2.TabIndex = 5;
            this.skinButton2.Text = "获取选中项";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.InheritColor = false;
            this.skinButton1.Location = new System.Drawing.Point(23, 291);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 4;
            this.skinButton1.Text = "删除选中项";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 346);
            this.Controls.Add(this.skinTabControl1);
            this.Controls.Add(this.skinRadioButton2);
            this.Controls.Add(this.skinRadioButton4);
            this.Controls.Add(this.skinRadioButton3);
            this.Controls.Add(this.skinRadioButton1);
            this.Controls.Add(this.skinCheckBox3);
            this.Controls.Add(this.skinCheckBox2);
            this.Controls.Add(this.skinCheckBox4);
            this.Controls.Add(this.skinCheckBox1);
            this.Controls.Add(this.skinButton3);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.chatListBox1);
            this.Name = "FrmTest";
            this.Text = "(测试案例2)测试更改功能窗体";
            this.skinTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.ChatListBox chatListBox1;
        private CCWin.SkinControl.SkinButton skinButton3;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox1;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox2;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox3;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox4;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton1;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton2;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton3;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton4;
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}