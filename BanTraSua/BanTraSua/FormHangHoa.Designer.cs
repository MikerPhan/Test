namespace BanTraSua
{
    partial class FormHangHoa
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
            System.Windows.Forms.Label giaLabel;
            System.Windows.Forms.Label maHHLabel;
            System.Windows.Forms.Label soluongLabel;
            System.Windows.Forms.Label tenHHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHangHoa));
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
            this.hangHoaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTextBox = new System.Windows.Forms.TextBox();
            this.maHHTextBox = new System.Windows.Forms.TextBox();
            this.soluongTextBox = new System.Windows.Forms.TextBox();
            this.tenHHTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            giaLabel = new System.Windows.Forms.Label();
            maHHLabel = new System.Windows.Forms.Label();
            soluongLabel = new System.Windows.Forms.Label();
            tenHHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingNavigator)).BeginInit();
            this.hangHoaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // giaLabel
            // 
            giaLabel.AutoSize = true;
            giaLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            giaLabel.Location = new System.Drawing.Point(337, 120);
            giaLabel.Name = "giaLabel";
            giaLabel.Size = new System.Drawing.Size(30, 15);
            giaLabel.TabIndex = 2;
            giaLabel.Text = "Giá:";
            // 
            // maHHLabel
            // 
            maHHLabel.AutoSize = true;
            maHHLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maHHLabel.Location = new System.Drawing.Point(114, 94);
            maHHLabel.Name = "maHHLabel";
            maHHLabel.Size = new System.Drawing.Size(49, 15);
            maHHLabel.TabIndex = 4;
            maHHLabel.Text = "Mã HH:";
            // 
            // soluongLabel
            // 
            soluongLabel.AutoSize = true;
            soluongLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            soluongLabel.Location = new System.Drawing.Point(310, 94);
            soluongLabel.Name = "soluongLabel";
            soluongLabel.Size = new System.Drawing.Size(61, 15);
            soluongLabel.TabIndex = 6;
            soluongLabel.Text = "Số lượng:";
            // 
            // tenHHLabel
            // 
            tenHHLabel.AutoSize = true;
            tenHHLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenHHLabel.Location = new System.Drawing.Point(114, 121);
            tenHHLabel.Name = "tenHHLabel";
            tenHHLabel.Size = new System.Drawing.Size(53, 15);
            tenHHLabel.TabIndex = 8;
            tenHHLabel.Text = "Tên HH:";
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
            this.hangHoaBindingNavigator.Size = new System.Drawing.Size(618, 25);
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
            // hangHoaDataGridView
            // 
            this.hangHoaDataGridView.AutoGenerateColumns = false;
            this.hangHoaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.hangHoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hangHoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.hangHoaDataGridView.DataSource = this.hangHoaBindingSource;
            this.hangHoaDataGridView.Location = new System.Drawing.Point(77, 248);
            this.hangHoaDataGridView.Name = "hangHoaDataGridView";
            this.hangHoaDataGridView.Size = new System.Drawing.Size(464, 220);
            this.hangHoaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã HH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenHH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên HH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Soluong";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gia";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giá";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // giaTextBox
            // 
            this.giaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "Gia", true));
            this.giaTextBox.Location = new System.Drawing.Point(377, 118);
            this.giaTextBox.Name = "giaTextBox";
            this.giaTextBox.Size = new System.Drawing.Size(100, 20);
            this.giaTextBox.TabIndex = 3;
            // 
            // maHHTextBox
            // 
            this.maHHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "MaHH", true));
            this.maHHTextBox.Location = new System.Drawing.Point(172, 92);
            this.maHHTextBox.Name = "maHHTextBox";
            this.maHHTextBox.Size = new System.Drawing.Size(100, 20);
            this.maHHTextBox.TabIndex = 5;
            // 
            // soluongTextBox
            // 
            this.soluongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "Soluong", true));
            this.soluongTextBox.Location = new System.Drawing.Point(377, 92);
            this.soluongTextBox.Name = "soluongTextBox";
            this.soluongTextBox.Size = new System.Drawing.Size(100, 20);
            this.soluongTextBox.TabIndex = 7;
            // 
            // tenHHTextBox
            // 
            this.tenHHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "TenHH", true));
            this.tenHHTextBox.Location = new System.Drawing.Point(172, 118);
            this.tenHHTextBox.Name = "tenHHTextBox";
            this.tenHHTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenHHTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(41, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Load dữ liệu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(216, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Danh sách hàng hóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(187, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(346, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 38);
            this.button3.TabIndex = 13;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(498, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 36);
            this.button4.TabIndex = 14;
            this.button4.Text = "report";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(618, 480);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(giaLabel);
            this.Controls.Add(this.giaTextBox);
            this.Controls.Add(maHHLabel);
            this.Controls.Add(this.maHHTextBox);
            this.Controls.Add(soluongLabel);
            this.Controls.Add(this.soluongTextBox);
            this.Controls.Add(tenHHLabel);
            this.Controls.Add(this.tenHHTextBox);
            this.Controls.Add(this.hangHoaDataGridView);
            this.Controls.Add(this.hangHoaBindingNavigator);
            this.Name = "FormHangHoa";
            this.Text = "FormHangHoa";
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingNavigator)).EndInit();
            this.hangHoaBindingNavigator.ResumeLayout(false);
            this.hangHoaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView hangHoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox giaTextBox;
        private System.Windows.Forms.TextBox maHHTextBox;
        private System.Windows.Forms.TextBox soluongTextBox;
        private System.Windows.Forms.TextBox tenHHTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}