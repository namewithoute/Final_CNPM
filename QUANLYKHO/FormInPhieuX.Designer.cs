
namespace QUANLYKHO
{
    partial class FormInPhieuX
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
            this.rpvPhieuXuat = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvPhieuXuat
            // 
            this.rpvPhieuXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvPhieuXuat.Location = new System.Drawing.Point(2, 1);
            this.rpvPhieuXuat.Name = "rpvPhieuXuat";
            this.rpvPhieuXuat.ServerReport.BearerToken = null;
            this.rpvPhieuXuat.Size = new System.Drawing.Size(800, 446);
            this.rpvPhieuXuat.TabIndex = 0;
            this.rpvPhieuXuat.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // FormInPhieuX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvPhieuXuat);
            this.Name = "FormInPhieuX";
            this.Text = "FormInPhieuX";
            this.Load += new System.EventHandler(this.FormInPhieuX_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvPhieuXuat;
    }
}