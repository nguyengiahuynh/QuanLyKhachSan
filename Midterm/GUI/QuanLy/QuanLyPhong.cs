using MidTerm.BUS;
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
        public QuanLyPhong()
        {
            InitializeComponent();
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
            themPhong.Show();
        }

        public void QuanLyPhong_Load(object sender, EventArgs e)
        {
            PhongBUS phongBUS = new PhongBUS();

            bunifuCustomDataGrid1.DataSource = phongBUS.LayDanhSachPhong();
        }

        public void HienThi(DataTable a)
        {
            bunifuCustomDataGrid1.DataSource = a;

        }
        
    }
}
