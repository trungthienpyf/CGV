using DTO;
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
    public partial class ChonGhe : Form
    {
        int SIZE = 30;
        int GAP = 7;
        List<VeDTO> listGhe = new List<VeDTO>();
        List<Button> seatCheck = new List<Button>();
        List<KhachHangDTO> listKhachHang = new List<KhachHangDTO>();


        double displayPrice = 0;
        double ticketPrice = 0;
        double total = 0;


        public ChonGhe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ThanhToan().Show();
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
          
        }

        private void LoadSeat(List<VeDTO> list)
        {
           
        }

        public void LoadSeat()
        {
            pnGhe.Controls.Clear();
            int ghe = 1;
            for (int i = 0; i < pnGhe.RowCount; i++)
            {
                for (int j = 0; j < pnGhe.ColumnCount; j++)
                {
                    Label lblGhe = new Label();
                    lblGhe.Text = ghe + "";
                    lblGhe.AutoSize = false;
                    lblGhe.Dock = DockStyle.Fill;
                    lblGhe.TextAlign = ContentAlignment.MiddleCenter;
                    lblGhe.Width = lblGhe.Height = 50;
                    lblGhe.BackColor = Color.White;
                    pnGhe.Controls.Add(lblGhe, j, i);
                    ghe++;
                    lblGhe.Click += LblGhe_Click;
                }
            }
        }
        private void LblGhe_Click(object sender, EventArgs e)
        {
            Label lblGhe = sender as Label;
            if (lblGhe.BackColor == Color.White)
                lblGhe.BackColor = Color.Green;
            else if (lblGhe.BackColor == Color.Green)
                lblGhe.BackColor = Color.White;
            else if (lblGhe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế số [" + lblGhe.Text + "] đã có người đặt rồi");
            }
        }

        private void ChonGhe_Load(object sender, EventArgs e)
        {
            LoadSeat();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy các vé đã chọn không ? ", "Hủy mua vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
             
            }
        }
    }
}
