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
        public QuanTri LayThongTinMotNhanVien(string user)
        {
            string sql = "Select * from QuanTri where username = '" + user + "'";
            var tmp = xlDuLieu.LayDuLieu(sql).AsEnumerable().Take(1).ToArray()[0].ItemArray;
            QuanTri result = new QuanTri();
            result.cmnd = tmp[0].ToString();
            result.ten = tmp[1].ToString();
            result.sdt = tmp[2].ToString();
            result.diaChi = tmp[3].ToString();
            result.gioiTinh = tmp[4].ToString();
            result.username = tmp[5].ToString();
            result.password = tmp[6].ToString();
            result.capBac = Convert.ToInt32(tmp[7]);
            return result;
        }
        public int XoaNhanVien(QuanTri quanTri)
        {
            //Xử lý dữ liệu
            string sql = string.Format("Delete from QuanTri where cmnd = '{0}'", quanTri.cmnd);
            return xlDuLieu.ThucThi(sql);
        }
        public bool KiemTraCMND(QuanTri quanTri)
        {
            string sql = string.Format("Select cmnd from QuanTri where cmnd = '{0}'", quanTri.cmnd);
            return xlDuLieu.KiemTra(sql);
        }

        public DataTable TimNhanVien(QuanTri quanTri)
        {
            string sql = string.Format("Select cmnd, ten, sdt, diaChi, gioiTinh, capBac from QuanTri where cmnd = '{0}'", quanTri.cmnd);
            return xlDuLieu.LayDuLieu(sql);
        }

        public int SuaNhanVien(QuanTri quanTri)
        {
            //Xử lý dữ liệu
            string sql = string.Format("Update QuanTri set ten = N'{0}', sdt = '{1}', diaChi = N'{2}', gioiTinh = N'{3}', username = '{4}', password = '{5}', capBac = '{6}' where cmnd = '{7}'", quanTri.ten, quanTri.sdt, quanTri.diaChi, quanTri.gioiTinh, quanTri.username, quanTri.password, quanTri.capBac, quanTri.cmnd);
            return xlDuLieu.ThucThi(sql);
        }

        public QuanTri LayThongTinNhanVienQuaCMND(string CMND)
        {
            string sql = "Select * from QuanTri where cmnd = '" + CMND + "'";
            var tmp = xlDuLieu.LayDuLieu(sql).AsEnumerable().Take(1).ToArray()[0].ItemArray;
            QuanTri result = new QuanTri();
            result.cmnd = tmp[0].ToString();
            result.ten = tmp[1].ToString();
            result.sdt = tmp[2].ToString();
            result.diaChi = tmp[3].ToString();
            result.gioiTinh = tmp[4].ToString();
            result.username = tmp[5].ToString();
            result.password = tmp[6].ToString();
            result.capBac = Convert.ToInt32(tmp[7]);
            return result;
        }
        public bool KiemTraUsername(QuanTri quanTri)
        {
            string sql = string.Format("Select username from QuanTri where username = '{0}'", quanTri.username);
            return xlDuLieu.KiemTra(sql);
        }
    }
}
