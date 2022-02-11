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
    public partial class editcustomer : Form
    {
        public editcustomer()
        {
            InitializeComponent();
        }

        private void cUSTOMERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTOMERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visionCenterDataSet);

        }

        private void editcustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visionCenterDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.visionCenterDataSet.CUSTOMER);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value;
            int index;
            
            value = Microsoft.VisualBasic.Interaction.InputBox("Customer ID", "Find customer");
            index = cUSTOMERBindingSource.Find("CID", value);
           
            if(index == -1)
            {
                MessageBox.Show("Customer Not Found","NOT FOUND",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                cUSTOMERBindingSource.Position = index;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cUSTOMERBindingNavigatorSaveItem.PerformClick();
            Close();
        }
    }
}
