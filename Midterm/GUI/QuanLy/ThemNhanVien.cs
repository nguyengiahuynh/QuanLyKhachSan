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
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        

        private void btnThemNV_Click(object sender, EventArgs e)
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
                quanTri.gioiTinh = txtGioiTinh.selectedValue;
                quanTri.capBac = int.Parse(txtCapBac.selectedValue);
                quanTri.username = txtUsername.Text;
                quanTri.password = txtPassword.Text;
                if (quanTriBUS.KiemTraCMND(quanTri) || quanTriBUS.KiemTraUsername(quanTri))
                {
                    txtCMND.Text = "";
                    txtTen.Text = "";
                    txtSDT.Text = "";
                    txtDiaChi.Text = "";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtCMND.Focus();
                    MessageBox.Show("Người cần thêm có CMND hoặc Username đã tồn tại trong danh sách!! Xin nhập lại");
                }
                else
                {
                    quanTriBUS.ThemNhanVien(quanTri);
                    this.Close();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
       


      
     
      

      
    }
}
