using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public int ID { get; set; }
        public string ngayTao { get; set; }
        public string thanhTien { get; set; }
        public int maKhachHang { get; set; }
        public List<Ve> ves { get; set; }
    }
    public class Ve
    {
        public int id { get; set; }
        public string ngayTao { get; set; }
        public string ngayXem { get; set; }
        public int trangThai { get; set; }
        public string giaVe { get; set; }
        public int maLichChieu { get; set; }
        public int maHoaDon { get; set; }
        public int maGhe { get; set; }
        public Lichchieu lichchieu { get; set; }
    }
    public class Lichchieu
    {
        public int id { get; set; }
        public string gioBatDau { get; set; }
        public string gioKetThuc { get; set; }
        public string ngayChieu { get; set; }
        public int maPhong { get; set; }
        public string ngayKetThuc { get; set; }
        public List<Phim> phims { get; set; }
    }
    public class Pivot
    {
        public int maLichChieu { get; set; }
        public int maPhim { get; set; }
    }
    public class Phim
    {
        public int id { get; set; }
        public string tenPhim { get; set; }
        public string moTa { get; set; }
        public string thoiGian { get; set; }
        public int maTheLoai { get; set; }
        public object img { get; set; }
        public Pivot pivot { get; set; }

    }
}
