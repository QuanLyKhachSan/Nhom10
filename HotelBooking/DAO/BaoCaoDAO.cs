using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DAO
{
    public class BaoCaoDAO
    {
        private static QUAN_LY_KHACH_SANEntities context = new QUAN_LY_KHACH_SANEntities();

        public static List<BCDoanhThuDTO> DoanhThuTheoLoaiPhong()
        {
            var query = from p in context.PHONGs
                        join ct in context.CHI_TIET_HOA_DON on p.MaPhong equals ct.MaPhong
                        join hd in context.HOA_DON on ct.MaHoaDon equals hd.MaHoaDon
                        group hd by p.MaLoaiPhong into g
                        select new BCDoanhThuDTO
                        {
                            Name = g.Key,
                            Sum = g.Sum(hd => hd.TriGia),
                        };
            return query.ToList();
        }

        public static List<BCDoanhThuDTO> DoanhThuTheoLoaiPhongTheoThang(DateTime ntm_min, DateTime ntm_max)
        {
            var query = from p in context.PHONGs
                        join ct in context.CHI_TIET_HOA_DON on p.MaPhong equals ct.MaPhong
                        join hd in context.HOA_DON on ct.MaHoaDon equals hd.MaHoaDon
                        where ct.NgayThanhToan >= ntm_min && ct.NgayThanhToan <= ntm_max
                        group hd by p.MaLoaiPhong into g
                        select new BCDoanhThuDTO
                        {
                            Name = g.Key,
                            Sum = g.Sum(hd => hd.TriGia),
                        };
            return query.ToList();
        }

        public static List<BCDoanhThuDTO> LayMaBCDoanhThuKeTiep()
        {
            var query = (from m in context.BAOCAO_DOANHTHUTHEOLOAIPHONG
                         select new BCDoanhThuDTO
                         {
                             MaBCDoanhThu = m.MaBCDoanhThu,
                         }).OrderByDescending(x => x.MaBCDoanhThu).Take(1);
            return query.ToList();
        }

        public static bool ThemBaoCaoDoanhThu(BCDoanhThuDTO infor)
        {
            SqlParameter mabc = new SqlParameter("@MaBCDoanhThu", infor.MaBCDoanhThu);
            SqlParameter thang = new SqlParameter("@Thang", infor.Thang);
            try
            {
                context.Database.ExecuteSqlCommand("spThemBCDoanhThuTheoLoaiPhongTheoThang @MaBCDoanhThu, @Thang", mabc, thang);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<BCDoanhThuDTO> LayMaCTBCDoanhThuKeTiep()
        {
            var query = (from m in context.CHITIET_BAOCAODOANHTHU
                         select new BCDoanhThuDTO
                         {
                             MaCTBCDoanhThu = m.MaBCCTDoanhThu,
                         }).OrderByDescending(x => x.MaCTBCDoanhThu).Take(1);
            return query.ToList();
        }

        public static bool ThemCTBaoCaoDoanhThu(BCDoanhThuDTO infor)
        {
            SqlParameter mabcct = new SqlParameter("@MaBCCTDoanhThu", infor.MaCTBCDoanhThu);
            SqlParameter malp = new SqlParameter("@MaLP", infor.Name);
            SqlParameter mabc = new SqlParameter("@MaBCDoanhThu", infor.MaBCDoanhThu);
            SqlParameter dt = new SqlParameter("@DoanhThu", infor.Sum);
            SqlParameter tl = new SqlParameter("@TiLe", infor.TiLe);

            try
            {
                context.Database.ExecuteSqlCommand("spThemBCCTDTTheoLoaiPhongTheoThang @MaBCCTDoanhThu, @MaLP, @MaBCDoanhThu, @DoanhThu, @TiLe",
                                mabcct, malp, mabc, dt, tl);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<BCMatDoDTO> MatDoSuDungPhong()
        {
            var query = from ct in context.CHI_TIET_HOA_DON
                        group ct by ct.MaPhong into g
                        select new BCMatDoDTO
                        {
                            MaPhong = g.Key,
                            TongNgayThue = g.Sum(ct => ct.SoNgayThue),
                        };
            return query.ToList();
        }

        public static List<BCMatDoDTO> MatDoSuDungPhongTheoThang(DateTime ntm_min, DateTime ntm_max)
        {
            var query = from ct in context.CHI_TIET_HOA_DON
                        where ct.NgayThanhToan >= ntm_min && ct.NgayThanhToan <= ntm_max
                        group ct by ct.MaPhong into g
                        select new BCMatDoDTO
                        {
                            MaPhong = g.Key,
                            TongNgayThue = g.Sum(ct => ct.SoNgayThue),
                        };
            return query.ToList();
        }

        public static List<BCMatDoDTO> LayMaBCMatDoKeTiep()
        {
            var query = (from m in context.BAOCAO_MATDOSUDUNGPHONG
                         select new BCMatDoDTO
                         {
                             MaBCMatDoSuDung = m.MaBCMatDoSuDung,
                         }).OrderByDescending(x => x.MaBCMatDoSuDung).Take(1);
            return query.ToList();
        }

        public static List<BCMatDoDTO> LayMaCTBCMatDoKeTiep()
        {
            var query = (from m in context.CHITIET_BAOCAOMATDOSUDUNG
                         select new BCMatDoDTO
                         {
                             MaBCCTMatDoSuDung = m.MaBCCTMatDoSuDung,
                         }).OrderByDescending(x => x.MaBCCTMatDoSuDung).Take(1);
            return query.ToList();
        }

        public static bool ThemBaoCaoMatDo(BCMatDoDTO infor)
        {
            SqlParameter mabc = new SqlParameter("@MaBCMatDo", infor.MaBCMatDoSuDung);
            SqlParameter thang = new SqlParameter("@Thang", infor.Thang);
            try
            {
                context.Database.ExecuteSqlCommand("spThemBCMatDoSuDungPhongTheoThang @MaBCMatDo, @Thang", mabc, thang);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ThemCTBaoCaoMatDo(BCMatDoDTO infor)
        {
            SqlParameter mabcct = new SqlParameter("@MaBCCTMatDo", infor.MaBCCTMatDoSuDung);
            SqlParameter map = new SqlParameter("@MaP", infor.MaPhong);
            SqlParameter mabc = new SqlParameter("@MaBCMatDo", infor.MaBCMatDoSuDung);
            SqlParameter tnt = new SqlParameter("@SoNgayThue", infor.TongNgayThue);
            SqlParameter tl = new SqlParameter("@TiLe", infor.TiLe);

            try
            {
                context.Database.ExecuteSqlCommand("spThemBCCTMDTheoPhongTheoThang @MaBCCTMatDo, @MaP, @MaBCMatDo, @SoNgayThue, @TiLe",
                                mabcct, map, mabc, tnt, tl);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}