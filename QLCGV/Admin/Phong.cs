using BAL;
using DTO;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QLCGV.Admin
{
    public partial class Phong : Form
    {
        PhongBAL phong = new PhongBAL();
        public Phong()
        {
            InitializeComponent();
        }
       

        private void Phong_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            PhongDTO phongDTO = new PhongDTO();
           
           
            try{
                if (txtMaPC.Text != "")
                {
                    throw new Exception("Vui long xoa ma truoc khi them du lieu");
                }
                if (txtTenPC.Text == "")
                {
                    throw new Exception("vui long nhap day du thong tin");
                }
                phongDTO.tenPhong = txtTenPC.Text;
                
                string query = string.Format("tenPhong={0}",phongDTO.tenPhong);
                bool check = phong.insertData(query);   

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


        private void btnXoa_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("https://mfw060.wcom.vn/api/phong/" + txtMaPC.Text);
            request.Method = "DELETE";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
                MessageBox.Show("Xoa thanh cong");
            else
                MessageBox.Show("Co loi xay ra");
            load();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Admin().Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PhongDTO phongDTO = new PhongDTO();
            try
            {
                if (txtMaPC.Text == "")
                {
                    throw new Exception("Vui long chon phim can xoa tren bang");
                }

                 phongDTO.tenPhong= txtTenPC.Text;
               
                string query = string.Format("tenPhong={0}",phongDTO.tenPhong);
                bool check = phong.updateData(query, int.Parse(txtMaPC.Text));
                if (check == true)
                {
                    MessageBox.Show("Cap nhat thanh cong!", "Thong Bao", MessageBoxButtons.OK);
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
            txtMaPC.Text = "";
            txtTenPC.Text = "";
        }
        private void load()
        {

            List<PhongDTO> ds = phong.readData();

            var list = new BindingList<PhongDTO>(ds);
            var source = new BindingSource(list, null);
            dgv.DataSource = source;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "tenPhong";
           
            clearText();
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dgv.CurrentRow.Index;
            txtMaPC.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtTenPC.Text = dgv.Rows[i].Cells[1].Value.ToString();

        }

        private void btnXoaMa_Click(object sender, EventArgs e)
        {
            clearText();
        }
    }

}

