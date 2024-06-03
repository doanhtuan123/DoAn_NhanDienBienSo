using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doantest.Menu.Statu
{
    public partial class total : Form
    {
        public total()
        {
            InitializeComponent();
            var imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Image";
            imageColumn.Name = "ImageColumn";
            dataGridView1.Columns.Add(imageColumn);

            // Thêm cột nhãn
            var labelColumn = new DataGridViewTextBoxColumn();
            labelColumn.HeaderText = "Label";
            labelColumn.Name = "LabelColumn";
            dataGridView1.Columns.Add(labelColumn);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Statu_Load(object sender, EventArgs e)
        {
            string imagesPath = @"D:\Workspace\doantest\doantest\image_cap\";
            dataGridView1.Refresh();
            // Đảm bảo thư mục tồn tại
            if (Directory.Exists(imagesPath))
            {
                // Lấy danh sách các file ảnh trong thư mục
                string[] imageFiles = Directory.GetFiles(imagesPath, "*.jpg");

                foreach (string imageFile in imageFiles)
                {
                    // Tải hình ảnh
                    Image img = Image.FromFile(imageFile);

                    // Tên file ảnh sẽ là nhãn của ảnh
                    string label = Path.GetFileNameWithoutExtension(imageFile);

                    // Thêm ảnh và nhãn vào DataGridView
                    dataGridView1.Rows.Add(img, label);

                }
            }
            else
            {
                MessageBox.Show("The specified directory does not exist.");
            }
        }
    }
}
