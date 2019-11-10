namespace BanTraSua
{
    partial class FormNhaCungCap
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
            System.Windows.Forms.Label chatLuongLabel;
            System.Windows.Forms.Label hangHoaCCLabel;
            System.Windows.Forms.Label maNCCLabel;
            System.Windows.Forms.Label tenNCCLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhaCungCap));
            this.nhaCungCapBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.nhaCungCapBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nhaCungCapDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatLuongTextBox = new System.Windows.Forms.TextBox();
            this.hangHoaCCTextBox = new System.Windows.Forms.TextBox();
            this.maNCCTextBox = new System.Windows.Forms.TextBox();
            this.tenNCCTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            chatLuongLabel = new System.Windows.Forms.Label();
            hangHoaCCLabel = new System.Windows.Forms.Label();
            maNCCLabel = new System.Windows.Forms.Label();
            tenNCCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingNavigator)).BeginInit();
            this.nhaCungCapBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chatLuongLabel
            // 
            chatLuongLabel.AutoSize = true;
            chatLuongLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            chatLuongLabel.Location = new System.Drawing.Point(97, 118);
            chatLuongLabel.Name = "chatLuongLabel";
            chatLuongLabel.Size = new System.Drawing.Size(73, 15);
            chatLuongLabel.TabIndex = 2;
            chatLuongLabel.Text = "Chất lượng:";
            // 
            // hangHoaCCLabel
            // 
            hangHoaCCLabel.AutoSize = true;
            hangHoaCCLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            hangHoaCCLabel.Location = new System.Drawing.Point(88, 143);
            hangHoaCCLabel.Name = "hangHoaCCLabel";
            hangHoaCCLabel.Size = new System.Drawing.Size(85, 15);
            hangHoaCCLabel.TabIndex = 4;
            hangHoaCCLabel.Text = "Hàng Hóa CC:";
            // 
            // maNCCLabel
            // 
            maNCCLabel.AutoSize = true;
            maNCCLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maNCCLabel.Location = new System.Drawing.Point(112, 169);
            maNCCLabel.Name = "maNCCLabel";
            maNCCLabel.Size = new System.Drawing.Size(58, 15);
            maNCCLabel.TabIndex = 6;
            maNCCLabel.Text = "Mã NCC:";
            // 
            // tenNCCLabel
            // 
            tenNCCLabel.AutoSize = true;
            tenNCCLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenNCCLabel.Location = new System.Drawing.Point(108, 195);
            tenNCCLabel.Name = "tenNCCLabel";
            tenNCCLabel.Size = new System.Drawing.Size(62, 15);
            tenNCCLabel.TabIndex = 8;
            tenNCCLabel.Text = "Tên NCC:";
            tenNCCLabel.Click += new System.EventHandler(this.tenNCCLabel_Click);
            // 
            // nhaCungCapBindingNavigator
            // 
            this.nhaCungCapBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nhaCungCapBindingNavigator.BindingSource = this.nhaCungCapBindingSource;
            this.nhaCungCapBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nhaCungCapBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nhaCungCapBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nhaCungCapBindingNavigatorSaveItem});
            this.nhaCungCapBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nhaCungCapBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nhaCungCapBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nhaCungCapBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nhaCungCapBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nhaCungCapBindingNavigator.Name = "nhaCungCapBindingNavigator";
            this.nhaCungCapBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nhaCungCapBindingNavigator.Size = new System.Drawing.Size(566, 25);
            this.nhaCungCapBindingNavigator.TabIndex = 0;
            this.nhaCungCapBindingNavigator.Text = "bindingNavigator1";
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
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataSource = typeof(BanHang.Domain.NhaCungCap);
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
            // nhaCungCapBindingNavigatorSaveItem
            // 
            this.nhaCungCapBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nhaCungCapBindingNavigatorSaveItem.Enabled = false;
            this.nhaCungCapBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nhaCungCapBindingNavigatorSaveItem.Image")));
            this.nhaCungCapBindingNavigatorSaveItem.Name = "nhaCungCapBindingNavigatorSaveItem";
            this.nhaCungCapBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nhaCungCapBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // nhaCungCapDataGridView
            // 
            this.nhaCungCapDataGridView.AutoGenerateColumns = false;
            this.nhaCungCapDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nhaCungCapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhaCungCapDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.nhaCungCapDataGridView.DataSource = this.nhaCungCapBindingSource;
            this.nhaCungCapDataGridView.GridColor = System.Drawing.Color.Gray;
            this.nhaCungCapDataGridView.Location = new System.Drawing.Point(63, 257);
            this.nhaCungCapDataGridView.Name = "nhaCungCapDataGridView";
            this.nhaCungCapDataGridView.Size = new System.Drawing.Size(442, 164);
            this.nhaCungCapDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNCC";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã NCC";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNCC";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên NCC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HangHoaCC";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hàng Hóa CC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ChatLuong";
            this.dataGridViewTextBoxColumn4.HeaderText = "Chất lượng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // chatLuongTextBox
            // 
            this.chatLuongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "ChatLuong", true));
            this.chatLuongTextBox.Location = new System.Drawing.Point(179, 115);
            this.chatLuongTextBox.Name = "chatLuongTextBox";
            this.chatLuongTextBox.Size = new System.Drawing.Size(100, 20);
            this.chatLuongTextBox.TabIndex = 3;
            // 
            // hangHoaCCTextBox
            // 
            this.hangHoaCCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "HangHoaCC", true));
            this.hangHoaCCTextBox.Location = new System.Drawing.Point(179, 141);
            this.hangHoaCCTextBox.Name = "hangHoaCCTextBox";
            this.hangHoaCCTextBox.Size = new System.Drawing.Size(100, 20);
            this.hangHoaCCTextBox.TabIndex = 5;
            // 
            // maNCCTextBox
            // 
            this.maNCCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "MaNCC", true));
            this.maNCCTextBox.Location = new System.Drawing.Point(179, 167);
            this.maNCCTextBox.Name = "maNCCTextBox";
            this.maNCCTextBox.Size = new System.Drawing.Size(100, 20);
            this.maNCCTextBox.TabIndex = 7;
            // 
            // tenNCCTextBox
            // 
            this.tenNCCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "TenNCC", true));
            this.tenNCCTextBox.Location = new System.Drawing.Point(179, 193);
            this.tenNCCTextBox.Name = "tenNCCTextBox";
            this.tenNCCTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenNCCTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(175, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Danh sách Nhà Cung Cấp";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(347, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Load Dữ Liệu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(347, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "Lưu ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(347, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 39);
            this.button3.TabIndex = 13;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 443);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(chatLuongLabel);
            this.Controls.Add(this.chatLuongTextBox);
            this.Controls.Add(hangHoaCCLabel);
            this.Controls.Add(this.hangHoaCCTextBox);
            this.Controls.Add(maNCCLabel);
            this.Controls.Add(this.maNCCTextBox);
            this.Controls.Add(tenNCCLabel);
            this.Controls.Add(this.tenNCCTextBox);
            this.Controls.Add(this.nhaCungCapDataGridView);
            this.Controls.Add(this.nhaCungCapBindingNavigator);
            this.Name = "FormNhaCungCap";
            this.Text = "FormNhaCungCap";
            this.Load += new System.EventHandler(this.FormNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingNavigator)).EndInit();
            this.nhaCungCapBindingNavigator.ResumeLayout(false);
            this.nhaCungCapBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private System.Windows.Forms.BindingNavigator nhaCungCapBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nhaCungCapBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nhaCungCapDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox chatLuongTextBox;
        private System.Windows.Forms.TextBox hangHoaCCTextBox;
        private System.Windows.Forms.TextBox maNCCTextBox;
        private System.Windows.Forms.TextBox tenNCCTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}