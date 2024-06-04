using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLHD_QC_VB.Forms
{
    public partial class frmTimkiem : Form
    {
        public frmTimkiem()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadComboBox()
        {
            string sql = "SELECT DISTINCT linhvuchoatdong FROM linhvuchoatdong"; // DISTINCT để đảm bảo rằng các Mã loại không được lặp lại
            DataTable tblLVHD = Class.Functions.GetDataToTable(sql);

            if (tblLVHD.Rows.Count > 0)
            {
                cboLVHD.DataSource = tblLVHD;
                cboLVHD.DisplayMember = "linhvuchoatdong";
                cboLVHD.ValueMember = "linhvuchoatdong";
            }
            else
            {
                cboLVHD.DataSource = null; // Trong trường hợp không có dữ liệu, đặt DataSource của ComboBox thành null
            }
        }

        private void frmTimkiem_Load(object sender, EventArgs e)
        {
            LoadComboBox();

        }
        private void resetvalue()
        {
            cboLVHD = null;
            txtDiaChi.Text = string.Empty;
            txtMaKH.Text = string.Empty;
            txtTenKH.Text = string.Empty;
        }
        DataTable tblcl;
        //private void load_datagrid()
        //{
        //    string sql;
        //    sql = "SELECT kh.makh, kh.tenkh, kh.diachi,kh.dienthoai, kh.email,COUNT(qc.makh) AS solanky,MAX(qc.ngayky) AS ngaykygannhat,SUM(qc.tongtien) AS tongtien " +
        //        "FROM khachhang kh LEFT JOIN quangcao qc ON kh.makh = qc.makh GROUP BY kh.makh, kh.tenkh, kh.diachi, kh.dienthoai, kh.email ";
        //    tblcl = Class.Functions.GetDataToTable(sql);
        //    dataGridView1.DataSource = tblcl;
        //    dataGridView1.Columns[0].HeaderText = "Mã khách hàng";
        //    dataGridView1.Columns[1].HeaderText = "Tên khách hàng";
        //    dataGridView1.Columns[2].HeaderText = "Địa chỉ";
        //    dataGridView1.Columns[3].HeaderText = "Điện thoại";
        //    dataGridView1.Columns[4].HeaderText = "Email";
        //    dataGridView1.Columns[5].HeaderText = "Số lần ký";
        //    dataGridView1.Columns[6].HeaderText = "Ngày ký gần nhất";
        //    dataGridView1.Columns[7].HeaderText = "Tổng tiền";
        //    dataGridView1.AllowUserToAddRows = false;
        //    dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        //}
        private void CheckSearchButton(object sender, EventArgs e)
        {
            // Kiểm tra nếu tất cả các điều khiển đầu vào đều trống
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) &&
                string.IsNullOrWhiteSpace(txtTenKH.Text) &&
                string.IsNullOrWhiteSpace(txtDiaChi.Text) &&
                (cboLVHD.SelectedIndex == -1 || cboLVHD.SelectedValue == null))
            {
                // Ẩn nút Tìm kiếm nếu tất cả điều kiện đều trống
                btnTimKiem.Visible = false;
            }
            else
            {
                // Hiển thị nút Tìm kiếm nếu có ít nhất một điều kiện không trống
                btnTimKiem.Visible = true;
            }
        }
        private void load_datagrid()
        {
            // Lấy giá trị từ các điều khiển đầu vào
            string maKH = txtMaKH.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string maLVHD = cboLVHD.Text.Trim(); // assuming that the ComboBox has been set up with a ValueMember

            // Xây dựng câu truy vấn SQL động
            string sql = "SELECT kh.makh, kh.tenkh, kh.diachi, kh.dienthoai, kh.email, " +
                         "COUNT(qc.makh) AS solanky, MAX(qc.ngayky) AS ngaykygannhat, SUM(qc.tongtien) AS tongtien " +
                         "FROM khachhang kh " +
                         "LEFT JOIN quangcao qc ON kh.makh = qc.makh " +
                         "INNER JOIN linhvuchoatdong lvhd ON kh.malvhd = lvhd.malvhd " +
                         "WHERE 1=1";

            if (!string.IsNullOrEmpty(maKH))
            {
                sql += " AND kh.makh = N'" + maKH + "'";
            }
            if (!string.IsNullOrEmpty(tenKH))
            {
                sql += " AND kh.tenkh LIKE N'%" + tenKH + "%'";
            }
            if (!string.IsNullOrEmpty(diaChi))
            {
                sql += " AND kh.diachi = N'" + diaChi + "'";
            }
            if (!string.IsNullOrEmpty(maLVHD))
            {
                sql += " AND lvhd.linhvuchoatdong = N'" + maLVHD + "'";
            }

            sql += " GROUP BY kh.makh, kh.tenkh, kh.diachi, kh.dienthoai, kh.email";

            // Gọi phương thức GetDataToTable để lấy dữ liệu
            tblcl = Class.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblcl;

            // Thiết lập các cột của DataGridView
            dataGridView1.Columns[0].HeaderText = "Mã khách hàng";
            dataGridView1.Columns[1].HeaderText = "Tên khách hàng";
            dataGridView1.Columns[2].HeaderText = "Địa chỉ";
            dataGridView1.Columns[3].HeaderText = "Điện thoại";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Số lần ký";
            dataGridView1.Columns[6].HeaderText = "Ngày ký gần nhất";
            dataGridView1.Columns[7].HeaderText = "Tổng tiền";

            // Thiết lập chế độ của DataGridView
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btnTimLai_Click(object sender, EventArgs e)
        {
            resetvalue();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) &&
                string.IsNullOrWhiteSpace(txtTenKH.Text) &&
                string.IsNullOrWhiteSpace(txtDiaChi.Text) &&
                (cboLVHD.SelectedIndex == -1 || cboLVHD.SelectedValue == null))
            {
                // Hiển thị thông báo cảnh báo
                MessageBox.Show("Vui lòng nhập ít nhất một điều kiện tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Gọi phương thức load_datagrid() để tải dữ liệu
                load_datagrid();
            }
        }
    }
}
