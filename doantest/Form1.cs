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
using doantest.Menu;
namespace doantest
{
    public partial class LoginForm : Form
    {
        Modify modify;
        public LoginForm()
        {
            InitializeComponent();
            textBox_username.ForeColor = Color.LightGray;
            textBox_username.Text = "Enter your Username";
            this.textBox_username.Leave += new System.EventHandler(this.Textbox_username_leave);
            this.textBox_username.Enter += new System.EventHandler(this.Textbox_uesrname_enter);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_cancel_click(object sender, EventArgs e)
        {
            Close();
        }

        private void Textbox_uesrname_enter(object sender, EventArgs e)
        {
            if (textBox_username.Text == "Enter your Username")
            {
                textBox_username.Text = "";
                textBox_username.ForeColor = Color.Black;
            }
        }

        private void Textbox_username_leave(object sender, EventArgs e)
        {
            if (textBox_username.Text == "")
            {
                textBox_username.Text = "Enter your Username";
                textBox_username.ForeColor = Color.Gray;
            }
        }
        
        private void button_login_Click(object sender, EventArgs e)
        {
            modify = new Modify();
            string tentk = textBox_username.Text.Trim();
            string matkhau = textBox_pass.Text.Trim();

            if (tentk == "")
            {
                MessageBox.Show("Nhập tên đăng nhập");
            }
            else if (matkhau == "")
            {
                MessageBox.Show("Nhập mật khẩu");
            }
            else
            {
                // Sử dụng tham số truy vấn để tránh injection SQL
                string query = "SELECT * FROM Taikhoans WHERE Uesrname = '" + tentk + "'  AND Password= '" + matkhau + "'";
                if (modify.TaiKhoans(query).Count > 0)
                {
                    Menuform menuForm = new Menuform();
                    this.Visible = false; //ẩn thôi chứ khum tắt
                    menuForm.ShowDialog();
                    this.Visible = true; //mở lại
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }             
}
        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lable_register_click(object sender, EventArgs e)
        {

           

        }

        private void lable_forgot_click(object sender, EventArgs e)
        {
            FormForgot a = new FormForgot();
            this.Visible = false; //ẩn thôi chứ khum tắt
            a.ShowDialog(); //show chạy song song khác với showDialog dừng chạy form hiện tại rồi mở form mà mình muốn mở
            this.Visible = true; //mở lại
        }
    }
}
