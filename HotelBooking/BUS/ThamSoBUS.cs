using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class ThamSoBUS
    {
        public static bool CapNhatTSSoKhachToiDa(double value)
        {
            return ThamSoDAO.CapNhatTSSoKhachToiDa(value);
        }

        public static bool CapNhatTSHeSo(double value)
        {
            return ThamSoDAO.CapNhatTSHeSo(value);
        }

        public static bool CapNhatTSPhuThu(double value)
        {
            return ThamSoDAO.CapNhatTSPhuThu(value);
        }

        public static List<ThamSoDTO> LayGiaTriThamSo()
        {
            return ThamSoDAO.LayGiaTriThamSo();
        }
    }
}