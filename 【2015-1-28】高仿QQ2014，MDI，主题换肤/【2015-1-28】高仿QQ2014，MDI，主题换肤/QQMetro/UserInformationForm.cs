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
 * * 说明：UserInformationForm.cs
 * *
********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;

namespace QQMetro
{
    public partial class UserInformationForm : CCSkinMain
    {
        private ChatListSubItem item;
        private Point point;
        public UserInformationForm() {
            InitializeComponent();
        }

        /// <summary>
        /// 用户信息及位置赋值
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="point"></param>
        public void SetUserData(ChatListSubItem Item, Point point) {
            this.Item = Item;
            this.Location = this.point = point;
        }

        public ChatListSubItem Item {
            get {
                return item;
            }
            set {
                if (item != value) {
                    item = value;
                    lblName.Text = item.NicName;
                    lblQm.Text = item.PersonalMsg;
                    imgQQShow.Image = item.QQShow;
                }
            }
        }

        //悬浮至好友Q名时
        private void lblChatName_MouseEnter(object sender, EventArgs e) {
            lblName.Font = new Font("微软雅黑", 16F, FontStyle.Underline);
        }

        //离开好友Q名时
        private void lblChatName_MouseLeave(object sender, EventArgs e) {
            lblName.Font = new Font("微软雅黑", 16F);
        }

        //窗口加载时
        private void FrmInformation_Load(object sender, EventArgs e) {
            //初始化窗口出现位置
            this.Location = point;
        }

        //窗体重绘时
        private void FrmUserInformation_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            SolidBrush sb = new SolidBrush(Color.FromArgb(100, 255, 255, 255));
            g.FillRectangle(sb, new Rectangle(new Point(1, Height - 103), new Size(Width - 2, 80)));
        }

        //计时器
        public bool isMove = false;
        private void timShow_Tick(object sender, EventArgs e) {
            //鼠标不在窗体内时
            if (!this.Bounds.Contains(Cursor.Position) && isMove) {
                this.Hide();
                isMove = false;
            } else if (this.Bounds.Contains(Cursor.Position)) {
                //鼠标进入窗体
                isMove = true;
                //停止好友模块滑动计时器
                IsFMove = false;
            }
        }

        private bool isFMove = false;

        public bool IsFMove {
            get { return isFMove; }
            set {
                isFMove = value;
                timMove.Enabled = value;
            }
        }
        private void timMove_Tick(object sender, EventArgs e) {
            if (IsFMove) {
                this.Hide();
                timMove.Stop();
            }
        }
    }
}
