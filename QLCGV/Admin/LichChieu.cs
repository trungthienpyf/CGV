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
using System.Globalization;

namespace QLCGV.Admin
{
    public partial class LichChieu : Form
    {
        LichChieuBAL  lichChieu = new LichChieuBAL();
        public LichChieu()
        {
            InitializeComponent();
        }
        private bool checkGio()
        {
            DateTime time1 = DateTime.ParseExact(texttime1.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime time2 = DateTime.ParseExact(texttime2.Text, "HH:mm:ss", CultureInfo.InvariantCulture);
            bool isvalid = time1 < time2;
            return isvalid;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LichChieuDTO lichChieuDTO = new LichChieuDTO();
            try
            {
                if (lbID.Text != "")
                {
                    throw new Exception("Vui long xoa ma truoc khi them du lieu");
                }
                if (texttime1.Text == "" || texttime2.Text == "" || comboTL.Text == "" || dateTimePicker1.Text == "")
                {
                    throw new Exception("vui long nhap day du thong tin");
                }
                if(checkGio()== false)
                {
                    throw new Exception("vui long nhap lai gio");
                }
                lichChieuDTO.gioBatDau = texttime1.Text;
                lichChieuDTO.gioKetThuc = texttime2.Text;
                lichChieuDTO.ngayChieu = dateTimePicker1.Text;
                lichChieuDTO.maPhong = comboTL.SelectedValue.ToString();
                string query = string.Format("gioBD={0}&gioKT={1}&Ngay={2}&MaP={3}",
                lichChieuDTO.gioBatDau, lichChieuDTO.gioKetThuc, lichChieuDTO.ngayChieu,lichChieuDTO.maPhong);
                bool check = lichChieu.insertData(query);
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
        private void load()
        {
           // getNameCategoryMovie();
            List<LichChieuDTO> ds = lichChieu.readData();

            var list = new BindingList<LichChieuDTO>(ds);
            var source = new BindingSource(list, null);
            dgv.DataSource = source;
            dgv.Columns[0].HeaderText = "id";
            dgv.Columns[0].HeaderText = "thoi gian bat dau";
            dgv.Columns[0].HeaderText = "thoi gian ket thuc";
            dgv.Columns[0].HeaderText = "ngay chieu";
            dgv.Columns[0].HeaderText = "ma phong";
            
        }
        //private void getNameCategoryMovie()
        //{


        //    phongBAL tlp = new phongBAL();
        //    var ds = tlp.readData();


        //    var list = new BindingList<phongBAL>(ds);
        //    var source = new BindingSource(list, null);
        //    comboTL.DataSource = source;

        //    comboTL.DisplayMember = "id";
        //    comboTL.DisplayMember = "tenPhong";

        //}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LichChieu_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LichChieuDTO lichChieuDTO = new LichChieuDTO();
            try
            {
                if (lbID.Text == "")
                {
                    throw new Exception("Vui long chon phim can xoa tren bang");
                }

                lichChieuDTO.gioBatDau = texttime1.Text;
                lichChieuDTO.gioKetThuc = texttime2.Text;
                lichChieuDTO.ngayChieu  = dateTimePicker1.Text;
                lichChieuDTO.maPhong = comboTL.SelectedValue.ToString();
                string query = string.Format("gioBD={0}&gioKT={1}&Ngay={2}&MaP={3}",
                lichChieuDTO.gioBatDau, lichChieuDTO.gioKetThuc, lichChieuDTO.ngayChieu,lichChieuDTO.maPhong);
                bool check = lichChieu.updateData(query, int.Parse(lbID.Text));
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

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            lbID.Text = dgv.Rows[i].Cells[0].Value.ToString();
            texttime1.Text = dgv.Rows[i].Cells[1].Value.ToString();
            texttime2.Text = dgv.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text = dgv.Rows[i].Cells[3].Value.ToString();
            comboTL.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("https://mfw060.wcom.vn/api/lichChieu/" + lbID.Text);
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
