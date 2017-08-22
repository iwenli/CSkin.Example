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
 * * 说明：FrmPrcImg.Designer.cs
 * *
********************************************************************/

namespace HuiXing
{
    partial class FrmPrcImg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrcImg));
            this.colorShow = new System.Windows.Forms.ColorDialog();
            this.pnlImg = new CCWin.SkinControl.SkinPanel();
            this.imgPens = new CCWin.SkinControl.SkinPictureBox();
            this.skinPanel7 = new CCWin.SkinControl.SkinPanel();
            this.toolMenuPens = new CCWin.SkinControl.SkinToolStrip();
            this.btnPrc = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton44 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton45 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton46 = new System.Windows.Forms.ToolStripButton();
            this.btnImgBig = new System.Windows.Forms.ToolStripButton();
            this.btnImgSmall = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel12 = new System.Windows.Forms.ToolStripLabel();
            this.toolGj1 = new System.Windows.Forms.ToolStripButton();
            this.toolGj2 = new System.Windows.Forms.ToolStripButton();
            this.toolGj3 = new System.Windows.Forms.ToolStripButton();
            this.toolGj4 = new System.Windows.Forms.ToolStripButton();
            this.toolGj5 = new System.Windows.Forms.ToolStripButton();
            this.toolGj6 = new System.Windows.Forms.ToolStripButton();
            this.toolGj7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel13 = new System.Windows.Forms.ToolStripLabel();
            this.toolPen1 = new System.Windows.Forms.ToolStripButton();
            this.toolPen2 = new System.Windows.Forms.ToolStripButton();
            this.toolPen3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel14 = new System.Windows.Forms.ToolStripLabel();
            this.toolSelectColor = new System.Windows.Forms.ToolStripTextBox();
            this.btnColorSelect = new System.Windows.Forms.ToolStripButton();
            this.pnlImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPens)).BeginInit();
            this.skinPanel7.SuspendLayout();
            this.toolMenuPens.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImg
            // 
            this.pnlImg.AutoScroll = true;
            this.pnlImg.BackColor = System.Drawing.Color.Gray;
            this.pnlImg.Controls.Add(this.imgPens);
            this.pnlImg.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImg.DownBack = null;
            this.pnlImg.Location = new System.Drawing.Point(0, 31);
            this.pnlImg.MouseBack = null;
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.NormlBack = null;
            this.pnlImg.Size = new System.Drawing.Size(620, 348);
            this.pnlImg.TabIndex = 11;
            // 
            // imgPens
            // 
            this.imgPens.BackColor = System.Drawing.Color.White;
            this.imgPens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPens.Location = new System.Drawing.Point(134, 64);
            this.imgPens.Name = "imgPens";
            this.imgPens.Size = new System.Drawing.Size(352, 220);
            this.imgPens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPens.TabIndex = 8;
            this.imgPens.TabStop = false;
            this.imgPens.MouseDown += new System.Windows.Forms.MouseEventHandler(this.C_MouseDown);
            this.imgPens.MouseMove += new System.Windows.Forms.MouseEventHandler(this.C_MouseMove);
            // 
            // skinPanel7
            // 
            this.skinPanel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinPanel7.BackgroundImage = global::HuiXing.Properties.Resources.BaiduShurufa_2014_8_2_16_32_58;
            this.skinPanel7.Controls.Add(this.toolMenuPens);
            this.skinPanel7.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel7.DownBack = null;
            this.skinPanel7.Location = new System.Drawing.Point(0, 0);
            this.skinPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanel7.MouseBack = null;
            this.skinPanel7.Name = "skinPanel7";
            this.skinPanel7.NormlBack = null;
            this.skinPanel7.Size = new System.Drawing.Size(620, 31);
            this.skinPanel7.TabIndex = 10;
            // 
            // toolMenuPens
            // 
            this.toolMenuPens.Arrow = System.Drawing.Color.White;
            this.toolMenuPens.Back = System.Drawing.Color.White;
            this.toolMenuPens.BackColor = System.Drawing.Color.Transparent;
            this.toolMenuPens.BackRadius = 4;
            this.toolMenuPens.BackRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.toolMenuPens.Base = System.Drawing.Color.Transparent;
            this.toolMenuPens.BaseFore = System.Drawing.Color.Black;
            this.toolMenuPens.BaseForeAnamorphosis = false;
            this.toolMenuPens.BaseForeAnamorphosisBorder = 4;
            this.toolMenuPens.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.toolMenuPens.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.toolMenuPens.BaseHoverFore = System.Drawing.Color.Black;
            this.toolMenuPens.BaseItemAnamorphosis = true;
            this.toolMenuPens.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.toolMenuPens.BaseItemBorderShow = true;
            this.toolMenuPens.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("toolMenuPens.BaseItemDown")));
            this.toolMenuPens.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolMenuPens.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("toolMenuPens.BaseItemMouse")));
            this.toolMenuPens.BaseItemNorml = ((System.Drawing.Image)(resources.GetObject("toolMenuPens.BaseItemNorml")));
            this.toolMenuPens.BaseItemPressed = System.Drawing.Color.Transparent;
            this.toolMenuPens.BaseItemRadius = 2;
            this.toolMenuPens.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.toolMenuPens.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.toolMenuPens.BindTabControl = null;
            this.toolMenuPens.Dock = System.Windows.Forms.DockStyle.None;
            this.toolMenuPens.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.toolMenuPens.Fore = System.Drawing.Color.Black;
            this.toolMenuPens.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolMenuPens.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolMenuPens.HoverFore = System.Drawing.Color.White;
            this.toolMenuPens.ItemAnamorphosis = false;
            this.toolMenuPens.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.toolMenuPens.ItemBorderShow = false;
            this.toolMenuPens.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.toolMenuPens.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.toolMenuPens.ItemRadius = 1;
            this.toolMenuPens.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.toolMenuPens.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrc,
            this.toolStripButton44,
            this.toolStripButton45,
            this.toolStripSeparator4,
            this.toolStripButton46,
            this.btnImgBig,
            this.btnImgSmall,
            this.toolStripSeparator5,
            this.toolStripLabel12,
            this.toolGj1,
            this.toolGj2,
            this.toolGj3,
            this.toolGj4,
            this.toolGj5,
            this.toolGj6,
            this.toolGj7,
            this.toolStripSeparator6,
            this.toolStripLabel13,
            this.toolPen1,
            this.toolPen2,
            this.toolPen3,
            this.toolStripSeparator7,
            this.toolStripLabel14,
            this.toolSelectColor,
            this.btnColorSelect});
            this.toolMenuPens.Location = new System.Drawing.Point(5, 3);
            this.toolMenuPens.Name = "toolMenuPens";
            this.toolMenuPens.Padding = new System.Windows.Forms.Padding(0);
            this.toolMenuPens.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.toolMenuPens.Size = new System.Drawing.Size(614, 25);
            this.toolMenuPens.SkinAllColor = true;
            this.toolMenuPens.TabIndex = 132;
            this.toolMenuPens.Text = "skinToolStrip11";
            this.toolMenuPens.TitleAnamorphosis = false;
            this.toolMenuPens.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.toolMenuPens.TitleRadius = 4;
            this.toolMenuPens.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btnPrc
            // 
            this.btnPrc.AutoSize = false;
            this.btnPrc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrc.ForeColor = System.Drawing.Color.Black;
            this.btnPrc.Image = ((System.Drawing.Image)(resources.GetObject("btnPrc.Image")));
            this.btnPrc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrc.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnPrc.Name = "btnPrc";
            this.btnPrc.Size = new System.Drawing.Size(24, 24);
            this.btnPrc.Text = "屏幕截图";
            this.btnPrc.Click += new System.EventHandler(this.btnPrc_Click);
            // 
            // toolStripButton44
            // 
            this.toolStripButton44.AutoSize = false;
            this.toolStripButton44.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton44.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton44.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton44.Image")));
            this.toolStripButton44.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton44.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton44.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripButton44.Name = "toolStripButton44";
            this.toolStripButton44.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton44.Text = "复制到剪贴板";
            // 
            // toolStripButton45
            // 
            this.toolStripButton45.AutoSize = false;
            this.toolStripButton45.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton45.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton45.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton45.Image")));
            this.toolStripButton45.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton45.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton45.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripButton45.Name = "toolStripButton45";
            this.toolStripButton45.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton45.Text = "保存到文件";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton46
            // 
            this.toolStripButton46.AutoSize = false;
            this.toolStripButton46.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton46.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton46.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton46.Image")));
            this.toolStripButton46.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton46.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton46.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripButton46.Name = "toolStripButton46";
            this.toolStripButton46.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton46.Text = "撤销编辑";
            // 
            // btnImgBig
            // 
            this.btnImgBig.AutoSize = false;
            this.btnImgBig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImgBig.ForeColor = System.Drawing.Color.Black;
            this.btnImgBig.Image = ((System.Drawing.Image)(resources.GetObject("btnImgBig.Image")));
            this.btnImgBig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImgBig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImgBig.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnImgBig.Name = "btnImgBig";
            this.btnImgBig.Size = new System.Drawing.Size(24, 24);
            this.btnImgBig.Text = "放大";
            this.btnImgBig.Click += new System.EventHandler(this.btnImgBig_Click);
            // 
            // btnImgSmall
            // 
            this.btnImgSmall.AutoSize = false;
            this.btnImgSmall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImgSmall.ForeColor = System.Drawing.Color.Black;
            this.btnImgSmall.Image = ((System.Drawing.Image)(resources.GetObject("btnImgSmall.Image")));
            this.btnImgSmall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImgSmall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImgSmall.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnImgSmall.Name = "btnImgSmall";
            this.btnImgSmall.Size = new System.Drawing.Size(24, 24);
            this.btnImgSmall.Text = "缩小";
            this.btnImgSmall.Click += new System.EventHandler(this.btnImgSmall_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel12
            // 
            this.toolStripLabel12.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.toolStripLabel12.Name = "toolStripLabel12";
            this.toolStripLabel12.Size = new System.Drawing.Size(32, 25);
            this.toolStripLabel12.Text = "工具";
            // 
            // toolGj1
            // 
            this.toolGj1.AutoSize = false;
            this.toolGj1.Checked = true;
            this.toolGj1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolGj1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGj1.ForeColor = System.Drawing.Color.Black;
            this.toolGj1.Image = ((System.Drawing.Image)(resources.GetObject("toolGj1.Image")));
            this.toolGj1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolGj1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGj1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolGj1.Name = "toolGj1";
            this.toolGj1.Size = new System.Drawing.Size(24, 24);
            this.toolGj1.Tag = "1";
            this.toolGj1.Text = "手形工具";
            this.toolGj1.Click += new System.EventHandler(this.toolGj1_Click);
            // 
            // toolGj2
            // 
            this.toolGj2.AutoSize = false;
            this.toolGj2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGj2.ForeColor = System.Drawing.Color.Black;
            this.toolGj2.Image = ((System.Drawing.Image)(resources.GetObject("toolGj2.Image")));
            this.toolGj2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolGj2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGj2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolGj2.Name = "toolGj2";
            this.toolGj2.Size = new System.Drawing.Size(24, 24);
            this.toolGj2.Tag = "1";
            this.toolGj2.Text = "箭头工具";
            this.toolGj2.Click += new System.EventHandler(this.toolGj1_Click);
            // 
            // toolGj3
            // 
            this.toolGj3.AutoSize = false;
            this.toolGj3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGj3.ForeColor = System.Drawing.Color.Black;
            this.toolGj3.Image = ((System.Drawing.Image)(resources.GetObject("toolGj3.Image")));
            this.toolGj3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolGj3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGj3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolGj3.Name = "toolGj3";
            this.toolGj3.Size = new System.Drawing.Size(24, 24);
            this.toolGj3.Tag = "1";
            this.toolGj3.Text = "圆形工具";
            this.toolGj3.Click += new System.EventHandler(this.toolGj1_Click);
            // 
            // toolGj4
            // 
            this.toolGj4.AutoSize = false;
            this.toolGj4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGj4.ForeColor = System.Drawing.Color.Black;
            this.toolGj4.Image = ((System.Drawing.Image)(resources.GetObject("toolGj4.Image")));
            this.toolGj4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolGj4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGj4.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolGj4.Name = "toolGj4";
            this.toolGj4.Size = new System.Drawing.Size(24, 24);
            this.toolGj4.Tag = "1";
            this.toolGj4.Text = "矩形工具";
            this.toolGj4.Click += new System.EventHandler(this.toolGj1_Click);
            // 
            // toolGj5
            // 
            this.toolGj5.AutoSize = false;
            this.toolGj5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGj5.ForeColor = System.Drawing.Color.Black;
            this.toolGj5.Image = ((System.Drawing.Image)(resources.GetObject("toolGj5.Image")));
            this.toolGj5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolGj5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGj5.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolGj5.Name = "toolGj5";
            this.toolGj5.Size = new System.Drawing.Size(24, 24);
            this.toolGj5.Tag = "1";
            this.toolGj5.Text = "画刷工具";
            this.toolGj5.Click += new System.EventHandler(this.toolGj1_Click);
            // 
            // toolGj6
            // 
            this.toolGj6.AutoSize = false;
            this.toolGj6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGj6.ForeColor = System.Drawing.Color.Black;
            this.toolGj6.Image = ((System.Drawing.Image)(resources.GetObject("toolGj6.Image")));
            this.toolGj6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolGj6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGj6.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolGj6.Name = "toolGj6";
            this.toolGj6.Size = new System.Drawing.Size(24, 24);
            this.toolGj6.Tag = "1";
            this.toolGj6.Text = "文本工具";
            this.toolGj6.Click += new System.EventHandler(this.toolGj1_Click);
            // 
            // toolGj7
            // 
            this.toolGj7.AutoSize = false;
            this.toolGj7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGj7.ForeColor = System.Drawing.Color.Black;
            this.toolGj7.Image = ((System.Drawing.Image)(resources.GetObject("toolGj7.Image")));
            this.toolGj7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolGj7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGj7.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolGj7.Name = "toolGj7";
            this.toolGj7.Size = new System.Drawing.Size(24, 24);
            this.toolGj7.Tag = "1";
            this.toolGj7.Text = "提示工具";
            this.toolGj7.Click += new System.EventHandler(this.toolGj1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel13
            // 
            this.toolStripLabel13.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.toolStripLabel13.Name = "toolStripLabel13";
            this.toolStripLabel13.Size = new System.Drawing.Size(32, 25);
            this.toolStripLabel13.Text = "画笔";
            // 
            // toolPen1
            // 
            this.toolPen1.AutoSize = false;
            this.toolPen1.Checked = true;
            this.toolPen1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolPen1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPen1.ForeColor = System.Drawing.Color.Black;
            this.toolPen1.Image = ((System.Drawing.Image)(resources.GetObject("toolPen1.Image")));
            this.toolPen1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolPen1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPen1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolPen1.Name = "toolPen1";
            this.toolPen1.Size = new System.Drawing.Size(24, 24);
            this.toolPen1.Tag = "2";
            this.toolPen1.Text = "画笔粗细";
            this.toolPen1.Click += new System.EventHandler(this.toolPen1_Click);
            // 
            // toolPen2
            // 
            this.toolPen2.AutoSize = false;
            this.toolPen2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPen2.ForeColor = System.Drawing.Color.Black;
            this.toolPen2.Image = ((System.Drawing.Image)(resources.GetObject("toolPen2.Image")));
            this.toolPen2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolPen2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPen2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolPen2.Name = "toolPen2";
            this.toolPen2.Size = new System.Drawing.Size(24, 24);
            this.toolPen2.Tag = "2";
            this.toolPen2.Text = "画笔粗细";
            this.toolPen2.Click += new System.EventHandler(this.toolPen1_Click);
            // 
            // toolPen3
            // 
            this.toolPen3.AutoSize = false;
            this.toolPen3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPen3.ForeColor = System.Drawing.Color.Black;
            this.toolPen3.Image = ((System.Drawing.Image)(resources.GetObject("toolPen3.Image")));
            this.toolPen3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolPen3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPen3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolPen3.Name = "toolPen3";
            this.toolPen3.Size = new System.Drawing.Size(24, 24);
            this.toolPen3.Tag = "2";
            this.toolPen3.Text = "画笔粗细";
            this.toolPen3.Click += new System.EventHandler(this.toolPen1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel14
            // 
            this.toolStripLabel14.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.toolStripLabel14.Name = "toolStripLabel14";
            this.toolStripLabel14.Size = new System.Drawing.Size(32, 25);
            this.toolStripLabel14.Text = "颜色";
            // 
            // toolSelectColor
            // 
            this.toolSelectColor.AutoSize = false;
            this.toolSelectColor.BackColor = System.Drawing.Color.Red;
            this.toolSelectColor.Enabled = false;
            this.toolSelectColor.ForeColor = System.Drawing.Color.Black;
            this.toolSelectColor.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolSelectColor.Name = "toolSelectColor";
            this.toolSelectColor.ReadOnly = true;
            this.toolSelectColor.Size = new System.Drawing.Size(24, 24);
            // 
            // btnColorSelect
            // 
            this.btnColorSelect.AutoSize = false;
            this.btnColorSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnColorSelect.ForeColor = System.Drawing.Color.Black;
            this.btnColorSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnColorSelect.Image")));
            this.btnColorSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnColorSelect.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnColorSelect.Name = "btnColorSelect";
            this.btnColorSelect.Size = new System.Drawing.Size(15, 24);
            this.btnColorSelect.Text = "选择颜色";
            this.btnColorSelect.Click += new System.EventHandler(this.btnColorSelect_Click);
            // 
            // FrmPrcImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(620, 379);
            this.Controls.Add(this.pnlImg);
            this.Controls.Add(this.skinPanel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(620, 379);
            this.Name = "FrmPrcImg";
            this.Text = "FrmPrcImg";
            this.Load += new System.EventHandler(this.FrmPrcImg_Load);
            this.pnlImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPens)).EndInit();
            this.skinPanel7.ResumeLayout(false);
            this.skinPanel7.PerformLayout();
            this.toolMenuPens.ResumeLayout(false);
            this.toolMenuPens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel pnlImg;
        private CCWin.SkinControl.SkinPanel skinPanel7;
        private CCWin.SkinControl.SkinToolStrip toolMenuPens;
        private System.Windows.Forms.ToolStripButton btnPrc;
        private System.Windows.Forms.ToolStripButton toolStripButton44;
        private System.Windows.Forms.ToolStripButton toolStripButton45;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton46;
        private System.Windows.Forms.ToolStripButton btnImgBig;
        private System.Windows.Forms.ToolStripButton btnImgSmall;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel12;
        private System.Windows.Forms.ToolStripButton toolGj1;
        private System.Windows.Forms.ToolStripButton toolGj2;
        private System.Windows.Forms.ToolStripButton toolGj3;
        private System.Windows.Forms.ToolStripButton toolGj4;
        private System.Windows.Forms.ToolStripButton toolGj5;
        private System.Windows.Forms.ToolStripButton toolGj6;
        private System.Windows.Forms.ToolStripButton toolGj7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel13;
        private System.Windows.Forms.ToolStripButton toolPen1;
        private System.Windows.Forms.ToolStripButton toolPen2;
        private System.Windows.Forms.ToolStripButton toolPen3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel14;
        private System.Windows.Forms.ToolStripTextBox toolSelectColor;
        private System.Windows.Forms.ToolStripButton btnColorSelect;
        private System.Windows.Forms.ColorDialog colorShow;
        private CCWin.SkinControl.SkinPictureBox imgPens;
    }
}