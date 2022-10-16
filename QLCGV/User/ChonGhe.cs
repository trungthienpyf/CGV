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
            string json = wc.DownloadString("https://mfw060.wcom.vn/api/ghe");
            pnGhe.Controls.Clear();
            List<GheDTO> ds = JsonConvert.DeserializeObject<List<GheDTO>>(json);
            
            using (WebClient wc2 = new WebClient())
            {
                string query = string.Format("maLichChieu={0}&maPhim={1}&maPhong={2}&ngayXem={3}",
                  User.maLC, User.maP, User.maPhong,User.day2);

                wc2.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string json2 = wc2.UploadString("https://mfw060.wcom.vn/api/getGheExit", query);
                
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

                MessageBox.Show("Ghế đã được bán, xin vui lòng chọn ghế khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Ghế số [" + lblGhe.Text + "] đã có người đặt rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

          

            txtThanhTien.Text = thanhtien.ToString();
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
                MessageBox.Show("Vui lòng chọn ghế trước khi thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            
            total = txtThanhTien.Text;

            soVe = dsChon.Count;
            
            using (WebClient wc = new WebClient())
            {
                string query = string.Format("ngayTao={0}&thanhTien={1}&maKhachHang={2}",
                     DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), txtThanhTien.Text, Login.id);
                wc.Encoding = UTF8Encoding.UTF8;
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded; charset=utf-8";
                string HtmlResult = wc.UploadString("https://mfw060.wcom.vn/api/hoaDon", query);

                var jo = JObject.Parse(HtmlResult);
                var status = jo["status"].ToString();
                if (status == "200")
                {
                    
                }
                   
                else
                    MessageBox.Show("Co loi xay ra");
            };


            WebClient wc1 = new WebClient();
            string json = wc1.DownloadString("https://mfw060.wcom.vn/api/hoaDon");

            List<HoaDonDTO> ds = JsonConvert.DeserializeObject<List<HoaDonDTO>>(json);
            var hd = ds.Last();
            maHD = hd.ID;
            tenGhe.Clear();
            foreach (var btn in DsGhe)
            {
               
               insertTicket(btn,hd.ID);
                tenGhe.Add("Ghe "+btn);
            }

            MessageBox.Show("Đặt vé thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
            this.Hide();

            new ThanhToan().ShowDialog();

            }
        }
        public void insertTicket(int ghe,int hd)
        {
            using (WebClient wc = new WebClient())
            {
                int tienVe = int.Parse(txtThanhTien.Text) / dsChon.Count;

                string query = string.Format("ngayTao={0}&trangThai={1}&giaVe={2}&maLichChieu={3}&maHoaDon={4}&maGhe={5}&ngayXem={6}",
                     DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"),1, tienVe.ToString(), User.maLC, hd, ghe, User.day2);
            
                wc.Encoding = UTF8Encoding.UTF8;
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded; charset=utf-8";
                string HtmlResult = wc.UploadString("https://mfw060.wcom.vn/api/ve", query);

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


            txtThanhTien.Text = "";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy các vé đang chọn không ? ", "Hủy mua vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                new User().Show();
            }
            
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            txtThanhTien.ReadOnly = true;
        }
    }
}
