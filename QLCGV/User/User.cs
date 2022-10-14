using DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
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
    public partial class User : Form
    {
        public static int maLC;
        public static int maP;
        public static int maPhong;
        public static string tg;
        public static string gioBD;
        public static string tenPhim;
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
            new ChonGhe().Show();
          
        }
       
  
    
       
        private void User_Load(object sender, EventArgs e)
        {

            WebClient wc1 = new WebClient();
            string json = wc1.DownloadString("http://127.0.0.1:8000/api/getPhimClient");

            var ds = JsonConvert.DeserializeObject<List<PhimDTO>>(json);

            foreach (var i in ds)
            {
                maP = i.id;
                SplitContainer spltcnt = new SplitContainer();
                Button hinh = new Button();
                SplitContainer spltcnt2 = new SplitContainer();
                Label lbName = new Label();
               
                TableLayoutPanel pnGio = new TableLayoutPanel();

                spltcnt.Dock = DockStyle.Fill;
                lbName.Text = i.tenPhim;
                
                hinh.Text = "Hinh";
              
                  spltcnt2.Dock = DockStyle.Fill;
                 spltcnt2.Orientation = Orientation.Horizontal;
               
                spltcnt2.Panel1.Controls.Add(lbName);
                spltcnt2.Panel2.Controls.Add(pnGio);
                pnGio.Dock = DockStyle.Fill;
                pnGio.ColumnCount = 5;
                pnGio.RowCount = 1;

                /* 
                  pnGio.Controls.Add(new Button() { Text = "Contact No" }, 1, 0);
                  pnGio.Controls.Add(new Button() { Text = "Email ID" }, 2, 0);*/
                int col = 0;
               
                foreach (var d in i.lich_chieus)
                  {
                    
                    
                    Button b = new Button();
                    b.Tag = d.id +","+d.pivot.maPhim+","+d.maPhong+","+d.gioBatDau+","+i.tenPhim;
                    b.Text = d.gioBatDau;
                    b.Click += button1_Click;
                    pnGio.Controls.Add(b, col, 0);
                    col++;

                  
                }
       
                spltcnt.Panel1.Controls.Add(hinh);
                spltcnt.Panel2.Controls.Add(spltcnt2);
               
                
                pnIndex.Controls.Add(spltcnt);
            }
           
        }
    }
}
