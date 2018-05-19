using MidTerm.BUS;
using MidTerm.DTO;
using MidTerm.GUI.QuanLy;
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
    public partial class QuanLyNhanVien : Form
    {
        string username;
        string CMND = "";
        public QuanLyNhanVien(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            CMND = "";
            QuanTriBUS quanTriBUS = new QuanTriBUS();
            bunifuCustomDataGrid1.DataSource = quanTriBUS.LayDanhSachNhanVien();
            string hoTen = quanTriBUS.LayThongTinMotNhanVien(username).ten;
            label2.Text = "Xin chào! " + hoTen;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (CMND == "")
            {
                MessageBox.Show("Bạn chưa chọn người cần chỉnh sửa thông tin!!");
                return;
            }
            ChinhSuaThongTinQuanTri chinhSua = new ChinhSuaThongTinQuanTri(CMND);
            chinhSua.ShowDialog();
            QuanLyNhanVien_Load(sender, e);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ThemNhanVien themNhanVien = new ThemNhanVien();
            themNhanVien.ShowDialog();
            QuanLyNhanVien_Load(sender, e);
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard(username);
            dash.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien qlnv = new QuanLyNhanVien(username);
            qlnv.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyPhong qlp = new QuanLyPhong(username);
            qlp.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn dangXuat = new SignIn();
            dangXuat.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoCao bc = new BaoCao(username);
            bc.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            XoaQuanTri xoaQuanTri = new XoaQuanTri(CMND);
            xoaQuanTri.ShowDialog();
            QuanLyNhanVien_Load(sender, e);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            ThongTinQuanTri ttqt = new ThongTinQuanTri(username);
            ttqt.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                MessageBox.Show("Bạn chưa điền CMND người cần tìm!!");
                return;
            }
            else
            {
                QuanTriBUS quanTriBUS = new QuanTriBUS();
                QuanTri quanTri = new QuanTri();
                quanTri.cmnd = txtTim.Text;
                quanTri.ten = "";
                quanTri.sdt = "";
                quanTri.diaChi = "";
                quanTri.gioiTinh = "";
                quanTri.capBac = 0;
                quanTri.username = "";
                quanTri.password = "";
                if (!quanTriBUS.KiemTraCMND(quanTri))
                {
                    txtTim.Text = "";
                    txtTim.Focus();
                    MessageBox.Show("Người cần tìm không tồn tại trong danh sách!! Xin nhập lại");
                }
                else
                {
                    bunifuCustomDataGrid1.DataSource = quanTriBUS.TimNhanVien(quanTri);
                }
            }
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            QuanTriBUS quanTriBUS = new QuanTriBUS();
            bunifuCustomDataGrid1.DataSource = quanTriBUS.LayDanhSachNhanVien();
        }

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.CurrentRow.Index != -1)
            {
                CMND = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn si = new SignIn();
            si.ShowDialog();
        }

      
    }
}
