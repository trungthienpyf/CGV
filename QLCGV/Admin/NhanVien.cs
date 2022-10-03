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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        //ket noi SQL
        string _conn = "server=LAPTOP-FL07KQOI; database=_QLRP; Integrated security=True";

        DataTable table = new DataTable();

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

        private void btnUpdate_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Text == "" || txtPass.Text == "" || cmbCV.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                if (txtPass.Text.Length < 6)
                {
                    throw new Exception("Mật khẩu phải đủ 6 ký tự");
                }
                int selectedRow = getSelectedRow(txtID.Text);
                if (selectedRow == -1)
                {
                    SqlConnection conn = new SqlConnection();
                    string query = "insert into Admin(maAdmin,tenAdmin,chucVu, matKhau) values('" + txtID.Text + "','" + txtHoTen.Text + "','" + cmbCV.Text + "','" + txtPass.Text + "')";
                    conn.ConnectionString = _conn;

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    load();
                }
                else
                {
                    SqlConnection conn = new SqlConnection();
                    string query = "update  Admin set tenAdmin='" + txtHoTen.Text + "', chucVu='" + cmbCV.Text + "',matKhau='" + txtPass.Text + "' where maAdmin='" + txtID.Text + "'";
                    conn.ConnectionString = _conn;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
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
            string query = "Select * from Admin ";

            conn.ConnectionString = _conn;

            using (var adapter = new SqlDataAdapter(query, conn))
            {
                table.Clear();
                adapter.Fill(table);
                this.dgv.DataSource = table;
            }
            conn.Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            txtID.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgv.Rows[i].Cells[1].Value.ToString(); 
            cmbCV.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txtPass.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = getSelectedRow(txtID.Text);

                if (selectedRow == -1)
                {
                    throw new Exception("Không có phòng để xóa ");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa? ", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgv.Rows.RemoveAt(selectedRow);

                        SqlConnection conn = new SqlConnection();
                        string query = "DELETE dbo.Admin  where maAdmin=" + txtID.Text;
                        conn.ConnectionString = _conn;
                        SqlCommand cmd = new SqlCommand(query, conn);
                        conn.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                        load();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Admin().Show();
        }

        private void NV_Load(object sender, EventArgs e)
        {
            load();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_QLRPDataSet1.ADMIN' table. You can move, or remove it, as needed.
            this.aDMINTableAdapter.Fill(this._QLRPDataSet1.ADMIN);

        }
    }
}
