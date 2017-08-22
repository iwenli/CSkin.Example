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
 * * 作者： 乔克斯 QQ：345015918 .Net项目技术组群：306485590
 * * 请保留以上版权信息，否则作者将保留追究法律责任。
 * *
 * * 创建时间：2013-12-08
 * * 说明：FrmMain.Designer.cs
 * *
********************************************************************/

namespace loli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ImgShow = new CCWin.SkinControl.SkinAnimatorImg();
            this.btnSurprise = new CCWin.SkinControl.SkinButton();
            this.btnProud = new CCWin.SkinControl.SkinButton();
            this.btnFine = new CCWin.SkinControl.SkinButton();
            this.btnCry = new CCWin.SkinControl.SkinButton();
            this.btnWink = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // ImgShow
            // 
            this.ImgShow.BackColor = System.Drawing.Color.Transparent;
            this.ImgShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImgShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImgShow.FrameNumber = 3;
            this.ImgShow.FrameRate = 80;
            this.ImgShow.Image = ((System.Drawing.Image)(resources.GetObject("ImgShow.Image")));
            this.ImgShow.Location = new System.Drawing.Point(0, 0);
            this.ImgShow.Name = "ImgShow";
            this.ImgShow.OneFrame = 1;
            this.ImgShow.Size = new System.Drawing.Size(206, 250);
            this.ImgShow.StartTime = 6000;
            this.ImgShow.Stretch = true;
            this.ImgShow.TabIndex = 0;
            // 
            // btnSurprise
            // 
            this.btnSurprise.BackColor = System.Drawing.Color.Transparent;
            this.btnSurprise.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSurprise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSurprise.DownBack = null;
            this.btnSurprise.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.btnSurprise.FadeGlow = false;
            this.btnSurprise.InheritColor = false;
            this.btnSurprise.Location = new System.Drawing.Point(160, 16);
            this.btnSurprise.MouseBack = null;
            this.btnSurprise.Name = "btnSurprise";
            this.btnSurprise.NormlBack = null;
            this.btnSurprise.Size = new System.Drawing.Size(45, 45);
            this.btnSurprise.TabIndex = 5;
            this.btnSurprise.Tag = "3";
            this.btnSurprise.UseVisualStyleBackColor = false;
            this.btnSurprise.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnProud
            // 
            this.btnProud.BackColor = System.Drawing.Color.Transparent;
            this.btnProud.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnProud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProud.DownBack = null;
            this.btnProud.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.btnProud.FadeGlow = false;
            this.btnProud.InheritColor = false;
            this.btnProud.Location = new System.Drawing.Point(114, 1);
            this.btnProud.MouseBack = null;
            this.btnProud.Name = "btnProud";
            this.btnProud.NormlBack = null;
            this.btnProud.Size = new System.Drawing.Size(45, 45);
            this.btnProud.TabIndex = 4;
            this.btnProud.Tag = "2";
            this.btnProud.UseVisualStyleBackColor = false;
            this.btnProud.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnFine
            // 
            this.btnFine.BackColor = System.Drawing.Color.Transparent;
            this.btnFine.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnFine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFine.DownBack = null;
            this.btnFine.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.btnFine.FadeGlow = false;
            this.btnFine.InheritColor = false;
            this.btnFine.Location = new System.Drawing.Point(49, 1);
            this.btnFine.MouseBack = null;
            this.btnFine.Name = "btnFine";
            this.btnFine.NormlBack = null;
            this.btnFine.Size = new System.Drawing.Size(45, 45);
            this.btnFine.TabIndex = 3;
            this.btnFine.Tag = "1";
            this.btnFine.UseVisualStyleBackColor = false;
            this.btnFine.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCry
            // 
            this.btnCry.BackColor = System.Drawing.Color.Transparent;
            this.btnCry.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCry.DownBack = null;
            this.btnCry.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.btnCry.FadeGlow = false;
            this.btnCry.InheritColor = false;
            this.btnCry.Location = new System.Drawing.Point(2, 25);
            this.btnCry.MouseBack = null;
            this.btnCry.Name = "btnCry";
            this.btnCry.NormlBack = null;
            this.btnCry.Size = new System.Drawing.Size(45, 45);
            this.btnCry.TabIndex = 2;
            this.btnCry.Tag = "0";
            this.btnCry.UseVisualStyleBackColor = false;
            this.btnCry.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnWink
            // 
            this.btnWink.BackColor = System.Drawing.Color.Transparent;
            this.btnWink.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnWink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWink.DownBack = null;
            this.btnWink.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.btnWink.FadeGlow = false;
            this.btnWink.InheritColor = false;
            this.btnWink.Location = new System.Drawing.Point(3, 346);
            this.btnWink.MouseBack = null;
            this.btnWink.Name = "btnWink";
            this.btnWink.NormlBack = null;
            this.btnWink.Size = new System.Drawing.Size(45, 45);
            this.btnWink.TabIndex = 1;
            this.btnWink.Tag = "4";
            this.btnWink.UseVisualStyleBackColor = false;
            this.btnWink.Click += new System.EventHandler(this.btn_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 500);
            this.Controls.Add(this.btnSurprise);
            this.Controls.Add(this.btnProud);
            this.Controls.Add(this.btnFine);
            this.Controls.Add(this.btnCry);
            this.Controls.Add(this.btnWink);
            this.Controls.Add(this.ImgShow);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.SkinBack = ((System.Drawing.Image)(resources.GetObject("$this.SkinBack")));
            this.SkinShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinAnimatorImg ImgShow;
        private CCWin.SkinControl.SkinButton btnSurprise;
        private CCWin.SkinControl.SkinButton btnProud;
        private CCWin.SkinControl.SkinButton btnFine;
        private CCWin.SkinControl.SkinButton btnCry;
        private CCWin.SkinControl.SkinButton btnWink;
    }
}

