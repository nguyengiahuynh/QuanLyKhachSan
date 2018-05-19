using MidTerm.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.DAO
{
    class PhongDAO
    {
        XL_DULIEU xlDuLieu = new XL_DULIEU();
        public DataTable LayDanhSachPhong()
        {
            return xlDuLieu.LayDuLieu("Select p.maPhong as 'Mã phòng', p.loaiPhong as 'Loại phòng', lp.tenLoai as 'Tên loại phòng', lp.donGia as 'Đơn giá', p.tinhTrang as 'Tình trạng' from Phong p, LoaiPhong lp where p.loaiPhong = lp.loaiPhong");
        }

        public int ThemPhong(Phong phong)
        {
            //Xử lý dữ liệu
            string sql = string.Format("Insert Into Phong(maPhong, loaiPhong, tinhTrang) Values('{0}','{1}','{2}')", phong.maPhong, phong.loaiPhong, phong.tinhTrang);
            return xlDuLieu.ThucThi(sql);
        }
        public bool KiemTraMaPhong(Phong phong)
        {
            string sql = string.Format("Select maPhong from Phong where maPhong = '{0}'", phong.maPhong);
            return xlDuLieu.KiemTra(sql);
        }

        public int XoaPhong(Phong phong)
        {
            //Xử lý dữ liệu
            string sql = string.Format("Delete from Phong where maPhong = '{0}'", phong.maPhong);
            return xlDuLieu.ThucThi(sql);
        }

        public Phong LayThongTinPhongQuaMaPhong(string maPhong)
        {
            string sql = "Select * from Phong where maPhong = '" + maPhong + "'";
            var tmp = xlDuLieu.LayDuLieu(sql).AsEnumerable().Take(1).ToArray()[0].ItemArray;
            Phong result = new Phong();
            result.maPhong = tmp[0].ToString();
            result.loaiPhong = Convert.ToInt32(tmp[1]);
            result.tinhTrang = Convert.ToInt32(tmp[2]);
            return result;
        }

        public int SuaPhong(Phong phong)
        {
            //Xử lý dữ liệu
            string sql = string.Format("Update Phong set loaiPhong = '{0}', tinhTrang = '{1}' where maPhong = '{2}'", phong.loaiPhong, phong.tinhTrang, phong.maPhong);
            return xlDuLieu.ThucThi(sql);
        }

        public DataTable TimPhong(Phong phong)
        {
            string sql = string.Format("Select p.maPhong as 'Mã phòng', p.loaiPhong as 'Loại phòng', lp.tenLoai as 'Tên loại phòng', lp.donGia as 'Đơn giá', p.tinhTrang as 'Tình trạng' from Phong p, LoaiPhong lp where p.loaiPhong = lp.loaiPhong and p.maPhong = '{0}'", phong.maPhong);
            return xlDuLieu.LayDuLieu(sql);
        }
    }
}
