using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class HoaDonBUS
    {
        public static List<HoaDonDTO> LayMaPhongDaThue()
        {
            return HoaDonDAO.LayMaPhongDaThue();
        }

        public static List<HoaDonDTO> LayThongTinThuePhong(HoaDonDTO infor)
        {
            return HoaDonDAO.LayThongTinThuePhong(infor);
        }

        public static bool TinhSoNgayDaThue(HoaDonDTO infor)
        {
            return HoaDonDAO.TinhSoNgayDaThue(infor);
        }

        public static List<HoaDonDTO> LaySoNgayDaThue()
        {
            return HoaDonDAO.LaySoNgayDaThue();
        }

        public static int LaySoLuongKhach(int maphieuthue)
        {
            return HoaDonDAO.LaySoLuongKhach(maphieuthue);
        }

        public static List<HoaDonDTO> TinhPhuThu(int num)
        {
            return HoaDonDAO.LayGiaTriPhuThu();
        }

        public static int DemSLKhachNuocNgoai(HoaDonDTO infor)
        {
            return HoaDonDAO.DemSLKhachNuocNgoai(infor);
        }

        public static List<HoaDonDTO> TinhHeSo()
        {
            return HoaDonDAO.TinhHeSo();
        }

        public static List<HoaDonDTO> KhachPT_KhachNG()
        {
            return HoaDonDAO.KhachPT_KhachNG();
        }

        public static decimal ThanhTien(int snt, decimal dg, decimal pt, decimal hs)
        {
            decimal thanhtien = 0;
            if (snt == 0)
            {
                return (thanhtien = dg);
            }
            else
            {
                thanhtien = ((snt * dg));
                thanhtien += (dg * pt);
                if (hs != 0)
                {
                    thanhtien *= hs;
                    return thanhtien;
                }
                else
                {
                    return thanhtien;
                }
            }
        }

        public static int? LayMaHDCuoiCung()
        {
            return HoaDonDAO.LayMaHDCuoiCung();
        }

        public static List<HoaDonDTO> LayMaPhieuThue(int maphong)
        {
            return HoaDonDAO.LayMaPhieuThue(maphong);
        }

        public static bool LapHoaDon(HoaDonDTO inforKH)
        {
            return HoaDonDAO.LapHoaDon(inforKH);
        }

        public static bool LapChiTietHoaDon(HoaDonDTO inforKH, HoaDonDTO inforHD)
        {
            return HoaDonDAO.LapChiTietHoaDon(inforKH, inforHD);
        }

        public static bool XoaChiTietPhieuThue(HoaDonDTO inforHD)
        {
            return HoaDonDAO.XoaChiTietPhieuThue(inforHD);
        }

        public static bool XoaPhieuThue(HoaDonDTO inforHD)
        {
            return HoaDonDAO.XoaPhieuThue(inforHD);
        }
    }
}