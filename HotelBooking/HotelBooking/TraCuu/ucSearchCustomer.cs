using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HotelBooking.TraCuu
{
    public partial class ucSearchCustomer : UserControl
    {
        public ucSearchCustomer()
        {
            InitializeComponent();
        }

        private void SuKienLoadForm()
        {
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            List<KhachHangDTO> lst = KhachHangBUS.LayDSLoaiKhach();
            cboLoaiKhach.Items.Clear();
            for (int i = 0; i < (lst.Count); i++)
            {
                cboLoaiKhach.Items.Add(lst[i].LoaiKhach);
            }
            cboPhong.DisplayMember = "_MaPhong";
            cboPhong.ValueMember = "_MaPhong";
            cboPhong.DataSource = PhongBUS.DanhSachPhongDangDuocThue();
            gcKhachHang.DataSource = KhachHangBUS.DanhSachKhachHang();
        }

        private void ucSearchCustomer_Load(object sender, EventArgs e)
        {
            SuKienLoadForm();
        }

        private void gvKhachHang_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == gvKhachHang.Columns["LoaiKhach"])
            {
                var _loaikhach = Convert.ToString(gvKhachHang.GetRowCellValue(e.RowHandle, gvKhachHang.Columns["LoaiKhach"]));
                if (_loaikhach == "Nước ngoài")
                {
                    e.Appearance.BackColor = Color.FromArgb(0x00, 0xFF, 0x00);
                }
            }
        }

        private KhachHangDTO LayThongTinTimKiem()
        {
            KhachHangDTO thongtin = new KhachHangDTO();
            thongtin.TenKhachHang = txtTenKH.Text;
            thongtin.DiaChi = txtDiaChi.Text;
            thongtin.LoaiKhach = cboLoaiKhach.Text;

            return thongtin;
        }

        private void TimKiemTheoYeuCau(int s)
        {
            KhachHangDTO thongtin = LayThongTinTimKiem();
            if (s == 1)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoTen(thongtin);
            }
            else if (s == 2)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoTenDiaChi(thongtin);
            }
            else if (s == 3)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoTenLoaiKhach(thongtin);
            }
            else if (s == 4)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoTenDiaChiLoaiKhach(thongtin);
            }
            else if (s == 5)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoLoaiKhach(thongtin);
            }
            else if (s == 6)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoLoaiKhachDiaChi(thongtin);
            }
            else if (s == 7)
            {
                gcKhachHang.DataSource = KhachHangBUS.DSKHTheoDiaChi(thongtin);
            }
            else if (s == 8)
            {
                gcKhachHang.DataSource = KhachHangBUS.DanhSachKhachHang();
            }
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" && cboLoaiKhach.Text == "")
            {
                TimKiemTheoYeuCau(1);
            }
            else if (txtDiaChi.Text != "" && cboLoaiKhach.Text == "")
            {
                TimKiemTheoYeuCau(2);
            }
            else if (txtDiaChi.Text == "" && cboLoaiKhach.Text != "")
            {
                TimKiemTheoYeuCau(3);
            }
            else if (txtDiaChi.Text != "" && cboLoaiKhach.Text != "")
            {
                TimKiemTheoYeuCau(4);
            }
            else if (txtDiaChi.Text == "" && cboLoaiKhach.Text == "" && txtTenKH.Text == "")
            {
                TimKiemTheoYeuCau(8);
            }
        }

        private void cboLoaiKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" && txtTenKH.Text == "")
            {
                TimKiemTheoYeuCau(5);
            }
            else if (txtDiaChi.Text != "" && txtTenKH.Text == "")
            {
                TimKiemTheoYeuCau(6);
            }
            else if (txtDiaChi.Text == "" && txtTenKH.Text != "")
            {
                TimKiemTheoYeuCau(3);
            }
            else if (txtDiaChi.Text != "" && txtTenKH.Text != "")
            {
                TimKiemTheoYeuCau(4);
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" && txtTenKH.Text == "")
            {
                TimKiemTheoYeuCau(7);
            }
            else if (cboLoaiKhach.Text != "" && txtTenKH.Text == "")
            {
                TimKiemTheoYeuCau(6);
            }
            else if (cboLoaiKhach.Text == "" && txtTenKH.Text != "")
            {
                TimKiemTheoYeuCau(2);
            }
            else if (cboLoaiKhach.Text != "" && txtTenKH.Text != "")
            {
                TimKiemTheoYeuCau(4);
            }
            else if (txtDiaChi.Text == "" && cboLoaiKhach.Text == "" && txtTenKH.Text == "")
            {
                TimKiemTheoYeuCau(8);
            }
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhongDTO thongtin = new PhongDTO();
            thongtin.MaPhong = int.Parse(cboPhong.Text);

            gcKhachHang.DataSource = KhachHangBUS.DSKHTheoPhong(thongtin);
        }

        private void btnTimMoi_Click(object sender, EventArgs e)
        {
            SuKienLoadForm();
        }

        private void gvKhachHang_DoubleClick(object sender, EventArgs e)
        {
            int makh = int.Parse(gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, gvKhachHang.Columns["MaKH"]).ToString());
            string tenkh = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, gvKhachHang.Columns["TenKhachHang"]).ToString();
            List<PhieuThuePhongDTO> lst = new List<PhieuThuePhongDTO>();
            lst = PhieuThueBUS.LayPhongTuongUng(makh);
            int maphong = lst[0]._MaPhong;
            MessageBox.Show("Khách hàng '" + tenkh + "' đang thuê phòng số " + maphong + "", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}