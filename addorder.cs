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
    public partial class addorder : Form
    {
        public addorder(string value)
        {
            InitializeComponent();
            this.value = value;
            oRDERBindingNavigator.Visible = false;
        }

        private void oRDERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oRDERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visionCenterDataSet);

        }
        public string value { get; set; }
        private void addorder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visionCenterDataSet.ORDER' table. You can move, or remove it, as needed.
            //this.oRDERTableAdapter.Fill(this.visionCenterDataSet.ORDER);
            oRDERBindingSource.AddNew();
            cIDMaskedTextBox.Text = value;
            sPECTACLECheckBox.CheckState = CheckState.Unchecked;
            rEPAIRCheckBox.CheckState = CheckState.Unchecked;
            aCCESSORIESCheckBox.CheckState = CheckState.Unchecked;
            sUNGLASSCheckBox.CheckState = CheckState.Unchecked;


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
            oRDERBindingNavigatorSaveItem.PerformClick();
            openChildForm(new Orderline(oIDMaskedTextBox.Text));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
