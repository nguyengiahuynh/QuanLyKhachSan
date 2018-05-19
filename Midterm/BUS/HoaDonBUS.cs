using MidTerm.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.BUS
{
    class HoaDonBUS
    {
        HoaDonDAO hoaDonDAO = new HoaDonDAO();

        public DataTable LayDanhSachHoaDon()
        {
            try
            {
                return hoaDonDAO.LayDanhSachHoaDon();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DoanhThu1(int thang, int nam)
        {
            try
            {
                return hoaDonDAO.DoanhThu1(thang, nam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DoanhThu2(int nam)
        {
            try
            {
                return hoaDonDAO.DoanhThu2(nam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DoanhThu3(int thang, int nam)
        {
            try
            {
                return hoaDonDAO.DoanhThu3(thang, nam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DoanhThu4(int nam)
        {
            try
            {
                return hoaDonDAO.DoanhThu4(nam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool KiemTraThang(int thang)
        {
            try
            {
                return hoaDonDAO.KiemTraThang(thang);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool KiemTraNam(int nam)
        {
            try
            {
                return hoaDonDAO.KiemTraNam(nam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
