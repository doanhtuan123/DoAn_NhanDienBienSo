namespace doantest.Menu.Customer
{
    partial class EditCustomer
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
            button_edit = new Button();
            btnClose = new Button();
            label1 = new Label();
            lbId = new Label();
            label8 = new Label();
            textBox_fullname = new TextBox();
            label2 = new Label();
            dTPBirthDate = new DateTimePicker();
            label3 = new Label();
            tbEmail = new TextBox();
            label4 = new Label();
            textBox_phone = new TextBox();
            groupBox1 = new GroupBox();
            text_ID = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            textBox_gneder = new TextBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_edit
            // 
            button_edit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_edit.Location = new Point(120, 477);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(131, 55);
            button_edit.TabIndex = 160;
            button_edit.Text = "EDIT";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(368, 477);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 55);
            btnClose.TabIndex = 161;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(165, 26);
            label1.TabIndex = 129;
            label1.Text = "ID CUSTOMER";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbId.Location = new Point(52, 77);
            lbId.Name = "lbId";
            lbId.Size = new Size(97, 24);
            lbId.TabIndex = 162;
            lbId.Text = "Full Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label8.Location = new Point(51, 249);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 24);
            label8.TabIndex = 168;
            label8.Text = "Gender";
            // 
            // textBox_fullname
            // 
            textBox_fullname.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_fullname.Location = new Point(236, 77);
            textBox_fullname.Name = "textBox_fullname";
            textBox_fullname.Size = new Size(232, 32);
            textBox_fullname.TabIndex = 155;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 189);
            label2.Name = "label2";
            label2.Size = new Size(85, 24);
            label2.TabIndex = 163;
            label2.Text = "BirthDate";
            // 
            // dTPBirthDate
            // 
            dTPBirthDate.CustomFormat = "yyyy-MM-dd";
            dTPBirthDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dTPBirthDate.Format = DateTimePickerFormat.Custom;
            dTPBirthDate.Location = new Point(236, 189);
            dTPBirthDate.Name = "dTPBirthDate";
            dTPBirthDate.Size = new Size(232, 32);
            dTPBirthDate.TabIndex = 157;
            dTPBirthDate.Value = new DateTime(2022, 5, 20, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 330);
            label3.Name = "label3";
            label3.Size = new Size(132, 24);
            label3.TabIndex = 164;
            label3.Text = "Email Address";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbEmail.Location = new Point(236, 330);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(232, 32);
            tbEmail.TabIndex = 159;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 134);
            label4.Name = "label4";
            label4.Size = new Size(140, 24);
            label4.TabIndex = 165;
            label4.Text = "Phone Number";
            // 
            // textBox_phone
            // 
            textBox_phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_phone.Location = new Point(236, 134);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(232, 32);
            textBox_phone.TabIndex = 156;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(text_ID);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(648, 651);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit Customer";
            // 
            // text_ID
            // 
            text_ID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            text_ID.Location = new Point(222, 38);
            text_ID.Name = "text_ID";
            text_ID.Size = new Size(220, 32);
            text_ID.TabIndex = 170;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button1.Location = new Point(481, 28);
            button1.Name = "button1";
            button1.Size = new Size(99, 44);
            button1.TabIndex = 134;
            button1.Text = "CHECK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CHECK_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(textBox_gneder);
            panel1.Controls.Add(button_edit);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(lbId);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox_fullname);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dTPBirthDate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_phone);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 575);
            panel1.TabIndex = 133;
            // 
            // textBox_gneder
            // 
            textBox_gneder.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_gneder.Location = new Point(236, 260);
            textBox_gneder.Name = "textBox_gneder";
            textBox_gneder.Size = new Size(232, 32);
            textBox_gneder.TabIndex = 169;
            // 
            // EditCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 651);
            Controls.Add(groupBox1);
            Name = "EditCustomer";
            Text = "EditCustomer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button_edit;
        private Button btnClose;
        private Label label1;
        private Label lbId;
        private Label label8;
        private TextBox textBox_fullname;
        private Label label2;
        private DateTimePicker dTPBirthDate;
        private Label label3;
        private TextBox tbEmail;
        private Label label4;
        private TextBox textBox_phone;
        private GroupBox groupBox1;
        private Panel panel1;
        private TextBox text_ID;
        private Button button1;
        private TextBox textBox_gneder;
    }
}