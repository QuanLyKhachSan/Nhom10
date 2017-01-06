using System;
using System.Windows.Forms;

namespace HotelBooking.LuuTru
{
    public partial class frmRentRoom : Form
    {
        public frmRentRoom()
        {
            InitializeComponent();
        }

        private void frmRentRoom_Load(object sender, EventArgs e)
        {
            pnlRentRoom.Controls.Clear();
            ucRentRoom _ucRentRoom = new ucRentRoom();
            _ucRentRoom.Show();
            _ucRentRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlRentRoom.Controls.Add(_ucRentRoom);
        }

        private void frmRentRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}