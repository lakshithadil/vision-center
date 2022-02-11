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
    public partial class edit_user : Form
    {   
        public edit_user(string username,string set)
        {
            InitializeComponent();
            this.username = username;
            this.set = set;
            userBindingNavigator.Visible = false;
            roleComboBox.Enabled = false;
            passwordTextBox.PasswordChar = '*';
        }
        public string username { get; set; }
        public string set { get; set; }
        

        private void edit_user_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visionCenterDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.visionCenterDataSet.user);
            // TODO: This line of code loads data into the 'visionCenterDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.visionCenterDataSet.user);
            // TODO: This line of code loads data into the 'visionCenterDataSet.user' table. You can move, or remove it, as needed.
            // this.userTableAdapter.Fill(this.visionCenterDataSet.user);
            if (set == "s")
            {
               // userBindingSource.AddNew();
                user_nameTextBox.ReadOnly = false;
                roleComboBox.Enabled = true;
                userBindingNavigator.Visible = true;
            }
            else
            {
                this.Text = "Change password";
                this.userTableAdapter.Fill(this.visionCenterDataSet.user);
                int index;
                index = userBindingSource.Find("user name", username);
                userBindingSource.Position = index;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userBindingNavigatorSaveItem.PerformClick();
            MessageBox.Show("      successfull");
            this.Close();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visionCenterDataSet);

        }
        int state = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (state == 0)
            {
                button3.Image = (Properties.Resources.icons8_eye_32px);
                passwordTextBox.PasswordChar = default;
                state = 1;
            }
            else if (state == 1)
            {
                state = 0;
                passwordTextBox.PasswordChar = '*';
                button3.Image = (Properties.Resources.icons8_hide_32px);
            }
        }
    }
}
