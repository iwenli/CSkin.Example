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
 * * 说明：Tools.cs
 * *
********************************************************************/

using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace QQMetro.Helpers
{
    /// <summary>
    /// 工具类定义
    /// </summary>
    public class Tools
    {

        /// <summary>
        /// 二进制序列化
        /// </summary>
        /// <typeparam name="T">序列化的类型</typeparam>
        /// <param name="obj">序列化的对象</param>
        /// <param name="filename">序列化的XML文件名</param>
        public static void BinarySerializer<T>(T obj, string filename)
        {


            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    formatter.Serialize(fs, obj);
                }
                catch (SerializationException e)
                {
                    Trace.WriteLine(e);

                }
            }
        }

        /// <summary>
        /// 二进制反列化
        /// </summary>
        /// <typeparam name="T">反序列化的类型</typeparam>
        /// <param name="filename">反序列化的XML文件名</param>
        /// <returns>T类型对象</returns>
        public static T BinaryDeserialize<T>(string filename)
        {

            // 检查文件是否存在
            if (!File.Exists(filename))
            {
                return default(T);
            }
            T obj = default(T);
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    obj = (T)formatter.Deserialize(fs);
                }
                catch (SerializationException e)
                {
                    Trace.WriteLine(e);

                }
            }
            return obj;
        }

        /// <summary>
        /// 创建目录
        /// </summary>
        /// <param name="path">目录名</param>
        public static void CreateDir(string path)
        {
            string[] dirs = path.Split(char.Parse("\\"));
            string tmp = "";
            if (!Directory.Exists(path))
            {
                foreach (string item in dirs)
                {
                    tmp += item + "\\";
                    if (!Directory.Exists(tmp))
                    {
                        Directory.CreateDirectory(tmp);
                    }
                }
            }
        }


    }
    /// <summary>
    /// 安全助手类定义
    /// </summary>
    public class SecurityHelper
    {
        /// <summary>
        /// 获取字符串的 MD5 值
        /// </summary>
        /// <param name="text">字符串</param>
        /// <returns>MD5 值</returns>
        public static string GetStringMD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] encryptedBytes = md5.ComputeHash(Encoding.Default.GetBytes(text));

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < encryptedBytes.Length; i++)
            {
                sb.AppendFormat("{0:x2}", encryptedBytes[i]);
            }

            return sb.ToString();
        }

        /// <summary>
        /// 实现对一个文件md5的读取，path为文件路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetMD5(string path)
        {
            try
            {
                using (Stream file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    return GetMD5(file);
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        /// <summary>
        /// 获取流的 MD5 值
        /// </summary>
        /// <param name="s">流</param>
        /// <returns>MD5 值</returns>
        public static string GetMD5(Stream s)
        {
            byte[] hash_byte;
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                hash_byte = md5.ComputeHash(s);
            }
            return GetMD5String(hash_byte);
        }

        /// <summary>
        /// 获取数组的 MD5 值
        /// </summary>
        /// <param name="buffer">数组</param>
        /// <returns>MD5 值</returns>
        public static string GetMD5(byte[] buffer)
        {
            byte[] hash_byte;
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                hash_byte = md5.ComputeHash(buffer);
            }
            return GetMD5String(hash_byte);
        }

        /// <summary>
        /// 获取数组的 MD5 值
        /// </summary>
        /// <param name="buffer">数组</param>
        /// <param name="offset">偏移</param>
        /// <param name="count">长度</param>
        /// <returns>MD5 值</returns>
        public static string GetMD5(byte[] buffer, int offset, int count)
        {
            byte[] hash_byte;
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                hash_byte = md5.ComputeHash(buffer, offset, count);
            }
            return GetMD5String(hash_byte);
        }

        /// <summary>
        /// 获取数组的 MD5 值
        /// </summary>
        /// <param name="hash_byte">数组</param>
        /// <returns>MD5 值</returns>
        private static string GetMD5String(byte[] hash_byte)
        {
            string resule = BitConverter.ToString(hash_byte);
            resule = resule.Replace("-", "");
            return resule;
        }
    }
}
