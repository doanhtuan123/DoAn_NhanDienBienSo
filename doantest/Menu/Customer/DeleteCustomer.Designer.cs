namespace doantest.Menu.Customer
{
    partial class DeleteCustomer
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            label2 = new Label();
            button1 = new Button();
            txtID = new TextBox();
            txtEmail = new TextBox();
            txtGender = new TextBox();
            txtName = new TextBox();
            txtBirday = new DateTimePicker();
            txtPhone = new TextBox();
            button_close = new Button();
            button_remove = new Button();
            lbNameStaff = new Label();
            label1 = new Label();
            dataGridView_show = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_show).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtGender);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtBirday);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(button_close);
            groupBox1.Controls.Add(button_remove);
            groupBox1.Controls.Add(lbNameStaff);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 612);
            groupBox1.TabIndex = 140;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(78, 413);
            label5.Name = "label5";
            label5.Size = new Size(62, 24);
            label5.TabIndex = 202;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(78, 343);
            label4.Name = "label4";
            label4.Size = new Size(71, 24);
            label4.TabIndex = 201;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(73, 280);
            label3.Name = "label3";
            label3.Size = new Size(80, 24);
            label3.TabIndex = 200;
            label3.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.Location = new Point(73, 222);
            label8.Name = "label8";
            label8.Size = new Size(85, 24);
            label8.TabIndex = 199;
            label8.Text = "Birthday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(73, 149);
            label2.Name = "label2";
            label2.Size = new Size(65, 24);
            label2.TabIndex = 194;
            label2.Text = "Name";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(146, 501);
            button1.Name = "button1";
            button1.Size = new Size(128, 47);
            button1.TabIndex = 193;
            button1.Text = "REMOVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtID
            // 
            txtID.AccessibleName = "";
            txtID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtID.Location = new Point(106, 49);
            txtID.Name = "txtID";
            txtID.Size = new Size(232, 32);
            txtID.TabIndex = 192;
            // 
            // txtEmail
            // 
            txtEmail.AccessibleName = "";
            txtEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtEmail.Location = new Point(238, 413);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 32);
            txtEmail.TabIndex = 191;
            // 
            // txtGender
            // 
            txtGender.AccessibleName = "";
            txtGender.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtGender.Location = new Point(238, 280);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(232, 32);
            txtGender.TabIndex = 190;
            // 
            // txtName
            // 
            txtName.AccessibleName = "";
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtName.Location = new Point(238, 149);
            txtName.Name = "txtName";
            txtName.Size = new Size(232, 32);
            txtName.TabIndex = 186;
            // 
            // txtBirday
            // 
            txtBirday.AccessibleName = "";
            txtBirday.CustomFormat = "yyyy-MM-dd";
            txtBirday.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtBirday.Format = DateTimePickerFormat.Custom;
            txtBirday.Location = new Point(238, 222);
            txtBirday.Name = "txtBirday";
            txtBirday.Size = new Size(232, 32);
            txtBirday.TabIndex = 188;
            txtBirday.Value = new DateTime(2022, 5, 20, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            txtPhone.AccessibleName = "";
            txtPhone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPhone.Location = new Point(238, 343);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(232, 32);
            txtPhone.TabIndex = 189;
            txtPhone.TextChanged += tbEmail_TextChanged;
            // 
            // button_close
            // 
            button_close.BackColor = SystemColors.ButtonFace;
            button_close.FlatStyle = FlatStyle.Popup;
            button_close.Location = new Point(367, 501);
            button_close.Name = "button_close";
            button_close.Size = new Size(128, 47);
            button_close.TabIndex = 140;
            button_close.Text = "CLOSE";
            button_close.UseVisualStyleBackColor = false;
            button_close.Click += button_close_Click;
            // 
            // button_remove
            // 
            button_remove.BackColor = SystemColors.ButtonFace;
            button_remove.FlatStyle = FlatStyle.Popup;
            button_remove.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button_remove.Location = new Point(431, 51);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(127, 39);
            button_remove.TabIndex = 139;
            button_remove.Text = "CHECK";
            button_remove.UseVisualStyleBackColor = false;
            button_remove.Click += button_remove_Click;
            // 
            // lbNameStaff
            // 
            lbNameStaff.AutoSize = true;
            lbNameStaff.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameStaff.Location = new Point(73, 108);
            lbNameStaff.Name = "lbNameStaff";
            lbNameStaff.Size = new Size(121, 26);
            lbNameStaff.TabIndex = 136;
            lbNameStaff.Text = "Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 51);
            label1.Name = "label1";
            label1.Size = new Size(40, 26);
            label1.TabIndex = 133;
            label1.Text = "ID ";
            // 
            // dataGridView_show
            // 
            dataGridView_show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_show.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_show.Location = new Point(19, 137);
            dataGridView_show.Name = "dataGridView_show";
            dataGridView_show.ReadOnly = true;
            dataGridView_show.RowHeadersWidth = 51;
            dataGridView_show.RowTemplate.Height = 24;
            dataGridView_show.Size = new Size(783, 323);
            dataGridView_show.TabIndex = 139;
            // 
            // DeleteCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 612);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView_show);
            Name = "DeleteCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteCustomer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_show).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_close;
        private Button button_remove;
        private Label lbNameStaff;
        private Label label1;
        private DataGridView dataGridView_show;
        private TextBox txtGender;
        private TextBox txtName;
        private DateTimePicker txtBirday;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtID;
        private Button button1;
        private Label label3;
        private Label label8;
        private Label label2;
        private Label label5;
        private Label label4;
    }
}