﻿using MidTerm.BUS;
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
    public partial class BaoCao : Form
    {
        string username;
        public BaoCao(string user)
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

        private void BaoCao_Load(object sender, EventArgs e)
        {
            QuanTriBUS quanTriBUS = new QuanTriBUS();
            string hoTen = quanTriBUS.LayThongTinMotNhanVien(username).ten;
            HoaDonBUS hoaDonBUS = new HoaDonBUS();
            bunifuCustomDataGrid1.DataSource = hoaDonBUS.LayDanhSachHoaDon();
            label2.Text = "Xin chào! " + hoTen;
        }

        

        private void label2_Click_1(object sender, EventArgs e)
        {
            ThongTinQuanTri ttqt = new ThongTinQuanTri(username);
            ttqt.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            DoanhThu01 dt = new DoanhThu01();
            dt.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DoanhThu02 dt = new DoanhThu02();
            dt.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DoanhThu03 dt = new DoanhThu03();
            dt.ShowDialog();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DoanhThu04 dt = new DoanhThu04();
            dt.ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn si = new SignIn();
            si.ShowDialog();
        }
    }
}
