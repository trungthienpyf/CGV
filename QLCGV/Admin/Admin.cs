using BAL;
using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCGV.Admin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           // this.Hide();
            new Phim().Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Phong().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NhanVien().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            this.Hide();
            new LichChieu().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new KhachHang().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TheLoaiPhim().Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TheLoaiPhim().Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // this.Hide();
            new Phim().Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Phong().Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LichChieu().Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NhanVien().Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new KhachHang().Show();
        }
        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
          
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
            
                yield return day;
            
               
        }
        private void Admin_Load(object sender, EventArgs e)
        {
           /* string dateInString = DateTime.Today.ToString();

            DateTime startDate = DateTime.Parse(dateInString);
            DateTime expiryDate = startDate.AddDays(-30);

            foreach (DateTime day in EachDay(expiryDate, startDate))
            {
                MessageBox.Show(day.ToString("dd-MM-yyyy"));
            }*/
          
            WebClient wc1 = new WebClient();
            string json = wc1.DownloadString("http://127.0.0.1:8000/api/countTicket");

             var ds = JsonConvert.DeserializeObject(json);
          label2.Text=ds.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    
                    this.Hide();
                    MessageBox.Show("Đăng xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Login().Show();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }

        }
    }
}
