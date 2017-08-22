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
 * * 说明：FrmTheme.cs
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

namespace QQMetro
{
    public partial class FrmTheme : Skin_Mac
    {
        public FrmTheme() {
            InitializeComponent();
        }
        #region 窗体加载时
        /// <summary>
        /// 窗体加载时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTheme_Load(object sender, EventArgs e) {
            cboTheme.SelectedIndex = 0;
        }
        #endregion

        #region 更换主题
        /// <summary>
        /// 更换主题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboTheme_SelectedIndexChanged(object sender, EventArgs e) {
            string theme = cboTheme.SelectedItem.ToString();
            switch (theme) {
                case "Mac":
                    this.XTheme = new Skin_Mac() { };
                    break;
                case "Dev":
                    this.XTheme = new Skin_DevExpress() { };
                    break;
                case "VS":
                    this.XTheme = new Skin_VS() { };
                    break;
                case "Win8":
                    this.XTheme = new Skin_Metro() { };
                    break;
                case "Color":
                    this.XTheme = new Skin_Color() { };
                    break;
                case "None":
                    //            如果不想变动的属性可以在↓这里输入
                    this.XTheme = new CCSkinMain() { Shadow = false };
                    break;
            }
        }
        #endregion

        #region 关于按钮
        /// <summary>
        /// 关于按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e) {
            CCSkinMain about = new CCSkinMain();
            about.Text = "关于";
            //可拖动图片换背景
            about.AllowDrop = true;
            //窗体居中
            about.StartPosition = FormStartPosition.CenterScreen;

            #region 继承换肤模式1
            //继承所属窗体背景
            about.InheritBack = true;
            //继承所属窗体主题
            about.InheritTheme = true;
            //所属窗体
            about.Owner = this;
            //显示
            about.Show();
            #endregion

            #region 继承换肤模式2
            ////窗体居中
            //about.StartPosition = FormStartPosition.CenterScreen;
            //about.XTheme = this.XTheme;
            ////显示
            //about.Show(); 
            #endregion
        }
        #endregion

        #region 弹窗按钮
        /// <summary>
        /// 弹窗按钮
        /// </summary>
        string newLine = Environment.NewLine;
        private void btnMsg_Click(object sender, EventArgs e) {
            string info = "简单文字信息................" + newLine +
             "简单文字信息................";
            MessageBoxEx.Show(info);
            MessageBoxEx.Show(info, "带标题的示例");
            MessageBoxEx.Show(info, "带标题的示例",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBoxEx.Show(info, "带标题的示例",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBoxEx.Show(info, "带标题的示例",
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            MessageBoxEx.Show(info, "带标题的示例",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            MessageBoxEx.Show(info, "带标题的示例",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            MessageBoxEx.Show(info, "带标题的示例",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
        }
        #endregion
    }
}
