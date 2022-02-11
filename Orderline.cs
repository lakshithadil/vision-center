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
    public partial class Orderline : Form
    {
        public Orderline(string value)
        {
            InitializeComponent();
            this.value = value;
            button2.Enabled = false;
            button3.Enabled = false;
            label9.Text = "0";
            oRDERLINEBindingNavigator.Visible = false;
        }

        private void oRDERLINEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oRDERLINEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visionCenterDataSet);

        }
        public string value { get; set; }
        private void Orderline_Load(object sender, EventArgs e)
        {
            
           
           
            // TODO: This line of code loads data into the 'visionCenterDataSet.ORDERLINE' table. You can move, or remove it, as needed.
            //this.oRDERLINETableAdapter.Fill(this.visionCenterDataSet.ORDERLINE);
            oRDERLINEBindingSource.AddNew();
            oIDMaskedTextBox.Text = value;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void oRDERLINEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.oRDERLINEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visionCenterDataSet);

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pIDMaskedTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                
                if (pIDMaskedTextBox.TextLength >= 2)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.VisionCenterConnectionString))
                    {
                        connection.Open();
                        SqlCommand cmd;
                        SqlDataReader dataReader;
                       
                        string sql = $"SELECT * FROM  [PRODUCT] WHERE PID = '{pIDMaskedTextBox.Text}'";
                        cmd = new SqlCommand(sql, connection);
                        dataReader = cmd.ExecuteReader();
                        dataReader.Read();

                        label1.Text = $"{dataReader.GetValue(0)}";
                        label2.Text = $"{dataReader.GetValue(1)}";
                        label3.Text = $"{dataReader.GetValue(2)}";
                        label4.Text = $"{dataReader.GetValue(3)}";
                        label5.Text = $"{dataReader.GetValue(4)}";
                        label6.Text = $"{dataReader.GetValue(5)}";

                        connection.Close();

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("invalid product id");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = "0";
            oRDERLINEBindingSource.AddNew();
            oIDMaskedTextBox.Text = value;
            button1.Enabled = true;
            button2.Enabled = false;
            oIDMaskedTextBox.ReadOnly = false;
            pIDMaskedTextBox.ReadOnly = false;
            used_forComboBox1.Enabled = true;
            quantityTextBox1.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.VisionCenterConnectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string sql = $"UPDATE [PRODUCT] SET [QtyInStock] =  ({label5.Text} - {quantityTextBox1.Text}) WHERE PID = '{pIDMaskedTextBox.Text}' ";
                    adapter.InsertCommand = new SqlCommand(sql, connection);
                    adapter.InsertCommand.ExecuteNonQuery();
                    connection.Close();

                }

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.VisionCenterConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd;
                    SqlDataReader dataReader;
                    
                    string sql = $"SELECT * FROM  [PRODUCT] WHERE PID = '{pIDMaskedTextBox.Text}'";
                    cmd = new SqlCommand(sql, connection);
                    dataReader = cmd.ExecuteReader();
                    dataReader.Read();

                    label5.Text = $"{dataReader.GetValue(4)}";


                    connection.Close();

                }
                oRDERLINEBindingNavigatorSaveItem.PerformClick();
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.VisionCenterConnectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string sql = $"UPDATE [ORDERLINE] SET [Sub total] =  ({label4.Text} * {quantityTextBox1.Text}) WHERE OID = '{oIDMaskedTextBox.Text}' AND PID ='{pIDMaskedTextBox.Text}'  ";
                    adapter.InsertCommand = new SqlCommand(sql, connection);
                    adapter.InsertCommand.ExecuteNonQuery();
                    connection.Close();

                }
                oRDERLINEBindingNavigatorSaveItem.PerformClick();
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.VisionCenterConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd;
                    SqlDataReader dataReader;

                    string sql = $"SELECT [Sub total] FROM  [ORDERLINE] WHERE OID = '{oIDMaskedTextBox.Text}' AND PID ='{pIDMaskedTextBox.Text}'";
                    cmd = new SqlCommand(sql, connection);
                    dataReader = cmd.ExecuteReader();
                    dataReader.Read();

                    label9.Text = $"{dataReader.GetValue(0)}";


                    connection.Close();

                }
                button2.Enabled = true;
                button3.Enabled = true;
                button1.Enabled = false;
                oIDMaskedTextBox.ReadOnly = true;
                pIDMaskedTextBox.ReadOnly = true;
                used_forComboBox1.Enabled = false;
                quantityTextBox1.ReadOnly = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // oRDERLINEBindingSource.CancelEdit();
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            oRDERLINEBindingNavigatorSaveItem.PerformClick();
            openChildForm(new Transaction(oIDMaskedTextBox.Text));
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void unit_priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void qtyInStockLabel_Click(object sender, EventArgs e)
        {

        }

        private void date_fromLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
