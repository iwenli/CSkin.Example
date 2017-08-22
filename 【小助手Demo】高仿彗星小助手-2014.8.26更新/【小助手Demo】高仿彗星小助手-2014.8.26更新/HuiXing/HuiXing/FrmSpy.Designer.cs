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
 * * 说明：FrmSpy.Designer.cs
 * *
********************************************************************/

namespace HuiXing
{
    partial class FrmSpy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpy));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("65728|Start|开始", 0, 0);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("65732|TrayNotifyWnd", 0, 0);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("65780|ReBarWindow32", 0, 0);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("65724|Shell_TrayWnd", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("65552|#32769", 19, 19, new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.skinDataGridView2 = new CCWin.SkinControl.SkinDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinWaterTextBox5 = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinWaterTextBox4 = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinWaterTextBox6 = new CCWin.SkinControl.SkinWaterTextBox();
            this.imgListSpy = new System.Windows.Forms.ImageList(this.components);
            this.skinTreeView1 = new CCWin.SkinControl.SkinTreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.skinWaterTextBox2 = new CCWin.SkinControl.SkinWaterTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.skinWaterTextBox3 = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinWaterTextBox1 = new CCWin.SkinControl.SkinWaterTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.skinWaterTextBox7 = new CCWin.SkinControl.SkinWaterTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.skinWaterTextBox8 = new CCWin.SkinControl.SkinWaterTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.skinButton7 = new CCWin.SkinControl.SkinButton();
            this.skinButton6 = new CCWin.SkinControl.SkinButton();
            this.skinButton8 = new CCWin.SkinControl.SkinButton();
            this.skinButton5 = new CCWin.SkinControl.SkinButton();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.skinToolStrip4 = new CCWin.SkinControl.SkinToolStrip();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton42 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripDropDownButton();
            this.最小化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最大化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.发送消息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.闪烁窗口位置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.突破灰色按钮ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示隐藏控件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.加入可调边框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置为独立窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.生成代码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.获取内容ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.skinCheckBox7 = new CCWin.SkinControl.SkinCheckBox();
            this.imgXz = new CCWin.SkinControl.SkinPictureBox();
            this.skinCheckBox4 = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBox5 = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBox6 = new CCWin.SkinControl.SkinCheckBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView2)).BeginInit();
            this.skinPanel2.SuspendLayout();
            this.skinToolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgXz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 137;
            this.label1.Text = "窗口句柄";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(45, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 137;
            this.label2.Text = "窗口标题";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(46, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 137;
            this.label4.Text = "窗口属性";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(45, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 137;
            this.label3.Text = "窗口位置";
            // 
            // skinDataGridView2
            // 
            this.skinDataGridView2.AllowUserToDeleteRows = false;
            this.skinDataGridView2.AllowUserToOrderColumns = true;
            this.skinDataGridView2.AlternatingCellBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.skinDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.skinDataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.skinDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.skinDataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.skinDataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridView2.ColumnFont = null;
            this.skinDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.skinDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.skinDataGridView2.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.skinDataGridView2.EnableHeadersVisualStyles = false;
            this.skinDataGridView2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinDataGridView2.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.skinDataGridView2.HeadFont = new System.Drawing.Font("微软雅黑", 9F);
            this.skinDataGridView2.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView2.Location = new System.Drawing.Point(9, 235);
            this.skinDataGridView2.Margin = new System.Windows.Forms.Padding(10);
            this.skinDataGridView2.MouseCellBackColor = System.Drawing.Color.White;
            this.skinDataGridView2.MultiSelect = false;
            this.skinDataGridView2.Name = "skinDataGridView2";
            this.skinDataGridView2.ReadOnly = true;
            this.skinDataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView2.RowHeadersVisible = false;
            this.skinDataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.skinDataGridView2.RowTemplate.Height = 23;
            this.skinDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skinDataGridView2.Size = new System.Drawing.Size(361, 135);
            this.skinDataGridView2.SkinGridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.skinDataGridView2.TabIndex = 135;
            this.skinDataGridView2.TitleBack = null;
            this.skinDataGridView2.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView2.TitleBackColorEnd = System.Drawing.SystemColors.Control;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "属性名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "属性值";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "备注";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // skinWaterTextBox5
            // 
            this.skinWaterTextBox5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinWaterTextBox5.Location = new System.Drawing.Point(104, 67);
            this.skinWaterTextBox5.Name = "skinWaterTextBox5";
            this.skinWaterTextBox5.Size = new System.Drawing.Size(235, 21);
            this.skinWaterTextBox5.TabIndex = 138;
            this.skinWaterTextBox5.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox5.WaterText = "";
            // 
            // skinWaterTextBox4
            // 
            this.skinWaterTextBox4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinWaterTextBox4.Location = new System.Drawing.Point(104, 39);
            this.skinWaterTextBox4.Name = "skinWaterTextBox4";
            this.skinWaterTextBox4.Size = new System.Drawing.Size(235, 21);
            this.skinWaterTextBox4.TabIndex = 138;
            this.skinWaterTextBox4.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox4.WaterText = "";
            // 
            // skinWaterTextBox6
            // 
            this.skinWaterTextBox6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinWaterTextBox6.Location = new System.Drawing.Point(104, 95);
            this.skinWaterTextBox6.Name = "skinWaterTextBox6";
            this.skinWaterTextBox6.Size = new System.Drawing.Size(235, 21);
            this.skinWaterTextBox6.TabIndex = 138;
            this.skinWaterTextBox6.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox6.WaterText = "";
            // 
            // imgListSpy
            // 
            this.imgListSpy.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListSpy.ImageStream")));
            this.imgListSpy.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListSpy.Images.SetKeyName(0, "1431.bmp");
            this.imgListSpy.Images.SetKeyName(1, "1432.bmp");
            this.imgListSpy.Images.SetKeyName(2, "1433.bmp");
            this.imgListSpy.Images.SetKeyName(3, "1434.bmp");
            this.imgListSpy.Images.SetKeyName(4, "1435.bmp");
            this.imgListSpy.Images.SetKeyName(5, "1436.bmp");
            this.imgListSpy.Images.SetKeyName(6, "1437.bmp");
            this.imgListSpy.Images.SetKeyName(7, "1438.bmp");
            this.imgListSpy.Images.SetKeyName(8, "1439.bmp");
            this.imgListSpy.Images.SetKeyName(9, "14310.bmp");
            this.imgListSpy.Images.SetKeyName(10, "14311.bmp");
            this.imgListSpy.Images.SetKeyName(11, "14312.bmp");
            this.imgListSpy.Images.SetKeyName(12, "14313.bmp");
            this.imgListSpy.Images.SetKeyName(13, "14314.bmp");
            this.imgListSpy.Images.SetKeyName(14, "14315.bmp");
            this.imgListSpy.Images.SetKeyName(15, "14316.bmp");
            this.imgListSpy.Images.SetKeyName(16, "14317.bmp");
            this.imgListSpy.Images.SetKeyName(17, "14318.bmp");
            this.imgListSpy.Images.SetKeyName(18, "14319.bmp");
            this.imgListSpy.Images.SetKeyName(19, "14320.bmp");
            this.imgListSpy.Images.SetKeyName(20, "14321.bmp");
            this.imgListSpy.Images.SetKeyName(21, "14322.bmp");
            this.imgListSpy.Images.SetKeyName(22, "14323.bmp");
            this.imgListSpy.Images.SetKeyName(23, "14324.bmp");
            this.imgListSpy.Images.SetKeyName(24, "14325.bmp");
            this.imgListSpy.Images.SetKeyName(25, "14326.bmp");
            this.imgListSpy.Images.SetKeyName(26, "14327.bmp");
            // 
            // skinTreeView1
            // 
            this.skinTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinTreeView1.BackColor = System.Drawing.Color.White;
            this.skinTreeView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.skinTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinTreeView1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTreeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.skinTreeView1.HideSelection = false;
            this.skinTreeView1.ImageIndex = 0;
            this.skinTreeView1.ImageList = this.imgListSpy;
            this.skinTreeView1.ItemHeight = 20;
            this.skinTreeView1.Location = new System.Drawing.Point(376, 40);
            this.skinTreeView1.Name = "skinTreeView1";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "节点0";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Text = "65728|Start|开始";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "节点2";
            treeNode2.SelectedImageIndex = 0;
            treeNode2.Text = "65732|TrayNotifyWnd";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "节点3";
            treeNode3.SelectedImageIndex = 0;
            treeNode3.Text = "65780|ReBarWindow32";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "节点15";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Text = "65724|Shell_TrayWnd";
            treeNode5.ImageIndex = 19;
            treeNode5.Name = "节点9";
            treeNode5.SelectedImageIndex = 19;
            treeNode5.Text = "65552|#32769";
            this.skinTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.skinTreeView1.SelectedImageIndex = 0;
            this.skinTreeView1.Size = new System.Drawing.Size(237, 330);
            this.skinTreeView1.TabIndex = 143;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(7, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 145;
            this.label5.Text = "顶级窗口";
            // 
            // skinWaterTextBox2
            // 
            this.skinWaterTextBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinWaterTextBox2.Location = new System.Drawing.Point(66, 147);
            this.skinWaterTextBox2.Name = "skinWaterTextBox2";
            this.skinWaterTextBox2.Size = new System.Drawing.Size(91, 21);
            this.skinWaterTextBox2.TabIndex = 148;
            this.skinWaterTextBox2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox2.WaterText = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(194, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 152;
            this.label7.Text = "父 窗 口";
            // 
            // skinWaterTextBox3
            // 
            this.skinWaterTextBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinWaterTextBox3.Location = new System.Drawing.Point(253, 147);
            this.skinWaterTextBox3.Name = "skinWaterTextBox3";
            this.skinWaterTextBox3.Size = new System.Drawing.Size(86, 21);
            this.skinWaterTextBox3.TabIndex = 153;
            this.skinWaterTextBox3.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox3.WaterText = "";
            // 
            // skinWaterTextBox1
            // 
            this.skinWaterTextBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinWaterTextBox1.Location = new System.Drawing.Point(66, 175);
            this.skinWaterTextBox1.Name = "skinWaterTextBox1";
            this.skinWaterTextBox1.Size = new System.Drawing.Size(91, 21);
            this.skinWaterTextBox1.TabIndex = 148;
            this.skinWaterTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox1.WaterText = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(7, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 145;
            this.label6.Text = "上一窗口";
            // 
            // skinWaterTextBox7
            // 
            this.skinWaterTextBox7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinWaterTextBox7.Location = new System.Drawing.Point(253, 175);
            this.skinWaterTextBox7.Name = "skinWaterTextBox7";
            this.skinWaterTextBox7.Size = new System.Drawing.Size(86, 21);
            this.skinWaterTextBox7.TabIndex = 153;
            this.skinWaterTextBox7.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox7.WaterText = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(194, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 152;
            this.label8.Text = "下一窗口";
            // 
            // skinWaterTextBox8
            // 
            this.skinWaterTextBox8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinWaterTextBox8.Location = new System.Drawing.Point(66, 204);
            this.skinWaterTextBox8.Name = "skinWaterTextBox8";
            this.skinWaterTextBox8.Size = new System.Drawing.Size(273, 21);
            this.skinWaterTextBox8.TabIndex = 148;
            this.skinWaterTextBox8.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox8.WaterText = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(7, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 145;
            this.label9.Text = "上一窗口";
            // 
            // skinButton7
            // 
            this.skinButton7.BackColor = System.Drawing.Color.Transparent;
            this.skinButton7.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton7.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton7.DownBack")));
            this.skinButton7.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton7.Image = ((System.Drawing.Image)(resources.GetObject("skinButton7.Image")));
            this.skinButton7.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton7.Location = new System.Drawing.Point(345, 173);
            this.skinButton7.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton7.MouseBack")));
            this.skinButton7.Name = "skinButton7";
            this.skinButton7.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton7.NormlBack")));
            this.skinButton7.Palace = true;
            this.skinButton7.Size = new System.Drawing.Size(25, 25);
            this.skinButton7.TabIndex = 154;
            this.skinButton7.UseVisualStyleBackColor = false;
            // 
            // skinButton6
            // 
            this.skinButton6.BackColor = System.Drawing.Color.Transparent;
            this.skinButton6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton6.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton6.DownBack")));
            this.skinButton6.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton6.Image = ((System.Drawing.Image)(resources.GetObject("skinButton6.Image")));
            this.skinButton6.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton6.Location = new System.Drawing.Point(345, 145);
            this.skinButton6.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton6.MouseBack")));
            this.skinButton6.Name = "skinButton6";
            this.skinButton6.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton6.NormlBack")));
            this.skinButton6.Palace = true;
            this.skinButton6.Size = new System.Drawing.Size(25, 25);
            this.skinButton6.TabIndex = 154;
            this.skinButton6.UseVisualStyleBackColor = false;
            // 
            // skinButton8
            // 
            this.skinButton8.BackColor = System.Drawing.Color.Transparent;
            this.skinButton8.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton8.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton8.DownBack")));
            this.skinButton8.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton8.Image = ((System.Drawing.Image)(resources.GetObject("skinButton8.Image")));
            this.skinButton8.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton8.Location = new System.Drawing.Point(345, 202);
            this.skinButton8.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton8.MouseBack")));
            this.skinButton8.Name = "skinButton8";
            this.skinButton8.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton8.NormlBack")));
            this.skinButton8.Palace = true;
            this.skinButton8.Size = new System.Drawing.Size(25, 25);
            this.skinButton8.TabIndex = 151;
            this.skinButton8.UseVisualStyleBackColor = false;
            // 
            // skinButton5
            // 
            this.skinButton5.BackColor = System.Drawing.Color.Transparent;
            this.skinButton5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton5.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton5.DownBack")));
            this.skinButton5.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton5.Image = ((System.Drawing.Image)(resources.GetObject("skinButton5.Image")));
            this.skinButton5.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton5.Location = new System.Drawing.Point(163, 173);
            this.skinButton5.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton5.MouseBack")));
            this.skinButton5.Name = "skinButton5";
            this.skinButton5.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton5.NormlBack")));
            this.skinButton5.Palace = true;
            this.skinButton5.Size = new System.Drawing.Size(25, 25);
            this.skinButton5.TabIndex = 151;
            this.skinButton5.UseVisualStyleBackColor = false;
            // 
            // skinButton4
            // 
            this.skinButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton4.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton4.DownBack")));
            this.skinButton4.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton4.Image = ((System.Drawing.Image)(resources.GetObject("skinButton4.Image")));
            this.skinButton4.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton4.Location = new System.Drawing.Point(163, 145);
            this.skinButton4.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton4.MouseBack")));
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton4.NormlBack")));
            this.skinButton4.Palace = true;
            this.skinButton4.Size = new System.Drawing.Size(25, 25);
            this.skinButton4.TabIndex = 151;
            this.skinButton4.UseVisualStyleBackColor = false;
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinPanel2.BackgroundImage = global::HuiXing.Properties.Resources.BaiduShurufa_2014_8_2_16_32_58;
            this.skinPanel2.Controls.Add(this.skinToolStrip4);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(0, 0);
            this.skinPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(620, 31);
            this.skinPanel2.TabIndex = 144;
            // 
            // skinToolStrip4
            // 
            this.skinToolStrip4.Arrow = System.Drawing.Color.Black;
            this.skinToolStrip4.AutoSize = false;
            this.skinToolStrip4.Back = System.Drawing.Color.White;
            this.skinToolStrip4.BackColor = System.Drawing.Color.Transparent;
            this.skinToolStrip4.BackRadius = 4;
            this.skinToolStrip4.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip4.Base = System.Drawing.Color.Transparent;
            this.skinToolStrip4.BaseFore = System.Drawing.Color.Black;
            this.skinToolStrip4.BaseForeAnamorphosis = false;
            this.skinToolStrip4.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip4.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinToolStrip4.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStrip4.BaseHoverFore = System.Drawing.Color.Black;
            this.skinToolStrip4.BaseItemAnamorphosis = true;
            this.skinToolStrip4.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.skinToolStrip4.BaseItemBorderShow = true;
            this.skinToolStrip4.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip4.BaseItemDown")));
            this.skinToolStrip4.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinToolStrip4.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip4.BaseItemMouse")));
            this.skinToolStrip4.BaseItemNorml = ((System.Drawing.Image)(resources.GetObject("skinToolStrip4.BaseItemNorml")));
            this.skinToolStrip4.BaseItemPressed = System.Drawing.Color.Transparent;
            this.skinToolStrip4.BaseItemRadius = 2;
            this.skinToolStrip4.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip4.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.skinToolStrip4.BindTabControl = null;
            this.skinToolStrip4.Dock = System.Windows.Forms.DockStyle.None;
            this.skinToolStrip4.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip4.Fore = System.Drawing.Color.Black;
            this.skinToolStrip4.GripMargin = new System.Windows.Forms.Padding(0);
            this.skinToolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.skinToolStrip4.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip4.ItemAnamorphosis = false;
            this.skinToolStrip4.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip4.ItemBorderShow = false;
            this.skinToolStrip4.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip4.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip4.ItemRadius = 1;
            this.skinToolStrip4.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton19,
            this.toolStripButton18,
            this.toolStripButton42,
            this.toolStripButton17,
            this.toolStripButton16,
            this.toolStripTextBox1,
            this.toolStripLabel11});
            this.skinToolStrip4.Location = new System.Drawing.Point(6, 3);
            this.skinToolStrip4.Name = "skinToolStrip4";
            this.skinToolStrip4.Padding = new System.Windows.Forms.Padding(0);
            this.skinToolStrip4.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip4.Size = new System.Drawing.Size(614, 25);
            this.skinToolStrip4.SkinAllColor = true;
            this.skinToolStrip4.TabIndex = 125;
            this.skinToolStrip4.Text = "skinToolStrip4";
            this.skinToolStrip4.TitleAnamorphosis = false;
            this.skinToolStrip4.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip4.TitleRadius = 4;
            this.skinToolStrip4.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolStripButton19
            // 
            this.toolStripButton19.AutoSize = false;
            this.toolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton19.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton19.Image")));
            this.toolStripButton19.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton19.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripButton19.Name = "toolStripButton19";
            this.toolStripButton19.Size = new System.Drawing.Size(80, 23);
            this.toolStripButton19.Text = "复制基本信息";
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.AutoSize = false;
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton18.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton18.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.Size = new System.Drawing.Size(80, 23);
            this.toolStripButton18.Text = "复制窗口树";
            // 
            // toolStripButton42
            // 
            this.toolStripButton42.AutoSize = false;
            this.toolStripButton42.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton42.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton42.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton42.Image")));
            this.toolStripButton42.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton42.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton42.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripButton42.Name = "toolStripButton42";
            this.toolStripButton42.Size = new System.Drawing.Size(80, 23);
            this.toolStripButton42.Text = "截取窗口图像";
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.AutoSize = false;
            this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton17.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.最小化ToolStripMenuItem,
            this.最大化ToolStripMenuItem,
            this.还原ToolStripMenuItem,
            this.关闭ToolStripMenuItem,
            this.toolStripMenuItem8,
            this.发送消息ToolStripMenuItem,
            this.闪烁窗口位置ToolStripMenuItem,
            this.突破灰色按钮ToolStripMenuItem,
            this.显示隐藏控件ToolStripMenuItem,
            this.toolStripMenuItem9,
            this.加入可调边框ToolStripMenuItem,
            this.设置为独立窗体ToolStripMenuItem,
            this.toolStripMenuItem10,
            this.生成代码ToolStripMenuItem,
            this.获取内容ToolStripMenuItem});
            this.toolStripButton17.ForeColor = System.Drawing.Color.White;
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton17.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.Size = new System.Drawing.Size(80, 23);
            this.toolStripButton17.Text = "常用操作";
            // 
            // 最小化ToolStripMenuItem
            // 
            this.最小化ToolStripMenuItem.Name = "最小化ToolStripMenuItem";
            this.最小化ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.最小化ToolStripMenuItem.Text = "最小化";
            // 
            // 最大化ToolStripMenuItem
            // 
            this.最大化ToolStripMenuItem.Name = "最大化ToolStripMenuItem";
            this.最大化ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.最大化ToolStripMenuItem.Text = "最大化";
            // 
            // 还原ToolStripMenuItem
            // 
            this.还原ToolStripMenuItem.Name = "还原ToolStripMenuItem";
            this.还原ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.还原ToolStripMenuItem.Text = "还原";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(157, 6);
            // 
            // 发送消息ToolStripMenuItem
            // 
            this.发送消息ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("发送消息ToolStripMenuItem.Image")));
            this.发送消息ToolStripMenuItem.Name = "发送消息ToolStripMenuItem";
            this.发送消息ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.发送消息ToolStripMenuItem.Text = "发送消息";
            // 
            // 闪烁窗口位置ToolStripMenuItem
            // 
            this.闪烁窗口位置ToolStripMenuItem.Name = "闪烁窗口位置ToolStripMenuItem";
            this.闪烁窗口位置ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.闪烁窗口位置ToolStripMenuItem.Text = "闪烁窗口位置";
            // 
            // 突破灰色按钮ToolStripMenuItem
            // 
            this.突破灰色按钮ToolStripMenuItem.Name = "突破灰色按钮ToolStripMenuItem";
            this.突破灰色按钮ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.突破灰色按钮ToolStripMenuItem.Text = "突破灰色按钮";
            // 
            // 显示隐藏控件ToolStripMenuItem
            // 
            this.显示隐藏控件ToolStripMenuItem.Name = "显示隐藏控件ToolStripMenuItem";
            this.显示隐藏控件ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.显示隐藏控件ToolStripMenuItem.Text = "显示隐藏控件";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(157, 6);
            // 
            // 加入可调边框ToolStripMenuItem
            // 
            this.加入可调边框ToolStripMenuItem.Name = "加入可调边框ToolStripMenuItem";
            this.加入可调边框ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.加入可调边框ToolStripMenuItem.Text = "加入可调边框";
            // 
            // 设置为独立窗体ToolStripMenuItem
            // 
            this.设置为独立窗体ToolStripMenuItem.Name = "设置为独立窗体ToolStripMenuItem";
            this.设置为独立窗体ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.设置为独立窗体ToolStripMenuItem.Text = "设置为独立窗口";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(157, 6);
            // 
            // 生成代码ToolStripMenuItem
            // 
            this.生成代码ToolStripMenuItem.Name = "生成代码ToolStripMenuItem";
            this.生成代码ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.生成代码ToolStripMenuItem.Text = "生成代码";
            // 
            // 获取内容ToolStripMenuItem
            // 
            this.获取内容ToolStripMenuItem.Name = "获取内容ToolStripMenuItem";
            this.获取内容ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.获取内容ToolStripMenuItem.Text = "获取内容";
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton16.AutoSize = false;
            this.toolStripButton16.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton16.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.Size = new System.Drawing.Size(52, 23);
            this.toolStripButton16.Text = "查找";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel11.Text = "查找窗口";
            // 
            // skinCheckBox7
            // 
            this.skinCheckBox7.AutoSize = true;
            this.skinCheckBox7.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox7.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox7.DefaultCheckButtonWidth = 13;
            this.skinCheckBox7.DownBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox7.DownBack")));
            this.skinCheckBox7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox7.LightEffect = false;
            this.skinCheckBox7.Location = new System.Drawing.Point(275, 124);
            this.skinCheckBox7.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox7.MouseBack")));
            this.skinCheckBox7.Name = "skinCheckBox7";
            this.skinCheckBox7.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox7.NormlBack")));
            this.skinCheckBox7.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox7.SelectedDownBack")));
            this.skinCheckBox7.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox7.SelectedMouseBack")));
            this.skinCheckBox7.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox7.SelectedNormlBack")));
            this.skinCheckBox7.Size = new System.Drawing.Size(48, 16);
            this.skinCheckBox7.TabIndex = 140;
            this.skinCheckBox7.Text = "透明";
            this.skinCheckBox7.UseVisualStyleBackColor = false;
            // 
            // imgXz
            // 
            this.imgXz.BackColor = System.Drawing.Color.Transparent;
            this.imgXz.BackgroundImage = global::HuiXing.Properties.Resources.imgXz;
            this.imgXz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgXz.Location = new System.Drawing.Point(6, 37);
            this.imgXz.Margin = new System.Windows.Forms.Padding(0);
            this.imgXz.Name = "imgXz";
            this.imgXz.Size = new System.Drawing.Size(32, 32);
            this.imgXz.TabIndex = 134;
            this.imgXz.TabStop = false;
            this.imgXz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgXz_MouseDown);
            this.imgXz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgXz_MouseMove);
            this.imgXz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgXz_MouseUp);
            // 
            // skinCheckBox4
            // 
            this.skinCheckBox4.AutoSize = true;
            this.skinCheckBox4.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox4.DefaultCheckButtonWidth = 13;
            this.skinCheckBox4.DownBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox4.DownBack")));
            this.skinCheckBox4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox4.LightEffect = false;
            this.skinCheckBox4.Location = new System.Drawing.Point(218, 124);
            this.skinCheckBox4.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox4.MouseBack")));
            this.skinCheckBox4.Name = "skinCheckBox4";
            this.skinCheckBox4.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox4.NormlBack")));
            this.skinCheckBox4.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox4.SelectedDownBack")));
            this.skinCheckBox4.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox4.SelectedMouseBack")));
            this.skinCheckBox4.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox4.SelectedNormlBack")));
            this.skinCheckBox4.Size = new System.Drawing.Size(48, 16);
            this.skinCheckBox4.TabIndex = 140;
            this.skinCheckBox4.Text = "置顶";
            this.skinCheckBox4.UseVisualStyleBackColor = false;
            // 
            // skinCheckBox5
            // 
            this.skinCheckBox5.AutoSize = true;
            this.skinCheckBox5.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox5.Checked = true;
            this.skinCheckBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBox5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox5.DefaultCheckButtonWidth = 13;
            this.skinCheckBox5.DownBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox5.DownBack")));
            this.skinCheckBox5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox5.LightEffect = false;
            this.skinCheckBox5.Location = new System.Drawing.Point(161, 124);
            this.skinCheckBox5.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox5.MouseBack")));
            this.skinCheckBox5.Name = "skinCheckBox5";
            this.skinCheckBox5.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox5.NormlBack")));
            this.skinCheckBox5.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox5.SelectedDownBack")));
            this.skinCheckBox5.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox5.SelectedMouseBack")));
            this.skinCheckBox5.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox5.SelectedNormlBack")));
            this.skinCheckBox5.Size = new System.Drawing.Size(48, 16);
            this.skinCheckBox5.TabIndex = 141;
            this.skinCheckBox5.Text = "禁止";
            this.skinCheckBox5.UseVisualStyleBackColor = false;
            // 
            // skinCheckBox6
            // 
            this.skinCheckBox6.AutoSize = true;
            this.skinCheckBox6.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox6.Checked = true;
            this.skinCheckBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBox6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox6.DefaultCheckButtonWidth = 13;
            this.skinCheckBox6.DownBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox6.DownBack")));
            this.skinCheckBox6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox6.LightEffect = false;
            this.skinCheckBox6.Location = new System.Drawing.Point(104, 124);
            this.skinCheckBox6.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox6.MouseBack")));
            this.skinCheckBox6.Name = "skinCheckBox6";
            this.skinCheckBox6.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox6.NormlBack")));
            this.skinCheckBox6.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox6.SelectedDownBack")));
            this.skinCheckBox6.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox6.SelectedMouseBack")));
            this.skinCheckBox6.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("skinCheckBox6.SelectedNormlBack")));
            this.skinCheckBox6.Size = new System.Drawing.Size(48, 16);
            this.skinCheckBox6.TabIndex = 142;
            this.skinCheckBox6.Text = "可视";
            this.skinCheckBox6.UseVisualStyleBackColor = false;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.DownBack")));
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton1.Image = ((System.Drawing.Image)(resources.GetObject("skinButton1.Image")));
            this.skinButton1.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton1.Location = new System.Drawing.Point(345, 37);
            this.skinButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.MouseBack")));
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.NormlBack")));
            this.skinButton1.Palace = true;
            this.skinButton1.Size = new System.Drawing.Size(25, 25);
            this.skinButton1.TabIndex = 139;
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton2.DownBack")));
            this.skinButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton2.Image = ((System.Drawing.Image)(resources.GetObject("skinButton2.Image")));
            this.skinButton2.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton2.Location = new System.Drawing.Point(345, 65);
            this.skinButton2.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton2.MouseBack")));
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton2.NormlBack")));
            this.skinButton2.Palace = true;
            this.skinButton2.Size = new System.Drawing.Size(25, 25);
            this.skinButton2.TabIndex = 139;
            this.skinButton2.UseVisualStyleBackColor = false;
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton3.DownBack")));
            this.skinButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton3.Image = ((System.Drawing.Image)(resources.GetObject("skinButton3.Image")));
            this.skinButton3.ImageSize = new System.Drawing.Size(16, 16);
            this.skinButton3.Location = new System.Drawing.Point(345, 93);
            this.skinButton3.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton3.MouseBack")));
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton3.NormlBack")));
            this.skinButton3.Palace = true;
            this.skinButton3.Size = new System.Drawing.Size(25, 25);
            this.skinButton3.TabIndex = 139;
            this.skinButton3.UseVisualStyleBackColor = false;
            // 
            // FrmSpy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(620, 379);
            this.Controls.Add(this.skinButton7);
            this.Controls.Add(this.skinButton6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.skinWaterTextBox7);
            this.Controls.Add(this.skinWaterTextBox3);
            this.Controls.Add(this.skinButton8);
            this.Controls.Add(this.skinButton5);
            this.Controls.Add(this.skinButton4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.skinWaterTextBox8);
            this.Controls.Add(this.skinWaterTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.skinWaterTextBox2);
            this.Controls.Add(this.skinDataGridView2);
            this.Controls.Add(this.skinTreeView1);
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.skinCheckBox7);
            this.Controls.Add(this.imgXz);
            this.Controls.Add(this.skinWaterTextBox5);
            this.Controls.Add(this.skinCheckBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.skinCheckBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.skinCheckBox6);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skinWaterTextBox4);
            this.Controls.Add(this.skinWaterTextBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(620, 379);
            this.Name = "FrmSpy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSpy";
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView2)).EndInit();
            this.skinPanel2.ResumeLayout(false);
            this.skinToolStrip4.ResumeLayout(false);
            this.skinToolStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgXz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView skinDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox7;
        private CCWin.SkinControl.SkinPictureBox imgXz;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox4;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox5;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox6;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinButton skinButton3;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox4;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox6;
        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox5;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip4;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripButton toolStripButton42;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton17;
        private System.Windows.Forms.ToolStripMenuItem 最小化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最大化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem 发送消息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 闪烁窗口位置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 突破灰色按钮ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示隐藏控件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem 加入可调边框ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置为独立窗体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem 生成代码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 获取内容ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.ImageList imgListSpy;
        private CCWin.SkinControl.SkinTreeView skinTreeView1;
        private System.Windows.Forms.Label label5;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox2;
        private CCWin.SkinControl.SkinButton skinButton4;
        private CCWin.SkinControl.SkinButton skinButton6;
        private System.Windows.Forms.Label label7;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox3;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox1;
        private System.Windows.Forms.Label label6;
        private CCWin.SkinControl.SkinButton skinButton5;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox7;
        private System.Windows.Forms.Label label8;
        private CCWin.SkinControl.SkinButton skinButton7;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox8;
        private System.Windows.Forms.Label label9;
        private CCWin.SkinControl.SkinButton skinButton8;
    }
}