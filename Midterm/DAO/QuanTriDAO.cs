using MidTerm.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.DAO
{
    class QuanTriDAO
    {
        XL_DULIEU xlDuLieu = new XL_DULIEU();
        public DataTable LayDanhSachNhanVien()
        {
            return xlDuLieu.LayDuLieu("Select cmnd, ten, sdt, diaChi, gioiTinh, capBac from QuanTri");
        }

        public int ThemNhanVien(QuanTri quanTri)
        {
            //Xử lý dữ liệu
            string sql = string.Format("Insert Into QuanTri(cmnd, ten, sdt, diaChi, gioiTinh, username, password, capBac) Values('{0}', N'{1}','{2}', N'{3}', N'{4}', '{5}','{6}','{7}')", quanTri.cmnd, quanTri.ten, quanTri.sdt, quanTri.diaChi, quanTri.gioiTinh, quanTri.username, quanTri.password, quanTri.capBac);
            return xlDuLieu.ThucThi(sql);
        }
    }
}
