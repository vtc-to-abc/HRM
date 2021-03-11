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

namespace FinalHRM
{
    public partial class frLogin : MetroFramework.Forms.MetroForm
    {
        public frLogin()
        {
            InitializeComponent();
        }

        SqlConnection a = new SqlConnection(@"Data Source=(local);Initial Catalog=FinalHRM;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            if ((usertxt.Text == "") || (passtxt.Text == ""))
            {

                errortk.SetError(usertxt, "Tài Khoản Lỗi");
                MessageBox.Show("Xin hãy Điền Đủ Thông Tin", "Thông Báo");
                return;
            }
            else
            {


                errortk.SetError(usertxt, "OK");

                SqlConnection scn = new SqlConnection();
                scn.ConnectionString = @"server=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=FinalHRM;integrated security=true";
                SqlCommand scmd = new SqlCommand("select count (*)  from Account where TenDangNhap=@usr and pass=@pwd", scn);
                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@usr", usertxt.Text);
                scmd.Parameters.AddWithValue("@pwd", passtxt.Text);
                scn.Open();
                if (scmd.ExecuteScalar().ToString() == "1")
                {

                    MessageBox.Show("đăng nhập thành công");
                    frMain h = new frMain();
                    h.Show();

                    this.Hide();
                }

                else
                {
                    usertxt.Clear();
                    passtxt.Clear();
                    MessageBox.Show("Kiểm Tra Lại Mật Khẩu Hoặc Tài Khoản");
                }
                scn.Close();

            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            if ((usertxt.Text == "") || (passtxt.Text == ""))
            {

                errortk.SetError(usertxt, "Tài Khoản Lỗi");
                MessageBox.Show("Xin hãy Điền Đủ Thông Tin", "Thông Báo");
                return;
            }
            else
            {


                errortk.SetError(usertxt, "OK");

                SqlConnection scn = new SqlConnection();
                scn.ConnectionString = @"server=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=FinalHRM;integrated security=true";
                SqlCommand scmd = new SqlCommand("select count (*)  from Account where username=@usr and pass=@pwd", scn);
                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@usr", usertxt.Text);
                scmd.Parameters.AddWithValue("@pwd", passtxt.Text);
                scn.Open();
                if (scmd.ExecuteScalar().ToString() == "1")
                {

                    MessageBox.Show("đăng nhập thành công");
                    frMain h = new frMain();
                    h.Show();

                    this.Hide();
                }

                else
                {
                    usertxt.Clear();
                    passtxt.Clear();
                    MessageBox.Show("Kiểm Tra Lại Mật Khẩu Hoặc Tài Khoản");
                }
                scn.Close();


            }
        }

        private void login_FromClose(object sender,FormClosedEventArgs e)
        {
            Application.Exit();
        }
       
        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
