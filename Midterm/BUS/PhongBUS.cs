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

        public bool KiemTraMaPhong(Phong phong)
        {
            try
            {
                return phongDAO.KiemTraMaPhong(phong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void XoaPhong(Phong phong)
        {
            try
            {
                phongDAO.XoaPhong(phong);
                MessageBox.Show("Xóa phòng thành công");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Phong LayThongTinPhongQuaMaPhong(string maPhong)
        {
            try
            {
                return phongDAO.LayThongTinPhongQuaMaPhong(maPhong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SuaPhong(Phong phong)
        {
            try
            {
                phongDAO.SuaPhong(phong);
                MessageBox.Show("Sửa thông tin phòng thành công");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable TimPhong(Phong phong)
        {
            try
            {
                return phongDAO.TimPhong(phong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
