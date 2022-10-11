using DTO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL
    {
        public List<KhachHangDTO> readData(string URL)
        {
            WebClient wc = new WebClient();
            string json = wc.DownloadString(URL);

            List<KhachHangDTO> ds = JsonConvert.DeserializeObject<List<KhachHangDTO>>(json);

            return ds;
        }
        public bool insertData(string myParameters, string URL)
        {

            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(URL, myParameters);

                var jo = JObject.Parse(HtmlResult);
                var status = jo["status"].ToString();
                if (status == "200")
                    return true;
                else
                    return false;
            };
        }
        public bool updateData(string myParameters, int id, string URL)
        {
            var bytes = Encoding.ASCII.GetBytes(myParameters);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format(URL + id));
            request.Method = "PUT";
            request.ContentType = "application/x-www-form-urlencoded";
            using (var requestStream = request.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
                return true;
            else
                return false;
        }
    }
}
