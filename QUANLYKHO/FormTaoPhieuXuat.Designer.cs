
namespace QUANLYKHO
{
    partial class FormTaoPhieuXuat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.soDienThoai = new System.Windows.Forms.TextBox();
            this.tenNguoiNhan = new System.Windows.Forms.TextBox();
            this.maPhieuXuat = new System.Windows.Forms.TextBox();
            this.ngayXuat = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.diaChi = new System.Windows.Forms.TextBox();
            this.dataTaoPhieuXuat = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TTGiaoHang = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TTThanhToan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTaoPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(138, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người nhận";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(151, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(169, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(151, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã phiếu xuất";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // soDienThoai
            // 
            this.soDienThoai.Location = new System.Drawing.Point(289, 129);
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.Size = new System.Drawing.Size(233, 22);
            this.soDienThoai.TabIndex = 4;
            // 
            // tenNguoiNhan
            // 
            this.tenNguoiNhan.Location = new System.Drawing.Point(289, 83);
            this.tenNguoiNhan.Name = "tenNguoiNhan";
            this.tenNguoiNhan.Size = new System.Drawing.Size(233, 22);
            this.tenNguoiNhan.TabIndex = 5;
            // 
            // maPhieuXuat
            // 
            this.maPhieuXuat.Location = new System.Drawing.Point(289, 41);
            this.maPhieuXuat.Name = "maPhieuXuat";
            this.maPhieuXuat.Size = new System.Drawing.Size(233, 22);
            this.maPhieuXuat.TabIndex = 6;
            // 
            // ngayXuat
            // 
            this.ngayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayXuat.Location = new System.Drawing.Point(692, 45);
            this.ngayXuat.Name = "ngayXuat";
            this.ngayXuat.Size = new System.Drawing.Size(200, 22);
            this.ngayXuat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày xuất";
            // 
            // diaChi
            // 
            this.diaChi.Location = new System.Drawing.Point(289, 172);
            this.diaChi.Name = "diaChi";
            this.diaChi.Size = new System.Drawing.Size(233, 22);
            this.diaChi.TabIndex = 9;
            // 
            // dataTaoPhieuXuat
            // 
            this.dataTaoPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTaoPhieuXuat.Location = new System.Drawing.Point(176, 264);
            this.dataTaoPhieuXuat.Name = "dataTaoPhieuXuat";
            this.dataTaoPhieuXuat.RowHeadersWidth = 51;
            this.dataTaoPhieuXuat.RowTemplate.Height = 24;
            this.dataTaoPhieuXuat.Size = new System.Drawing.Size(768, 185);
            this.dataTaoPhieuXuat.TabIndex = 10;
            this.dataTaoPhieuXuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(735, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 13;
            // 
            // TTGiaoHang
            // 
            this.TTGiaoHang.Location = new System.Drawing.Point(555, 102);
            this.TTGiaoHang.Name = "TTGiaoHang";
            this.TTGiaoHang.Size = new System.Drawing.Size(151, 23);
            this.TTGiaoHang.TabIndex = 12;
            this.TTGiaoHang.Text = "Tình trạng giao hàng";
            this.TTGiaoHang.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(735, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 22);
            this.textBox2.TabIndex = 15;
            // 
            // TTThanhToan
            // 
            this.TTThanhToan.Location = new System.Drawing.Point(564, 151);
            this.TTThanhToan.Name = "TTThanhToan";
            this.TTThanhToan.Size = new System.Drawing.Size(151, 23);
            this.TTThanhToan.TabIndex = 14;
            this.TTThanhToan.Text = "Tình trạng thanh toán";
            // 
            // FormTaoPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 531);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TTThanhToan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TTGiaoHang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataTaoPhieuXuat);
            this.Controls.Add(this.diaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ngayXuat);
            this.Controls.Add(this.maPhieuXuat);
            this.Controls.Add(this.tenNguoiNhan);
            this.Controls.Add(this.soDienThoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTaoPhieuXuat";
            this.Text = "Tạo phiếu xuất";
            ((System.ComponentModel.ISupportInitialize)(this.dataTaoPhieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soDienThoai;
        private System.Windows.Forms.TextBox tenNguoiNhan;
        private System.Windows.Forms.TextBox maPhieuXuat;
        private System.Windows.Forms.DateTimePicker ngayXuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox diaChi;
        private System.Windows.Forms.DataGridView dataTaoPhieuXuat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TTGiaoHang;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TTThanhToan;
    }
}