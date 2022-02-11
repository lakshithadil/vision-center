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
    public partial class Transaction : Form
    {
        public Transaction(string value)
        {
            InitializeComponent();
            this.value = value;
            tRANSACTIONBindingNavigator.Visible = false;
        }
        public string value { get; set; }
        private void tRANSACTIONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tRANSACTIONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visionCenterDataSet);

        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            tRANSACTIONBindingSource.AddNew();
            oIDMaskedTextBox.Text = value;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.VisionCenterConnectionString))
            {
                connection.Open();
                SqlCommand cmd;
                SqlDataReader dataReader;
                string output = " ";
                string sql = $"SELECT SUM([Sub total]) FROM [ORDERLINE] WHERE OID = '{oIDMaskedTextBox.Text}'";
                cmd = new SqlCommand(sql, connection);
                dataReader = cmd.ExecuteReader();
                dataReader.Read();

                full_AmountTextBox.Text = $"{dataReader.GetValue(0)}";
                

                connection.Close();

            }

        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (discountTextBox.TextLength >= 1)
            {
                double ans;
                ans = Convert.ToDouble(full_AmountTextBox.Text) - (Convert.ToDouble(full_AmountTextBox.Text) * (Convert.ToDouble(discountTextBox.Text)) / 100);
                after_discount_balanceTextBox.Text= $"{ans}";
                
            }
            
        }

        private void paymentTextBox_TextChanged(object sender, EventArgs e)
        {
           if (paymentTextBox.TextLength >= 1)
            {
                //tRANSACTIONBindingNavigatorSaveItem.PerformClick();
                double bln;
                bln = Convert.ToDouble(after_discount_balanceTextBox.Text) - Convert.ToDouble(paymentTextBox.Text);
                balanceTextBox.Text = $"{bln}";
            }
        }

        private void after_discountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tRANSACTIONBindingNavigatorSaveItem.PerformClick();
            Customer.forminstance.Close();
            MessageBox.Show("successfully placed the order,This is your invoice");

            finalinvoice finalinvoice = new finalinvoice(tIDMaskedTextBox.Text);
            finalinvoice.Show();

        }
    }
}
