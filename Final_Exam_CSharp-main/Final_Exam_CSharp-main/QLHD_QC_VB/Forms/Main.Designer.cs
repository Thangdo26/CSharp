﻿namespace QLHD_QC_VB.Forms
{
    partial class frmQLHD
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
            menuStrip1 = new MenuStrip();
            mnudanhmuc = new ToolStripMenuItem();
            mnunhanvien = new ToolStripMenuItem();
            mnukhachhang = new ToolStripMenuItem();
            mnubao = new ToolStripMenuItem();
            mnuhopdong = new ToolStripMenuItem();
            mnuhopdongquangcao = new ToolStripMenuItem();
            mnuhopdongvietbai = new ToolStripMenuItem();
            mnubaocao = new ToolStripMenuItem();
            mnutimkiem = new ToolStripMenuItem();
            mnuthoat = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnudanhmuc, mnuhopdong, mnubaocao, mnutimkiem, mnuthoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1158, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnudanhmuc
            // 
            mnudanhmuc.DropDownItems.AddRange(new ToolStripItem[] { mnunhanvien, mnukhachhang, mnubao });
            mnudanhmuc.Name = "mnudanhmuc";
            mnudanhmuc.Size = new Size(109, 29);
            mnudanhmuc.Text = "Danh mục";
            // 
            // mnunhanvien
            // 
            mnunhanvien.Name = "mnunhanvien";
            mnunhanvien.Size = new Size(206, 34);
            mnunhanvien.Text = "Nhân viên";
            mnunhanvien.Click += mnunhanvien_Click;
            // 
            // mnukhachhang
            // 
            mnukhachhang.Name = "mnukhachhang";
            mnukhachhang.Size = new Size(206, 34);
            mnukhachhang.Text = "Khách hàng";
            mnukhachhang.Click += mnukhachhang_Click;
            // 
            // mnubao
            // 
            mnubao.Name = "mnubao";
            mnubao.Size = new Size(206, 34);
            mnubao.Text = "Báo";
            mnubao.Click += mnubao_Click;
            // 
            // mnuhopdong
            // 
            mnuhopdong.DropDownItems.AddRange(new ToolStripItem[] { mnuhopdongquangcao, mnuhopdongvietbai });
            mnuhopdong.Name = "mnuhopdong";
            mnuhopdong.Size = new Size(111, 29);
            mnuhopdong.Text = "Hợp đồng";
            // 
            // mnuhopdongquangcao
            // 
            mnuhopdongquangcao.Name = "mnuhopdongquangcao";
            mnuhopdongquangcao.Size = new Size(289, 34);
            mnuhopdongquangcao.Text = "Hợp đồng Quảng cáo";
            mnuhopdongquangcao.Click += mnuhopdongquangcao_Click;
            // 
            // mnuhopdongvietbai
            // 
            mnuhopdongvietbai.Name = "mnuhopdongvietbai";
            mnuhopdongvietbai.Size = new Size(289, 34);
            mnuhopdongvietbai.Text = "Hợp đồng Viết bài";
            mnuhopdongvietbai.Click += mnuhopdongvietbai_Click;
            // 
            // mnubaocao
            // 
            mnubaocao.Name = "mnubaocao";
            mnubaocao.Size = new Size(96, 29);
            mnubaocao.Text = "Báo cáo ";
            // 
            // mnutimkiem
            // 
            mnutimkiem.Name = "mnutimkiem";
            mnutimkiem.Size = new Size(100, 29);
            mnutimkiem.Text = "Tìm kiếm";
            mnutimkiem.Click += mnutimkiem_Click;
            // 
            // mnuthoat
            // 
            mnuthoat.Name = "mnuthoat";
            mnuthoat.Size = new Size(73, 29);
            mnuthoat.Text = "Thoát";
            // 
            // frmQLHD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 652);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmQLHD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Hợp đồng Quảng cáo và Viết bài";
            Load += frmQLHD_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnudanhmuc;
        private ToolStripMenuItem mnunhanvien;
        private ToolStripMenuItem mnukhachhang;
        private ToolStripMenuItem mnubao;
        private ToolStripMenuItem mnuhopdong;
        private ToolStripMenuItem mnuhopdongquangcao;
        private ToolStripMenuItem mnuhopdongvietbai;
        private ToolStripMenuItem mnubaocao;
        private ToolStripMenuItem mnutimkiem;
        private ToolStripMenuItem mnuthoat;
    }
}