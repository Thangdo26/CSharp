namespace QLHD_QC_VB.Forms
{
    partial class frmtimkiemhd
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
            lbltkhd = new Label();
            lblmahd = new Label();
            lblmanv = new Label();
            lbltungay = new Label();
            lbltoingay = new Label();
            lblgiatri = new Label();
            lblmakh = new Label();
            lblloaihd = new Label();
            txtmahd = new TextBox();
            txtmakh = new TextBox();
            txtmanv = new TextBox();
            msktungay = new MaskedTextBox();
            msktoingay = new MaskedTextBox();
            txtgiatri = new TextBox();
            DataGridView = new DataGridView();
            btntimkiem = new Button();
            btntimlai = new Button();
            btndong = new Button();
            cboloaihd = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbltkhd
            // 
            lbltkhd.Anchor = AnchorStyles.Top;
            lbltkhd.AutoSize = true;
            lbltkhd.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltkhd.Location = new Point(402, 11);
            lbltkhd.Margin = new Padding(4, 0, 4, 0);
            lbltkhd.Name = "lbltkhd";
            lbltkhd.Size = new Size(337, 45);
            lbltkhd.TabIndex = 0;
            lbltkhd.Text = "TÌM KIẾM HỢP ĐỒNG";
            // 
            // lblmahd
            // 
            lblmahd.Anchor = AnchorStyles.Top;
            lblmahd.AutoSize = true;
            lblmahd.Location = new Point(32, 78);
            lblmahd.Margin = new Padding(4, 0, 4, 0);
            lblmahd.Name = "lblmahd";
            lblmahd.Size = new Size(126, 25);
            lblmahd.TabIndex = 1;
            lblmahd.Text = "Mã hợp đồng:";
            // 
            // lblmanv
            // 
            lblmanv.Anchor = AnchorStyles.Top;
            lblmanv.AutoSize = true;
            lblmanv.Location = new Point(812, 78);
            lblmanv.Margin = new Padding(4, 0, 4, 0);
            lblmanv.Name = "lblmanv";
            lblmanv.Size = new Size(122, 25);
            lblmanv.TabIndex = 2;
            lblmanv.Text = "Mã nhân viên:";
            // 
            // lbltungay
            // 
            lbltungay.Anchor = AnchorStyles.Top;
            lbltungay.AutoSize = true;
            lbltungay.Location = new Point(102, 146);
            lbltungay.Margin = new Padding(4, 0, 4, 0);
            lbltungay.Name = "lbltungay";
            lbltungay.Size = new Size(80, 25);
            lbltungay.TabIndex = 3;
            lbltungay.Text = "Từ ngày:";
            // 
            // lbltoingay
            // 
            lbltoingay.Anchor = AnchorStyles.Top;
            lbltoingay.AutoSize = true;
            lbltoingay.Location = new Point(355, 146);
            lbltoingay.Margin = new Padding(4, 0, 4, 0);
            lbltoingay.Name = "lbltoingay";
            lbltoingay.Size = new Size(84, 25);
            lbltoingay.TabIndex = 4;
            lbltoingay.Text = "Tới ngày:";
            // 
            // lblgiatri
            // 
            lblgiatri.Anchor = AnchorStyles.Top;
            lblgiatri.AutoSize = true;
            lblgiatri.Location = new Point(612, 146);
            lblgiatri.Margin = new Padding(4, 0, 4, 0);
            lblgiatri.Name = "lblgiatri";
            lblgiatri.Size = new Size(62, 25);
            lblgiatri.TabIndex = 5;
            lblgiatri.Text = "Giá trị:";
            // 
            // lblmakh
            // 
            lblmakh.Anchor = AnchorStyles.Top;
            lblmakh.AutoSize = true;
            lblmakh.Location = new Point(416, 78);
            lblmakh.Margin = new Padding(4, 0, 4, 0);
            lblmakh.Name = "lblmakh";
            lblmakh.Size = new Size(137, 25);
            lblmakh.TabIndex = 6;
            lblmakh.Text = "Mã khách hàng:";
            // 
            // lblloaihd
            // 
            lblloaihd.Anchor = AnchorStyles.Top;
            lblloaihd.AutoSize = true;
            lblloaihd.Location = new Point(849, 146);
            lblloaihd.Margin = new Padding(4, 0, 4, 0);
            lblloaihd.Name = "lblloaihd";
            lblloaihd.Size = new Size(133, 25);
            lblloaihd.TabIndex = 7;
            lblloaihd.Text = "Loại hợp đồng:";
            // 
            // txtmahd
            // 
            txtmahd.Anchor = AnchorStyles.Top;
            txtmahd.Location = new Point(168, 74);
            txtmahd.Margin = new Padding(4);
            txtmahd.Name = "txtmahd";
            txtmahd.Size = new Size(240, 31);
            txtmahd.TabIndex = 8;
            // 
            // txtmakh
            // 
            txtmakh.Anchor = AnchorStyles.Top;
            txtmakh.Location = new Point(564, 74);
            txtmakh.Margin = new Padding(4);
            txtmakh.Name = "txtmakh";
            txtmakh.Size = new Size(240, 31);
            txtmakh.TabIndex = 9;
            // 
            // txtmanv
            // 
            txtmanv.Anchor = AnchorStyles.Top;
            txtmanv.Location = new Point(945, 74);
            txtmanv.Margin = new Padding(4);
            txtmanv.Name = "txtmanv";
            txtmanv.Size = new Size(240, 31);
            txtmanv.TabIndex = 10;
            // 
            // msktungay
            // 
            msktungay.Anchor = AnchorStyles.Top;
            msktungay.Location = new Point(191, 142);
            msktungay.Margin = new Padding(4);
            msktungay.Mask = "00/00/0000";
            msktungay.Name = "msktungay";
            msktungay.Size = new Size(155, 31);
            msktungay.TabIndex = 11;
            msktungay.ValidatingType = typeof(DateTime);
            msktungay.MaskInputRejected += msktungay_MaskInputRejected;
            msktungay.Enter += msktungay_Enter;
            msktungay.Leave += msktungay_Leave;
            // 
            // msktoingay
            // 
            msktoingay.Anchor = AnchorStyles.Top;
            msktoingay.Location = new Point(449, 142);
            msktoingay.Margin = new Padding(4);
            msktoingay.Mask = "00/00/0000";
            msktoingay.Name = "msktoingay";
            msktoingay.Size = new Size(155, 31);
            msktoingay.TabIndex = 12;
            msktoingay.ValidatingType = typeof(DateTime);
            msktoingay.MaskInputRejected += msktoingay_MaskInputRejected;
            msktoingay.MouseClick += msktoingay_MouseClick;
            // 
            // txtgiatri
            // 
            txtgiatri.Anchor = AnchorStyles.Top;
            txtgiatri.Location = new Point(685, 142);
            txtgiatri.Margin = new Padding(4);
            txtgiatri.Name = "txtgiatri";
            txtgiatri.Size = new Size(155, 31);
            txtgiatri.TabIndex = 13;
            txtgiatri.TextChanged += txtgiatri_TextChanged;
            txtgiatri.KeyPress += txtgiatri_KeyPress;
            // 
            // DataGridView
            // 
            DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(182, 221);
            DataGridView.Margin = new Padding(4);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(856, 251);
            DataGridView.TabIndex = 15;
            // 
            // btntimkiem
            // 
            btntimkiem.Anchor = AnchorStyles.Bottom;
            btntimkiem.Location = new Point(308, 498);
            btntimkiem.Margin = new Padding(4);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(118, 36);
            btntimkiem.TabIndex = 16;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // btntimlai
            // 
            btntimlai.Anchor = AnchorStyles.Bottom;
            btntimlai.Location = new Point(552, 498);
            btntimlai.Margin = new Padding(4);
            btntimlai.Name = "btntimlai";
            btntimlai.Size = new Size(118, 36);
            btntimlai.TabIndex = 17;
            btntimlai.Text = "Tìm lại";
            btntimlai.UseVisualStyleBackColor = true;
            btntimlai.Click += btntimlai_Click;
            // 
            // btndong
            // 
            btndong.Anchor = AnchorStyles.Bottom;
            btndong.Location = new Point(795, 498);
            btndong.Margin = new Padding(4);
            btndong.Name = "btndong";
            btndong.Size = new Size(118, 36);
            btndong.TabIndex = 18;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            btndong.Click += btndong_Click;
            // 
            // cboloaihd
            // 
            cboloaihd.Anchor = AnchorStyles.Top;
            cboloaihd.FormattingEnabled = true;
            cboloaihd.Location = new Point(992, 142);
            cboloaihd.Margin = new Padding(4);
            cboloaihd.Name = "cboloaihd";
            cboloaihd.Size = new Size(102, 33);
            cboloaihd.TabIndex = 19;
            cboloaihd.SelectedIndexChanged += cboloaihd_SelectedIndexChanged;
            // 
            // frmtimkiemhd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 560);
            Controls.Add(cboloaihd);
            Controls.Add(btndong);
            Controls.Add(btntimlai);
            Controls.Add(btntimkiem);
            Controls.Add(DataGridView);
            Controls.Add(txtgiatri);
            Controls.Add(msktoingay);
            Controls.Add(msktungay);
            Controls.Add(txtmanv);
            Controls.Add(txtmakh);
            Controls.Add(txtmahd);
            Controls.Add(lblloaihd);
            Controls.Add(lblmakh);
            Controls.Add(lblgiatri);
            Controls.Add(lbltoingay);
            Controls.Add(lbltungay);
            Controls.Add(lblmanv);
            Controls.Add(lblmahd);
            Controls.Add(lbltkhd);
            Margin = new Padding(4);
            Name = "frmtimkiemhd";
            Text = "Tìm kiếm hợp đồng";
            Load += frmtimkiemhd_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltkhd;
        private Label lblmahd;
        private Label lblmanv;
        private Label lbltungay;
        private Label lbltoingay;
        private Label lblgiatri;
        private Label lblmakh;
        private Label lblloaihd;
        private TextBox txtmahd;
        private TextBox txtmakh;
        private TextBox txtmanv;
        private MaskedTextBox msktungay;
        private MaskedTextBox msktoingay;
        private TextBox txtgiatri;
        private DataGridView DataGridView;
        private Button btntimkiem;
        private Button btntimlai;
        private Button btndong;
        private ComboBox cboloaihd;
    }
}