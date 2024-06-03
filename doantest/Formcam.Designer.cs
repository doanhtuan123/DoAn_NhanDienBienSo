namespace doantest
{
    partial class Formcam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            saveFileDialog1 = new SaveFileDialog();
            button_done = new Button();
            pictureBox_recognize = new PictureBox();
            btn_charge = new Button();
            timerSysterm = new System.Windows.Forms.Timer(components);
            btn_offcam = new Button();
            btn_cap = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txtGender = new TextBox();
            txtName = new TextBox();
            txtBirday = new DateTimePicker();
            txtPhone = new TextBox();
            btn_cam = new Button();
            richTextBox_licenseplates = new RichTextBox();
            label_licenseplates = new Label();
            dateTimePickerSystem = new DateTimePicker();
            btn_Check = new Button();
            btn_parking = new Button();
            comboBox1 = new ComboBox();
            pictureBox_camera = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox_recognize).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_camera).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Jpeg image|*.jpeg|Png image|*.png|Gif image|*.gif";
            // 
            // button_done
            // 
            button_done.BackColor = Color.Transparent;
            button_done.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button_done.Location = new Point(1176, 741);
            button_done.Name = "button_done";
            button_done.Size = new Size(154, 34);
            button_done.TabIndex = 36;
            button_done.Text = "Done";
            button_done.UseVisualStyleBackColor = false;
            button_done.Click += btn_done_click;
            // 
            // pictureBox_recognize
            // 
            pictureBox_recognize.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_recognize.Location = new Point(962, 78);
            pictureBox_recognize.Name = "pictureBox_recognize";
            pictureBox_recognize.Size = new Size(369, 137);
            pictureBox_recognize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_recognize.TabIndex = 35;
            pictureBox_recognize.TabStop = false;
            // 
            // btn_charge
            // 
            btn_charge.BackColor = Color.Transparent;
            btn_charge.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_charge.Location = new Point(1176, 685);
            btn_charge.Name = "btn_charge";
            btn_charge.Size = new Size(154, 34);
            btn_charge.TabIndex = 31;
            btn_charge.Text = "Add";
            btn_charge.UseVisualStyleBackColor = false;
            btn_charge.Click += btn_charge_Click;
            // 
            // timerSysterm
            // 
            timerSysterm.Tick += timerSysterm_Tick_1;
            // 
            // btn_offcam
            // 
            btn_offcam.BackColor = Color.Transparent;
            btn_offcam.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_offcam.Location = new Point(393, 721);
            btn_offcam.Name = "btn_offcam";
            btn_offcam.Size = new Size(193, 50);
            btn_offcam.TabIndex = 25;
            btn_offcam.Text = "Turn off Camera";
            btn_offcam.UseVisualStyleBackColor = false;
            btn_offcam.Click += btn_offcam_Click;
            // 
            // btn_cap
            // 
            btn_cap.BackColor = Color.Transparent;
            btn_cap.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_cap.Location = new Point(393, 666);
            btn_cap.Name = "btn_cap";
            btn_cap.Size = new Size(193, 50);
            btn_cap.TabIndex = 24;
            btn_cap.Text = "Capture";
            btn_cap.UseVisualStyleBackColor = false;
            btn_cap.Click += btn_cap_clic;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtGender);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtBirday);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(button_done);
            groupBox1.Controls.Add(pictureBox_recognize);
            groupBox1.Controls.Add(btn_charge);
            groupBox1.Controls.Add(btn_offcam);
            groupBox1.Controls.Add(btn_cap);
            groupBox1.Controls.Add(btn_cam);
            groupBox1.Controls.Add(richTextBox_licenseplates);
            groupBox1.Controls.Add(label_licenseplates);
            groupBox1.Controls.Add(dateTimePickerSystem);
            groupBox1.Controls.Add(btn_Check);
            groupBox1.Controls.Add(btn_parking);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(pictureBox_camera);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1381, 792);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(977, 532);
            label5.Name = "label5";
            label5.Size = new Size(50, 18);
            label5.TabIndex = 201;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(977, 459);
            label4.Name = "label4";
            label4.Size = new Size(63, 18);
            label4.TabIndex = 200;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(977, 394);
            label3.Name = "label3";
            label3.Size = new Size(120, 18);
            label3.TabIndex = 199;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(977, 343);
            label2.Name = "label2";
            label2.Size = new Size(69, 18);
            label2.TabIndex = 198;
            label2.Text = "Birthday";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(977, 282);
            label1.Name = "label1";
            label1.Size = new Size(84, 18);
            label1.TabIndex = 197;
            label1.Text = "Full Name";
            // 
            // txtEmail
            // 
            txtEmail.AccessibleName = "";
            txtEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtEmail.Location = new Point(1098, 532);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 32);
            txtEmail.TabIndex = 196;
            // 
            // txtGender
            // 
            txtGender.AccessibleName = "";
            txtGender.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtGender.Location = new Point(1099, 394);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(232, 32);
            txtGender.TabIndex = 195;
            // 
            // txtName
            // 
            txtName.AccessibleName = "";
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtName.Location = new Point(1098, 282);
            txtName.Name = "txtName";
            txtName.Size = new Size(232, 32);
            txtName.TabIndex = 192;
            // 
            // txtBirday
            // 
            txtBirday.AccessibleName = "";
            txtBirday.CustomFormat = "yyyy-MM-dd";
            txtBirday.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtBirday.Format = DateTimePickerFormat.Custom;
            txtBirday.Location = new Point(1098, 343);
            txtBirday.Name = "txtBirday";
            txtBirday.Size = new Size(232, 32);
            txtBirday.TabIndex = 193;
            txtBirday.Value = new DateTime(2022, 5, 20, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            txtPhone.AccessibleName = "";
            txtPhone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPhone.Location = new Point(1099, 459);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(232, 32);
            txtPhone.TabIndex = 194;
            // 
            // btn_cam
            // 
            btn_cam.BackColor = Color.Transparent;
            btn_cam.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_cam.Location = new Point(393, 610);
            btn_cam.Name = "btn_cam";
            btn_cam.Size = new Size(193, 50);
            btn_cam.TabIndex = 23;
            btn_cam.Text = "Turn on Camera";
            btn_cam.UseVisualStyleBackColor = false;
            btn_cam.Click += btn_batcam;
            // 
            // richTextBox_licenseplates
            // 
            richTextBox_licenseplates.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox_licenseplates.Location = new Point(962, 24);
            richTextBox_licenseplates.Name = "richTextBox_licenseplates";
            richTextBox_licenseplates.Size = new Size(369, 48);
            richTextBox_licenseplates.TabIndex = 26;
            richTextBox_licenseplates.Text = "";
            // 
            // label_licenseplates
            // 
            label_licenseplates.AutoSize = true;
            label_licenseplates.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label_licenseplates.Location = new Point(959, 3);
            label_licenseplates.Name = "label_licenseplates";
            label_licenseplates.Size = new Size(114, 17);
            label_licenseplates.TabIndex = 32;
            label_licenseplates.Text = "License Plates";
            // 
            // dateTimePickerSystem
            // 
            dateTimePickerSystem.CustomFormat = " MMMM dd, yyyy | hh: mm: ss : tt";
            dateTimePickerSystem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dateTimePickerSystem.Format = DateTimePickerFormat.Custom;
            dateTimePickerSystem.Location = new Point(956, 220);
            dateTimePickerSystem.Name = "dateTimePickerSystem";
            dateTimePickerSystem.Size = new Size(374, 23);
            dateTimePickerSystem.TabIndex = 27;
            dateTimePickerSystem.Value = new DateTime(2022, 5, 2, 0, 0, 0, 0);
            // 
            // btn_Check
            // 
            btn_Check.BackColor = SystemColors.ActiveCaption;
            btn_Check.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Check.ForeColor = SystemColors.ActiveCaptionText;
            btn_Check.Location = new Point(1001, 686);
            btn_Check.Name = "btn_Check";
            btn_Check.Size = new Size(154, 33);
            btn_Check.TabIndex = 29;
            btn_Check.Text = "Check";
            btn_Check.UseVisualStyleBackColor = false;
            btn_Check.Click += btn_Check_Click;
            // 
            // btn_parking
            // 
            btn_parking.BackColor = Color.Transparent;
            btn_parking.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_parking.Location = new Point(1001, 739);
            btn_parking.Name = "btn_parking";
            btn_parking.Size = new Size(154, 36);
            btn_parking.TabIndex = 28;
            btn_parking.Text = "Info";
            btn_parking.UseVisualStyleBackColor = false;
            btn_parking.Click += btn_parking_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.HighlightText;
            comboBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 555);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(386, 25);
            comboBox1.TabIndex = 21;
            // 
            // pictureBox_camera
            // 
            pictureBox_camera.BackColor = SystemColors.ButtonHighlight;
            pictureBox_camera.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_camera.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_camera.Location = new Point(0, 3);
            pictureBox_camera.Name = "pictureBox_camera";
            pictureBox_camera.Size = new Size(942, 537);
            pictureBox_camera.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_camera.TabIndex = 22;
            pictureBox_camera.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(61, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1381, 792);
            panel1.TabIndex = 1;
            // 
            // Formcam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1502, 809);
            Controls.Add(panel1);
            Name = "Formcam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formcam";
            Load += Formcam_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_recognize).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_camera).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void btn_cap_click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private SaveFileDialog saveFileDialog1;
        private Button button_done;
        private PictureBox pictureBox_recognize;
        private Button btn_charge;
        private System.Windows.Forms.Timer timerSysterm;
        private Button btn_offcam;
        private Button btn_cap;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox1;
        private Button btn_cam;
        private RichTextBox richTextBox_licenseplates;
        private Label label_licenseplates;
        private DateTimePicker dateTimePickerSystem;
        private Button btn_Check;
        private Button btn_parking;
        private ComboBox comboBox1;
        public PictureBox pictureBox_camera;
        private Panel panel1;
        private TextBox txtEmail;
        private TextBox txtGender;
        private TextBox txtName;
        private DateTimePicker txtBirday;
        private TextBox txtPhone;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}