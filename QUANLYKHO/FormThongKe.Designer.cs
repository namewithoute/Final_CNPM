
namespace QUANLYKHO
{
    partial class FormThongKe
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
            this.ngayThongKe = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataDsNhap = new System.Windows.Forms.DataGridView();
            this.MaSanPhamNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPhamNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataDsXuat = new System.Windows.Forms.DataGridView();
            this.MaSanPhamXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPhamXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXemTK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTienNhap = new System.Windows.Forms.TextBox();
            this.txtTienXuat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thaoTácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thaoTácToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoPhiếuXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoPhiếuXuấtKhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataDsNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDsXuat)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ngayThongKe
            // 
            this.ngayThongKe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayThongKe.Location = new System.Drawing.Point(386, 96);
            this.ngayThongKe.Name = "ngayThongKe";
            this.ngayThongKe.Size = new System.Drawing.Size(154, 22);
            this.ngayThongKe.TabIndex = 0;
            this.ngayThongKe.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê hàng tháng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thống kê tháng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataDsNhap
            // 
            this.dataDsNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDsNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPhamNhap,
            this.TenSanPhamNhap,
            this.SoLuongNhap,
            this.DonGiaNhap,
            this.TongTienNhap});
            this.dataDsNhap.Location = new System.Drawing.Point(126, 191);
            this.dataDsNhap.Name = "dataDsNhap";
            this.dataDsNhap.RowHeadersWidth = 51;
            this.dataDsNhap.RowTemplate.Height = 24;
            this.dataDsNhap.Size = new System.Drawing.Size(791, 141);
            this.dataDsNhap.TabIndex = 3;
            // 
            // MaSanPhamNhap
            // 
            this.MaSanPhamNhap.DataPropertyName = "MaSanPhamNhap";
            this.MaSanPhamNhap.HeaderText = "Mã sản phẩm";
            this.MaSanPhamNhap.MinimumWidth = 6;
            this.MaSanPhamNhap.Name = "MaSanPhamNhap";
            this.MaSanPhamNhap.Width = 125;
            // 
            // TenSanPhamNhap
            // 
            this.TenSanPhamNhap.DataPropertyName = "TenSanPhamNhap";
            this.TenSanPhamNhap.HeaderText = "Tên sản phẩm";
            this.TenSanPhamNhap.MinimumWidth = 6;
            this.TenSanPhamNhap.Name = "TenSanPhamNhap";
            this.TenSanPhamNhap.Width = 125;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "Số lượng";
            this.SoLuongNhap.MinimumWidth = 6;
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.Width = 125;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Đơn giá";
            this.DonGiaNhap.MinimumWidth = 6;
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.Width = 125;
            // 
            // TongTienNhap
            // 
            this.TongTienNhap.DataPropertyName = "TongTienNhap";
            this.TongTienNhap.HeaderText = "Tổng tiền";
            this.TongTienNhap.MinimumWidth = 6;
            this.TongTienNhap.Name = "TongTienNhap";
            this.TongTienNhap.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sản phẩm nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sản phẩm xuất";
            // 
            // dataDsXuat
            // 
            this.dataDsXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDsXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPhamXuat,
            this.TenSanPhamXuat,
            this.SoLuongXuat,
            this.DonGiaXuat,
            this.TongTienXuat});
            this.dataDsXuat.Location = new System.Drawing.Point(126, 443);
            this.dataDsXuat.Name = "dataDsXuat";
            this.dataDsXuat.RowHeadersWidth = 51;
            this.dataDsXuat.RowTemplate.Height = 24;
            this.dataDsXuat.Size = new System.Drawing.Size(791, 143);
            this.dataDsXuat.TabIndex = 6;
            // 
            // MaSanPhamXuat
            // 
            this.MaSanPhamXuat.DataPropertyName = "MaSanPhamXuat";
            this.MaSanPhamXuat.HeaderText = "Mã sản phẩm";
            this.MaSanPhamXuat.MinimumWidth = 6;
            this.MaSanPhamXuat.Name = "MaSanPhamXuat";
            this.MaSanPhamXuat.Width = 125;
            // 
            // TenSanPhamXuat
            // 
            this.TenSanPhamXuat.DataPropertyName = "TenSanPhamXuat";
            this.TenSanPhamXuat.HeaderText = "Tên sản phẩm";
            this.TenSanPhamXuat.MinimumWidth = 6;
            this.TenSanPhamXuat.Name = "TenSanPhamXuat";
            this.TenSanPhamXuat.Width = 125;
            // 
            // SoLuongXuat
            // 
            this.SoLuongXuat.DataPropertyName = "SoLuongXuat";
            this.SoLuongXuat.HeaderText = "Số lượng";
            this.SoLuongXuat.MinimumWidth = 6;
            this.SoLuongXuat.Name = "SoLuongXuat";
            this.SoLuongXuat.Width = 125;
            // 
            // DonGiaXuat
            // 
            this.DonGiaXuat.DataPropertyName = "DonGiaXuat";
            this.DonGiaXuat.HeaderText = "Đơn giá";
            this.DonGiaXuat.MinimumWidth = 6;
            this.DonGiaXuat.Name = "DonGiaXuat";
            this.DonGiaXuat.Width = 125;
            // 
            // TongTienXuat
            // 
            this.TongTienXuat.DataPropertyName = "TongTienXuat";
            this.TongTienXuat.HeaderText = "Tổng tiền ";
            this.TongTienXuat.MinimumWidth = 6;
            this.TongTienXuat.Name = "TongTienXuat";
            this.TongTienXuat.Width = 125;
            // 
            // btnXemTK
            // 
            this.btnXemTK.Location = new System.Drawing.Point(606, 85);
            this.btnXemTK.Name = "btnXemTK";
            this.btnXemTK.Size = new System.Drawing.Size(125, 48);
            this.btnXemTK.TabIndex = 7;
            this.btnXemTK.Text = "Xem thống kê";
            this.btnXemTK.UseVisualStyleBackColor = true;
            this.btnXemTK.Click += new System.EventHandler(this.btnXemTK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng tiền đã nhập kho";
            // 
            // txtTienNhap
            // 
            this.txtTienNhap.Enabled = false;
            this.txtTienNhap.Location = new System.Drawing.Point(817, 356);
            this.txtTienNhap.Name = "txtTienNhap";
            this.txtTienNhap.Size = new System.Drawing.Size(100, 22);
            this.txtTienNhap.TabIndex = 10;
            // 
            // txtTienXuat
            // 
            this.txtTienXuat.Enabled = false;
            this.txtTienXuat.Location = new System.Drawing.Point(817, 614);
            this.txtTienXuat.Name = "txtTienXuat";
            this.txtTienXuat.Size = new System.Drawing.Size(100, 22);
            this.txtTienXuat.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 617);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tổng tiền đã xuất kho";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thaoTácToolStripMenuItem,
            this.thaoTácToolStripMenuItem1,
            this.đơnHàngToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thaoTácToolStripMenuItem
            // 
            this.thaoTácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem,
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem});
            this.thaoTácToolStripMenuItem.Name = "thaoTácToolStripMenuItem";
            this.thaoTácToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thaoTácToolStripMenuItem.Text = "Thông tin";
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
            // thaoTácToolStripMenuItem1
            // 
            this.thaoTácToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoPhiếuXuấtKhoToolStripMenuItem,
            this.tạoPhiếuXuấtKhoToolStripMenuItem1});
            this.thaoTácToolStripMenuItem1.Name = "thaoTácToolStripMenuItem1";
            this.thaoTácToolStripMenuItem1.Size = new System.Drawing.Size(80, 24);
            this.thaoTácToolStripMenuItem1.Text = "Thao tác";
            // 
            // tạoPhiếuXuấtKhoToolStripMenuItem
            // 
            this.tạoPhiếuXuấtKhoToolStripMenuItem.Name = "tạoPhiếuXuấtKhoToolStripMenuItem";
            this.tạoPhiếuXuấtKhoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tạoPhiếuXuấtKhoToolStripMenuItem.Text = "Tạo phiếu nhập kho";
            this.tạoPhiếuXuấtKhoToolStripMenuItem.Click += new System.EventHandler(this.tạoPhiếuXuấtKhoToolStripMenuItem_Click);
            // 
            // tạoPhiếuXuấtKhoToolStripMenuItem1
            // 
            this.tạoPhiếuXuấtKhoToolStripMenuItem1.Name = "tạoPhiếuXuấtKhoToolStripMenuItem1";
            this.tạoPhiếuXuấtKhoToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.tạoPhiếuXuấtKhoToolStripMenuItem1.Text = "Tạo phiếu xuất kho";
            this.tạoPhiếuXuấtKhoToolStripMenuItem1.Click += new System.EventHandler(this.tạoPhiếuXuấtKhoToolStripMenuItem1_Click);
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
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 681);
            this.Controls.Add(this.txtTienXuat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTienNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXemTK);
            this.Controls.Add(this.dataDsXuat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataDsNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ngayThongKe);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDsNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDsXuat)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ngayThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataDsNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataDsXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPhamNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPhamNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienNhap;
        private System.Windows.Forms.Button btnXemTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPhamXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPhamXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienXuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTienNhap;
        private System.Windows.Forms.TextBox txtTienXuat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thaoTácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thaoTácToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tạoPhiếuXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoPhiếuXuấtKhoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
    }
}