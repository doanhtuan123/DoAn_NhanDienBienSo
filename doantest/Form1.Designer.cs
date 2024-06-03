namespace doantest
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            textBox_username = new TextBox();
            textBox_pass = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox_logo = new PictureBox();
            Label_name = new Label();
            pictureBox2 = new PictureBox();
            label_password = new Label();
            button_login = new Button();
            button1 = new Button();
            label_forgot = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.LightSteelBlue;
            label1.CausesValidation = false;
            label1.ForeColor = SystemColors.HotTrack;
            label1.Name = "label1";
            // 
            // textBox_username
            // 
            textBox_username.BackColor = SystemColors.Control;
            textBox_username.Cursor = Cursors.IBeam;
            resources.ApplyResources(textBox_username, "textBox_username");
            textBox_username.Name = "textBox_username";
            textBox_username.TextChanged += textBox_username_TextChanged;
            textBox_username.Enter += Textbox_uesrname_enter;
            textBox_username.Leave += Textbox_username_leave;
            // 
            // textBox_pass
            // 
            textBox_pass.BackColor = SystemColors.ButtonFace;
            textBox_pass.Cursor = Cursors.IBeam;
            resources.ApplyResources(textBox_pass, "textBox_pass");
            textBox_pass.Name = "textBox_pass";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox_logo
            // 
            pictureBox_logo.BackColor = Color.LightSteelBlue;
            resources.ApplyResources(pictureBox_logo, "pictureBox_logo");
            pictureBox_logo.Name = "pictureBox_logo";
            pictureBox_logo.TabStop = false;
            // 
            // Label_name
            // 
            resources.ApplyResources(Label_name, "Label_name");
            Label_name.BackColor = Color.LightSteelBlue;
            Label_name.ForeColor = SystemColors.ControlText;
            Label_name.Name = "Label_name";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // label_password
            // 
            resources.ApplyResources(label_password, "label_password");
            label_password.BackColor = Color.LightSteelBlue;
            label_password.ForeColor = SystemColors.ControlText;
            label_password.Name = "label_password";
            // 
            // button_login
            // 
            resources.ApplyResources(button_login, "button_login");
            button_login.ForeColor = SystemColors.ControlText;
            button_login.Name = "button_login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = SystemColors.Desktop;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_cancel_click;
            // 
            // label_forgot
            // 
            resources.ApplyResources(label_forgot, "label_forgot");
            label_forgot.BackColor = Color.LightSteelBlue;
            label_forgot.ForeColor = SystemColors.ActiveCaptionText;
            label_forgot.Name = "label_forgot";
            label_forgot.Click += lable_forgot_click;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            BackColor = SystemColors.ControlLight;
            Controls.Add(label_forgot);
            Controls.Add(button1);
            Controls.Add(button_login);
            Controls.Add(label_password);
            Controls.Add(pictureBox2);
            Controls.Add(Label_name);
            Controls.Add(pictureBox_logo);
            Controls.Add(pictureBox1);
            Controls.Add(textBox_pass);
            Controls.Add(textBox_username);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = SystemColors.HotTrack;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            TransparencyKey = Color.Gainsboro;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_username;
        private TextBox textBox_pass;
        private PictureBox pictureBox1;
        private PictureBox pictureBox_logo;
        private Label Label_name;
        private PictureBox pictureBox2;
        private Label label_password;
        private Button button_login;
        private Button button1;
        private Label label_forgot;
    }
}
