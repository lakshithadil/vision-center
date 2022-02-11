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
    public partial class PRESCRIPTION : Form
    {
        public PRESCRIPTION(string value)

        {
            InitializeComponent();
            this.value = value;
            pRESCRIPTIONBindingNavigator.Visible = false;
        }
        public string value { get; set; }
        private void pRESCRIPTIONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRESCRIPTIONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visionCenterDataSet);

        }

        private void PRESCRIPTION_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visionCenterDataSet.PRESCRIPTION' table. You can move, or remove it, as needed.
            //this.pRESCRIPTIONTableAdapter.Fill(this.visionCenterDataSet.PRESCRIPTION);
            pRESCRIPTIONBindingSource.AddNew();
            cIDMaskedTextBox.Text = value;
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
            pRESCRIPTIONBindingNavigatorSaveItem.PerformClick();
            openChildForm(new addorder(cIDMaskedTextBox.Text));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
