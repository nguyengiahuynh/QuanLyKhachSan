using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.DAO
{
    class HoaDonDAO
    {
        XL_DULIEU xlDuLieu = new XL_DULIEU();
        public DataTable LayDanhSachHoaDon()
        {
            return xlDuLieu.LayDuLieu("Select maHoaDon as 'Mã hóa đơn', maPhieu as 'Mã phiếu', tien as 'Thành tiền', soNgay as 'Số ngày thuê', ngayLapHoaDon as 'Ngày lập hóa đơn' from HoaDon");
        }

        public DataTable DoanhThu1(int thang, int nam)
        {
            string sql = string.Format("select MONTH(hd.ngayLapHoaDon) as 'Tháng', YEAR(hd.ngayLapHoaDon) as 'Năm', SUM(hd.tien) as 'Tổng doanh thu' from HoaDon hd where MONTH(hd.ngayLapHoaDon) = '{0}' and YEAR(hd.ngayLapHoaDon) = '{1}' group by MONTH(hd.ngayLapHoaDon), YEAR(hd.ngayLapHoaDon)", thang, nam);
            return xlDuLieu.LayDuLieu(sql);
        }

        public DataTable DoanhThu2(int nam)
        {
            string sql = string.Format("select p.loaiPhong as 'Loại phòng', l.tenLoai as 'Tên loại phòng', SUM(hd.tien) as 'Tổng tiền' from HoaDon hd, PhieuThuePhong phieu, Phong p, LoaiPhong l where YEAR(hd.ngayLapHoaDon) = '{0}' and hd.maPhieu = phieu.maPhieu and phieu.maPhong = p.maPhong and p.loaiPhong = l.loaiPhong group by p.loaiPhong, l.tenLoai", nam);
            return xlDuLieu.LayDuLieu(sql);
        }

        public DataTable DoanhThu3(int thang, int nam)
        {
            string sql = string.Format("select hd.ngayLapHoaDon as 'Ngày', SUM(hd.tien) as 'Tổng tiền' from HoaDon hd where MONTH(hd.ngayLapHoaDon) = '{0}' and YEAR(hd.ngayLapHoaDon) = '{1}' group by hd.ngayLapHoaDon", thang, nam);
            return xlDuLieu.LayDuLieu(sql);
        }

        public DataTable DoanhThu4(int nam)
        {
            string sql = string.Format("select MONTH(hd.ngayLapHoaDon) as 'Tháng', YEAR(hd.ngayLapHoaDon) as 'Năm', SUM(hd.tien) as 'Tổng doanh thu' from HoaDon hd where YEAR(hd.ngayLapHoaDon) = '{0}' group by MONTH(hd.ngayLapHoaDon), YEAR(hd.ngayLapHoaDon)", nam);
            return xlDuLieu.LayDuLieu(sql);
        }

        public bool KiemTraThang(int thang)
        {
            string sql = string.Format("Select MONTH(ngayLapHoaDon) from HoaDon where MONTH(ngayLapHoaDon) = '{0}'", thang);
            return xlDuLieu.KiemTra(sql);
        }

        public bool KiemTraNam(int nam)
        {
            string sql = string.Format("Select YEAR(ngayLapHoaDon) from HoaDon where YEAR(ngayLapHoaDon) = '{0}'", nam);
            return xlDuLieu.KiemTra(sql);
        }
    }
}
