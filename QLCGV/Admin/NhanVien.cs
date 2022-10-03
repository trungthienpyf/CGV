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
        string _conn = "server=TRUNGTHIEN\\SQLEXPRESS; database=_QLRP; Integrated security=True";

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
                    throw new Exception("vui long nhap day du thong tin");
                }
                int selectedRow = getSelectedRow(txtID.Text);
                if (selectedRow == -1)
                {
                    SqlConnection conn = new SqlConnection();
                    string query = "insert into NhanVien(maNV,hoTenNV,matKhau,chucVu) values('" + txtID.Text + "','" + txtHoTen.Text + "','" + txtPass.Text + "','" + cmbCV.Text + "')";
                    conn.ConnectionString = _conn;

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Them moi du lieu thanh cong!", "Thong Bao", MessageBoxButtons.OK);
                    
                }
                else
                {
                    SqlConnection conn = new SqlConnection();
                    string query = "update  NhanVien set hoTenNV='" + txtHoTen.Text + "',matKhau='" + txtPass.Text + "', chucVu='" + cmbCV.Text + "',matheloai='" + "' where maNV='" + txtID.Text + "'";
                    conn.ConnectionString = _conn;

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Cap nhat du lieu thanh cong!", "Thong Bao", MessageBoxButtons.OK);
                    
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
            txtID.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtPass.Text = dgv.Rows[i].Cells[2].Value.ToString();
            cmbCV.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = getSelectedRow(txtID.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Khong tim thay Ma NV can xoa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Ban co muon xoa?", "Yes/No", MessageBoxButtons.YesNo);                 
                    if (dr == DialogResult.Yes)
                    {
                        dgv.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xoa SV thanh cong!", "Thong bao", MessageBoxButtons.OK);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
