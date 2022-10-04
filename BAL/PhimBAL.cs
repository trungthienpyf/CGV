using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Newtonsoft.Json.Linq;
using DAL;

namespace BAL
{
    public class PhimBAL
    {
        PhimDAL phimDAL=new PhimDAL();
        public List<PhimDTO> readData()
        {
            string URL = "https://200a-2405-4803-c834-55e0-f5ff-e590-633d-fbc4.ap.ngrok.io/api/phim";
          var ds=  phimDAL.readData(URL);

            return ds;
        }
        public bool insertData(string myParameters)
        {

        
            string URL = "https://200a-2405-4803-c834-55e0-f5ff-e590-633d-fbc4.ap.ngrok.io/api/phim";
            bool check = phimDAL.insertData(myParameters, URL);

            if (check)
                return true;
            else
                return false;
        }
        public bool updateData(string myParameters,int id)
        {
            string URL= "https://200a-2405-4803-c834-55e0-f5ff-e590-633d-fbc4.ap.ngrok.io/api/phim/";
            bool check =phimDAL.updateData(myParameters, id, URL);

            if (check)
                return true;
            else
                return false;
        }

        
    }
}
