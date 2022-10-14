using DAL;
using QLCGV.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QLCGV
{
    public partial class Login : Form
    {
        public static string id ;
        string tk = "admin";
        string mk = "admin";
        string tkuser = "user";
        string mkuser = "user";

        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
           /* if(textTk.Text==tk && textPass.Text == mk)
            {
                this.Hide();
                new Admin.Admin().Show();
            }

            if (textTk.Text == tkuser && textPass.Text == mkuser)
            {
                this.Hide();
                new User.User().Show();
            }*/
            ApiService api = new ApiService();
            var khachHang = api.readData();
            var listAdmin = api.readAdminData();
            var kh = khachHang.Where(x => x.email == textTk.Text && x.matKhau == textPass.Text).FirstOrDefault();
            bool checkAdmin = listAdmin.Any(x=>x.TaiKhoan== textTk.Text && x.MatKhau== textPass.Text);
            bool checkUser = khachHang.Any(x=>x.email == textTk.Text && x.matKhau== textPass.Text);
            if (checkAdmin)
            {
                this.Hide();
                var admin = new Admin.Admin();
                admin.Show();
            }
            if (kh!=null)
            {
                this.Hide();
                var user = new User.User();
                id = kh.ID.ToString();
                user.Show();
            }
            else
                MessageBox.Show("Kiểm tra lại thông tin của bạn :::");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DangKy().Show();
        }

        private void textTk_TextChanged(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("a");
        }
    }
}
