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
 * * 说明：FrmLogin.Designer.cs
 * *
********************************************************************/

namespace QQFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.QQItems = new CCWin.SkinControl.SkinToolStrip();
            this.btnLogin = new System.Windows.Forms.ToolStripButton();
            this.btnRight = new CCWin.SkinControl.SkinButton();
            this.btnLeft = new CCWin.SkinControl.SkinButton();
            this.QQItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // QQItems
            // 
            this.QQItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QQItems.Arrow = System.Drawing.Color.White;
            this.QQItems.AutoSize = false;
            this.QQItems.Back = System.Drawing.Color.Transparent;
            this.QQItems.BackColor = System.Drawing.Color.Transparent;
            this.QQItems.BackRadius = 4;
            this.QQItems.BackRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.QQItems.Base = System.Drawing.Color.Transparent;
            this.QQItems.BaseFore = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.QQItems.BaseForeAnamorphosis = false;
            this.QQItems.BaseForeAnamorphosisBorder = 4;
            this.QQItems.BaseForeAnamorphosisColor = System.Drawing.Color.Black;
            this.QQItems.BaseForeOffset = new System.Drawing.Point(3, 6);
            this.QQItems.BaseHoverFore = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.QQItems.BaseItemAnamorphosis = false;
            this.QQItems.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.QQItems.BaseItemBorderShow = false;
            this.QQItems.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("QQItems.BaseItemDown")));
            this.QQItems.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.QQItems.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("QQItems.BaseItemMouse")));
            this.QQItems.BaseItemNorml = null;
            this.QQItems.BaseItemPressed = System.Drawing.Color.Transparent;
            this.QQItems.BaseItemRadius = 2;
            this.QQItems.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.QQItems.BaseItemSplitter = System.Drawing.Color.Transparent;
            this.QQItems.BindTabControl = null;
            this.QQItems.Dock = System.Windows.Forms.DockStyle.None;
            this.QQItems.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.QQItems.Fore = System.Drawing.Color.Black;
            this.QQItems.GripMargin = new System.Windows.Forms.Padding(0);
            this.QQItems.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.QQItems.HoverFore = System.Drawing.Color.White;
            this.QQItems.ImageScalingSize = new System.Drawing.Size(100, 100);
            this.QQItems.ItemAnamorphosis = false;
            this.QQItems.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.QQItems.ItemBorderShow = false;
            this.QQItems.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.QQItems.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.QQItems.ItemRadius = 1;
            this.QQItems.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.QQItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogin});
            this.QQItems.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.QQItems.Location = new System.Drawing.Point(57, 52);
            this.QQItems.Name = "QQItems";
            this.QQItems.Padding = new System.Windows.Forms.Padding(0);
            this.QQItems.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.QQItems.Size = new System.Drawing.Size(150, 160);
            this.QQItems.SkinAllColor = true;
            this.QQItems.TabIndex = 174;
            this.QQItems.Text = "今天";
            this.QQItems.TitleAnamorphosis = false;
            this.QQItems.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.QQItems.TitleRadius = 4;
            this.QQItems.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoToolTip = false;
            this.btnLogin.Image = global::QQFriend.Properties.Resources.headimg_dl;
            this.btnLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 160);
            this.btnLogin.Text = "账号加载中";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRight.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRight.DownBack = null;
            this.btnRight.Location = new System.Drawing.Point(241, 92);
            this.btnRight.MouseBack = null;
            this.btnRight.Name = "btnRight";
            this.btnRight.NormlBack = null;
            this.btnRight.Size = new System.Drawing.Size(17, 71);
            this.btnRight.TabIndex = 175;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLeft.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLeft.DownBack = null;
            this.btnLeft.Location = new System.Drawing.Point(7, 92);
            this.btnLeft.MouseBack = null;
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.NormlBack = null;
            this.btnLeft.Size = new System.Drawing.Size(17, 71);
            this.btnLeft.TabIndex = 175;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(265, 255);
            this.Controls.Add(this.QQItems);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "QQ登录";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.QQItems.ResumeLayout(false);
            this.QQItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinToolStrip QQItems;
        private CCWin.SkinControl.SkinButton btnRight;
        private CCWin.SkinControl.SkinButton btnLeft;
        private System.Windows.Forms.ToolStripButton btnLogin;

    }
}

