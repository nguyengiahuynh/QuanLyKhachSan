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

namespace MidTerm
{
    public partial class ThemPhong : Form
    {
        public ThemPhong()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin phía trên!! Xin nhập lại");
                return;
            }
            else
            {
                PhongBUS phongBUS = new PhongBUS();
                Phong phong = new Phong();
                phong.maPhong = txtMaPhong.Text;
                phong.loaiPhong = int.Parse(txtLoaiPhong.selectedValue);
                phong.tinhTrang = int.Parse(txtTinhTrang.selectedValue);
                if (phongBUS.KiemTraMaPhong(phong))
                {
                    txtMaPhong.Text = "";
                    txtMaPhong.Focus();
                    MessageBox.Show("Phòng cần thêm đã tồn tại trong danh sách!! Xin nhập lại");
                }
                else
                {
                    phongBUS.ThemPhong(phong);
                    this.Close();
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
