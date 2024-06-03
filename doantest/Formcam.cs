using System;
using System.Drawing;
using System.Drawing.Imaging; // Thêm dòng này
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using doantest.Menu;

namespace doantest
{

    public partial class Formcam : Form
    {
        private FilterInfoCollection cam;
        //camera cụ thể ta chọn để chup
        private VideoCaptureDevice video;
        Modify1 modify1;
        Customer customer;

        string selectedImagePath;


        public Formcam()
        {
            InitializeComponent();
            cam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //đẩy camera đang kết nối với máy của chúng ta vào combobox cho ta chọn
            foreach (FilterInfo info in cam)
            {
                comboBox1.Items.Add(info.Name);
            }
            //mặc định là ta sẽ chọn camera đầu tiên trong combobox
            comboBox1.SelectedIndex = 0;
            timerSysterm.Start();

        }

        private void btn_batcam(object sender, EventArgs e)
        {

            video = new VideoCaptureDevice(cam[comboBox1.SelectedIndex].MonikerString);
            //camera này phải tạo 1 cái frame khác để chụp ảnh
            video.NewFrame += Video_NewFrame;
            video.Start();

            btn_parking.Enabled = true;
            btn_charge.Enabled = true;
            btn_Check.Enabled = true;


        }
        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //ảnh thu được từ camera
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            //show ảnh lên
            pictureBox_camera.Image = image;
        }

        private void btn_offcam_Click(object sender, EventArgs e)
        {
            if (video != null && video.IsRunning)
            {
                try
                {
                    video.SignalToStop(); // Thử sử dụng phương thức SignalToStop() thay vì Stop()
                    video.WaitForStop();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi dừng video: " + ex.Message);
                }

                pictureBox_camera.Image = null;

                // Đặt các nút khác về trạng thái ban đầu
                btn_parking.Enabled = true;
                btn_charge.Enabled = true;
                btn_Check.Enabled = true;
            }
            else
            {
                MessageBox.Show("Camera hiện tại không bật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if (video != null && video.IsRunning)
            {
                video.SignalToStop(); // Dừng video
                video.WaitForStop(); // Chờ cho video dừng lại hoàn toàn
            }
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

        private void btn_parking_Click(object sender, EventArgs e)
        {
            modify1 = new Modify1();
            string id = richTextBox_licenseplates.Text; // Giả sử bạn có một TextBox tên là txtId để nhập Id
            string id1 = ExtractIdInsideBrackets(id);
            customer = modify1.GetCustomerById(id1);

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
                MessageBox.Show("Id mới");

            }
        }

        private void btn_done_click(object sender, EventArgs e)
        {
            timerSysterm.Stop(); // Dừng timer

            if (video != null && video.IsRunning)
            {
                video.SignalToStop(); // Dừng video
                video.WaitForStop(); // Chờ cho video dừng lại hoàn toàn
                pictureBox_camera.Image = null;
            }

            Menuform menuform = new Menuform();
            this.Close();



        }

        private void btn_cap_clic(object sender, EventArgs e)
        {

            if (video != null && video.IsRunning)
            {
                dateTimePickerSystem.Value = DateTime.Now;
                video.SignalToStop();
                video.WaitForStop();

                if (pictureBox_camera.Image != null)
                {
                    Bitmap capturedImage = new Bitmap(pictureBox_camera.Image);
                    string savePath = @"D:\Workspace\doantest\doantest\image_cap\";
                    string fileName = "captured_image_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                    selectedImagePath = Path.Combine(savePath, fileName);
                    capturedImage.Save(selectedImagePath, ImageFormat.Jpeg);
                    pictureBox_recognize.Image = capturedImage;

                }

                video.Start();
            }
            else
            {
                MessageBox.Show("VUi lòng bật camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            richTextBox_licenseplates.Clear();
            // Kiểm tra xem hình ảnh từ camera đã được chụp chưa
            if (pictureBox_recognize.Image != null)
            {
                // Lưu hình ảnh từ pictureBox_camera vào một tập tin tạm thời
                string tempImagePath = Path.GetTempFileName() + ".jpg";
                pictureBox_recognize.Image.Save(tempImagePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                // Đọc dữ liệu của hình ảnh tạm thời và chuyển đổi thành base64
                byte[] imageData = File.ReadAllBytes(tempImagePath);
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
                try
                {
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    // Đọc dữ liệu từ phản hồi
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                        string responseText = reader.ReadToEnd();

                        // Hiển thị kết quả nhận được từ server trên richTextBox_licenseplates
                        richTextBox_licenseplates.AppendText(responseText + Environment.NewLine);
                    }
                }
                catch (WebException ex)
                {
                    // Xử lý lỗi nếu có
                    richTextBox_licenseplates.AppendText("Lỗi khi gửi yêu cầu: " + ex.Message + Environment.NewLine);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chụp hình trước khi kiểm tra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            txtName.Text = string.Empty; // Giả sử bạn có các TextBox để hiển thị thông tin khách hàng
            txtBirday.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void Formcam_Load(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timerSysterm_Tick_1(object sender, EventArgs e)
        {

        }

        private void btn_charge_Click(object sender, EventArgs e)
        {
            modify1 = new Modify1();
            string id = richTextBox_licenseplates.Text; // Giả sử bạn có một TextBox tên là txtId để nhập Id
            
            string Id = this.ExtractIdInsideBrackets(id);
            string Name = this.txtName.Text;
            DateTime Birday = this.txtBirday.Value;
            string Phone = this.txtPhone.Text;
            string Gender = this.txtGender.Text;
            string Email = this.txtEmail.Text;
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
                MessageBox.Show("ADD thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thành công ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }




}
