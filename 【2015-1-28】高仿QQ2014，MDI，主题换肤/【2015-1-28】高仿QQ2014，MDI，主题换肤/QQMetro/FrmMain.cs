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
 * * 网站：CSkin界面库 http://www.cskin.net 
 * * 论坛：http://bbs.cskin.net
 * * 作者： 乔克斯 QQ：345015918 .Net项目技术组群：306485590
 * * 请保留以上版权信息，否则作者将保留追究法律责任。
 * *
 * * 创建时间：2015-01-28
 * * 说明：FrmMain.cs
 * *
********************************************************************/

using CCWin;
using CCWin.SkinClass;
using CCWin.SkinControl;
using CCWin.Win32;
using QQMetro.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace QQMetro
{
    public partial class FrmMain : CCSkinMain
    {
        ChatListSubItem UserItem { get; set; }
        public FrmMain(ChatListSubItem UserItem, SkinButton BtnState) {
            InitializeComponent();
            //获取屏幕宽高
            SW = Screen.PrimaryScreen.Bounds.Width;
            SH = Screen.PrimaryScreen.Bounds.Height;
            //赋值传来的登录用户
            this.UserItem = UserItem;
            //获取当前登录帐号与头像
            lblName.Text = UserItem.NicName;
            //获取当前状态
            btnState.Image = BtnState.Image;
            btnState.Tag = BtnState.Tag;
            //调整图标位置
            btnState.Left = lblName.Right;
            lblLv.Left = btnState.Right;
            imgSvip.Left = lblLv.Right;
        }
        #region 变量
        private int form_top_old;
        private int form_left_old;
        private int form_right_old;
        private int SW;
        private int SH;
        #endregion

        #region 窗体加载时
        /// <summary>
        /// 窗体加载时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e) {
            //上次登录历史窗体
            FrmInformation frm = new FrmInformation();
            frm.Show(this);
            //获取屏幕宽高与调节最大大小
            this.MaximumSize = new Size(543, Screen.GetWorkingArea(this).Height);
            //加载随机好友
            System.Threading.ThreadPool.QueueUserWorkItem((s) => BindQQFriend());
        }
        #endregion

        #region 加载随机好友
        Random ran = new Random();
        /// <summary>
        /// 加载随机好友
        /// </summary>
        private void BindQQFriend() {
            //加载随机好友信息
            for (uint i = 0; i < 100; i++) {
                //第一次加载我的QQ，其余99个QQ采用随机QQ号
                uint Id = i == 0 ? 345015918 : (uint)ran.Next(10001, 1000000000);
                //加载Q名
                string QQName = GetQQName(Id);
                //Q名不为空
                if (QQName != string.Empty) {
                    ChatListSubItem QQ = new ChatListSubItem();
                    //加载Q名
                    QQ.NicName = QQName;
                    //加载状态
                    QQ.Status = GetQQOnline(Id) ? ChatListSubItem.UserStatus.Online : ChatListSubItem.UserStatus.OffLine;
                    //加载签名
                    QQ.PersonalMsg = "我超帅，来自：" + QQName;
                    //加载备注名
                    QQ.DisplayName = string.Empty;
                    //加载QQ号
                    QQ.ID = Id;
                    //加载带背景QQ秀
                    QQ.QQShow = HttpHelper.GetUrlImg(string.Format("http://acfs.tencent.com/{0}/.jpg", Id));
                    //加载头像
                    QQ.HeadImage = HttpHelper.GetUrlImg(string.Format("http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin={0}&spec=100", Id));
                    //委托主线程添加好友
                    this.Invoke(new MethodInvoker(delegate {
                        chatListBox.Items[0].SubItems.Add(QQ);
                    }));
                }
            }
            //委托主线程排序好友顺序
            this.Invoke(new MethodInvoker(delegate {
                if (chatListBox.Items[0].SubItems.Count > 0) {
                    //排序
                    chatListBox.Items[0].SubItems.Sort();
                }
            }));
        }
        #region 获取QQ是否在线
        /// <summary>
        /// 获取QQ是否在线
        /// </summary>
        /// <param name="qq"></param>
        /// <returns></returns>
        public bool GetQQOnline(uint qq) {
            bool Online = false;
            try {
                WebClient web = new WebClient();
                web.Encoding = Encoding.GetEncoding("utf-8");//设置编码
                Online = web.DownloadString(string.Format("http://webpresence.qq.com/getonline?Type=1&{0}:", qq)) == "online[0]=1;" ? true : false;
                web.Dispose();
            } catch (Exception) {
            }
            return Online;
        }
        #endregion

        #region 获取QQ名称
        /// <summary>
        /// 获取QQ名称
        /// </summary>
        /// <param name="qq"></param>
        /// <returns></returns>
        public string GetQQName(uint qq) {
            WebClient web = new WebClient();
            web.Encoding = Encoding.GetEncoding("utf-8");//设置编码
            //获取QQ名称
            string qqName = web.DownloadString(string.Format("http://r.qzone.qq.com/cgi-bin/user/cgi_personal_card?uin={0}", qq)).Replace("&quot;", "\"");
            Regex regex = new Regex("\"nickname\":\"(.+?)\"");
            MatchCollection match = regex.Matches(qqName);
            return match.Count == 0 ? "" : match[0].Success ? match[0].Groups[1].Value : string.Empty;
        }
        #endregion
        #endregion

        #region 退出事件
        protected override void OnClosing(CancelEventArgs e) {
            System.Environment.Exit(0);
            base.OnClosing(e);
        }
        #endregion

        #region 计时器贴边隐藏与其他事件
        //贴边隐藏
        int? hg = null;
        private void timHide_Tick(object sender, EventArgs e) {
            //隐藏窗口的方法
            form_top_old = 2 - this.Height;
            form_left_old = 2 - this.Width;
            form_right_old = SW - 2;
            //没点击移动时
            if (!this.isMouseDown) {
                //鼠标在窗体内时
                if (this.Bounds.Contains(Cursor.Position)) {
                    switch (this.Aanhor) {
                        //执行右移特效
                        case AnchorStyles.Left:
                            if (hg == null) {
                                hg = this.Height;
                            }
                            this.Height = MaximumSize.Height;
                            this.Top = 0;
                            int b = this.Left;
                            for (int i = b; i < 0; i += 1) {
                                this.Left = i;
                            }
                            this.Left = 0;
                            break;
                        //执行左移特效
                        case AnchorStyles.Right:
                            if (hg == null) {
                                hg = this.Height;
                            }
                            this.Height = MaximumSize.Height;
                            this.Top = 0;
                            int c = this.Left;
                            for (int i = c; i > SW - this.Width; i -= 1) {
                                this.Left = i;
                            }
                            this.Left = SW - this.Width;
                            break;
                        //执行下移特效
                        case AnchorStyles.Top:
                            int a = this.Top;
                            for (int i = a; i < 0; i += 2) {
                                this.Top = i;
                            }
                            this.Top = 0;
                            break;
                    }
                    //hg不为空的话，恢复成原来高度
                    if (hg != null && this.Left > 0 && this.Left < Screen.PrimaryScreen.Bounds.Width - this.Width) {
                        this.Height = (int)hg;
                        hg = null;
                    }
                } else {
                    switch (this.Aanhor) {
                        //执行左移特效
                        case AnchorStyles.Left:
                            if (this.Left != form_left_old) {
                                for (int i = 0; i >= form_left_old; i -= 1) {
                                    this.Left = i;
                                }
                                this.Left = form_left_old;
                            }
                            break;
                        //执行右移特效
                        case AnchorStyles.Right:
                            if (this.Left != form_right_old) {
                                for (int i = SW - this.Width; i <= form_right_old; i += 1) {
                                    this.Left = i;
                                }
                                this.Left = form_right_old;
                            }
                            break;
                        //执行上移特效
                        case AnchorStyles.Top:
                            if (this.Top != form_top_old) {
                                for (int i = 0; i >= form_top_old; i -= 2) {
                                    this.Top = i;
                                }
                                this.Top = form_top_old;
                            }
                            break;
                    }
                }
            }
        }
        #endregion

        #region 窗口重绘时
        /// <summary>
        /// 窗口重绘时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.Default;
            //tab 243, 250, 253
            SolidBrush sbTab = new SolidBrush(Color.FromArgb(230, 255, 255, 255));
            g.FillRectangle(sbTab, new Rectangle(new Point(1, ChatTab.Top), new Size(this.Width - 2, ChatTab.ItemSize.Height)));
            g.DrawLine(new Pen(Color.FromArgb(221, 224, 226)), new Point(1, ChatTab.Top + ChatTab.ItemSize.Height - 1), new Point(this.Width - 2, ChatTab.Top + ChatTab.ItemSize.Height - 1));
            //Foot 190, 255, 255, 255 218, 230, 244
            SolidBrush sb = new SolidBrush(Color.FromArgb(200, 255, 255, 255));
            g.FillRectangle(sb, new Rectangle(new Point(1, Height - 60), new Size(Width - 2, 59)));
            g.DrawLine(new Pen(Color.FromArgb(192, 212, 236)), new Point(1, Height - 60), new Point(Width - 2, Height - 60));
        }
        #endregion

        #region 背景色改变时
        /// <summary>
        /// 背景色改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_BackColorChanged(object sender, EventArgs e) {
            chatListBox.BackColor = chatGroup.BackColor = chatHistory.BackColor = Color.FromArgb(50, this.BackColor);
        }
        #endregion

        #region 根据系统判断是否加载特效
        private void FrmMain_VisibleChanged(object sender, EventArgs e) {
            //Environment.OSVersion.Version.Major小于6则是win7 Vista以下系统
            this.Special = Environment.OSVersion.Version.Major >= 6;
        }
        #endregion

        #region 选择当前登录状态
        //选择状态
        private void btnState_Click(object sender, EventArgs e) {
            MenuState.Show(btnState, new Point(0, btnState.Height), ToolStripDropDownDirection.Right);
        }
        #endregion

        #region QQ主菜单
        /// <summary>
        /// 打开QQ主菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolQQMenu_Click(object sender, EventArgs e) {
            QQMenu.Show(SkToolCdTwo, new Point(3, -2), ToolStripDropDownDirection.AboveRight);
            toolQQMenu.Image = Properties.Resources.menu_btn_highlight;
            toolQQMenu.Checked = true;
        }

        //QQ主菜单关闭时
        private void QQMenu_Closing(object sender, ToolStripDropDownClosingEventArgs e) {
            toolQQMenu.Image = Properties.Resources.menu_btn_normal;
            toolQQMenu.Checked = false;
        }

        //QQ主菜单悬浮时
        private void toolQQMenu_MouseEnter(object sender, EventArgs e) {
            toolQQMenu.Image = Properties.Resources.menu_btn_highlight;
        }

        //QQ主菜单离开时
        private void toolQQMenu_MouseLeave(object sender, EventArgs e) {
            if (!QQMenu.Visible) {
                toolQQMenu.Image = Properties.Resources.menu_btn_normal;
            }
        }
        #endregion

        #region 好友列表悬浮头像时
        private UserInformationForm userInformationForm;//悬浮至头像时
        private void chatShow_MouseEnterHead(object sender, ChatListEventArgs e) {
            if (userInformationForm == null || userInformationForm.IsDisposed) {
                userInformationForm = new UserInformationForm();
            }
            int top = this.Top + this.ChatTab.Top + this.ChatTab.ItemSize.Height + (e.MouseOnSubItem.HeadRect.Y - this.chatListBox.chatVScroll.Value);
            int left = this.Left - 279 - 5;
            int ph = Screen.GetWorkingArea(this).Height;

            if (top + 181 > ph) {
                top = ph - 181 - 5;
            }

            if (left < 0) {
                left = this.Right + 5;
            }
            userInformationForm.IsFMove = false;
            this.userInformationForm.Item = e.MouseOnSubItem;
            this.userInformationForm.SetUserData(e.MouseOnSubItem, new Point(left, top));
            this.userInformationForm.Show();
        }
        #endregion

        #region 好友列表离开头像时
        private void chatShow_MouseLeaveHead(object sender, ChatListEventArgs e) {
            if (userInformationForm != null && !userInformationForm.IsDisposed) {
                userInformationForm.IsFMove = true;
            }
        }
        #endregion

        #region Q名悬浮离开时信息框
        //悬浮时
        private void lblName_MouseHover(object sender, EventArgs e) {
            if (userInformationForm == null || userInformationForm.IsDisposed) {
                userInformationForm = new UserInformationForm();
            }
            int top = this.Top + lblName.Top;
            int left = this.Left - 279 - 5;
            int ph = Screen.GetWorkingArea(this).Height;

            if (top + 181 > ph) {
                top = ph - 181 - 5;
            }

            if (left < 0) {
                left = this.Right + 5;
            }
            userInformationForm.IsFMove = false;
            this.userInformationForm.Item = UserItem;
            this.userInformationForm.SetUserData(UserItem, new Point(left, top));
            this.userInformationForm.Show();
        }

        //离开时
        private void lblName_MouseLeave(object sender, EventArgs e) {
            if (userInformationForm != null && !userInformationForm.IsDisposed) {
                userInformationForm.IsFMove = true;
            }
        }
        #endregion

        #region 状态菜单选择状态
        private void toolState_Click(object sender, EventArgs e) {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            btnState.Image = item.Image;
            btnState.Tag = item.Tag;
        }
        #endregion

        #region 天气悬浮事件
        //悬浮至头像时
        private FrmWeather frmWeather;
        private void btnTq_MouseHover(object sender, EventArgs e) {
            //窗体的TopLeft值
            int UserTop = this.Top;
            int UserLeft = this.Right + 2;
            //屏幕不包括任务栏的高度
            int PH = Screen.GetWorkingArea(this).Height;
            int PW = Screen.GetWorkingArea(this).Width;
            //判断是否超过屏幕高度
            if (UserTop + 250 > PH) {
                UserTop = PH - 250 - 2;
            }
            //判断是否大于屏幕右边
            if (UserLeft + 240 + 2 > PW) {
                UserLeft = this.Left - 240 - 2;
            }
            //窗体不为空传值
            if (frmWeather == null || frmWeather.IsDisposed) {
                frmWeather = new FrmWeather(new Point(UserLeft, UserTop));
            }
            //设置窗体已释放
            if (frmWeather.frm == null || frmWeather.frm.IsDisposed) {
                frmWeather.IsFMove = false;
                frmWeather.Location = new Point(UserLeft, UserTop);
                frmWeather.LoactionPoint = new Point(UserLeft, UserTop);
                frmWeather.Show();
            }
        }

        private void btnTq_MouseLeave(object sender, EventArgs e) {
            if (frmWeather != null && !frmWeather.IsDisposed) {
                //设置窗体已释放
                if (frmWeather.frm == null || frmWeather.frm.IsDisposed) {
                    frmWeather.IsFMove = true;
                    frmWeather.TimShow(true);
                }
            }
        }
        #endregion

        #region 双击好友弹窗对话框
        private void chatListBox_DoubleClickSubItem(object sender, ChatListEventArgs e, MouseEventArgs es) {
            if (es.Button == MouseButtons.Right) {
                return;
            }
            ChatListSubItem item = e.SelectSubItem;
            item.IsTwinkle = false;

            //bool isFormexist;
            string windowsName = "与 " + item.NicName + " 对话中";
            IntPtr handle = NativeMethods.FindWindow(null, windowsName);
            if (handle != IntPtr.Zero) {
                Form frm = (Form)Form.FromHandle(handle);
                frm.Activate();
            } else {
                //ipSend为从列表中取出，要发送的对象的IP
                FrmQQChat fChat = new FrmQQChat(item);
                fChat.Text = "与 " + item.NicName + " 对话中";
                fChat.Show();
            }
        }
        #endregion

        #region 查找好友
        /// <summary>
        /// 查找好友
        /// </summary>
        private int searchIndex = 0;
        private ChatListSubItem[] searchItems;
        private string searchText = null;

        private void btnSearch_Click(object sender, EventArgs e) {
            string findText = txtSearch.Text;
            if (findText != searchText)//搜索内容变化
            {
                searchIndex = 0;
                searchItems = chatListBox.GetSubItemsByText(findText);
            }
            if (searchItems != null) {
                if (searchIndex < searchItems.Length) {
                    chatListBox.SelectSubItem = searchItems[searchIndex];
                }
                searchIndex++;
                if (searchIndex == searchItems.Length) {
                    searchIndex = 0;
                }
            } else//没有查找到
            {
                chatListBox.SelectSubItem = null;
            }
        }
        #endregion
    }
}
