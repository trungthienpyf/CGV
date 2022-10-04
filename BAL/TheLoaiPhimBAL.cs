using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class TheLoaiPhimBAL
    {
        public List<TheLoaiPhimDTO> readData()
        {
            WebClient wc = new WebClient();
            string json = wc.DownloadString("https://200a-2405-4803-c834-55e0-f5ff-e590-633d-fbc4.ap.ngrok.io/api/theLoaiPhim");

            List<TheLoaiPhimDTO> ds = JsonConvert.DeserializeObject<List<TheLoaiPhimDTO>>(json);

            return ds;
        }
    }
}
