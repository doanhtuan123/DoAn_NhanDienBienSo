namespace doantest
{
    partial class FormImage
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
            pictureBox_image = new PictureBox();
            button_select = new Button();
            button2 = new Button();
            button_check_image = new Button();
            button_cancel_imgae = new Button();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            pictureBox_image1 = new PictureBox();
            groupBox1 = new GroupBox();
            label_licenseplates = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtGender = new TextBox();
            txtName = new TextBox();
            txtBirday = new DateTimePicker();
            txtPhone = new TextBox();
            richTextBox_image = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_image1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_image
            // 
            pictureBox_image.BackColor = SystemColors.ButtonHighlight;
            pictureBox_image.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_image.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_image.Location = new Point(25, 29);
            pictureBox_image.Name = "pictureBox_image";
            pictureBox_image.Size = new Size(423, 333);
            pictureBox_image.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_image.TabIndex = 0;
            pictureBox_image.TabStop = false;
            // 
            // button_select
            // 
            button_select.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_select.Location = new Point(13, 369);
            button_select.Name = "button_select";
            button_select.Size = new Size(125, 37);
            button_select.TabIndex = 1;
            button_select.Text = "Browse...";
            button_select.UseVisualStyleBackColor = true;
            button_select.Click += button_select_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(159, 486);
            button2.Name = "button2";
            button2.Size = new Size(114, 49);
            button2.TabIndex = 2;
            button2.Tag = "";
            button2.Text = "Info";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button_check_image
            // 
            button_check_image.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_check_image.Location = new Point(19, 485);
            button_check_image.Name = "button_check_image";
            button_check_image.Size = new Size(119, 50);
            button_check_image.TabIndex = 3;
            button_check_image.Text = "Check";
            button_check_image.UseVisualStyleBackColor = true;
            button_check_image.Click += button_check_image_Click;
            // 
            // button_cancel_imgae
            // 
            button_cancel_imgae.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_cancel_imgae.Location = new Point(290, 487);
            button_cancel_imgae.Name = "button_cancel_imgae";
            button_cancel_imgae.Size = new Size(106, 48);
            button_cancel_imgae.TabIndex = 4;
            button_cancel_imgae.Text = "Cancel";
            button_cancel_imgae.UseVisualStyleBackColor = true;
            button_cancel_imgae.Click += button_cancel_imgae_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(144, 370);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(303, 36);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(481, 240);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 8;
            label2.Text = "Information";
            // 
            // pictureBox_image1
            // 
            pictureBox_image1.BackColor = SystemColors.ButtonHighlight;
            pictureBox_image1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_image1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_image1.Location = new Point(612, 113);
            pictureBox_image1.Name = "pictureBox_image1";
            pictureBox_image1.Size = new Size(192, 108);
            pictureBox_image1.TabIndex = 10;
            pictureBox_image1.TabStop = false;
            pictureBox_image1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(label_licenseplates);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtGender);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtBirday);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(richTextBox_image);
            groupBox1.Controls.Add(pictureBox_image1);
            groupBox1.Controls.Add(button_select);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button_check_image);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(button_cancel_imgae);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(938, 607);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // label_licenseplates
            // 
            label_licenseplates.AutoSize = true;
            label_licenseplates.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label_licenseplates.Location = new Point(561, 17);
            label_licenseplates.Name = "label_licenseplates";
            label_licenseplates.Size = new Size(145, 24);
            label_licenseplates.TabIndex = 33;
            label_licenseplates.Text = "License Plates";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(483, 461);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 206;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(483, 411);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 205;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(481, 369);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 204;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(481, 319);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 203;
            label4.Text = "BirthDay";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(481, 280);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 202;
            label3.Text = "Name";
            // 
            // txtEmail
            // 
            txtEmail.AccessibleName = "";
            txtEmail.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtEmail.Location = new Point(628, 461);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 29);
            txtEmail.TabIndex = 201;
            // 
            // txtGender
            // 
            txtGender.AccessibleName = "";
            txtGender.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGender.Location = new Point(628, 411);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(232, 29);
            txtGender.TabIndex = 200;
            // 
            // txtName
            // 
            txtName.AccessibleName = "";
            txtName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtName.Location = new Point(628, 280);
            txtName.Name = "txtName";
            txtName.Size = new Size(232, 29);
            txtName.TabIndex = 197;
            // 
            // txtBirday
            // 
            txtBirday.AccessibleName = "";
            txtBirday.CustomFormat = "yyyy-MM-dd";
            txtBirday.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtBirday.Format = DateTimePickerFormat.Custom;
            txtBirday.Location = new Point(628, 319);
            txtBirday.Name = "txtBirday";
            txtBirday.Size = new Size(232, 29);
            txtBirday.TabIndex = 198;
            txtBirday.Value = new DateTime(2022, 5, 20, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            txtPhone.AccessibleName = "";
            txtPhone.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPhone.Location = new Point(628, 364);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(232, 29);
            txtPhone.TabIndex = 199;
            // 
            // richTextBox_image
            // 
            richTextBox_image.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox_image.Location = new Point(561, 49);
            richTextBox_image.Name = "richTextBox_image";
            richTextBox_image.Size = new Size(275, 41);
            richTextBox_image.TabIndex = 11;
            richTextBox_image.Text = "";
            richTextBox_image.TextChanged += richTextBox2_TextChanged;
            // 
            // FormImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 631);
            Controls.Add(pictureBox_image);
            Controls.Add(groupBox1);
            Name = "FormImage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormImage";
            Load += FormImage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_image1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_image;
        private Button button_select;
        private Button button2;
        private Button button_check_image;
        private Button button_cancel_imgae;
        private RichTextBox richTextBox1;
        private Label label2;
        private PictureBox pictureBox_image1;
        private GroupBox groupBox1;
        private RichTextBox richTextBox_image;
        private TextBox txtEmail;
        private TextBox txtGender;
        private TextBox txtName;
        private DateTimePicker txtBirday;
        private TextBox txtPhone;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label_licenseplates;
    }
}