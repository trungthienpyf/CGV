using BAL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class KhachHang : Form
    {
        KhachHangBAL khachHangBAl = new KhachHangBAL();
        public KhachHang()
        {
            InitializeComponent();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHangDTO khachHangDTO = new KhachHangDTO();
            try
            {
                if(txtID.Text == "" || txtTenKH.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtMatKhau.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin cá nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else
                {
                    khachHangDTO.tenKhachHang = txtTenKH.Text;
                    khachHangDTO.ID = int.Parse(txtID.Text);
                    khachHangDTO.sdt = txtSDT.Text;
                    khachHangDTO.email = txtEmail.Text;
                    khachHangDTO.matKhau = txtMatKhau.Text;
                    khachHangDTO.diaChi = txtDiaChi.Text;
                    string query = string.Format("id={0}&tenKhachhang={1}&SDT={2}&email={3}&matKhau={4}",
                    khachHangDTO.ID, khachHangDTO.tenKhachHang, khachHangDTO.sdt, khachHangDTO.email, khachHangDTO.matKhau);
                    bool checkStatus = khachHangBAl.updateData(query, int.Parse(txtID.Text));
                    if(checkStatus == true)
                    {
                        MessageBox.Show("Cập nhật khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refesh();
                    }else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("https://mfw060.wcom.vn/api/khachHang/" + txtID.Text);
            request.Method = "DELETE";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có lỗi xảy ra !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ReLoad();
            Refesh();
        }
       
        private void Refesh()
        {
            txtID.Text = "";
            txtTenKH.Text = "";
            txtEmail.Text = "";
            txtMatKhau.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }


        private void ReLoad()
        {
            List<KhachHangDTO> list = khachHangBAl.readData();

            var LITS = new BindingList<KhachHangDTO>(list);
            var source = new BindingSource(list, null);
            dgvKhachHang.DataSource = source;
            dgvKhachHang.Columns[0].HeaderText = "ID";
            dgvKhachHang.Columns[1].HeaderText = "Tên Khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "SĐT";
            dgvKhachHang.Columns[3].HeaderText = "Email";
            dgvKhachHang.Columns[4].HeaderText = "Mật khẩu";
            dgvKhachHang.Columns[5].HeaderText = "Địa chỉ";
            
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvKhachHang.ReadOnly = true;
            int i;
            i = dgvKhachHang.CurrentRow.Index;
            txtID.Text = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
            txtEmail.Text = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
            txtMatKhau.Text = dgvKhachHang.Rows[i].Cells[4].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[i].Cells[5].Value.ToString();
        }
    }
}
