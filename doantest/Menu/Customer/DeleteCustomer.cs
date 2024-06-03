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
    public partial class DeleteCustomer : Form
    {
        Modify1 modify1;
        doantest.Customer customer;
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            modify1 = new Modify1();
            string id = txtID.Text; // Giả sử bạn có một TextBox tên là txtId để nhập Id
            customer = modify1.GetCustomerById(id);

            if (customer != null)
            {
                txtName.Text = customer.Name; // Giả sử bạn có các TextBox để hiển thị thông tin khách hàng
                txtBirday.Text = customer.Birday.ToShortDateString();
                txtPhone.Text = customer.Phone;
                txtGender.Text = customer.Gender;
                txtEmail.Text = customer.Email;
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng với Id này.");
            }
        }

        private void dataGridView_remove_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text; // Giả sử bạn có một TextBox tên là txtId để nhập Id

            if (modify1.DeleteCustomerById(id))
            {
                MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Text = string.Empty; // Giả sử bạn có các TextBox để hiển thị thông tin khách hàng
                txtBirday.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtGender.Text = string.Empty;
                txtEmail.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Xóa không thành công ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
