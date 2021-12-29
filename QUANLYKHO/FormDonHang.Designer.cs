
namespace QUANLYKHO
{
    partial class FormDonHang
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
            this.label6 = new System.Windows.Forms.Label();
            this.maDon = new System.Windows.Forms.TextBox();
            this.tenDaiLy = new System.Windows.Forms.TextBox();
            this.soDienThoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dsMaDon = new System.Windows.Forms.ListBox();
            this.dataDonHang = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChuyenPhieuXuat = new System.Windows.Forms.Button();
            this.ngayDatHang = new System.Windows.Forms.DateTimePicker();
            this.diaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thaoTácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoPhiếuNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoPhiếuXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.htThanhToan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDonHang)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đại lý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày đặt hàng";
            // 
            // maDon
            // 
            this.maDon.Location = new System.Drawing.Point(321, 128);
            this.maDon.Name = "maDon";
            this.maDon.Size = new System.Drawing.Size(174, 22);
            this.maDon.TabIndex = 7;
            // 
            // tenDaiLy
            // 
            this.tenDaiLy.Location = new System.Drawing.Point(321, 177);
            this.tenDaiLy.Name = "tenDaiLy";
            this.tenDaiLy.Size = new System.Drawing.Size(174, 22);
            this.tenDaiLy.TabIndex = 8;
            // 
            // soDienThoai
            // 
            this.soDienThoai.Location = new System.Drawing.Point(321, 230);
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.Size = new System.Drawing.Size(174, 22);
            this.soDienThoai.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(497, 55);
            this.label5.TabIndex = 13;
            this.label5.Text = "Đơn đặt hàng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dsMaDon
            // 
            this.dsMaDon.FormattingEnabled = true;
            this.dsMaDon.ItemHeight = 16;
            this.dsMaDon.Location = new System.Drawing.Point(-3, 31);
            this.dsMaDon.Name = "dsMaDon";
            this.dsMaDon.Size = new System.Drawing.Size(107, 612);
            this.dsMaDon.TabIndex = 14;
            this.dsMaDon.SelectedIndexChanged += new System.EventHandler(this.dsMaDon_SelectedIndexChanged);
            // 
            // dataDonHang
            // 
            this.dataDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.SoLuong,
            this.DonGia,
            this.TongTien});
            this.dataDonHang.Location = new System.Drawing.Point(206, 417);
            this.dataDonHang.Name = "dataDonHang";
            this.dataDonHang.RowHeadersWidth = 51;
            this.dataDonHang.RowTemplate.Height = 24;
            this.dataDonHang.Size = new System.Drawing.Size(680, 201);
            this.dataDonHang.TabIndex = 15;
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.MinimumWidth = 6;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Width = 125;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 125;
            // 
            // btnChuyenPhieuXuat
            // 
            this.btnChuyenPhieuXuat.Location = new System.Drawing.Point(733, 356);
            this.btnChuyenPhieuXuat.Name = "btnChuyenPhieuXuat";
            this.btnChuyenPhieuXuat.Size = new System.Drawing.Size(143, 46);
            this.btnChuyenPhieuXuat.TabIndex = 16;
            this.btnChuyenPhieuXuat.Text = "Tạo phiếu xuất kho";
            this.btnChuyenPhieuXuat.UseVisualStyleBackColor = true;
            this.btnChuyenPhieuXuat.Click += new System.EventHandler(this.btnChuyenPhieuXuat_Click);
            // 
            // ngayDatHang
            // 
            this.ngayDatHang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayDatHang.Location = new System.Drawing.Point(711, 138);
            this.ngayDatHang.Name = "ngayDatHang";
            this.ngayDatHang.Size = new System.Drawing.Size(139, 22);
            this.ngayDatHang.TabIndex = 17;
            // 
            // diaChi
            // 
            this.diaChi.Location = new System.Drawing.Point(709, 180);
            this.diaChi.Multiline = true;
            this.diaChi.Name = "diaChi";
            this.diaChi.Size = new System.Drawing.Size(204, 65);
            this.diaChi.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Địa chỉ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.thaoTácToolStripMenuItem,
            this.đơnHàngToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(991, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem,
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // danhSáchPhiếuNhậpKhoToolStripMenuItem
            // 
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem.Name = "danhSáchPhiếuNhậpKhoToolStripMenuItem";
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem.Text = "Danh sách phiếu nhập kho";
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem.Click += new System.EventHandler(this.danhSáchPhiếuNhậpKhoToolStripMenuItem_Click);
            // 
            // danhSáchPhiếuXuấtKhoToolStripMenuItem
            // 
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem.Name = "danhSáchPhiếuXuấtKhoToolStripMenuItem";
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem.Text = "Danh sách phiếu xuất kho";
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem.Click += new System.EventHandler(this.danhSáchPhiếuXuấtKhoToolStripMenuItem_Click);
            // 
            // thaoTácToolStripMenuItem
            // 
            this.thaoTácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoPhiếuNhậpKhoToolStripMenuItem,
            this.tạoPhiếuXuấtKhoToolStripMenuItem});
            this.thaoTácToolStripMenuItem.Name = "thaoTácToolStripMenuItem";
            this.thaoTácToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.thaoTácToolStripMenuItem.Text = "Thao tác";
            // 
            // tạoPhiếuNhậpKhoToolStripMenuItem
            // 
            this.tạoPhiếuNhậpKhoToolStripMenuItem.Name = "tạoPhiếuNhậpKhoToolStripMenuItem";
            this.tạoPhiếuNhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.tạoPhiếuNhậpKhoToolStripMenuItem.Text = "Tạo phiếu nhập kho";
            this.tạoPhiếuNhậpKhoToolStripMenuItem.Click += new System.EventHandler(this.tạoPhiếuNhậpKhoToolStripMenuItem_Click);
            // 
            // tạoPhiếuXuấtKhoToolStripMenuItem
            // 
            this.tạoPhiếuXuấtKhoToolStripMenuItem.Name = "tạoPhiếuXuấtKhoToolStripMenuItem";
            this.tạoPhiếuXuấtKhoToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.tạoPhiếuXuấtKhoToolStripMenuItem.Text = "Tạo phiếu xuất kho";
            this.tạoPhiếuXuấtKhoToolStripMenuItem.Click += new System.EventHandler(this.tạoPhiếuXuấtKhoToolStripMenuItem_Click);
            // 
            // đơnHàngToolStripMenuItem
            // 
            this.đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            this.đơnHàngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.đơnHàngToolStripMenuItem.Text = "Đơn hàng";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(321, 276);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 49);
            this.textBox2.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ghi chú";
            // 
            // htThanhToan
            // 
            this.htThanhToan.Location = new System.Drawing.Point(709, 278);
            this.htThanhToan.Name = "htThanhToan";
            this.htThanhToan.Size = new System.Drawing.Size(186, 22);
            this.htThanhToan.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Hình thức thanh toán";
            // 
            // FormDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 630);
            this.Controls.Add(this.htThanhToan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.diaChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ngayDatHang);
            this.Controls.Add(this.btnChuyenPhieuXuat);
            this.Controls.Add(this.dataDonHang);
            this.Controls.Add(this.dsMaDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.soDienThoai);
            this.Controls.Add(this.tenDaiLy);
            this.Controls.Add(this.maDon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDonHang";
            this.Text = "FormDonHang";
            this.Load += new System.EventHandler(this.FormDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDonHang)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maDon;
        private System.Windows.Forms.TextBox tenDaiLy;
        private System.Windows.Forms.TextBox soDienThoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox dsMaDon;
        private System.Windows.Forms.DataGridView dataDonHang;
        private System.Windows.Forms.Button btnChuyenPhieuXuat;
        private System.Windows.Forms.DateTimePicker ngayDatHang;
        private System.Windows.Forms.TextBox diaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thaoTácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoPhiếuNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoPhiếuXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.TextBox htThanhToan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
    }
}