using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class PhongBAL
    {
        PhongDAL phongDAL = new PhongDAL();
        public List<PhongDTO> readData()
        {
            string URL = "https://mfw060.wcom.vn/api/phong";
            var ds = phongDAL.readData(URL);

            return ds;
        }
        public bool insertData(string myParameters)
        {

            string URL = "https://mfw060.wcom.vn/api/phong";
            bool check = phongDAL.insertData(myParameters, URL);

            if (check)
                return true;
            else
                return false;
        }
        public bool updateData(string myParameters, int id)
        {
            string URL = "https://mfw060.wcom.vn/api/phong/";
            bool check = phongDAL.updateData(myParameters, id, URL);

            if (check)
                return true;
            else
                return false;
        }
    }
}
