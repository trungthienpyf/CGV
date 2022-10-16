using DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace QLCGV.User
{
    public partial class User : Form
    {
        public static int maLC;
        public static int maP;
        public static int maPhong;
        public static string tg;
        public static string gioBD;
        public static string tenPhim;
        public static string day= DateTime.Today.ToString("dd-MM-yyyy");
        public static string day2= DateTime.Today.ToString("yyyyyyyy-MM-dd");
        List<Button> btnArr = new List<Button>();
        public User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            Button btn = sender as Button;

          

        string[] authorsList = btn.Tag.ToString().Split(',');
         
            maLC = int.Parse(authorsList[0]);
            maP = int.Parse(authorsList[1]);
            maPhong = int.Parse(authorsList[2]);
            gioBD =authorsList[3];
            tenPhim =authorsList[4];
           
            this.Hide();
            var showGhe = new ChonGhe();
            showGhe.FormClosed += new FormClosedEventHandler(User_FormClosed); //add handler to catch when child form is closed
            showGhe.Show();
          
        }
       
  
    private void loadPhim(string day)
        {

         


            WebClient wc1 = new WebClient();

            var k = DateTime.ParseExact(day,
      "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
           
              string query = string.Format("ngayChieu={0}",
             k.ToString("yyyy-MM-dd"));
          
            wc1.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

            string json = wc1.UploadString("https://mfw060.wcom.vn/api/getPhimClient", query);


            var ds = JsonConvert.DeserializeObject<List<PhimDTO>>(json);

            foreach (var i in ds)
            {
                maP = i.id;
                SplitContainer spltcnt = new SplitContainer();
                //  Button hinh = new Button();
                SplitContainer spltcnt2 = new SplitContainer();
                Label lbName = new Label();

                TableLayoutPanel pnGio = new TableLayoutPanel();

                spltcnt.Dock = DockStyle.Fill;
                lbName.Text = i.tenPhim;

                // hinh.Text = "Hinh";

                spltcnt2.Dock = DockStyle.Fill;
                spltcnt2.Orientation = Orientation.Horizontal;

                spltcnt2.Panel1.Controls.Add(lbName);
                spltcnt2.Panel2.Controls.Add(pnGio);
                pnGio.Dock = DockStyle.Fill;
                pnGio.ColumnCount = 5;
                pnGio.RowCount = 1;
                PictureBox hinh = new PictureBox();

                hinh.Load("https://media.blogradio.vn/Upload/CMS/Nam_2013/Thang_2/Ngay_25/conmeotrenmainha.jpg?v=1");
                hinh.SizeMode = PictureBoxSizeMode.StretchImage;

                int col = 0;
                foreach (var u in i.lich_chieus)
                {
                    if(day== DateTime.Today.ToString("dd-MM-yyyy"))
                    {
                        var gio = DateTime.ParseExact(u.gioBatDau, "HH:mm:ss", CultureInfo.InvariantCulture);

                        if (gio >= DateTime.Now)
                        {
                            Button z = new Button();
                            z.Tag = u.id + "," + u.pivot.maPhim + "," + u.maPhong + "," + u.gioBatDau + "," + i.tenPhim;
                            z.Text = u.gioBatDau;
                            z.Click += button1_Click;
                            pnGio.Controls.Add(z, col, 0);
                            col++;
                        }
                    }
                    else
                    {
                        Button b = new Button();
                        b.Tag = u.id + "," + u.pivot.maPhim + "," + u.maPhong + "," + u.gioBatDau + "," + i.tenPhim;
                        b.Text = u.gioBatDau;
                        b.Click += button1_Click;
                        pnGio.Controls.Add(b, col, 0);
                        col++;
                    }

                }

                spltcnt.Panel1.Controls.Add(hinh);
                spltcnt.Panel2.Controls.Add(spltcnt2);


                pnIndex.Controls.Add(spltcnt);
            }
        }
      
        public void User_Load(object sender, EventArgs e)
        {
         
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            var tomorrow_2 = today.AddDays(2);
            var tomorrow_3 = today.AddDays(3);
            var tomorrow_4 = today.AddDays(4);
         
            List<string> date = new List<string> { today.ToString("dd-MM-yyyy") , 
                tomorrow.ToString("dd-MM-yyyy") ,
                tomorrow_2.ToString("dd-MM-yyyy") ,
                tomorrow_3.ToString("dd-MM-yyyy") ,
                tomorrow_4.ToString("dd-MM-yyyy") ,

            };

         

            foreach (var item in date)
            {
                Button button = new Button();
                btnArr.Add(button);
                button.Text = item;
                if (button.Text == today.ToString("dd-MM-yyyy"))
                {
                    button.Enabled = false;
                }
                button.Click += button1_Click_1;
                pnTime.Controls.Add(button);
            }
            loadPhim(day);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
       
            foreach (Button c in btnArr)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                }
            }
            day = btn.Text;
            day2 = DateTime.ParseExact(btn.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
          

            if (btn.Text==day)
            {
                btn.Enabled = false;
            }
            pnIndex.Controls.Clear();
            loadPhim(day);
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            /* pnIndex.Controls.Clear();
             day = DateTime.Today.ToString("dd-MM-yyyy");
             day2 = DateTime.Today.ToString("yyyy-MM-dd");*/
           
            /*this.User_Load(null,EventArgs.Empty);*/
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Ve().Show();
        }
    }
}
