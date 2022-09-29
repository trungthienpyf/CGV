using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (textTk.Text == tk && textPass.Text == mk)
            {
                this.Hide();

                var admin = new Admin.Admin();
                admin.Show();

            }
            if (textTk.Text == tkuser && textPass.Text == mkuser)
            {
                this.Hide();
                var user = new User.User();
                user.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
