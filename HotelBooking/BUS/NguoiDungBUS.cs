using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class NguoiDungBUS
    {
        public static List<NguoiDungDTO> LayThongTinNguoiDung()
        {
            return NguoiDungDAO.LayThongTinNguoiDung();
        }

        public static int DemSoLuongTK()
        {
            return NguoiDungDAO.DemSoLuongTK();
        }
    }
}