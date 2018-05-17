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
    class PhongBUS
    {
        PhongDAO phongDAO = new PhongDAO();

        public DataTable LayDanhSachPhong()
        {
            try
            {
                return phongDAO.LayDanhSachPhong();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ThemPhong(Phong phong)
        {
            try
            {
                phongDAO.ThemPhong(phong);
                MessageBox.Show("Thêm phòng mới thành công");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
