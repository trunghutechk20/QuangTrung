using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.ChildForm
{
    public partial class frmPhong : Form
    {
        private Database db;
        private string idPhong = null;
        private int rowIndex = -1;
        public frmPhong()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            new frmXuLyPhong(null).ShowDialog();//truyền tham số null vào để xác định trường hợp thêm mới phòng
            LoadDsPhong();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            LoadDsPhong();

            //dat lai ten cot
            dgvPhong.Columns["tenloaiphong"].HeaderText = "Loại phòng";
            dgvPhong.Columns["dongia"].HeaderText = "Đơn giá";
            dgvPhong.Columns["trangthai"].HeaderText = "Trạng thái";

            //set kich thuoc cac cot
            dgvPhong.Columns["id"].Width = 100;
            dgvPhong.Columns["tenloaiphong"].Width = 200;
            dgvPhong.Columns["dongia"].Width = 200;
            dgvPhong.Columns["trangthai"].Width = 200;

        }
        private void LoadDsPhong()
        {
           

        }

        private void dgvPhong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // lay id phong được chọn
            var idPhong = dgvPhong.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            new frmXuLyPhong(idPhong).ShowDialog();//truyền idPhong được chọn qua form frmXulyphong để xác định truòng hợp cập nhật phòng
            LoadDsPhong();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy id phòng cần xóa trong sự kiện cell click của datagridview
            rowIndex = e.RowIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idPhong))
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa", "Chú ý!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("bạn có chắc muốn xóa phòng" +dgvPhong.Rows[rowIndex].Cells["tenphong"].Value.ToString()+"hay không?","Xác nhận xóa phòng",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.OK)
            {
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idPhong",
                        value = dgvPhong.Rows [rowIndex].Cells["ID"].Value.ToString()
                    }
                };
                var kq = db.ExeCute("deletePhong", lstPara);
                if(kq == 1)
                {
                    MessageBox.Show("Xóa phòng thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDsPhong();
                }    
            }
        }
    }

}
