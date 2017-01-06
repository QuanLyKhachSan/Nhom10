using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace HotelBooking.NguoiDung
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private string user = "";
        private string pass = "";
        private int numUser = 0;

        #region

        public string GiaiMaMatKhau(string Message, string Passphrase)
        {
            byte[] Results;

            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. Bam chuoi su dung MD5

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();

            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

            // Step 2. Tao doi tuong TripleDESCryptoServiceProvider moi

            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Cai dat bo giai ma

            TDESAlgorithm.Key = TDESKey;

            TDESAlgorithm.Mode = CipherMode.ECB;

            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert chuoi (Message) thanh dang byte[]

            byte[] DataToDecrypt = Convert.FromBase64String(Message);

            // Step 5. Bat dau giai ma chuoi

            try
            {
                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();

                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                // Xoa moi thong tin ve Triple DES va HashProvider de dam bao an toan

                TDESAlgorithm.Clear();

                HashProvider.Clear();
            }

            // Step 6. Tra ve ket qua bang dinh dang UTF8

            return UTF8.GetString(Results);
        }

        #endregion

        private List<NguoiDungDTO> lst = NguoiDungBUS.LayThongTinNguoiDung();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lst = NguoiDungBUS.LayThongTinNguoiDung();

            //Dem so luong tai khoan
            numUser = NguoiDungBUS.DemSoLuongTK();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                user = lst[i].TenDangNhap;
                pass = lst[i].MatKhau;

                user = user.TrimEnd();
                pass = pass.TrimEnd();

                pass = GiaiMaMatKhau(pass, "BuiDucQuan");

                if (txtUserName.Text == user && txtUserPass.Text == pass)
                {
                    this.Hide();
                    frmMain.user = txtUserName.Text;
                    frmMain.admin = lst[i].PhanQuyen.ToString();
                    frmMain _frmMain = new frmMain();
                    _frmMain.Show();
                }
            }
        }
    }
}