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
    public partial class XoaQuanTri : Form
    {
        string CMND;
        public XoaQuanTri(string chungMinhNhanDan)
        {
            InitializeComponent();
            CMND = chungMinhNhanDan;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text == "")
            {
                txtCMND.Text = "";
                txtCMND.Focus();
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin phía trên");
                return;
            }
            else
            {
                QuanTriBUS quanTriBUS = new QuanTriBUS();
                QuanTri quanTri = new QuanTri();
                quanTri.cmnd = txtCMND.Text;
                quanTri.ten = "";
                quanTri.sdt = "";
                quanTri.diaChi = "";
                quanTri.gioiTinh = "";
                quanTri.capBac = 0;
                quanTri.username = "";
                quanTri.password = "";
                if (!quanTriBUS.KiemTraCMND(quanTri))
                {
                    txtCMND.Text = "";
                    txtCMND.Focus();
                    MessageBox.Show("Người cần xóa không tồn tại trong danh sách!! Xin nhập lại");
                }
                else
                {
                    quanTriBUS.XoaNhanVien(quanTri);
                    this.Close();
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XoaQuanTri_Load(object sender, EventArgs e)
        {
            txtCMND.Text = CMND;
        }
    }
}
