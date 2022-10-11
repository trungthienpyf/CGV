using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class KhachHangBAL
    {
        KhachHangDAL khachHangDAL = new KhachHangDAL();
        public List<KhachHangDTO> readData()
        {
            string URL = "https://mfw060.wcom.vn/api/khachHang/";
            var ds = khachHangDAL.readData(URL);

            return ds;
        }
        public bool insertData(string myParameters)
        {
            string URL = "https://mfw060.wcom.vn/api/khachHang/";
            bool check = khachHangDAL.insertData(myParameters, URL);

            if (check)
                return true;
            else
                return false;
        }
        public bool updateData(string myParameters, int id)
        {
            string URL = "https://mfw060.wcom.vn/api/khachHang/";
            bool check = khachHangDAL.updateData(myParameters, id, URL);

            if (check)
                return true;
            else
                return false;
        }
    }
}
