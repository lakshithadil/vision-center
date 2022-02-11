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
    public partial class Lense : Form
    {
        public Lense(string value)
        {
            InitializeComponent();
            this.value = value;
            lENSEBindingNavigator.Visible = false;
        }

        public string value { get; set; }

        private void lENSEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lENSEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visionCenterDataSet);

        }

        private void Lense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visionCenterDataSet.LENSE' table. You can move, or remove it, as needed.
            //this.lENSETableAdapter.Fill(this.visionCenterDataSet.LENSE);
            lENSEBindingSource.AddNew();
            pIDMaskedTextBox.Text = value;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            lENSEBindingNavigatorSaveItem.PerformClick();
            addproducts.forminstance.Close();
            MessageBox.Show("successfully added");
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
