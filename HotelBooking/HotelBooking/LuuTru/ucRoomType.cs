using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelBooking.LuuTru
{
    public partial class ucRoomType : UserControl
    {
        public ucRoomType()
        {
            InitializeComponent();
        }

        private void ThietLapButton(bool flag)
        {
            btnCapNhat.Enabled = flag;
            btnLuu.Enabled = flag;
            btnXoa.Enabled = flag;
        }

        private void ucRoomType_Load(object sender, EventArgs e)
        {
            ThietLapButton(false);
            List<PhongDTO> lst = PhongBUS.LayDSLoaiPhong();
            for (int i = 0; i < lst.Count; i++)
            {
            }
            gcLoaiPhong.DataSource = lst;
        }

        private void gvLoaiPhong_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = gvLoaiPhong.GetRowCellValue(gvLoaiPhong.FocusedRowHandle, gvLoaiPhong.Columns["MaLoaiPhong"]).ToString();
            txtLoaiPhong.Text = gvLoaiPhong.GetRowCellValue(gvLoaiPhong.FocusedRowHandle, gvLoaiPhong.Columns["TenLoaiPhong"]).ToString();
            txtDonGia.Text = gvLoaiPhong.GetRowCellValue(gvLoaiPhong.FocusedRowHandle, gvLoaiPhong.Columns["DonGia"]).ToString();

            int num = PhongBUS.LoaiPhongTrong(txtMaPhong.Text);
            if (num > 0)
            {
                ThietLapButton(false);
            }
            else
            {
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void LamMoi()
        {
            txtMaPhong.Text = "";
            txtLoaiPhong.Text = "";
            txtDonGia.Text = "";
        }

        private void ThietLapTextBox(bool flag)
        {
            txtLoaiPhong.Enabled = flag;
            txtDonGia.Enabled = flag;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Ngừng";
                btnLuu.Enabled = true;
                LamMoi();
                ThietLapTextBox(true);
                gcLoaiPhong.Enabled = false;
                List<PhongDTO> lst = PhongBUS.LayMaLoaiPhongKeTiep();
                txtMaPhong.Text = lst[0].MaLoaiPhong;
            }
            else
            {
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                ThietLapTextBox(false);
                gcLoaiPhong.Enabled = true;
                LamMoi();
            }
        }

        private PhongDTO LayThongTinLoaiPhong()
        {
            PhongDTO infor = new PhongDTO();
            infor.MaLoaiPhong = txtMaPhong.Text;
            infor.TenLoaiPhong = txtLoaiPhong.Text;
            infor.DonGia = Convert.ToDecimal(txtDonGia.Text);

            return infor;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Ngừng")
            {
                if (txtLoaiPhong.Text == "" || txtDonGia.Text == "")
                {
                    MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    PhongDTO infor = LayThongTinLoaiPhong();
                    if (PhongBUS.ThemLoaiPhong(infor))
                    {
                        MessageBox.Show("Thêm loại phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ucRoomType_Load(sender, e);
                        btnThem.Text = "Thêm";
                        gcLoaiPhong.Enabled = true;
                        ThietLapTextBox(false);
                        LamMoi();
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại phòng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (btnCapNhat.Text == "Ngừng")
            {
                if (txtLoaiPhong.Text == "" || txtDonGia.Text == "")
                {
                    MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    PhongDTO infor = LayThongTinLoaiPhong();
                    if (PhongBUS.SuaTTLoaiPhong(infor))
                    {
                        MessageBox.Show("Sửa thông tin loại phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ucRoomType_Load(sender, e);
                        btnCapNhat.Text = "Cập nhật";
                        gcLoaiPhong.Enabled = true;
                        ThietLapTextBox(false);
                        btnThem.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin loại phòng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Text == "Cập nhật")
            {
                btnCapNhat.Text = "Ngừng";
                ThietLapTextBox(true);
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
            }
            else
            {
                btnCapNhat.Text = "Cập nhật";
                ThietLapTextBox(false);
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = (MessageBox.Show("Tất cả các phòng thuộc loại phòng này cũng sẽ bị xóa. Bạn có chắc muốn xóa không?", "Hỏi", buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2));
            if (result == DialogResult.Yes)
            {
                PhongDTO infor = LayThongTinLoaiPhong();
                if (PhongBUS.XoaLoaiPhong(infor))
                {
                    MessageBox.Show("Xóa loại phòng có mã " + infor.MaLoaiPhong + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    ucRoomType_Load(sender, e);
                    LamMoi();
                    btnCapNhat.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Không xóa được loại phòng có mã " + infor.MaLoaiPhong + "", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}