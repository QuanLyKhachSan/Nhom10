using BUS;
using DTO;
using HotelBooking.LuuTru;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelBooking.TraCuu
{
    public partial class ucSearchRoom : UserControl
    {
        private PhongBUS phongBUS = new PhongBUS();

        public ucSearchRoom()
        {
            InitializeComponent();
            cboLoaiPhong.DisplayMember = "TenLoaiPhong";
            cboLoaiPhong.ValueMember = "MaLoaiPhong";
        }

        private void SuKienLoadForm()
        {
            cboLoaiPhong.DataSource = PhongBUS.LoaiPhong();
            gcPhong.DataSource = PhongBUS.DanhSachPhong();
            btnDatPhong.Enabled = false;
        }

        //Event load form
        private void ucSearchRoom_Load(object sender, EventArgs e)
        {
            SuKienLoadForm();
        }

        private void gvPhong_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == gvPhong.Columns["TinhTrang"])
            {
                var _tinhtrang = Convert.ToString(gvPhong.GetRowCellValue(e.RowHandle, gvPhong.Columns["TinhTrang"]));
                if (_tinhtrang == "Đầy")
                {
                    e.Appearance.BackColor = Color.FromArgb(0x00, 0xFF, 0x00);
                }

                if (_tinhtrang == "Sửa chữa")
                {
                    e.Appearance.BackColor = Color.FromArgb(0xFF, 0x00, 0x00);
                }
            }
        }

        private PhongDTO LayThongTinTimKiem()
        {
            PhongDTO thongtin = new PhongDTO();
            thongtin.TenLoaiPhong = cboLoaiPhong.Text;
            thongtin.GhiChu = txtGhiChu.Text;

            return thongtin;
        }

        private void TimKiemTheoYeuCau(int s)
        {
            PhongDTO thongtin = LayThongTinTimKiem();
            if (s == 1)
            {
                gcPhong.DataSource = PhongBUS.DanhSachPhongYeuCau(thongtin);
            }
            else if (s == 2)
            {
                gcPhong.DataSource = PhongBUS.DanhSachPhongTheoLoai(thongtin);
            }
            else if (s == 3)
            {
                gcPhong.DataSource = PhongBUS.DanhSachPhongTheoLoaiTheoYeuCau(thongtin);
            }
            else if (s == 4)
            {
                decimal dgtu = Convert.ToDecimal(txtDonGiaTu.Text);
                gcPhong.DataSource = PhongBUS.DanhSachPhongTheoDGTu(dgtu);
            }
            else if (s == 5)
            {
                decimal dgtu = Convert.ToDecimal(txtDonGiaTu.Text);
                decimal dgden = Convert.ToDecimal(txtDonGiaDen.Text);
                gcPhong.DataSource = PhongBUS.DanhSachPhongTheoKhoangDG(dgtu, dgden);
            }
            else if (s == 6)
            {
                decimal dgden = Convert.ToDecimal(txtDonGiaDen.Text);
                gcPhong.DataSource = PhongBUS.DanhSachPhongTheoDGDen(dgden);
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            TimKiemTheoYeuCau(1);
        }

        private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDonGiaTu.Text == "" && txtDonGiaDen.Text == "" && txtGhiChu.Text == "")
            {
                TimKiemTheoYeuCau(2);
            }
            else if (txtDonGiaTu.Text == "" && txtDonGiaDen.Text == "" && txtGhiChu.Text != "")
            {
                TimKiemTheoYeuCau(3);
            }
        }

        private void txtDonGiaTu_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaTu.Text != "")
            {
                if (txtDonGiaDen.Text == "")
                {
                    TimKiemTheoYeuCau(4);
                }
                else
                {
                    TimKiemTheoYeuCau(5);
                }
            }
            else if (txtDonGiaTu.Text == "" && txtDonGiaDen.Text == "")
            {
                TimKiemTheoYeuCau(2);
            }
        }

        private void txtDonGiaDen_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaDen.Text != "")
            {
                if (txtDonGiaTu.Text == "")
                {
                    TimKiemTheoYeuCau(6);
                }
                else
                {
                    TimKiemTheoYeuCau(5);
                }
            }
            else if (txtDonGiaTu.Text == "" && txtDonGiaDen.Text == "")
            {
                TimKiemTheoYeuCau(2);
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            gcPhong.DataSource = PhongBUS.DanhSachPhong();
            txtDonGiaTu.Text = "";
            txtDonGiaDen.Text = "";
        }

        //Button dat phong
        private void btnThoat_Click(object sender, EventArgs e)
        {
            ucRentRoom.room = gvPhong.GetRowCellValue(gvPhong.FocusedRowHandle, gvPhong.Columns["MaPhong"]).ToString();
            ucRentRoom.roomtype = gvPhong.GetRowCellValue(gvPhong.FocusedRowHandle, gvPhong.Columns["TenLoaiPhong"]).ToString();

            frmRentRoom _frmRentRoom = new frmRentRoom();
            _frmRentRoom.Show();

            gcPhong.Enabled = false;
            btnDatPhong.Enabled = false;
        }

        private void gvPhong_Click(object sender, EventArgs e)
        {
            string status = gvPhong.GetRowCellValue(gvPhong.FocusedRowHandle, gvPhong.Columns["TinhTrang"]).ToString();
            if (status == "Trống")
                btnDatPhong.Enabled = true;
            else
                btnDatPhong.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            SuKienLoadForm();
            gcPhong.Enabled = true;
        }

        private void txtDonGiaTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGiaDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}