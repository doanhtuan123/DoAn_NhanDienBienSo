using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using doantest;
using Stripe;

namespace doantest.Menu.Customer
{
    public partial class AddCustomer : Form
    {
        Modify1 modify1;
        doantest.Customer customer;
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            modify1 = new Modify1();
            string Id = this.textBox_Id.Text;
            string Name = this.textBox_fullname.Text;
            DateTime Birday = this.dTPBirthDate.Value;
            string Phone = this.textBox_phone.Text;
            string Gender = this.textBox_gender.Text;
            string Email = this.tbEmail.Text;
            if (string.IsNullOrWhiteSpace(Id) || string.IsNullOrWhiteSpace(Name) ||
                Birday == DateTime.MinValue || string.IsNullOrWhiteSpace(Phone) ||
                string.IsNullOrWhiteSpace(Gender) || string.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Yêu cầu nhập đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                customer = new doantest.Customer(Id, Name, Birday, Phone, Gender, Email);

            if (modify1.insert(customer))
            {
                MessageBox.Show("Add thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
