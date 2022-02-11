using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace vision_center1
{
    public partial class Form1 : Form
    {

        public static Form1 forminstance;
        public Form1(string role,string user)
        {
            InitializeComponent();
            SidePanel.Height = buttonHome.Height;
            SidePanel.Top = buttonHome.Top;
            this.value = role;
            this.value1 = user;
            forminstance = this;

        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }
        public string value { get; set; }
        public string value1 { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            openChildForm(new Home());
            label3.Text = value;
            label4.Text = value1;
            if(value == "Other")
            {
                button1.Visible = false;
                buttonReports.Visible = false;
            }
            

        }

        void buttonOrder_Click(object sender, EventArgs e)
        {

            SidePanel.Height = buttonOrder.Height;
            SidePanel.Top = buttonOrder.Top;
            openChildForm(new Order());
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonHome.Height;
            SidePanel.Top = buttonHome.Top;
            
            openChildForm(new Home());
            
        }

        private void buttonHome_MouseHover(object sender, EventArgs e)
        {
            buttonHome.ForeColor = Color.White;
        }

        private void buttonHome_MouseLeave(object sender, EventArgs e)
        {
            buttonHome.ForeColor = Color.Wheat;
        }

        private void buttonOrder_MouseHover(object sender, EventArgs e)
        {
            buttonOrder.ForeColor = Color.White;
        }

        private void buttonOrder_MouseLeave(object sender, EventArgs e)
        {
            buttonOrder.ForeColor = Color.Wheat;
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {

            SidePanel.Height = buttonProducts.Height;
            SidePanel.Top = buttonProducts.Top;
            openChildForm(new Products());
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonCustomers.Height;
            SidePanel.Top = buttonCustomers.Top;
            openChildForm(new Customers());
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonInvoice.Height;
            SidePanel.Top = buttonInvoice.Top;
            openChildForm(new Invoice());
        }



        private void buttonProducts_MouseHover(object sender, EventArgs e)
        {
            buttonProducts.ForeColor = Color.White;
        }

        private void buttonProducts_MouseLeave(object sender, EventArgs e)
        {
            buttonProducts.ForeColor = Color.Wheat;
        }

        private void buttonCustomers_MouseHover(object sender, EventArgs e)
        {
            buttonCustomers.ForeColor = Color.White;
        }

        private void buttonCustomers_MouseLeave(object sender, EventArgs e)
        {
            buttonCustomers.ForeColor = Color.Wheat;
        }

        private void buttonInvoice_MouseHover(object sender, EventArgs e)
        {
            buttonInvoice.ForeColor = Color.White;
        }

        private void buttonInvoice_MouseLeave(object sender, EventArgs e)
        {
            buttonInvoice.ForeColor = Color.Wheat;
        }

        private void buttonReports_MouseHover(object sender, EventArgs e)
        {
            buttonReports.ForeColor = Color.White;
        }

        private void buttonReports_MouseLeave(object sender, EventArgs e)
        {
            buttonReports.ForeColor = Color.Wheat;
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonReprots_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonReports.Height;
            SidePanel.Top = buttonReports.Top;
            openChildForm(new Reports());
        }

        private void orderUc1_Load(object sender, EventArgs e)
        {

        }

        private void panelChildform_Paint(object sender, PaintEventArgs e)
        {

        }
        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            
            childForm.BringToFront();
            childForm.Show();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            welcome.forminstance.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ans;
            ans = MessageBox.Show("Do you want to log out ?", "vision center", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(ans == DialogResult.OK)
            {
                this.Dispose();
                //Form1.forminstance.Hide();

                welcome.forminstance.Show();
            }

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult ans;
            ans = MessageBox.Show("Do you want to change password ?", "vision center", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ans == DialogResult.OK)
            {
                //this.Dispose();
                //Form1.forminstance.Hide();
                Form formBackground = new Form();
                try
                {
                    using (edit_user uu = new edit_user(value1,$"f"))
                    {
                        formBackground.StartPosition = FormStartPosition.Manual;
                        formBackground.FormBorderStyle = FormBorderStyle.None;
                        formBackground.Opacity = .50d;
                        formBackground.BackColor = Color.Black;
                        formBackground.WindowState = FormWindowState.Maximized;
                        formBackground.TopMost = true;
                        formBackground.Location = this.Location;
                        formBackground.ShowInTaskbar = false;
                        formBackground.Show();

                        uu.Owner = formBackground;
                        uu.ShowDialog();

                        formBackground.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    formBackground.Dispose();
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult ans;
            ans = MessageBox.Show("Do you want to give access to other users ?", "vision center", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ans == DialogResult.OK)
            {
                //this.Dispose();
                //Form1.forminstance.Hide();
                Form formBackground = new Form();
                try
                {
                    using (edit_user uu = new edit_user(value1, $"s"))
                    {
                        formBackground.StartPosition = FormStartPosition.Manual;
                        formBackground.FormBorderStyle = FormBorderStyle.None;
                        formBackground.Opacity = .50d;
                        formBackground.BackColor = Color.Black;
                        formBackground.WindowState = FormWindowState.Maximized;
                        formBackground.TopMost = true;
                        formBackground.Location = this.Location;
                        formBackground.ShowInTaskbar = false;
                        formBackground.Show();

                        uu.Owner = formBackground;
                        uu.ShowDialog();

                        formBackground.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    formBackground.Dispose();
                }
            }
        }
    }
}

