using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHD_QC_VB.Forms
{
    public partial class frmbao : Form
    {
        DataTable tblbao;
        public frmbao()
        {
            InitializeComponent();
        }
        private void resetvalues()
        {
            txtmabao.Text = "";
            txttenbao.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
            mskdienthoai.Text = "";
        }

        private void frmbao_Load(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = false;
            btnlammoi.Enabled = false;
            load_data();
        }
        private void load_data()
        {
            string sql;
            sql = "select mabao, tenbao, diachi, sdt, email from bao";
            tblbao = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblbao;
            DataGridView.Columns[0].HeaderText = "Mã báo";
            DataGridView.Columns[1].HeaderText = "Tên báo";
            DataGridView.Columns[2].HeaderText = "Địa chỉ";
            DataGridView.Columns[3].HeaderText = "Số điện thoại";
            DataGridView.Columns[4].HeaderText = "Email";
            DataGridView.Columns[0].Width = 75;
            DataGridView.Columns[1].Width = 150;
            DataGridView.Columns[2].Width = 400;
            DataGridView.Columns[3].Width = 100;
            DataGridView.Columns[4].Width = 150;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            resetvalues();
            btnthemmoi.Enabled = false;
            txtmabao.Focus();
            btnlammoi.Enabled = true;
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            btnlammoi.Enabled = false;
            resetvalues();
            btnthemmoi.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthemmoi.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmabao.Focus();
                return;
            }
            if(tblbao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu tồn tại trong bảng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            txtmabao.Text = DataGridView.CurrentRow.Cells["mabao"].Value.ToString();
            txttenbao.Text = DataGridView.CurrentRow.Cells["tenbao"].Value.ToString();
            txtdiachi.Text = DataGridView.CurrentRow.Cells["diachi"].Value.ToString();
            txtemail.Text = DataGridView.CurrentRow.Cells["email"].Value.ToString();
            mskdienthoai.Text = DataGridView.CurrentRow.Cells["sdt"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnlammoi.Enabled = true;
        }
    }
}
