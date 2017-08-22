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
 * * 说明：UserInformationForm.designer.cs
 * *
********************************************************************/

namespace QQMetro
{
    partial class UserInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInformationForm));
            this.timShow = new System.Windows.Forms.Timer(this.components);
            this.imgQQShow = new System.Windows.Forms.PictureBox();
            this.lblName = new CCWin.SkinControl.SkinLabel();
            this.lblQm = new CCWin.SkinControl.SkinLabel();
            this.timMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgQQShow)).BeginInit();
            this.SuspendLayout();
            // 
            // timShow
            // 
            this.timShow.Enabled = true;
            this.timShow.Interval = 800;
            this.timShow.Tick += new System.EventHandler(this.timShow_Tick);
            // 
            // imgQQShow
            // 
            this.imgQQShow.BackColor = System.Drawing.Color.White;
            this.imgQQShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgQQShow.Image = ((System.Drawing.Image)(resources.GetObject("imgQQShow.Image")));
            this.imgQQShow.Location = new System.Drawing.Point(6, 13);
            this.imgQQShow.Name = "imgQQShow";
            this.imgQQShow.Size = new System.Drawing.Size(84, 141);
            this.imgQQShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgQQShow.TabIndex = 0;
            this.imgQQShow.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.BorderColor = System.Drawing.Color.Black;
            this.lblName.BorderSize = 4;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(96, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 30);
            this.lblName.TabIndex = 101;
            this.lblName.Text = "威廉乔克斯_汀";
            this.lblName.MouseEnter += new System.EventHandler(this.lblChatName_MouseEnter);
            this.lblName.MouseLeave += new System.EventHandler(this.lblChatName_MouseLeave);
            // 
            // lblQm
            // 
            this.lblQm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQm.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblQm.BackColor = System.Drawing.Color.Transparent;
            this.lblQm.BorderColor = System.Drawing.Color.Black;
            this.lblQm.BorderSize = 4;
            this.lblQm.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblQm.ForeColor = System.Drawing.Color.White;
            this.lblQm.Location = new System.Drawing.Point(97, 42);
            this.lblQm.Name = "lblQm";
            this.lblQm.Size = new System.Drawing.Size(176, 20);
            this.lblQm.TabIndex = 102;
            this.lblQm.Text = "退一步海阔天空！";
            // 
            // timMove
            // 
            this.timMove.Interval = 800;
            this.timMove.Tick += new System.EventHandler(this.timMove_Tick);
            // 
            // UserInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.BackLayout = false;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(279, 181);
            this.CloseBoxSize = new System.Drawing.Size(39, 20);
            this.ControlBox = false;
            this.ControlBoxOffset = new System.Drawing.Point(0, -1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblQm);
            this.Controls.Add(this.imgQQShow);
            this.DropBack = false;
            this.EffectCaption = CCWin.TitleType.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(28, 20);
            this.MinimizeBox = false;
            this.MiniSize = new System.Drawing.Size(28, 20);
            this.Mobile = CCWin.MobileStyle.None;
            this.Name = "UserInformationForm";
            this.Radius = 2;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmInformation_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmUserInformation_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.imgQQShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timShow;
        private System.Windows.Forms.PictureBox imgQQShow;
        private CCWin.SkinControl.SkinLabel lblName;
        private CCWin.SkinControl.SkinLabel lblQm;
        private System.Windows.Forms.Timer timMove;
    }
}