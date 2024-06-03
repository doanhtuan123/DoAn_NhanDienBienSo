namespace doantest.Menu.AllCustomer
{
    partial class Allcustomer
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
            dataGridView_datatable = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_datatable).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_datatable
            // 
            dataGridView_datatable.AllowDrop = true;
            dataGridView_datatable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_datatable.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView_datatable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_datatable.Location = new Point(25, 87);
            dataGridView_datatable.Name = "dataGridView_datatable";
            dataGridView_datatable.ReadOnly = true;
            dataGridView_datatable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_datatable.Size = new Size(742, 332);
            dataGridView_datatable.TabIndex = 0;
            dataGridView_datatable.CellContentClick += dataGridView_datatable_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(298, 22);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 1;
            label1.Text = "All Customer";
            // 
            // Allcustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView_datatable);
            Name = "Allcustomer";
            Text = "Allcustomer";
            Load += Allcustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_datatable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_datatable;
        private Label label1;
    }
}