namespace doantest.Menu.Customer
{
    partial class AddCustomer
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
            lbId = new Label();
            label8 = new Label();
            textBox_fullname = new TextBox();
            label2 = new Label();
            dTPBirthDate = new DateTimePicker();
            label3 = new Label();
            tbEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox_phone = new TextBox();
            textBox_gender = new TextBox();
            textBox_Id = new TextBox();
            SuspendLayout();
            // 
            // button_edit
            // 
            button_edit.BackColor = SystemColors.ButtonFace;
            button_edit.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_edit.Location = new Point(94, 474);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(131, 55);
            button_edit.TabIndex = 176;
            button_edit.Text = "ADD";
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button_edit_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ButtonFace;
            btnClose.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(300, 474);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 55);
            btnClose.TabIndex = 177;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbId.Location = new Point(48, 133);
            lbId.Name = "lbId";
            lbId.Size = new Size(97, 24);
            lbId.TabIndex = 178;
            lbId.Text = "Full Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label8.Location = new Point(48, 322);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 24);
            label8.TabIndex = 184;
            label8.Text = "Gender";
            // 
            // textBox_fullname
            // 
            textBox_fullname.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_fullname.Location = new Point(240, 133);
            textBox_fullname.Name = "textBox_fullname";
            textBox_fullname.Size = new Size(232, 32);
            textBox_fullname.TabIndex = 171;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 250);
            label2.Name = "label2";
            label2.Size = new Size(79, 24);
            label2.TabIndex = 179;
            label2.Text = "BirthDay";
            // 
            // dTPBirthDate
            // 
            dTPBirthDate.CustomFormat = "yyyy-MM-dd";
            dTPBirthDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dTPBirthDate.Format = DateTimePickerFormat.Custom;
            dTPBirthDate.Location = new Point(240, 250);
            dTPBirthDate.Name = "dTPBirthDate";
            dTPBirthDate.Size = new Size(232, 32);
            dTPBirthDate.TabIndex = 173;
            dTPBirthDate.Value = new DateTime(2022, 5, 20, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 391);
            label3.Name = "label3";
            label3.Size = new Size(132, 24);
            label3.TabIndex = 180;
            label3.Text = "Email Address";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbEmail.Location = new Point(240, 391);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(232, 32);
            tbEmail.TabIndex = 175;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(48, 63);
            label5.Name = "label5";
            label5.Size = new Size(113, 24);
            label5.TabIndex = 182;
            label5.Text = "ID Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 195);
            label4.Name = "label4";
            label4.Size = new Size(140, 24);
            label4.TabIndex = 181;
            label4.Text = "Phone Number";
            // 
            // textBox_phone
            // 
            textBox_phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_phone.Location = new Point(240, 195);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(232, 32);
            textBox_phone.TabIndex = 172;
            // 
            // textBox_gender
            // 
            textBox_gender.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_gender.Location = new Point(240, 322);
            textBox_gender.Name = "textBox_gender";
            textBox_gender.Size = new Size(232, 32);
            textBox_gender.TabIndex = 185;
            // 
            // textBox_Id
            // 
            textBox_Id.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_Id.Location = new Point(240, 63);
            textBox_Id.Name = "textBox_Id";
            textBox_Id.Size = new Size(232, 32);
            textBox_Id.TabIndex = 186;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(529, 559);
            Controls.Add(textBox_Id);
            Controls.Add(textBox_gender);
            Controls.Add(button_edit);
            Controls.Add(btnClose);
            Controls.Add(lbId);
            Controls.Add(label8);
            Controls.Add(textBox_fullname);
            Controls.Add(label2);
            Controls.Add(dTPBirthDate);
            Controls.Add(label3);
            Controls.Add(tbEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox_phone);
            Name = "AddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_edit;
        private Button btnClose;
        private Label lbId;
        private Label label8;
        private TextBox textBox_fullname;
        private Label label2;
        private DateTimePicker dTPBirthDate;
        private Label label3;
        private TextBox tbEmail;
        private Label label5;
        private Label label4;
        private TextBox textBox_phone;
        private TextBox textBox_gender;
        private TextBox textBox_Id;
    }
}