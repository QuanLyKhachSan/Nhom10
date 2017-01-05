using DTO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DAO
{
    public class ThamSoDAO
    {
        private static QUAN_LY_KHACH_SANEntities context = new QUAN_LY_KHACH_SANEntities();

        public static bool CapNhatTSSoKhachToiDa(double value)
        {
            SqlParameter slkhachtoida = new SqlParameter("@SlKhachToiDa", value);

            try
            {
                context.Database.ExecuteSqlCommand("spCapNhatTSSoKhachToiDa @SlKhachToiDa", slkhachtoida);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhatTSHeSo(double value)
        {
            SqlParameter heso = new SqlParameter("@HeSo", value);

            try
            {
                context.Database.ExecuteSqlCommand("spCapNhatTSHeSo @HeSo", heso);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhatTSPhuThu(double value)
        {
            SqlParameter phuthu = new SqlParameter("@PhuThu", value);

            try
            {
                context.Database.ExecuteSqlCommand("spCapNhatTSPhuThu @PhuThu", phuthu);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<ThamSoDTO> LayGiaTriThamSo()
        {
            var query = (from t in context.THAM_SO
                         select new ThamSoDTO
                         {
                             PhuThu = t.PhuThu,
                             HeSo = t.HeSo,
                             SLKhachToiDa = t.SoKhachToiDa,
                         });
            return query.ToList();
        }
    }
}