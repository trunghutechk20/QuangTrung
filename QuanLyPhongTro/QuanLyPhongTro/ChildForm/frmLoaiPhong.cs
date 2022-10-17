using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.ChildForm
{
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private Database db;

        private int maLoaiPhong = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            var tenLoaiPhong = txtTenLoaiPhong.Text.Trim();
            var donGia = int.Parse(txtDonGia.Text);

            //ràng buộc dữ liệu
            if (maLoaiPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần cập nhật", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //dừng chương trình ngang đây
            }

            if (string.IsNullOrEmpty(tenLoaiPhong))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //dừng chương trình ngang đây
            }
            if (donGia < 500000)
            {
                MessageBox.Show("Đơn giá tối thiểu là 500.000", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //dừng chương trình ngang đây
            }

            var prList = new List<CustomParameter>();

            prList.Add(new CustomParameter()
            {
                key = "@idLoaiPhong",
                value = maLoaiPhong.ToString()
            });

            prList.Add(new CustomParameter
            {
                key = "@tenLoaiPhong",
                value = tenLoaiPhong
            });
            prList.Add(new CustomParameter
            {
                key = "@donGia",
                value = donGia.ToString()
            });
            var rs = db.ExeCute("[capNhatloaiphong]", prList);
            if (rs == 1)
            {
                MessageBox.Show("Cập nhật phòng thành công!", "Successfully!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsLoaiPhong();
                txtDonGia.Text = "0";
                txtTenLoaiPhong.Text = null;
                maLoaiPhong = 0;
            }
        }
        private void LoadDsLoaiPhong()
        {
            var db = new Database();
            dgvDsLoaiPhong.DataSource = db.SelectData("loadDsLoaiPhong");
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDsLoaiPhong();
            dgvDsLoaiPhong.Columns[0].Width = 100;
            dgvDsLoaiPhong.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDsLoaiPhong.Columns[0].HeaderText = "Mã Loại";

            dgvDsLoaiPhong.Columns[2].Width = 200;
            dgvDsLoaiPhong.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDsLoaiPhong.Columns[2].DefaultCellStyle.Format = "NO";
            dgvDsLoaiPhong.Columns[2].HeaderText = "Mã Loại";

            dgvDsLoaiPhong.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDsLoaiPhong.Columns[1].HeaderText = "Tên loại phòng";

        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvDsLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maLoaiPhong = int.Parse(dgvDsLoaiPhong.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTenLoaiPhong.Text = dgvDsLoaiPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonGia.Text = dgvDsLoaiPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
