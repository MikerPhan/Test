namespace BanTraSua
{
    partial class FormNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label namSinhLabel;
            System.Windows.Forms.Label tenNVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gioiTinhTextBox = new System.Windows.Forms.TextBox();
            this.maNVTextBox = new System.Windows.Forms.TextBox();
            this.namSinhTextBox = new System.Windows.Forms.TextBox();
            this.tenNVTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            namSinhLabel = new System.Windows.Forms.Label();
            tenNVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            gioiTinhLabel.Location = new System.Drawing.Point(75, 86);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(60, 15);
            gioiTinhLabel.TabIndex = 1;
            gioiTinhLabel.Text = "Giới tính:";
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maNVLabel.Location = new System.Drawing.Point(87, 113);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(48, 15);
            maNVLabel.TabIndex = 3;
            maNVLabel.Text = "Mã NV:";
            // 
            // namSinhLabel
            // 
            namSinhLabel.AutoSize = true;
            namSinhLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            namSinhLabel.Location = new System.Drawing.Point(72, 138);
            namSinhLabel.Name = "namSinhLabel";
            namSinhLabel.Size = new System.Drawing.Size(63, 15);
            namSinhLabel.TabIndex = 5;
            namSinhLabel.Text = "Năm sinh:";
            // 
            // tenNVLabel
            // 
            tenNVLabel.AutoSize = true;
            tenNVLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenNVLabel.Location = new System.Drawing.Point(83, 162);
            tenNVLabel.Name = "tenNVLabel";
            tenNVLabel.Size = new System.Drawing.Size(52, 15);
            tenNVLabel.TabIndex = 7;
            tenNVLabel.Text = "Tên NV:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNVDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.namSinhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhanVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Tên NV";
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // namSinhDataGridViewTextBoxColumn
            // 
            this.namSinhDataGridViewTextBoxColumn.DataPropertyName = "NamSinh";
            this.namSinhDataGridViewTextBoxColumn.HeaderText = "Năm sinh";
            this.namSinhDataGridViewTextBoxColumn.Name = "namSinhDataGridViewTextBoxColumn";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(BanHang.Domain.NhanVien);
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "GioiTinh", true));
            this.gioiTinhTextBox.Location = new System.Drawing.Point(147, 81);
            this.gioiTinhTextBox.Name = "gioiTinhTextBox";
            this.gioiTinhTextBox.Size = new System.Drawing.Size(100, 20);
            this.gioiTinhTextBox.TabIndex = 2;
            // 
            // maNVTextBox
            // 
            this.maNVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaNV", true));
            this.maNVTextBox.Location = new System.Drawing.Point(147, 110);
            this.maNVTextBox.Name = "maNVTextBox";
            this.maNVTextBox.Size = new System.Drawing.Size(100, 20);
            this.maNVTextBox.TabIndex = 4;
            // 
            // namSinhTextBox
            // 
            this.namSinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "NamSinh", true));
            this.namSinhTextBox.Location = new System.Drawing.Point(147, 136);
            this.namSinhTextBox.Name = "namSinhTextBox";
            this.namSinhTextBox.Size = new System.Drawing.Size(100, 20);
            this.namSinhTextBox.TabIndex = 6;
            // 
            // tenNVTextBox
            // 
            this.tenNVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "TenNV", true));
            this.tenNVTextBox.Location = new System.Drawing.Point(147, 162);
            this.tenNVTextBox.Name = "tenNVTextBox";
            this.tenNVTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenNVTextBox.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(306, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Load Dữ Liệu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(306, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(306, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 34);
            this.button3.TabIndex = 12;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(gioiTinhLabel);
            this.Controls.Add(this.gioiTinhTextBox);
            this.Controls.Add(maNVLabel);
            this.Controls.Add(this.maNVTextBox);
            this.Controls.Add(namSinhLabel);
            this.Controls.Add(this.namSinhTextBox);
            this.Controls.Add(tenNVLabel);
            this.Controls.Add(this.tenNVTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormNhanVien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.TextBox gioiTinhTextBox;
        private System.Windows.Forms.TextBox maNVTextBox;
        private System.Windows.Forms.TextBox namSinhTextBox;
        private System.Windows.Forms.TextBox tenNVTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

