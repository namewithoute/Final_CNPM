
namespace QUANLYKHO
{
    partial class FormDanhSachPhieuNhap
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thaoTácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoPhiếuNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoPhiếuXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ds_phieunhap = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ngayNhapKho = new System.Windows.Forms.DateTimePicker();
            this.dataDanhSachPhieuNhap = new System.Windows.Forms.DataGridView();
            this.STTSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.TextBox();
            this.maPhieuNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachPhieuNhap)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1162, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.đơnHàngToolStripMenuItem.Click += new System.EventHandler(this.đơnHàngToolStripMenuItem_Click_1);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // ds_phieunhap
            // 
            this.ds_phieunhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ds_phieunhap.FormattingEnabled = true;
            this.ds_phieunhap.HorizontalScrollbar = true;
            this.ds_phieunhap.ItemHeight = 16;
            this.ds_phieunhap.Location = new System.Drawing.Point(12, 31);
            this.ds_phieunhap.Name = "ds_phieunhap";
            this.ds_phieunhap.Size = new System.Drawing.Size(151, 516);
            this.ds_phieunhap.TabIndex = 3;
            this.ds_phieunhap.SelectedIndexChanged += new System.EventHandler(this.ds_phieunhap_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày nhập kho";
            // 
            // ngayNhapKho
            // 
            this.ngayNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ngayNhapKho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayNhapKho.Location = new System.Drawing.Point(547, 223);
            this.ngayNhapKho.Name = "ngayNhapKho";
            this.ngayNhapKho.Size = new System.Drawing.Size(189, 22);
            this.ngayNhapKho.TabIndex = 9;
            // 
            // dataDanhSachPhieuNhap
            // 
            this.dataDanhSachPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDanhSachPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDanhSachPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTSanPham,
            this.MaSanPham,
            this.TenSanPham,
            this.SoLuong,
            this.DonGia,
            this.TongTien});
            this.dataDanhSachPhieuNhap.Location = new System.Drawing.Point(221, 319);
            this.dataDanhSachPhieuNhap.Name = "dataDanhSachPhieuNhap";
            this.dataDanhSachPhieuNhap.RowHeadersVisible = false;
            this.dataDanhSachPhieuNhap.RowHeadersWidth = 51;
            this.dataDanhSachPhieuNhap.RowTemplate.Height = 24;
            this.dataDanhSachPhieuNhap.Size = new System.Drawing.Size(916, 175);
            this.dataDanhSachPhieuNhap.TabIndex = 0;
            this.dataDanhSachPhieuNhap.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataDanhSachPhieuNhap_CellMouseUp);
            this.dataDanhSachPhieuNhap.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDanhSachPhieuNhap_CellValueChanged);
            // 
            // STTSanPham
            // 
            this.STTSanPham.DataPropertyName = "STTSanPham";
            this.STTSanPham.HeaderText = "Số thứ tự sản phẩm";
            this.STTSanPham.MinimumWidth = 6;
            this.STTSanPham.Name = "STTSanPham";
            this.STTSanPham.Visible = false;
            this.STTSanPham.Width = 125;
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
            this.TenSanPham.Width = 135;
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
            // tenNhanVien
            // 
            this.tenNhanVien.Enabled = false;
            this.tenNhanVien.Location = new System.Drawing.Point(547, 176);
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.Size = new System.Drawing.Size(183, 22);
            this.tenNhanVien.TabIndex = 10;
            // 
            // maPhieuNhap
            // 
            this.maPhieuNhap.Enabled = false;
            this.maPhieuNhap.Location = new System.Drawing.Point(547, 126);
            this.maPhieuNhap.Name = "maPhieuNhap";
            this.maPhieuNhap.Size = new System.Drawing.Size(183, 22);
            this.maPhieuNhap.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(653, 57);
            this.label4.TabIndex = 12;
            this.label4.Text = "PHIẾU NHẬP KHO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(911, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "Xóa phiếu nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // FormDanhSachPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataDanhSachPhieuNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maPhieuNhap);
            this.Controls.Add(this.tenNhanVien);
            this.Controls.Add(this.ngayNhapKho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ds_phieunhap);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormDanhSachPhieuNhap";
            this.Text = "Danh sách phiếu nhập kho";
            this.Load += new System.EventHandler(this.FormDanhSachPhieuNhap_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachPhieuNhap)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thaoTácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoPhiếuNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoPhiếuXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.ListBox ds_phieunhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ngayNhapKho;
        private System.Windows.Forms.DataGridView dataDanhSachPhieuNhap;
        private System.Windows.Forms.TextBox tenNhanVien;
        private System.Windows.Forms.TextBox maPhieuNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
    }
}