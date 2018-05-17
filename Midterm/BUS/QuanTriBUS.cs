using MidTerm.DAO;
using MidTerm.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm.BUS
{
    class QuanTriBUS
    {
        QuanTriDAO quanTriDAO = new QuanTriDAO();

        public DataTable LayDanhSachNhanVien()
        {
            try
            {
                return quanTriDAO.LayDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ThemNhanVien(QuanTri quanTri)
        {
            try
            {
                quanTriDAO.ThemNhanVien(quanTri);
                MessageBox.Show("Thêm nhân viên mới thành công");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
