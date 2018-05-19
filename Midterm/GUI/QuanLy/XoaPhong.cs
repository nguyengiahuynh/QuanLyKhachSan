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
    public partial class XoaPhong : Form
    {
        string MaPhong;
        public XoaPhong(string ma)
        {
            InitializeComponent();
            MaPhong = ma;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "")
            {
                txtMaPhong.Text = "";
                txtMaPhong.Focus();
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin phía trên");
                return;
            }
            else
            {
                PhongBUS phongBUS = new PhongBUS();
                Phong phong = new Phong();
                phong.maPhong = txtMaPhong.Text;
                phong.loaiPhong = -1;
                phong.tinhTrang = -1;
                if (!phongBUS.KiemTraMaPhong(phong))
                {
                    txtMaPhong.Text = "";
                    txtMaPhong.Focus();
                    MessageBox.Show("Phòng cần xóa không tồn tại trong danh sách!! Xin nhập lại");
                }
                else
                {
                    phongBUS.XoaPhong(phong);
                    this.Close();
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XoaPhong_Load(object sender, EventArgs e)
        {
            txtMaPhong.Text = MaPhong;
        }

      
    }
}
