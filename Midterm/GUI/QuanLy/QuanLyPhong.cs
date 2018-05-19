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
    public partial class QuanLyPhong : Form
    {
        string username;
        string MaPhong = "";
        public QuanLyPhong(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ThemPhong themPhong = new ThemPhong();
            themPhong.ShowDialog();
            QuanLyPhong_Load(sender, e);
        }

        public void QuanLyPhong_Load(object sender, EventArgs e)
        {
            MaPhong = "";
            PhongBUS phongBUS = new PhongBUS();
            bunifuCustomDataGrid1.DataSource = phongBUS.LayDanhSachPhong();
            QuanTriBUS quanTriBUS = new QuanTriBUS();
            string hoTen = quanTriBUS.LayThongTinMotNhanVien(username).ten;
            label2.Text = "Xin chào! " + hoTen;
        }

        public void HienThi(DataTable a)
        {
            bunifuCustomDataGrid1.DataSource = a;

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
            XoaPhong xoaPhong = new XoaPhong(MaPhong);
            xoaPhong.ShowDialog();
            QuanLyPhong_Load(sender, e);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            ThongTinQuanTri ttqt = new ThongTinQuanTri(username);
            ttqt.Show();
        }

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.CurrentRow.Index != -1)
            {
                MaPhong = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            PhongBUS phongBUS = new PhongBUS();
            bunifuCustomDataGrid1.DataSource = phongBUS.LayDanhSachPhong();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (MaPhong == "")
            {
                MessageBox.Show("Bạn chưa chọn phòng cần chỉnh sửa thông tin!!");
                return;
            }
            ChinhSuaThongTinPhong chinhSua = new ChinhSuaThongTinPhong(MaPhong);
            chinhSua.ShowDialog();
            QuanLyPhong_Load(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                MessageBox.Show("Bạn chưa điền mã phòng của phòng cần tìm!!");
                return;
            }
            else
            {
                PhongBUS phongBUS = new PhongBUS();
                Phong phong = new Phong();
                phong.maPhong = txtTim.Text;
                phong.tinhTrang = -1;
                phong.loaiPhong = -1;
                if (!phongBUS.KiemTraMaPhong(phong))
                {
                    txtTim.Text = "";
                    txtTim.Focus();
                    MessageBox.Show("Phòng cần tìm không tồn tại trong danh sách!! Xin nhập lại");
                }
                else
                {
                    bunifuCustomDataGrid1.DataSource = phongBUS.TimPhong(phong);
                }
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
