
namespace QUANLYKHO
{
    partial class FormDanhSachPhieuXuat
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
            this.dsMaXuat = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thaoTácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoPhiếuNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoPhiếuXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maPhieuXuat = new System.Windows.Forms.TextBox();
            this.tenNguoiNhan = new System.Windows.Forms.TextBox();
            this.soDienThoai = new System.Windows.Forms.TextBox();
            this.diaChi = new System.Windows.Forms.TextBox();
            this.dataDanhSachXuat = new System.Windows.Forms.DataGridView();
            this.STTSanPhamXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXuatKho = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboTTGiaoHang = new System.Windows.Forms.ComboBox();
            this.comboTTThanhToan = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachXuat)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsMaXuat
            // 
            this.dsMaXuat.FormattingEnabled = true;
            this.dsMaXuat.ItemHeight = 16;
            this.dsMaXuat.Location = new System.Drawing.Point(0, 28);
            this.dsMaXuat.Name = "dsMaXuat";
            this.dsMaXuat.Size = new System.Drawing.Size(118, 596);
            this.dsMaXuat.TabIndex = 0;
            this.dsMaXuat.SelectedIndexChanged += new System.EventHandler(this.dsMaXuat_SelectedIndexChanged);
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
            this.menuStrip1.Size = new System.Drawing.Size(1016, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchPhiếuNhậpToolStripMenuItem,
            this.danhSáchPhiếuXuấtToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // danhSáchPhiếuNhậpToolStripMenuItem
            // 
            this.danhSáchPhiếuNhậpToolStripMenuItem.Name = "danhSáchPhiếuNhậpToolStripMenuItem";
            this.danhSáchPhiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.danhSáchPhiếuNhậpToolStripMenuItem.Text = "Danh sách phiếu nhập ";
            this.danhSáchPhiếuNhậpToolStripMenuItem.Click += new System.EventHandler(this.danhSáchPhiếuNhậpToolStripMenuItem_Click);
            // 
            // danhSáchPhiếuXuấtToolStripMenuItem
            // 
            this.danhSáchPhiếuXuấtToolStripMenuItem.Name = "danhSáchPhiếuXuấtToolStripMenuItem";
            this.danhSáchPhiếuXuấtToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.danhSáchPhiếuXuấtToolStripMenuItem.Text = "Danh sách phiếu xuất";
            this.danhSáchPhiếuXuấtToolStripMenuItem.Click += new System.EventHandler(this.danhSáchPhiếuXuấtToolStripMenuItem_Click);
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
            this.đơnHàngToolStripMenuItem.Click += new System.EventHandler(this.đơnHàngToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "PHIẾU XUẤT KHO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã phiếu xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên người nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ";
            // 
            // maPhieuXuat
            // 
            this.maPhieuXuat.Enabled = false;
            this.maPhieuXuat.Location = new System.Drawing.Point(340, 94);
            this.maPhieuXuat.Name = "maPhieuXuat";
            this.maPhieuXuat.Size = new System.Drawing.Size(220, 22);
            this.maPhieuXuat.TabIndex = 7;
            // 
            // tenNguoiNhan
            // 
            this.tenNguoiNhan.Location = new System.Drawing.Point(340, 138);
            this.tenNguoiNhan.Name = "tenNguoiNhan";
            this.tenNguoiNhan.Size = new System.Drawing.Size(220, 22);
            this.tenNguoiNhan.TabIndex = 8;
            this.tenNguoiNhan.TextChanged += new System.EventHandler(this.tenNguoiNhan_TextChanged);
            // 
            // soDienThoai
            // 
            this.soDienThoai.Location = new System.Drawing.Point(340, 180);
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.Size = new System.Drawing.Size(220, 22);
            this.soDienThoai.TabIndex = 9;
            // 
            // diaChi
            // 
            this.diaChi.Location = new System.Drawing.Point(340, 225);
            this.diaChi.Name = "diaChi";
            this.diaChi.Size = new System.Drawing.Size(220, 22);
            this.diaChi.TabIndex = 10;
            // 
            // dataDanhSachXuat
            // 
            this.dataDanhSachXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDanhSachXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTSanPhamXuat,
            this.TenSanPham,
            this.MaSanPham,
            this.SoLuong,
            this.DonGia,
            this.TongTien});
            this.dataDanhSachXuat.Location = new System.Drawing.Point(189, 345);
            this.dataDanhSachXuat.Name = "dataDanhSachXuat";
            this.dataDanhSachXuat.RowHeadersVisible = false;
            this.dataDanhSachXuat.RowHeadersWidth = 51;
            this.dataDanhSachXuat.RowTemplate.Height = 24;
            this.dataDanhSachXuat.Size = new System.Drawing.Size(770, 241);
            this.dataDanhSachXuat.TabIndex = 11;
            this.dataDanhSachXuat.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataDanhSachXuat_CellMouseUp);
            this.dataDanhSachXuat.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDanhSachXuat_CellValueChanged);
            this.dataDanhSachXuat.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataDanhSachXuat_DataError);
            // 
            // STTSanPhamXuat
            // 
            this.STTSanPhamXuat.DataPropertyName = "STTSanPhamXuat";
            this.STTSanPhamXuat.HeaderText = "Số thứ tự sản phẩm";
            this.STTSanPhamXuat.MinimumWidth = 6;
            this.STTSanPhamXuat.Name = "STTSanPhamXuat";
            this.STTSanPhamXuat.Visible = false;
            this.STTSanPhamXuat.Width = 125;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenSanPham.Width = 125;
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.MinimumWidth = 6;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaSanPham.Width = 125;
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
            // ngayXuatKho
            // 
            this.ngayXuatKho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayXuatKho.Location = new System.Drawing.Point(825, 90);
            this.ngayXuatKho.Name = "ngayXuatKho";
            this.ngayXuatKho.Size = new System.Drawing.Size(152, 22);
            this.ngayXuatKho.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(690, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày xuất kho";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.Location = new System.Drawing.Point(765, 270);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(141, 49);
            this.btnXoaPhieu.TabIndex = 14;
            this.btnXoaPhieu.Text = "Xóa phiếu xuất kho";
            this.btnXoaPhieu.UseVisualStyleBackColor = true;
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPhieu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(658, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tình trạng giao hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(658, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tình trạng thanh toán";
            // 
            // comboTTGiaoHang
            // 
            this.comboTTGiaoHang.FormattingEnabled = true;
            this.comboTTGiaoHang.Location = new System.Drawing.Point(825, 138);
            this.comboTTGiaoHang.Name = "comboTTGiaoHang";
            this.comboTTGiaoHang.Size = new System.Drawing.Size(159, 24);
            this.comboTTGiaoHang.TabIndex = 19;
            this.comboTTGiaoHang.SelectedIndexChanged += new System.EventHandler(this.comboTTGiaoHang_SelectedIndexChanged);
            // 
            // comboTTThanhToan
            // 
            this.comboTTThanhToan.FormattingEnabled = true;
            this.comboTTThanhToan.Location = new System.Drawing.Point(823, 199);
            this.comboTTThanhToan.Name = "comboTTThanhToan";
            this.comboTTThanhToan.Size = new System.Drawing.Size(161, 24);
            this.comboTTThanhToan.TabIndex = 20;
            this.comboTTThanhToan.SelectedIndexChanged += new System.EventHandler(this.comboTTThanhToan_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "In phiếu xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDanhSachPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboTTThanhToan);
            this.Controls.Add(this.comboTTGiaoHang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXoaPhieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ngayXuatKho);
            this.Controls.Add(this.dataDanhSachXuat);
            this.Controls.Add(this.diaChi);
            this.Controls.Add(this.soDienThoai);
            this.Controls.Add(this.tenNguoiNhan);
            this.Controls.Add(this.maPhieuXuat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dsMaXuat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDanhSachPhieuXuat";
            this.Text = "FormDanhSachPhieuXuat";
            this.Load += new System.EventHandler(this.FormDanhSachPhieuXuat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachXuat)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dsMaXuat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thaoTácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maPhieuXuat;
        private System.Windows.Forms.TextBox tenNguoiNhan;
        private System.Windows.Forms.TextBox soDienThoai;
        private System.Windows.Forms.TextBox diaChi;
        private System.Windows.Forms.DataGridView dataDanhSachXuat;
        private System.Windows.Forms.DateTimePicker ngayXuatKho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTSanPhamXuat;
        private System.Windows.Forms.DataGridViewComboBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboTTGiaoHang;
        private System.Windows.Forms.ComboBox comboTTThanhToan;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoPhiếuNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoPhiếuXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}