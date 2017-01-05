using DTO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DAO
{
    public class HoaDonDAO
    {
        private static QUAN_LY_KHACH_SANEntities context = new QUAN_LY_KHACH_SANEntities();

        public static List<DTO.HoaDonDTO> LayMaPhongDaThue()
        {
            var query = (from r in context.PHIEU_THUE_PHONG
                         select new HoaDonDTO
                         {
                             MaPhong = r.MaPhong,
                         });
            return query.ToList();
        }

        public static List<HoaDonDTO> LayThongTinThuePhong(HoaDonDTO infor)
        {
            var query = (from pt in context.PHIEU_THUE_PHONG
                         join p in context.PHONGs on pt.MaPhong equals p.MaPhong
                         join lp in context.LOAI_PHONG on p.MaLoaiPhong equals lp.MaLoaiPhong
                         where pt.MaPhong == infor.MaPhong
                         select new HoaDonDTO
                         {
                             NgayBatDauThue = pt.NgayBatDauThue,
                             DonGia = lp.DonGia,
                             MaPhieuThue = pt.MaPhieuThue,
                         });
            return query.ToList();
        }

        public static bool TinhSoNgayDaThue(HoaDonDTO infor)
        {
            SqlParameter ngaythue = new SqlParameter("@NgayBDThue", infor.NgayBatDauThue);

            try
            {
                context.Database.ExecuteSqlCommand("spTruNgayThangNam @NgayBDThue", ngaythue);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<HoaDonDTO> LaySoNgayDaThue()
        {
            var query = (from n in context.THAM_SO
                         select new HoaDonDTO
                         {
                             SoNgayDaThue = n.SoNgayThue,
                         });
            return query.ToList();
        }

        public static int LaySoLuongKhach(int maphieuthue)
        {
            int num = (from pt in context.PHIEU_THUE_PHONG
                       join ct in context.CHI_TIET_PHIEU_THUE on pt.MaPhieuThue equals ct.MaPhieuThue
                       where ct.MaPhieuThue == maphieuthue
                       select new HoaDonDTO
                       {
                       }).Count();
            return num;
        }

        public static List<HoaDonDTO> LayGiaTriPhuThu()
        {
            var query = (from p in context.THAM_SO
                         select new HoaDonDTO
                         {
                             PhuThu = p.PhuThu,
                         });
            return query.ToList();
        }

        public static int DemSLKhachNuocNgoai(HoaDonDTO infor)
        {
            int num = (from pt in context.PHIEU_THUE_PHONG
                       join ct in context.CHI_TIET_PHIEU_THUE on pt.MaPhieuThue equals ct.MaPhieuThue
                       join kh in context.KHACH_HANG on ct.MaKhachHang equals kh.MaKhachHang
                       where pt.MaPhong == infor.MaPhong && kh.MaLoaiKhach == "LK002"
                       select new HoaDonDTO
                       {
                       }).Count();
            return num;
        }

        public static List<HoaDonDTO> TinhHeSo()
        {
            var query = (from h in context.THAM_SO
                         select new HoaDonDTO
                         {
                             HeSo = h.HeSo,
                         });
            return query.ToList();
        }

        public static List<HoaDonDTO> KhachPT_KhachNG()
        {
            var query = (from t in context.THAM_SO
                         select new HoaDonDTO
                         {
                             KhachPTThu = t.PhuThuKhachThu,
                             SLKhachNG = t.SLKhachNuocNgoai,
                         });
            return query.ToList();
        }

        public static int? LayMaHDCuoiCung()
        {
            int num = (from h in context.HOA_DON
                       select new HoaDonDTO
                       {
                       }).Count();
            return num;
        }

        public static List<HoaDonDTO> LayMaPhieuThue(int maphong)
        {
            var query = (from pt in context.PHIEU_THUE_PHONG
                         where pt.MaPhong == maphong
                         select new HoaDonDTO
                         {
                             MaPhieuThue = pt.MaPhieuThue,
                         });
            return query.ToList();
        }

        public static bool LapHoaDon(HoaDonDTO inforKH)
        {
            SqlParameter mahd = new SqlParameter("@MaHD", inforKH.MaHoaDon);
            SqlParameter tenkh = new SqlParameter("@MaKH", inforKH.TenKH_CQ);
            SqlParameter trigia = new SqlParameter("@TriGia", inforKH.TriGia);

            try
            {
                context.Database.ExecuteSqlCommand("spThemHoaDon @MaHD, @MaKH, @TriGia",
                                mahd, tenkh, trigia);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool LapChiTietHoaDon(HoaDonDTO inforKH, HoaDonDTO inforHD)
        {
            SqlParameter mahd = new SqlParameter("@MaHD", inforKH.MaHoaDon);
            SqlParameter songaythue = new SqlParameter("@SoNT", inforHD.SoNgayDaThue);
            SqlParameter dongia = new SqlParameter("@DonGia", inforHD.DonGia);
            SqlParameter thanhtien = new SqlParameter("@ThanhTien", inforHD.ThanhTien);
            SqlParameter ngaythanhtoan = new SqlParameter("@NgayTT", inforHD.NgayThanhToan);
            SqlParameter maphong = new SqlParameter("@MaPhong", inforHD.MaPhong);

            try
            {
                context.Database.ExecuteSqlCommand("spThemChiTietHD @MaHD, @SoNT, @DonGia, @ThanhTien, @NgayTT, @MaPhong",
                                    mahd, songaythue, dongia, thanhtien, ngaythanhtoan, maphong);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaChiTietPhieuThue(HoaDonDTO inforHD)
        {
            SqlParameter mapt = new SqlParameter("@MaPT", inforHD.MaPhieuThue);
            try
            {
                context.Database.ExecuteSqlCommand("spXoaCTPhieuThue @MaPT", mapt);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaPhieuThue(HoaDonDTO inforHD)
        {
            SqlParameter mapt = new SqlParameter("@MaPT", inforHD.MaPhieuThue);
            try
            {
                context.Database.ExecuteSqlCommand("spXoaPhieuThue @MaPT", mapt);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}