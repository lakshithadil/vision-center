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
    public partial class Frame : Form
    {
        public Frame(string value)
        {
            InitializeComponent();
            this.value = value;
            fRAMEBindingNavigator.Visible = false;
        }
        public string value { get; set; }
        private void fRAMEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fRAMEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visionCenterDataSet);

        }

        private void fRAMEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.fRAMEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visionCenterDataSet);

        }

        private void Frame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visionCenterDataSet.FRAME' table. You can move, or remove it, as needed.
            // this.fRAMETableAdapter.Fill(this.visionCenterDataSet.FRAME);
            fRAMEBindingSource.AddNew();
            pIDMaskedTextBox.Text = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fRAMEBindingNavigatorSaveItem.PerformClick();
            addproducts.forminstance.Close();
            MessageBox.Show("successfully added");
        }
    }
}
