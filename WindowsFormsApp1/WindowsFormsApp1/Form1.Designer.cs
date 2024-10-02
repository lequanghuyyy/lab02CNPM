namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Mssv = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Hoten = new System.Windows.Forms.TextBox();
            this.Hocluc = new System.Windows.Forms.TextBox();
            this.Quequan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MssvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaysinhColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocLucColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mssv
            // 
            this.Mssv.CausesValidation = false;
            this.Mssv.Location = new System.Drawing.Point(113, 40);
            this.Mssv.Name = "Mssv";
            this.Mssv.ReadOnly = true;
            this.Mssv.Size = new System.Drawing.Size(156, 20);
            this.Mssv.TabIndex = 0;
            this.Mssv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Hoten
            // 
            this.Hoten.Location = new System.Drawing.Point(348, 41);
            this.Hoten.Name = "Hoten";
            this.Hoten.ReadOnly = true;
            this.Hoten.Size = new System.Drawing.Size(338, 20);
            this.Hoten.TabIndex = 2;
            // 
            // Hocluc
            // 
            this.Hocluc.Location = new System.Drawing.Point(113, 104);
            this.Hocluc.Name = "Hocluc";
            this.Hocluc.ReadOnly = true;
            this.Hocluc.Size = new System.Drawing.Size(156, 20);
            this.Hocluc.TabIndex = 3;
            // 
            // Quequan
            // 
            this.Quequan.Enabled = false;
            this.Quequan.FormattingEnabled = true;
            this.Quequan.Items.AddRange(new object[] {
            "An Giang",
            "Đắk Nông",
            "Kon Tum",
            "Quảng Trị",
            "Bà Rịa - Vũng Tàu",
            "Điện Biên",
            "Lai Châu",
            "Sóc Trăng",
            "Bạc Liêu",
            "Đồng Nai",
            "Lâm Đồng",
            "Sơn La",
            "Bắc Giang",
            "Đồng Tháp ",
            "Lạng Sơn",
            "Tây Ninh",
            "Bắc Kạn",
            "Gia Lai",
            "Lào Cai",
            "Thái Bình",
            "Bắc Ninh",
            "Hà Giang",
            "Long An",
            "Thái Nguyên",
            "Bến Tre",
            "Hà Nam",
            "Nam Định\t",
            "Thanh Hóa",
            "Bình Định\t",
            "Hà Nội",
            "Nghệ An",
            "Thừa Thiên Huế",
            "Bình Dương",
            "Hà Tĩnh",
            "Ninh Bình",
            "Tiền Giang",
            "Bình Phước",
            "Hải Dương",
            "Ninh Thuận",
            "Trà Vinh",
            "Bình Thuận",
            "Hải Phòng",
            "Phú Thọ",
            "Tuyên Quang",
            "Cà Mau",
            "Hậu Giang",
            "Phú Yên",
            "Vĩnh Long",
            "Cần Thơ",
            "Hòa Bình",
            "Quảng Bình",
            "Vĩnh Phúc",
            "Cao Bằng",
            "Hưng Yên",
            "Quảng Nam",
            "Yên Bái",
            "Đà Nẵng",
            "Khánh Hòa",
            "Quảng Ngãi",
            "Phú Quốc",
            "Đắk Lắk",
            "Kiên Giang",
            "Quảng Ninh\t"});
            this.Quequan.Location = new System.Drawing.Point(113, 71);
            this.Quequan.Name = "Quequan";
            this.Quequan.Size = new System.Drawing.Size(156, 21);
            this.Quequan.TabIndex = 4;
            this.Quequan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quê quán";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Học lực";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã số sinh viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thông tin sinh viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Họ tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(275, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Chức năng";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Xem in";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(368, 170);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(287, 170);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 17;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(206, 170);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Control;
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(125, 170);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Thêm";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Danh sách sinh viên";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MssvColumn,
            this.HotenColumn,
            this.QueQuanColumn,
            this.NgaysinhColumn,
            this.HocLucColumn});
            this.dataGridView1.Location = new System.Drawing.Point(15, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(671, 198);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MssvColumn
            // 
            this.MssvColumn.HeaderText = "Mã số sinh viên";
            this.MssvColumn.Name = "MssvColumn";
            // 
            // HotenColumn
            // 
            this.HotenColumn.HeaderText = "Họ tên";
            this.HotenColumn.Name = "HotenColumn";
            // 
            // QueQuanColumn
            // 
            this.QueQuanColumn.HeaderText = "Quê Quán";
            this.QueQuanColumn.Name = "QueQuanColumn";
            // 
            // NgaysinhColumn
            // 
            this.NgaysinhColumn.HeaderText = "Ngày Sinh";
            this.NgaysinhColumn.Name = "NgaysinhColumn";
            // 
            // HocLucColumn
            // 
            this.HocLucColumn.HeaderText = "Học Lực";
            this.HocLucColumn.Name = "HocLucColumn";
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.Enabled = false;
            this.Ngaysinh.Location = new System.Drawing.Point(348, 76);
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.Size = new System.Drawing.Size(338, 20);
            this.Ngaysinh.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.Ngaysinh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quequan);
            this.Controls.Add(this.Hocluc);
            this.Controls.Add(this.Hoten);
            this.Controls.Add(this.Mssv);
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Mssv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Hoten;
        private System.Windows.Forms.TextBox Hocluc;
        private System.Windows.Forms.ComboBox Quequan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MssvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaysinhColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocLucColumn;
    }
}

