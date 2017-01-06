using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HotelBooking.LuuTru
{
    public partial class ucRentRoom : UserControl
    {
        public static string room = string.Empty;
        public static string roomtype = string.Empty;
        private DataTable dt = new DataTable();
        private int numRow = 0; private int maxCus = 0;

        public ucRentRoom()
        {
            InitializeComponent();
        }

        private void ucRentRoom_Load(object sender, EventArgs e)
        {
            txtMaPhong.Text = room;
            txtLoaiPhong.Text = roomtype;

            cboLoaiKhachHang.DataSource = KhachHangBUS.LayDSLoaiKhach();
            cboLoaiKhachHang.ValueMember = "MaLoaiKhach";
            cboLoaiKhachHang.DisplayMember = "TenLoaiKhach";

            #region Lấy số lượng khách tối đa có trong 1 phòng

            List<ThamSoDTO> lstMaxCus = PhongBUS.SoLuongKhachToiDa();
            maxCus = lstMaxCus[0].SLKhachToiDa;

            #endregion Lấy số lượng khách tối đa có trong 1 phòng
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (numRow < maxCus)
            {
                if (txtTenKhachHang.Text != "" && txtDiaChi.Text != "" && txtCMND.Text != "")
                {
                    dgvCustomer.Rows.Add();
                    dgvCustomer.Rows[numRow].Cells["colTenKhachHang"].Value = txtTenKhachHang.Text;
                    dgvCustomer.Rows[numRow].Cells["colLoaiKhach"].Value = cboLoaiKhachHang.Text;
                    dgvCustomer.Rows[numRow].Cells["colCMND"].Value = txtCMND.Text;
                    dgvCustomer.Rows[numRow].Cells["colDiaChi"].Value = txtDiaChi.Text;
                    numRow++;

                    btnLuu.Enabled = true;
                    btnXoaKH.Enabled = true;

                    txtTenKhachHang.Text = "";
                    txtCMND.Text = "";
                    txtDiaChi.Text = "";
                    txtTenKhachHang.Focus();
                }
            }
            else
            {
                btnThemKH.Enabled = false;
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            string kt_chon = "false";
            for (int j = 0; j < dgvCustomer.Rows.Count; j++)
            {
                try
                {
                    kt_chon = dgvCustomer.Rows[j].Cells["colXoa"].Value.ToString();
                }
                catch { }
                if (kt_chon == "True")
                {
                    dgvCustomer.Rows.RemoveAt(j);
                    kt_chon = "false";
                    numRow--; j = -1;
                    btnThemKH.Enabled = true;
                }
            }

            if (dgvCustomer.RowCount == 0)
            {
                btnXoaKH.Enabled = false;
                btnLuu.Enabled = false;
            }
        }

        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Bạn có muốn kết thúc phiên làm việc này không?", "Hỏi", buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                ((Form)this.TopLevelControl).Close();
            }
        }

        private PhieuThuePhongDTO LayThongTinPhong()
        {
            PhieuThuePhongDTO p = new PhieuThuePhongDTO();
            p._MaPhong = int.Parse(txtMaPhong.Text);
            p._NgayThue = Convert.ToDateTime(dtpNgayThuePhong.Text);
            return p;
        }

        private KhachHangDTO LayThongTinKhachHang(int i)
        {
            KhachHangDTO kh = new KhachHangDTO();
            List<KhachHangDTO> lst = new List<KhachHangDTO>();
            try
            {
                lst = PhieuThueBUS.LayMaKHKeTiep();
                kh.MaKH = lst[0].MaKH + 1;
            }
            catch
            {
                kh.MaKH = 1;
            }
            kh.TenKhachHang = dgvCustomer.Rows[i].Cells["colTenKhachHang"].Value.ToString();
            kh.CMND = dgvCustomer.Rows[i].Cells["colCMND"].Value.ToString();
            kh.DiaChi = dgvCustomer.Rows[i].Cells["colDiaChi"].Value.ToString();
            kh.MaLoaiKhach = dgvCustomer.Rows[i].Cells["colLoaiKhach"].Value.ToString();

            return kh;
        }

        private ChiTietPhieuThueDTO LayMaKeTiep()
        {
            ChiTietPhieuThueDTO ct = new ChiTietPhieuThueDTO();
            List<PhieuThuePhongDTO> lst = new List<PhieuThuePhongDTO>();
            try
            {
                lst = PhieuThueBUS.LayMaPTKeTiep();
                ct._MaPT = lst[0].MaPT + 1;
                lst = PhieuThueBUS.LayMaCTPTKeTiep();
                ct._MaCTPT = lst[0].MaCTPT + 1;
            }
            catch
            {
                ct._MaPT = 1;
                ct._MaCTPT = 1;
            }

            return ct;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhieuThuePhongDTO p = LayThongTinPhong();
            ChiTietPhieuThueDTO ct = LayMaKeTiep();

            //Thêm phiếu thuê
            if (PhieuThueBUS.ThemPhieuThuePhong(ct, p))
            {
                for (int i = 0; i < dgvCustomer.Rows.Count; i++)
                {
                    KhachHangDTO kh = LayThongTinKhachHang(i);
                    //Thêm khách hàng
                    if (KhachHangBUS.ThemKhachHang(kh))
                    {
                        //Thêm chi tiết phiếu thuê
                        if (!PhieuThueBUS.ThemCTPhieuThuePhong(ct, kh))
                        {
                            MessageBox.Show("Không thêm được chi tiết phiếu thuê", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thêm thông tin của khách hàng " + kh.TenKhachHang + "", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }

                //Cập nhật lại tình trạng phòng
                if (PhongBUS.CapNhatTinhTrangPhong(p))
                {
                    MessageBox.Show("Lập phiếu thuê phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((Form)this.TopLevelControl).Close();
                }
                else
                {
                    MessageBox.Show("Không cập nhật được tình trạng phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Không thêm được phiếu thuê", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}