namespace doantest
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            label_creat = new Label();
            textBox_email = new TextBox();
            textBox_username1 = new TextBox();
            textBox_password1 = new TextBox();
            textBox_passwordcheck = new TextBox();
            label_email = new Label();
            label1_uesrname = new Label();
            label1_password = new Label();
            label1_confirm = new Label();
            button1_Singup = new Button();
            checkBox1 = new CheckBox();
            pictureBox_logosin = new PictureBox();
            button1_cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logosin).BeginInit();
            SuspendLayout();
            // 
            // label_creat
            // 
            label_creat.AutoSize = true;
            label_creat.BackColor = Color.LightSteelBlue;
            label_creat.Font = new Font("Wide Latin", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label_creat.ForeColor = SystemColors.HotTrack;
            label_creat.Location = new Point(50, 35);
            label_creat.Name = "label_creat";
            label_creat.Size = new Size(479, 29);
            label_creat.TabIndex = 0;
            label_creat.Text = "CREAT AN ACCOUNT";
            label_creat.Click += label_creat_Click;
            // 
            // textBox_email
            // 
            textBox_email.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_email.Location = new Point(99, 122);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(280, 26);
            textBox_email.TabIndex = 1;
            // 
            // textBox_username1
            // 
            textBox_username1.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_username1.Location = new Point(99, 182);
            textBox_username1.Name = "textBox_username1";
            textBox_username1.Size = new Size(280, 26);
            textBox_username1.TabIndex = 2;
            // 
            // textBox_password1
            // 
            textBox_password1.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_password1.Location = new Point(99, 250);
            textBox_password1.Name = "textBox_password1";
            textBox_password1.Size = new Size(280, 26);
            textBox_password1.TabIndex = 3;
            // 
            // textBox_passwordcheck
            // 
            textBox_passwordcheck.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_passwordcheck.Location = new Point(99, 319);
            textBox_passwordcheck.Name = "textBox_passwordcheck";
            textBox_passwordcheck.Size = new Size(280, 26);
            textBox_passwordcheck.TabIndex = 4;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.BackColor = Color.LightSteelBlue;
            label_email.Font = new Font("Lucida Bright", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label_email.Location = new Point(99, 101);
            label_email.Name = "label_email";
            label_email.Size = new Size(61, 18);
            label_email.TabIndex = 5;
            label_email.Text = "Email: ";
            // 
            // label1_uesrname
            // 
            label1_uesrname.AutoSize = true;
            label1_uesrname.BackColor = Color.LightSteelBlue;
            label1_uesrname.Font = new Font("Lucida Bright", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1_uesrname.Location = new Point(99, 161);
            label1_uesrname.Name = "label1_uesrname";
            label1_uesrname.Size = new Size(90, 18);
            label1_uesrname.TabIndex = 6;
            label1_uesrname.Text = "Uesrname:";
            // 
            // label1_password
            // 
            label1_password.AutoSize = true;
            label1_password.BackColor = Color.LightSteelBlue;
            label1_password.Font = new Font("Lucida Bright", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1_password.Location = new Point(99, 229);
            label1_password.Name = "label1_password";
            label1_password.Size = new Size(85, 18);
            label1_password.TabIndex = 7;
            label1_password.Text = "Password:";
            // 
            // label1_confirm
            // 
            label1_confirm.AutoSize = true;
            label1_confirm.BackColor = Color.LightSteelBlue;
            label1_confirm.Font = new Font("Lucida Bright", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1_confirm.Location = new Point(104, 298);
            label1_confirm.Name = "label1_confirm";
            label1_confirm.Size = new Size(154, 18);
            label1_confirm.TabIndex = 8;
            label1_confirm.Text = "Confirm Password:";
            // 
            // button1_Singup
            // 
            button1_Singup.AutoSize = true;
            button1_Singup.Font = new Font("Wide Latin", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1_Singup.ForeColor = SystemColors.MenuHighlight;
            button1_Singup.Location = new Point(122, 380);
            button1_Singup.Name = "button1_Singup";
            button1_Singup.Size = new Size(148, 35);
            button1_Singup.TabIndex = 9;
            button1_Singup.Text = "SINGUP";
            button1_Singup.UseVisualStyleBackColor = true;
            button1_Singup.Click += button1_Singup_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.LightSteelBlue;
            checkBox1.Font = new Font("Lucida Bright", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ActiveCaptionText;
            checkBox1.Location = new Point(169, 351);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(291, 22);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "I agree to the term and conditions";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // pictureBox_logosin
            // 
            pictureBox_logosin.Image = (Image)resources.GetObject("pictureBox_logosin.Image");
            pictureBox_logosin.Location = new Point(270, 66);
            pictureBox_logosin.Name = "pictureBox_logosin";
            pictureBox_logosin.Size = new Size(54, 50);
            pictureBox_logosin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_logosin.TabIndex = 11;
            pictureBox_logosin.TabStop = false;
            // 
            // button1_cancel
            // 
            button1_cancel.AutoSize = true;
            button1_cancel.Font = new Font("Wide Latin", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1_cancel.ForeColor = SystemColors.MenuHighlight;
            button1_cancel.Location = new Point(309, 379);
            button1_cancel.Name = "button1_cancel";
            button1_cancel.Size = new Size(151, 36);
            button1_cancel.TabIndex = 12;
            button1_cancel.Text = "CANCEL";
            button1_cancel.UseVisualStyleBackColor = true;
            button1_cancel.Click += button_cancel_click1;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(25F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(579, 441);
            Controls.Add(button1_cancel);
            Controls.Add(pictureBox_logosin);
            Controls.Add(checkBox1);
            Controls.Add(button1_Singup);
            Controls.Add(label1_confirm);
            Controls.Add(label1_password);
            Controls.Add(label1_uesrname);
            Controls.Add(label_email);
            Controls.Add(textBox_passwordcheck);
            Controls.Add(textBox_password1);
            Controls.Add(textBox_username1);
            Controls.Add(textBox_email);
            Controls.Add(label_creat);
            DoubleBuffered = true;
            Font = new Font("Wide Latin", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(11, 5, 11, 5);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            TransparencyKey = Color.Gainsboro;
            Load += FormRegister_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_logosin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_creat;
        private TextBox textBox_email;
        private TextBox textBox_username1;
        private TextBox textBox_password1;
        private TextBox textBox_passwordcheck;
        private Label label_email;
        private Label label1_uesrname;
        private Label label1_password;
        private Label label1_confirm;
        private Button button1_Singup;
        private CheckBox checkBox1;
        private PictureBox pictureBox_logosin;
        private Button button1_cancel;
    }
}