using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class KhachHangBUS
    {
        public static List<KhachHangDTO> LayDSLoaiKhach()
        {
            return KhachHangDAO.LayDSLoaiKhach();
        }

        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            return KhachHangDAO.ThemKhachHang(kh);
        }

        public static object LayDSKhachThuePhong(int idroom)
        {
            return KhachHangDAO.LayDSKhachThuePhong(idroom);
        }

        public static List<KhachHangDTO> LayMaKhachHangCanXoa(int? maphieuthue)
        {
            return KhachHangDAO.LayMaKhachHangCanXoa(maphieuthue);
        }

        public static bool XoaKhachHang(KhachHangDTO id)
        {
            return KhachHangDAO.XoaKhachHang(id);
        }

        public static List<KhachHangDTO> DanhSachKhachHang()
        {
            return KhachHangDAO.DanhSachKhachHang();
        }

        public static List<KhachHangDTO> DSKHTheoPhong(PhongDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoPhong(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTen(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoTen(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenDiaChi(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoTenDiaChi(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenLoaiKhach(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoTenLoaiKhach(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenDiaChiLoaiKhach(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoTenDiaChiLoaiKhach(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoLoaiKhach(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoLoaiKhach(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoLoaiKhachDiaChi(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoLoaiKhachDiaChi(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoDiaChi(KhachHangDTO thongtin)
        {
            return KhachHangDAO.DSKHTheoDiaChi(thongtin);
        }
    }
}