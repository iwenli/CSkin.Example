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
 * * 说明：FrmMain.cs
 * *
********************************************************************/

using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using CCWin.SkinControl; 
using System.Diagnostics;

namespace QQFriend
{
    public partial class FrmMain : Skin_Mac
    {
        /// <summary>
        /// 登录用户
        /// </summary>
        LoginedInfo Login;
        public FrmMain(LoginedInfo login) {
            InitializeComponent();
            this.Login = login;
        }
        #region 窗体加载时
        FrmLeft left = null;
        private void FrmMain_Load(object sender, EventArgs e) {
            left = new FrmLeft(this);
            left.Show(this);
            //清空好友列表
            QQChat.Items.Clear();
            lblQQFriend.Visible = false;
            System.Threading.ThreadPool.QueueUserWorkItem((s) => ItSpider());
        }
        #endregion

        #region 加载好友列表
        /// <summary>
        /// 加载好友列表
        /// </summary>
        /// <returns></returns>
        private void ItSpider() {
            XWebClient web = new XWebClient();
            web.Encoding = Encoding.UTF8;
            string html = web.DownloadString(string.Format("http://ptlogin2.qq.com/jump?clientuin={0}&clientkey={1}&keyindex=9&aid=636014201&u1=http://user.qzone.qq.com/{0}", Login.Uin, Login.Key));
            if (html.Contains("登陆区") || html.Contains("对方未开通空间")) {
                this.Invoke(new MethodInvoker(delegate {
                    if (html.Contains("对方未开通空间")) {
                        lblQQFriend.Text = "对方未开通空间";
                    } else {
                        lblQQFriend.Text = "clientkey已过期";
                    }
                    lblQQFriend.Visible = true;
                }));
            } else {
                List<Cookie> lcks = web.GetAllCookies();
                if (lcks.Count > 0) {
                    string skey = lcks.Where(c => c.Name.Equals("skey")).ToList()[0].Value;
                    string suin = lcks.Where(c => c.Name.Equals("uin")).ToList()[0].Value;
                    long gtk = GetG_tk(skey);
                    string url = string.Format("http://r.cnc.qzone.qq.com/cgi-bin/tfriend/friend_mngfrd_get.cgi?uin={0}&rd=0.9740207901969242&g_tk={1}", Login.Uin, gtk);
                    string json = web.DownloadString(url).Replace("_Callback(", "").Replace(");", "");
                    QQFriend qqf = JsonHelper.ParseFormByJson<QQFriend>(json);
                    if (qqf != null) {
                        //先加载分组出来
                        List<ChatListSubItem> flist = new List<ChatListSubItem>();
                        foreach (Gpname gitem in qqf.gpnames.OrderBy(c => c.sortid)) {
                            //加载分组
                            ChatListItem gp = new ChatListItem();
                            gp.Text = gitem.gpname;
                            gp.Tag = gitem.gpid;
                            this.Invoke(new MethodInvoker(delegate {
                                QQChat.Items.Add(gp);
                            }));
                            //加载好友
                            foreach (Item item in qqf.items) {
                                if (item.groupid.ToString() == gitem.gpid.ToString()) {
                                    ChatListSubItem qq = new ChatListSubItem();
                                    qq.ID = (uint)item.uin;
                                    qq.IsVip = item.is_special.Equals("1");
                                    qq.NicName = item.name;
                                    qq.DisplayName = item.realname;
                                    qq.HeadImage = Properties.Resources.headimg_dl;
                                    qq.Status = item.online == 1 ? ChatListSubItem.UserStatus.Online : ChatListSubItem.UserStatus.OffLine;
                                    qq.Tag = item;
                                    qq.PersonalMsg = string.Format("{0}{1}{2}{3}", item.uin, item.is_special.Equals("1") ? " 特殊关注" : string.Empty, item.yellow == -1 ? string.Empty : " 黄钻" + item.yellow, item.is_xy.Equals("1") ? " 姓名：" + item.xyname : string.Empty);
                                    //缓存list
                                    flist.Add(qq);
                                    gp.SubItems.Add(qq);
                                }
                            }
                            this.Invoke(new MethodInvoker(delegate {
                                //分组重新排序
                                if (gp.SubItems.Count > 0) {
                                    gp.SubItems.Sort();
                                }
                            }));
                        }
                        //慢慢加载头像
                        foreach (ChatListSubItem item in flist) {
                            Item i = (Item)item.Tag;
                            item.HeadImage = HttpHelper.GetUrlImg(i.img);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 计算Gtk值
        /// </summary>
        /// <param name="sKey"></param>
        /// <returns></returns>
        public long GetG_tk(string sKey) {
            int hash = 5381;
            for (int i = 0, len = sKey.Length; i < len; ++i) {
                hash += (hash << 5) + (int)sKey[i];
            }
            return (hash & 0x7fffffff);
        }
        #endregion

        #region 窗体移动时
        protected override void OnLocationChanged(EventArgs e) {
            base.OnLocationChanged(e);
            if (left != null) {
                left.Location = new Point(this.Left - left.Width, this.Top - 180);
            }
        }
        #endregion

        #region 窗体关闭时
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
        #endregion

        #region 查看头像和QQ秀
        FrmPrintscreen frm = null;
        private void ToolItemImg_Click(object sender, EventArgs e) {
            ToolStripMenuItem Item = (ToolStripMenuItem)sender;
            if (QQChat.SelectSubItem != null) {
                Image img = HttpHelper.GetUrlImg(string.Format(Item.Tag.ToString(), QQChat.SelectSubItem.ID));
                if (frm == null || frm.IsDisposed) {
                    frm = new FrmPrintscreen();
                }
                frm.ListImg = new List<Image>() { img };
                frm.Show();
            }
        }
        #endregion

        #region 菜单项IE链接
        private void ToolItemUrl(object sender, EventArgs e) {
            ToolStripMenuItem Item = (ToolStripMenuItem)sender;
            if (QQChat.SelectSubItem != null) {
                string url = string.Empty;
                if (Item.Text.Equals("加为好友")) {
                    url = string.Format(Item.Tag.ToString(), QQChat.SelectSubItem.ID, Login.Uin);
                } else {
                    url = string.Format("http://ptlogin2.qq.com/jump?clientuin={0}&clientkey={1}&keyindex=9&aid=636014201&u1={2}", Login.Uin, Login.Key, string.Format(Item.Tag.ToString(), QQChat.SelectSubItem.ID));
                }
                Process.Start("iexplore.exe", url);
            }
        }
        #endregion

        #region 查看QQ资料
        private void ToolGetQQData_Click(object sender, EventArgs e) {
            if (QQChat.SelectSubItem != null) {
                Item IData = (Item)QQChat.SelectSubItem.Tag;
                MessageBoxEx.Show(string.Format("QQ：{0}\r\nQQ名：{1}\r\n备注名：{2}\r\n状态：{3}\r\n黄钻等级：{4}\r\n朋友网姓名：{5}", IData.uin, IData.name, IData.realname, IData.online == 1 ? "在线" : "离线", IData.yellow == -1 ? 0 : IData.yellow, IData.is_xy.Equals("1") ? IData.xyname : "空"), "QQ资料");
            }
        }
        #endregion
    }
}
