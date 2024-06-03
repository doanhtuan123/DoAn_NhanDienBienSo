namespace doantest
{
    partial class FormForgot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgot));
            pictureBox_forgot = new PictureBox();
            label_email1 = new Label();
            textBox_emailforgot = new TextBox();
            label_forgot = new Label();
            get_password = new Button();
            button1_cancel1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_forgot).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_forgot
            // 
            pictureBox_forgot.Image = (Image)resources.GetObject("pictureBox_forgot.Image");
            pictureBox_forgot.Location = new Point(276, 104);
            pictureBox_forgot.Name = "pictureBox_forgot";
            pictureBox_forgot.Size = new Size(54, 50);
            pictureBox_forgot.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_forgot.TabIndex = 15;
            pictureBox_forgot.TabStop = false;
            // 
            // label_email1
            // 
            label_email1.AutoSize = true;
            label_email1.BackColor = Color.LightSteelBlue;
            label_email1.Font = new Font("Lucida Bright", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label_email1.Location = new Point(72, 181);
            label_email1.Name = "label_email1";
            label_email1.Size = new Size(152, 18);
            label_email1.TabIndex = 14;
            label_email1.Text = "registration email:";
            // 
            // textBox_emailforgot
            // 
            textBox_emailforgot.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_emailforgot.Location = new Point(72, 218);
            textBox_emailforgot.Name = "textBox_emailforgot";
            textBox_emailforgot.Size = new Size(280, 26);
            textBox_emailforgot.TabIndex = 13;
            textBox_emailforgot.TextChanged += textBox_email_TextChanged;
            // 
            // label_forgot
            // 
            label_forgot.AutoSize = true;
            label_forgot.BackColor = Color.LightSteelBlue;
            label_forgot.Font = new Font("Wide Latin", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label_forgot.ForeColor = SystemColors.HotTrack;
            label_forgot.Location = new Point(50, 57);
            label_forgot.Name = "label_forgot";
            label_forgot.Size = new Size(492, 29);
            label_forgot.TabIndex = 12;
            label_forgot.Text = "FORGOT  PASSWORD";
            // 
            // get_password
            // 
            get_password.Font = new Font("Lucida Bright", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            get_password.Location = new Point(99, 338);
            get_password.Name = "get_password";
            get_password.Size = new Size(231, 41);
            get_password.TabIndex = 16;
            get_password.Text = "Get PassWord";
            get_password.UseVisualStyleBackColor = true;
            get_password.Click += get_password_Click;
            // 
            // button1_cancel1
            // 
            button1_cancel1.AutoSize = true;
            button1_cancel1.Font = new Font("Lucida Bright", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1_cancel1.ForeColor = SystemColors.InfoText;
            button1_cancel1.Location = new Point(371, 338);
            button1_cancel1.Name = "button1_cancel1";
            button1_cancel1.Size = new Size(151, 36);
            button1_cancel1.TabIndex = 17;
            button1_cancel1.Text = "Cancel";
            button1_cancel1.UseVisualStyleBackColor = true;
            button1_cancel1.Click += button_cancel;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 280);
            label1.Name = "label1";
            label1.Size = new Size(93, 24);
            label1.TabIndex = 18;
            label1.Text = "Kết quả :";
            // 
            // FormForgot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(595, 480);
            Controls.Add(label1);
            Controls.Add(button1_cancel1);
            Controls.Add(get_password);
            Controls.Add(pictureBox_forgot);
            Controls.Add(label_email1);
            Controls.Add(textBox_emailforgot);
            Controls.Add(label_forgot);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormForgot";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormForgot";
            TransparencyKey = Color.Gainsboro;
            ((System.ComponentModel.ISupportInitialize)pictureBox_forgot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_forgot;
        private Label label_email1;
        private TextBox textBox_emailforgot;
        private Label label_forgot;
        private Button get_password;
        private Button button1_cancel1;
        private Label label1;
    }
}