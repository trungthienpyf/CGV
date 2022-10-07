using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class AdminBAL
    {
        AdminDAL adminDAL = new AdminDAL();
        public List<AdminDTO> readData()
        {
            string URL = "https://mfw060.wcom.vn/api/admin";
            var ds = adminDAL.readData(URL);

            return ds;
        }
        public bool insertData(string myParameters)
        {


            string URL = "https://mfw060.wcom.vn/api/admin";
            bool check = adminDAL.insertData(myParameters, URL);

            if (check)
                return true;
            else
                return false;
        }
        public bool updateData(string myParameters, int id)
        {
            string URL = "https://mfw060.wcom.vn/api/admin/";
            bool check = adminDAL.updateData(myParameters, id, URL);

            if (check)
                return true;
            else
                return false;
        }
    }
}
