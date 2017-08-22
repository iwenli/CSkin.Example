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
 * * 说明：FrmLogin.Designer.cs
 * *
********************************************************************/

namespace QQMetro
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            CCWin.CmSysButton cmSysButton1 = new CCWin.CmSysButton();
            this.pnlTx = new CCWin.SkinControl.SkinPanel();
            this.pnlImgTx = new CCWin.SkinControl.SkinPanel();
            this.btnState = new CCWin.SkinControl.SkinButton();
            this.btnDuoId = new CCWin.SkinControl.SkinButton();
            this.btnSw = new CCWin.SkinControl.SkinButton();
            this.btnDl = new CCWin.SkinControl.SkinButton();
            this.chkMima = new CCWin.SkinControl.SkinCheckBox();
            this.btnMima = new CCWin.SkinControl.SkinButton();
            this.btnZc = new CCWin.SkinControl.SkinButton();
            this.btnId = new CCWin.SkinControl.SkinButton();
            this.txtPwd = new CCWin.SkinControl.SkinTextBox();
            this.btnJpPwd = new CCWin.SkinControl.SkinButton();
            this.txtId = new CCWin.SkinControl.SkinTextBox();
            this.chkZdLogin = new CCWin.SkinControl.SkinCheckBox();
            this.MenuId = new CCWin.SkinControl.SkinContextMenuStrip();
            this.MenuState = new CCWin.SkinControl.SkinContextMenuStrip();
            this.ItemImonline = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemQme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemAway = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemBusy = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMute = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemInVisble = new System.Windows.Forms.ToolStripMenuItem();
            this.toolShow = new System.Windows.Forms.ToolTip(this.components);
            this.tuopan = new System.Windows.Forms.NotifyIcon(this.components);
            this.QQMenu = new CCWin.SkinControl.SkinContextMenuStrip();
            this.toolQQShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pwdErro = new QQMetro.PwdErro();
            this.loginCode = new QQMetro.LoginCode();
            this.pnlTx.SuspendLayout();
            this.pnlImgTx.SuspendLayout();
            this.txtPwd.SuspendLayout();
            this.txtId.SuspendLayout();
            this.MenuState.SuspendLayout();
            this.QQMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTx
            // 
            this.pnlTx.BackColor = System.Drawing.Color.Transparent;
            this.pnlTx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTx.BackgroundImage")));
            this.pnlTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTx.Controls.Add(this.pnlImgTx);
            this.pnlTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlTx.DownBack = null;
            this.pnlTx.Location = new System.Drawing.Point(42, 195);
            this.pnlTx.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTx.MouseBack = null;
            this.pnlTx.Name = "pnlTx";
            this.pnlTx.NormlBack = null;
            this.pnlTx.Size = new System.Drawing.Size(82, 82);
            this.pnlTx.TabIndex = 13;
            // 
            // pnlImgTx
            // 
            this.pnlImgTx.BackColor = System.Drawing.Color.Transparent;
            this.pnlImgTx.BackgroundImage = global::QQMetro.Properties.Resources._4;
            this.pnlImgTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImgTx.Controls.Add(this.btnState);
            this.pnlImgTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlImgTx.DownBack = null;
            this.pnlImgTx.Location = new System.Drawing.Point(1, 1);
            this.pnlImgTx.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImgTx.MouseBack = null;
            this.pnlImgTx.Name = "pnlImgTx";
            this.pnlImgTx.NormlBack = null;
            this.pnlImgTx.Radius = 4;
            this.pnlImgTx.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.pnlImgTx.Size = new System.Drawing.Size(80, 80);
            this.pnlImgTx.TabIndex = 12;
            // 
            // btnState
            // 
            this.btnState.BackColor = System.Drawing.Color.Transparent;
            this.btnState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnState.BackRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.btnState.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnState.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnState.DownBack = ((System.Drawing.Image)(resources.GetObject("btnState.DownBack")));
            this.btnState.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnState.Image = ((System.Drawing.Image)(resources.GetObject("btnState.Image")));
            this.btnState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnState.Location = new System.Drawing.Point(62, 61);
            this.btnState.Margin = new System.Windows.Forms.Padding(0);
            this.btnState.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnState.MouseBack")));
            this.btnState.Name = "btnState";
            this.btnState.NormlBack = null;
            this.btnState.Palace = true;
            this.btnState.Size = new System.Drawing.Size(18, 18);
            this.btnState.TabIndex = 12;
            this.btnState.Tag = "1";
            this.btnState.UseVisualStyleBackColor = false;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // btnDuoId
            // 
            this.btnDuoId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDuoId.BackColor = System.Drawing.Color.Transparent;
            this.btnDuoId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnDuoId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDuoId.DownBack = ((System.Drawing.Image)(resources.GetObject("btnDuoId.DownBack")));
            this.btnDuoId.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnDuoId.Location = new System.Drawing.Point(9, 301);
            this.btnDuoId.Margin = new System.Windows.Forms.Padding(0);
            this.btnDuoId.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnDuoId.MouseBack")));
            this.btnDuoId.Name = "btnDuoId";
            this.btnDuoId.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnDuoId.NormlBack")));
            this.btnDuoId.Size = new System.Drawing.Size(24, 24);
            this.btnDuoId.TabIndex = 14;
            this.toolShow.SetToolTip(this.btnDuoId, "多帐号登录");
            this.btnDuoId.UseVisualStyleBackColor = false;
            // 
            // btnSw
            // 
            this.btnSw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSw.BackColor = System.Drawing.Color.Transparent;
            this.btnSw.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnSw.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSw.DownBack = ((System.Drawing.Image)(resources.GetObject("btnSw.DownBack")));
            this.btnSw.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnSw.Location = new System.Drawing.Point(399, 301);
            this.btnSw.Margin = new System.Windows.Forms.Padding(0);
            this.btnSw.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnSw.MouseBack")));
            this.btnSw.Name = "btnSw";
            this.btnSw.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnSw.NormlBack")));
            this.btnSw.Size = new System.Drawing.Size(24, 24);
            this.btnSw.TabIndex = 15;
            this.toolShow.SetToolTip(this.btnSw, "二维码登录");
            this.btnSw.UseVisualStyleBackColor = false;
            // 
            // btnDl
            // 
            this.btnDl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDl.BackColor = System.Drawing.Color.Transparent;
            this.btnDl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDl.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnDl.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnDl.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDl.DownBack = ((System.Drawing.Image)(resources.GetObject("btnDl.DownBack")));
            this.btnDl.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnDl.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnDl.ForeColor = System.Drawing.Color.White;
            this.btnDl.Location = new System.Drawing.Point(133, 288);
            this.btnDl.Margin = new System.Windows.Forms.Padding(0);
            this.btnDl.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnDl.MouseBack")));
            this.btnDl.Name = "btnDl";
            this.btnDl.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnDl.NormlBack")));
            this.btnDl.Size = new System.Drawing.Size(194, 30);
            this.btnDl.TabIndex = 3;
            this.btnDl.Text = "登  录";
            this.btnDl.UseVisualStyleBackColor = false;
            this.btnDl.Click += new System.EventHandler(this.btnDl_Click);
            // 
            // chkMima
            // 
            this.chkMima.AutoSize = true;
            this.chkMima.BackColor = System.Drawing.Color.Transparent;
            this.chkMima.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkMima.DefaultCheckButtonWidth = 17;
            this.chkMima.DownBack = ((System.Drawing.Image)(resources.GetObject("chkMima.DownBack")));
            this.chkMima.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkMima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.chkMima.LightEffect = false;
            this.chkMima.Location = new System.Drawing.Point(133, 260);
            this.chkMima.MouseBack = ((System.Drawing.Image)(resources.GetObject("chkMima.MouseBack")));
            this.chkMima.Name = "chkMima";
            this.chkMima.NormlBack = ((System.Drawing.Image)(resources.GetObject("chkMima.NormlBack")));
            this.chkMima.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("chkMima.SelectedDownBack")));
            this.chkMima.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("chkMima.SelectedMouseBack")));
            this.chkMima.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("chkMima.SelectedNormlBack")));
            this.chkMima.Size = new System.Drawing.Size(75, 21);
            this.chkMima.TabIndex = 1;
            this.chkMima.Text = "记住密码";
            this.chkMima.UseVisualStyleBackColor = false;
            this.chkMima.CheckedChanged += new System.EventHandler(this.chkMima_CheckedChanged);
            // 
            // btnMima
            // 
            this.btnMima.BackColor = System.Drawing.Color.Transparent;
            this.btnMima.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnMima.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnMima.Create = true;
            this.btnMima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMima.DownBack = ((System.Drawing.Image)(resources.GetObject("btnMima.DownBack")));
            this.btnMima.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnMima.Location = new System.Drawing.Point(337, 235);
            this.btnMima.Margin = new System.Windows.Forms.Padding(0);
            this.btnMima.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnMima.MouseBack")));
            this.btnMima.Name = "btnMima";
            this.btnMima.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnMima.NormlBack")));
            this.btnMima.Size = new System.Drawing.Size(48, 11);
            this.btnMima.TabIndex = 38;
            this.btnMima.UseVisualStyleBackColor = false;
            // 
            // btnZc
            // 
            this.btnZc.BackColor = System.Drawing.Color.Transparent;
            this.btnZc.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnZc.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnZc.Create = true;
            this.btnZc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZc.DownBack = ((System.Drawing.Image)(resources.GetObject("btnZc.DownBack")));
            this.btnZc.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnZc.Location = new System.Drawing.Point(337, 205);
            this.btnZc.Margin = new System.Windows.Forms.Padding(0);
            this.btnZc.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnZc.MouseBack")));
            this.btnZc.Name = "btnZc";
            this.btnZc.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnZc.NormlBack")));
            this.btnZc.Size = new System.Drawing.Size(48, 11);
            this.btnZc.TabIndex = 37;
            this.btnZc.UseVisualStyleBackColor = false;
            // 
            // btnId
            // 
            this.btnId.BackColor = System.Drawing.Color.White;
            this.btnId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnId.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnId.DownBack = ((System.Drawing.Image)(resources.GetObject("btnId.DownBack")));
            this.btnId.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnId.IsEnabledDraw = false;
            this.btnId.Location = new System.Drawing.Point(170, 3);
            this.btnId.Margin = new System.Windows.Forms.Padding(0);
            this.btnId.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnId.MouseBack")));
            this.btnId.Name = "btnId";
            this.btnId.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnId.NormlBack")));
            this.btnId.Size = new System.Drawing.Size(22, 24);
            this.btnId.TabIndex = 36;
            this.btnId.UseVisualStyleBackColor = false;
            this.btnId.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnId_MouseDown);
            this.btnId.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.btnId.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.Transparent;
            this.txtPwd.Controls.Add(this.btnJpPwd);
            this.txtPwd.DownBack = null;
            this.txtPwd.Icon = null;
            this.txtPwd.IconIsButton = true;
            this.txtPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPwd.IsPasswordChat = '●';
            this.txtPwd.IsSystemPasswordChar = false;
            this.txtPwd.Lines = new string[0];
            this.txtPwd.Location = new System.Drawing.Point(133, 226);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(0);
            this.txtPwd.MaxLength = 32767;
            this.txtPwd.MinimumSize = new System.Drawing.Size(0, 28);
            this.txtPwd.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("txtPwd.MouseBack")));
            this.txtPwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPwd.Multiline = true;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("txtPwd.NormlBack")));
            this.txtPwd.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.txtPwd.ReadOnly = false;
            this.txtPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPwd.Size = new System.Drawing.Size(194, 30);
            // 
            // 
            // 
            this.txtPwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPwd.SkinTxt.Multiline = true;
            this.txtPwd.SkinTxt.Name = "BaseText";
            this.txtPwd.SkinTxt.PasswordChar = '●';
            this.txtPwd.SkinTxt.Size = new System.Drawing.Size(161, 20);
            this.txtPwd.SkinTxt.TabIndex = 0;
            this.txtPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPwd.SkinTxt.WaterText = "密码";
            this.txtPwd.TabIndex = 40;
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPwd.WaterText = "密码";
            this.txtPwd.WordWrap = true;
            // 
            // btnJpPwd
            // 
            this.btnJpPwd.BackColor = System.Drawing.Color.White;
            this.btnJpPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnJpPwd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnJpPwd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnJpPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJpPwd.DownBack = ((System.Drawing.Image)(resources.GetObject("btnJpPwd.DownBack")));
            this.btnJpPwd.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnJpPwd.Location = new System.Drawing.Point(172, 6);
            this.btnJpPwd.Margin = new System.Windows.Forms.Padding(0);
            this.btnJpPwd.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnJpPwd.MouseBack")));
            this.btnJpPwd.Name = "btnJpPwd";
            this.btnJpPwd.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnJpPwd.NormlBack")));
            this.btnJpPwd.Size = new System.Drawing.Size(15, 16);
            this.btnJpPwd.TabIndex = 41;
            this.toolShow.SetToolTip(this.btnJpPwd, "打开软键盘");
            this.btnJpPwd.UseVisualStyleBackColor = false;
            this.btnJpPwd.Click += new System.EventHandler(this.btnJpPwd_Click);
            this.btnJpPwd.MouseEnter += new System.EventHandler(this.btnJpPwd_MouseEnter);
            this.btnJpPwd.MouseLeave += new System.EventHandler(this.btnJpPwd_MouseLeave);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Transparent;
            this.txtId.Controls.Add(this.btnId);
            this.txtId.DownBack = null;
            this.txtId.Icon = null;
            this.txtId.IconIsButton = false;
            this.txtId.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtId.IsPasswordChat = '\0';
            this.txtId.IsSystemPasswordChar = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(133, 196);
            this.txtId.Margin = new System.Windows.Forms.Padding(0);
            this.txtId.MaxLength = 32767;
            this.txtId.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtId.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("txtId.MouseBack")));
            this.txtId.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("txtId.NormlBack")));
            this.txtId.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.txtId.ReadOnly = false;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.Size = new System.Drawing.Size(194, 30);
            // 
            // 
            // 
            this.txtId.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtId.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtId.SkinTxt.Multiline = true;
            this.txtId.SkinTxt.Name = "BaseText";
            this.txtId.SkinTxt.Size = new System.Drawing.Size(161, 20);
            this.txtId.SkinTxt.TabIndex = 0;
            this.txtId.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtId.SkinTxt.WaterText = "QQ号码/手机/邮箱";
            this.txtId.SkinTxt.TextChanged += new System.EventHandler(this.txtId_SkinTxt_TextChanged);
            this.txtId.TabIndex = 39;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtId.WaterText = "QQ号码/手机/邮箱";
            this.txtId.WordWrap = true;
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            this.txtId.MouseLeave += new System.EventHandler(this.txtId_MouseLeave);
            // 
            // chkZdLogin
            // 
            this.chkZdLogin.AutoSize = true;
            this.chkZdLogin.BackColor = System.Drawing.Color.Transparent;
            this.chkZdLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkZdLogin.DefaultCheckButtonWidth = 17;
            this.chkZdLogin.DownBack = ((System.Drawing.Image)(resources.GetObject("chkZdLogin.DownBack")));
            this.chkZdLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkZdLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.chkZdLogin.LightEffect = false;
            this.chkZdLogin.Location = new System.Drawing.Point(252, 260);
            this.chkZdLogin.MouseBack = ((System.Drawing.Image)(resources.GetObject("chkZdLogin.MouseBack")));
            this.chkZdLogin.Name = "chkZdLogin";
            this.chkZdLogin.NormlBack = ((System.Drawing.Image)(resources.GetObject("chkZdLogin.NormlBack")));
            this.chkZdLogin.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("chkZdLogin.SelectedDownBack")));
            this.chkZdLogin.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("chkZdLogin.SelectedMouseBack")));
            this.chkZdLogin.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("chkZdLogin.SelectedNormlBack")));
            this.chkZdLogin.Size = new System.Drawing.Size(75, 21);
            this.chkZdLogin.TabIndex = 2;
            this.chkZdLogin.Text = "自动登录";
            this.chkZdLogin.UseVisualStyleBackColor = false;
            this.chkZdLogin.CheckedChanged += new System.EventHandler(this.chkZdLogin_CheckedChanged);
            // 
            // MenuId
            // 
            this.MenuId.Arrow = System.Drawing.Color.Black;
            this.MenuId.AutoSize = false;
            this.MenuId.Back = System.Drawing.Color.White;
            this.MenuId.BackColor = System.Drawing.Color.White;
            this.MenuId.BackRadius = 4;
            this.MenuId.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.MenuId.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(209)))));
            this.MenuId.Fore = System.Drawing.Color.Black;
            this.MenuId.HoverFore = System.Drawing.Color.White;
            this.MenuId.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.MenuId.ItemAnamorphosis = false;
            this.MenuId.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuId.ItemBorderShow = false;
            this.MenuId.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuId.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuId.ItemRadius = 4;
            this.MenuId.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.MenuId.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.MenuId.Name = "MenuId";
            this.MenuId.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.MenuId.Size = new System.Drawing.Size(194, 4);
            this.MenuId.SkinAllColor = true;
            this.MenuId.TitleAnamorphosis = false;
            this.MenuId.TitleColor = System.Drawing.Color.White;
            this.MenuId.TitleRadius = 4;
            this.MenuId.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.MenuId.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.MenuId_Closing);
            // 
            // MenuState
            // 
            this.MenuState.Arrow = System.Drawing.Color.Black;
            this.MenuState.AutoSize = false;
            this.MenuState.Back = System.Drawing.Color.White;
            this.MenuState.BackRadius = 2;
            this.MenuState.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.MenuState.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.MenuState.Fore = System.Drawing.Color.Black;
            this.MenuState.HoverFore = System.Drawing.Color.White;
            this.MenuState.ImageScalingSize = new System.Drawing.Size(15, 15);
            this.MenuState.ItemAnamorphosis = false;
            this.MenuState.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuState.ItemBorderShow = false;
            this.MenuState.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuState.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuState.ItemRadius = 4;
            this.MenuState.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.MenuState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemImonline,
            this.ItemQme,
            this.toolStripMenuItem1,
            this.ItemAway,
            this.ItemBusy,
            this.ItemMute,
            this.toolStripMenuItem2,
            this.ItemInVisble});
            this.MenuState.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.MenuState.Name = "MenuState";
            this.MenuState.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.MenuState.Size = new System.Drawing.Size(106, 147);
            this.MenuState.SkinAllColor = true;
            this.MenuState.TitleAnamorphosis = false;
            this.MenuState.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.MenuState.TitleRadius = 2;
            this.MenuState.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            // 
            // ItemImonline
            // 
            this.ItemImonline.AutoSize = false;
            this.ItemImonline.Image = ((System.Drawing.Image)(resources.GetObject("ItemImonline.Image")));
            this.ItemImonline.Name = "ItemImonline";
            this.ItemImonline.Size = new System.Drawing.Size(105, 22);
            this.ItemImonline.Tag = "2";
            this.ItemImonline.Text = "我在线上";
            this.ItemImonline.ToolTipText = "表示希望好友看到您在线。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            this.ItemImonline.Click += new System.EventHandler(this.Item_Click);
            // 
            // ItemQme
            // 
            this.ItemQme.AutoSize = false;
            this.ItemQme.Image = ((System.Drawing.Image)(resources.GetObject("ItemQme.Image")));
            this.ItemQme.Name = "ItemQme";
            this.ItemQme.Size = new System.Drawing.Size(105, 22);
            this.ItemQme.Tag = "1";
            this.ItemQme.Text = "Q我把";
            this.ItemQme.ToolTipText = "表示希望好友主动联系您。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：自动弹出会话窗口\r\n";
            this.ItemQme.Click += new System.EventHandler(this.Item_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 6);
            // 
            // ItemAway
            // 
            this.ItemAway.AutoSize = false;
            this.ItemAway.Image = ((System.Drawing.Image)(resources.GetObject("ItemAway.Image")));
            this.ItemAway.Name = "ItemAway";
            this.ItemAway.Size = new System.Drawing.Size(105, 22);
            this.ItemAway.Tag = "3";
            this.ItemAway.Text = "离开";
            this.ItemAway.ToolTipText = "表示离开，暂无法处理消息。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            this.ItemAway.Click += new System.EventHandler(this.Item_Click);
            // 
            // ItemBusy
            // 
            this.ItemBusy.AutoSize = false;
            this.ItemBusy.Image = ((System.Drawing.Image)(resources.GetObject("ItemBusy.Image")));
            this.ItemBusy.Name = "ItemBusy";
            this.ItemBusy.Size = new System.Drawing.Size(105, 22);
            this.ItemBusy.Tag = "4";
            this.ItemBusy.Text = "忙碌";
            this.ItemBusy.ToolTipText = "表示忙碌，不会及时处理消息。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏显示气泡\r\n";
            this.ItemBusy.Click += new System.EventHandler(this.Item_Click);
            // 
            // ItemMute
            // 
            this.ItemMute.AutoSize = false;
            this.ItemMute.Image = ((System.Drawing.Image)(resources.GetObject("ItemMute.Image")));
            this.ItemMute.Name = "ItemMute";
            this.ItemMute.Size = new System.Drawing.Size(105, 22);
            this.ItemMute.Tag = "5";
            this.ItemMute.Text = "请勿打扰";
            this.ItemMute.ToolTipText = "表示不想被打扰。\r\n声音：关闭\r\n消息提醒框：关闭\r\n会话消息：任务栏显示气泡\r\n\r\n";
            this.ItemMute.Click += new System.EventHandler(this.Item_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 6);
            // 
            // ItemInVisble
            // 
            this.ItemInVisble.AutoSize = false;
            this.ItemInVisble.Image = ((System.Drawing.Image)(resources.GetObject("ItemInVisble.Image")));
            this.ItemInVisble.Name = "ItemInVisble";
            this.ItemInVisble.Size = new System.Drawing.Size(105, 22);
            this.ItemInVisble.Tag = "6";
            this.ItemInVisble.Text = "隐身";
            this.ItemInVisble.ToolTipText = "表示好友看到您是离线的。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            this.ItemInVisble.Click += new System.EventHandler(this.Item_Click);
            // 
            // tuopan
            // 
            this.tuopan.ContextMenuStrip = this.QQMenu;
            this.tuopan.Icon = ((System.Drawing.Icon)(resources.GetObject("tuopan.Icon")));
            this.tuopan.Text = "CC";
            this.tuopan.Visible = true;
            this.tuopan.DoubleClick += new System.EventHandler(this.toolQQShow_Click);
            // 
            // QQMenu
            // 
            this.QQMenu.Arrow = System.Drawing.Color.Black;
            this.QQMenu.AutoSize = false;
            this.QQMenu.Back = System.Drawing.Color.White;
            this.QQMenu.BackRadius = 2;
            this.QQMenu.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.QQMenu.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.QQMenu.Fore = System.Drawing.Color.Black;
            this.QQMenu.HoverFore = System.Drawing.Color.White;
            this.QQMenu.ImageScalingSize = new System.Drawing.Size(11, 11);
            this.QQMenu.ItemAnamorphosis = false;
            this.QQMenu.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(136)))), ((int)(((byte)(200)))));
            this.QQMenu.ItemBorderShow = false;
            this.QQMenu.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(136)))), ((int)(((byte)(200)))));
            this.QQMenu.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(136)))), ((int)(((byte)(200)))));
            this.QQMenu.ItemRadius = 4;
            this.QQMenu.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.QQMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolQQShow,
            this.toolStripMenuItem3,
            this.toolExit});
            this.QQMenu.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.QQMenu.Name = "MenuState";
            this.QQMenu.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.QQMenu.Size = new System.Drawing.Size(120, 53);
            this.QQMenu.SkinAllColor = true;
            this.QQMenu.TitleAnamorphosis = false;
            this.QQMenu.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.QQMenu.TitleRadius = 4;
            this.QQMenu.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            // 
            // toolQQShow
            // 
            this.toolQQShow.AutoSize = false;
            this.toolQQShow.Name = "toolQQShow";
            this.toolQQShow.Size = new System.Drawing.Size(119, 22);
            this.toolQQShow.Text = "打开主面板";
            this.toolQQShow.Click += new System.EventHandler(this.toolQQShow_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(116, 6);
            // 
            // toolExit
            // 
            this.toolExit.AutoSize = false;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(119, 22);
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // pwdErro
            // 
            this.pwdErro.BackColor = System.Drawing.Color.Transparent;
            this.pwdErro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pwdErro.BackgroundImage")));
            this.pwdErro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pwdErro.Diglog = System.Windows.Forms.DialogResult.None;
            this.pwdErro.Location = new System.Drawing.Point(426, 30);
            this.pwdErro.Name = "pwdErro";
            this.pwdErro.Size = new System.Drawing.Size(430, 300);
            this.pwdErro.TabIndex = 42;
            this.pwdErro.Visible = false;
            // 
            // loginCode
            // 
            this.loginCode.BackColor = System.Drawing.Color.Transparent;
            this.loginCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginCode.BackgroundImage")));
            this.loginCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginCode.Diglog = System.Windows.Forms.DialogResult.None;
            this.loginCode.Location = new System.Drawing.Point(422, 30);
            this.loginCode.Name = "loginCode";
            this.loginCode.Size = new System.Drawing.Size(430, 300);
            this.loginCode.TabIndex = 43;
            this.loginCode.Visible = false;
            this.loginCode.VisibleChanged += new System.EventHandler(this.loginCode_VisibleChanged);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnDl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackShade = false;
            this.BackToColor = false;
            this.CanResize = false;
            this.CaptionHeight = 30;
            this.ClientSize = new System.Drawing.Size(430, 330);
            this.CloseBoxSize = new System.Drawing.Size(30, 30);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.ControlBoxOffset = new System.Drawing.Point(0, 0);
            this.Controls.Add(this.pwdErro);
            this.Controls.Add(this.loginCode);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.chkZdLogin);
            this.Controls.Add(this.chkMima);
            this.Controls.Add(this.btnMima);
            this.Controls.Add(this.btnZc);
            this.Controls.Add(this.btnDl);
            this.Controls.Add(this.btnSw);
            this.Controls.Add(this.btnDuoId);
            this.Controls.Add(this.pnlTx);
            this.Controls.Add(this.txtPwd);
            this.DropBack = false;
            this.EffectCaption = CCWin.TitleType.None;
            this.MaxDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxDownBack")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 330);
            this.MaxMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxMouseBack")));
            this.MaxNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxNormlBack")));
            this.MaxSize = new System.Drawing.Size(30, 30);
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MinimumSize = new System.Drawing.Size(430, 330);
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(30, 30);
            this.MobileApi = false;
            this.Name = "FrmLogin";
            this.Radius = 2;
            this.RestoreDownBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreDownBack")));
            this.RestoreMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreMouseBack")));
            this.RestoreNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreNormlBack")));
            this.ShadowPalace = ((System.Drawing.Image)(resources.GetObject("$this.ShadowPalace")));
            this.ShadowWidth = 6;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            cmSysButton1.Bounds = new System.Drawing.Rectangle(340, 0, 30, 30);
            cmSysButton1.BoxState = CCWin.ControlBoxState.Normal;
            cmSysButton1.Location = new System.Drawing.Point(340, 0);
            cmSysButton1.Name = "SysSet";
            cmSysButton1.OwnerForm = this;
            cmSysButton1.Size = new System.Drawing.Size(30, 30);
            cmSysButton1.SysButtonDown = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonDown")));
            cmSysButton1.SysButtonMouse = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonMouse")));
            cmSysButton1.SysButtonNorml = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonNorml")));
            cmSysButton1.ToolTip = "设置";
            this.SysButtonItems.AddRange(new CCWin.CmSysButton[] {
            cmSysButton1});
            this.Text = "QQ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmLogin_VisibleChanged);
            this.pnlTx.ResumeLayout(false);
            this.pnlImgTx.ResumeLayout(false);
            this.txtPwd.ResumeLayout(false);
            this.txtPwd.PerformLayout();
            this.txtId.ResumeLayout(false);
            this.txtId.PerformLayout();
            this.MenuState.ResumeLayout(false);
            this.QQMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPanel pnlTx;
        private CCWin.SkinControl.SkinPanel pnlImgTx;
        private CCWin.SkinControl.SkinButton btnState;
        private CCWin.SkinControl.SkinButton btnDuoId;
        private CCWin.SkinControl.SkinButton btnSw;
        private CCWin.SkinControl.SkinButton btnDl;
        private CCWin.SkinControl.SkinCheckBox chkMima;
        private CCWin.SkinControl.SkinButton btnMima;
        private CCWin.SkinControl.SkinButton btnZc;
        private CCWin.SkinControl.SkinButton btnId;
        private CCWin.SkinControl.SkinTextBox txtPwd;
        private CCWin.SkinControl.SkinTextBox txtId;
        private CCWin.SkinControl.SkinCheckBox chkZdLogin;
        private CCWin.SkinControl.SkinButton btnJpPwd;
        private CCWin.SkinControl.SkinContextMenuStrip MenuId;
        private CCWin.SkinControl.SkinContextMenuStrip MenuState;
        private System.Windows.Forms.ToolStripMenuItem ItemImonline;
        private System.Windows.Forms.ToolStripMenuItem ItemQme;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ItemAway;
        private System.Windows.Forms.ToolStripMenuItem ItemBusy;
        private System.Windows.Forms.ToolStripMenuItem ItemMute;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ItemInVisble;
        private System.Windows.Forms.ToolTip toolShow;
        public System.Windows.Forms.NotifyIcon tuopan;
        private CCWin.SkinControl.SkinContextMenuStrip QQMenu;
        private System.Windows.Forms.ToolStripMenuItem toolQQShow;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private PwdErro pwdErro;
        private LoginCode loginCode;
    }
}

