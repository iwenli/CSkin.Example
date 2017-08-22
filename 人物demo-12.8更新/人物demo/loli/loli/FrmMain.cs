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
 * * 作者： 乔克斯 QQ：345015918 .Net项目技术组群：306485590
 * * 请保留以上版权信息，否则作者将保留追究法律责任。
 * *
 * * 创建时间：2013-12-08
 * * 说明：FrmMain.cs
 * *
********************************************************************/

using CCWin;
using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace loli
{
    /// <summary>
    /// 继承SkinMain，实现异形窗体
    /// </summary>
    public partial class FrmMain : SkinMain
    {
        public FrmMain() {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e) {
            ImgShow.Image = null;
            int i = Convert.ToInt32((sender as SkinButton).Tag);
            //根据各按钮的Tag值变换表情
            ImgShow.BackgroundImage = i == 0 ?
                Properties.Resources.cry : i == 1 ?
                Properties.Resources.fine : i == 2 ?
                Properties.Resources.proud : i == 3 ?
                Properties.Resources.surprise : Properties.Resources.wink;
        }

        //窗口加载时
        WebBrowser web;
        private void FrmMain_Load(object sender, EventArgs e) {
            web = new WebBrowser();
            //多线程
            Thread threadInvalidate = new Thread(new ThreadStart(() => {
                //使用百度语音朗读接口
                string dtxt = string.Format("<EMBED src=\"http://tts.baidu.com/text2audio?lan=zh&ie=UTF-8&text={0}\" autostart=\"ture\" loop=\"ture\"></EMBED>", UrlEncode("你好，我是CSkin机器人"));
                //跨线程调用控件
                this.Invoke(new MethodInvoker(delegate {
                    web.DocumentText = dtxt;
                }));
            }));
            threadInvalidate.IsBackground = true;
            threadInvalidate.Start();
        }

        //中文URL转码
        public static string UrlEncode(string str) {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.UTF8.GetBytes(str); //默认是System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < byStr.Length; i++) {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }
            return (sb.ToString());
        }
    }
}
