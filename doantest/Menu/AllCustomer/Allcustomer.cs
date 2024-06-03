using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doantest.Menu.AllCustomer
{
    public partial class Allcustomer : Form
    {
        public Allcustomer()
        {
            InitializeComponent();
        }
        Modify1 modify1;
        private void dataGridView_datatable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Allcustomer_Load(object sender, EventArgs e)
        {
            modify1 = new Modify1();
            try
            {
                dataGridView_datatable.DataSource = modify1.getAllCustomer();

            }
            catch(Exception ex)
            {
                MessageBox.Show("loi" + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
