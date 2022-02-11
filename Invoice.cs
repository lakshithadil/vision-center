using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vision_center1
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonplaceanorder_Click(object sender, EventArgs e)
        {
            reporttrans reporttrans = new reporttrans();
            reporttrans.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            find_trans findTrans = new find_trans();
            findTrans.Show();
        }
    }
}
