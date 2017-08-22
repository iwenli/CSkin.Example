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
 * * 说明：FrmFileUp.cs
 * *
********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using CCWin.SkinControl;
using HuiXing.Properties;

namespace HuiXing
{
    public partial class FrmFileUp : Form
    {
        private Random _random;
        private Color _baseColor = Color.DarkGoldenrod;
        private Color _borderColor = Color.FromArgb(64, 64, 0);
        private Color _progressBarBarColor = Color.Gold;
        private Color _progressBarBorderColor = Color.Olive;
        private Color _progressBarTextColor = Color.Olive;

        public FrmFileUp()
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = fileTansfersContainer1;
            _random = new Random();
            SkinFileTransfersItem item;
            item = fileTansfersContainer1.AddItem(
                "发送文件",
                "123.rar",
                Resources.muzic.ToBitmap(),
                1024 * 1024 * 20,
                 FileTransfersItemStyle.Send);
            item.BaseColor = _baseColor;
            item.BorderColor = _borderColor;
            item.ProgressBarBarColor = _progressBarBarColor;
            item.ProgressBarBorderColor = _progressBarBorderColor;
            item.ProgressBarTextColor = _progressBarTextColor;
            item.CancelButtonClick += new EventHandler(item_CancelButtonClick);
            item.Start();

            item = fileTansfersContainer1.AddItem(
                "接收文件",
                "456.rar",
                Resources.film.ToBitmap(),
                1024 * 1024 * 10,
                 FileTransfersItemStyle.Receive);
            item.CancelButtonClick += new EventHandler(item_CancelButtonClick);
            item.Start();

            item = fileTansfersContainer1.AddItem(
               "接收文件",
               "789.rar",
               Resources.picture.ToBitmap(),
               1024 * 1024 * 15,
                FileTransfersItemStyle.ReadyReceive);
            item.SaveButtonClick += new EventHandler(item_SaveButtonClick);
            item.SaveToButtonClick += new EventHandler(item_SaveToButtonClick);
            item.RefuseButtonClick += new EventHandler(item_RefuseButtonClick);
            item.Start();
        }

        void item_RefuseButtonClick(object sender, EventArgs e)
        {
            SkinFileTransfersItem item = sender as SkinFileTransfersItem;
            MessageBox.Show(string.Format(
               "点击了 {0} - {1}，拒绝接收文件。",
               item.Text,
               item.FileName));
        }

        void item_SaveToButtonClick(object sender, EventArgs e)
        {
            SkinFileTransfersItem item = sender as SkinFileTransfersItem;
            MessageBox.Show(string.Format(
               "点击了 {0} - {1}，保存文件到...。",
               item.Text,
               item.FileName));
        }

        void item_SaveButtonClick(object sender, EventArgs e)
        {
            SkinFileTransfersItem item = sender as SkinFileTransfersItem;
            MessageBox.Show(string.Format(
               "点击了 {0} - {1}，保存文件。",
               item.Text,
               item.FileName));
        }

        void item_CancelButtonClick(object sender, EventArgs e)
        {
            SkinFileTransfersItem item = sender as SkinFileTransfersItem;
            MessageBox.Show(string.Format(
                "点击了 {0} - {1}，取消发送文件。",
                item.Text,
                item.FileName));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int length = _random.Next(80, 150) * 1024;
            foreach (SkinFileTransfersItem item in fileTansfersContainer1.Controls)
            {
                if (item.TotalTransfersSize + length >
                    item.FileSize)
                {
                    item.TotalTransfersSize = 0;
                }
                else
                {
                    item.TotalTransfersSize += length;
                }
            }
        }
    }
}