using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace QUANLYKHO
{
    public partial class FormInPhieuX : Form
    {
        private string query;
        public FormInPhieuX()
        {
            InitializeComponent();
        }

        private void FormInPhieuX_Load(object sender, EventArgs e)
        {

       
        }
        CauHinhRP ch = new CauHinhRP();
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            rpvPhieuXuat.LocalReport.ReportEmbeddedResource = "QUANLYKHO.ReportXuat.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = ch.Table(getQuery());
            rpvPhieuXuat.LocalReport.DataSources.Add(reportDataSource);
            this.rpvPhieuXuat.RefreshReport();
        }
        public void setQuery(string query)
        {
            this.query = query;
        }
        public string getQuery()
        {
            return this.query;
        }
       
    }
}
