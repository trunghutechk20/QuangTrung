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
    public partial class frmXuLyPhong : Form
    {
        private string idPhong;
        private Database db;
        public frmXuLyPhong(string idPhong)
        {
            this.idPhong = idPhong;
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void LoadLoaiPhong()
        {
            var dt = db.SelectData("loadDsLoaiPhong");
            cbbLoaiphong.DataSource = dt;
            cbbLoaiphong.DisplayMember = "TenLoaiPhong";
            cbbLoaiphong.ValueMember = "ID";

        }
        private void frmXuLyPhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadLoaiPhong();
            // vì phòng được xác định qua id nên chúng ta cần truyền tham số là giá trị của id phòng vào
            var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idPhong",
                        value= idPhong
                    }
                };
            var phong = db.SelectData("selectPhong", lstPara).Rows[0];
            cbbLoaiphong.SelectedValue = phong["idLoaiPhong"].ToString();
            txtTenphong.Text = phong["TenPhong"].ToString();
            if (phong["trangthai"].ToString() == "1")
            {
                ckbHoatdong.Checked = true;
            }
            else
            {
                ckbHoatdong.Checked = false;
            }
        }
        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (cbbLoaiphong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var idLoaiPhong = cbbLoaiphong.SelectedIndex.ToString();
            var tenphong = txtTenphong.Text.Trim();
            var trangthai = ckbHoatdong.Checked ? 1 : 0;

            if (string.IsNullOrEmpty(tenphong))
            {
                MessageBox.Show("Vui lòng nhập tên phòng", "Ràng buộc dữ liệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenphong.Select();
                return;
            }
            if (string.IsNullOrEmpty(idPhong))//truong hop them moi phong ko co id phong <=> null
            {
                var lstPra = new List<CustomParameter>()
                {
                   new CustomParameter()
                   {
                       key = "@idLoaiPhong",
                       value = idLoaiPhong
                   },
                   new CustomParameter()
                   {
                       key = "@tenphong",
                       value = tenphong
                   },
                   new CustomParameter()
                   {
                       key = "@trangthai",
                       value = trangthai.ToString()
                   }
                };
                var rs = db.ExeCute("[themMoiPhong]",lstPra);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm mới phòng thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //reset lại các giá trị cảu compoment sau khi thêm mới thành công
                    txtTenphong.Text = null;
                    cbbLoaiphong.SelectedIndex = 0;
                }
            }
            else// truong hop cap nhat phomng da ton tai <=> idphong co gia tri # null
            {
                // xử lý trường hợp cập nhật khi click vào button btnXacnhan
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idPhong",
                        value = idPhong
                    },
                    new CustomParameter()
                    {
                        key = "@tenphong",
                        value = txtTenphong.Text
                    },
                    new CustomParameter()
                    {
                        key = "@idLoaiPhong",
                        value = cbbLoaiphong.SelectedValue.ToString()
                    },
                     new CustomParameter()
                    {
                        key = "@trangthai",
                        value = trangthai.ToString()
                    }
                };
                var kq = db.ExeCute("updatePhong", lstPara);
                if(kq == 1)
                {
                    MessageBox.Show("Cập nhật thông tin phòng thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin phòng không thành công", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                  
            }
        }


    }
}
