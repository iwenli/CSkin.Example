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
 * * 创建时间：2013-09-07
 * * 说明：FrmMain.Designer.cs
 * *
********************************************************************/

namespace QQFriend
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.QQChat = new CCWin.SkinControl.ChatListBox();
            this.UserMenu = new CCWin.SkinControl.SkinContextMenuStrip();
            this.toolStripMenuItem51 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddFriend = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem60 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem53 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolGetQQData = new System.Windows.Forms.ToolStripMenuItem();
            this.查看QQ秀ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看头像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQQFriend = new CCWin.SkinControl.SkinLabel();
            this.UserMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // QQChat
            // 
            this.QQChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.QQChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QQChat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QQChat.ForeColor = System.Drawing.Color.Black;
            this.QQChat.FriendsMobile = false;
            this.QQChat.ListSubItemMenu = this.UserMenu;
            this.QQChat.Location = new System.Drawing.Point(4, 34);
            this.QQChat.Name = "QQChat";
            this.QQChat.SelectSubItem = null;
            this.QQChat.Size = new System.Drawing.Size(264, 409);
            this.QQChat.SubItemMenu = null;
            this.QQChat.TabIndex = 0;
            this.QQChat.Text = "chatListBox1";
            // 
            // UserMenu
            // 
            this.UserMenu.Arrow = System.Drawing.Color.Black;
            this.UserMenu.Back = System.Drawing.Color.White;
            this.UserMenu.BackRadius = 4;
            this.UserMenu.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.UserMenu.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.UserMenu.Fore = System.Drawing.Color.Black;
            this.UserMenu.HoverFore = System.Drawing.Color.White;
            this.UserMenu.ImageScalingSize = new System.Drawing.Size(11, 11);
            this.UserMenu.ItemAnamorphosis = false;
            this.UserMenu.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.UserMenu.ItemBorderShow = false;
            this.UserMenu.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.UserMenu.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.UserMenu.ItemRadius = 4;
            this.UserMenu.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.UserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem51,
            this.toolAddFriend,
            this.toolStripMenuItem60,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem53,
            this.ToolGetQQData,
            this.查看QQ秀ToolStripMenuItem,
            this.查看头像ToolStripMenuItem});
            this.UserMenu.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.UserMenu.Name = "MenuState";
            this.UserMenu.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.UserMenu.Size = new System.Drawing.Size(133, 170);
            this.UserMenu.SkinAllColor = true;
            this.UserMenu.TitleAnamorphosis = false;
            this.UserMenu.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.UserMenu.TitleRadius = 4;
            this.UserMenu.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            // 
            // toolStripMenuItem51
            // 
            this.toolStripMenuItem51.Name = "toolStripMenuItem51";
            this.toolStripMenuItem51.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem51.Tag = "http://wpa.qq.com/msgrd?v=3&uin={0}&site=qq&menu=yes";
            this.toolStripMenuItem51.Text = "强制聊天";
            this.toolStripMenuItem51.Click += new System.EventHandler(this.ToolItemUrl);
            // 
            // toolAddFriend
            // 
            this.toolAddFriend.Name = "toolAddFriend";
            this.toolAddFriend.Size = new System.Drawing.Size(132, 22);
            this.toolAddFriend.Tag = "tencent://AddContact/?fromId=45&fromSubId=1&subcmd=all&uin={0}&fuin={1}";
            this.toolAddFriend.Text = "加为好友";
            this.toolAddFriend.Click += new System.EventHandler(this.ToolItemUrl);
            // 
            // toolStripMenuItem60
            // 
            this.toolStripMenuItem60.Name = "toolStripMenuItem60";
            this.toolStripMenuItem60.Size = new System.Drawing.Size(129, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem1.Tag = "http://user.qzone.qq.com/{0}/";
            this.toolStripMenuItem1.Text = "进入空间";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolItemUrl);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem2.Tag = "http://mail.qq.com/cgi-bin/qm_share?t=qm_mailme&email={0}@qq.com";
            this.toolStripMenuItem2.Text = "发送邮件";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolItemUrl);
            // 
            // toolStripMenuItem53
            // 
            this.toolStripMenuItem53.Name = "toolStripMenuItem53";
            this.toolStripMenuItem53.Size = new System.Drawing.Size(129, 6);
            // 
            // ToolGetQQData
            // 
            this.ToolGetQQData.Name = "ToolGetQQData";
            this.ToolGetQQData.Size = new System.Drawing.Size(132, 22);
            this.ToolGetQQData.Text = "查看资料";
            this.ToolGetQQData.Click += new System.EventHandler(this.ToolGetQQData_Click);
            // 
            // 查看QQ秀ToolStripMenuItem
            // 
            this.查看QQ秀ToolStripMenuItem.Name = "查看QQ秀ToolStripMenuItem";
            this.查看QQ秀ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.查看QQ秀ToolStripMenuItem.Tag = "http://qqshow-user.tencent.com/{0}/10/00/.jpg";
            this.查看QQ秀ToolStripMenuItem.Text = "查看QQ秀";
            this.查看QQ秀ToolStripMenuItem.Click += new System.EventHandler(this.ToolItemImg_Click);
            // 
            // 查看头像ToolStripMenuItem
            // 
            this.查看头像ToolStripMenuItem.Name = "查看头像ToolStripMenuItem";
            this.查看头像ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.查看头像ToolStripMenuItem.Tag = "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin={0}&spec=100";
            this.查看头像ToolStripMenuItem.Text = "查看头像";
            this.查看头像ToolStripMenuItem.Click += new System.EventHandler(this.ToolItemImg_Click);
            // 
            // lblQQFriend
            // 
            this.lblQQFriend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQQFriend.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblQQFriend.AutoSize = true;
            this.lblQQFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblQQFriend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblQQFriend.BorderSize = 3;
            this.lblQQFriend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQQFriend.ForeColor = System.Drawing.Color.Red;
            this.lblQQFriend.Location = new System.Drawing.Point(89, 212);
            this.lblQQFriend.Name = "lblQQFriend";
            this.lblQQFriend.Size = new System.Drawing.Size(94, 17);
            this.lblQQFriend.TabIndex = 2;
            this.lblQQFriend.Tag = "";
            this.lblQQFriend.Text = "clientkey已过期";
            this.lblQQFriend.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.CanResize = false;
            this.CaptionBackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(213)))), ((int)(((byte)(172)))));
            this.CaptionBackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(272, 447);
            this.Controls.Add(this.lblQQFriend);
            this.Controls.Add(this.QQChat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ShadowWidth = 6;
            this.Text = "好友列表";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.UserMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.ChatListBox QQChat;
        private CCWin.SkinControl.SkinLabel lblQQFriend;
        private CCWin.SkinControl.SkinContextMenuStrip UserMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem51;
        private System.Windows.Forms.ToolStripMenuItem toolAddFriend;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem60;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem53;
        private System.Windows.Forms.ToolStripMenuItem ToolGetQQData;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 查看QQ秀ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看头像ToolStripMenuItem;
    }
}