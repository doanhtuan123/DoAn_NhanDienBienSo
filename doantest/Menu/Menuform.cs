
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using doantest.Menu.Customer;
using doantest.Menu.AllCustomer;
using doantest.Menu.Statu;

namespace doantest.Menu
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void click_logout(object sender, EventArgs e)
        {
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button_timekeeping_Click(object sender, EventArgs e)
        {
            Formcam formcam = new Formcam();
            this.Visible = false; //ẩn thôi chứ khum tắt
            formcam.ShowDialog();
            this.Visible = true; //mở lại
            dataGridView_danhsach.Refresh();
        }

        private void button_image_reco_Click(object sender, EventArgs e)
        {
            FormImage formImage = new FormImage();
            this.Visible = false; //ẩn thôi chứ khum tắt
            formImage.ShowDialog();
            this.Visible = true; //mở lại
        }

        private void dataGridView_phancongtho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer Addcustomer = new AddCustomer();
            this.Visible = false;
            Addcustomer.ShowDialog();
            this.Visible = true;
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCustomer editCustomer = new EditCustomer();
            this.Visible = false;
            editCustomer.ShowDialog();
            this.Visible = true;
        }

        private void rEMOVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCustomer deleteCustomer = new DeleteCustomer();
            this.Visible = false;
            deleteCustomer.ShowDialog();
            this.Visible = true;
        }

        private void searchlStripMenuItem_Click(object sender, EventArgs e)
        {
            Allcustomer allcustomer = new Allcustomer();
            this.Visible = false;
            allcustomer.ShowDialog();
            this.Visible = true;
        }

        private void Menuform_Load(object sender, EventArgs e)
        {

        }

        private void totalRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void turnoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            total total = new total();
            this.Visible = false;
            total.ShowDialog();
            this.Visible = true;
        }
    }
}
