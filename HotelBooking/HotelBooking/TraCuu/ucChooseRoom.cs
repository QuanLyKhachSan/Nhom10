using BUS;
using DTO;
using HotelBooking.LuuTru;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HotelBooking.TraCuu
{
    public partial class ucChooseRoom : UserControl
    {
        private List<PhongDTO> lstRoom = new List<PhongDTO>();

        public ucChooseRoom()
        {
            InitializeComponent();
        }

        private void ThietLapTextBox()
        {
            txtMaPhong.Text = "";
            txtLoaiPhong.Text = "";
            txtGhiChu.Text = "";
            txtDonGia.Text = "";
        }

        private void LayDanhSachPhongTrong()
        {
            lstRoom = new List<PhongDTO>();
            //int numlp1 = PhongBUS.LaySLPhongTrongTheoLoai("LP001");
            //int numlp2 = PhongBUS.LaySLPhongTrongTheoLoai("LP002");
            //int numlp3 = PhongBUS.LaySLPhongTrongTheoLoai("LP003");
            //Lấy mã phòng, loại phòng chứa vào một list
            lstRoom = PhongBUS.LayMaPhongLoaiPhong();
            //Lấy danh mục loại phòng
            List<PhongDTO> dmlst = new List<PhongDTO>();
            dmlst = PhongBUS.LayDanhSachLoaiPhong();
            for (int i = 0; i < dmlst.Count; i++)
            {
                string lp = dmlst[i].MaLoaiPhong;
                int num = PhongBUS.LaySLPhongTrongTheoLoai(lp);
                DirectoryInfo dir;
                if (i < 3)
                {
                    dir = new DirectoryInfo(@"..\..\Images\" + lp + "");
                }
                else
                {
                    dir = new DirectoryInfo(@"..\..\Images\LPKhac");
                }
                for (int j = 1; j <= num; j++)
                {
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        try
                        {
                            this.imgListRoom.Images.Add(Image.FromFile(file.FullName));
                        }
                        catch
                        {
                            Console.WriteLine("This is not an image file");
                        }
                    }
                }
            }

            //DirectoryInfo dir1 = new DirectoryInfo(@"..\..\Images\ImgLoaiPhong1");
            //for (int i = 1; i <= numlp1; i++)
            //{
            //    foreach (FileInfo file in dir1.GetFiles())
            //    {
            //        try
            //        {
            //            this.imgListRoom.Images.Add(Image.FromFile(file.FullName));
            //        }
            //        catch
            //        {
            //            Console.WriteLine("This is not an image file");
            //        }
            //    }
            //}

            //DirectoryInfo dir2 = new DirectoryInfo(@"..\..\Images\ImgLoaiPhong2");
            //for (int i = 1; i <= numlp2; i++)
            //{
            //    foreach (FileInfo file in dir2.GetFiles())
            //    {
            //        try
            //        {
            //            this.imgListRoom.Images.Add(Image.FromFile(file.FullName));
            //        }
            //        catch
            //        {
            //            Console.WriteLine("This is not an image file");
            //        }
            //    }
            //}

            //DirectoryInfo dir3 = new DirectoryInfo(@"..\..\Images\ImgLoaiPhong3");
            //for (int i = 1; i <= numlp3; i++)
            //{
            //    foreach (FileInfo file in dir3.GetFiles())
            //    {
            //        try
            //        {
            //            this.imgListRoom.Images.Add(Image.FromFile(file.FullName));
            //        }
            //        catch
            //        {
            //            Console.WriteLine("This is not an image file");
            //        }
            //    }
            //}

            this.lsvRoom.View = View.LargeIcon;
            this.imgListRoom.ImageSize = new Size(50, 50);
            this.lsvRoom.LargeImageList = this.imgListRoom;

            for (int j = 0; j < this.imgListRoom.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                string a = Convert.ToString(j);
                item.Text = a;
                this.lsvRoom.Items.Add(item);
            }
        }

        private void ucChooseRoom_Load(object sender, EventArgs e)
        {
            LayDanhSachPhongTrong();
        }

        private void lsvRoom_Click(object sender, EventArgs e)
        {
            int stritem = int.Parse(lsvRoom.SelectedItems[0].SubItems[0].Text);
            txtMaPhong.Text = Convert.ToString(lstRoom[stritem].MaPhong);
            txtLoaiPhong.Text = lstRoom[stritem].TenLoaiPhong;
            txtGhiChu.Text = lstRoom[stritem].GhiChu;
            txtDonGia.Text = Convert.ToString(lstRoom[stritem].DonGia);
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn phòng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ucRentRoom.room = txtMaPhong.Text;
                ucRentRoom.roomtype = txtLoaiPhong.Text;
                frmRentRoom _frmRentRoom = new frmRentRoom();
                _frmRentRoom.Show();

                lsvRoom.Enabled = false;

                ThietLapTextBox();
                btnDatPhong.Enabled = false;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lsvRoom.Items.Clear();
            imgListRoom.Images.Clear();
            LayDanhSachPhongTrong();
            lsvRoom.Enabled = true;
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPhong.Text != "")
            {
                btnDatPhong.Enabled = true;
            }
        }
    }
}