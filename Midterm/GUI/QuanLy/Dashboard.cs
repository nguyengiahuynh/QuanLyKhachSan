using MidTerm.BUS;
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
    public partial class Dashboard : Form
    {
        string username;
        public Dashboard(string user)
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

        private void Dashboard_Load(object sender, EventArgs e)
        {  
            QuanTriBUS quanTriBUS = new QuanTriBUS();
            string hoTen = quanTriBUS.LayThongTinMotNhanVien(username).ten;
            label2.Text = "Xin chào! " + hoTen;

        }

       
        private void label2_Click_1(object sender, EventArgs e)
        {
            ThongTinQuanTri ttqt = new ThongTinQuanTri(username);
            ttqt.Show();
        }
    }
}
