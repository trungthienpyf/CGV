namespace CGV
{
    public partial class Form1 : Form
    {
        string tk = "admin";
        string mk = "admin";
        string tkuser = "user";
        string mkuser = "user";

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(textTk.Text == tk && textPass.Text == mk)
            {
                this.Hide();

                var admin = new Admin.Admin();
                admin.Show();

            }
            if (textTk.Text == tkuser && textPass.Text == mkuser)
            {
                this.Hide();
                var user = new User.User();
                user.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           new DangKy().Show();
         
        }
    }
}