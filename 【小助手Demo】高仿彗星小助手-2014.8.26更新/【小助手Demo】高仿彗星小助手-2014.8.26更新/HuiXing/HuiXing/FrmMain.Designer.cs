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
 * * 说明：FrmMain.Designer.cs
 * *
********************************************************************/

namespace HuiXing
{
    partial class FrmMain
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
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            CCWin.CmSysButton cmSysButton1 = new CCWin.CmSysButton();
            CCWin.CmSysButton cmSysButton2 = new CCWin.CmSysButton();
            this.tabShow = new CCWin.SkinControl.SkinTabControl();
            this.tabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.lodding = new CCWin.SkinControl.ProgressIndicator();
            this.webShow = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage4 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage5 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage6 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage7 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage8 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage9 = new CCWin.SkinControl.SkinTabPage();
            this.lblTs = new CCWin.SkinControl.SkinLabel();
            this.miniToolStrip = new CCWin.SkinControl.SkinToolStrip();
            this.SkinMenu = new CCWin.SkinControl.SkinContextMenuStrip();
            this.SkinTool1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool2 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool3 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool4 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool5 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool6 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool7 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool8 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool9 = new System.Windows.Forms.ToolStripMenuItem();
            this.tool1 = new System.Windows.Forms.ToolStripButton();
            this.tool2 = new System.Windows.Forms.ToolStripButton();
            this.tool3 = new System.Windows.Forms.ToolStripButton();
            this.tool4 = new System.Windows.Forms.ToolStripButton();
            this.tool5 = new System.Windows.Forms.ToolStripButton();
            this.tool6 = new System.Windows.Forms.ToolStripButton();
            this.tool7 = new System.Windows.Forms.ToolStripButton();
            this.tool8 = new System.Windows.Forms.ToolStripButton();
            this.tool9 = new System.Windows.Forms.ToolStripButton();
            this.tool10 = new System.Windows.Forms.ToolStripButton();
            this.ToolShow = new CCWin.SkinControl.SkinToolStrip();
            this.SkinToolMenu = new CCWin.SkinControl.SkinContextMenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.窗口置顶ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.软件设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.已管理员模式重启ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于彗星案例ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timColor = new System.Windows.Forms.Timer(this.components);
            this.tabShow.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SkinMenu.SuspendLayout();
            this.ToolShow.SuspendLayout();
            this.SkinToolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabShow
            // 
            this.tabShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.tabShow.Animation = animation1;
            this.tabShow.AnimationStart = false;
            this.tabShow.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabShow.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabShow.Controls.Add(this.tabPage1);
            this.tabShow.Controls.Add(this.tabPage2);
            this.tabShow.Controls.Add(this.tabPage3);
            this.tabShow.Controls.Add(this.tabPage4);
            this.tabShow.Controls.Add(this.tabPage5);
            this.tabShow.Controls.Add(this.tabPage6);
            this.tabShow.Controls.Add(this.tabPage7);
            this.tabShow.Controls.Add(this.tabPage8);
            this.tabShow.Controls.Add(this.tabPage9);
            this.tabShow.DrawType = CCWin.SkinControl.DrawStyle.Draw;
            this.tabShow.HeadBack = null;
            this.tabShow.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabShow.Interval = 5;
            this.tabShow.ItemSize = new System.Drawing.Size(68, 30);
            this.tabShow.Location = new System.Drawing.Point(7, 83);
            this.tabShow.Margin = new System.Windows.Forms.Padding(0);
            this.tabShow.Name = "tabShow";
            this.tabShow.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabShow.PageArrowDown")));
            this.tabShow.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabShow.PageArrowHover")));
            this.tabShow.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabShow.PageCloseHover")));
            this.tabShow.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabShow.PageCloseNormal")));
            this.tabShow.PageDown = ((System.Drawing.Image)(resources.GetObject("tabShow.PageDown")));
            this.tabShow.PageHover = ((System.Drawing.Image)(resources.GetObject("tabShow.PageHover")));
            this.tabShow.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabShow.PageNorml = null;
            this.tabShow.SelectedIndex = 0;
            this.tabShow.ShowToolTips = true;
            this.tabShow.Size = new System.Drawing.Size(620, 379);
            this.tabShow.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabShow.TabIndex = 2;
            this.tabShow.SelectedIndexChanged += new System.EventHandler(this.tabShow_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.skinPanel1);
            this.tabPage1.Controls.Add(this.lodding);
            this.tabPage1.Controls.Add(this.webShow);
            this.tabPage1.Location = new System.Drawing.Point(0, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(620, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主页";
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinPanel1.BackgroundImage = global::HuiXing.Properties.Resources.BaiduShurufa_2014_8_2_16_32_58;
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(620, 31);
            this.skinPanel1.TabIndex = 6;
            // 
            // lodding
            // 
            this.lodding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lodding.AutoStart = true;
            this.lodding.BackColor = System.Drawing.Color.Transparent;
            this.lodding.Location = new System.Drawing.Point(265, 114);
            this.lodding.Name = "lodding";
            this.lodding.Percentage = 0F;
            this.lodding.ShowText = true;
            this.lodding.Size = new System.Drawing.Size(90, 90);
            this.lodding.TabIndex = 1;
            this.lodding.Text = "加载中...";
            this.lodding.TextDisplay = CCWin.SkinControl.TextDisplayModes.Text;
            // 
            // webShow
            // 
            this.webShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webShow.Location = new System.Drawing.Point(0, 32);
            this.webShow.Margin = new System.Windows.Forms.Padding(0);
            this.webShow.MinimumSize = new System.Drawing.Size(20, 20);
            this.webShow.Name = "webShow";
            this.webShow.ScriptErrorsSuppressed = true;
            this.webShow.Size = new System.Drawing.Size(636, 336);
            this.webShow.TabIndex = 0;
            this.webShow.Url = new System.Uri("http://bbs.cskin.net/forum-40-1.html", System.UriKind.Absolute);
            this.webShow.Visible = false;
            this.webShow.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webShow_DocumentCompleted);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(0, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(620, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "FrmBbx";
            this.tabPage2.Text = "百宝箱";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(0, 30);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(620, 349);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = "FrmScSo";
            this.tabPage3.Text = "手册查询";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(0, 30);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(620, 349);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Tag = "FrmSpy";
            this.tabPage4.Text = "窗口SPY";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Location = new System.Drawing.Point(0, 30);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(620, 349);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Tag = "FrmWebSpy";
            this.tabPage5.Text = "网页SPY";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Location = new System.Drawing.Point(0, 30);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(620, 349);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Tag = "FrmPrcColor";
            this.tabPage6.Text = "屏幕取色";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.White;
            this.tabPage7.Location = new System.Drawing.Point(0, 30);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(620, 349);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Tag = "FrmPrcImg";
            this.tabPage7.Text = "屏幕截图";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.White;
            this.tabPage8.Location = new System.Drawing.Point(0, 30);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(620, 349);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Tag = "FrmExeManager";
            this.tabPage8.Text = "进程管理";
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.White;
            this.tabPage9.Location = new System.Drawing.Point(0, 30);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(620, 349);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Tag = "FrmReg";
            this.tabPage9.Text = "正则调试";
            // 
            // lblTs
            // 
            this.lblTs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTs.AutoSize = true;
            this.lblTs.BackColor = System.Drawing.Color.Transparent;
            this.lblTs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTs.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblTs.ForeColor = System.Drawing.Color.White;
            this.lblTs.Location = new System.Drawing.Point(5, 464);
            this.lblTs.Name = "lblTs";
            this.lblTs.Size = new System.Drawing.Size(118, 20);
            this.lblTs.TabIndex = 2;
            this.lblTs.Tag = "当前版本:V4.1.5.0";
            this.lblTs.Text = "当前版本:V4.1.5.0";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.Arrow = System.Drawing.Color.Black;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Back = System.Drawing.Color.White;
            this.miniToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.miniToolStrip.BackgroundImage = global::HuiXing.Properties.Resources.BaiduShurufa_2014_8_2_16_32_58;
            this.miniToolStrip.BackRadius = 4;
            this.miniToolStrip.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.miniToolStrip.Base = System.Drawing.Color.Transparent;
            this.miniToolStrip.BaseFore = System.Drawing.Color.Black;
            this.miniToolStrip.BaseForeAnamorphosis = false;
            this.miniToolStrip.BaseForeAnamorphosisBorder = 4;
            this.miniToolStrip.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.miniToolStrip.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.miniToolStrip.BaseHoverFore = System.Drawing.Color.Black;
            this.miniToolStrip.BaseItemAnamorphosis = true;
            this.miniToolStrip.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.miniToolStrip.BaseItemBorderShow = true;
            this.miniToolStrip.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("miniToolStrip.BaseItemDown")));
            this.miniToolStrip.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.miniToolStrip.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("miniToolStrip.BaseItemMouse")));
            this.miniToolStrip.BaseItemNorml = ((System.Drawing.Image)(resources.GetObject("miniToolStrip.BaseItemNorml")));
            this.miniToolStrip.BaseItemPressed = System.Drawing.Color.Transparent;
            this.miniToolStrip.BaseItemRadius = 2;
            this.miniToolStrip.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.miniToolStrip.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.miniToolStrip.BindTabControl = null;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.miniToolStrip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miniToolStrip.Fore = System.Drawing.Color.Black;
            this.miniToolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.HoverFore = System.Drawing.Color.White;
            this.miniToolStrip.ItemAnamorphosis = false;
            this.miniToolStrip.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.miniToolStrip.ItemBorderShow = false;
            this.miniToolStrip.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.miniToolStrip.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.miniToolStrip.ItemRadius = 1;
            this.miniToolStrip.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(595, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.miniToolStrip.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.miniToolStrip.Size = new System.Drawing.Size(597, 25);
            this.miniToolStrip.SkinAllColor = true;
            this.miniToolStrip.TabIndex = 125;
            this.miniToolStrip.TitleAnamorphosis = false;
            this.miniToolStrip.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.miniToolStrip.TitleRadius = 4;
            this.miniToolStrip.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // SkinMenu
            // 
            this.SkinMenu.Arrow = System.Drawing.Color.Black;
            this.SkinMenu.Back = System.Drawing.Color.White;
            this.SkinMenu.BackRadius = 4;
            this.SkinMenu.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.SkinMenu.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SkinMenu.Fore = System.Drawing.Color.Black;
            this.SkinMenu.HoverFore = System.Drawing.Color.White;
            this.SkinMenu.ItemAnamorphosis = false;
            this.SkinMenu.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SkinMenu.ItemBorderShow = false;
            this.SkinMenu.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SkinMenu.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SkinMenu.ItemRadius = 4;
            this.SkinMenu.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.SkinMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SkinTool1,
            this.SkinTool2,
            this.SkinTool3,
            this.SkinTool4,
            this.SkinTool5,
            this.SkinTool6,
            this.SkinTool7,
            this.SkinTool8,
            this.SkinTool9});
            this.SkinMenu.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SkinMenu.Name = "skinContextMenuStrip1";
            this.SkinMenu.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.SkinMenu.Size = new System.Drawing.Size(125, 202);
            this.SkinMenu.SkinAllColor = true;
            this.SkinMenu.TitleAnamorphosis = false;
            this.SkinMenu.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.SkinMenu.TitleRadius = 4;
            this.SkinMenu.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // SkinTool1
            // 
            this.SkinTool1.Checked = true;
            this.SkinTool1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SkinTool1.Name = "SkinTool1";
            this.SkinTool1.Size = new System.Drawing.Size(124, 22);
            this.SkinTool1.Tag = "0";
            this.SkinTool1.Text = "默认皮肤";
            this.SkinTool1.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool2
            // 
            this.SkinTool2.Name = "SkinTool2";
            this.SkinTool2.Size = new System.Drawing.Size(124, 22);
            this.SkinTool2.Tag = "1";
            this.SkinTool2.Text = "绚彩紫色";
            this.SkinTool2.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool3
            // 
            this.SkinTool3.Name = "SkinTool3";
            this.SkinTool3.Size = new System.Drawing.Size(124, 22);
            this.SkinTool3.Tag = "2";
            this.SkinTool3.Text = "悠然百合";
            this.SkinTool3.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool4
            // 
            this.SkinTool4.Name = "SkinTool4";
            this.SkinTool4.Size = new System.Drawing.Size(124, 22);
            this.SkinTool4.Tag = "3";
            this.SkinTool4.Text = "漫舞派对";
            this.SkinTool4.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool5
            // 
            this.SkinTool5.Name = "SkinTool5";
            this.SkinTool5.Size = new System.Drawing.Size(124, 22);
            this.SkinTool5.Tag = "4";
            this.SkinTool5.Text = "绿化环保";
            this.SkinTool5.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool6
            // 
            this.SkinTool6.Name = "SkinTool6";
            this.SkinTool6.Size = new System.Drawing.Size(124, 22);
            this.SkinTool6.Tag = "5";
            this.SkinTool6.Text = "蔚蓝风车";
            this.SkinTool6.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool7
            // 
            this.SkinTool7.Name = "SkinTool7";
            this.SkinTool7.Size = new System.Drawing.Size(124, 22);
            this.SkinTool7.Tag = "6";
            this.SkinTool7.Text = "固若精钢";
            this.SkinTool7.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool8
            // 
            this.SkinTool8.Name = "SkinTool8";
            this.SkinTool8.Size = new System.Drawing.Size(124, 22);
            this.SkinTool8.Tag = "7";
            this.SkinTool8.Text = "原木韵味";
            this.SkinTool8.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool9
            // 
            this.SkinTool9.Name = "SkinTool9";
            this.SkinTool9.Size = new System.Drawing.Size(124, 22);
            this.SkinTool9.Tag = "8";
            this.SkinTool9.Text = "恭贺新春";
            this.SkinTool9.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // tool1
            // 
            this.tool1.AutoSize = false;
            this.tool1.Checked = true;
            this.tool1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tool1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool1.Margin = new System.Windows.Forms.Padding(0);
            this.tool1.Name = "tool1";
            this.tool1.Size = new System.Drawing.Size(60, 50);
            this.tool1.Tag = "0";
            this.tool1.Text = "主页";
            // 
            // tool2
            // 
            this.tool2.AutoSize = false;
            this.tool2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool2.Margin = new System.Windows.Forms.Padding(0);
            this.tool2.Name = "tool2";
            this.tool2.Size = new System.Drawing.Size(60, 50);
            this.tool2.Tag = "1";
            this.tool2.Text = "百宝箱";
            // 
            // tool3
            // 
            this.tool3.AutoSize = false;
            this.tool3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool3.Margin = new System.Windows.Forms.Padding(0);
            this.tool3.Name = "tool3";
            this.tool3.Size = new System.Drawing.Size(60, 50);
            this.tool3.Tag = "2";
            this.tool3.Text = "手册查询";
            // 
            // tool4
            // 
            this.tool4.AutoSize = false;
            this.tool4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool4.Margin = new System.Windows.Forms.Padding(0);
            this.tool4.Name = "tool4";
            this.tool4.Size = new System.Drawing.Size(60, 50);
            this.tool4.Tag = "3";
            this.tool4.Text = "窗口SPY";
            // 
            // tool5
            // 
            this.tool5.AutoSize = false;
            this.tool5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool5.Margin = new System.Windows.Forms.Padding(0);
            this.tool5.Name = "tool5";
            this.tool5.Size = new System.Drawing.Size(60, 50);
            this.tool5.Tag = "4";
            this.tool5.Text = "网页SPY";
            // 
            // tool6
            // 
            this.tool6.AutoSize = false;
            this.tool6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool6.Margin = new System.Windows.Forms.Padding(0);
            this.tool6.Name = "tool6";
            this.tool6.Size = new System.Drawing.Size(60, 50);
            this.tool6.Tag = "5";
            this.tool6.Text = "屏幕取色";
            // 
            // tool7
            // 
            this.tool7.AutoSize = false;
            this.tool7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool7.Margin = new System.Windows.Forms.Padding(0);
            this.tool7.Name = "tool7";
            this.tool7.Size = new System.Drawing.Size(60, 50);
            this.tool7.Tag = "6";
            this.tool7.Text = "屏幕截图";
            // 
            // tool8
            // 
            this.tool8.AutoSize = false;
            this.tool8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool8.Margin = new System.Windows.Forms.Padding(0);
            this.tool8.Name = "tool8";
            this.tool8.Size = new System.Drawing.Size(60, 50);
            this.tool8.Tag = "7";
            this.tool8.Text = "进程管理";
            // 
            // tool9
            // 
            this.tool9.AutoSize = false;
            this.tool9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool9.Margin = new System.Windows.Forms.Padding(0);
            this.tool9.Name = "tool9";
            this.tool9.Size = new System.Drawing.Size(60, 50);
            this.tool9.Tag = "8";
            this.tool9.Text = "正则调试";
            // 
            // tool10
            // 
            this.tool10.AutoSize = false;
            this.tool10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool10.Margin = new System.Windows.Forms.Padding(0);
            this.tool10.Name = "tool10";
            this.tool10.Size = new System.Drawing.Size(60, 50);
            this.tool10.Text = "应用盒子";
            this.tool10.Visible = false;
            // 
            // ToolShow
            // 
            this.ToolShow.Arrow = System.Drawing.Color.Black;
            this.ToolShow.AutoSize = false;
            this.ToolShow.Back = System.Drawing.Color.White;
            this.ToolShow.BackColor = System.Drawing.Color.Transparent;
            this.ToolShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToolShow.BackgroundImage")));
            this.ToolShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolShow.BackRadius = 4;
            this.ToolShow.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.ToolShow.Base = System.Drawing.Color.Transparent;
            this.ToolShow.BaseFore = System.Drawing.Color.Black;
            this.ToolShow.BaseForeAnamorphosis = false;
            this.ToolShow.BaseForeAnamorphosisBorder = 4;
            this.ToolShow.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.ToolShow.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.ToolShow.BaseHoverFore = System.Drawing.Color.White;
            this.ToolShow.BaseItemAnamorphosis = true;
            this.ToolShow.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.BaseItemBorderShow = true;
            this.ToolShow.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("ToolShow.BaseItemDown")));
            this.ToolShow.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("ToolShow.BaseItemMouse")));
            this.ToolShow.BaseItemNorml = null;
            this.ToolShow.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.BaseItemRadius = 4;
            this.ToolShow.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.ToolShow.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.BindTabControl = this.tabShow;
            this.ToolShow.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolShow.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.ToolShow.Fore = System.Drawing.Color.Black;
            this.ToolShow.GripMargin = new System.Windows.Forms.Padding(0);
            this.ToolShow.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolShow.HoverFore = System.Drawing.Color.White;
            this.ToolShow.ItemAnamorphosis = true;
            this.ToolShow.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.ItemBorderShow = true;
            this.ToolShow.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.ItemRadius = 4;
            this.ToolShow.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.ToolShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool1,
            this.tool2,
            this.tool3,
            this.tool4,
            this.tool5,
            this.tool6,
            this.tool7,
            this.tool8,
            this.tool9,
            this.tool10});
            this.ToolShow.Location = new System.Drawing.Point(7, 28);
            this.ToolShow.Name = "ToolShow";
            this.ToolShow.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.ToolShow.Size = new System.Drawing.Size(541, 52);
            this.ToolShow.SkinAllColor = true;
            this.ToolShow.TabIndex = 1;
            this.ToolShow.Text = "skinToolStrip1";
            this.ToolShow.TitleAnamorphosis = true;
            this.ToolShow.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.ToolShow.TitleRadius = 4;
            this.ToolShow.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            // 
            // SkinToolMenu
            // 
            this.SkinToolMenu.Arrow = System.Drawing.Color.Black;
            this.SkinToolMenu.Back = System.Drawing.Color.White;
            this.SkinToolMenu.BackRadius = 4;
            this.SkinToolMenu.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.SkinToolMenu.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SkinToolMenu.Fore = System.Drawing.Color.Black;
            this.SkinToolMenu.HoverFore = System.Drawing.Color.White;
            this.SkinToolMenu.ItemAnamorphosis = false;
            this.SkinToolMenu.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SkinToolMenu.ItemBorderShow = false;
            this.SkinToolMenu.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SkinToolMenu.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SkinToolMenu.ItemRadius = 4;
            this.SkinToolMenu.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.SkinToolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem4,
            this.窗口置顶ToolStripMenuItem,
            this.软件设置ToolStripMenuItem,
            this.toolStripMenuItem6,
            this.已管理员模式重启ToolStripMenuItem,
            this.关于彗星案例ToolStripMenuItem,
            this.toolStripMenuItem7,
            this.退出ToolStripMenuItem});
            this.SkinToolMenu.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SkinToolMenu.Name = "SkinToolMenu";
            this.SkinToolMenu.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.SkinToolMenu.Size = new System.Drawing.Size(149, 154);
            this.SkinToolMenu.SkinAllColor = true;
            this.SkinToolMenu.TitleAnamorphosis = false;
            this.SkinToolMenu.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.SkinToolMenu.TitleRadius = 4;
            this.SkinToolMenu.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem5.Text = "显示主界面";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(145, 6);
            // 
            // 窗口置顶ToolStripMenuItem
            // 
            this.窗口置顶ToolStripMenuItem.Checked = true;
            this.窗口置顶ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.窗口置顶ToolStripMenuItem.Name = "窗口置顶ToolStripMenuItem";
            this.窗口置顶ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.窗口置顶ToolStripMenuItem.Text = "窗口置顶";
            // 
            // 软件设置ToolStripMenuItem
            // 
            this.软件设置ToolStripMenuItem.Name = "软件设置ToolStripMenuItem";
            this.软件设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.软件设置ToolStripMenuItem.Text = "软件设置";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(145, 6);
            // 
            // 已管理员模式重启ToolStripMenuItem
            // 
            this.已管理员模式重启ToolStripMenuItem.Name = "已管理员模式重启ToolStripMenuItem";
            this.已管理员模式重启ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.已管理员模式重启ToolStripMenuItem.Text = "访问CSkin";
            // 
            // 关于彗星案例ToolStripMenuItem
            // 
            this.关于彗星案例ToolStripMenuItem.Name = "关于彗星案例ToolStripMenuItem";
            this.关于彗星案例ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.关于彗星案例ToolStripMenuItem.Text = "关于彗星案例";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(145, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(176)))), ((int)(((byte)(215)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BorderPalace = ((System.Drawing.Image)(resources.GetObject("$this.BorderPalace")));
            this.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(635, 485);
            this.CloseBoxSize = new System.Drawing.Size(39, 20);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.ControlBoxOffset = new System.Drawing.Point(0, -1);
            this.Controls.Add(this.tabShow);
            this.Controls.Add(this.lblTs);
            this.Controls.Add(this.ToolShow);
            this.EffectBack = System.Drawing.Color.Black;
            this.EffectWidth = 5;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ICoOffset = new System.Drawing.Point(5, 0);
            this.MaxDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxDownBack")));
            this.MaxMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxMouseBack")));
            this.MaxNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxNormlBack")));
            this.MaxSize = new System.Drawing.Size(28, 20);
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MinimumSize = new System.Drawing.Size(635, 485);
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(28, 20);
            this.Name = "FrmMain";
            this.RestoreDownBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreDownBack")));
            this.RestoreMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreMouseBack")));
            this.RestoreNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreNormlBack")));
            this.ShadowPalace = ((System.Drawing.Image)(resources.GetObject("$this.ShadowPalace")));
            this.ShowSystemMenu = true;
            this.SkinOpacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            cmSysButton1.Bounds = new System.Drawing.Rectangle(512, -1, 28, 20);
            cmSysButton1.BoxState = CCWin.ControlBoxState.Normal;
            cmSysButton1.Location = new System.Drawing.Point(512, -1);
            cmSysButton1.Name = "ToolSet";
            cmSysButton1.OwnerForm = this;
            cmSysButton1.SysButtonDown = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonDown")));
            cmSysButton1.SysButtonMouse = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonMouse")));
            cmSysButton1.SysButtonNorml = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonNorml")));
            cmSysButton1.ToolTip = "设置";
            cmSysButton2.Bounds = new System.Drawing.Rectangle(484, -1, 28, 20);
            cmSysButton2.BoxState = CCWin.ControlBoxState.Normal;
            cmSysButton2.Location = new System.Drawing.Point(484, -1);
            cmSysButton2.Name = "ToolSkin";
            cmSysButton2.OwnerForm = this;
            cmSysButton2.SysButtonDown = ((System.Drawing.Image)(resources.GetObject("cmSysButton2.SysButtonDown")));
            cmSysButton2.SysButtonMouse = ((System.Drawing.Image)(resources.GetObject("cmSysButton2.SysButtonMouse")));
            cmSysButton2.SysButtonNorml = ((System.Drawing.Image)(resources.GetObject("cmSysButton2.SysButtonNorml")));
            cmSysButton2.ToolTip = "皮肤";
            this.SysButtonItems.AddRange(new CCWin.CmSysButton[] {
            cmSysButton1,
            cmSysButton2});
            this.Text = "彗星小助手";
            this.TitleColor = System.Drawing.Color.White;
            this.TopMost = true;
            this.SysBottomClick += new CCWin.CCSkinMain.SysBottomEventHandler(this.FrmMain_SysBottomClick);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMain_Paint);
            this.tabShow.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.SkinMenu.ResumeLayout(false);
            this.ToolShow.ResumeLayout(false);
            this.ToolShow.PerformLayout();
            this.SkinToolMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinToolStrip miniToolStrip;
        private CCWin.SkinControl.SkinContextMenuStrip SkinMenu;
        private System.Windows.Forms.ToolStripMenuItem SkinTool1;
        private System.Windows.Forms.ToolStripMenuItem SkinTool2;
        private System.Windows.Forms.ToolStripMenuItem SkinTool3;
        private System.Windows.Forms.ToolStripMenuItem SkinTool4;
        private System.Windows.Forms.ToolStripMenuItem SkinTool5;
        private System.Windows.Forms.ToolStripMenuItem SkinTool6;
        private System.Windows.Forms.ToolStripMenuItem SkinTool7;
        private System.Windows.Forms.ToolStripMenuItem SkinTool8;
        private System.Windows.Forms.ToolStripMenuItem SkinTool9;
        private CCWin.SkinControl.SkinTabControl tabShow;
        private CCWin.SkinControl.SkinTabPage tabPage1;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.ProgressIndicator lodding;
        private System.Windows.Forms.WebBrowser webShow;
        private CCWin.SkinControl.SkinTabPage tabPage2;
        private CCWin.SkinControl.SkinTabPage tabPage3;
        private CCWin.SkinControl.SkinTabPage tabPage4;
        private CCWin.SkinControl.SkinTabPage tabPage5;
        private CCWin.SkinControl.SkinTabPage tabPage6;
        private CCWin.SkinControl.SkinTabPage tabPage7;
        private CCWin.SkinControl.SkinTabPage tabPage8;
        private CCWin.SkinControl.SkinTabPage tabPage9;
        private System.Windows.Forms.ToolStripButton tool1;
        private System.Windows.Forms.ToolStripButton tool2;
        private System.Windows.Forms.ToolStripButton tool3;
        private System.Windows.Forms.ToolStripButton tool4;
        private System.Windows.Forms.ToolStripButton tool5;
        private System.Windows.Forms.ToolStripButton tool6;
        private System.Windows.Forms.ToolStripButton tool7;
        private System.Windows.Forms.ToolStripButton tool8;
        private System.Windows.Forms.ToolStripButton tool9;
        private System.Windows.Forms.ToolStripButton tool10;
        private CCWin.SkinControl.SkinToolStrip ToolShow;
        private CCWin.SkinControl.SkinContextMenuStrip SkinToolMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 窗口置顶ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 软件设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem 已管理员模式重启ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于彗星案例ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer timColor;
        public CCWin.SkinControl.SkinLabel lblTs;
    }
}

