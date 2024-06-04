namespace QLHD_QC_VB.Forms
{
    partial class frmhopdongquangcao
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
            lblHDQC = new Label();
            groupBox1 = new GroupBox();
            lbldienthoai = new Label();
            lbldiachi = new Label();
            lbltennv = new Label();
            lblmanv = new Label();
            lbltenkh = new Label();
            lblmakh = new Label();
            lblngayky = new Label();
            lblmaquangcao = new Label();
            groupBox2 = new GroupBox();
            mskngaykt = new MaskedTextBox();
            mskngaybd = new MaskedTextBox();
            cbomabao = new ComboBox();
            cbomadv = new ComboBox();
            txtthanhtien = new TextBox();
            txtdongia = new TextBox();
            txttendv = new TextBox();
            txttenbao = new TextBox();
            lblmadichvu = new Label();
            lblmabao = new Label();
            txttongtien = new TextBox();
            lbltongtien = new Label();
            btndong = new Button();
            btninhopdong = new Button();
            btnsua = new Button();
            bnthuyhopdong = new Button();
            btnluu = new Button();
            btnthemhopdong = new Button();
            DataGridView = new DataGridView();
            lbltenbao = new Label();
            lbldongia = new Label();
            lblngaykt = new Label();
            lblngaybd = new Label();
            lblthanhtien = new Label();
            lbldichvu = new Label();
            cbotkmaqc = new ComboBox();
            lblmaqc2 = new Label();
            btntimkiem = new Button();
            txtmaqc = new TextBox();
            txttennv = new TextBox();
            txttenkh = new TextBox();
            txtdiachi = new TextBox();
            mskngayky = new MaskedTextBox();
            mskdienthoai = new MaskedTextBox();
            cbomanv = new ComboBox();
            cbomakh = new ComboBox();
            lblnoidung = new Label();
            txtnoidung = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblHDQC
            // 
            lblHDQC.AutoSize = true;
            lblHDQC.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHDQC.Location = new Point(425, 9);
            lblHDQC.Name = "lblHDQC";
            lblHDQC.Size = new Size(335, 38);
            lblHDQC.TabIndex = 0;
            lblHDQC.Text = "HỢP ĐỒNG QUẢNG CÁO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbomakh);
            groupBox1.Controls.Add(cbomanv);
            groupBox1.Controls.Add(mskdienthoai);
            groupBox1.Controls.Add(mskngayky);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(txttenkh);
            groupBox1.Controls.Add(txttennv);
            groupBox1.Controls.Add(txtmaqc);
            groupBox1.Controls.Add(lbldienthoai);
            groupBox1.Controls.Add(lbldiachi);
            groupBox1.Controls.Add(lbltennv);
            groupBox1.Controls.Add(lblmanv);
            groupBox1.Controls.Add(lbltenkh);
            groupBox1.Controls.Add(lblmakh);
            groupBox1.Controls.Add(lblngayky);
            groupBox1.Controls.Add(lblmaquangcao);
            groupBox1.Location = new Point(77, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(993, 204);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // lbldienthoai
            // 
            lbldienthoai.AutoSize = true;
            lbldienthoai.Location = new Point(519, 156);
            lbldienthoai.Name = "lbldienthoai";
            lbldienthoai.Size = new Size(81, 20);
            lbldienthoai.TabIndex = 7;
            lbldienthoai.Text = "Điện thoại:";
            // 
            // lbldiachi
            // 
            lbldiachi.AutoSize = true;
            lbldiachi.Location = new Point(519, 116);
            lbldiachi.Name = "lbldiachi";
            lbldiachi.Size = new Size(58, 20);
            lbldiachi.TabIndex = 6;
            lbldiachi.Text = "Địa chỉ:";
            // 
            // lbltennv
            // 
            lbltennv.AutoSize = true;
            lbltennv.Location = new Point(74, 156);
            lbltennv.Name = "lbltennv";
            lbltennv.Size = new Size(102, 20);
            lbltennv.TabIndex = 5;
            lbltennv.Text = "Tên nhân viên:";
            // 
            // lblmanv
            // 
            lblmanv.AutoSize = true;
            lblmanv.Location = new Point(74, 116);
            lblmanv.Name = "lblmanv";
            lblmanv.Size = new Size(100, 20);
            lblmanv.TabIndex = 4;
            lblmanv.Text = "Mã nhân viên:";
            // 
            // lbltenkh
            // 
            lbltenkh.AutoSize = true;
            lbltenkh.Location = new Point(519, 76);
            lbltenkh.Name = "lbltenkh";
            lbltenkh.Size = new Size(114, 20);
            lbltenkh.TabIndex = 3;
            lbltenkh.Text = "Tên khách hàng:";
            // 
            // lblmakh
            // 
            lblmakh.AutoSize = true;
            lblmakh.Location = new Point(519, 37);
            lblmakh.Name = "lblmakh";
            lblmakh.Size = new Size(112, 20);
            lblmakh.TabIndex = 2;
            lblmakh.Text = "Mã khách hàng:";
            // 
            // lblngayky
            // 
            lblngayky.AutoSize = true;
            lblngayky.Location = new Point(74, 76);
            lblngayky.Name = "lblngayky";
            lblngayky.Size = new Size(65, 20);
            lblngayky.TabIndex = 1;
            lblngayky.Text = "Ngày ký:";
            // 
            // lblmaquangcao
            // 
            lblmaquangcao.AutoSize = true;
            lblmaquangcao.Location = new Point(74, 37);
            lblmaquangcao.Name = "lblmaquangcao";
            lblmaquangcao.Size = new Size(107, 20);
            lblmaquangcao.TabIndex = 0;
            lblmaquangcao.Text = "Mã quảng cáo:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtnoidung);
            groupBox2.Controls.Add(lblnoidung);
            groupBox2.Controls.Add(mskngaykt);
            groupBox2.Controls.Add(mskngaybd);
            groupBox2.Controls.Add(cbomabao);
            groupBox2.Controls.Add(cbomadv);
            groupBox2.Controls.Add(txtthanhtien);
            groupBox2.Controls.Add(txtdongia);
            groupBox2.Controls.Add(txttendv);
            groupBox2.Controls.Add(txttenbao);
            groupBox2.Controls.Add(lblmadichvu);
            groupBox2.Controls.Add(lblmabao);
            groupBox2.Controls.Add(txttongtien);
            groupBox2.Controls.Add(lbltongtien);
            groupBox2.Controls.Add(btndong);
            groupBox2.Controls.Add(btninhopdong);
            groupBox2.Controls.Add(btnsua);
            groupBox2.Controls.Add(bnthuyhopdong);
            groupBox2.Controls.Add(btnluu);
            groupBox2.Controls.Add(btnthemhopdong);
            groupBox2.Controls.Add(DataGridView);
            groupBox2.Controls.Add(lbltenbao);
            groupBox2.Controls.Add(lbldongia);
            groupBox2.Controls.Add(lblngaykt);
            groupBox2.Controls.Add(lblngaybd);
            groupBox2.Controls.Add(lblthanhtien);
            groupBox2.Controls.Add(lbldichvu);
            groupBox2.Location = new Point(22, 286);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1116, 491);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết";
            // 
            // mskngaykt
            // 
            mskngaykt.Location = new Point(639, 95);
            mskngaykt.Name = "mskngaykt";
            mskngaykt.Size = new Size(149, 27);
            mskngaykt.TabIndex = 23;
            // 
            // mskngaybd
            // 
            mskngaybd.Location = new Point(639, 44);
            mskngaybd.Name = "mskngaybd";
            mskngaybd.Size = new Size(149, 27);
            mskngaybd.TabIndex = 22;
            // 
            // cbomabao
            // 
            cbomabao.FormattingEnabled = true;
            cbomabao.Location = new Point(132, 44);
            cbomabao.Name = "cbomabao";
            cbomabao.Size = new Size(100, 28);
            cbomabao.TabIndex = 21;
            // 
            // cbomadv
            // 
            cbomadv.FormattingEnabled = true;
            cbomadv.Location = new Point(132, 95);
            cbomadv.Name = "cbomadv";
            cbomadv.Size = new Size(100, 28);
            cbomadv.TabIndex = 16;
            // 
            // txtthanhtien
            // 
            txtthanhtien.Location = new Point(923, 95);
            txtthanhtien.Name = "txtthanhtien";
            txtthanhtien.Size = new Size(152, 27);
            txtthanhtien.TabIndex = 20;
            // 
            // txtdongia
            // 
            txtdongia.Location = new Point(923, 44);
            txtdongia.Name = "txtdongia";
            txtdongia.Size = new Size(152, 27);
            txtdongia.TabIndex = 19;
            // 
            // txttendv
            // 
            txttendv.Location = new Point(320, 95);
            txttendv.Name = "txttendv";
            txttendv.Size = new Size(173, 27);
            txttendv.TabIndex = 18;
            // 
            // txttenbao
            // 
            txttenbao.Location = new Point(320, 44);
            txttenbao.Name = "txttenbao";
            txttenbao.Size = new Size(173, 27);
            txttenbao.TabIndex = 17;
            // 
            // lblmadichvu
            // 
            lblmadichvu.AutoSize = true;
            lblmadichvu.Location = new Point(42, 98);
            lblmadichvu.Name = "lblmadichvu";
            lblmadichvu.Size = new Size(84, 20);
            lblmadichvu.TabIndex = 16;
            lblmadichvu.Text = "Mã dịch vụ:";
            // 
            // lblmabao
            // 
            lblmabao.AutoSize = true;
            lblmabao.Location = new Point(42, 47);
            lblmabao.Name = "lblmabao";
            lblmabao.Size = new Size(63, 20);
            lblmabao.TabIndex = 15;
            lblmabao.Text = "Mã báo:";
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(902, 392);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(173, 27);
            txttongtien.TabIndex = 14;
            // 
            // lbltongtien
            // 
            lbltongtien.AutoSize = true;
            lbltongtien.Location = new Point(821, 395);
            lbltongtien.Name = "lbltongtien";
            lbltongtien.Size = new Size(75, 20);
            lbltongtien.TabIndex = 13;
            lbltongtien.Text = "Tổng tiền:";
            // 
            // btndong
            // 
            btndong.Location = new Point(1023, 456);
            btndong.Name = "btndong";
            btndong.Size = new Size(87, 29);
            btndong.TabIndex = 12;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            // 
            // btninhopdong
            // 
            btninhopdong.Location = new Point(881, 456);
            btninhopdong.Name = "btninhopdong";
            btninhopdong.Size = new Size(123, 29);
            btninhopdong.TabIndex = 11;
            btninhopdong.Text = "In hợp đồng";
            btninhopdong.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(621, 456);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(87, 29);
            btnsua.TabIndex = 10;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            // 
            // bnthuyhopdong
            // 
            bnthuyhopdong.Location = new Point(732, 456);
            bnthuyhopdong.Name = "bnthuyhopdong";
            bnthuyhopdong.Size = new Size(123, 29);
            bnthuyhopdong.TabIndex = 9;
            bnthuyhopdong.Text = "Hủy hợp đồng";
            bnthuyhopdong.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(513, 456);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(87, 29);
            btnluu.TabIndex = 8;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            // 
            // btnthemhopdong
            // 
            btnthemhopdong.Location = new Point(368, 456);
            btnthemhopdong.Name = "btnthemhopdong";
            btnthemhopdong.Size = new Size(123, 29);
            btnthemhopdong.TabIndex = 7;
            btnthemhopdong.Text = "Thêm hợp đồng";
            btnthemhopdong.UseVisualStyleBackColor = true;
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(42, 189);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(1033, 188);
            DataGridView.TabIndex = 6;
            // 
            // lbltenbao
            // 
            lbltenbao.AutoSize = true;
            lbltenbao.Location = new Point(249, 47);
            lbltenbao.Name = "lbltenbao";
            lbltenbao.Size = new Size(65, 20);
            lbltenbao.TabIndex = 5;
            lbltenbao.Text = "Tên báo:";
            // 
            // lbldongia
            // 
            lbldongia.AutoSize = true;
            lbldongia.Location = new Point(836, 47);
            lbldongia.Name = "lbldongia";
            lbldongia.Size = new Size(65, 20);
            lbldongia.TabIndex = 4;
            lbldongia.Text = "Đơn giá:";
            // 
            // lblngaykt
            // 
            lblngaykt.AutoSize = true;
            lblngaykt.Location = new Point(530, 98);
            lblngaykt.Name = "lblngaykt";
            lblngaykt.Size = new Size(103, 20);
            lblngaykt.TabIndex = 3;
            lblngaykt.Text = "Ngày kết thúc:";
            // 
            // lblngaybd
            // 
            lblngaybd.AutoSize = true;
            lblngaybd.Location = new Point(531, 47);
            lblngaybd.Name = "lblngaybd";
            lblngaybd.Size = new Size(102, 20);
            lblngaybd.TabIndex = 2;
            lblngaybd.Text = "Ngày bắt đầu:";
            // 
            // lblthanhtien
            // 
            lblthanhtien.AutoSize = true;
            lblthanhtien.Location = new Point(836, 98);
            lblthanhtien.Name = "lblthanhtien";
            lblthanhtien.Size = new Size(81, 20);
            lblthanhtien.TabIndex = 1;
            lblthanhtien.Text = "Thành tiền:";
            // 
            // lbldichvu
            // 
            lbldichvu.AutoSize = true;
            lbldichvu.Location = new Point(249, 98);
            lbldichvu.Name = "lbldichvu";
            lbldichvu.Size = new Size(61, 20);
            lbldichvu.TabIndex = 0;
            lbldichvu.Text = "Dịch vụ:";
            // 
            // cbotkmaqc
            // 
            cbotkmaqc.FormattingEnabled = true;
            cbotkmaqc.Location = new Point(140, 794);
            cbotkmaqc.Name = "cbotkmaqc";
            cbotkmaqc.Size = new Size(151, 28);
            cbotkmaqc.TabIndex = 3;
            // 
            // lblmaqc2
            // 
            lblmaqc2.AutoSize = true;
            lblmaqc2.Location = new Point(27, 797);
            lblmaqc2.Name = "lblmaqc2";
            lblmaqc2.Size = new Size(107, 20);
            lblmaqc2.TabIndex = 8;
            lblmaqc2.Text = "Mã quảng cáo:";
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(331, 794);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(87, 29);
            btntimkiem.TabIndex = 15;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            // 
            // txtmaqc
            // 
            txtmaqc.Location = new Point(187, 34);
            txtmaqc.Name = "txtmaqc";
            txtmaqc.Size = new Size(255, 27);
            txtmaqc.TabIndex = 24;
            // 
            // txttennv
            // 
            txttennv.Location = new Point(187, 153);
            txttennv.Name = "txttennv";
            txttennv.Size = new Size(255, 27);
            txttennv.TabIndex = 27;
            // 
            // txttenkh
            // 
            txttenkh.Location = new Point(639, 73);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(255, 27);
            txttenkh.TabIndex = 29;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(639, 113);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(255, 27);
            txtdiachi.TabIndex = 30;
            // 
            // mskngayky
            // 
            mskngayky.Location = new Point(187, 73);
            mskngayky.Mask = "00/00/0000";
            mskngayky.Name = "mskngayky";
            mskngayky.Size = new Size(255, 27);
            mskngayky.TabIndex = 24;
            mskngayky.ValidatingType = typeof(DateTime);
            // 
            // mskdienthoai
            // 
            mskdienthoai.Location = new Point(639, 153);
            mskdienthoai.Mask = "(999) 000-0000";
            mskdienthoai.Name = "mskdienthoai";
            mskdienthoai.Size = new Size(255, 27);
            mskdienthoai.TabIndex = 31;
            // 
            // cbomanv
            // 
            cbomanv.FormattingEnabled = true;
            cbomanv.Location = new Point(187, 113);
            cbomanv.Name = "cbomanv";
            cbomanv.Size = new Size(255, 28);
            cbomanv.TabIndex = 24;
            // 
            // cbomakh
            // 
            cbomakh.FormattingEnabled = true;
            cbomakh.Location = new Point(639, 34);
            cbomakh.Name = "cbomakh";
            cbomakh.Size = new Size(255, 28);
            cbomakh.TabIndex = 32;
            // 
            // lblnoidung
            // 
            lblnoidung.AutoSize = true;
            lblnoidung.Location = new Point(42, 145);
            lblnoidung.Name = "lblnoidung";
            lblnoidung.Size = new Size(74, 20);
            lblnoidung.TabIndex = 24;
            lblnoidung.Text = "Nội dung:";
            // 
            // txtnoidung
            // 
            txtnoidung.Location = new Point(132, 133);
            txtnoidung.Multiline = true;
            txtnoidung.Name = "txtnoidung";
            txtnoidung.Size = new Size(943, 44);
            txtnoidung.TabIndex = 25;
            // 
            // frmhopdongquangcao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 834);
            Controls.Add(btntimkiem);
            Controls.Add(lblmaqc2);
            Controls.Add(cbotkmaqc);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblHDQC);
            Name = "frmhopdongquangcao";
            Text = "Hợp đồng Quảng cáo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHDQC;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lbldienthoai;
        private Label lbldiachi;
        private Label lbltennv;
        private Label lblmanv;
        private Label lbltenkh;
        private Label lblmakh;
        private Label lblngayky;
        private Label lblmaquangcao;
        private Label lbldichvu;
        private Label lbltenbao;
        private Label lbldongia;
        private Label lblngaykt;
        private Label lblngaybd;
        private Label lblthanhtien;
        private Button btnthemhopdong;
        private DataGridView DataGridView;
        private Button bnthuyhopdong;
        private Button btnluu;
        private Button btndong;
        private Button btninhopdong;
        private Button btnsua;
        private Label lbltongtien;
        private TextBox txttongtien;
        private ComboBox cbotkmaqc;
        private Label lblmaqc2;
        private Button btntimkiem;
        private Label lblmadichvu;
        private Label lblmabao;
        private TextBox txtthanhtien;
        private TextBox txtdongia;
        private TextBox txttendv;
        private TextBox txttenbao;
        private ComboBox cbomadv;
        private MaskedTextBox mskngaykt;
        private MaskedTextBox mskngaybd;
        private ComboBox cbomabao;
        private ComboBox cbomakh;
        private ComboBox cbomanv;
        private MaskedTextBox mskdienthoai;
        private MaskedTextBox mskngayky;
        private TextBox txtdiachi;
        private TextBox txttenkh;
        private TextBox txttennv;
        private TextBox txtmaqc;
        private TextBox txtnoidung;
        private Label lblnoidung;
    }
}