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
 * * 说明：FrmTest.cs
 * *
********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HuiXing
{
    public partial class FrmTest : Form
    {
        public FrmTest() {
            InitializeComponent();
        }

        private void skinButton1_Click(object sender, EventArgs e) {
            this.chatListBox1.SelectItem.SubItems.Remove(this.chatListBox1.SelectSubItem);
        }

        private void skinButton2_Click(object sender, EventArgs e) {
            if (this.chatListBox1.SelectSubItem != null)
                MessageBox.Show("你选中了" + this.chatListBox1.SelectSubItem.NicName + " 分组是" + this.chatListBox1.SelectSubItem.OwnerListItem.Text);
        }

        private void skinButton3_Click(object sender, EventArgs e) {
            this.chatListBox1.SelectSubItem.IsTwinkle = true;
        }

        private void chatListBox1_ClickSubItem(object sender, CCWin.SkinControl.ChatListClickEventArgs e, MouseEventArgs es) {
            MessageBox.Show("Click：" + e.SelectSubItem.DisplayName);
        }

        private void chatListBox1_DownSubItem(object sender, CCWin.SkinControl.ChatListClickEventArgs e, MouseEventArgs es) {
            //MessageBox.Show("Down：" + e.SelectSubItem.DisplayName);
        }

        private void chatListBox1_UpSubItem(object sender, CCWin.SkinControl.ChatListClickEventArgs e, MouseEventArgs es) {
            MessageBox.Show("Up：" + e.SelectSubItem.DisplayName);
        }

        private void skinTabControl1_TabePageClosed(object sender, CCWin.SkinControl.TabPageEventArgs e) {
            MessageBox.Show("已关闭：" + e.ColseTabPage.Name);
        }

        private void skinTabControl1_TabePageClosing(object sender, CCWin.SkinControl.TabPageEventArgs e) {
            MessageBox.Show("即将关闭：" + e.ColseTabPage.Name);
        }
    }
}
