namespace QLHD_QC_VB.Forms
{
    partial class frmhopdongvietbai
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
            groupBox1 = new GroupBox();
            cbomakh = new ComboBox();
            cbomanv = new ComboBox();
            mskdienthoai = new MaskedTextBox();
            mskngayky = new MaskedTextBox();
            txtdiachi = new TextBox();
            txttenkh = new TextBox();
            txttennv = new TextBox();
            txtmavb = new TextBox();
            lbldienthoai = new Label();
            lbldiachi = new Label();
            lbltennv = new Label();
            lblmanv = new Label();
            lbltenkh = new Label();
            lblmakh = new Label();
            lblngayky = new Label();
            lblmavb = new Label();
            lblHDVB = new Label();
            btntimkiem = new Button();
            lblmavbtk = new Label();
            txtnoidung = new TextBox();
            txttieude = new TextBox();
            txttongtien = new TextBox();
            lbltongtien = new Label();
            btndong = new Button();
            btninhopdong = new Button();
            btnsua = new Button();
            bnthuyhopdong = new Button();
            btnluu = new Button();
            btnthemhopdong = new Button();
            DataGridView = new DataGridView();
            cbotkmavb = new ComboBox();
            groupBox2 = new GroupBox();
            lblnoidung = new Label();
            mskngaydang = new MaskedTextBox();
            cbomabao = new ComboBox();
            cbomatheloai = new ComboBox();
            txtnhuanbut = new TextBox();
            txttheloai = new TextBox();
            txttenbao = new TextBox();
            lblmatheloai = new Label();
            lblmabao = new Label();
            lbltenbao = new Label();
            lblnhuanbut = new Label();
            lblngaydang = new Label();
            lbltheloai = new Label();
            lbltieude = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            groupBox1.Controls.Add(txtmavb);
            groupBox1.Controls.Add(lbldienthoai);
            groupBox1.Controls.Add(lbldiachi);
            groupBox1.Controls.Add(lbltennv);
            groupBox1.Controls.Add(lblmanv);
            groupBox1.Controls.Add(lbltenkh);
            groupBox1.Controls.Add(lblmakh);
            groupBox1.Controls.Add(lblngayky);
            groupBox1.Controls.Add(lblmavb);
            groupBox1.Location = new Point(81, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(993, 204);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // cbomakh
            // 
            cbomakh.FormattingEnabled = true;
            cbomakh.Location = new Point(639, 34);
            cbomakh.Name = "cbomakh";
            cbomakh.Size = new Size(255, 28);
            cbomakh.TabIndex = 32;
            // 
            // cbomanv
            // 
            cbomanv.FormattingEnabled = true;
            cbomanv.Location = new Point(187, 113);
            cbomanv.Name = "cbomanv";
            cbomanv.Size = new Size(255, 28);
            cbomanv.TabIndex = 24;
            // 
            // mskdienthoai
            // 
            mskdienthoai.Location = new Point(639, 153);
            mskdienthoai.Mask = "(999) 000-0000";
            mskdienthoai.Name = "mskdienthoai";
            mskdienthoai.Size = new Size(255, 27);
            mskdienthoai.TabIndex = 31;
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
            // txtdiachi
            // 
            txtdiachi.Location = new Point(639, 113);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(255, 27);
            txtdiachi.TabIndex = 30;
            // 
            // txttenkh
            // 
            txttenkh.Location = new Point(639, 73);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(255, 27);
            txttenkh.TabIndex = 29;
            // 
            // txttennv
            // 
            txttennv.Location = new Point(187, 153);
            txttennv.Name = "txttennv";
            txttennv.Size = new Size(255, 27);
            txttennv.TabIndex = 27;
            // 
            // txtmavb
            // 
            txtmavb.Location = new Point(187, 34);
            txtmavb.Name = "txtmavb";
            txtmavb.Size = new Size(255, 27);
            txtmavb.TabIndex = 24;
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
            // lblmavb
            // 
            lblmavb.AutoSize = true;
            lblmavb.Location = new Point(74, 37);
            lblmavb.Name = "lblmavb";
            lblmavb.Size = new Size(86, 20);
            lblmavb.TabIndex = 0;
            lblmavb.Text = "Mã viết bài:";
            // 
            // lblHDVB
            // 
            lblHDVB.AutoSize = true;
            lblHDVB.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHDVB.Location = new Point(439, 9);
            lblHDVB.Name = "lblHDVB";
            lblHDVB.Size = new Size(275, 38);
            lblHDVB.TabIndex = 2;
            lblHDVB.Text = "HỢP ĐỒNG VIẾT BÀI";
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(327, 792);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(87, 29);
            btntimkiem.TabIndex = 19;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            // 
            // lblmavbtk
            // 
            lblmavbtk.AutoSize = true;
            lblmavbtk.Location = new Point(39, 795);
            lblmavbtk.Name = "lblmavbtk";
            lblmavbtk.Size = new Size(86, 20);
            lblmavbtk.TabIndex = 18;
            lblmavbtk.Text = "Mã viết bài:";
            // 
            // txtnoidung
            // 
            txtnoidung.Location = new Point(132, 133);
            txtnoidung.Multiline = true;
            txtnoidung.Name = "txtnoidung";
            txtnoidung.Size = new Size(943, 44);
            txtnoidung.TabIndex = 25;
            // 
            // txttieude
            // 
            txttieude.Location = new Point(639, 95);
            txttieude.Name = "txttieude";
            txttieude.Size = new Size(436, 27);
            txttieude.TabIndex = 20;
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
            // cbotkmavb
            // 
            cbotkmavb.FormattingEnabled = true;
            cbotkmavb.Location = new Point(152, 792);
            cbotkmavb.Name = "cbotkmavb";
            cbotkmavb.Size = new Size(151, 28);
            cbotkmavb.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtnoidung);
            groupBox2.Controls.Add(lblnoidung);
            groupBox2.Controls.Add(mskngaydang);
            groupBox2.Controls.Add(cbomabao);
            groupBox2.Controls.Add(cbomatheloai);
            groupBox2.Controls.Add(txttieude);
            groupBox2.Controls.Add(txtnhuanbut);
            groupBox2.Controls.Add(txttheloai);
            groupBox2.Controls.Add(txttenbao);
            groupBox2.Controls.Add(lblmatheloai);
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
            groupBox2.Controls.Add(lblnhuanbut);
            groupBox2.Controls.Add(lbltieude);
            groupBox2.Controls.Add(lblngaydang);
            groupBox2.Controls.Add(lbltheloai);
            groupBox2.Location = new Point(37, 286);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1116, 491);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết";
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
            // mskngaydang
            // 
            mskngaydang.Location = new Point(639, 44);
            mskngaydang.Mask = "00/00/0000";
            mskngaydang.Name = "mskngaydang";
            mskngaydang.Size = new Size(149, 27);
            mskngaydang.TabIndex = 22;
            mskngaydang.ValidatingType = typeof(DateTime);
            // 
            // cbomabao
            // 
            cbomabao.FormattingEnabled = true;
            cbomabao.Location = new Point(132, 44);
            cbomabao.Name = "cbomabao";
            cbomabao.Size = new Size(100, 28);
            cbomabao.TabIndex = 21;
            // 
            // cbomatheloai
            // 
            cbomatheloai.FormattingEnabled = true;
            cbomatheloai.Location = new Point(132, 95);
            cbomatheloai.Name = "cbomatheloai";
            cbomatheloai.Size = new Size(100, 28);
            cbomatheloai.TabIndex = 16;
            // 
            // txtnhuanbut
            // 
            txtnhuanbut.Location = new Point(923, 44);
            txtnhuanbut.Name = "txtnhuanbut";
            txtnhuanbut.Size = new Size(152, 27);
            txtnhuanbut.TabIndex = 19;
            // 
            // txttheloai
            // 
            txttheloai.Location = new Point(320, 95);
            txttheloai.Name = "txttheloai";
            txttheloai.Size = new Size(173, 27);
            txttheloai.TabIndex = 18;
            // 
            // txttenbao
            // 
            txttenbao.Location = new Point(320, 44);
            txttenbao.Name = "txttenbao";
            txttenbao.Size = new Size(173, 27);
            txttenbao.TabIndex = 17;
            // 
            // lblmatheloai
            // 
            lblmatheloai.AutoSize = true;
            lblmatheloai.Location = new Point(42, 98);
            lblmatheloai.Name = "lblmatheloai";
            lblmatheloai.Size = new Size(87, 20);
            lblmatheloai.TabIndex = 16;
            lblmatheloai.Text = "Mã thể loại:";
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
            // lbltenbao
            // 
            lbltenbao.AutoSize = true;
            lbltenbao.Location = new Point(249, 47);
            lbltenbao.Name = "lbltenbao";
            lbltenbao.Size = new Size(65, 20);
            lbltenbao.TabIndex = 5;
            lbltenbao.Text = "Tên báo:";
            // 
            // lblnhuanbut
            // 
            lblnhuanbut.AutoSize = true;
            lblnhuanbut.Location = new Point(836, 47);
            lblnhuanbut.Name = "lblnhuanbut";
            lblnhuanbut.Size = new Size(81, 20);
            lblnhuanbut.TabIndex = 4;
            lblnhuanbut.Text = "Nhuận bút:";
            // 
            // lblngaydang
            // 
            lblngaydang.AutoSize = true;
            lblngaydang.Location = new Point(531, 47);
            lblngaydang.Name = "lblngaydang";
            lblngaydang.Size = new Size(85, 20);
            lblngaydang.TabIndex = 2;
            lblngaydang.Text = "Ngày đăng:";
            // 
            // lbltheloai
            // 
            lbltheloai.AutoSize = true;
            lbltheloai.Location = new Point(249, 98);
            lbltheloai.Name = "lbltheloai";
            lbltheloai.Size = new Size(65, 20);
            lbltheloai.TabIndex = 0;
            lbltheloai.Text = "Thể loại:";
            // 
            // lbltieude
            // 
            lbltieude.AutoSize = true;
            lbltieude.Location = new Point(530, 98);
            lbltieude.Name = "lbltieude";
            lbltieude.Size = new Size(61, 20);
            lbltieude.TabIndex = 3;
            lbltieude.Text = "Tiêu đề:";
            // 
            // frmhopdongvietbai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 833);
            Controls.Add(btntimkiem);
            Controls.Add(lblmavbtk);
            Controls.Add(cbotkmavb);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblHDVB);
            Name = "frmhopdongvietbai";
            Text = "Hợp đồng Viết bài";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbomakh;
        private ComboBox cbomanv;
        private MaskedTextBox mskdienthoai;
        private MaskedTextBox mskngayky;
        private TextBox txtdiachi;
        private TextBox txttenkh;
        private TextBox txttennv;
        private TextBox txtmavb;
        private Label lbldienthoai;
        private Label lbldiachi;
        private Label lbltennv;
        private Label lblmanv;
        private Label lbltenkh;
        private Label lblmakh;
        private Label lblngayky;
        private Label lblmavb;
        private Label lblHDVB;
        private Button btntimkiem;
        private Label lblmavbtk;
        private TextBox txtnoidung;
        private TextBox txttieude;
        private TextBox txttongtien;
        private Label lbltongtien;
        private Button btndong;
        private Button btninhopdong;
        private Button btnsua;
        private Button bnthuyhopdong;
        private Button btnluu;
        private Button btnthemhopdong;
        private DataGridView DataGridView;
        private ComboBox cbotkmavb;
        private GroupBox groupBox2;
        private Label lblnoidung;
        private MaskedTextBox mskngaydang;
        private ComboBox cbomabao;
        private ComboBox cbomatheloai;
        private TextBox txtnhuanbut;
        private TextBox txttheloai;
        private TextBox txttenbao;
        private Label lblmatheloai;
        private Label lblmabao;
        private Label lbltenbao;
        private Label lblnhuanbut;
        private Label lblngaydang;
        private Label lbltheloai;
        private Label lbltieude;
    }
}