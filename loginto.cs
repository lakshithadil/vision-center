using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace vision_center1
{
    public partial class loginto : Form
    {
        public loginto()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
           // textBox2.PasswordChar = default;
           //this is from me 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginto_Load(object sender, EventArgs e)
        {
            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.VisionCenterConnectionString))
            {
                connection.Open();
               
                string sql = $"SELECT count(*) FROM  [user] WHERE [user name] = '{textBox1.Text}' and [role] ='{comboBox1.Text}' and [password] = '{textBox2.Text}'";
                SqlDataAdapter user = new SqlDataAdapter(sql,connection);
                DataTable dt = new DataTable();
                user.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                   
                  // welcome.forminstance.Close();
                    Form1 main = new Form1($"{comboBox1.Text}",$"{textBox1.Text}");
                    main.Show();
                    this.Close();
                    welcome.forminstance.Hide();
                }
                else
                {
                    MessageBox.Show("invalid user details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        int state = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if(state == 0) 
            {
                button3.Image = (Properties.Resources.icons8_eye_32px);
                textBox2.PasswordChar = default;
                state = 1;
            }
            else if(state == 1)
            {
                state = 0;
                textBox2.PasswordChar = '*';
                button3.Image = (Properties.Resources.icons8_hide_32px);
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.VisionCenterConnectionString))
            {
                connection.Open();

                string sql = $"SELECT count(*) FROM  [user] WHERE [user name] = '{textBox1.Text}'";
                SqlDataAdapter user = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                user.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    pictureBox1.Image = (Properties.Resources.icons8_Done_32px);

                }
                else
                {
                    pictureBox1.Image = (Properties.Resources.icons8_Close_32px);
                    
                }
                connection.Close();

            }
        }
    }
}
