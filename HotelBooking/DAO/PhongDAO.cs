using DTO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DAO
{
    public class PhongDAO
    {
        private static QUAN_LY_KHACH_SANEntities context = new QUAN_LY_KHACH_SANEntities();

        public static List<PhongDTO> DanhSachPhong()
        {
            var query = (from r in context.PHONGs
                         join t in context.LOAI_PHONG on r.LOAI_PHONG.MaLoaiPhong equals t.MaLoaiPhong
                         select new PhongDTO
                         {
                             MaPhong = r.MaPhong,
                             TinhTrang = r.TinhTrang,
                             GhiChu = r.GhiChu,
                             TenLoaiPhong = r.LOAI_PHONG.TenLoaiPhong,
                             DonGia = r.LOAI_PHONG.DonGia,
                         }).OrderByDescending(s => s.TinhTrang);
            return query.ToList();
        }

        public static List<PhongDTO> LoaiPhong()
        {
            var query = (from t in context.LOAI_PHONG
                         select new PhongDTO
                         {
                             MaLoaiPhong = t.MaLoaiPhong,
                             TenLoaiPhong = t.TenLoaiPhong,
                         });
            return query.ToList();
        }

        public static List<PhongDTO> DanhSachPhongTheoLoai(PhongDTO thongtin)
        {
            var query = (from r in context.PHONGs
                         join t in context.LOAI_PHONG on r.LOAI_PHONG.MaLoaiPhong equals t.MaLoaiPhong
                         where t.TenLoaiPhong == thongtin.TenLoaiPhong
                         select new PhongDTO
                         {
                             MaPhong = r.MaPhong,
                             TinhTrang = r.TinhTrang,
                             GhiChu = r.GhiChu,
                             TenLoaiPhong = r.LOAI_PHONG.TenLoaiPhong,
                             DonGia = r.LOAI_PHONG.DonGia,
                         }).OrderByDescending(s => s.TinhTrang);
            return query.ToList();
        }

        //Dùng store cho dễ
        public static List<PhongDTO> DanhSachPhongYeuCau(PhongDTO thongtin)
        {
            var query = (from r in context.PHONGs
                         join t in context.LOAI_PHONG on r.LOAI_PHONG.MaLoaiPhong equals t.MaLoaiPhong
                         where r.GhiChu.Contains(thongtin.GhiChu)
                         select new PhongDTO
                         {
                             MaPhong = r.MaPhong,
                             TinhTrang = r.TinhTrang,
                             GhiChu = r.GhiChu,
                             TenLoaiPhong = r.LOAI_PHONG.TenLoaiPhong,
                             DonGia = r.LOAI_PHONG.DonGia,
                         }).OrderByDescending(s => s.TinhTrang);
            return query.ToList();
        }

        public static List<PhongDTO> DanhSachPhongTheoLoaiTheoYeuCau(PhongDTO thongtin)
        {
            var query = (from r in context.PHONGs
                         join t in context.LOAI_PHONG on r.LOAI_PHONG.MaLoaiPhong equals t.MaLoaiPhong
                         where (t.TenLoaiPhong == thongtin.TenLoaiPhong) && (r.GhiChu.Contains(thongtin.GhiChu))
                         select new PhongDTO
                         {
                             MaPhong = r.MaPhong,
                             TinhTrang = r.TinhTrang,
                             GhiChu = r.GhiChu,
                             TenLoaiPhong = r.LOAI_PHONG.TenLoaiPhong,
                             DonGia = r.LOAI_PHONG.DonGia,
                         }).OrderByDescending(s => s.TinhTrang);
            return query.ToList();
        }

        public static List<PhongDTO> DanhSachPhongTheoDGTu(decimal dgtu)
        {
            var query = (from r in context.PHONGs
                         join t in context.LOAI_PHONG on r.LOAI_PHONG.MaLoaiPhong equals t.MaLoaiPhong
                         where t.DonGia >= dgtu
                         select new PhongDTO
                         {
                             MaPhong = r.MaPhong,
                             TinhTrang = r.TinhTrang,
                             GhiChu = r.GhiChu,
                             TenLoaiPhong = r.LOAI_PHONG.TenLoaiPhong,
                             DonGia = r.LOAI_PHONG.DonGia,
                         }).OrderByDescending(s => s.TinhTrang);
            return query.ToList();
        }

        public static List<PhongDTO> DanhSachPhongTheoKhoangDG(decimal dgtu, decimal dgden)
        {
            var query = (from r in context.PHONGs
                         join t in context.LOAI_PHONG on r.LOAI_PHONG.MaLoaiPhong equals t.MaLoaiPhong
                         where (t.DonGia >= dgtu) && (t.DonGia <= dgden)
                         select new PhongDTO
                         {
                             MaPhong = r.MaPhong,
                             TinhTrang = r.TinhTrang,
                             GhiChu = r.GhiChu,
                             TenLoaiPhong = r.LOAI_PHONG.TenLoaiPhong,
                             DonGia = r.LOAI_PHONG.DonGia,
                         }).OrderByDescending(s => s.TinhTrang);
            return query.ToList();
        }

        public static List<PhongDTO> DanhSachPhongTheoDGDen(decimal dgden)
        {
            var query = (from r in context.PHONGs
                         join t in context.LOAI_PHONG on r.LOAI_PHONG.MaLoaiPhong equals t.MaLoaiPhong
                         where t.DonGia <= dgden
                         select new PhongDTO
                         {
                             MaPhong = r.MaPhong,
                             TinhTrang = r.TinhTrang,
                             GhiChu = r.GhiChu,
                             TenLoaiPhong = r.LOAI_PHONG.TenLoaiPhong,
                             DonGia = r.LOAI_PHONG.DonGia,
                         }).OrderByDescending(s => s.TinhTrang);
            return query.ToList();
        }

        public static int LaySLPhongTrongTheoLoai(string loaiphong)
        {
            int num = (from r in context.PHONGs
                       join t in context.LOAI_PHONG on r.LOAI_PHONG.MaLoaiPhong equals t.MaLoaiPhong
                       where r.LOAI_PHONG.MaLoaiPhong == loaiphong && r.TinhTrang == "Trống"
                       select new PhongDTO
                       {
                       }).Count();
            return num;
        }

        public static List<PhongDTO> LayMaPhongLoaiPhong()
        {
            var query = (from r in context.PHONGs
                         join t in context.LOAI_PHONG on r.LOAI_PHONG.MaLoaiPhong equals t.MaLoaiPhong
                         where r.TinhTrang == "Trống"
                         select new PhongDTO
                         {
                             MaPhong = r.MaPhong,
                             TenLoaiPhong = r.LOAI_PHONG.TenLoaiPhong,
                             GhiChu = r.GhiChu,
                             DonGia = r.LOAI_PHONG.DonGia,
                         }).OrderBy(x => x.TenLoaiPhong);
            return query.ToList();
        }

        public static bool CapNhatTinhTrangPhong(PhieuThuePhongDTO p)
        {
            SqlParameter maphong = new SqlParameter("@MaPhong", p._MaPhong);

            try
            {
                context.Database.ExecuteSqlCommand("spCapNhatTinhTrangPhong @MaPhong",
                                    maphong);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<ThamSoDTO> SoLuongKhachToiDa()
        {
            var query = (from max in context.THAM_SO
                         select new ThamSoDTO
                         {
                             SLKhachToiDa = max.SoKhachToiDa,
                         });
            return query.ToList();
        }

        public static bool ThemPhong(PhongDTO infor)
        {
            SqlParameter tinhtrang = new SqlParameter("@TinhTrang", infor.TinhTrang);
            SqlParameter malp = new SqlParameter("@MaLoaiPhong", infor.MaLoaiPhong);
            SqlParameter ghichu = new SqlParameter("@GhiChu", infor.GhiChu);

            try
            {
                context.Database.ExecuteSqlCommand("spThemPhong @TinhTrang, @MaLoaiPhong, @GhiChu",
                                    tinhtrang, malp, ghichu);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SuaThongTinPhong(PhongDTO infor)
        {
            SqlParameter maphong = new SqlParameter("@MaPhong", infor.MaPhong);
            SqlParameter tinhtrang = new SqlParameter("@TinhTrang", infor.TinhTrang);
            SqlParameter malp = new SqlParameter("@MaLoaiPhong", infor.MaLoaiPhong);
            SqlParameter ghichu = new SqlParameter("@GhiChu", infor.GhiChu);

            try
            {
                context.Database.ExecuteSqlCommand("spSuaThongTinPhong @MaPhong, @TinhTrang, @MaLoaiPhong, @GhiChu",
                                    maphong, tinhtrang, malp, ghichu);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaPhong(PhongDTO infor)
        {
            SqlParameter maphong = new SqlParameter("@MaPhong", infor.MaPhong);
            try
            {
                context.Database.ExecuteSqlCommand("spXoaPhong @MaPhong", maphong);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ThietLapTTrangPhongBanDau(HoaDonDTO inforHD)
        {
            SqlParameter maphong = new SqlParameter("@MaPhong", inforHD.MaPhong);

            try
            {
                context.Database.ExecuteSqlCommand("spThietLapTTrangPhongBanDau @MaPhong",
                                    maphong);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<PhieuThuePhongDTO> DanhSachPhongDangDuocThue()
        {
            var query = (from p in context.PHIEU_THUE_PHONG
                         select new PhieuThuePhongDTO
                         {
                             _MaPhong = p.MaPhong,
                         });
            return query.ToList();
        }

        public static List<PhongDTO> LayDanhSachLoaiPhong()
        {
            var query = (from t in context.LOAI_PHONG
                         select new PhongDTO
                         {
                             MaLoaiPhong = t.MaLoaiPhong,
                         });
            return query.ToList();
        }

        public static List<PhongDTO> LayDSLoaiPhong()
        {
            var query = (from t in context.LOAI_PHONG
                         select new PhongDTO
                         {
                             MaLoaiPhong = t.MaLoaiPhong,
                             TenLoaiPhong = t.TenLoaiPhong,
                             DonGia = t.DonGia,
                         });
            return query.ToList();
        }

        public static int LoaiPhongTrong(string p)
        {
            int num = (from pt in context.PHIEU_THUE_PHONG
                       join ph in context.PHONGs on pt.MaPhong equals ph.MaPhong
                       join lp in context.LOAI_PHONG on ph.MaLoaiPhong equals lp.MaLoaiPhong
                       where lp.MaLoaiPhong == p
                       select new PhongDTO
                       {
                       }).Count();
            return num;
        }

        public static List<PhongDTO> LayMaLoaiPhongKeTiep()
        {
            var query = (from t in context.LOAI_PHONG
                         select new PhongDTO
                         {
                             MaLoaiPhong = t.MaLoaiPhong,
                         }).OrderByDescending(x => x.MaLoaiPhong);
            return query.ToList();
        }

        public static bool ThemLoaiPhong(PhongDTO infor)
        {
            SqlParameter malp = new SqlParameter("@MaLP", infor.MaLoaiPhong);
            SqlParameter tenlp = new SqlParameter("@TenLP", infor.TenLoaiPhong);
            SqlParameter dg = new SqlParameter("@DonGia", infor.DonGia);

            try
            {
                context.Database.ExecuteSqlCommand("spThemLoaiPhong @MaLP, @TenLP, @DonGia", malp, tenlp, dg);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SuaTTLoaiPhong(PhongDTO infor)
        {
            SqlParameter malp = new SqlParameter("@MaLP", infor.MaLoaiPhong);
            SqlParameter tenlp = new SqlParameter("@TenLP", infor.TenLoaiPhong);
            SqlParameter dg = new SqlParameter("@DonGia", infor.DonGia);

            try
            {
                context.Database.ExecuteSqlCommand("spSuaTTLoaiPhong @MaLP, @TenLP, @DonGia", malp, tenlp, dg);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaLoaiPhong(PhongDTO infor)
        {
            SqlParameter malp = new SqlParameter("@MaLP", infor.MaLoaiPhong);
            try
            {
                context.Database.ExecuteSqlCommand("spXoaLoaiPhong @MaLP", malp);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}