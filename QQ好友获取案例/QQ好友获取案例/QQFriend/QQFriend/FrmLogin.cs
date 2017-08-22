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
 * * 说明：FrmLogin.cs
 * *
********************************************************************/

using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QQFriend
{
    public partial class FrmLogin : Skin_Mac
    {
        public FrmLogin() {
            InitializeComponent();
        }
        #region 窗体加载时
        /// <summary>
        /// 已登录QQ
        /// </summary>
        List<LoginedInfo> list = new List<LoginedInfo>();

        /// <summary>
        /// 窗体加载时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e) {
            GetQQ checker = new GetQQ();
            if (checker.Initialize()) {
                //QQ数据
                list = checker.GetLoginedCache();
                if (list.Count > 0) {
                    LoginedInfo item = list[0];
                    item.Head = btnLogin.Image = HttpHelper.GetUrlImg(string.Format("http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin={0}&spec=100", item.Uin));
                    btnLogin.Text = string.Format("{0}\r\n（{1}）", item.Name, item.Uin);
                    btnLogin.Tag = 0;
                    QQItems.Tag = item;
                } else {
                    btnLogin.Text = "未检测到账号";
                }
            }
            //居中
            QQItems.Left = (this.Width - QQItems.Width) / 2;
            QQItems.Top = (this.Height - QQItems.Height) / 2 + 10;
        }
        #endregion

        #region 左右移动QQ
        /// <summary>
        /// 左移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeft_Click(object sender, EventArgs e) {
            if (btnLogin.Tag != null) {
                int SIndex = Convert.ToInt32(btnLogin.Tag);
                SIndex = SIndex == 0 ? list.Count - 1 : SIndex - 1;
                LoginedInfo item = list[SIndex];
                if (item.Head == null) {
                    item.Head = btnLogin.Image = HttpHelper.GetUrlImg(string.Format("http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin={0}&spec=100", item.Uin));
                } else {
                    btnLogin.Image = item.Head;
                }
                btnLogin.Text = string.Format("{0}\r\n（{1}）", item.Name, item.Uin);
                btnLogin.Tag = SIndex;
                QQItems.Tag = item;
            }
        }

        /// <summary>
        /// 右移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRight_Click(object sender, EventArgs e) {
            if (btnLogin.Tag != null) {
                int SIndex = Convert.ToInt32(btnLogin.Tag);
                SIndex = SIndex == list.Count - 1 ? 0 : SIndex + 1;
                LoginedInfo item = list[SIndex];
                if (item.Head == null) {
                    item.Head = btnLogin.Image = HttpHelper.GetUrlImg(string.Format("http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin={0}&spec=100", item.Uin));
                } else {
                    btnLogin.Image = item.Head;
                }
                btnLogin.Text = string.Format("{0}\r\n（{1}）", item.Name, item.Uin);
                btnLogin.Tag = SIndex;
                QQItems.Tag = item;
            }
        }
        #endregion

        #region 登录
        private void btnLogin_Click(object sender, EventArgs e) {
            if (QQItems.Tag != null) {
                FrmMain main = new FrmMain((LoginedInfo)QQItems.Tag);
                main.Show();
                this.Hide();
            } else {
                MessageBox.Show("未选中已登录账号！");
            }
        }
        #endregion
    }
}
