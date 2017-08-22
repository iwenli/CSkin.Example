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
 * * 说明：FrmPrcColor.cs
 * *
********************************************************************/

using CCWin.Win32;
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
    public partial class FrmPrcColor : Form
    {
        public FrmPrcColor() {
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

        #region 取色

        private void imgColorQ_MouseDown(object sender, MouseEventArgs e) {
            imgColorQ.BackgroundImage = Properties.Resources.ImgNorml;
            Cursor.Current = new Cursor(new MemoryStream(Properties.Resources._142));
            timColor.Start();
        }

        private void imgColorQ_MouseUp(object sender, MouseEventArgs e) {
            imgColorQ.BackgroundImage = Properties.Resources.ImgColor;
            timColor.Stop();
        }

        /// <summary>
        /// 计时器取色-100毫秒取一次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timColor_Tick(object sender, EventArgs e) {
            Color c = GetColor(Cursor.Position.X, Cursor.Position.Y);
            //取10进制码
            uint c10 = (uint)(((uint)c.B << 16) | (ushort)(((ushort)c.G << 8) | c.R));
            txt10Color.Text = c10.ToString();
            //取16进制码
            txt16Color.Text = c10.ToString("X");
            //取RGB
            txtRgb.Text = string.Format("{0},{1},{2}", c.R, c.G, c.B);
            //取HSL
            txtHSL.Text = rgbToHsl(c.R, c.G, c.B);
            //取HTML颜色码
            txtHtml.Text = ColorTranslator.ToHtml(c);
            //取VB颜色码
            txtVB.Text = string.Format("&h{0}&", c10.ToString("X"));
            //取C/C++颜色码
            txtC.Text = string.Format("0x{0}", c10.ToString("X"));
            //取Delphi颜色码
            txtDelphi.Text = string.Format("${0}", c10.ToString("X"));
            //取AS码
            txtAs.Text = ColorTranslator.ToHtml(c).Replace("#", "0xFF");
        }
        #endregion

        #region 屏幕放大镜
        private void imgPBig_MouseDown(object sender, MouseEventArgs e) {
            imgPBig.BackgroundImage = Properties.Resources.ImgNorml;
            Cursor.Current = new Cursor(new MemoryStream(Properties.Resources._171));
        }

        private void imgPBig_MouseUp(object sender, MouseEventArgs e) {
            imgPBig.BackgroundImage = Properties.Resources.ImgPer;
        }
        #endregion

        #region 获取屏幕点颜色
        /// <summary>  
        ///   
        /// </summary>  
        /// <param name="x">鼠标相对于显示器的坐标X</param>  
        /// <param name="y">鼠标相对于显示器的坐标Y</param>  
        /// <returns></returns>  
        public Color GetColor(int x, int y) {
            IntPtr hdc = NativeMethods.GetDC(IntPtr.Zero);
            uint pixel = NativeMethods.GetPixel(hdc, x, y);
            NativeMethods.ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF), (int)(pixel &
0x0000FF00) >> 8, (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }
        #endregion

        #region RGB转换HSL
        private string rgbToHsl(int color_R, int color_G, int color_B) {
            double R = color_R / 255.00;
            double G = color_G / 255.00;
            double B = color_B / 255.00;
            double max, min, diff, r_dist, g_dist, b_dist;
            double h, s, l;
            max = Math.Max(Math.Max(R, G), B);
            min = Math.Min(Math.Min(R, G), B);
            diff = max - min;
            l = (max + min) / 2.00 * 100.00;
            if (diff == 0) {
                h = 0;
                s = 0;
            } else {
                if (l < 50) {
                    s = diff / (max + min) * 100.00;
                } else {
                    s = diff / (2 - max - min) * 100.00;
                }
                r_dist = (max - R) / diff;
                g_dist = (max - G) / diff;
                b_dist = (max - B) / diff;
                h = b_dist - g_dist;
                if (R == max) {
                    h = b_dist - g_dist;
                } else if (G == max) {
                    h = 2 + r_dist - b_dist;
                } else if (B == max) {
                    h = 4 + g_dist - r_dist;
                }
                h *= 60;
                if (h < 0) {
                    h += 360;
                }
                if (h >= 360) {
                    h -= 360;
                }
            }
            return (int)h + "," + (int)s + "," + (int)l;
        }
        #endregion

        #region 复制颜色值
        private void btnCopy_Click(object sender, EventArgs e) {
            Button btn = (Button)sender;
            TextBox c = (TextBox)this.Controls[btn.Tag.ToString()];
            Clipboard.SetText(c.Text);
            MessageBox.Show("（" + c.Text + "）已复制。");
        } 
        #endregion
    }
}
