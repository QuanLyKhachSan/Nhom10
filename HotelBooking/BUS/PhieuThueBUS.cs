using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class PhieuThueBUS
    {
        public static List<KhachHangDTO> LayMaKHKeTiep()
        {
            return PhieuThueDAO.LayMaKHKeTiep();
        }

        public static List<PhieuThuePhongDTO> LayMaPTKeTiep()
        {
            return PhieuThueDAO.LayMaPTKeTiep();
        }

        public static List<PhieuThuePhongDTO> LayMaCTPTKeTiep()
        {
            return PhieuThueDAO.LayMaCTPTKeTiep();
        }

        public static bool ThemPhieuThuePhong(ChiTietPhieuThueDTO ct, PhieuThuePhongDTO p)
        {
            return PhieuThueDAO.ThemPhieuThuePhong(ct, p);
        }

        public static bool ThemCTPhieuThuePhong(ChiTietPhieuThueDTO ct, KhachHangDTO kh)
        {
            return PhieuThueDAO.ThemCTPhieuThuePhong(ct, kh);
        }

        public static List<PhieuThuePhongDTO> LayPhongTuongUng(int makh)
        {
            return PhieuThueDAO.LayPhongTuongUng(makh);
        }
    }
}