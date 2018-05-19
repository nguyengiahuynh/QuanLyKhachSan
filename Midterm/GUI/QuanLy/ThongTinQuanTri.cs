using MidTerm.BUS;
using MidTerm.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm.GUI.QuanLy
{
    public partial class ThongTinQuanTri : Form
    {
        string username;
        public ThongTinQuanTri(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongTinQuanTri_Load(object sender, EventArgs e)
        {
            QuanTriBUS quanTriBUS = new QuanTriBUS();
            txtCMND.Text = quanTriBUS.LayThongTinMotNhanVien(username).cmnd;
            txtTen.Text = quanTriBUS.LayThongTinMotNhanVien(username).ten;
            txtSDT.Text = quanTriBUS.LayThongTinMotNhanVien(username).sdt;
            txtDiaChi.Text = quanTriBUS.LayThongTinMotNhanVien(username).diaChi;
            txtGioiTinh.Text = quanTriBUS.LayThongTinMotNhanVien(username).gioiTinh;
            txtCapBac.Text = quanTriBUS.LayThongTinMotNhanVien(username).capBac.ToString();
            txtUsername.Text = quanTriBUS.LayThongTinMotNhanVien(username).username;
            txtPassword.Text = quanTriBUS.LayThongTinMotNhanVien(username).password;
        }
    }
}
