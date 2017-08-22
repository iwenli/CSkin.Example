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
 * * 说明：FrmChat.cs
 * *
********************************************************************/

using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QQMetro
{
    public partial class FrmChat : Form
    {
        public FrmChat() {
            InitializeComponent();
        }

        private void FrmChat_Load(object sender, EventArgs e) {
            Image img = Image.FromFile(Application.StartupPath + "//1.png");
            GifBox gif = txtSend.InsertImage((Image)img.Clone());
            gif.MouseDown += gif_MouseDown;
            img.Dispose();
            this.txtSend.DragDrop += new DragEventHandler(txtSend_DragDrop);
            this.txtSend.DragEnter += new DragEventHandler(txtSend_DragEnter);
        }

        void gif_MouseDown(object sender, MouseEventArgs e) {
            if (e.Clicks == 2 && e.Button == MouseButtons.Left) {
                GifBox gif = (GifBox)sender;
                FrmPrintscreen frm = new FrmPrintscreen(gif.Image);
                frm.Show(this);
            }
        }

        private void btnAddImg_Click(object sender, EventArgs e) {
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                Image img = Image.FromFile(open.FileName);
                GifBox gif = txtSend.InsertImage((Image)img.Clone());
                gif.MouseDown += gif_MouseDown;
                img.Dispose();
            }
        }

        private void txtSend_LinkClicked(object sender, LinkClickedEventArgs e) {
            try {
                Process.Start(e.LinkText);
            } catch {
                MessageBox.Show("无法打开链接。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void txtSend_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.All;
            else if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
        }

        void txtSend_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                string[] MyFiles;
                int i;
                // 将文件赋给一个数组。
                MyFiles = (string[])(e.Data.GetData(DataFormats.FileDrop));
                // 循环处理数组并将文件添加到列表中。
                for (i = 0; i <= MyFiles.Length - 1; i++) {
                    System.IO.FileInfo f = new System.IO.FileInfo(MyFiles[i]);
                    if (f.Exists) {
                        //SendFile(this, f.FullName);//触发发送文件事件
                    }
                }
            } else if (e.Data.GetDataPresent(DataFormats.Text) && this.txtSend.SelectedText != "")
                e.Effect = DragDropEffects.Move;
            else if (e.Data.GetDataPresent(DataFormats.Text) && this.txtSend.SelectedText == "")
                e.Effect = DragDropEffects.Copy;
        }

        //截图方法
        private FrmCapture m_frmCapture;
        private void StartCapture() {
            if (m_frmCapture == null || m_frmCapture.IsDisposed)
                m_frmCapture = new FrmCapture(txtSend);
            m_frmCapture.IsCaptureCursor = false;
            m_frmCapture.Show();
        }

        /// <summary>
        /// 截图按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateImg_Click(object sender, EventArgs e) {
            this.StartCapture();
        }

        //读取剪贴板
        private void btnPast_Click(object sender, EventArgs e) {
            System.Windows.Forms.IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text)) {//如果剪贴板中的数据是文本格式
                txtSend.AppendText((string)iData.GetData(DataFormats.Text));
            }
            if (iData.GetDataPresent(DataFormats.Bitmap)) {//如果剪贴板中的数据是文本格式
                imgShow.Image = (Bitmap)iData.GetData(DataFormats.Bitmap);
            }
            //Clipboard.SetDataObject(, true);
            //DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.V) {
                System.Windows.Forms.IDataObject iData = Clipboard.GetDataObject();
                if (iData.GetDataPresent(DataFormats.Bitmap)) {//如果剪贴板中的数据是文本格式
                    imgShow.Image = (Bitmap)iData.GetData(DataFormats.Bitmap);
                }
            }
        }
    }
}
