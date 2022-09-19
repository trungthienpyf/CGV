using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGV.Admin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            new Phim().Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Phong().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LichChieu().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NV().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new KH().Show();
        }
    }
}
