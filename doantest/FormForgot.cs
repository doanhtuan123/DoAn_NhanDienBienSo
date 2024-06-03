using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doantest
{
    public partial class FormForgot : Form
    {
        Modify modify;
        public FormForgot()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void get_password_Click(object sender, EventArgs e)
        {
            modify = new Modify();
            string email = textBox_emailforgot.Text;
            if(email.Trim() == "") { MessageBox.Show("Vui lòng nhập Email đăng kí");}
            else
            {
                string query = "SELECT * FROM Taikhoans where Email = '" + email + "' ";
                if(modify.TaiKhoans(query).Count != 0)
                {
                    label1.ForeColor = Color.Blue;
                    label1.Text = "PassWord: " + modify.TaiKhoans(query)[0].Password;
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Email chưa được đăng kí: ";
                }
            }


        }
    }
}
