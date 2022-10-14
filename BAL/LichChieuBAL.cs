using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class LichChieuBAL
    {
        LichChieuDAL LichChieuDAL = new LichChieuDAL();
        public List<LichChieuDTO> readData()
        {
            string URL = "http://127.0.0.1:8000/api/lichChieu";
            var ds = LichChieuDAL.readData(URL);

            return ds;
        }
        public bool insertData(string myParameters)
        {


            string URL = "http://127.0.0.1:8000/api/lichChieu";
            bool check = LichChieuDAL.insertData(myParameters, URL);

            if (check)
                return true;
            else
                return false;
        }
        public bool updateData(string myParameters, int id)
        {
            string URL = "http://127.0.0.1:8000/api/lichChieu/";
            bool check = LichChieuDAL.updateData(myParameters, id, URL);

            if (check)
                return true;
            else
                return false;
        }
    }
}
