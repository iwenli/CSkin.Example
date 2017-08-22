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
 * * 说明：LoginCode.cs
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
    public partial class LoginCode : UserControl
    {
        public LoginCode() {
            InitializeComponent();
        }

        private DialogResult diglog;
        /// <summary>
        /// 对话框的返回值
        /// </summary>
        public DialogResult Diglog {
            get { return diglog; }
            set { diglog = value; }
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e) {
            if (txtCode.SkinTxt.Text.ToLower() == CodeImg.CodeStr.ToLower()) {
                Diglog = DialogResult.OK;
                this.Visible = false;
            } else {
                Diglog = DialogResult.No;
                //刷新验证码
                CodeImg.NewCode();
                lblErroCode.Visible = true;
                this.txtCode.SkinTxt.Clear();
                this.txtCode.SkinTxt.Focus();
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQx_Click(object sender, EventArgs e) {
            Diglog = DialogResult.Cancel;
            this.Visible = false;
        }

        /// <summary>
        /// 查看登录地
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCkLoginD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("http://ip.qq.com/cgi-bin/myip");
        }

        /// <summary>
        /// 设置登录保护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetLoginBh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("http://aq.qq.com/cn2/safe_service/my_login_prot?source_id=2192");
        }

        /// <summary>
        /// 存储窗体容器的Enter响应按钮
        /// </summary>
        IButtonControl btn;

        /// <summary>
        /// 显示时清空文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginCode_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                lblErroCode.Visible = false;
                txtCode.SkinTxt.Clear();
                if (main != null) {
                    btn = main.AcceptButton;
                    main.AcceptButton = btnOk;
                }
            } else {
                if (main != null) {
                    main.AcceptButton = btn;
                }
            }
        }

        /// <summary>
        /// 控件所在窗体
        /// </summary>
        Form main;
        protected override void OnCreateControl() {
            base.OnCreateControl();
            main = this.FindForm();
        }

        /// <summary>
        /// 刷新验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblNewCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //刷新验证码
            CodeImg.NewCode();
        }
    }
}
