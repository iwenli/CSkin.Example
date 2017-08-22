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
 * * 说明：FrmMdi.Designer.cs
 * *
********************************************************************/

namespace QQMetro
{
    partial class FrmMdi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExitAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdd,
            this.toolStripMenuItem2,
            this.toolExitAll});
            this.menuStrip1.Location = new System.Drawing.Point(4, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolAdd
            // 
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(80, 21);
            this.toolAdd.Text = "添加子窗体";
            this.toolAdd.Click += new System.EventHandler(this.btnAddMdi_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCd,
            this.toolSp,
            this.toolCz});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 21);
            this.toolStripMenuItem2.Text = "子窗体排列";
            // 
            // toolCd
            // 
            this.toolCd.Name = "toolCd";
            this.toolCd.Size = new System.Drawing.Size(124, 22);
            this.toolCd.Text = "层叠排列";
            this.toolCd.Click += new System.EventHandler(this.toolBtnCd_Click);
            // 
            // toolSp
            // 
            this.toolSp.Name = "toolSp";
            this.toolSp.Size = new System.Drawing.Size(124, 22);
            this.toolSp.Text = "水平平铺";
            this.toolSp.Click += new System.EventHandler(this.toolBtnSp_Click);
            // 
            // toolCz
            // 
            this.toolCz.Name = "toolCz";
            this.toolCz.Size = new System.Drawing.Size(124, 22);
            this.toolCz.Text = "垂直平铺";
            this.toolCz.Click += new System.EventHandler(this.toolBtnCz_Click);
            // 
            // toolExitAll
            // 
            this.toolExitAll.Name = "toolExitAll";
            this.toolExitAll.Size = new System.Drawing.Size(104, 21);
            this.toolExitAll.Text = "关闭所有子窗体";
            this.toolExitAll.Click += new System.EventHandler(this.ToolExitAll_Click);
            // 
            // FrmMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(618, 460);
            this.Controls.Add(this.menuStrip1);
            this.InheritBack = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MdiBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MdiBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name = "FrmMdi";
            this.Text = "MDI窗体案例";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolExitAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolCd;
        private System.Windows.Forms.ToolStripMenuItem toolSp;
        private System.Windows.Forms.ToolStripMenuItem toolCz;
        private System.Windows.Forms.ToolStripMenuItem toolAdd;



    }
}