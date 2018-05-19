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
    public partial class ChinhSuaThongTinPhong : Form
    {
        string MaPhong;
        public ChinhSuaThongTinPhong(string ma)
        {
            InitializeComponent();
            MaPhong = ma;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin phía trên");
                return;
            }
            else
            {
                PhongBUS phongBUS = new PhongBUS();
                Phong phong = new Phong();
                phong.maPhong = txtMaPhong.Text;
                phong.loaiPhong = Int32.Parse(txtLoaiPhong.selectedValue.ToString());
                phong.tinhTrang = Int32.Parse(txtTinhTrang.selectedValue.ToString());
                phongBUS.SuaPhong(phong);
                this.Close();
            }
        }

        private void ChinhSuaThongTinPhong_Load(object sender, EventArgs e)
        {
            PhongBUS phongBUS = new PhongBUS();
            txtMaPhong.Text = phongBUS.LayThongTinPhongQuaMaPhong(MaPhong).maPhong;
            if (phongBUS.LayThongTinPhongQuaMaPhong(MaPhong).loaiPhong == 1)
                txtLoaiPhong.selectedIndex = 0;
            else if (phongBUS.LayThongTinPhongQuaMaPhong(MaPhong).loaiPhong == 2)
                txtLoaiPhong.selectedIndex = 1;
            else
                txtLoaiPhong.selectedIndex = 2;
            if (phongBUS.LayThongTinPhongQuaMaPhong(MaPhong).tinhTrang == 0)
                txtTinhTrang.selectedIndex = 0;
            else
                txtTinhTrang.selectedIndex = 1;
        }
    }
}
