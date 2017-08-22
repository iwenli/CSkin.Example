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
 * * 说明：QQFriend.cs
 * *
********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QQFriend
{
    /// <summary>
    /// 好友列表数据集对象
    /// </summary>
    public class QQFriend
    {
        /// <summary>
        /// 好友列表
        /// </summary>
        public List<Item> items { get; set; }
        /// <summary>
        /// 分组列表
        /// </summary>
        public List<Gpname> gpnames { get; set; }
    }

    /// <summary>
    /// 好友
    /// </summary>
    public class Item
    {
        /// <summary>
        /// QQ
        /// </summary>
        public long uin { get; set; }
        /// <summary>
        /// 分组ID
        /// </summary>
        public int groupid { get; set; }
        /// <summary>
        /// QQ名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 特殊关注
        /// </summary>
        public string is_special { get; set; }
        /// <summary>
        /// 朋友网名称
        /// </summary>
        public string xyname { get; set; }
        /// <summary>
        /// 朋友网是否注册
        /// </summary>
        public string is_xy { get; set; }
        /// <summary>
        /// 朋友网头像地址
        /// </summary>
        public string xyurl { get; set; }
        /// <summary>
        /// QQ头像地址-50
        /// </summary>
        public string img { get; set; }
        /// <summary>
        /// QQ头像地址-100
        /// </summary>
        public string imgbig { get; set; }
        /// <summary>
        /// 黄站等级，0-9 -1:不是黄钻
        /// </summary>
        public int yellow { get; set; }
        /// <summary>
        /// 备注名
        /// </summary>
        public string realname { get; set; }
        /// <summary>
        /// 是否在线 1：在线 0：不在线
        /// </summary>
        public int online { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int gender { get; set; }
    }

    /// <summary>
    /// 分组
    /// </summary>
    public class Gpname
    {
        /// <summary>
        /// 分组ID
        /// </summary>
        public int gpid { get; set; }
        //分组名称
        public string gpname { get; set; }
        //排序ID
        public int sortid { get; set; }
    }
}
