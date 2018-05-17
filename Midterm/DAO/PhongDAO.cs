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
    }
}
