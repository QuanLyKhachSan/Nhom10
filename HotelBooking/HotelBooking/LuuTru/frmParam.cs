using BUS;
using DTO;
using ManagePlugin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace HotelBooking.LuuTru
{
    public partial class frmParam : Form
    {
        public frmParam()
        {
            InitializeComponent();
        }

        private List<IPlugin> plugins = new List<IPlugin>();

        private void LoadPlugins()
        {
            IPlugin plugX = null;
            string[] files = Directory.GetFiles(
                Application.StartupPath + @"\AddPlugin",
                "*.dq");

            foreach (string f in files)
            {
                Assembly asm = Assembly.LoadFile(f);
                Type[] types = asm.GetTypes();
                string className1 =
                    Path.GetFileNameWithoutExtension(f) +
                    ".Coefficient";

                string className2 =
                    Path.GetFileNameWithoutExtension(f) +
                    ".MaxCus";

                string className3 =
                    Path.GetFileNameWithoutExtension(f) +
                    ".Additional";

                foreach (Type t in types)
                {
                    if (t.FullName == className1 || t.FullName == className2 || t.FullName == className3)
                        plugX = (IPlugin)Activator.CreateInstance(t);

                    plugins.Add(plugX);
                }
            }

            // Load the plugin list to combobox
            foreach (IPlugin p in plugins)
            {
                string name = p.GetName();
                cboThamSo.Items.Add(name);
            }
        }

        private void frmParam_Load(object sender, EventArgs e)
        {
            this.LoadPlugins();
            cboThamSo.SelectedIndex = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtGiaTri.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá trị tham số cần thay đổi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double value = Convert.ToDouble(txtGiaTri.Text);
                int selectedIndex = cboThamSo.SelectedIndex;

                IPlugin plugin = (IPlugin)plugins[selectedIndex];
                double success = plugin.UpdateValue(value);
                if (success == 0)
                {
                    MessageBox.Show("Cập nhật tham số không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cập nhật tham số thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cboThamSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ThamSoDTO> lst = new List<ThamSoDTO>();
            lst = ThamSoBUS.LayGiaTriThamSo();
            if (cboThamSo.SelectedIndex == 0)
            {
                txtGiaTri.Text = lst[0].PhuThu.ToString();
            }
            else if (cboThamSo.SelectedIndex == 1)
            {
                txtGiaTri.Text = lst[0].HeSo.ToString();
            }
            else if (cboThamSo.SelectedIndex == 2)
            {
                txtGiaTri.Text = lst[0].SLKhachToiDa.ToString();
            }
        }

        private void frmParam_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Bạn có muốn kết thúc phiên làm việc này không?", "Hỏi", buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}