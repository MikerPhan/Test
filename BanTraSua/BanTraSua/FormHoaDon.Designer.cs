namespace BanTraSua
{
    partial class FormHoaDon
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
            System.Windows.Forms.Label maHDLabel;
            System.Windows.Forms.Label maKHLabel;
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label ngayLapHDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.hoaDonBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hoaDonBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.hoaDonDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHDTextBox = new System.Windows.Forms.TextBox();
            this.maKHTextBox = new System.Windows.Forms.TextBox();
            this.maNVTextBox = new System.Windows.Forms.TextBox();
            this.ngayLapHDTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            maHDLabel = new System.Windows.Forms.Label();
            maKHLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            ngayLapHDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingNavigator)).BeginInit();
            this.hoaDonBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maHDLabel
            // 
            maHDLabel.AutoSize = true;
            maHDLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maHDLabel.Location = new System.Drawing.Point(97, 96);
            maHDLabel.Name = "maHDLabel";
            maHDLabel.Size = new System.Drawing.Size(49, 15);
            maHDLabel.TabIndex = 15;
            maHDLabel.Text = "Mã HD:";
            maHDLabel.Click += new System.EventHandler(this.maHDLabel_Click);
            // 
            // maKHLabel
            // 
            maKHLabel.AutoSize = true;
            maKHLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maKHLabel.Location = new System.Drawing.Point(97, 122);
            maKHLabel.Name = "maKHLabel";
            maKHLabel.Size = new System.Drawing.Size(49, 15);
            maKHLabel.TabIndex = 17;
            maKHLabel.Text = "Mã KH:";
            maKHLabel.Click += new System.EventHandler(this.maKHLabel_Click);
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maNVLabel.Location = new System.Drawing.Point(97, 148);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(48, 15);
            maNVLabel.TabIndex = 19;
            maNVLabel.Text = "Mã NV:";
            maNVLabel.Click += new System.EventHandler(this.maNVLabel_Click);
            // 
            // ngayLapHDLabel
            // 
            ngayLapHDLabel.AutoSize = true;
            ngayLapHDLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            ngayLapHDLabel.Location = new System.Drawing.Point(62, 173);
            ngayLapHDLabel.Name = "ngayLapHDLabel";
            ngayLapHDLabel.Size = new System.Drawing.Size(83, 15);
            ngayLapHDLabel.TabIndex = 21;
            ngayLapHDLabel.Text = "Ngày Lập HD:";
            ngayLapHDLabel.Click += new System.EventHandler(this.ngayLapHDLabel_Click);
            // 
            // hoaDonBindingNavigator
            // 
            this.hoaDonBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hoaDonBindingNavigator.BindingSource = this.hoaDonBindingSource;
            this.hoaDonBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hoaDonBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hoaDonBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hoaDonBindingNavigatorSaveItem});
            this.hoaDonBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hoaDonBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hoaDonBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hoaDonBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hoaDonBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hoaDonBindingNavigator.Name = "hoaDonBindingNavigator";
            this.hoaDonBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hoaDonBindingNavigator.Size = new System.Drawing.Size(609, 25);
            this.hoaDonBindingNavigator.TabIndex = 0;
            this.hoaDonBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataSource = typeof(BanHang.Domain.HoaDon);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // hoaDonBindingNavigatorSaveItem
            // 
            this.hoaDonBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hoaDonBindingNavigatorSaveItem.Enabled = false;
            this.hoaDonBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hoaDonBindingNavigatorSaveItem.Image")));
            this.hoaDonBindingNavigatorSaveItem.Name = "hoaDonBindingNavigatorSaveItem";
            this.hoaDonBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hoaDonBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(189, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Danh Sách Hóa Đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(343, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Load Dữ Liệu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(343, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(343, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 40);
            this.button3.TabIndex = 15;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // hoaDonDataGridView
            // 
            this.hoaDonDataGridView.AutoGenerateColumns = false;
            this.hoaDonDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.hoaDonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoaDonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.hoaDonDataGridView.DataSource = this.hoaDonBindingSource;
            this.hoaDonDataGridView.Location = new System.Drawing.Point(71, 258);
            this.hoaDonDataGridView.Name = "hoaDonDataGridView";
            this.hoaDonDataGridView.Size = new System.Drawing.Size(435, 171);
            this.hoaDonDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHD";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã HD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã KH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã NV";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NgayLapHD";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày Lập HD";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // maHDTextBox
            // 
            this.maHDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "MaHD", true));
            this.maHDTextBox.Location = new System.Drawing.Point(178, 93);
            this.maHDTextBox.Name = "maHDTextBox";
            this.maHDTextBox.Size = new System.Drawing.Size(100, 20);
            this.maHDTextBox.TabIndex = 16;
            this.maHDTextBox.TextChanged += new System.EventHandler(this.maHDTextBox_TextChanged);
            // 
            // maKHTextBox
            // 
            this.maKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "MaKH", true));
            this.maKHTextBox.Location = new System.Drawing.Point(178, 119);
            this.maKHTextBox.Name = "maKHTextBox";
            this.maKHTextBox.Size = new System.Drawing.Size(100, 20);
            this.maKHTextBox.TabIndex = 18;
            this.maKHTextBox.TextChanged += new System.EventHandler(this.maKHTextBox_TextChanged);
            // 
            // maNVTextBox
            // 
            this.maNVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "MaNV", true));
            this.maNVTextBox.Location = new System.Drawing.Point(178, 145);
            this.maNVTextBox.Name = "maNVTextBox";
            this.maNVTextBox.Size = new System.Drawing.Size(100, 20);
            this.maNVTextBox.TabIndex = 20;
            this.maNVTextBox.TextChanged += new System.EventHandler(this.maNVTextBox_TextChanged);
            // 
            // ngayLapHDTextBox
            // 
            this.ngayLapHDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "NgayLapHD", true));
            this.ngayLapHDTextBox.Location = new System.Drawing.Point(178, 171);
            this.ngayLapHDTextBox.Name = "ngayLapHDTextBox";
            this.ngayLapHDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ngayLapHDTextBox.TabIndex = 22;
            this.ngayLapHDTextBox.TextChanged += new System.EventHandler(this.ngayLapHDTextBox_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(343, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 36);
            this.button4.TabIndex = 14;
            this.button4.Text = "Report";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 529);
            this.Controls.Add(maHDLabel);
            this.Controls.Add(this.maHDTextBox);
            this.Controls.Add(maKHLabel);
            this.Controls.Add(this.maKHTextBox);
            this.Controls.Add(maNVLabel);
            this.Controls.Add(this.maNVTextBox);
            this.Controls.Add(ngayLapHDLabel);
            this.Controls.Add(this.ngayLapHDTextBox);
            this.Controls.Add(this.hoaDonDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoaDonBindingNavigator);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingNavigator)).EndInit();
            this.hoaDonBindingNavigator.ResumeLayout(false);
            this.hoaDonBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private System.Windows.Forms.BindingNavigator hoaDonBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hoaDonBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView hoaDonDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox maHDTextBox;
        private System.Windows.Forms.TextBox maKHTextBox;
        private System.Windows.Forms.TextBox maNVTextBox;
        private System.Windows.Forms.TextBox ngayLapHDTextBox;
        private System.Windows.Forms.Button button4;
    }
}