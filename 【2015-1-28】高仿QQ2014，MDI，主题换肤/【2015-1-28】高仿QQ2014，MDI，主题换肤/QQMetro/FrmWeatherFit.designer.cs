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
 * * 说明：FrmWeatherFit.designer.cs
 * *
********************************************************************/

namespace QQMetro
{
    partial class FrmWeatherFit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeatherFit));
            this.lblFit = new CCWin.SkinControl.SkinLabel();
            this.btnOk = new CCWin.SkinControl.SkinButton();
            this.lbWeather = new CCWin.SkinControl.SkinListBox();
            this.BaseText = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.txtCode = new CCWin.SkinControl.SkinAlphaWaterTextBox();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFit
            // 
            this.lblFit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFit.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblFit.AutoSize = true;
            this.lblFit.BackColor = System.Drawing.Color.Transparent;
            this.lblFit.BorderColor = System.Drawing.Color.Black;
            this.lblFit.BorderSize = 4;
            this.lblFit.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblFit.ForeColor = System.Drawing.Color.White;
            this.lblFit.Location = new System.Drawing.Point(11, 10);
            this.lblFit.Name = "lblFit";
            this.lblFit.Size = new System.Drawing.Size(37, 20);
            this.lblFit.TabIndex = 102;
            this.lblFit.Text = "设置";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(169)))), ((int)(((byte)(213)))));
            this.btnOk.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOk.DownBack = ((System.Drawing.Image)(resources.GetObject("btnOk.DownBack")));
            this.btnOk.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.btnOk.Location = new System.Drawing.Point(85, 219);
            this.btnOk.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnOk.MouseBack")));
            this.btnOk.Name = "btnOk";
            this.btnOk.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnOk.NormlBack")));
            this.btnOk.Palace = true;
            this.btnOk.Size = new System.Drawing.Size(70, 25);
            this.btnOk.TabIndex = 103;
            this.btnOk.Text = "完成";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbWeather
            // 
            this.lbWeather.Back = ((System.Drawing.Image)(resources.GetObject("lbWeather.Back")));
            this.lbWeather.BackColor = System.Drawing.Color.Transparent;
            this.lbWeather.BorderColor = System.Drawing.Color.Transparent;
            this.lbWeather.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbWeather.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbWeather.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbWeather.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lbWeather.ForeColor = System.Drawing.Color.White;
            this.lbWeather.FormattingEnabled = true;
            this.lbWeather.ImagePoint = false;
            this.lbWeather.ItemBorderVisble = false;
            this.lbWeather.ItemGlassVisble = false;
            this.lbWeather.ItemHeight = 30;
            this.lbWeather.ItemRadius = 4;
            this.lbWeather.Items.AddRange(new CCWin.SkinControl.SkinListBoxItem[] {
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("lbWeather.Items"))),
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("lbWeather.Items1"))),
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("lbWeather.Items2"))),
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("lbWeather.Items3")))});
            this.lbWeather.Location = new System.Drawing.Point(11, 75);
            this.lbWeather.Margin = new System.Windows.Forms.Padding(0);
            this.lbWeather.MouseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbWeather.Name = "lbWeather";
            this.lbWeather.Radius = 6;
            this.lbWeather.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.lbWeather.RowBackColor1 = System.Drawing.Color.Transparent;
            this.lbWeather.RowBackColor2 = System.Drawing.Color.Transparent;
            this.lbWeather.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbWeather.Size = new System.Drawing.Size(220, 120);
            this.lbWeather.TabIndex = 106;
            this.lbWeather.SelectedIndexChanged += new System.EventHandler(this.lbWeather_SelectedIndexChanged);
            // 
            // BaseText
            // 
            this.BaseText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(140)))), ((int)(((byte)(165)))));
            this.BaseText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BaseText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseText.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.BaseText.ForeColor = System.Drawing.Color.White;
            this.BaseText.Location = new System.Drawing.Point(5, 5);
            this.BaseText.Name = "BaseText";
            this.BaseText.Size = new System.Drawing.Size(210, 18);
            this.BaseText.TabIndex = 0;
            this.BaseText.WaterColor = System.Drawing.Color.White;
            this.BaseText.WaterText = "输入需要显示天气的城市";
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel1.BackgroundImage")));
            this.skinPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinPanel1.Controls.Add(this.txtCode);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(10, 34);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(222, 34);
            this.skinPanel1.TabIndex = 108;
            // 
            // txtCode
            // 
            this.txtCode.BackAlpha = 0;
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(134)))), ((int)(((byte)(161)))));
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCode.ForeColor = System.Drawing.Color.White;
            this.txtCode.Location = new System.Drawing.Point(9, 9);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(205, 16);
            this.txtCode.TabIndex = 0;
            this.txtCode.WaterColor = System.Drawing.Color.White;
            this.txtCode.WaterFont = new System.Drawing.Font("微软雅黑", 9F);
            this.txtCode.WaterText = "输入需要显示天气的城市";
            // 
            // FrmWeatherFit
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.BackLayout = false;
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.BackRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.BackToColor = false;
            this.BorderPalace = global::QQMetro.Properties.Resources.BackPalace;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(240, 250);
            this.CloseBoxSize = new System.Drawing.Size(39, 20);
            this.ControlBox = false;
            this.ControlBoxOffset = new System.Drawing.Point(0, -1);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.lbWeather);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblFit);
            this.DropBack = false;
            this.EffectCaption = CCWin.TitleType.None;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(28, 20);
            this.MinimizeBox = false;
            this.MiniSize = new System.Drawing.Size(28, 20);
            this.Mobile = CCWin.MobileStyle.None;
            this.Name = "FrmWeatherFit";
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.Special = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "设置";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmWeatherFit_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel lblFit;
        private CCWin.SkinControl.SkinButton btnOk;
        private CCWin.SkinControl.SkinListBox lbWeather;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinWaterTextBox BaseText;
        private CCWin.SkinControl.SkinAlphaWaterTextBox txtCode;
    }
}