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

namespace QLCGV.Admin
{
    public partial class Phim : Form
    {
        string _conn = "server=TRUNGTHIEN\\SQLEXPRESS; database=_QLRP; Integrated security=True";
       
        DataTable table = new DataTable();

        public Phim()
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
      
        private void button1_Click(object sender, EventArgs e)
        {
           
            
                        try
                        {
                            if (textPhim.Text == "" || textTg.Text == "" || comboTL.Text == "" || richTextBox1.Text == "")
                            {
                                throw new Exception("vui long nhap day du thong tin");
                            }
                            int selectedRow = getSelectedRow(textMa.Text);
                            if (selectedRow == -1)
                            {
                                
                                SqlConnection conn = new SqlConnection();
                                string query = "insert into Phim(maPhim,tenPhim,mota,thoigian,matheloai) values('" + textMa.Text + "','" + textPhim.Text + "','" + richTextBox1.Text + "','" + textTg.Text + "','" + comboTL.SelectedValue + "')";
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
                            string query = "update  Phim set tenPhim='" + textPhim.Text +"',mota='" + richTextBox1.Text +"', thoigian='" + textTg.Text +"',matheloai='" + comboTL.SelectedValue + "' where maPhim='" + textMa.Text + "'";
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

        private void getNameCategoryMovie()
        {
            SqlConnection conn = new SqlConnection();
            string query = "Select matheloai,tenTheLoai  from TheLoaiPhim";
            conn.ConnectionString = _conn;
            DataTable table2 = new DataTable();
            using (var adapter = new SqlDataAdapter(query, conn))
            {

                table2.Clear();
                adapter.Fill(table2);
                comboTL.DataSource = table2;
                comboTL.ValueMember = "matheloai";
                comboTL.DisplayMember = "tenTheLoai";

                /*   foreach (DataRow dr in table2.Rows)
                   {
                        comboTL.DataSource = dr; = "CategoryName";
                       comboTL.DisplayMember.Add(dr["tenTheLoai"].ToString());
   ComboForCategory.ValueMember = "CategoryId";

                        comboTL.Items.Add(dr["tenTheLoai"].ToString());
                         comboTL.
                         comboTL.Text = dr["tenTheLoai"].ToString();
            }
            */
            }
            conn.Close();
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
        private void Phim_Load(object sender, EventArgs e)
        {
            getNameCategoryMovie();
            load();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            int i ;
            i = dgv.CurrentRow.Index;
            textMa.Text = dgv.Rows[i].Cells[0].Value.ToString();
            textPhim.Text = dgv.Rows[i].Cells[1].Value.ToString();
            richTextBox1.Text = dgv.Rows[i].Cells[2].Value.ToString();
            textTg.Text = dgv.Rows[i].Cells[3].Value.ToString();
            comboTL.Text = dgv.Rows[i].Cells[4].Value.ToString();
           
          
        }
    }
}
