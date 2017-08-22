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
 * * 说明：FileHelper.cs
 * *
********************************************************************/

namespace QQMetro.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    public static class FileHelper
    {
        public static void ClearDirectory(string dirPath)
        {
            string[] files = Directory.GetFiles(dirPath);
            foreach (string str in files)
            {
                File.Delete(str);
            }
            foreach (string str2 in Directory.GetDirectories(dirPath))
            {
                DeleteDirectory(str2);
            }
        }

        public static void Copy(string sourceParentDirectoryPath, IEnumerable<string> filesBeCopyed, IEnumerable<string> directoriesCopyed, string destParentDirectoryPath)
        {
            string str2;
            bool flag = sourceParentDirectoryPath == destParentDirectoryPath;
            if (filesBeCopyed != null)
            {
                foreach (string str in filesBeCopyed)
                {
                    str2 = str;
                    while (flag && File.Exists(destParentDirectoryPath + str2))
                    {
                        str2 = "副本-" + str2;
                    }
                    string path = sourceParentDirectoryPath + str;
                    if (File.Exists(path))
                    {
                        File.Copy(path, destParentDirectoryPath + str2);
                    }
                }
            }
            if (directoriesCopyed != null)
            {
                foreach (string str in directoriesCopyed)
                {
                    str2 = str;
                    while (flag && Directory.Exists(destParentDirectoryPath + str2))
                    {
                        str2 = "副本-" + str2;
                    }
                    if (Directory.Exists(sourceParentDirectoryPath + str))
                    {
                        CopyDirectoryAndFiles(sourceParentDirectoryPath, str, destParentDirectoryPath, str2);
                    }
                }
            }
        }

        private static void CopyDirectoryAndFiles(string sourceParentDirectoryPath, string dirBeCopyed, string destParentDirectoryPath, string newDirName)
        {
            Directory.CreateDirectory(destParentDirectoryPath + newDirName);
            DirectoryInfo info = new DirectoryInfo(sourceParentDirectoryPath + dirBeCopyed);
            foreach (FileInfo info2 in info.GetFiles())
            {
                File.Copy(info2.FullName, destParentDirectoryPath + newDirName + @"\" + info2.Name);
            }
            foreach (DirectoryInfo info3 in info.GetDirectories())
            {
                CopyDirectoryAndFiles(sourceParentDirectoryPath + dirBeCopyed + @"\", info3.Name, destParentDirectoryPath + newDirName + @"\", info3.Name);
            }
        }

        public static void DeleteDirectory(string dirPath)
        {
            foreach (string str in Directory.GetFiles(dirPath))
            {
                File.Delete(str);
            }
            foreach (string str2 in Directory.GetDirectories(dirPath))
            {
                DeleteDirectory(str2);
            }
            DirectoryInfo info = new DirectoryInfo(dirPath);
            info.Refresh();
            if ((info.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                info.Attributes &= ~FileAttributes.ReadOnly;
            }
            info.Delete();
        }

        public static void DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        private static void DoGetOffspringFiles(string rootPath, DirectoryInfo dir, ref List<string> list)
        {
            foreach (FileInfo info in dir.GetFiles())
            {
                list.Add(info.FullName.Substring(rootPath.Length));
            }
            foreach (DirectoryInfo info2 in dir.GetDirectories())
            {
                DoGetOffspringFiles(rootPath, info2, ref list);
            }
        }

        public static string EnsureExtendName(string origin_path, string extend_name)
        {
            if (Path.GetExtension(origin_path) != extend_name)
            {
                origin_path = origin_path + extend_name;
            }
            return origin_path;
        }

        public static void GenerateFile(string filePath, string text)
        {
            string directoryName = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
            FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(text);
            writer.Flush();
            writer.Close();
            stream.Close();
        }

        public static ulong GetDirectorySize(string dirPath)
        {
            if (!Directory.Exists(dirPath))
            {
                return 0L;
            }
            ulong num = 0L;
            DirectoryInfo info = new DirectoryInfo(dirPath);
            foreach (FileInfo info2 in info.GetFiles())
            {
                num += (ulong) info2.Length;
            }
            DirectoryInfo[] directories = info.GetDirectories();
            if (directories.Length > 0)
            {
                for (int i = 0; i < directories.Length; i++)
                {
                    num += GetDirectorySize(directories[i].FullName);
                }
            }
            return num;
        }

        public static string GetFileContent(string file_path)
        {
            if (!File.Exists(file_path))
            {
                return null;
            }
            StreamReader reader = new StreamReader(file_path, Encoding.UTF8);
            string str = reader.ReadToEnd();
            reader.Close();
            return str;
        }

        public static string GetFileDirectory(string filePath)
        {
            return Path.GetDirectoryName(filePath);
        }

        public static string GetFileNameNoPath(string filePath)
        {
            return Path.GetFileName(filePath);
        }

        public static ulong GetFileSize(string filePath)
        {
            FileInfo info = new FileInfo(filePath);
            return (ulong) info.Length;
        }

        public static string GetFileToOpen(string title)
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Filter = "All Files (*.*)|*.*",
                FileName = ""
            };
            if (title != null)
            {
                dialog.Title = title;
            }
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return null;
        }

        public static string GetFileToOpen(string title, string extendName, string iniDir)
        {
            return GetFileToOpen2(title, iniDir, new string[] { extendName });
        }

        public static string GetFileToOpen2(string title, string iniDir, params string[] extendNames)
        {
            int num;
            StringBuilder builder = new StringBuilder("(");
            for (num = 0; num < extendNames.Length; num++)
            {
                builder.Append("*");
                builder.Append(extendNames[num]);
                if (num < (extendNames.Length - 1))
                {
                    builder.Append(";");
                }
                else
                {
                    builder.Append(")");
                }
            }
            builder.Append("|");
            for (num = 0; num < extendNames.Length; num++)
            {
                builder.Append("*");
                builder.Append(extendNames[num]);
                if (num < (extendNames.Length - 1))
                {
                    builder.Append(";");
                }
            }
            OpenFileDialog dialog = new OpenFileDialog {
                Filter = builder.ToString(),
                FileName = "",
                InitialDirectory = iniDir
            };
            if (title != null)
            {
                dialog.Title = title;
            }
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return null;
        }

        public static string GetFolderToOpen(bool newFolderButton)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog {
                ShowNewFolderButton = newFolderButton
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.SelectedPath;
            }
            return null;
        }

        /// <summary>
        /// 获取目标目录下以及其子目录下的所有文件（采用相对路径）。
        /// </summary>
        /// <param name="dirPath"></param>
        /// <returns></returns>
        public static List<string> GetOffspringFiles(string dirPath)
        {
            List<string> list = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            DoGetOffspringFiles(dirPath, dir, ref list);
            return list;
        }

        public static string GetPathToSave(string title, string defaultName, string iniDir)
        {
            string extension = Path.GetExtension(defaultName);
            SaveFileDialog dialog = new SaveFileDialog {
                Filter = string.Format("The Files (*{0})|*{0}", extension),
                FileName = defaultName,
                InitialDirectory = iniDir,
                OverwritePrompt = false
            };
            if (title != null)
            {
                dialog.Title = title;
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return null;
        }

        public static void Move(string oldParentDirectoryPath, IEnumerable<string> filesBeMoved, IEnumerable<string> directoriesBeMoved, string newParentDirectoryPath)
        {
            string str2;
            if (filesBeMoved != null)
            {
                foreach (string str in filesBeMoved)
                {
                    str2 = oldParentDirectoryPath + str;
                    if (File.Exists(str2))
                    {
                        File.Move(str2, newParentDirectoryPath + str);
                    }
                }
            }
            if (directoriesBeMoved != null)
            {
                foreach (string str in directoriesBeMoved)
                {
                    str2 = oldParentDirectoryPath + str;
                    if (Directory.Exists(str2))
                    {
                        Directory.Move(str2, newParentDirectoryPath + str);
                    }
                }
            }
        }

        public static void ReadFileData(FileStream fs, byte[] buff, int count, int offset)
        {
            int num2;
            for (int i = 0; i < count; i += num2)
            {
                num2 = fs.Read(buff, offset + i, count - i);
            }
        }

        public static byte[] ReadFileReturnBytes(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return null;
            }
            FileStream input = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryReader reader = new BinaryReader(input);
            byte[] buffer = reader.ReadBytes((int) input.Length);
            reader.Close();
            input.Close();
            return buffer;
        }

        public static void WriteBuffToFile(byte[] buff, string filePath)
        {
            string directoryName = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
            FileStream output = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(output);
            writer.Write(buff);
            writer.Flush();
            writer.Close();
            output.Close();
        }

        public static void WriteBuffToFile(byte[] buff, int offset, int len, string filePath)
        {
            string directoryName = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
            FileStream output = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(output);
            writer.Write(buff, offset, len);
            writer.Flush();
            writer.Close();
            output.Close();
        }
    }
}

