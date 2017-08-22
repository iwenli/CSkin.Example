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
 * * 说明：FrmWeather.designer.cs
 * *
********************************************************************/

namespace QQMetro
{
    partial class FrmWeather
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeather));
            this.timShow = new System.Windows.Forms.Timer(this.components);
            this.lblTQ = new CCWin.SkinControl.SkinLabel();
            this.lblWeather = new CCWin.SkinControl.SkinLabel();
            this.btnState = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.lblCity = new CCWin.SkinControl.SkinLabel();
            this.skinToolStrip2 = new CCWin.SkinControl.SkinToolStrip();
            this.toolTodayImg = new System.Windows.Forms.ToolStripButton();
            this.toolTomorrowImg = new System.Windows.Forms.ToolStripButton();
            this.toolAfterImg = new System.Windows.Forms.ToolStripButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinToolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timShow
            // 
            this.timShow.Interval = 800;
            this.timShow.Tick += new System.EventHandler(this.timShow_Tick);
            // 
            // lblTQ
            // 
            this.lblTQ.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblTQ.AutoSize = true;
            this.lblTQ.BackColor = System.Drawing.Color.Transparent;
            this.lblTQ.BorderColor = System.Drawing.Color.Black;
            this.lblTQ.BorderSize = 4;
            this.lblTQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTQ.Font = new System.Drawing.Font("楷体", 32F);
            this.lblTQ.ForeColor = System.Drawing.Color.White;
            this.lblTQ.Location = new System.Drawing.Point(14, 14);
            this.lblTQ.Name = "lblTQ";
            this.lblTQ.Size = new System.Drawing.Size(63, 43);
            this.lblTQ.TabIndex = 101;
            this.lblTQ.Text = "25";
            // 
            // lblWeather
            // 
            this.lblWeather.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeather.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblWeather.AutoSize = true;
            this.lblWeather.BackColor = System.Drawing.Color.Transparent;
            this.lblWeather.BorderColor = System.Drawing.Color.Black;
            this.lblWeather.BorderSize = 4;
            this.lblWeather.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblWeather.ForeColor = System.Drawing.Color.White;
            this.lblWeather.Location = new System.Drawing.Point(20, 90);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(73, 20);
            this.lblWeather.TabIndex = 102;
            this.lblWeather.Text = "阴  西北风";
            // 
            // btnState
            // 
            this.btnState.BackColor = System.Drawing.Color.Transparent;
            this.btnState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnState.BackRectangle = new System.Drawing.Rectangle(4, 4, 4, 4);
            this.btnState.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnState.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnState.DownBack = global::QQMetro.Properties.Resources.allbtn_down;
            this.btnState.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnState.Image = global::QQMetro.Properties.Resources.set_icon;
            this.btnState.ImageSize = new System.Drawing.Size(18, 17);
            this.btnState.Location = new System.Drawing.Point(208, 5);
            this.btnState.Margin = new System.Windows.Forms.Padding(0);
            this.btnState.MouseBack = global::QQMetro.Properties.Resources.allbtn_highlight;
            this.btnState.Name = "btnState";
            this.btnState.NormlBack = null;
            this.btnState.Palace = true;
            this.btnState.Size = new System.Drawing.Size(28, 22);
            this.btnState.TabIndex = 129;
            this.btnState.Tag = "1";
            this.btnState.UseVisualStyleBackColor = false;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.Black;
            this.skinLabel1.BorderSize = 4;
            this.skinLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinLabel1.Font = new System.Drawing.Font("楷体", 19F);
            this.skinLabel1.ForeColor = System.Drawing.Color.White;
            this.skinLabel1.Location = new System.Drawing.Point(69, 26);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(38, 26);
            this.skinLabel1.TabIndex = 101;
            this.skinLabel1.Text = "℃";
            // 
            // lblCity
            // 
            this.lblCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCity.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.BorderColor = System.Drawing.Color.Black;
            this.lblCity.BorderSize = 4;
            this.lblCity.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(23, 63);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(84, 21);
            this.lblCity.TabIndex = 102;
            this.lblCity.Text = "深圳(当地)";
            // 
            // skinToolStrip2
            // 
            this.skinToolStrip2.Arrow = System.Drawing.Color.White;
            this.skinToolStrip2.Back = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BackRadius = 4;
            this.skinToolStrip2.BackRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.skinToolStrip2.Base = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BaseFore = System.Drawing.Color.White;
            this.skinToolStrip2.BaseForeAnamorphosis = true;
            this.skinToolStrip2.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip2.BaseForeAnamorphosisColor = System.Drawing.Color.Black;
            this.skinToolStrip2.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStrip2.BaseHoverFore = System.Drawing.Color.White;
            this.skinToolStrip2.BaseItemAnamorphosis = false;
            this.skinToolStrip2.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.skinToolStrip2.BaseItemBorderShow = false;
            this.skinToolStrip2.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemDown")));
            this.skinToolStrip2.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinToolStrip2.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemMouse")));
            this.skinToolStrip2.BaseItemNorml = null;
            this.skinToolStrip2.BaseItemPressed = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BaseItemRadius = 2;
            this.skinToolStrip2.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip2.BaseItemSplitter = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BindTabControl = null;
            this.skinToolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.skinToolStrip2.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip2.Fore = System.Drawing.Color.Black;
            this.skinToolStrip2.GripMargin = new System.Windows.Forms.Padding(0);
            this.skinToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.skinToolStrip2.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip2.ImageScalingSize = new System.Drawing.Size(37, 32);
            this.skinToolStrip2.ItemAnamorphosis = false;
            this.skinToolStrip2.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemBorderShow = false;
            this.skinToolStrip2.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemRadius = 1;
            this.skinToolStrip2.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTodayImg,
            this.toolTomorrowImg,
            this.toolAfterImg});
            this.skinToolStrip2.Location = new System.Drawing.Point(1, 148);
            this.skinToolStrip2.Name = "skinToolStrip2";
            this.skinToolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.skinToolStrip2.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip2.Size = new System.Drawing.Size(242, 80);
            this.skinToolStrip2.SkinAllColor = true;
            this.skinToolStrip2.TabIndex = 132;
            this.skinToolStrip2.Text = "今天";
            this.skinToolStrip2.TitleAnamorphosis = false;
            this.skinToolStrip2.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip2.TitleRadius = 4;
            this.skinToolStrip2.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            // 
            // toolTodayImg
            // 
            this.toolTodayImg.AutoSize = false;
            this.toolTodayImg.AutoToolTip = false;
            this.toolTodayImg.ForeColor = System.Drawing.Color.White;
            this.toolTodayImg.Image = ((System.Drawing.Image)(resources.GetObject("toolTodayImg.Image")));
            this.toolTodayImg.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTodayImg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTodayImg.Margin = new System.Windows.Forms.Padding(0);
            this.toolTodayImg.MergeIndex = 0;
            this.toolTodayImg.Name = "toolTodayImg";
            this.toolTodayImg.Size = new System.Drawing.Size(80, 80);
            this.toolTodayImg.Text = "今天";
            this.toolTodayImg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // toolTomorrowImg
            // 
            this.toolTomorrowImg.AutoSize = false;
            this.toolTomorrowImg.AutoToolTip = false;
            this.toolTomorrowImg.ForeColor = System.Drawing.Color.White;
            this.toolTomorrowImg.Image = ((System.Drawing.Image)(resources.GetObject("toolTomorrowImg.Image")));
            this.toolTomorrowImg.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTomorrowImg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTomorrowImg.Margin = new System.Windows.Forms.Padding(0);
            this.toolTomorrowImg.MergeIndex = 0;
            this.toolTomorrowImg.Name = "toolTomorrowImg";
            this.toolTomorrowImg.Size = new System.Drawing.Size(80, 80);
            this.toolTomorrowImg.Text = "明天";
            this.toolTomorrowImg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // toolAfterImg
            // 
            this.toolAfterImg.AutoSize = false;
            this.toolAfterImg.AutoToolTip = false;
            this.toolAfterImg.ForeColor = System.Drawing.Color.White;
            this.toolAfterImg.Image = ((System.Drawing.Image)(resources.GetObject("toolAfterImg.Image")));
            this.toolAfterImg.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolAfterImg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAfterImg.Margin = new System.Windows.Forms.Padding(0);
            this.toolAfterImg.MergeIndex = 0;
            this.toolAfterImg.Name = "toolAfterImg";
            this.toolAfterImg.Size = new System.Drawing.Size(80, 80);
            this.toolAfterImg.Text = "后天";
            this.toolAfterImg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // skinLabel2
            // 
            this.skinLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.Black;
            this.skinLabel2.BorderSize = 4;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel2.ForeColor = System.Drawing.Color.White;
            this.skinLabel2.Location = new System.Drawing.Point(62, 229);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(162, 17);
            this.skinLabel2.TabIndex = 133;
            this.skinLabel2.Text = "端午节了,中国任你游,特价了!";
            // 
            // skinLabel3
            // 
            this.skinLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(197)))), ((int)(((byte)(48)))));
            this.skinLabel3.BorderSize = 3;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.skinLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(197)))), ((int)(((byte)(48)))));
            this.skinLabel3.Location = new System.Drawing.Point(24, 227);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(35, 21);
            this.skinLabel3.TabIndex = 134;
            this.skinLabel3.Text = "2折";
            // 
            // FrmWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::QQMetro.Properties.Resources.main_2;
            this.BackLayout = false;
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.BackRectangle = new System.Drawing.Rectangle(2, 2, 2, 2);
            this.BackToColor = false;
            this.BorderPalace = global::QQMetro.Properties.Resources.BackPalace;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(240, 250);
            this.CloseBoxSize = new System.Drawing.Size(39, 20);
            this.ControlBox = false;
            this.ControlBoxOffset = new System.Drawing.Point(0, -1);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinToolStrip2);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.lblTQ);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel3);
            this.DropBack = false;
            this.EffectCaption = CCWin.TitleType.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(28, 20);
            this.MinimizeBox = false;
            this.MiniSize = new System.Drawing.Size(28, 20);
            this.Mobile = CCWin.MobileStyle.None;
            this.Name = "FrmWeather";
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.Special = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmWeather_FormClosing);
            this.Load += new System.EventHandler(this.FrmInformation_Load);
            this.skinToolStrip2.ResumeLayout(false);
            this.skinToolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timShow;
        private CCWin.SkinControl.SkinLabel lblTQ;
        private CCWin.SkinControl.SkinLabel lblWeather;
        private CCWin.SkinControl.SkinButton btnState;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel lblCity;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip2;
        private System.Windows.Forms.ToolStripButton toolTodayImg;
        private System.Windows.Forms.ToolStripButton toolTomorrowImg;
        private System.Windows.Forms.ToolStripButton toolAfterImg;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
    }
}