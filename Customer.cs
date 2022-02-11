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
    public partial class Customer : Form
    {
        public static Customer forminstance;
        public Customer()
        {
            InitializeComponent();
            forminstance = this;
            cUSTOMERBindingNavigator.Visible = false;
        }
        
        private void cUSTOMERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTOMERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visionCenterDataSet);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visionCenterDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            //this.cUSTOMERTableAdapter.Fill(this.visionCenterDataSet.CUSTOMER);
            cUSTOMERBindingSource.AddNew();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            cUSTOMERBindingNavigatorSaveItem.PerformClick();
            if (comboBox1.Text == "YES")
            {
                openChildForm(new PRESCRIPTION(cIDMaskedTextBox.Text));

            }
            else
            {
                openChildForm(new addorder(cIDMaskedTextBox.Text));
            }
            this.ControlBox = false;
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

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
