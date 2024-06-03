namespace doantest.Menu
{
    partial class Menuform
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button_logotmenu = new Button();
            label1 = new Label();
            dataGridView_danhsach = new DataGridView();
            button_timekeeping = new Button();
            statusToolStripMenuItem = new ToolStripMenuItem();
            searchlStripMenuItem = new ToolStripMenuItem();
            turnoverToolStripMenuItem = new ToolStripMenuItem();
            cUSTOMERToolStripMenuItem = new ToolStripMenuItem();
            aDDToolStripMenuItem = new ToolStripMenuItem();
            eDITToolStripMenuItem = new ToolStripMenuItem();
            rEMOVEToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            button_image_reco = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_danhsach).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button_logotmenu
            // 
            button_logotmenu.BackColor = SystemColors.ActiveCaption;
            button_logotmenu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button_logotmenu.ForeColor = SystemColors.ControlLightLight;
            button_logotmenu.Location = new Point(940, 39);
            button_logotmenu.Name = "button_logotmenu";
            button_logotmenu.Size = new Size(146, 41);
            button_logotmenu.TabIndex = 71;
            button_logotmenu.Text = "LOG OUT";
            button_logotmenu.UseVisualStyleBackColor = false;
            button_logotmenu.Click += click_logout;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(-167, -46);
            label1.Name = "label1";
            label1.Size = new Size(85, 26);
            label1.TabIndex = 65;
            label1.Text = "ID Staff";
            // 
            // dataGridView_danhsach
            // 
            dataGridView_danhsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_danhsach.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView_danhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_danhsach.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_danhsach.Location = new Point(58, 86);
            dataGridView_danhsach.Name = "dataGridView_danhsach";
            dataGridView_danhsach.RowHeadersWidth = 51;
            dataGridView_danhsach.RowTemplate.Height = 24;
            dataGridView_danhsach.ScrollBars = ScrollBars.Vertical;
            dataGridView_danhsach.Size = new Size(975, 421);
            dataGridView_danhsach.TabIndex = 62;
            dataGridView_danhsach.CellContentClick += dataGridView_phancongtho_CellContentClick;
            // 
            // button_timekeeping
            // 
            button_timekeeping.BackColor = SystemColors.ActiveCaption;
            button_timekeeping.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button_timekeeping.Location = new Point(182, 533);
            button_timekeeping.Name = "button_timekeeping";
            button_timekeeping.Size = new Size(273, 41);
            button_timekeeping.TabIndex = 63;
            button_timekeeping.Text = "Camera recognition";
            button_timekeeping.UseVisualStyleBackColor = false;
            button_timekeeping.Click += button_timekeeping_Click;
            // 
            // statusToolStripMenuItem
            // 
            statusToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchlStripMenuItem });
            statusToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            statusToolStripMenuItem.Size = new Size(138, 29);
            statusToolStripMenuItem.Text = "List Customer";
            // 
            // searchlStripMenuItem
            // 
            searchlStripMenuItem.Name = "searchlStripMenuItem";
            searchlStripMenuItem.Size = new Size(192, 30);
            searchlStripMenuItem.Text = "All Customer";
            searchlStripMenuItem.Click += searchlStripMenuItem_Click;
            // 
            // turnoverToolStripMenuItem
            // 
            turnoverToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            turnoverToolStripMenuItem.Name = "turnoverToolStripMenuItem";
            turnoverToolStripMenuItem.Size = new Size(148, 29);
            turnoverToolStripMenuItem.Text = "Image Captrue";
            turnoverToolStripMenuItem.Click += turnoverToolStripMenuItem_Click;
            // 
            // cUSTOMERToolStripMenuItem
            // 
            cUSTOMERToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aDDToolStripMenuItem, eDITToolStripMenuItem, rEMOVEToolStripMenuItem });
            cUSTOMERToolStripMenuItem.Font = new Font("Segoe UI", 13.8F);
            cUSTOMERToolStripMenuItem.Name = "cUSTOMERToolStripMenuItem";
            cUSTOMERToolStripMenuItem.Size = new Size(105, 29);
            cUSTOMERToolStripMenuItem.Text = "Customer";
            // 
            // aDDToolStripMenuItem
            // 
            aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            aDDToolStripMenuItem.Size = new Size(236, 30);
            aDDToolStripMenuItem.Text = "Add Customer";
            aDDToolStripMenuItem.Click += aDDToolStripMenuItem_Click;
            // 
            // eDITToolStripMenuItem
            // 
            eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            eDITToolStripMenuItem.Size = new Size(236, 30);
            eDITToolStripMenuItem.Text = "Edit Customer";
            eDITToolStripMenuItem.Click += eDITToolStripMenuItem_Click;
            // 
            // rEMOVEToolStripMenuItem
            // 
            rEMOVEToolStripMenuItem.Name = "rEMOVEToolStripMenuItem";
            rEMOVEToolStripMenuItem.Size = new Size(236, 30);
            rEMOVEToolStripMenuItem.Text = "Remove Customer";
            rEMOVEToolStripMenuItem.Click += rEMOVEToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { statusToolStripMenuItem, turnoverToolStripMenuItem, cUSTOMERToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1111, 33);
            menuStrip1.TabIndex = 64;
            menuStrip1.Text = "menuStripOffice";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // button_image_reco
            // 
            button_image_reco.BackColor = SystemColors.ActiveCaption;
            button_image_reco.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button_image_reco.Location = new Point(575, 533);
            button_image_reco.Name = "button_image_reco";
            button_image_reco.Size = new Size(273, 41);
            button_image_reco.TabIndex = 72;
            button_image_reco.Text = "Image recognition";
            button_image_reco.UseVisualStyleBackColor = false;
            button_image_reco.Click += button_image_reco_Click;
            // 
            // Menuform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 586);
            Controls.Add(button_image_reco);
            Controls.Add(button_logotmenu);
            Controls.Add(button_timekeeping);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(dataGridView_danhsach);
            Name = "Menuform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menuform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_danhsach).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_logotmenu;
        private Label label1;
        private Button button_timekeeping;
        private ToolStripMenuItem contractToolStripMenuItem;
        private ToolStripMenuItem addContractToolStripMenuItem;
        private ToolStripMenuItem editContractToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem statusToolStripMenuItem;
        private ToolStripMenuItem searchlStripMenuItem;
        private ToolStripMenuItem turnoverToolStripMenuItem;
        private ToolStripMenuItem cUSTOMERToolStripMenuItem;
        private ToolStripMenuItem aDDToolStripMenuItem;
        private ToolStripMenuItem eDITToolStripMenuItem;
        private ToolStripMenuItem rEMOVEToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button button_image_reco;
        public DataGridView dataGridView_danhsach;
    }
}