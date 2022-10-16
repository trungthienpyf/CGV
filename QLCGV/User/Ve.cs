using DTO;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCGV.User
{
    public partial class Ve : Form
    {
        public Ve()
        {
            InitializeComponent();
        }
        string text;
        string phim;
        string ngayXem;
        string gioXem;
        string ghe;
        string gia;
        int sl = 0;
        private void Ve_Load(object sender, EventArgs e)
        {
            WebClient wc1 = new WebClient();
            wc1.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string query = string.Format("id={0}",
           Login.id);
            string json = wc1.UploadString("http://127.0.0.1:8000/api/getTicket", query);


            var ds = JsonConvert.DeserializeObject<List<HoaDonDTO>>(json);
           
            
            foreach(var item in ds)
            {
                Label lb = new Label();
                text = "Mã đặt vé " + item.ID;
               sl = item.ves.Count;
                ghe = "";
                gia = item.thanhTien +" VND";
                foreach (var k in item.ves)
                {
                 
                    ghe += " Ghế " + k.maGhe;
                   
                    gioXem = k.lichchieu.gioBatDau;
                    ngayXem = k.lichchieu.ngayChieu;

                    foreach (var p in k.lichchieu.phims)
                    {
                        phim = p.tenPhim;
                       
                    }
                }
                text += ", Số lượng vé " + sl +", Tổng tiền "+gia +"," + ghe + ", " + phim + ", Ngày xem " + ngayXem + ", giờ xem " + gioXem ;
                lb.Text = text;
                lb.Dock = DockStyle.Fill;
                pnVe.Controls.Add(lb);

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User().Show();
        }
    }
}
