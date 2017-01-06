using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using HotelBooking.BaoCao;
using HotelBooking.HeThong;
using HotelBooking.LuuTru;
using HotelBooking.NguoiDung;
using HotelBooking.TraCuu;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotelBooking
{
    public partial class frmMain : RibbonForm
    {
        public static string user = string.Empty;
        public static string admin = string.Empty;

        public frmMain()
        {
            InitializeComponent();
            InitSkinGallery();
            InitGrid();
        }

        private void InitSkinGallery()
        {
            ////SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private BindingList<Person> gridDataList = new BindingList<Person>();

        private void InitGrid()
        {
            //gridDataList.Add(new Person("John", "Smith"));
            //gridDataList.Add(new Person("Gabriel", "Smith"));
            //gridDataList.Add(new Person("Ashley", "Smith", "some comment"));
            //gridDataList.Add(new Person("Adrian", "Smith", "some comment"));
            //gridDataList.Add(new Person("Gabriella", "Smith", "some comment"));
            ////gridControl.DataSource = gridDataList;
        }

        //Load form
        private void LoadForm()
        {
            pnlMain.Controls.Clear();
            ucBackground _ucBackground = new ucBackground();
            _ucBackground.Show();
            _ucBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Controls.Add(_ucBackground);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            siInfo.Caption = user;
            //if (string.IsNullOrEmpty(admin))
            //{
            //    UpdateGroup.Visible = false;
            //    itemChangeRules.Visible = false;
            //}
            LoadForm();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Bạn có thoát khỏi chương trình không?", "Hỏi", buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void iClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadForm();
        }

        private void iLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            frmLogin _frmLogin = new frmLogin();
            _frmLogin.Show();
        }

        private void iIntro_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            ucIntro _ucucIntro = new ucIntro();
            _ucucIntro.Show();
            _ucucIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Controls.Add(_ucucIntro);
        }

        private void iHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Help.ShowHelp(this, helpProvider.HelpNamespace, HelpNavigator.TableOfContents);
            //Help.ShowHelp(this, "--file:e:\\HotelBooking\\HotelBooking\\bin\\Debug\\help.chm");
            //System.Diagnostics.Process.Start(@"E:\HotelBooking\HotelBooking\Help\help.chm");
        }

        #region hàm dùng chung

        private void RentRoom()
        {
            pnlMain.Controls.Clear();
            ucChooseRoom _ucChooseRoom = new ucChooseRoom();
            _ucChooseRoom.Show();
            _ucChooseRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Controls.Add(_ucChooseRoom);
        }

        private void Payment()
        {
            pnlMain.Controls.Clear();
            ucBill _ucBill = new ucBill();
            _ucBill.Show();
            _ucBill.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Controls.Add(_ucBill);
        }

        private void Room()
        {
            pnlMain.Controls.Clear();
            ucRoom _ucRoom = new ucRoom();
            _ucRoom.Show();
            _ucRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Controls.Add(_ucRoom);
        }

        private void RoomType()
        {
            pnlMain.Controls.Clear();
            ucRoomType _ucRoomType = new ucRoomType();
            _ucRoomType.Show();
            _ucRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Controls.Add(_ucRoomType);
        }

        private void SearchRoom()
        {
            pnlMain.Controls.Clear();
            ucSearchRoom _ucSearchRoom = new ucSearchRoom();
            _ucSearchRoom.Show();
            _ucSearchRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Controls.Add(_ucSearchRoom);
        }

        private void SearchCustomer()
        {
            pnlMain.Controls.Clear();
            ucSearchCustomer _ucSearchCustomer = new ucSearchCustomer();
            _ucSearchCustomer.Show();
            _ucSearchCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Controls.Add(_ucSearchCustomer);
        }

        private void Sales()
        {
            frmSales fr = new frmSales();
            fr.Show();
        }

        private void Density()
        {
            frmDensity fr = new frmDensity();
            fr.Show();
        }

        #endregion hàm dùng chung

        #region cập nhật

        //Room
        private void itemRoom_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Room();
        }

        //Room type
        private void itemRoomType_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RoomType();
        }

        #endregion cập nhật

        #region quản lý

        //Rent room
        private void itemRentRoom_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RentRoom();
        }

        //Change rules
        private void itemChangeRules_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmParam _frmParam = new frmParam();
            _frmParam.Show();
        }

        private void itemBill_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Payment();
        }

        #endregion quản lý

        #region tìm kiếm

        //Search room
        private void itemSearchRoom_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SearchRoom();
        }

        //Search customer
        private void itemSearchCustomer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SearchCustomer();
        }

        #endregion tìm kiếm

        #region báo cáo

        private void itemSales_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Sales();
        }

        private void itemDensity_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Density();
        }

        #endregion báo cáo

        #region phím tắt

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Control | Keys.Shift | Keys.D):
                    RentRoom();
                    break;

                case (Keys.Control | Keys.Shift | Keys.T):
                    Payment();
                    break;

                case (Keys.Control | Keys.Alt | Keys.P):
                    if (int.Parse(admin) == 0)
                    {
                        Room();
                    }
                    break;

                case (Keys.Control | Keys.Alt | Keys.L):
                    if (int.Parse(admin) == 0)
                    {
                        RoomType();
                    }
                    break;

                case (Keys.Control | Keys.Alt | Keys.Shift | Keys.R):
                    SearchRoom();
                    break;

                case (Keys.Control | Keys.Alt | Keys.Shift | Keys.K):
                    SearchCustomer();
                    break;

                case (Keys.Control | Keys.D):
                    Sales();
                    break;

                case (Keys.Control | Keys.M):
                    Density();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion phím tắt
    }
}