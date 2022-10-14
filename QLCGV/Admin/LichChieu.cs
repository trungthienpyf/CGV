using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BAL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Net;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace QLCGV.Admin
{
    public partial class LichChieu : Form
    {
        LichChieuBAL  lichChieu = new LichChieuBAL();
        public LichChieu()
        {
            InitializeComponent();
        }
        private bool checkGio()
        {
            DateTime time1 = DateTime.ParseExact(dateTimePicker2.Value.ToString("HH:mm"), "HH:mm", CultureInfo.InvariantCulture);
            DateTime time2 = DateTime.ParseExact(dateTimePicker3.Value.ToString("HH:mm"), "HH:mm", CultureInfo.InvariantCulture);
            bool isvalid = time1 < time2;
            return isvalid;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LichChieuDTO lichChieuDTO = new LichChieuDTO();
            try
            {
               // MessageBox.Show(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                if (lbID.Text != "")
                {
                    throw new Exception("Vui long xoa ma truoc khi them du lieu");
                }
             
                if (   dateTimePicker1.Text == "" || comboTL.Text == "")
                {
                    throw new Exception("vui long nhap day du thong tin");
                }
                if(checkGio()== false)
                {
                    throw new Exception("Giờ bắt đầu không được nhỏ hơn giờ kết thúc");
                }
                lichChieuDTO.gioBatDau = dateTimePicker2.Value.ToString("HH:mm");
                lichChieuDTO.gioKetThuc = dateTimePicker3.Value.ToString("HH:mm");
                lichChieuDTO.ngayChieu = dateTimePicker1.Value.ToString("yyyy-MM-dd");
               lichChieuDTO.maPhong = int.Parse(comboTL.SelectedValue.ToString());
              
                string query = string.Format("gioBatDau={0}&gioKetThuc={1}&ngayChieu={2}&maPhong={3}",
                lichChieuDTO.gioBatDau, lichChieuDTO.gioKetThuc, lichChieuDTO.ngayChieu, lichChieuDTO.maPhong);
              
                bool check = lichChieu.insertData(query);
                if (check == true)
                {
                    MessageBox.Show("Them moi du lieu thanh cong!", "Thong Bao", MessageBoxButtons.OK);
                    WebClient wc1 = new WebClient();
                    string json = wc1.DownloadString("http://127.0.0.1:8000/api/lichChieu");

                    List<LichChieuDTO> ds = JsonConvert.DeserializeObject<List<LichChieuDTO>>(json);
                    var hd = ds.Last();
                    insertCT(hd.id);
                    load();
                }
                else
                {
                    throw new Exception("Them khong thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void load()
        {
           // getNameCategoryMovie();
            List<LichChieuDTO> ds = lichChieu.readData();

            var list = new BindingList<LichChieuDTO>(ds);
            var source = new BindingSource(list, null);
            dgv.DataSource = source;
          
            
        }
        private void getNameCategoryMovie()
        {


            PhongBAL tlp = new PhongBAL();
            var ds = tlp.readData();
            PhimBAL tlp2 = new PhimBAL();
            var ds1 = tlp2.readData();

            var list = new BindingList<PhongDTO>(ds);
            var source = new BindingSource(list, null);
            comboTL.DataSource = source;

            comboTL.ValueMember = "ID";
            comboTL.DisplayMember = "tenPhong";


            var list2 = new BindingList<PhimDTO>(ds1);
            var source2 = new BindingSource(list2, null);
            comboBox1.DataSource = source2;

            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "tenPhim";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LichChieu_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";


            dateTimePicker2.Format = DateTimePickerFormat.Time;
          

            dateTimePicker2.ShowUpDown = true;
            dateTimePicker3.Format = DateTimePickerFormat.Time;
         

          
            dateTimePicker3.ShowUpDown = true;

            load();
            getNameCategoryMovie();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            LichChieuDTO lichChieuDTO = new LichChieuDTO();
            try
            {
               
                if (lbID.Text == "")
                {
                    throw new Exception("Vui long chon phim can xoa tren bang");
                }

         
               
                lichChieuDTO.ngayChieu  = dateTimePicker1.Text;
                lichChieuDTO.maPhong = int.Parse(comboTL.SelectedValue.ToString());
                string query = string.Format("gioBatDau={0}&gioKetThuc={1}&ngayChieu={2}&maPhong={3}",
                lichChieuDTO.gioBatDau, lichChieuDTO.gioKetThuc, lichChieuDTO.ngayChieu,lichChieuDTO.maPhong);
                bool check = lichChieu.updateData(query, int.Parse(lbID.Text));
                if (check == true)
                {
                    MessageBox.Show("Cap nhat phim lieu thanh cong!", "Thong Bao", MessageBoxButtons.OK);


                   
                    load();
                }
                else
                {
                    throw new Exception("Sua khong thanh cong");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void insertCT(int id)
        {
            using (WebClient wc = new WebClient())
            {
              

                string query = string.Format("maPhim={0}&maLichChieu={1}",
                comboBox1.SelectedValue, id);
                wc.Encoding = UTF8Encoding.UTF8;
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded; charset=utf-8";
                string HtmlResult = wc.UploadString("http://127.0.0.1:8000/api/ct_lc", query);
                MessageBox.Show(query);
                var jo = JObject.Parse(HtmlResult);
                var status = jo["status"].ToString();
                if (status == "200")
                {

                }

                else
                    MessageBox.Show("Co loi xay ra");
            };
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            lbID.Text = dgv.Rows[i].Cells[0].Value.ToString();
           
          
            dateTimePicker1.Text = dgv.Rows[i].Cells[3].Value.ToString();
            comboTL.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("https://mfw060.wcom.vn/api/lichChieu/" + lbID.Text);
            request.Method = "DELETE";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
                MessageBox.Show("Xoa thanh cong");
            else
                MessageBox.Show("Co loi xay ra");
            load();

        }

       
    }
}
