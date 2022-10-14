using DAL;
using DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCGV.User
{
    public partial class ChonGhe : Form
    {

        public string ghe="1";
        public static string total;
        public static int maHD;
        public static int soVe;


        List<Button> dsChon = new List<Button>();
       public static  List<String> tenGhe = new List<String>();
        public  int thanhtien = 0;

        public ChonGhe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ThanhToan().Show();
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
          
        }

        
        public void LoadSeat()
        {

            List<GheDTO> ds2 = new List<GheDTO>();
 
            WebClient wc = new WebClient();
            string json = wc.DownloadString("http://127.0.0.1:8000/api/ghe");
            pnGhe.Controls.Clear();
            List<GheDTO> ds = JsonConvert.DeserializeObject<List<GheDTO>>(json);
            
            using (WebClient wc2 = new WebClient())
            {
                string query = string.Format("maLichChieu={0}&maPhim={1}&maPhong={2}",
                  User.maLC, User.maP, User.maPhong);
            
                wc2.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string json2 = wc2.UploadString("http://127.0.0.1:8000/api/getGheExit", query);
                
                ds2 = JsonConvert.DeserializeObject<List<GheDTO>>(json2);

                
            };
           
            foreach (var request in ds)
            {

                Button accept = new Button();

                accept.Text = "Ghe " + request.ID.ToString();

                accept.Tag = request.ID.ToString();
                accept.Click += button3_Click;

                var index = ds2.FirstOrDefault(f => f.ID == request.ID);
             
                if (index != null)
                {

                    accept.BackColor = Color.Yellow;

                }
                else { 
                    accept.BackColor = Color.White;
                }
               
              

                pnGhe.Controls.Add(accept);
             

            }

        }
        private void button3_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            //   MessageBox.Show(Convert.ToInt32(btn.Tag).ToString());
          
            if (btn.BackColor == Color.White)
            {

                btn.BackColor = Color.Blue;
                dsChon.Add(btn);
                DsGhe.Add(Convert.ToInt32(btn.Tag));
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
                dsChon.Add(btn);
                DsGhe.Add(Convert.ToInt32(btn.Tag));
            }
            else if (btn.BackColor == Color.Yellow)
            {
                dsChon.Remove(btn);
               
                DsGhe.Remove(Convert.ToInt32(btn.Tag));

                MessageBox.Show("ghe da dc ban!!", "Thong bao", MessageBoxButtons.OK);

            }
        
    

        }
        private void LblGhe_Click(object sender, EventArgs e)
        {
            Label lblGhe = sender as Label;
            if (lblGhe.BackColor == Color.White)
                lblGhe.BackColor = Color.Green;
            else if (lblGhe.BackColor == Color.Green)
                lblGhe.BackColor = Color.White;
            else if (lblGhe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế số [" + lblGhe.Text + "] đã có người đặt rồi");
            }
        }

        private void ChonGhe_Load(object sender, EventArgs e)
        {   
            LoadSeat();

          
        }
        List<int> DsGhe = new List<int>();
        private void btnChon_Click(object sender, EventArgs e)
       {       Button c = sender as Button;
            int idRequest = Convert.ToInt32(c.Tag);
          
            foreach (Button b in dsChon)
            {
                int a = idRequest;
                if (a <= 5)
                {
                    b.BackColor = Color.Yellow;
                    thanhtien += 500;
                    
                }
                else if (a >= 5 && a <= 10)
                {
                    b.BackColor = Color.Yellow;
                    thanhtien += 1000;
                   

                }
                else if (a > 10)
                {
                    b.BackColor = Color.Yellow;
                    thanhtien += 2000;
  
                }
               
            }

          

            textBox1.Text = thanhtien.ToString();
            thanhtien = 0;
          
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy các vé đã chọn không ? ", "Hủy mua vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
             
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(DsGhe.Count == 0)
            {
                MessageBox.Show("Vui long chon ghe truoc khi thanh toan");
            }
            else
            {

            
            total = textBox1.Text;

            soVe = dsChon.Count;
            
            using (WebClient wc = new WebClient())
            {
                string query = string.Format("ngayTao={0}&thanhTien={1}&maKhachHang={2}",
                     DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), textBox1.Text, Login.id);
                wc.Encoding = UTF8Encoding.UTF8;
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded; charset=utf-8";
                string HtmlResult = wc.UploadString("http://127.0.0.1:8000/api/hoaDon", query);

                var jo = JObject.Parse(HtmlResult);
                var status = jo["status"].ToString();
                if (status == "200")
                {
                    
                }
                   
                else
                    MessageBox.Show("Co loi xay ra");
            };


            WebClient wc1 = new WebClient();
            string json = wc1.DownloadString("http://127.0.0.1:8000/api/hoaDon");

            List<HoaDonDTO> ds = JsonConvert.DeserializeObject<List<HoaDonDTO>>(json);
            var hd = ds.Last();
            maHD = hd.ID;
            tenGhe.Clear();
            foreach (var btn in DsGhe)
            {
               
               insertTicket(btn,hd.ID);
                tenGhe.Add("Ghe "+btn);
            }

            MessageBox.Show("Dat ve thanh cong");
         
            this.Hide();

            new ThanhToan().ShowDialog();

            }
        }
        public void insertTicket(int ghe,int hd)
        {
            using (WebClient wc = new WebClient())
            {
                int tienVe = int.Parse(textBox1.Text) / dsChon.Count;

                string query = string.Format("ngayTao={0}&trangThai={1}&giaVe={2}&maLichChieu={3}&maHoaDon={4}&maGhe={5}",
                     DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"),1, tienVe.ToString(), User.maLC, hd, ghe);
                wc.Encoding = UTF8Encoding.UTF8;
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded; charset=utf-8";
                string HtmlResult = wc.UploadString("http://127.0.0.1:8000/api/ve", query);

                var jo = JObject.Parse(HtmlResult);
                var status = jo["status"].ToString();
                if (status == "200")
                {
                    
                }

                else
                    MessageBox.Show("Co loi xay ra");
            };
        }
        private void button2_Click(object sender, EventArgs e)
        {
         
        

            foreach (Button b in dsChon)
            {
                b.BackColor = Color.White;

            }
            dsChon.Clear();


            textBox1.Text = "";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User().Show();
        }
    }
}
