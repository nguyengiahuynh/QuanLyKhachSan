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
        public QuanTri LayThongTinMotNhanVien(string user)
        {
            return quanTriDAO.LayThongTinMotNhanVien(user);
        }

        public int CheckSignIn(string user, string pas)
        {
            QuanTri qt = new QuanTri();
            qt = LayThongTinMotNhanVien(user);
            if (qt.password == pas)
            {
                return qt.capBac;
            }
            else return 0;
        }

        public void XoaNhanVien(QuanTri quanTri)
        {
            try
            {
                quanTriDAO.XoaNhanVien(quanTri);
                MessageBox.Show("Xóa nhân viên thành công");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool KiemTraCMND(QuanTri quanTri)
        {
            try
            {
                return quanTriDAO.KiemTraCMND(quanTri);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable TimNhanVien(QuanTri quanTri)
        {
            try
            {
                return quanTriDAO.TimNhanVien(quanTri);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SuaNhanVien(QuanTri quanTri)
        {
            try
            {
                quanTriDAO.SuaNhanVien(quanTri);
                MessageBox.Show("Sửa thông tin thành công");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public QuanTri LayThongTinNhanVienQuaCMND(string CMND)
        {
            return quanTriDAO.LayThongTinNhanVienQuaCMND(CMND);
        }

        public bool KiemTraUsername(QuanTri quanTri)
        {
            try
            {
                return quanTriDAO.KiemTraUsername(quanTri);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
