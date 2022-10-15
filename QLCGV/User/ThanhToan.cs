using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCGV.User
{
    public partial class ThanhToan : Form
    {
        public  string a;
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            // ChonGhe g = new ChonGhe();

            //    string ghe = ChonGhe.ghe;

            // MessageBox.Show(ChonGhe.total);
            label3.Text = ChonGhe.maHD.ToString();
            label10.Text = User.tenPhim.ToString();
            label11.Text = User.gioBD.ToString();
            label12.Text = User.maPhong.ToString();
            label13.Text = ChonGhe.soVe.ToString();
           
            label15.Text = ChonGhe.total.ToString()+" VND";
            label14.Text = "";
            foreach (var k in ChonGhe.tenGhe)
            {
                label14.Text += k+ " ";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (User frmAddMov = new User())
            {
                if (frmAddMov.ShowDialog() == DialogResult.OK)
                {
                    frmAddMov.Invalidate();
                    frmAddMov.Refresh();
                

                }
            }
            
           
        }

        
    }
}
