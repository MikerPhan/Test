namespace BanTraSua
{
    partial class FormKhachHang
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
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label maKHLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label tenKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.hangHoaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.hangHoaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.maKHTextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.tenKHTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            maKHLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            tenKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingNavigator)).BeginInit();
            this.hangHoaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            diaChiLabel.ForeColor = System.Drawing.Color.Black;
            diaChiLabel.Location = new System.Drawing.Point(95, 103);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(50, 15);
            diaChiLabel.TabIndex = 12;
            diaChiLabel.Text = "Địa chỉ:";
            diaChiLabel.Click += new System.EventHandler(this.diaChiLabel_Click);
            // 
            // maKHLabel
            // 
            maKHLabel.AutoSize = true;
            maKHLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maKHLabel.ForeColor = System.Drawing.Color.Black;
            maKHLabel.Location = new System.Drawing.Point(95, 129);
            maKHLabel.Name = "maKHLabel";
            maKHLabel.Size = new System.Drawing.Size(49, 15);
            maKHLabel.TabIndex = 14;
            maKHLabel.Text = "Mã KH:";
            maKHLabel.Click += new System.EventHandler(this.maKHLabel_Click);
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            sDTLabel.Location = new System.Drawing.Point(64, 154);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(81, 15);
            sDTLabel.TabIndex = 16;
            sDTLabel.Text = "Số điện thoại:";
            sDTLabel.Click += new System.EventHandler(this.sDTLabel_Click);
            // 
            // tenKHLabel
            // 
            tenKHLabel.AutoSize = true;
            tenKHLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenKHLabel.Location = new System.Drawing.Point(91, 180);
            tenKHLabel.Name = "tenKHLabel";
            tenKHLabel.Size = new System.Drawing.Size(53, 15);
            tenKHLabel.TabIndex = 18;
            tenKHLabel.Text = "Tên KH:";
            tenKHLabel.Click += new System.EventHandler(this.tenKHLabel_Click);
            // 
            // hangHoaBindingNavigator
            // 
            this.hangHoaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hangHoaBindingNavigator.BindingSource = this.hangHoaBindingSource;
            this.hangHoaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hangHoaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hangHoaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hangHoaBindingNavigatorSaveItem});
            this.hangHoaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hangHoaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hangHoaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hangHoaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hangHoaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hangHoaBindingNavigator.Name = "hangHoaBindingNavigator";
            this.hangHoaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hangHoaBindingNavigator.Size = new System.Drawing.Size(561, 25);
            this.hangHoaBindingNavigator.TabIndex = 0;
            this.hangHoaBindingNavigator.Text = "bindingNavigator1";
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
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataSource = typeof(BanHang.Domain.HangHoa);
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
            // hangHoaBindingNavigatorSaveItem
            // 
            this.hangHoaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hangHoaBindingNavigatorSaveItem.Enabled = false;
            this.hangHoaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hangHoaBindingNavigatorSaveItem.Image")));
            this.hangHoaBindingNavigatorSaveItem.Name = "hangHoaBindingNavigatorSaveItem";
            this.hangHoaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hangHoaBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(351, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Load Dữ Liệu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(351, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(351, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataSource = typeof(BanHang.Domain.KhachHang);
            // 
            // khachHangDataGridView
            // 
            this.khachHangDataGridView.AutoGenerateColumns = false;
            this.khachHangDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.khachHangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khachHangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.khachHangDataGridView.DataSource = this.khachHangBindingSource;
            this.khachHangDataGridView.Location = new System.Drawing.Point(57, 299);
            this.khachHangDataGridView.Name = "khachHangDataGridView";
            this.khachHangDataGridView.Size = new System.Drawing.Size(441, 230);
            this.khachHangDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã KH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên KH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn3.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "DiaChi", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(174, 100);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(100, 20);
            this.diaChiTextBox.TabIndex = 13;
            this.diaChiTextBox.TextChanged += new System.EventHandler(this.diaChiTextBox_TextChanged);
            // 
            // maKHTextBox
            // 
            this.maKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "MaKH", true));
            this.maKHTextBox.Location = new System.Drawing.Point(174, 126);
            this.maKHTextBox.Name = "maKHTextBox";
            this.maKHTextBox.Size = new System.Drawing.Size(100, 20);
            this.maKHTextBox.TabIndex = 15;
            this.maKHTextBox.TextChanged += new System.EventHandler(this.maKHTextBox_TextChanged);
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(174, 152);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(100, 20);
            this.sDTTextBox.TabIndex = 17;
            this.sDTTextBox.TextChanged += new System.EventHandler(this.sDTTextBox_TextChanged);
            // 
            // tenKHTextBox
            // 
            this.tenKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "TenKH", true));
            this.tenKHTextBox.Location = new System.Drawing.Point(174, 178);
            this.tenKHTextBox.Name = "tenKHTextBox";
            this.tenKHTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenKHTextBox.TabIndex = 19;
            this.tenKHTextBox.TextChanged += new System.EventHandler(this.tenKHTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(170, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Danh sách Khách Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(diaChiLabel);
            this.Controls.Add(this.diaChiTextBox);
            this.Controls.Add(maKHLabel);
            this.Controls.Add(this.maKHTextBox);
            this.Controls.Add(sDTLabel);
            this.Controls.Add(this.sDTTextBox);
            this.Controls.Add(tenKHLabel);
            this.Controls.Add(this.tenKHTextBox);
            this.Controls.Add(this.khachHangDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hangHoaBindingNavigator);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingNavigator)).EndInit();
            this.hangHoaBindingNavigator.ResumeLayout(false);
            this.hangHoaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private System.Windows.Forms.BindingNavigator hangHoaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hangHoaBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.DataGridView khachHangDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox maKHTextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox tenKHTextBox;
        private System.Windows.Forms.Label label1;
    }
}