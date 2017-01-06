using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelBooking.LuuTru
{
    public partial class ucBill : UserControl
    {
        public ucBill()
        {
            InitializeComponent();
            cboMaPhong.ValueMember = "MaPhong";
            cboMaPhong.DisplayMember = "MaPhong";
        }

        private int numRow = 0;

        private void ThietLapButton(bool flag)
        {
            btnXoa.Enabled = flag;
            btnThanhToan.Enabled = flag;
        }

        private void ucBill_Load(object sender, EventArgs e)
        {
            ThietLapButton(false);
            cboMaPhong.DataSource = HoaDonBUS.LayMaPhongDaThue();
        }

        private void cboMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            HoaDonDTO infor = new HoaDonDTO();
            infor.MaPhong = int.Parse(cboMaPhong.Text);
            List<HoaDonDTO> lst = new List<HoaDonDTO>();
            lst = HoaDonBUS.LayThongTinThuePhong(infor);
            txtDonGia.Text = lst[0].DonGia.ToString();
            int maphieuthue = lst[0].MaPhieuThue.Value;
            infor.NgayBatDauThue = Convert.ToDateTime(lst[0].NgayBatDauThue.ToString());
            HoaDonBUS.TinhSoNgayDaThue(infor);
            lst = HoaDonBUS.LaySoNgayDaThue();
            txtSoNgayThue.Text = lst[0].SoNgayDaThue.ToString();
            if (txtSoNgayThue.Text == "0")
            {
                txtSoNgayThue.Text = "1";
            }
            int num = HoaDonBUS.LaySoLuongKhach(maphieuthue);
            lst = HoaDonBUS.KhachPT_KhachNG();
            int kpt = lst[0].KhachPTThu.Value;
            int kng = lst[0].SLKhachNG.Value;
            if (num >= kpt)
            {
                lst = HoaDonBUS.TinhPhuThu(num);
                txtPhuThu.Text = lst[0].PhuThu.ToString();
            }
            else
            {
                txtPhuThu.Text = "0";
            }
            int lk2 = HoaDonBUS.DemSLKhachNuocNgoai(infor);
            if (lk2 >= kng)
            {
                lst = HoaDonBUS.TinhHeSo();
                txtHeSo.Text = lst[0].HeSo.ToString();
            }
            else
            {
                txtHeSo.Text = "0";
            }
            bool flag = true;
            for (int i = 0; i < dgvHoaDon.RowCount; i++)
            {
                if (dgvHoaDon.Rows[i].Cells["colMaPhong"].Value.ToString() == cboMaPhong.Text)
                {
                    btnThem.Enabled = false;
                    flag = false;
                    break;
                }
            }
            if (flag == true)
                btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgvHoaDon.Rows.Add();
            dgvHoaDon.Rows[numRow].Cells["colSTT"].Value = numRow + 1;
            dgvHoaDon.Rows[numRow].Cells["colMaPhong"].Value = cboMaPhong.Text;
            dgvHoaDon.Rows[numRow].Cells["colSoNgayThue"].Value = txtSoNgayThue.Text;
            dgvHoaDon.Rows[numRow].Cells["colDonGia"].Value = txtDonGia.Text;
            dgvHoaDon.Rows[numRow].Cells["colPhuThu"].Value = txtPhuThu.Text;
            dgvHoaDon.Rows[numRow].Cells["colHeSo"].Value = txtHeSo.Text;

            btnThem.Enabled = false;

            decimal thanhtien = HoaDonBUS.ThanhTien(int.Parse(txtSoNgayThue.Text), Convert.ToDecimal(txtDonGia.Text), Convert.ToDecimal(txtPhuThu.Text), Convert.ToDecimal(txtHeSo.Text));
            dgvHoaDon.Rows[numRow].Cells["colThanhTien"].Value = thanhtien.ToString("0");

            numRow++;

            txtTriGia.Text = ((Convert.ToDecimal(txtTriGia.Text)) + thanhtien).ToString("0");
            ThietLapButton(true);
            if (txtKhCq.Text == "")
            {
                btnThanhToan.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string kt_chon = "false";
            decimal thanhtien = 0;
            for (int j = 0; j < dgvHoaDon.Rows.Count; j++)
            {
                try
                {
                    kt_chon = dgvHoaDon.Rows[j].Cells["colXoa"].Value.ToString();
                    thanhtien = Convert.ToDecimal(dgvHoaDon.Rows[j].Cells["colThanhTien"].Value.ToString());
                }
                catch { }
                if (kt_chon == "True")
                {
                    txtTriGia.Text = ((Convert.ToDecimal(txtTriGia.Text)) - thanhtien).ToString();
                    if (!(Convert.ToDecimal(txtTriGia.Text) > 0))
                    {
                        txtTriGia.Text = "0";
                    }
                    dgvHoaDon.Rows.RemoveAt(j);
                    kt_chon = "false";
                    numRow--; j = -1;
                }
            }

            if (dgvHoaDon.RowCount == 0)
            {
                ThietLapButton(false);
                btnThem.Enabled = true;
            }
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int maphong = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells["colMaPhong"].Value.ToString());
            frmInforCus.idroom = maphong;
            frmInforCus _frmInforCus = new frmInforCus();
            _frmInforCus.Show();
        }

        private HoaDonDTO ThongTinKHThanhToan()
        {
            HoaDonDTO infor = new HoaDonDTO();
            //Lay ma hoa don ke tiep
            infor.MaHoaDon = HoaDonBUS.LayMaHDCuoiCung();
            infor.MaHoaDon = infor.MaHoaDon + 1;

            infor.TenKH_CQ = txtKhCq.Text;
            infor.TriGia = Convert.ToDecimal(txtTriGia.Text);
            return infor;
        }

        private HoaDonDTO ThongTinHDThanhToan(int i)
        {
            HoaDonDTO infor = new HoaDonDTO();
            int maphong = int.Parse(dgvHoaDon.Rows[i].Cells["colMaPhong"].Value.ToString());
            infor.MaPhong = maphong;
            List<HoaDonDTO> lst = new List<HoaDonDTO>();
            lst = HoaDonBUS.LayMaPhieuThue(maphong);
            infor.MaPhieuThue = lst[0].MaPhieuThue.Value;
            infor.SoNgayDaThue = int.Parse(dgvHoaDon.Rows[i].Cells["colSoNgayThue"].Value.ToString());
            infor.DonGia = Convert.ToDecimal(dgvHoaDon.Rows[i].Cells["colDonGia"].Value.ToString());
            infor.ThanhTien = Convert.ToDecimal(dgvHoaDon.Rows[i].Cells["colThanhTien"].Value.ToString());
            infor.NgayThanhToan = Convert.ToDateTime(dtpNgayThanhToan.Text);
            return infor;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtKhCq.Text == "")
            {
                MessageBox.Show("Tên khách hàng hoặc tên cơ quan thanh toán chưa được nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool success = true;
                HoaDonDTO inforKH = ThongTinKHThanhToan();
                if (HoaDonBUS.LapHoaDon(inforKH))
                {
                    for (int i = 0; i < dgvHoaDon.RowCount; i++)
                    {
                        HoaDonDTO inforHD = ThongTinHDThanhToan(i);
                        if (!(HoaDonBUS.LapChiTietHoaDon(inforKH, inforHD)))
                        {
                            success = false;
                            MessageBox.Show("Không lập được chi tiết hóa đơn thứ " + i + "", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        //Xóa thông tin trong bảng phiếu thuê, chi tiết phiếu thuê, khách hàng
                        //Lấy tất cả mã khách hàng cần xóa
                        List<KhachHangDTO> lstkh = new List<KhachHangDTO>();
                        int? maphieuthue = inforHD.MaPhieuThue;
                        lstkh = KhachHangBUS.LayMaKhachHangCanXoa(maphieuthue);

                        //Xóa chi tiết phiếu thuê
                        if (!(HoaDonBUS.XoaChiTietPhieuThue(inforHD)))
                        {
                            success = false;
                            MessageBox.Show("Không xóa được chi tiết phiếu thuê", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }

                        //Xóa khách hàng
                        int count = lstkh.Count();
                        for (int j = 0; j < count; j++)
                        {
                            KhachHangDTO id = new KhachHangDTO();
                            id.MaKH = lstkh[j].MaKH;
                            if (!(KhachHangBUS.XoaKhachHang(id)))
                            {
                                success = false;
                                MessageBox.Show("Không xóa được khách hàng có mã " + id.MaKH + "", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }

                        //Xóa phiếu thuê
                        if (!(HoaDonBUS.XoaPhieuThue(inforHD)))
                        {
                            success = false;
                            MessageBox.Show("Không xóa được phiếu thuê", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }

                        //Cập nhật trạng thái mã phòng
                        if (!(PhongBUS.ThietLapTTrangPhongBanDau(inforHD)))
                        {
                            success = false;
                            MessageBox.Show("Không cập nhật lại được tình trạng phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    if (success == true)
                    {
                        MessageBox.Show("Lập hóa đơn thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        for (int i = 0; i < dgvHoaDon.RowCount; i++)
                        {
                            dgvHoaDon.Rows.RemoveAt(i);
                            i = -1;
                            numRow = 0;
                        }

                        ucBill_Load(sender, e);
                        ThietLapButton(false);
                        txtKhCq.Text = "";
                        txtTriGia.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Không lập được hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                ThietLapButton(false);
            }
        }

        private void txtKhCq_TextChanged(object sender, EventArgs e)
        {
            if (txtKhCq.Text != "")
            {
                if (dgvHoaDon.Rows.Count > 0)
                {
                    btnThanhToan.Enabled = true;
                }
            }
        }
    }
}