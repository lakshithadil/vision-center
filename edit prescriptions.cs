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
    public partial class edit_prescriptions : Form
    {
        public edit_prescriptions()
        {
            InitializeComponent();
        }

        private void pRESCRIPTIONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRESCRIPTIONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visionCenterDataSet);

        }

        private void edit_prescriptions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visionCenterDataSet.PRESCRIPTION' table. You can move, or remove it, as needed.
            this.pRESCRIPTIONTableAdapter.Fill(this.visionCenterDataSet.PRESCRIPTION);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value;
            int index;

            value = Microsoft.VisualBasic.Interaction.InputBox("Prescription ID", "Find Prescription");
            index = pRESCRIPTIONBindingSource.Find("PRID", value);

            if (index == -1)
            {
                MessageBox.Show("Prescription Not Found", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               pRESCRIPTIONBindingSource.Position = index;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pRESCRIPTIONBindingNavigatorSaveItem.PerformClick();
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
