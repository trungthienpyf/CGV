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
            string json = wc.DownloadString("https://mfw060.wcom.vn/api/theLoaiPhim");

            List<TheLoaiPhimDTO> ds = JsonConvert.DeserializeObject<List<TheLoaiPhimDTO>>(json);

            return ds;
        }
    }
}
