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
    public partial class addproducts : Form
    {
        public static addproducts forminstance;
        public addproducts()
        {
            InitializeComponent();
            forminstance = this;
            pRODUCTBindingNavigator.Visible = false;
            
        }
      
        private void pRODUCTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRODUCTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visionCenterDataSet);

        }

        private void addproducts_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'visionCenterDataSet.PRODUCT' table. You can move, or remove it, as needed.
            //this.pRODUCTTableAdapter.Fill(this.visionCenterDataSet.PRODUCT);
            //if ()
           // {
                pRODUCTBindingSource.AddNew();
           // }
           // else
           // {
           //     this.pRODUCTTableAdapter.Fill(this.visionCenterDataSet.PRODUCT);
           // }
        }

        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();

            childForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pRODUCTBindingNavigatorSaveItem.PerformClick();
            if (categoryComboBox.Text == "lenses")
            {
                openChildForm(new Lense(pIDMaskedTextBox.Text));
                this.ControlBox = false;
            }
            else if (categoryComboBox.Text == "frames")
            {
                openChildForm(new Frame(pIDMaskedTextBox.Text));
                this.ControlBox = false;
            }
            else
            {
                addproducts.forminstance.Close();
                MessageBox.Show("successfully added");
              

            }
        }

    }
}
