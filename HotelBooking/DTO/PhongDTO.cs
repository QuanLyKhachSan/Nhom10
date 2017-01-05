namespace DTO
{
    public class PhongDTO
    {
        private int? _MaPhong;

        public int? MaPhong
        {
            get { return _MaPhong; }
            set { _MaPhong = value; }
        }

        private string _TinhTrang;

        public string TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }

        private string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }

        private string _MaLoaiPhong;

        public string MaLoaiPhong
        {
            get { return _MaLoaiPhong; }
            set { _MaLoaiPhong = value; }
        }

        private string _TenLoaiPhong;

        public string TenLoaiPhong
        {
            get { return _TenLoaiPhong; }
            set { _TenLoaiPhong = value; }
        }

        private decimal? _DonGia;

        public decimal? DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
    }
}