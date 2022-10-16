using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCGV.Admin
{
    public partial class TheLoaiPhim : Form
    {
        public TheLoaiPhim()
        {
            InitializeComponent();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin ad = new Admin();
            ad.Show();
        }
    }
}
