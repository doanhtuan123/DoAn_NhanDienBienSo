using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace doantest
{
    public partial class FormRegister : Form
    {
        Modify modify;
        public FormRegister()
        {
            InitializeComponent();
        }

        private void label_creat_Click(object sender, EventArgs e)
        {

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void button_cancel_click1(object sender, EventArgs e)
        {
            Close();
        }
        public bool Checkacc(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }

        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9.]{3,20}@gmail\.com(\.vn)?$");
        }
        private void button1_Singup_Click(object sender, EventArgs e)
        {
            modify = new Modify();
            string tentk = textBox_username1.Text;
            string matkhau = textBox_password1.Text;
            string xmatkhau = textBox_passwordcheck.Text;
            string email = textBox_email.Text;
            if(!Checkacc(tentk)) { MessageBox.Show("Vui lòng nhập UesrName dài khoảng 6-24 kí tự , với các ký tự chữ và số, chữ hoa và chữ thường");return; }
            if(!Checkacc(matkhau)){ MessageBox.Show("Vui lòng nhập PassWord dài 6-24 kí tự gồm các chữ hoa và chữ thường");return; }
            if(xmatkhau != matkhau) { MessageBox.Show("Xác nhận Password không chính xác ");return; }
            if (!CheckEmail(email)) { MessageBox.Show("Email không đúng định dạng");return; }
            if(modify.TaiKhoans("Select * from Taikhoans where Email = '" + email+"'").Count != 0) { MessageBox.Show("Email đã tồn tại");return; }
            try
            {
                string query = "insert into Taikhoans values ('"+tentk+"','"+matkhau+"','"+email+"')";
                modify.command(query);
                MessageBox.Show("Đăng kí tài khoản thành công ");
                Close();
            }
            catch
            {
                MessageBox.Show("UserName đã tồn tại! Vui lòng nhập UserName khác");
            }
        }
    }
}
