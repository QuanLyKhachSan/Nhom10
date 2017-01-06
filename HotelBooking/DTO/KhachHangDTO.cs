namespace DTO
{
    public class KhachHangDTO
    {
        private int _MaKH;

        public int MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        public string _TenKhachHang;

        public string TenKhachHang
        {
            get { return _TenKhachHang; }
            set { _TenKhachHang = value; }
        }

        public string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        private string _CMND;

        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }

        private string _LoaiKhach;

        public string LoaiKhach
        {
            get { return _LoaiKhach; }
            set { _LoaiKhach = value; }
        }

        private string _MaLoaiKhach;

        public string MaLoaiKhach
        {
            get { return _MaLoaiKhach; }
            set { _MaLoaiKhach = value; }
        }
    }
}