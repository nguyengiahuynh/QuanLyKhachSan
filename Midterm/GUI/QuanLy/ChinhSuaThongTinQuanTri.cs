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
    public partial class ChinhSuaThongTinQuanTri : Form
    {
        string CMND;
        public ChinhSuaThongTinQuanTri(string chungMinhNhanDan)
        {
            InitializeComponent();
            CMND = chungMinhNhanDan;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtCMND.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtGioiTinh.selectedIndex = 0;
            txtCapBac.selectedIndex = 0;
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtCMND.Focus();
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin phía trên");
                return;
            }
            else
            {
                QuanTriBUS quanTriBUS = new QuanTriBUS();
                QuanTri quanTri = new QuanTri();
                quanTri.cmnd = txtCMND.Text;
                quanTri.ten = txtTen.Text;
                quanTri.sdt = txtSDT.Text;
                quanTri.diaChi = txtDiaChi.Text;
                quanTri.gioiTinh = txtGioiTinh.selectedValue.ToString();
                quanTri.capBac = Int32.Parse(txtCapBac.selectedValue.ToString());
                quanTri.username = txtUsername.Text;
                quanTri.password = txtPassword.Text;
                if (txtUsername.Text != quanTriBUS.LayThongTinNhanVienQuaCMND(CMND).username)
                {
                    if (quanTriBUS.KiemTraUsername(quanTri))
                    {
                        MessageBox.Show("Username của người bạn vừa sửa đã trùng với người khác!! Xin nhập lại");
                        txtUsername.Text = "";
                        txtUsername.Focus();
                        return;
                    }
                }
                quanTriBUS.SuaNhanVien(quanTri);
                this.Close();
            }
        }

        private void ChinhSuaThongTinQuanTri_Load(object sender, EventArgs e)
        {
            QuanTriBUS quanTriBUS = new QuanTriBUS();
            txtCMND.Text = quanTriBUS.LayThongTinNhanVienQuaCMND(CMND).cmnd;
            txtTen.Text = quanTriBUS.LayThongTinNhanVienQuaCMND(CMND).ten;
            txtSDT.Text = quanTriBUS.LayThongTinNhanVienQuaCMND(CMND).sdt;
            txtDiaChi.Text = quanTriBUS.LayThongTinNhanVienQuaCMND(CMND).diaChi;
            if (quanTriBUS.LayThongTinNhanVienQuaCMND(CMND).gioiTinh == "Nam")
                txtGioiTinh.selectedIndex = 0;
            else
                txtGioiTinh.selectedIndex = 1;
            if (quanTriBUS.LayThongTinNhanVienQuaCMND(CMND).capBac == 1)
                txtCapBac.selectedIndex = 0;
            else
                txtCapBac.selectedIndex = 1;
            txtUsername.Text = quanTriBUS.LayThongTinNhanVienQuaCMND(CMND).username;
            txtPassword.Text = quanTriBUS.LayThongTinNhanVienQuaCMND(CMND).password;
        }
    }
}
