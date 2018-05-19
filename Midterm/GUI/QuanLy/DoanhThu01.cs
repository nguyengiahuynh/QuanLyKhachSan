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

namespace MidTerm.GUI.QuanLy
{
    public partial class DoanhThu01 : Form
    {
        public DoanhThu01()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtNam.Text == "" || txtThang.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin phía trên!! Xin nhập lại");
                return;
            }
            HoaDonBUS hoaDonBUS = new HoaDonBUS();
            if (!hoaDonBUS.KiemTraThang(Int32.Parse(txtThang.Text)) || !hoaDonBUS.KiemTraNam(Int32.Parse(txtNam.Text)))
            {
                MessageBox.Show("Tháng hoặc năm bạn cần xem không có hóa đơn nào được xuất nên không có doanh thu!! Xin nhập lại");
                return;
            }
            bunifuCustomDataGrid1.DataSource = hoaDonBUS.DoanhThu1(Int32.Parse(txtThang.Text), Int32.Parse(txtNam.Text));
        }

        
    }
}
