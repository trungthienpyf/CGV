using BAL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QLCGV.Admin
{
    public partial class NhanVien : Form
    {
        AdminBAL admin = new AdminBAL();

        public NhanVien()
        {
            InitializeComponent();
        }
        //ket noi SQL

        private void load()
        {
            List<AdminDTO> ds = admin.readData();

            var list = new BindingList<AdminDTO>(ds);
            var source = new BindingSource(list, null);
            dgv.DataSource = source;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "Tên Admin";
            dgv.Columns[2].HeaderText = "Tài Khoản";
            dgv.Columns[3].HeaderText = "Mật Khẩu";
            dgv.Columns[4].HeaderText = "Chức Vụ";
            clearText();

        }
        private void clearText()
        {
            lbID.Text = "";
            txtTenAdm.Text = "";
            txtAccount.Text = "";
            txtPass.Text = "";
            cmbCV.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Admin().Show();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            load();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            AdminDTO adminDTO = new AdminDTO();

            try
            {

                if (lbID.Text != "")
                {
                    throw new Exception("Vui lòng xóa mã trước khi nhập");
                }

                if (txtTenAdm.Text == "" || txtAccount.Text == "" || txtPass.Text == "" || cmbCV.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                AdminBAL ad = new AdminBAL();
                var list = ad.readData();

                var checkInclude = list.Where(p => p.TaiKhoan == txtAccount.Text).FirstOrDefault();
                if (checkInclude != null)
                {
                    throw new Exception("Tài khoản đã tồn tại!!!");
                }

                if (txtPass.Text.Length < 6)
                {
                    throw new Exception("Mật khẩu chứa ít nhất 6 ký tự!!");
                }
                adminDTO.TenAdmin = txtTenAdm.Text;
                adminDTO.TaiKhoan = txtAccount.Text;
                adminDTO.MatKhau = txtPass.Text;
                adminDTO.ChucVu = cmbCV.Text;
                string query = string.Format("tenAdmin={0}&taiKhoan={1}&matKhau={2}&chucVu={3}",
                    adminDTO.TenAdmin, adminDTO.TaiKhoan, adminDTO.MatKhau, adminDTO.ChucVu);
                /* byte[] bytes = Encoding.Default.GetBytes(query);
                 query = Encoding.UTF8.GetString(bytes);*/
                bool check = admin.insertData(query);

                if (check == true)
                {
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    load();
                }
                else
                {
                    throw new Exception("Thêm thất bại");
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
            txtTenAdm.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtAccount.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txtPass.Text = dgv.Rows[i].Cells[3].Value.ToString();
            cmbCV.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AdminDTO adminDTO = new AdminDTO();
            try
            {
                if (lbID.Text == "")
                {
                    throw new Exception("Vui lòng chọn nhân viên cần xóa!!!");
                }

                adminDTO.TenAdmin = txtTenAdm.Text;
                adminDTO.TaiKhoan = txtAccount.Text;
                adminDTO.MatKhau = txtPass.Text;
                adminDTO.ChucVu = cmbCV.Text;
                string query = string.Format("tenAdmin={0}&taiKhoan={1}&matKhau={2}&chucVu={3}",
                    adminDTO.TenAdmin, adminDTO.TaiKhoan, adminDTO.MatKhau, adminDTO.ChucVu);
                AdminBAL ad = new AdminBAL();
                var list = ad.readData();

                var checkInclude = list.Where(p => p.TaiKhoan == txtAccount.Text).FirstOrDefault();
                if (checkInclude != null)
                {
                    throw new Exception("Tài khoản đã tồn tại!!!");
                }
                bool check = admin.updateData(query, int.Parse(lbID.Text));
                if (check == true)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thong Bao", MessageBoxButtons.OK);
                    load();
                }
                else
                {
                    throw new Exception("Cập nhập thất bại!");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("https://mfw060.wcom.vn/api/admin/" + int.Parse(lbID.Text));
            MessageBox.Show(lbID.Text);
            request.Method = "DELETE";
            request.ContentType = @"application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Xoa thanh cong");

            }
            else
            {
                MessageBox.Show("Co loi xay ra");

            }
            
            load();
        }
    }
}
