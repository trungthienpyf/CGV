using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace QLCGV
{
    public partial class DangKy : Form
    {
        string _conn = "server=TRUNGTHIEN\\SQLEXPRESS; database=_QLRP; Integrated security=True";
       
        public DangKy()
        {
            InitializeComponent();
        }
        void connDB()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = _conn;
                conn.Open();
                MessageBox.Show("Thanh Cong");
                conn.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            try {
                
                if (string.IsNullOrEmpty(textHt.Text.Trim()))
                {
                    throw new Exception("Vui lòng nhập họ và tên");
                    
                }
                if (string.IsNullOrEmpty(textSdt.Text.Trim()))
                {
                    throw new Exception("Vui lòng nhập Số điện thoại");

                }

                if (string.IsNullOrEmpty(textEmail.Text.Trim()))
                {
                    throw new Exception("Vui lòng nhập Email");

                }
                Regex mRegxExpression;
                if (textSdt.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"(09|01)[0-9]{8}$");

                    if (!mRegxExpression.IsMatch(textSdt.Text.Trim()))
                    {
                        throw new Exception("Vui lòng nhập SDT chính xác!!!");

                    }
                }
                if (textEmail.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                    if (!mRegxExpression.IsMatch(textEmail.Text.Trim()))
                    {
                        throw new Exception("Vui lòng nhập Email");

                    }
                }
               
                    
                
                if (string.IsNullOrEmpty(textMk.Text.Trim()))
                {
                    throw new Exception("Vui lòng nhập Password");

                }
              
                bool check = false;
                string query2 = "select * from khachhang where SDT=@SDT or email=@Email";
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = _conn;
                SqlCommand cmd2 = new SqlCommand(query2, conn);

                conn.Open();
                string query = "insert into khachhang(tenKhachHang,SDT,Email,diaChi,matKhau) values(@tenKhachHang,@SDT,@Email,@diaChi,@matKhau)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenKhachHang", textHt.Text);
                cmd.Parameters.AddWithValue("@SDT", textSdt.Text);
                cmd.Parameters.AddWithValue("@Email", textEmail.Text);
             //  cmd.Parameters.Add("@Email", SqlDbType.String).Value = Convert.ToString(textEmail.Text);
                cmd2.Parameters.AddWithValue("@SDT", textSdt.Text);
                cmd2.Parameters.AddWithValue("@Email", textEmail.Text);
                cmd.Parameters.AddWithValue("@diaChi", richTextDc.Text);
                cmd.Parameters.AddWithValue("@matKhau", textMk.Text);


                SqlDataReader reader = cmd2.ExecuteReader();

                // cmd.Parameters.AddWithValue("@HoTen", textMSSV1.Text);
                while (reader.Read())
                {
                    check = true;

                }
                reader.Close();

                if (check == true)
                {
                  throw new Exception("Sdt hoặc email đã tồn tại");
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký tài khoản thành công!!", "Thông báo");
                    new Login().Show();
                    this.Close();
                }


                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           
        }
    }
}
