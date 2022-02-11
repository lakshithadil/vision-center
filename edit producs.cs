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
    public partial class edit_products : Form
    {
        public edit_products()
        {
            InitializeComponent();
            groupBox2.Visible = false;
            groupBox1.Visible = false;
        }

        private void pRODUCTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRODUCTBindingSource.EndEdit();
            this.lENSEBindingSource.EndEdit();
            this.fRAMEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visionCenterDataSet);

        }

        private void edit_producs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visionCenterDataSet.LENSE' table. You can move, or remove it, as needed.
            this.lENSETableAdapter.Fill(this.visionCenterDataSet.LENSE);
            // TODO: This line of code loads data into the 'visionCenterDataSet.FRAME' table. You can move, or remove it, as needed.
            this.fRAMETableAdapter.Fill(this.visionCenterDataSet.FRAME);
            // TODO: This line of code loads data into the 'visionCenterDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.visionCenterDataSet.PRODUCT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value;
            int index;

            value = Microsoft.VisualBasic.Interaction.InputBox("Product ID", "Find Product");
            index = pRODUCTBindingSource.Find("PID", value);

            if (index == -1)
            {
                MessageBox.Show("Product Not Found", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pRODUCTBindingSource.Position = index;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pRODUCTBindingNavigatorSaveItem.PerformClick();
            MessageBox.Show("    successfully updated");
            Close();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex == 0)
            {
                groupBox2.Visible = true;
                groupBox1.Visible = false;
            }
            else if (categoryComboBox.SelectedIndex == 1)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void categoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            


        }

        private void categoryComboBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
