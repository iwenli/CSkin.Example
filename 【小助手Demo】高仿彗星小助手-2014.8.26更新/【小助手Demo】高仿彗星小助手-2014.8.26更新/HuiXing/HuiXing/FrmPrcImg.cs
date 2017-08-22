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
 * * 说明：FrmPrcImg.cs
 * *
********************************************************************/

using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HuiXing
{
    public partial class FrmPrcImg : Form
    {
        public FrmPrcImg() {
            InitializeComponent();
            SetStyles();
        }
        #region 减少闪烁
        //减少闪烁
        private void SetStyles() {
            base.SetStyle(
              ControlStyles.UserPaint |
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.ResizeRedraw |
              ControlStyles.DoubleBuffer, true);
            base.UpdateStyles();
            base.AutoScaleMode = AutoScaleMode.None;
        }
        #endregion

        #region 选择画笔颜色
        /// <summary>
        /// 选择画笔颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColorSelect_Click(object sender, EventArgs e) {
            if (colorShow.ShowDialog() == DialogResult.OK) {
                toolSelectColor.BackColor = colorShow.Color;
            }
        }
        #endregion

        #region 画图工具选中
        private void toolGj1_Click(object sender, EventArgs e) {
            ToolStripButton Sbtn = (ToolStripButton)sender;
            SelectToolBtn(Sbtn, "1");
            if (Sbtn.Name == "toolGj1") {
                //改变画板鼠标
                imgPens.Cursor = new Cursor(new MemoryStream(Properties.Resources._154));
            } else {
                //改变画板鼠标
                imgPens.Cursor = new Cursor(new MemoryStream(Properties.Resources._171));
            }
        }
        #endregion

        #region 画图画笔工具选中
        private void toolPen1_Click(object sender, EventArgs e) {
            ToolStripButton Sbtn = (ToolStripButton)sender;
            SelectToolBtn(Sbtn, "2");
        }
        #endregion

        #region 工具栏选中方法
        private void SelectToolBtn(ToolStripButton Sbtn, string TBtnTag) {
            foreach (var item in toolMenuPens.Items) {
                if (item is ToolStripButton) {
                    ToolStripButton btn = (ToolStripButton)item;
                    if (btn.Tag != null) {
                        btn.Checked = btn.Tag.ToString().Equals(TBtnTag) ? false : btn.Checked;
                    }
                }
            }
            Sbtn.Checked = true;
        }
        #endregion

        #region 截图
        /// <summary>
        /// 截图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrc_Click(object sender, EventArgs e) {
            this.StartCapture();
        }
        //截图方法
        private FrmCapture m_frmCapture;
        private void StartCapture() {
            if (m_frmCapture == null || m_frmCapture.IsDisposed)
                m_frmCapture = new FrmCapture();
            m_frmCapture.IsCaptureCursor = false;
            m_frmCapture.FormClosing += m_frmCapture_FormClosing;
            m_frmCapture.Show();
        }

        /// <summary>
        /// 截图截完时，获取截图图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_frmCapture_FormClosing(object sender, FormClosingEventArgs e) {
            imgPens.Image = Clipboard.GetImage();
            imgPens.Width = imgPens.Image.Width;
            imgPens.Height = imgPens.Image.Height;
            //绘图居中
            ICenter();
        }
        #endregion

        #region 绘图画板变大变小
        private void btnImgBig_Click(object sender, EventArgs e) {
            imgPens.Width += Convert.ToInt32(imgPens.Width * 0.1);
            imgPens.Height += Convert.ToInt32(imgPens.Height * 0.1);
            //绘图居中
            ICenter();
        }

        private void btnImgSmall_Click(object sender, EventArgs e) {
            imgPens.Width -= Convert.ToInt32(imgPens.Width * 0.1);
            imgPens.Height -= Convert.ToInt32(imgPens.Height * 0.1);
            //绘图居中
            ICenter();
        }


        /// <summary>
        /// 绘图居中
        /// </summary>
        private void ICenter() {
            imgPens.Top = (pnlImg.Height - imgPens.Height) / 2;
            imgPens.Left = (pnlImg.Width - imgPens.Width) / 2;
            //改变主窗体的Lbl提示值
            (Application.OpenForms["FrmMain"] as FrmMain).lblTs.Text = string.Format("当前图片尺寸:{0} x {1}", imgPens.Width, imgPens.Height);
        }
        #endregion

        #region 控件移动
        private Point mouse_offset;
        private void C_MouseDown(object o, MouseEventArgs e) {
            if (toolGj1.Checked) {
                mouse_offset = new Point(-e.X, -e.Y);//记录当前位置
            }
        }
        private void C_MouseMove(object o, MouseEventArgs e) {
            if (toolGj1.Checked) {
                if (e.Button == MouseButtons.Left) {
                    Point mousePos = Control.MousePosition;
                    mousePos.Offset(mouse_offset.X, mouse_offset.Y);//设置偏移
                    ((Control)o).Location = ((Control)o).Parent.PointToClient(mousePos);
                }
            }
        }
        #endregion

        #region 窗口加载时
        private void FrmPrcImg_Load(object sender, EventArgs e) {
            //改变画板鼠标-移动
            imgPens.Cursor = new Cursor(new MemoryStream(Properties.Resources._154));
        }
        #endregion
    }
}
