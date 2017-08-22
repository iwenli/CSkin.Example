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
 * * 说明：LoginCode.Designer.cs
 * *
********************************************************************/

namespace QQMetro
{
    partial class LoginCode
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCode));
            this.btnSetLoginBh = new System.Windows.Forms.LinkLabel();
            this.btnCkLoginD = new System.Windows.Forms.LinkLabel();
            this.lblNewCode = new System.Windows.Forms.LinkLabel();
            this.txtCode = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.btnQx = new CCWin.SkinControl.SkinButton();
            this.btnOk = new CCWin.SkinControl.SkinButton();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.lblErroCode = new CCWin.SkinControl.SkinLabel();
            this.CodeImg = new CCWin.SkinControl.SkinCode();
            this.txtCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetLoginBh
            // 
            this.btnSetLoginBh.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(111)))), ((int)(((byte)(234)))));
            this.btnSetLoginBh.AutoSize = true;
            this.btnSetLoginBh.BackColor = System.Drawing.Color.Transparent;
            this.btnSetLoginBh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetLoginBh.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnSetLoginBh.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(133)))), ((int)(((byte)(227)))));
            this.btnSetLoginBh.Location = new System.Drawing.Point(287, 222);
            this.btnSetLoginBh.Name = "btnSetLoginBh";
            this.btnSetLoginBh.Size = new System.Drawing.Size(80, 17);
            this.btnSetLoginBh.TabIndex = 30;
            this.btnSetLoginBh.TabStop = true;
            this.btnSetLoginBh.Text = "设置登录保护";
            this.btnSetLoginBh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSetLoginBh_LinkClicked);
            // 
            // btnCkLoginD
            // 
            this.btnCkLoginD.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(111)))), ((int)(((byte)(234)))));
            this.btnCkLoginD.AutoSize = true;
            this.btnCkLoginD.BackColor = System.Drawing.Color.Transparent;
            this.btnCkLoginD.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCkLoginD.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnCkLoginD.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(133)))), ((int)(((byte)(227)))));
            this.btnCkLoginD.Location = new System.Drawing.Point(257, 207);
            this.btnCkLoginD.Name = "btnCkLoginD";
            this.btnCkLoginD.Size = new System.Drawing.Size(68, 17);
            this.btnCkLoginD.TabIndex = 29;
            this.btnCkLoginD.TabStop = true;
            this.btnCkLoginD.Text = "查看登录地";
            this.btnCkLoginD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCkLoginD_LinkClicked);
            // 
            // lblNewCode
            // 
            this.lblNewCode.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(111)))), ((int)(((byte)(234)))));
            this.lblNewCode.AutoSize = true;
            this.lblNewCode.BackColor = System.Drawing.Color.Transparent;
            this.lblNewCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNewCode.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblNewCode.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(133)))), ((int)(((byte)(227)))));
            this.lblNewCode.Location = new System.Drawing.Point(244, 139);
            this.lblNewCode.Name = "lblNewCode";
            this.lblNewCode.Size = new System.Drawing.Size(92, 17);
            this.lblNewCode.TabIndex = 28;
            this.lblNewCode.TabStop = true;
            this.lblNewCode.Text = "看不清，换一张";
            this.lblNewCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNewCode_LinkClicked);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.Transparent;
            this.txtCode.DownBack = ((System.Drawing.Bitmap)(resources.GetObject("txtCode.DownBack")));
            this.txtCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCode.Icon = null;
            this.txtCode.IconIsButton = false;
            this.txtCode.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCode.Location = new System.Drawing.Point(88, 64);
            this.txtCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtCode.MinimumSize = new System.Drawing.Size(28, 26);
            this.txtCode.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("txtCode.MouseBack")));
            this.txtCode.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCode.Name = "txtCode";
            this.txtCode.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("txtCode.NormlBack")));
            this.txtCode.Padding = new System.Windows.Forms.Padding(4);
            this.txtCode.Size = new System.Drawing.Size(260, 26);
            // 
            // txtCode.BaseText
            // 
            this.txtCode.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtCode.SkinTxt.Location = new System.Drawing.Point(4, 4);
            this.txtCode.SkinTxt.Name = "BaseText";
            this.txtCode.SkinTxt.Size = new System.Drawing.Size(252, 18);
            this.txtCode.SkinTxt.TabIndex = 0;
            this.txtCode.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCode.SkinTxt.WaterText = "以下字符不区分大小写";
            this.txtCode.TabIndex = 40;
            this.txtCode.Tag = "";
            // 
            // skinLabel4
            // 
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(85, 42);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(224, 17);
            this.skinLabel4.TabIndex = 39;
            this.skinLabel4.Text = "为了您的账号安全，本次登录需输验证码";
            // 
            // btnQx
            // 
            this.btnQx.BackColor = System.Drawing.Color.Transparent;
            this.btnQx.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnQx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnQx.DownBack = ((System.Drawing.Image)(resources.GetObject("btnQx.DownBack")));
            this.btnQx.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnQx.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQx.Location = new System.Drawing.Point(339, 272);
            this.btnQx.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnQx.MouseBack")));
            this.btnQx.Name = "btnQx";
            this.btnQx.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnQx.NormlBack")));
            this.btnQx.Palace = true;
            this.btnQx.Size = new System.Drawing.Size(83, 25);
            this.btnQx.TabIndex = 37;
            this.btnQx.Text = "取消";
            this.btnQx.UseVisualStyleBackColor = false;
            this.btnQx.Click += new System.EventHandler(this.btnQx_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnOk.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOk.DownBack = ((System.Drawing.Image)(resources.GetObject("btnOk.DownBack")));
            this.btnOk.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.Location = new System.Drawing.Point(253, 272);
            this.btnOk.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnOk.MouseBack")));
            this.btnOk.Name = "btnOk";
            this.btnOk.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnOk.NormlBack")));
            this.btnOk.Palace = true;
            this.btnOk.Size = new System.Drawing.Size(83, 25);
            this.btnOk.TabIndex = 38;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.Image")));
            this.skinPictureBox1.Location = new System.Drawing.Point(45, 38);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(36, 36);
            this.skinPictureBox1.TabIndex = 36;
            this.skinPictureBox1.TabStop = false;
            // 
            // skinLabel3
            // 
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel3.Location = new System.Drawing.Point(86, 222);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(211, 17);
            this.skinLabel3.TabIndex = 35;
            this.skinLabel3.Text = "·您的网络有危及QQ用户安全的行为，";
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel2.Location = new System.Drawing.Point(86, 207);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(179, 17);
            this.skinLabel2.TabIndex = 34;
            this.skinLabel2.Text = "·您本次登录地与常登录地不符，";
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.skinLabel1.Location = new System.Drawing.Point(84, 180);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(143, 19);
            this.skinLabel1.TabIndex = 33;
            this.skinLabel1.Text = "需要验证的原因可能是:";
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel1.Controls.Add(this.CodeImg);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = ((System.Drawing.Image)(resources.GetObject("skinPanel1.DownBack")));
            this.skinPanel1.Location = new System.Drawing.Point(88, 97);
            this.skinPanel1.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinPanel1.MouseBack")));
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinPanel1.NormlBack")));
            this.skinPanel1.Palace = true;
            this.skinPanel1.Size = new System.Drawing.Size(134, 60);
            this.skinPanel1.TabIndex = 27;
            // 
            // lblErroCode
            // 
            this.lblErroCode.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblErroCode.AutoSize = true;
            this.lblErroCode.BackColor = System.Drawing.Color.Transparent;
            this.lblErroCode.BorderColor = System.Drawing.Color.White;
            this.lblErroCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblErroCode.ForeColor = System.Drawing.Color.Red;
            this.lblErroCode.Location = new System.Drawing.Point(351, 69);
            this.lblErroCode.Name = "lblErroCode";
            this.lblErroCode.Size = new System.Drawing.Size(68, 17);
            this.lblErroCode.TabIndex = 41;
            this.lblErroCode.Text = "验证码错误";
            this.lblErroCode.Visible = false;
            // 
            // CodeImg
            // 
            this.CodeImg.CodeImg = ((System.Drawing.Image)(resources.GetObject("CodeImg.CodeImg")));
            this.CodeImg.Color_BackGround = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(254)))), ((int)(((byte)(236))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(250)))), ((int)(((byte)(246))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))))};
            this.CodeImg.Location = new System.Drawing.Point(2, 2);
            this.CodeImg.Name = "CodeImg";
            this.CodeImg.Size = new System.Drawing.Size(130, 56);
            this.CodeImg.TabIndex = 0;
            this.CodeImg.VcArray = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "A",
        "B",
        "C",
        "D",
        "E",
        "F",
        "G",
        "H",
        "J",
        "K",
        "M",
        "N",
        "P",
        "Q",
        "R",
        "S",
        "T",
        "U",
        "V",
        "W",
        "X",
        "Y",
        "Z"};
            // 
            // LoginCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblErroCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.btnQx);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.btnSetLoginBh);
            this.Controls.Add(this.btnCkLoginD);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.lblNewCode);
            this.Controls.Add(this.skinPanel1);
            this.DoubleBuffered = true;
            this.Name = "LoginCode";
            this.Size = new System.Drawing.Size(430, 300);
            this.VisibleChanged += new System.EventHandler(this.LoginCode_VisibleChanged);
            this.txtCode.ResumeLayout(false);
            this.txtCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel btnSetLoginBh;
        private System.Windows.Forms.LinkLabel btnCkLoginD;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.LinkLabel lblNewCode;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinButton btnQx;
        private CCWin.SkinControl.SkinButton btnOk;
        private CCWin.SkinControl.SkinTextBox txtCode;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel lblErroCode;
        private CCWin.SkinControl.SkinCode CodeImg;
    }
}
