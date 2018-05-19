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
    public partial class DoanhThu03 : Form
    {
        public DoanhThu03()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtNam.Text == "" || txtThang.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin phía trên!! Xin nhập lại");
                return;
            }
            HoaDonBUS hoaDonBUS = new HoaDonBUS();
            if (!hoaDonBUS.KiemTraNam(Int32.Parse(txtNam.Text)) || !hoaDonBUS.KiemTraThang(Int32.Parse(txtThang.Text)))
            {
                MessageBox.Show("Tháng hoặc năm bạn cần xem không có hóa đơn nào được xuất nên không có doanh thu!! Xin nhập lại");
                return;
            }
            bunifuCustomDataGrid1.DataSource = hoaDonBUS.DoanhThu3(Int32.Parse(txtThang.Text), Int32.Parse(txtNam.Text));
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
