using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolTip = System.Windows.Forms.ToolTip;


namespace QLHD_QC_VB.Forms
{
    public partial class frmtimkiemhd : Form
    {
        public frmtimkiemhd()
        {
            InitializeComponent();
        }
        DataTable tbltkhd;

        private void frmtimkiemhd_Load(object sender, EventArgs e)
        {
            resetvalues();
            msktungay.Mask = "00/00/0000";
            msktoingay.Mask = "00/00/0000";
            // Xử lý sự kiện khi nhập giá trị không hợp lệ
            msktoingay.MaskInputRejected += new MaskInputRejectedEventHandler(msktoingay_MaskInputRejected);
            msktungay.MaskInputRejected += new MaskInputRejectedEventHandler(msktungay_MaskInputRejected);
            DataGridView.DataSource = null;
            string tiento;
            tiento = "select distinct(SUBSTRING(mahd,1,2)) as tiento from (" +
                "select a.mavb as mahd,a.manv,a.makh,ngayky,coalesce(sum(nhuanbut),0) as tongtien " +
                "from vietbai a full join chitietvietbai b on a.mavb=b.mavb " +
                "group by a.mavb,a.manv,a.makh,ngayky " +
                "union " +
                "select a.maqc as mahd,manv,makh,ngayky,coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien " +
                "from quangcao a full join chitietquangcao b on a.maqc=b.maqc " +
                "group by a.maqc,manv,makh,ngayky) a";
            Class.Functions.Fillcombo(tiento, cboloaihd, "tiento", "tiento");
            cboloaihd.SelectedIndex = -1;
        }

        private void resetvalues()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
            txtmahd.Focus();
            msktungay.Text = "";
            msktoingay.Text = "";
            cboloaihd.SelectedIndex = -1;
            DataGridView.DataSource = null;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi nhập giá trị không hợp lệ
            if (!string.IsNullOrWhiteSpace(msktungay.Text))
            {
                if (DateTime.TryParseExact(msktungay.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime enteredDate))
                {
                    // Kiểm tra năm hợp lệ (từ 1990 đến năm hiện tại)
                    if (enteredDate.Year < 1990 || enteredDate.Year > DateTime.Now.Year)
                    {
                        ShowErrorMessage("Năm không hợp lệ (từ 1990 đến năm hiện tại)");
                        return;
                    }

                    // Kiểm tra tháng hợp lệ (từ 1 đến 12)
                    if (enteredDate.Month < 1 || enteredDate.Month > 12)
                    {
                        ShowErrorMessage("Tháng không hợp lệ (từ 1 đến 12)");
                        return;
                    }

                    // Kiểm tra ngày nhập vào phải nhỏ hơn hoặc bằng ngày hiện tại
                    if (enteredDate > DateTime.Now)
                    {
                        ShowErrorMessage("Ngày nhập vào phải nhỏ hơn hoặc bằng ngày hiện tại");
                        return;
                    }

                    // Nếu đến đây thì ngày hợp lệ, thực hiện công việc tiếp theo
                    // ...
                }
                else
                {
                    ShowErrorMessage("Ngày không hợp lệ, vui lòng nhập đúng định dạng dd/MM/yyyy");
                }
            }
            else
            {
                ShowErrorMessage("Vui lòng nhập ngày");
            }

            if (!string.IsNullOrWhiteSpace(msktoingay.Text))
            {
                if (DateTime.TryParseExact(msktoingay.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime enteredDate))
                {
                    // Kiểm tra năm hợp lệ (từ 1990 đến năm hiện tại)
                    if (enteredDate.Year < 1990 || enteredDate.Year > DateTime.Now.Year)
                    {
                        ShowErrorMessage1("Năm không hợp lệ (từ 1990 đến năm hiện tại)");
                        return;
                    }

                    // Kiểm tra tháng hợp lệ (từ 1 đến 12)
                    if (enteredDate.Month < 1 || enteredDate.Month > 12)
                    {
                        ShowErrorMessage1("Tháng không hợp lệ (từ 1 đến 12)");
                        return;
                    }

                    // Kiểm tra ngày nhập vào phải nhỏ hơn hoặc bằng ngày hiện tại
                    if (enteredDate > DateTime.Now)
                    {
                        ShowErrorMessage1("Ngày nhập vào phải nhỏ hơn hoặc bằng ngày hiện tại");
                        return;
                    }

                    // Nếu đến đây thì ngày hợp lệ, thực hiện công việc tiếp theo
                    // ...
                }
                else
                {
                    ShowErrorMessage1("Ngày không hợp lệ, vui lòng nhập đúng định dạng dd/MM/yyyy");
                }
            }
            else
            {
                ShowErrorMessage1("Vui lòng nhập ngày");
            }

