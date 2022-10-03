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

namespace QLCGV.Admin
{
    public partial class LichChieu : Form
    {
        string _conn = @"server=LAPTOP-PCHHO158\\SQLEXPRESS; database=_QLRP; Integrated security=True";

        DataTable table = new DataTable();

        public LichChieu()
        {
            InitializeComponent();
        }
        private int getSelectedRow(string id)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells[0].Value.ToString() == id)
                {
                    return i;
                }
            }
            return -1;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (texttime1.Text == "" || texttime2.Text == ""  || dateTimePicker1.Text == "")
                {
                    throw new Exception("vui long nhap day du thong tin");
                }
                int selectedRow = getSelectedRow(txtlichchieu.Text);
                if (selectedRow == -1)
                {
                    SqlConnection conn = new SqlConnection();
                    string query = "insert into Phim(maLichChieu,gioBatDau,gioKetThuc,ngayChieu,maPhong) values('" + txtlichchieu.Text + "','" + texttime1.Text + "','" + texttime2.Text + "','" + dateTimePicker1.Text + "','" + comboTL.SelectedValue + "')";
                    conn.ConnectionString = _conn;

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Them moi du lieu thanh cong!", "Thong Bao", MessageBoxButtons.OK);
                    load();
                }
                else
                {
                    SqlConnection conn = new SqlConnection();
                    string query = "update  LICHCHIEU set gioBatDau='" + texttime1.Text + "',gioKetThuc='" + texttime2.Text + "', ngayChieu='" + dateTimePicker1.Text + "',maPhong='" + comboTL.SelectedValue + "' where maLichChieu='" + txtlichchieu.Text + "'";
                    conn.ConnectionString = _conn;

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Cap nhat du lieu thanh cong!", "Thong Bao", MessageBoxButtons.OK);
                    load();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
        private void load()
        {
            SqlConnection conn = new SqlConnection();

            string query = "Select maPhim as #,tenPhim as 'Tên phim',mota as 'Mô tả',thoigian as 'Thời lượng phim',tenTheLoai as 'Thể loại' from Phim join TheLoaiPhim on Phim.maTheLoai=TheloaiPhim.maTheLoai";

            conn.ConnectionString = _conn;

            using (var adapter = new SqlDataAdapter(query, conn))
            {

                table.Clear();
                adapter.Fill(table);
                this.dgv.DataSource = table;


            }

            conn.Close();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void LichChieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_QLRPDataSet2.LICHCHIEU' table. You can move, or remove it, as needed.
            this.lICHCHIEUTableAdapter.Fill(this._QLRPDataSet2.LICHCHIEU);
            // TODO: This line of code loads data into the '_QLRPDataSet1.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this._QLRPDataSet1.PHONG);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn quay trở về trang đăng ký ","cảnh báo",MessageBoxButtons.OK)==DialogResult.Yes)
            
                this.Hide();
                new DangKy().Show();           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DateTime iDate;
            iDate = dateTimePicker1.Value;
            MessageBox.Show("Bạn đã lựa chọn: " + iDate);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            txtlichchieu.Text = dgv.Rows[i].Cells[0].Value.ToString();
            texttime1.Text = dgv.Rows[i].Cells[1].Value.ToString();
            texttime2.Text = dgv.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text = dgv.Rows[i].Cells[3].Value.ToString();
            comboTL.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }
    }
}
