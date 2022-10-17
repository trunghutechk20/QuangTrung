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
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            db = new Database();
            InitializeComponent();
        }
        private Database db;

        private void frmXuLyDV_Load(object sender, EventArgs e)
        {
            LoadDsDV();
            dgvDichVu.Columns[1].HeaderText = "Tên Dịch Vụ";
            dgvDichVu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void LoadDsDV()
        {
            db = new Database();

            var tinkiem = txtTimKiem.Text.Trim();
            var lstPra = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@timkiem",
                    value = tinkiem,
                }
            };

            var dt = db.SelectData("LoadDsDV", lstPra);

            dgvDichVu.DataSource = dt;
        }
        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            if(txtTenDV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tenDV",
                    value = txtTenDV.Text,
                }
            };
            if (db.ExeCute("ThemDV", lstPara) == 1)
            {
                MessageBox.Show("Thêm mới dịch vụ thành công!");
                LoadDsDV();
                txtTenDV.Text = null;
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            LoadDsDV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id < 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần cập nhật", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return ;
            }
            if (txtTenDV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@id",
                    value = id.ToString(),
                },
                new CustomParameter()
                {
                    key = "@tenDV",
                    value = txtTenDV.Text,
                }
            };
            if (db.ExeCute("CapNhatDV", lstPara) == 1)
            {
                MessageBox.Show("Cập nhật dịch vụ thành công!","Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsDV();
                txtTenDV.Text = null;
                id = -1;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id < 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần Xóa", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (MessageBox.Show("bạn có muốn xóa dịch vụ này?", "Xác nhận!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
            {
                var lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@id",
                    value = id.ToString(),
                }
            };
                if (db.ExeCute("XoaDV", lstPara) == 1)
                {
                    MessageBox.Show("Xóa dịch vụ thành công!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadDsDV();
                    txtTenDV.Text = null;
                    id = -1;
                }

            }
        }
        int id = -1;
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = int.Parse(dgvDichVu.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTenDV.Text = dgvDichVu.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
