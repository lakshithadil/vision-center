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

namespace vision_center1
{
    public partial class finalinvoice : Form
    {
        public finalinvoice(string para)
        {
            InitializeComponent();
            this.para = para;
        }

        private void finalinvoice_Load(object sender, EventArgs e)
        {

            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("TID", para, true);

            reportViewer1.ServerReport.SetParameters(parameters);
            reportViewer1.RefreshReport();

        }
        public string para { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            //ReportParameter[] parameters = new ReportParameter[1];
            //parameters[0] = new ReportParameter("TID", para, true);

            //reportViewer1.ServerReport.SetParameters(parameters);
            //reportViewer1.RefreshReport();
        }
    }
}
