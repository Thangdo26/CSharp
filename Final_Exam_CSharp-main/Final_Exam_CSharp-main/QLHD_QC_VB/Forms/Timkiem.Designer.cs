namespace QLHD_QC_VB.Forms
{
    partial class frmTimkiem
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
            lblLVHD = new Label();
            lblTenKH = new Label();
            lblDiaChi = new Label();
            lblMaKH = new Label();
            cboLVHD = new ComboBox();
            txtTenKH = new TextBox();
            txtDiaChi = new TextBox();
            txtMaKH = new TextBox();
            dataGridView1 = new DataGridView();
            btnTimKiem = new Button();
            btnTimLai = new Button();
            btnDong = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblLVHD
            // 
            lblLVHD.AutoSize = true;
            lblLVHD.Location = new Point(71, 30);
            lblLVHD.Name = "lblLVHD";
            lblLVHD.Size = new Size(166, 25);
            lblLVHD.TabIndex = 0;
            lblLVHD.Text = "Lĩnh vực hoạt động";
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Location = new Point(71, 88);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(134, 25);
            lblTenKH.TabIndex = 1;
            lblTenKH.Text = "Tên khách hàng";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(508, 88);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(65, 25);
            lblDiaChi.TabIndex = 2;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Location = new Point(508, 30);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(133, 25);
            lblMaKH.TabIndex = 3;
            lblMaKH.Text = "Mã khách hàng";
            // 
            // cboLVHD
            // 
            cboLVHD.FormattingEnabled = true;
            cboLVHD.Location = new Point(243, 30);
            cboLVHD.Name = "cboLVHD";
            cboLVHD.Size = new Size(221, 33);
            cboLVHD.TabIndex = 4;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(243, 82);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(219, 31);
            txtTenKH.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(647, 85);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(219, 31);
            txtDiaChi.TabIndex = 6;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(647, 30);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(219, 31);
            txtMaKH.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(839, 305);
            dataGridView1.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(228, 478);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(121, 45);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnTimLai
            // 
            btnTimLai.Location = new Point(405, 478);
            btnTimLai.Name = "btnTimLai";
            btnTimLai.Size = new Size(121, 45);
            btnTimLai.TabIndex = 10;
            btnTimLai.Text = "Tìm lại";
            btnTimLai.UseVisualStyleBackColor = true;
            btnTimLai.Click += btnTimLai_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(574, 478);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(121, 45);
            btnDong.TabIndex = 11;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // frmTimkiem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 544);
            Controls.Add(btnDong);
            Controls.Add(btnTimLai);
            Controls.Add(btnTimKiem);
            Controls.Add(dataGridView1);
            Controls.Add(txtMaKH);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenKH);
            Controls.Add(cboLVHD);
            Controls.Add(lblMaKH);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenKH);
            Controls.Add(lblLVHD);
            Name = "frmTimkiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tìm kiếm khách hàng";
            Load += frmTimkiem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLVHD;
        private Label lblTenKH;
        private Label lblDiaChi;
        private Label lblMaKH;
        private ComboBox cboLVHD;
        private TextBox txtTenKH;
        private TextBox txtDiaChi;
        private TextBox txtMaKH;
        private DataGridView dataGridView1;
        private Button btnTimKiem;
        private Button btnTimLai;
        private Button btnDong;
    }
}