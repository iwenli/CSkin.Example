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
 * * 创建时间：2013-09-07
 * * 说明：GetQQ.cs
 * *
********************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

namespace QQFriend
{
    public class GetQQ
    {
        public GetQQ() {

        }
        private HtmlDocument Document;
        WebBrowser browser = new WebBrowser();
        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        public bool Initialize() {
            browser.Url = new Uri("http://xui.ptlogin2.qq.com/cgi-bin/qlogin");
            while (browser.ReadyState != WebBrowserReadyState.Complete) {
                Application.DoEvents();
            }
            if (browser.Document.Url.AbsoluteUri == "http://xui.ptlogin2.qq.com/cgi-bin/qlogin") {
                Document = browser.Document;
                return true;
            }
            return false;
        }

        /// <summary>
        /// 暴力
        /// </summary>
        /// <returns></returns>
        public List<LoginedInfo> GetLoginedCache() {
            string htmlText = browser.Document.Body.InnerText;
            List<LoginedInfo> qqlist = new List<LoginedInfo>();
            string jscript = "javascript:for(var C=0;C<q_aUinList.length;C++){var D=q_aUinList[C];document.write(D.uin+\",\"+D.nick+\",\"+D.key+\"$\");}void(0);";
            browser.Navigate(jscript);
            string readText = browser.Document.Body.InnerText;
            while (readText == htmlText) {
                readText = browser.Document.Body.InnerText;
                Application.DoEvents();
            }
            if (readText.Contains("$")) {
                readText = readText.Substring(0, readText.Length - 1);
            }
            string[] sArry = readText.Split('$');
            for (int i = 0; i < sArry.Length; i++) {
                if (sArry[i] != "" && sArry[i].Contains(",")) {
                    string[] infos = Regex.Split(sArry[i], ",");
                    if (infos.Length == 3) {
                        qqlist.Add(new LoginedInfo(infos[0], infos[1], infos[2]));
                    }
                }
            }
            return qqlist;
        }

    }
    public class LoginedInfo
    {
        public LoginedInfo(string uin, string name, string key) {
            this.Uin = uin;
            this.Name = name;
            this.Key = key;
        }
        public string Uin { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public Image Head { get; set; }
    }
}
