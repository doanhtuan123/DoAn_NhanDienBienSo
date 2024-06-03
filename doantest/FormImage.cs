using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using doantest.Menu.Contract;

namespace doantest
{
    public partial class FormImage : Form
    {
        string selectedImagePath;
        Modify1 modify1;
        Customer customer;
        public FormImage()
        {
            InitializeComponent();
        }

        private void FormImage_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;

                // Kiểm tra xem tệp hình ảnh có tồn tại không
                if (File.Exists(selectedImagePath))
                {
                    // Hiển thị hình ảnh lên PictureBox
                    pictureBox_image.Image = Image.FromFile(selectedImagePath);
                    pictureBox_image.SizeMode = PictureBoxSizeMode.StretchImage; // Hiển thị ảnh với kích thước phù hợp trong PictureBox

                    // Hiển thị đường dẫn tệp hình ảnh trong RichTextBox
                    richTextBox1.Text = selectedImagePath;
                }
                else
                {
                    MessageBox.Show("Không thể tìm thấy tệp hình ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_cancel_imgae_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_check_image_Click(object sender, EventArgs e)
        {
            richTextBox_image.Clear();

            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                try
                {
                    // Đọc dữ liệu của hình ảnh và chuyển đổi thành base64
                    byte[] imageData = File.ReadAllBytes(selectedImagePath);
                    string encodedImage = Convert.ToBase64String(imageData);

                    // URL của server
                    string url = "http://192.168.98.100:8000//detect_plate";


                    // Tạo dữ liệu POST
                    string postData = "image=" + Uri.EscapeDataString(encodedImage);

                    // Chuyển dữ liệu POST thành mảng byte
                    byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                    // Tạo yêu cầu
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.ContentLength = byteArray.Length;

                    // Ghi dữ liệu vào luồng yêu cầu
                    using (Stream dataStream = request.GetRequestStream())
                    {
                        dataStream.Write(byteArray, 0, byteArray.Length);
                    }

                    // Nhận phản hồi từ server
                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    {
                        // Đọc dữ liệu từ phản hồi
                        using (Stream responseStream = response.GetResponseStream())
                        {
                            StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                            string responseText = reader.ReadToEnd();

                            // Hiển thị chỉ biển số xe trong ô richTextBox_licenseplates
                            richTextBox_image.AppendText(responseText + Environment.NewLine);
                        }
                    }

                }
                catch (WebException ex)
                {
                    // Xử lý lỗi nếu có
                    richTextBox_image.AppendText("Lỗi khi gửi yêu cầu: " + ex.Message + Environment.NewLine);
                }
                catch (FormatException ex)
                {
                    // Xử lý lỗi nếu có
                    richTextBox_image.AppendText("Lỗi khi chuyển đổi hình ảnh: " + ex.Message + Environment.NewLine);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hình ảnh trước khi kiểm tra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtName.Text = string.Empty; // Giả sử bạn có các TextBox để hiển thị thông tin khách hàng
            txtBirday.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }




        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public string ExtractIdInsideBrackets(string id)
        {
            // Tìm vị trí của dấu ngoặc mở và đóng
            int startIndex = id.IndexOf('"');
            int endIndex = id.LastIndexOf('"');


            // Kiểm tra xem cả hai dấu ngoặc đều tồn tại trong chuỗi
            if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
            {
                // Lấy phần bên trong dấu ngoặc
                return id.Substring(startIndex + 1, endIndex - startIndex - 1);
            }

            // Nếu không tìm thấy dấu ngoặc, trả về chuỗi gốc hoặc xử lý lỗi
            return id;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            modify1 = new Modify1();
            string id = richTextBox_image.Text; // Giả sử bạn có một TextBox tên là txtId để nhập Id
            string extractedId = ExtractIdInsideBrackets(id);
            customer = modify1.GetCustomerById(extractedId);

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
    }
}
