using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ASSIGNMENT2.Form1;

namespace ASSIGNMENT2
{
    public partial class lbWaterBill : Form
    {

        public lbWaterBill(Invoice invoice)
        {
            InitializeComponent();
            lbCustomerName.Text = invoice.CUSTOMERNAME ;
            lbCustomerType.Text = invoice.CUSTOMERTYPE ;
            lbLastMonth.Text =  invoice.LASTMONTHWATER.ToString() + " m³";
            lbThisMonth.Text =  invoice.THISMONTHWATER.ToString() + " m³";
            lbWaterUsage.Text =  invoice.WATERUSAGE.ToString() + " m³";
            lbTotal.Text = invoice.TOTALCOST.ToString()  + " VND";

            this.Name = "BillDetailsForm";
            this.Text = "Bill Details";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Successful.","Successful!" , MessageBoxButtons.OK, MessageBoxIcon.None);
            return;
        }
    }
}
