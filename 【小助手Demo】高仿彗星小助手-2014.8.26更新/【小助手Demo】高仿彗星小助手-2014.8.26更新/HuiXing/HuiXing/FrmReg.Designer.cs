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
 * * 说明：FrmReg.Designer.cs
 * *
********************************************************************/

namespace HuiXing
{
    partial class FrmReg
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
            this.components = new System.ComponentModel.Container();
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReg));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("\\           将下一个字符标记为特殊字符或字面值。例如\"n\"与字符\"n\"匹配。\"\\n\"与换行符匹配。序列\"\\\\\"与\"\\\"匹配对面，\"\\(\"与\"(\"匹配。" +
        "", 0, 0);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("语法说明", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("匹配HTML标记", 5, 5);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("网页相关", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("\n匹配国内电话号码", 5, 5);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("特定号码", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("\n匹配中文字符", 5, 5);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("字符串相关", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("正则例程", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6,
            treeNode8});
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.skinTextBox3 = new CCWin.SkinControl.SkinTextBox();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.skinTextBox2 = new CCWin.SkinControl.SkinTextBox();
            this.skinTabPage10 = new CCWin.SkinControl.SkinTabPage();
            this.skinDataGridView3 = new CCWin.SkinControl.SkinDataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.tvMsg = new CCWin.SkinControl.SkinTreeView();
            this.skinPanel9 = new CCWin.SkinControl.SkinPanel();
            this.skinCheckBox3 = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBox2 = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBox1 = new CCWin.SkinControl.SkinCheckBox();
            this.skinToolStrip10 = new CCWin.SkinControl.SkinToolStrip();
            this.toolStripButton40 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton41 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TvImgList = new System.Windows.Forms.ImageList(this.components);
            this.skinTabControl1.SuspendLayout();
            this.skinTabPage1.SuspendLayout();
            this.skinTextBox3.SuspendLayout();
            this.skinTabPage2.SuspendLayout();
            this.skinTextBox2.SuspendLayout();
            this.skinTabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView3)).BeginInit();
            this.skinTextBox1.SuspendLayout();
            this.skinPanel9.SuspendLayout();
            this.skinToolStrip10.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            animation1.AnimateOnlyDifferences = false;
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
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.skinTabControl1.Animation = animation1;
            this.skinTabControl1.AnimationStart = false;
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage1);
            this.skinTabControl1.Controls.Add(this.skinTabPage2);
            this.skinTabControl1.Controls.Add(this.skinTabPage10);
            this.skinTabControl1.DrawType = CCWin.SkinControl.DrawStyle.Draw;
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(70, 26);
            this.skinTabControl1.Location = new System.Drawing.Point(245, 154);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageBaseColor = System.Drawing.SystemColors.Control;
            this.skinTabControl1.PageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(185)))), ((int)(((byte)(182)))));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(366, 218);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 11;
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.White;
            this.skinTabPage1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.skinTabPage1.Controls.Add(this.skinTextBox3);
            this.skinTabPage1.Location = new System.Drawing.Point(0, 26);
            this.skinTabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Padding = new System.Windows.Forms.Padding(7);
            this.skinTabPage1.Size = new System.Drawing.Size(366, 192);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.Text = "提示";
            // 
            // skinTextBox3
            // 
            this.skinTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox3.DownBack = null;
            this.skinTextBox3.Icon = null;
            this.skinTextBox3.IconIsButton = false;
            this.skinTextBox3.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox3.Location = new System.Drawing.Point(7, 7);
            this.skinTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox3.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox3.MouseBack = null;
            this.skinTextBox3.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox3.Name = "skinTextBox3";
            this.skinTextBox3.NormlBack = null;
            this.skinTextBox3.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox3.Size = new System.Drawing.Size(352, 178);
            // 
            // skinTextBox3.BaseText
            // 
            this.skinTextBox3.SkinTxt.BackColor = System.Drawing.Color.White;
            this.skinTextBox3.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox3.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox3.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox3.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox3.SkinTxt.Multiline = true;
            this.skinTextBox3.SkinTxt.Name = "BaseText";
            this.skinTextBox3.SkinTxt.ReadOnly = true;
            this.skinTextBox3.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.skinTextBox3.SkinTxt.Size = new System.Drawing.Size(342, 168);
            this.skinTextBox3.SkinTxt.TabIndex = 0;
            this.skinTextBox3.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox3.SkinTxt.WaterText = "";
            this.skinTextBox3.TabIndex = 12;
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.White;
            this.skinTabPage2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.skinTabPage2.Controls.Add(this.skinTextBox2);
            this.skinTabPage2.Location = new System.Drawing.Point(0, 26);
            this.skinTabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Padding = new System.Windows.Forms.Padding(7);
            this.skinTabPage2.Size = new System.Drawing.Size(366, 192);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.Text = "欲测试文本";
            // 
            // skinTextBox2
            // 
            this.skinTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox2.DownBack = null;
            this.skinTextBox2.Icon = null;
            this.skinTextBox2.IconIsButton = false;
            this.skinTextBox2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Location = new System.Drawing.Point(7, 7);
            this.skinTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox2.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox2.MouseBack = null;
            this.skinTextBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Name = "skinTextBox2";
            this.skinTextBox2.NormlBack = null;
            this.skinTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox2.Size = new System.Drawing.Size(352, 178);
            // 
            // skinTextBox2.BaseText
            // 
            this.skinTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox2.SkinTxt.Multiline = true;
            this.skinTextBox2.SkinTxt.Name = "BaseText";
            this.skinTextBox2.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.skinTextBox2.SkinTxt.Size = new System.Drawing.Size(342, 168);
            this.skinTextBox2.SkinTxt.TabIndex = 0;
            this.skinTextBox2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.SkinTxt.WaterText = "";
            this.skinTextBox2.TabIndex = 11;
            // 
            // skinTabPage10
            // 
            this.skinTabPage10.BackColor = System.Drawing.Color.White;
            this.skinTabPage10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.skinTabPage10.Controls.Add(this.skinDataGridView3);
            this.skinTabPage10.Location = new System.Drawing.Point(0, 26);
            this.skinTabPage10.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabPage10.Name = "skinTabPage10";
            this.skinTabPage10.Padding = new System.Windows.Forms.Padding(7);
            this.skinTabPage10.Size = new System.Drawing.Size(366, 192);
            this.skinTabPage10.TabIndex = 2;
            this.skinTabPage10.Text = "匹配结果";
            // 
            // skinDataGridView3
            // 
            this.skinDataGridView3.AllowUserToDeleteRows = false;
            this.skinDataGridView3.AllowUserToOrderColumns = true;
            this.skinDataGridView3.AlternatingCellBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.skinDataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.skinDataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.skinDataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.skinDataGridView3.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridView3.ColumnFont = null;
            this.skinDataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.skinDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.skinDataGridView3.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView3.DefaultCellStyle = dataGridViewCellStyle3;
            this.skinDataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinDataGridView3.EnableHeadersVisualStyles = false;
            this.skinDataGridView3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinDataGridView3.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.skinDataGridView3.HeadFont = new System.Drawing.Font("微软雅黑", 9F);
            this.skinDataGridView3.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView3.Location = new System.Drawing.Point(7, 7);
            this.skinDataGridView3.Margin = new System.Windows.Forms.Padding(10);
            this.skinDataGridView3.MouseCellBackColor = System.Drawing.Color.White;
            this.skinDataGridView3.MultiSelect = false;
            this.skinDataGridView3.Name = "skinDataGridView3";
            this.skinDataGridView3.ReadOnly = true;
            this.skinDataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView3.RowHeadersVisible = false;
            this.skinDataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.skinDataGridView3.RowTemplate.Height = 23;
            this.skinDataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skinDataGridView3.Size = new System.Drawing.Size(352, 178);
            this.skinDataGridView3.SkinGridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.skinDataGridView3.TabIndex = 10;
            this.skinDataGridView3.TitleBack = null;
            this.skinDataGridView3.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView3.TitleBackColorEnd = System.Drawing.SystemColors.Control;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "序号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "匹配文本";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Location = new System.Drawing.Point(245, 58);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.Size = new System.Drawing.Size(366, 93);
            // 
            // skinTextBox1.BaseText
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Multiline = true;
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(356, 83);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 10;
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(242, 39);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(80, 17);
            this.skinLabel2.TabIndex = 9;
            this.skinLabel2.Text = "正则表达式：";
            // 
            // tvMsg
            // 
            this.tvMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvMsg.BackColor = System.Drawing.Color.White;
            this.tvMsg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.tvMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvMsg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tvMsg.ImageIndex = 0;
            this.tvMsg.ImageList = this.TvImgList;
            this.tvMsg.ItemHeight = 20;
            this.tvMsg.Location = new System.Drawing.Point(6, 39);
            this.tvMsg.Name = "tvMsg";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "节点15";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Text = "\\           将下一个字符标记为特殊字符或字面值。例如\"n\"与字符\"n\"匹配。\"\\n\"与换行符匹配。序列\"\\\\\"与\"\\\"匹配对面，\"\\(\"与\"(\"匹配。" +
    "";
            treeNode2.ImageIndex = 4;
            treeNode2.Name = "节点9";
            treeNode2.SelectedImageIndex = 4;
            treeNode2.Text = "语法说明";
            treeNode2.ToolTipText = "语法说明";
            treeNode3.ImageIndex = 5;
            treeNode3.Name = "节点1";
            treeNode3.SelectedImageIndex = 5;
            treeNode3.Text = "匹配HTML标记";
            treeNode4.ImageIndex = 4;
            treeNode4.Name = "节点18";
            treeNode4.SelectedImageIndex = 4;
            treeNode4.Text = "网页相关";
            treeNode5.ImageIndex = 5;
            treeNode5.Name = "节点2";
            treeNode5.SelectedImageIndex = 5;
            treeNode5.Text = "\n匹配国内电话号码";
            treeNode6.ImageIndex = 4;
            treeNode6.Name = "节点19";
            treeNode6.SelectedImageIndex = 4;
            treeNode6.Text = "特定号码";
            treeNode7.ImageIndex = 5;
            treeNode7.Name = "节点3";
            treeNode7.SelectedImageIndex = 5;
            treeNode7.Text = "\n匹配中文字符";
            treeNode8.ImageIndex = 4;
            treeNode8.Name = "节点20";
            treeNode8.SelectedImageIndex = 4;
            treeNode8.Text = "字符串相关";
            treeNode9.ImageIndex = 4;
            treeNode9.Name = "节点14";
            treeNode9.SelectedImageIndex = 4;
            treeNode9.Text = "正则例程";
            this.tvMsg.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode9});
            this.tvMsg.SelectedImageIndex = 0;
            this.tvMsg.Size = new System.Drawing.Size(227, 333);
            this.tvMsg.TabIndex = 8;
            // 
            // skinPanel9
            // 
            this.skinPanel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinPanel9.BackgroundImage = global::HuiXing.Properties.Resources.BaiduShurufa_2014_8_2_16_32_58;
            this.skinPanel9.Controls.Add(this.skinCheckBox3);
            this.skinPanel9.Controls.Add(this.skinCheckBox2);
            this.skinPanel9.Controls.Add(this.skinCheckBox1);
            this.skinPanel9.Controls.Add(this.skinToolStrip10);
            this.skinPanel9.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel9.DownBack = null;
            this.skinPanel9.Location = new System.Drawing.Point(0, 0);
            this.skinPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanel9.MouseBack = null;
            this.skinPanel9.Name = "skinPanel9";
            this.skinPanel9.NormlBack = null;
            this.skinPanel9.Size = new System.Drawing.Size(620, 31);
            this.skinPanel9.TabIndex = 10;
            // 
            // skinCheckBox3
            // 
            this.skinCheckBox3.AutoSize = true;
            this.skinCheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox3.DefaultCheckButtonWidth = 13;
            this.skinCheckBox3.DownBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox3.DownBack")));
            this.skinCheckBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox3.LightEffect = false;
            this.skinCheckBox3.Location = new System.Drawing.Point(392, 5);
            this.skinCheckBox3.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox3.MouseBack")));
            this.skinCheckBox3.Name = "skinCheckBox3";
            this.skinCheckBox3.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox3.NormlBack")));
            this.skinCheckBox3.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox3.SelectedDownBack")));
            this.skinCheckBox3.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox3.SelectedMouseBack")));
            this.skinCheckBox3.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox3.SelectedNormlBack")));
            this.skinCheckBox3.Size = new System.Drawing.Size(75, 21);
            this.skinCheckBox3.TabIndex = 127;
            this.skinCheckBox3.Text = "全局匹配";
            this.skinCheckBox3.UseVisualStyleBackColor = false;
            // 
            // skinCheckBox2
            // 
            this.skinCheckBox2.AutoSize = true;
            this.skinCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox2.Checked = true;
            this.skinCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBox2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox2.DefaultCheckButtonWidth = 13;
            this.skinCheckBox2.DownBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox2.DownBack")));
            this.skinCheckBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox2.LightEffect = false;
            this.skinCheckBox2.Location = new System.Drawing.Point(311, 5);
            this.skinCheckBox2.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox2.MouseBack")));
            this.skinCheckBox2.Name = "skinCheckBox2";
            this.skinCheckBox2.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox2.NormlBack")));
            this.skinCheckBox2.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox2.SelectedDownBack")));
            this.skinCheckBox2.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox2.SelectedMouseBack")));
            this.skinCheckBox2.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox2.SelectedNormlBack")));
            this.skinCheckBox2.Size = new System.Drawing.Size(75, 21);
            this.skinCheckBox2.TabIndex = 127;
            this.skinCheckBox2.Text = "支持多行";
            this.skinCheckBox2.UseVisualStyleBackColor = false;
            // 
            // skinCheckBox1
            // 
            this.skinCheckBox1.AutoSize = true;
            this.skinCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox1.Checked = true;
            this.skinCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBox1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox1.DefaultCheckButtonWidth = 13;
            this.skinCheckBox1.DownBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox1.DownBack")));
            this.skinCheckBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox1.LightEffect = false;
            this.skinCheckBox1.Location = new System.Drawing.Point(218, 5);
            this.skinCheckBox1.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox1.MouseBack")));
            this.skinCheckBox1.Name = "skinCheckBox1";
            this.skinCheckBox1.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox1.NormlBack")));
            this.skinCheckBox1.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox1.SelectedDownBack")));
            this.skinCheckBox1.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox1.SelectedMouseBack")));
            this.skinCheckBox1.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox1.SelectedNormlBack")));
            this.skinCheckBox1.Size = new System.Drawing.Size(87, 21);
            this.skinCheckBox1.TabIndex = 127;
            this.skinCheckBox1.Text = "忽略大小写";
            this.skinCheckBox1.UseVisualStyleBackColor = false;
            // 
            // skinToolStrip10
            // 
            this.skinToolStrip10.Arrow = System.Drawing.Color.White;
            this.skinToolStrip10.Back = System.Drawing.Color.White;
            this.skinToolStrip10.BackColor = System.Drawing.Color.Transparent;
            this.skinToolStrip10.BackRadius = 4;
            this.skinToolStrip10.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip10.Base = System.Drawing.Color.Transparent;
            this.skinToolStrip10.BaseFore = System.Drawing.Color.Black;
            this.skinToolStrip10.BaseForeAnamorphosis = false;
            this.skinToolStrip10.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip10.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinToolStrip10.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStrip10.BaseHoverFore = System.Drawing.Color.Black;
            this.skinToolStrip10.BaseItemAnamorphosis = true;
            this.skinToolStrip10.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.skinToolStrip10.BaseItemBorderShow = true;
            this.skinToolStrip10.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip10.BaseItemDown")));
            this.skinToolStrip10.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinToolStrip10.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip10.BaseItemMouse")));
            this.skinToolStrip10.BaseItemNorml = ((System.Drawing.Image)(resources.GetObject("skinToolStrip10.BaseItemNorml")));
            this.skinToolStrip10.BaseItemPressed = System.Drawing.Color.Transparent;
            this.skinToolStrip10.BaseItemRadius = 2;
            this.skinToolStrip10.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip10.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.skinToolStrip10.BindTabControl = null;
            this.skinToolStrip10.Dock = System.Windows.Forms.DockStyle.None;
            this.skinToolStrip10.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip10.Fore = System.Drawing.Color.Black;
            this.skinToolStrip10.GripMargin = new System.Windows.Forms.Padding(0);
            this.skinToolStrip10.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.skinToolStrip10.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip10.ItemAnamorphosis = false;
            this.skinToolStrip10.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip10.ItemBorderShow = false;
            this.skinToolStrip10.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip10.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip10.ItemRadius = 1;
            this.skinToolStrip10.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip10.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton40,
            this.toolStripSeparator2,
            this.toolStripButton41,
            this.toolStripSeparator3});
            this.skinToolStrip10.Location = new System.Drawing.Point(6, 3);
            this.skinToolStrip10.Name = "skinToolStrip10";
            this.skinToolStrip10.Padding = new System.Windows.Forms.Padding(0);
            this.skinToolStrip10.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip10.Size = new System.Drawing.Size(214, 25);
            this.skinToolStrip10.SkinAllColor = true;
            this.skinToolStrip10.TabIndex = 126;
            this.skinToolStrip10.Text = "skinToolStrip10";
            this.skinToolStrip10.TitleAnamorphosis = false;
            this.skinToolStrip10.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip10.TitleRadius = 4;
            this.skinToolStrip10.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolStripButton40
            // 
            this.toolStripButton40.AutoSize = false;
            this.toolStripButton40.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton40.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton40.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton40.Image")));
            this.toolStripButton40.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton40.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton40.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripButton40.Name = "toolStripButton40";
            this.toolStripButton40.Size = new System.Drawing.Size(80, 23);
            this.toolStripButton40.Text = "打开文件";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton41
            // 
            this.toolStripButton41.AutoSize = false;
            this.toolStripButton41.ForeColor = System.Drawing.Color.White;
            this.toolStripButton41.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton41.Image")));
            this.toolStripButton41.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton41.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton41.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripButton41.Name = "toolStripButton41";
            this.toolStripButton41.Size = new System.Drawing.Size(100, 23);
            this.toolStripButton41.Text = "取匹配文本";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // TvImgList
            // 
            this.TvImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TvImgList.ImageStream")));
            this.TvImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.TvImgList.Images.SetKeyName(0, "1851.bmp");
            this.TvImgList.Images.SetKeyName(1, "1852.bmp");
            this.TvImgList.Images.SetKeyName(2, "1853.bmp");
            this.TvImgList.Images.SetKeyName(3, "1854.bmp");
            this.TvImgList.Images.SetKeyName(4, "1855.bmp");
            this.TvImgList.Images.SetKeyName(5, "1856.bmp");
            this.TvImgList.Images.SetKeyName(6, "1857.bmp");
            this.TvImgList.Images.SetKeyName(7, "1858.bmp");
            this.TvImgList.Images.SetKeyName(8, "1859.bmp");
            this.TvImgList.Images.SetKeyName(9, "18510.bmp");
            this.TvImgList.Images.SetKeyName(10, "18511.bmp");
            this.TvImgList.Images.SetKeyName(11, "18512.bmp");
            this.TvImgList.Images.SetKeyName(12, "18513.bmp");
            this.TvImgList.Images.SetKeyName(13, "18514.bmp");
            this.TvImgList.Images.SetKeyName(14, "18515.bmp");
            this.TvImgList.Images.SetKeyName(15, "18516.bmp");
            this.TvImgList.Images.SetKeyName(16, "18517.bmp");
            // 
            // FrmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(620, 379);
            this.Controls.Add(this.skinTabControl1);
            this.Controls.Add(this.skinTextBox1);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.tvMsg);
            this.Controls.Add(this.skinPanel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(620, 379);
            this.Name = "FrmReg";
            this.Text = "FrmReg";
            this.skinTabControl1.ResumeLayout(false);
            this.skinTabPage1.ResumeLayout(false);
            this.skinTextBox3.ResumeLayout(false);
            this.skinTextBox3.PerformLayout();
            this.skinTabPage2.ResumeLayout(false);
            this.skinTextBox2.ResumeLayout(false);
            this.skinTextBox2.PerformLayout();
            this.skinTabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView3)).EndInit();
            this.skinTextBox1.ResumeLayout(false);
            this.skinTextBox1.PerformLayout();
            this.skinPanel9.ResumeLayout(false);
            this.skinPanel9.PerformLayout();
            this.skinToolStrip10.ResumeLayout(false);
            this.skinToolStrip10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage skinTabPage1;
        private CCWin.SkinControl.SkinTextBox skinTextBox3;
        private CCWin.SkinControl.SkinTabPage skinTabPage2;
        private CCWin.SkinControl.SkinTextBox skinTextBox2;
        private CCWin.SkinControl.SkinTabPage skinTabPage10;
        private CCWin.SkinControl.SkinDataGridView skinDataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTreeView tvMsg;
        private CCWin.SkinControl.SkinPanel skinPanel9;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox3;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox2;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox1;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip10;
        private System.Windows.Forms.ToolStripButton toolStripButton40;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton41;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList TvImgList;
    }
}