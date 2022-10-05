using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DAL
{
    public class ApiService
    {
        public List<KhachHangDTO>  readData()
        {
            WebClient wc = new WebClient();
            string json = wc.DownloadString("https://mfw060.wcom.vn/api/khachHang");

            List<KhachHangDTO> ds = JsonConvert.DeserializeObject<List<KhachHangDTO>>(json);

            return ds;
        }
        public bool insertData(string myParameters)
        {

            string URI = "https://mfw060.wcom.vn/api/khachHang";

            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(URI, myParameters);

                var jo = JObject.Parse(HtmlResult);
                var status = jo["status"].ToString();
                if (status == "200")
                    return true;
                else
                    return false; 
            };
        }
    }
}
