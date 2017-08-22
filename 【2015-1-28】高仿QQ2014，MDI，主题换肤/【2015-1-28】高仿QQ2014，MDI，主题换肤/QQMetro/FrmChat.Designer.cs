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
 * * 说明：FrmChat.Designer.cs
 * *
********************************************************************/

namespace QQMetro
{
    partial class FrmChat
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
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.imgShow = new System.Windows.Forms.PictureBox();
            this.btnPast = new CCWin.SkinControl.SkinButton();
            this.btnCreateImg = new CCWin.SkinControl.SkinButton();
            this.btnAddImg = new CCWin.SkinControl.SkinButton();
            this.txtSend = new CCWin.SkinControl.SkinChatRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgShow)).BeginInit();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.FileName = "openFileDialog1";
            this.open.Filter = "PNG文件|*.png|JPG文件|*.jpg|BMP文件|*.bmp|GIF文件|*.gif|全部文件|*.*";
            // 
            // imgShow
            // 
            this.imgShow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imgShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgShow.Location = new System.Drawing.Point(380, 2);
            this.imgShow.Name = "imgShow";
            this.imgShow.Size = new System.Drawing.Size(90, 82);
            this.imgShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgShow.TabIndex = 2;
            this.imgShow.TabStop = false;
            // 
            // btnPast
            // 
            this.btnPast.BackColor = System.Drawing.Color.Transparent;
            this.btnPast.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnPast.DownBack = null;
            this.btnPast.InheritColor = false;
            this.btnPast.Location = new System.Drawing.Point(174, 8);
            this.btnPast.MouseBack = null;
            this.btnPast.Name = "btnPast";
            this.btnPast.NormlBack = null;
            this.btnPast.Size = new System.Drawing.Size(75, 23);
            this.btnPast.TabIndex = 1;
            this.btnPast.Text = "读取剪贴板";
            this.btnPast.UseVisualStyleBackColor = false;
            this.btnPast.Click += new System.EventHandler(this.btnPast_Click);
            // 
            // btnCreateImg
            // 
            this.btnCreateImg.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateImg.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCreateImg.DownBack = null;
            this.btnCreateImg.InheritColor = false;
            this.btnCreateImg.Location = new System.Drawing.Point(93, 8);
            this.btnCreateImg.MouseBack = null;
            this.btnCreateImg.Name = "btnCreateImg";
            this.btnCreateImg.NormlBack = null;
            this.btnCreateImg.Size = new System.Drawing.Size(75, 23);
            this.btnCreateImg.TabIndex = 1;
            this.btnCreateImg.Text = "截图";
            this.btnCreateImg.UseVisualStyleBackColor = false;
            this.btnCreateImg.Click += new System.EventHandler(this.btnCreateImg_Click);
            // 
            // btnAddImg
            // 
            this.btnAddImg.BackColor = System.Drawing.Color.Transparent;
            this.btnAddImg.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAddImg.DownBack = null;
            this.btnAddImg.InheritColor = false;
            this.btnAddImg.Location = new System.Drawing.Point(12, 8);
            this.btnAddImg.MouseBack = null;
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.NormlBack = null;
            this.btnAddImg.Size = new System.Drawing.Size(75, 23);
            this.btnAddImg.TabIndex = 1;
            this.btnAddImg.Text = "添加图片";
            this.btnAddImg.UseVisualStyleBackColor = false;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // txtSend
            // 
            this.txtSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSend.EnableAutoDragDrop = true;
            this.txtSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtSend.Location = new System.Drawing.Point(0, 42);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(471, 286);
            this.txtSend.TabIndex = 0;
            this.txtSend.Text = "";
            this.txtSend.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtSend_LinkClicked);
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 328);
            this.Controls.Add(this.imgShow);
            this.Controls.Add(this.btnPast);
            this.Controls.Add(this.btnCreateImg);
            this.Controls.Add(this.btnAddImg);
            this.Controls.Add(this.txtSend);
            this.Name = "FrmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChat";
            this.Load += new System.EventHandler(this.FrmChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnAddImg;
        private System.Windows.Forms.OpenFileDialog open;
        private CCWin.SkinControl.SkinButton btnCreateImg;
        private CCWin.SkinControl.SkinButton btnPast;
        private System.Windows.Forms.PictureBox imgShow;
        private CCWin.SkinControl.SkinChatRichTextBox txtSend;
    }
}