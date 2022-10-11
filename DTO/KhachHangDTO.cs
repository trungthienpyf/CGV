using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public int ID { get; set; }
        public string tenKhachHang { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string matKhau { get; set; }
    }
}
