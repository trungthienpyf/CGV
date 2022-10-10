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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BAL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Net;

namespace QLCGV.Admin
{
   
    public  partial class Phim : Form
    {
        PhimBAL phim = new PhimBAL();

        public Phim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhimDTO phimDTO = new PhimDTO();
            try
            {
                if (labelId.Text != "")
                {
                    throw new Exception("Vui long xoa ma truoc khi them du lieu");
                }
                if (textPhim.Text == "" || textTg.Text == "" || comboTL.Text == "" || richTextBox1.Text == "")
                {
                    throw new Exception("vui long nhap day du thong tin");
                }
               
                phimDTO.tenPhim = textPhim.Text;
                phimDTO.moTa = richTextBox1.Text;
                phimDTO.thoiGian = textTg.Text;
                phimDTO.maTheLoai = comboTL.SelectedValue.ToString();
                string query = string.Format("tenPhim={0}&moTa={1}&thoiGian={2}&maTheLoai={3}",
               phimDTO.tenPhim, phimDTO.moTa, phimDTO.thoiGian, phimDTO.maTheLoai);
                bool check =  phim.insertData(query);

                if (check == true)
                {
                    MessageBox.Show("Them moi du lieu thanh cong!", "Thong Bao", MessageBoxButtons.OK);
                    load();
                }
                else
                {
                    throw new Exception("Them khong thanh cong");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            PhimDTO phimDTO = new PhimDTO();
            try
            {
                if (labelId.Text == "")
                {
                    throw new Exception("Vui long chon phim can xoa tren bang");
                }

                phimDTO.tenPhim = textPhim.Text;
                phimDTO.moTa = richTextBox1.Text;
                phimDTO.thoiGian = textTg.Text;
                phimDTO.maTheLoai = comboTL.SelectedValue.ToString();
                string query = string.Format("tenPhim={0}&moTa={1}&thoiGian={2}&maTheLoai={3}",
               phimDTO.tenPhim, phimDTO.moTa, phimDTO.thoiGian, phimDTO.maTheLoai);
               bool check= phim.updateData(query, int.Parse(labelId.Text));
                if (check == true)
                {
                    MessageBox.Show("Cap nhat phim lieu thanh cong!", "Thong Bao", MessageBoxButtons.OK);
                    load();
                }
                else
                {
                    throw new Exception("Sua khong thanh cong");
                }

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearText()
        {
            labelId.Text = "";
            textPhim.Text ="";
            richTextBox1.Text ="";
            textTg.Text = "";
            comboTL.SelectedIndex = 0;
        }
        private void getNameCategoryMovie()
        {


            TheLoaiPhimBAL tlp = new TheLoaiPhimBAL();
           var ds= tlp.readData();


            var list = new BindingList<TheLoaiPhimDTO>(ds);
            var source = new BindingSource(list, null);
            comboTL.DataSource = source;
          
            comboTL.ValueMember = "ID";
            comboTL.DisplayMember = "tenTheLoai";

        }

        
        private void load()
        {
            getNameCategoryMovie();
            List<PhimDTO> ds = phim.readData();

            var list = new BindingList<PhimDTO>(ds);
            var source = new BindingSource(list, null);
            dgv.DataSource = source;
            dgv.Columns[0].HeaderText = "id";
            dgv.Columns[1].HeaderText = "Mo Ta";
            dgv.Columns[0].HeaderText = "Thoi gian phim";
            dgv.Columns[0].HeaderText = "Ma The Loai";
            clearText();
        }
       

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            int i ;
            i = dgv.CurrentRow.Index;
            labelId.Text = dgv.Rows[i].Cells[0].Value.ToString();
            textPhim.Text = dgv.Rows[i].Cells[1].Value.ToString();
            richTextBox1.Text = dgv.Rows[i].Cells[2].Value.ToString();
            textTg.Text = dgv.Rows[i].Cells[3].Value.ToString();
            comboTL.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void Phim_Load(object sender, EventArgs e)
        {
            load();
        }

        private void textMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                WebRequest request = WebRequest.Create("https://mfw060.wcom.vn/api/phim/" + labelId.Text);
                request.Method = "DELETE";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                    MessageBox.Show("Xoa thanh cong");
                else
                    MessageBox.Show("Co loi xay ra");
            load();

        }
    }
}
