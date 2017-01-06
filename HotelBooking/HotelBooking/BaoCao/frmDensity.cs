using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelBooking.BaoCao
{
    public partial class frmDensity : Form
    {
        public frmDensity()
        {
            InitializeComponent();
        }

        private void frmDensity_Load(object sender, EventArgs e)
        {
            rbtTatCa.Checked = true;
        }

        private List<BCMatDoDTO> lst = new List<BCMatDoDTO>();

        private void btnXem_Click(object sender, EventArgs e)
        {
            decimal s = 0;
            if (rbtTatCa.Checked == true)
            {
                try
                {
                    lst = BaoCaoBUS.MatDoSuDungPhong();
                    decimal sum = 0;
                    for (int i = 0; i < lst.Count; i++)
                    {
                        sum = sum + lst[i].TongNgayThue.Value;
                    }

                    for (int i = 0; i < lst.Count - 1; i++)
                    {
                        decimal per = (lst[i].TongNgayThue.Value * 100) / sum;
                        per = Math.Round(per, 2);
                        s = s + per;
                        lst[i].TiLe = (per).ToString() + "%";
                    }
                    s = 100 - s;
                    lst[lst.Count - 1].TiLe = (s).ToString() + "%";
                    BCMatDoDTOBindingSource.DataSource = lst;

                    btnLuu.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Dữ liệu hiện tại không có", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rbtTheoThang.Checked == true)
            {
                BCMatDoDTO infor = new BCMatDoDTO();
                infor.Thang = dtpMDThang.Value.Month;
                infor.Nam = dtpMDThang.Value.Year;
                lst = BaoCaoBUS.MatDoSuDungPhongTheoThang(infor);
                if (lst.Count > 0)
                {
                    s = 0;
                    decimal sum = 0;
                    for (int i = 0; i < lst.Count; i++)
                    {
                        sum = sum + lst[i].TongNgayThue.Value;
                    }

                    for (int i = 0; i < lst.Count - 1; i++)
                    {
                        decimal per = (lst[i].TongNgayThue.Value * 100) / sum;
                        per = Math.Round(per, 2);
                        s = s + per;
                        lst[i].TiLe = (per).ToString() + "%";
                    }
                    s = 100 - s;
                    lst[lst.Count - 1].TiLe = (s).ToString() + "%";

                    btnLuu.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Dữ liệu báo cáo cho tháng " + infor.Thang + " năm " + infor.Nam + " hiện không có", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                BCMatDoDTOBindingSource.DataSource = lst;
            }
            this.reportViewerMatDo.RefreshReport();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool success = true;
            List<BCMatDoDTO> dtlst = new List<BCMatDoDTO>();
            BCMatDoDTO infor = new BCMatDoDTO();
            try
            {
                dtlst = BaoCaoBUS.LayMaBCMatDoKeTiep();
                infor.MaBCMatDoSuDung = (dtlst[0].MaBCMatDoSuDung + 1);
                dtlst = BaoCaoBUS.LayMaCTBCMatDoKeTiep();
                infor.MaBCCTMatDoSuDung = (dtlst[0].MaBCCTMatDoSuDung + 1);
            }
            catch
            {
                infor.MaBCMatDoSuDung = 1;
                infor.MaBCCTMatDoSuDung = 1;
            }
            infor.Thang = dtpMDThang.Value.Month;
            if (BaoCaoBUS.ThemBaoCaoMatDo(infor))
            {
                int n = lst.Count();
                for (int i = 0; i < n; i++)
                {
                    infor.MaPhong = lst[i].MaPhong;
                    infor.TongNgayThue = lst[i].TongNgayThue;
                    infor.TiLe = lst[i].TiLe;
                    if (!(BaoCaoBUS.ThemCTBaoCaoMatDo(infor)))
                    {
                        success = false;
                        MessageBox.Show("Không thêm được chi tiết báo cáo mật độ sử dụng phòng cho tháng " + infor.Thang + "", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (success == true)
                {
                    MessageBox.Show("Lưu dữ liệu báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLuu.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Không thêm được báo cáo mật độ sử dụng phòng cho tháng " + infor.Thang + "", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}