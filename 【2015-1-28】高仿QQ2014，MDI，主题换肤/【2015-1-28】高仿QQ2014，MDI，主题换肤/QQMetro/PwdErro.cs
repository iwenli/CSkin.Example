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
 * * 说明：PwdErro.cs
 * *
********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace QQMetro
{
    public partial class PwdErro : UserControl
    {
        public PwdErro() {
            InitializeComponent();
            SetStyles();
        }

        private DialogResult diglog;
        /// <summary>
        /// 对话框的返回值
        /// </summary>
        public DialogResult Diglog {
            get { return diglog; }
            set { diglog = value; }
        }

        #region 减少闪烁方法
        private void SetStyles() {
            //设置自定义控件Style
            this.SetStyle(ControlStyles.ResizeRedraw, true);//调整大小时重绘
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);// 双缓冲
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);// 禁止擦除背景.
            this.SetStyle(ControlStyles.UserPaint, true);//自行绘制
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(200, 255, 255, 255);
            UpdateStyles();
        }
        #endregion

        private void btnPwdZh_Click(object sender, EventArgs e) {
            Process.Start("https://aq.qq.com/cn2/findpsw/pc/pc_find_pwd_input_account?source_id=1003&ptlang=2052&aquin=");
        }

        private void btnQx_Click(object sender, EventArgs e) {
            this.Diglog = DialogResult.Cancel;
            this.Visible = false;
        }
    }
}
