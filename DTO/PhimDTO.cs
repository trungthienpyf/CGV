using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhimDTO
    {
        public int id { get; set; }
        public string tenPhim { get; set; }
        public string moTa { get; set; }
        public string thoiGian { get; set; }
        public int maTheLoai { get; set; }
        public List<LichChieu> lich_chieus { get; set; }
    }
    public class LichChieu
    {
        public int id { get; set; }
        public string gioBatDau { get; set; }
        public string gioKetThuc { get; set; }
        public string ngayChieu { get; set; }
        public int maPhong { get; set; }
        public Pivot pivot { get; set; }
    }

    public class Pivot
    {
        public int maPhim { get; set; }
        public int maLichChieu { get; set; }
    }




}
