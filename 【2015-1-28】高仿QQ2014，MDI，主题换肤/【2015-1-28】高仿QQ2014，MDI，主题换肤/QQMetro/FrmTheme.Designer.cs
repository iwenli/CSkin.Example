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
 * * 说明：FrmTheme.Designer.cs
 * *
********************************************************************/

namespace QQMetro
{
    partial class FrmTheme
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
            this.cboTheme = new CCWin.SkinControl.SkinComboBox();
            this.btnAbout = new CCWin.SkinControl.SkinButton();
            this.btnMsg = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // cboTheme
            // 
            this.cboTheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheme.FormattingEnabled = true;
            this.cboTheme.Items.AddRange(new object[] {
            "Mac",
            "Dev",
            "VS",
            "Win8",
            "Color",
            "None"});
            this.cboTheme.Location = new System.Drawing.Point(119, 78);
            this.cboTheme.Name = "cboTheme";
            this.cboTheme.Size = new System.Drawing.Size(121, 22);
            this.cboTheme.TabIndex = 0;
            this.cboTheme.WaterText = "";
            this.cboTheme.SelectedIndexChanged += new System.EventHandler(this.cboTheme_SelectedIndexChanged);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(51)))), ((int)(((byte)(161)))), ((int)(((byte)(224)))));
            this.btnAbout.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAbout.DownBack = null;
            this.btnAbout.Location = new System.Drawing.Point(119, 128);
            this.btnAbout.MouseBack = null;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.NormlBack = null;
            this.btnAbout.Size = new System.Drawing.Size(121, 35);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "关于";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnMsg
            // 
            this.btnMsg.BackColor = System.Drawing.Color.Transparent;
            this.btnMsg.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(51)))), ((int)(((byte)(161)))), ((int)(((byte)(224)))));
            this.btnMsg.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnMsg.DownBack = null;
            this.btnMsg.Location = new System.Drawing.Point(119, 191);
            this.btnMsg.MouseBack = null;
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.NormlBack = null;
            this.btnMsg.Size = new System.Drawing.Size(121, 35);
            this.btnMsg.TabIndex = 1;
            this.btnMsg.Text = "弹窗";
            this.btnMsg.UseVisualStyleBackColor = false;
            this.btnMsg.Click += new System.EventHandler(this.btnMsg_Click);
            // 
            // FrmTheme
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 298);
            this.Controls.Add(this.btnMsg);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.cboTheme);
            this.MdiBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name = "FrmTheme";
            this.Text = "主题换肤";
            this.Load += new System.EventHandler(this.FrmTheme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinComboBox cboTheme;
        private CCWin.SkinControl.SkinButton btnAbout;
        private CCWin.SkinControl.SkinButton btnMsg;





    }
}