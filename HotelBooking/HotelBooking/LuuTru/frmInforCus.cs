using BUS;
using System;
using System.Windows.Forms;

namespace HotelBooking.LuuTru
{
    public partial class frmInforCus : Form
    {
        public static int idroom = 0;

        public frmInforCus()
        {
            InitializeComponent();
        }

        private void frmInforCus_Load(object sender, EventArgs e)
        {
            if (idroom != 0)
            {
                gcDSKhachHang.DataSource = KhachHangBUS.LayDSKhachThuePhong(idroom);
            }
        }
    }
}