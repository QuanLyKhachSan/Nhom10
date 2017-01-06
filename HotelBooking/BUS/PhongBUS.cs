using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class PhongBUS
    {
        public static List<PhongDTO> DanhSachPhong()
        {
            return PhongDAO.DanhSachPhong();
        }

        public static List<PhongDTO> LoaiPhong()
        {
            return PhongDAO.LoaiPhong();
        }

        public static List<PhongDTO> DanhSachPhongTheoLoai(PhongDTO thongtin)
        {
            return PhongDAO.DanhSachPhongTheoLoai(thongtin);
        }

        public static List<PhongDTO> DanhSachPhongYeuCau(PhongDTO thongtin)
        {
            return PhongDAO.DanhSachPhongYeuCau(thongtin);
        }

        public static List<PhongDTO> DanhSachPhongTheoLoaiTheoYeuCau(PhongDTO thongtin)
        {
            return PhongDAO.DanhSachPhongTheoLoaiTheoYeuCau(thongtin);
        }

        public static List<PhongDTO> DanhSachPhongTheoDGTu(decimal dgtu)
        {
            return PhongDAO.DanhSachPhongTheoDGTu(dgtu);
        }

        public static List<PhongDTO> DanhSachPhongTheoKhoangDG(decimal dgtu, decimal dgden)
        {
            return PhongDAO.DanhSachPhongTheoKhoangDG(dgtu, dgden);
        }

        public static List<PhongDTO> DanhSachPhongTheoDGDen(decimal dgden)
        {
            return PhongDAO.DanhSachPhongTheoDGDen(dgden);
        }

        public static int LaySLPhongTrongTheoLoai(string loaiphong)
        {
            return PhongDAO.LaySLPhongTrongTheoLoai(loaiphong);
        }

        public static List<PhongDTO> LayMaPhongLoaiPhong()
        {
            return PhongDAO.LayMaPhongLoaiPhong();
        }

        public static bool CapNhatTinhTrangPhong(PhieuThuePhongDTO p)
        {
            return PhongDAO.CapNhatTinhTrangPhong(p);
        }

        public static List<ThamSoDTO> SoLuongKhachToiDa()
        {
            return PhongDAO.SoLuongKhachToiDa();
        }

        public static bool ThemPhong(PhongDTO infor)
        {
            return PhongDAO.ThemPhong(infor);
        }

        public static bool SuaThongTinPhong(PhongDTO infor)
        {
            return PhongDAO.SuaThongTinPhong(infor);
        }

        public static bool XoaPhong(PhongDTO infor)
        {
            return PhongDAO.XoaPhong(infor);
        }

        public static bool ThietLapTTrangPhongBanDau(HoaDonDTO inforHD)
        {
            return PhongDAO.ThietLapTTrangPhongBanDau(inforHD);
        }

        public static List<PhieuThuePhongDTO> DanhSachPhongDangDuocThue()
        {
            return PhongDAO.DanhSachPhongDangDuocThue();
        }

        public static List<PhongDTO> LayDanhSachLoaiPhong()
        {
            return PhongDAO.LayDanhSachLoaiPhong();
        }

        public static List<PhongDTO> LayDSLoaiPhong()
        {
            return PhongDAO.LayDSLoaiPhong();
        }

        public static int LoaiPhongTrong(string p)
        {
            return PhongDAO.LoaiPhongTrong(p);
        }

        public static bool ThemLoaiPhong(PhongDTO infor)
        {
            return PhongDAO.ThemLoaiPhong(infor);
        }

        public static List<PhongDTO> LayMaLoaiPhongKeTiep()
        {
            List<PhongDTO> lst = PhongDAO.LayMaLoaiPhongKeTiep();
            string malp = lst[0].MaLoaiPhong.ToString();
            string tt = malp.Substring(0, 2);
            string ht = malp.Substring(2, 3);
            int htnew = int.Parse(ht);
            htnew += 1;
            if (htnew > 99)
            {
                lst[0].MaLoaiPhong = (tt) + (htnew).ToString();
            }
            else if (htnew > 9)
            {
                lst[0].MaLoaiPhong = (tt) + "0" + (htnew).ToString();
            }
            else
            {
                lst[0].MaLoaiPhong = (tt) + "00" + (htnew).ToString();
            }
            return lst;
        }

        public static bool SuaTTLoaiPhong(PhongDTO infor)
        {
            return PhongDAO.SuaTTLoaiPhong(infor);
        }

        public static bool XoaLoaiPhong(PhongDTO infor)
        {
            return PhongDAO.XoaLoaiPhong(infor);
        }
    }
}