            void ShowErrorMessage(string message)
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msktungay.Text = "";
            }
            void ShowErrorMessage1(string message)
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msktoingay.Text = "";
            }
            string sql;
            if ((txtmakh.Text == "") && (txtmahd.Text == "") && (txtmanv.Text == "") && (txtgiatri.Text == "")
                && (cboloaihd.SelectedValue == null) && (msktoingay.Text == "  /  /") && (msktungay.Text == "  /  /"))
            {
                MessageBox.Show("Hãy nhập ít nhất một điều kiện để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select * from (" +
                "select a.mavb as mahd,a.manv,a.makh,ngayky,coalesce(sum(nhuanbut),0) as tongtien " +
                "from vietbai a full join chitietvietbai b on a.mavb=b.mavb " +
                "group by a.mavb,a.manv,a.makh,ngayky " +
                "union " +
                "select a.maqc as mahd,manv,makh,ngayky,coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien " +
                "from quangcao a full join chitietquangcao b on a.maqc=b.maqc " +
                "group by a.maqc,manv,makh,ngayky) a where 1=1";
            if (txtmahd.Text != "")
            {
                sql = sql + " and mahd like N'%" + txtmahd.Text + "%'";
            }
            if (txtmanv.Text != "")
            {
                sql = sql + " and manv like N'%" + txtmanv.Text + "%'";
            }
            if (txtmakh.Text != "")
            {
                sql = sql + " and makh like N'%" + txtmakh.Text + "%'";
            }
            if (cboloaihd.SelectedValue != null)
            {
                sql = sql + " and SUBSTRING(mahd,1,2) ='" + cboloaihd.Text + "'";
            }
            if (msktungay.Text != "  /  /" && msktungay.Text.Length == 10 && msktungay.Text.IndexOf(' ') == -1)
            {
                sql = sql + " and ngayky >='" + Class.Functions.ConvertDate(msktungay.Text) + "'";
            }
            if (msktoingay.Text != "  /  /" && msktoingay.Text.Length == 10 && msktoingay.Text.IndexOf(' ') == -1)
            {
                sql = sql + " and ngayky <='" + Class.Functions.ConvertDate(msktoingay.Text) + "'";
            }
            if (msktoingay.Text != "  /  /" && msktungay.Text != "  /  /" && Class.Functions.DateDiff(msktungay.Text, msktoingay.Text) < 0)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msktoingay.Focus();
                return;
            }
            if (txtgiatri.Text != "")
            {
                sql = sql + " and tongtien <=" + txtgiatri.Text + "";
            }
            tbltkhd = Class.Functions.GetDataToTable(sql);
            if (tbltkhd.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetvalues();
            }
            else
            {
                MessageBox.Show("Có " + tbltkhd.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridView.DataSource = tbltkhd;
                load_data();
            }
        }
        private void load_data()
        {
            DataGridView.Columns[0].HeaderText = "Mã hợp đồng";
            DataGridView.Columns[1].HeaderText = "Mã nhân viên";
            DataGridView.Columns[2].HeaderText = "Mã khách hàng";
            DataGridView.Columns[3].HeaderText = "Ngày ký";
            DataGridView.Columns[4].HeaderText = "Tổng tiền";
            DataGridView.Columns[0].Width = 170;
            DataGridView.Columns[1].Width = 170;
            DataGridView.Columns[2].Width = 170;
            DataGridView.Columns[3].Width = 125;
            DataGridView.Columns[4].Width = 110;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            resetvalues();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtgiatri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar)) == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private ToolTip toolTip1;
        private void msktungay_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (toolTip1 == null)
            {
                // Nếu chưa, khởi tạo mới
                toolTip1 = new ToolTip();
            }
            toolTip1.ToolTipTitle = "Lỗi định dạng";
            toolTip1.Show("Vui lòng nhập đúng định dạng ngày tháng (dd/mm/yyyy)", msktungay, 0, -20, 2000);
            if (DateTime.TryParseExact(msktungay.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime enteredDate))
            {
                // Kiểm tra ngày hợp lệ (từ 1 đến 31)
                if (enteredDate.Day < 1 || enteredDate.Day > 31)
                {
                    MessageBox.Show("Ngày không hợp lệ (từ 1 đến 31)", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktoingay.Text = "";
                    return;
                }
                // Kiểm tra tháng hợp lệ (từ 1 đến 12)
                else if (enteredDate.Month < 1 || enteredDate.Month > 12)
                {
                    MessageBox.Show("Tháng không hợp lệ (từ 1 đến 12)", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktoingay.Text = "";
                    return;
                }
                // Kiểm tra năm hợp lệ (từ 1990 đến năm hiện tại)
                else if (enteredDate.Year < 1990 || enteredDate.Year > DateTime.Now.Year)
                {
                    MessageBox.Show("Năm không hợp lệ (từ 1990 đến năm hiện tại)", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktoingay.Text = "";
                    return;
                }
                // Kiểm tra ngày nhập vào phải nhỏ hơn ngày hiện tại
                else if (enteredDate > DateTime.Now)
                {
                    MessageBox.Show("Ngày nhập vào phải nhỏ hơn ngày hiện tại", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktoingay.Text = "";
                    return;
                }
            }

        }
        private void msktoingay_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (toolTip1 == null)
            {
                // Nếu chưa, khởi tạo mới
                toolTip1 = new ToolTip();
            }
            toolTip1.ToolTipTitle = "Lỗi định dạng";
            toolTip1.Show("Vui lòng nhập đúng định dạng ngày tháng (dd/mm/yyyy)", msktoingay, 0, -20, 2000);
        }

        private void txtgiatri_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboloaihd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void msktungay_Enter(object sender, EventArgs e)
        {
            // Kiểm tra ngày nhập vào
        }

        private void msktungay_Leave(object sender, EventArgs e)
        {

        }

        private void msktoingay_MouseClick(object sender, MouseEventArgs e)
        {
            if (DateTime.TryParseExact(msktungay.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime enteredDate))
            {
                // Kiểm tra ngày hợp lệ (từ 1 đến 31)
                if (enteredDate.Day < 1 || enteredDate.Day > 31)
                {
                    MessageBox.Show("Ngày không hợp lệ (từ 1 đến 31)", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktoingay.Text = "";
                    return;
                }
                // Kiểm tra tháng hợp lệ (từ 1 đến 12)
                else if (enteredDate.Month < 1 || enteredDate.Month > 12)
                {
                    MessageBox.Show("Tháng không hợp lệ (từ 1 đến 12)", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktoingay.Text = "";
                    return;
                }
                // Kiểm tra năm hợp lệ (từ 1990 đến năm hiện tại)
                else if (enteredDate.Year < 1990 || enteredDate.Year > DateTime.Now.Year)
                {
                    MessageBox.Show("Năm không hợp lệ (từ 1990 đến năm hiện tại)", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktoingay.Text = "";
                    return;
                }
                // Kiểm tra ngày nhập vào phải nhỏ hơn ngày hiện tại
                else if (enteredDate > DateTime.Now)
                {
                    MessageBox.Show("Ngày nhập vào phải nhỏ hơn ngày hiện tại", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktoingay.Text = "";
                    return;
                }
            }
        }
    }
}
