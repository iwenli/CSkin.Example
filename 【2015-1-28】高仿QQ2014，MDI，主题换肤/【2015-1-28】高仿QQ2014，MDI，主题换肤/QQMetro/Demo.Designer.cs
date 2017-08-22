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
 * * 说明：Demo.Designer.cs
 * *
********************************************************************/

namespace QQMetro
{
    partial class Demo
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
            this.btnMdi = new CCWin.SkinControl.SkinButton();
            this.btnTheme = new CCWin.SkinControl.SkinButton();
            this.btnYxForm = new CCWin.SkinControl.SkinButton();
            this.btnQQ2014 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // btnMdi
            // 
            this.btnMdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMdi.BackColor = System.Drawing.Color.Transparent;
            this.btnMdi.BaseColor = System.Drawing.Color.Silver;
            this.btnMdi.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnMdi.DownBack = null;
            this.btnMdi.Location = new System.Drawing.Point(44, 80);
            this.btnMdi.MouseBack = null;
            this.btnMdi.Name = "btnMdi";
            this.btnMdi.NormlBack = null;
            this.btnMdi.Size = new System.Drawing.Size(90, 35);
            this.btnMdi.TabIndex = 0;
            this.btnMdi.Text = "MDI";
            this.btnMdi.UseVisualStyleBackColor = false;
            this.btnMdi.Click += new System.EventHandler(this.btnMdi_Click);
            // 
            // btnTheme
            // 
            this.btnTheme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTheme.BackColor = System.Drawing.Color.Transparent;
            this.btnTheme.BaseColor = System.Drawing.Color.Silver;
            this.btnTheme.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnTheme.DownBack = null;
            this.btnTheme.Location = new System.Drawing.Point(158, 80);
            this.btnTheme.MouseBack = null;
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.NormlBack = null;
            this.btnTheme.Size = new System.Drawing.Size(90, 35);
            this.btnTheme.TabIndex = 0;
            this.btnTheme.Text = "主题换肤";
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // btnYxForm
            // 
            this.btnYxForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYxForm.BackColor = System.Drawing.Color.Transparent;
            this.btnYxForm.BaseColor = System.Drawing.Color.Silver;
            this.btnYxForm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnYxForm.DownBack = null;
            this.btnYxForm.Location = new System.Drawing.Point(44, 147);
            this.btnYxForm.MouseBack = null;
            this.btnYxForm.Name = "btnYxForm";
            this.btnYxForm.NormlBack = null;
            this.btnYxForm.Size = new System.Drawing.Size(90, 35);
            this.btnYxForm.TabIndex = 0;
            this.btnYxForm.Text = "异形窗体";
            this.btnYxForm.UseVisualStyleBackColor = false;
            this.btnYxForm.Click += new System.EventHandler(this.btnYxForm_Click);
            // 
            // btnQQ2014
            // 
            this.btnQQ2014.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQQ2014.BackColor = System.Drawing.Color.Transparent;
            this.btnQQ2014.BaseColor = System.Drawing.Color.Silver;
            this.btnQQ2014.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnQQ2014.DownBack = null;
            this.btnQQ2014.Location = new System.Drawing.Point(158, 147);
            this.btnQQ2014.MouseBack = null;
            this.btnQQ2014.Name = "btnQQ2014";
            this.btnQQ2014.NormlBack = null;
            this.btnQQ2014.Size = new System.Drawing.Size(90, 35);
            this.btnQQ2014.TabIndex = 0;
            this.btnQQ2014.Text = "QQ2014";
            this.btnQQ2014.UseVisualStyleBackColor = false;
            this.btnQQ2014.Click += new System.EventHandler(this.btnQQ2014_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 263);
            this.Controls.Add(this.btnQQ2014);
            this.Controls.Add(this.btnYxForm);
            this.Controls.Add(this.btnTheme);
            this.Controls.Add(this.btnMdi);
            this.MinimumSize = new System.Drawing.Size(292, 263);
            this.Name = "Demo";
            this.Text = "Demo案例";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnMdi;
        private CCWin.SkinControl.SkinButton btnTheme;
        private CCWin.SkinControl.SkinButton btnYxForm;
        private CCWin.SkinControl.SkinButton btnQQ2014;
    }
}