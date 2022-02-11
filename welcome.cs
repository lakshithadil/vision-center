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
    public partial class welcome : Form
    {
        public static welcome forminstance;
        public welcome()
        {
            InitializeComponent();
            Opacity = 0;
            forminstance = this;
            
        }
        
        private void login_Load(object sender, EventArgs e)

        {
            
           
           // panel1.BackColor = Color.FromArgb(i, 0, 0, 0);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(Opacity == 1)
            {
                timer1.Stop();

            }
            Opacity += .2;
        }

        private void login_Enter(object sender, EventArgs e)
        {
            
            
        }

        private void login_Click(object sender, EventArgs e)
        {
           

            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            
            openChildForm(new loginto());

        }

        private void login_MouseClick(object sender, MouseEventArgs e)
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
            childForm.Show();
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();

            childForm.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
