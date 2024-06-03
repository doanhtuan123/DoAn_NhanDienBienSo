using Stripe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace doantest.Menu.Customer
{
    public partial class EditCustomer : Form
    {
        Modify1 modify1;
        doantest.Customer customer;
        public EditCustomer()
        {
            InitializeComponent();
        }

        private void CHECK_Click(object sender, EventArgs e)
        {
            modify1 = new Modify1();
            string id = text_ID.Text; // Giả sử bạn có một TextBox tên là txtId để nhập Id
            customer = modify1.GetCustomerById(id);

            if (customer != null)
            {
                textBox_fullname.Text = customer.Name; // Giả sử bạn có các TextBox để hiển thị thông tin khách hàng
                dTPBirthDate.Text = customer.Birday.ToShortDateString();
                textBox_phone.Text = customer.Phone;
                textBox_gneder.Text = customer.Gender;
                tbEmail.Text = customer.Email;
            }
            else
            {
                MessageBox.Show("Không tìm thấy Id Customer  này.");
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {

            string Id = this.text_ID.Text;
            string Name = this.textBox_fullname.Text;
            DateTime Birday = this.dTPBirthDate.Value;
            string Phone = this.textBox_phone.Text;
            string Gender = this.textBox_gneder.Text;
            string Email = this.tbEmail.Text;
            if (string.IsNullOrWhiteSpace(Id) || string.IsNullOrWhiteSpace(Name) ||
                Birday == DateTime.MinValue || string.IsNullOrWhiteSpace(Phone) ||
                string.IsNullOrWhiteSpace(Gender) || string.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Yêu cầu nhập đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            customer = new doantest.Customer(Id, Name, Birday, Phone, Gender, Email);
            if (modify1.update(customer))
            {
                MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_ID.Text = string.Empty; // Giả sử bạn có các TextBox để hiển thị thông tin khách hàng
                tbEmail.Text = string.Empty;
                textBox_phone.Text = string.Empty;
                textBox_fullname.Text = string.Empty;
                dTPBirthDate.Text = string.Empty;
                textBox_fullname.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Không thành công ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
