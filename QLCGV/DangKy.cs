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
using DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLCGV
{
    public partial class DangKy : Form
    {
      
       
        public DangKy()
        {
            InitializeComponent();
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
                ApiService dk = new ApiService();

                var list= dk.readData();

               var checkInclude =list.Where(p => p.sdt == textSdt.Text || p.email == textEmail.Text).FirstOrDefault();
                if (checkInclude!=null)
                {
                    throw new Exception("SDT hoac Email da bi trung!");

                }
                string query = string.Format("tenKhachHang={0}&sdt={1}&email={2}&matKhau={3}&diaChi{4}",
                textHt.Text, textSdt.Text, textEmail.Text, textMk.Text,richTextDc);
                bool check= dk.insertData(query);
  
                if (check == true)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!!", "Thông báo");
                    new Login().Show();
                    this.Close();
                }
                else
                {
                    throw new Exception("Có lỗi xảy ra");
                    
                  
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           
        }
    }
}
