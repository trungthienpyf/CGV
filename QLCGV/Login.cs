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

namespace QLCGV
{
    public partial class Login : Form
    {
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
            bool check = false;
            SqlConnection n = new SqlConnection(@"Data Source=LAPTOP-PCHHO158;Initial Catalog=_QLRP;Integrated Security=True");
            string hh = txtTk.Text;
            string mk = textPass.Text;
            n.Open();
           
            SqlConnection nn = new SqlConnection(@"Data Source=LAPTOP-PCHHO158;Initial Catalog=_QLRP;Integrated Security=True");
            string sqll = "select * from ADMIN where tenAdmin ='" + hh + "' and matKhau = '" + mk + "'";
            SqlCommand cmdd = new SqlCommand(sqll, n);

            SqlDataReader datt = cmdd.ExecuteReader();
            string sql = "select * from KHACHHANG where SDT ='" + hh + "' and matKhau = '" + mk + "'";
            if (datt.Read() == true)
            {
                check = true;
                this.Hide();
                var admin = new Admin.Admin();
                admin.Show();              
            }
            datt.Close();
            SqlCommand cmd = new SqlCommand(sql, n);
            SqlDataReader dat = cmd.ExecuteReader();

            if (dat.Read() == true)
            {
                check = true;
                this.Hide();
                var user = new User.User();
                user.Show();
            }
            if (check == false)
            {
                MessageBox.Show("Kiểm tra lại thông tin của bạn :::");
            }
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

    }
}
