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
 * * 说明：FrmMdi.cs
 * *
********************************************************************/

using CCWin;
using CCWin.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace QQMetro
{
    public partial class FrmMdi : Skin_Mac
    {
        public FrmMdi() {
            InitializeComponent();
        }
        #region 添加子窗体
        private void btnAddMdi_Click(object sender, EventArgs e) {
            Form f = new Form();
            f.MdiParent = this;
            f.Show();
        }
        #endregion

        #region 子窗体排列
        private void toolBtnCd_Click(object sender, EventArgs e) {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolBtnSp_Click(object sender, EventArgs e) {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolBtnCz_Click(object sender, EventArgs e) {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        #endregion

        #region 关闭所有子窗体
        private void ToolExitAll_Click(object sender, EventArgs e) {
            Form[] frmList = this.MdiChildren;
            foreach (Form frm in frmList) {
                frm.Close();
            }
        }
        #endregion
    }
}