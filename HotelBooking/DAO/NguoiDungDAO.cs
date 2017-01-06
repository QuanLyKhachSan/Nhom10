using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class NguoiDungDAO
    {
        private static QUAN_LY_KHACH_SANEntities context = new QUAN_LY_KHACH_SANEntities();

        public static List<NguoiDungDTO> LayThongTinNguoiDung()
        {
            var query = (from n in context.NGUOI_DUNG
                         select new NguoiDungDTO
                         {
                             TenDangNhap = n.TenTaiKhoan,
                             MatKhau = n.MatKhau,
                             PhanQuyen = n.PhanQuyen,
                         });
            return query.ToList();
        }

        public static int DemSoLuongTK()
        {
            int query = (from n in context.NGUOI_DUNG
                         select new NguoiDungDTO
                         {
                         }).Count();
            return query;
        }
    }
}