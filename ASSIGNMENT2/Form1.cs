using ASSIGNMENT2;
using System.Windows.Forms;
using static ASSIGNMENT2.Form1;

namespace ASSIGNMENT2
{
    public partial class Form1 : Form
    {
        public List<Invoice> invoices = new List<Invoice>();

        // Declare a constant VAT rate of 10%
        public
        const decimal VAT = 0.1m;
        public Form1()
        {
            InitializeComponent();
        }

        // Load the form and populate the combo box with customer types
        private void Form1_Load(object sender, EventArgs e)
        {
            cboTypeOfCustomer.Items.Add("Household customer");
            cboTypeOfCustomer.Items.Add("Administration agency , public services");
            cboTypeOfCustomer.Items.Add("Production units");
            cboTypeOfCustomer.Items.Add("Business services");
            cboTypeOfCustomer.SelectedIndex = 0;

            // Set the view of the list view to details
            lvInvoice.View = View.Details;
            // Add columns to the list view
            lvInvoice.Columns.Add("Customer Name", 150);
            lvInvoice.Columns.Add("Last Month Water Meter", 100);
            lvInvoice.Columns.Add("This Month Water Meter", 100);
            lvInvoice.Columns.Add("Amount Of Water Usage", 100);
            lvInvoice.Columns.Add("Total Water Bill", 100);
            // Set the view of the list view to details
            lvInvoice.View = View.Details;
            // Enable grid lines
            lvInvoice.GridLines = true;
            // Enable full row select
            lvInvoice.FullRowSelect = true;

        }
        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptnCalculator_Click(object sender, EventArgs e)
        {

            // Get the customer name from the text box
            string customerName = txtCustomerName.Text.Trim();
            // Get the customer type from the combo box
            string customerType = cboTypeOfCustomer.Text;
            // Initialize the number of people to 0
            int numberOfPeople = 0;
            // Initialize the last month water to 0
            decimal lastMonthWater = 0;
            // Initialize the this month water to 0
            decimal thisMonthWater = 0;
            // Check if the customer name is empty
            if (string.IsNullOrEmpty(customerName))
            {
                // Show an error message if the customer name is empty
                MessageBox.Show("Please enter customer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the customer type is empty
            if (string.IsNullOrEmpty(customerType))
            {
                // Show an error message if the customer type is empty
                MessageBox.Show("Please select type of customer .", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if the customer type is "Household customer"
            if (customerType.Equals("Household customer"))
            {
                // Check if the number of people is a positive integer
                if (!int.TryParse(txtNumberOfPeople.Text, out numberOfPeople) || numberOfPeople <= 0)
                {
                    // Show an error message if the number of people is not a positive integer
                    MessageBox.Show("Number of members be a positve interger for Household customers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // Check if the last month water is a positive number
            if (!decimal.TryParse(txtLastMonthWater.Text, out lastMonthWater) || lastMonthWater <= 0)
            {
                // Show an error message if the last month water is not a positive number
                MessageBox.Show("Last month water meter should be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if the this month water is a positive number
            if (!decimal.TryParse(txtThisMonthWater.Text, out thisMonthWater) || thisMonthWater <= 0)
            {
                // Show an error message if the this month water is not a positive number
                MessageBox.Show("This month water meter should be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if the last month water is greater than the this month water
            if (lastMonthWater > thisMonthWater)
            {
                // Show an error message if the last month water is greater than the this month water
                MessageBox.Show("Please enter the correct amount of water used.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate the water bill
            var invoice = CalculateWaterBill(lastMonthWater, thisMonthWater, customerType, numberOfPeople);
            // Create a new list view item
            ListViewItem item = new ListViewItem(customerName);
            // Add the last month water to the list view item
            item.SubItems.Add(lastMonthWater.ToString());
            // Add the this month water to the list view item
            item.SubItems.Add(thisMonthWater.ToString());
            // Add the water usage to the list view item
            item.SubItems.Add(invoice.Item1.ToString());
            // Add the total cost to the list view item
            item.SubItems.Add(invoice.Item2.ToString());
            // Add the list view item to the list view
            lvInvoice.Items.Add(item);


            // Create a new invoice
            Invoice invoice1 = new Invoice
            {
                // Set the customer name
                CUSTOMERNAME = customerName,
                // Set the customer type
                CUSTOMERTYPE = customerType,
                // Set the last month water
                LASTMONTHWATER = lastMonthWater,
                // Set the this month water
                THISMONTHWATER = thisMonthWater,
                // Set the water usage
                WATERUSAGE = invoice.Item1,
                // Set the total cost
                TOTALCOST = invoice.Item2,
            };
            // Add the invoice to the list of invoices
            invoices.Add(invoice1);
        }
        //This method calculates the water bill for a customer based on their type and the amount of water used
        private (decimal, decimal) CalculateWaterBill(decimal lastMonthWater, decimal thisMonthWater, string customerType, int numberOfPeople)
        {
            //Initialize the total cost to 0
            decimal totalCost = 0;
            //Calculate the water usage for this month
            decimal waterUsage = thisMonthWater - lastMonthWater;
            //Check the customer type and calculate the total cost accordingly
            if (customerType.Equals("Household customer"))
            {
                //Calculate the average water used per person
                decimal averageWaterUsed = waterUsage / numberOfPeople;
                //Calculate the total cost for a household customer
                totalCost = BillWaterForHouseHold(averageWaterUsed, waterUsage);
            }
            else if (customerType.Equals("Administration agency , public services"))
            {
                //Calculate the total cost for an administration agency or public service
                totalCost = (waterUsage * 9.955m);
                totalCost += (waterUsage * VAT);
            }
            else if (customerType.Equals("Production units"))
            {
                //Calculate the total cost for a production unit
                totalCost = waterUsage * 11615;
                totalCost += (waterUsage * VAT);
            }
            else
            {
                //Calculate the total cost for any other type of customer
                totalCost = waterUsage * 22.068m;
                totalCost += (waterUsage * VAT);
            }
            //Return the water usage and total cost
            return (waterUsage, totalCost);

        }
        private decimal BillWaterForHouseHold(decimal averageWaterUsed, decimal waterUsage)
        {
            // Initialize totalCost to 0
            decimal totalCost = 0;
            // Check if averageWaterUsed is between 0 and 10
            if (0 <= averageWaterUsed && averageWaterUsed < 10)
            {
                // Calculate totalCost for waterUsage at 5973 per unit
                totalCost = waterUsage * 5973;
                // Add VAT to totalCost
                totalCost += (waterUsage * VAT);
            }
            // Check if averageWaterUsed is between 10 and 20
            else if (10 <= averageWaterUsed && averageWaterUsed < 20)
            {
                // Calculate totalCost for waterUsage at 7052 per unit
                totalCost = waterUsage * 7052;
                // Add VAT to totalCost
                totalCost += (waterUsage * VAT);
            }
            // Check if averageWaterUsed is between 20 and 30
            else if (20 <= averageWaterUsed && averageWaterUsed < 30)
            {
                // Calculate totalCost for waterUsage at 8699 per unit
                totalCost = waterUsage * 8699;
                // Add VAT to totalCost
                totalCost += (waterUsage * VAT);
            }
            // If averageWaterUsed is greater than or equal to 30
            else
            {
                // Calculate totalCost for waterUsage at 15929 per unit
                totalCost = waterUsage * 15929;
            }
            // Return totalCost plus VAT
            return (totalCost + totalCost * VAT);
        }
        private void cboTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected customer type from the combo box
            string customerType = cboTypeOfCustomer.Text;
            // If the selected customer type is "Household customer", enable the number of people text box
            if (customerType.Equals("Household customer"))
            {
                txtNumberOfPeople.Enabled = true;
            }
            // Otherwise, disable the number of people text box and clear its text
            else
            {
                txtNumberOfPeople.Enabled = false;
                txtNumberOfPeople.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Call the ClearAllTextBoxes method to clear all text boxes in the form
            ClearAllTextBoxes(this);
        }
        //This method clears all the textboxes in a control
        private void ClearAllTextBoxes(Control control)
        {
            //Loop through all the controls in the control
            foreach (Control c in control.Controls)
            {
                //If the control is a textbox, clear its text
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                //Otherwise, call the method recursively on the control
                else
                {
                    ClearAllTextBoxes(c);
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the search string from the text box
            string search = txtSearch.Text.Trim();

            // Clear the list view items
            lvInvoice.Items.Clear();
            // If the search string is empty, add all invoices to the list view
            if (string.IsNullOrEmpty(search))
            {
                foreach (var invoice in invoices)
                {
                    // Create a new list view item for each invoice
                    ListViewItem item = new ListViewItem(invoice.CUSTOMERNAME);
                    item.SubItems.Add(invoice.LASTMONTHWATER.ToString());
                    item.SubItems.Add(invoice.THISMONTHWATER.ToString());
                    item.SubItems.Add(invoice.WATERUSAGE.ToString());
                    item.SubItems.Add(invoice.TOTALCOST.ToString());
                    // Add the list view item to the list view
                    lvInvoice.Items.Add(item);
                }
            }
            // If the search string is not empty, search for invoices with the search string in the customer name
            else
            {
                bool foundResult = false;
                foreach (var invoice in invoices)
                {
                    // If the customer name contains the search string, add the invoice to the list view
                    if (!string.IsNullOrEmpty(invoice.CUSTOMERNAME) && invoice.CUSTOMERNAME.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        ListViewItem item = new ListViewItem(invoice.CUSTOMERNAME);
                        item.SubItems.Add(invoice.LASTMONTHWATER.ToString());
                        item.SubItems.Add(invoice.THISMONTHWATER.ToString());
                        item.SubItems.Add(invoice.WATERUSAGE.ToString());
                        item.SubItems.Add(invoice.TOTALCOST.ToString());
                        lvInvoice.Items.Add(item);
                        foundResult = true;
                    }
                }
                // If no invoices were found, add a message to the list view
                if (!foundResult)
                {
                    ListViewItem item = new ListViewItem("No result found!");
                    lvInvoice.Items.Add(item);
                }
            }
        }
        private void lvInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected in the list view
            if (lvInvoice.SelectedItems.Count > 0)
            {
                // Get the index of the selected item
                var bill = lvInvoice.SelectedItems[0].Index;
                // Check if the index is within the range of the invoices list
                if (bill >= 0 && bill < invoices.Count)
                {
                    // Get the invoice at the selected index
                    Invoice invoice = invoices[bill];
                    // Create a new form with the selected invoice
                    lbWaterBill form2 = new lbWaterBill(invoice);
                    // Show the form
                    form2.ShowDialog();
                }
            }
        }
        public class Invoice
        {
            //Customer name property
            public string CUSTOMERNAME
            {
                get;
                set;
            }
            //Customer type property
            public string CUSTOMERTYPE
            {
                get;
                set;
            }
            //Last month water usage property
            public decimal LASTMONTHWATER
            {
                get;
                set;
            }
            //This month water usage property
            public decimal THISMONTHWATER
            {
                get;
                set;
            }
            //Water usage property
            public decimal WATERUSAGE
            {
                get;
                set;
            }
            //Total cost property
            public decimal TOTALCOST
            {
                get;
                set;
            }

        }
        //This method is called when the btnShowMenu button is clicked
        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            //Get the button that triggered the event
            Button btnSender = (Button)sender;
            //Create a new point object with the x and y coordinates of the button's height
            Point ptLowerLeft = new Point(0, btnSender.Height);
            //Convert the point to screen coordinates
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            //Show the contextMenuStrip1 at the point
            contextMenuStrip1.Show(ptLowerLeft);
        }

        //This method is called when a key is pressed in the txtNumberOfPeople text box
        private void txtNumberOfPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If the key pressed is not a digit or the backspace key, then the event is handled
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtLastMonthWater_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastMonthWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit, a comma, or the backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                // If the pressed key is not a digit, a comma, or the backspace key, handle the event as handled
                e.Handled = true;
            }
        }

        private void txtThisMonthWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit, a comma, or the backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                // If not, handle the event to prevent the key from being entered
                e.Handled = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Create a new list to store the sorted invoices
            List<Invoice> sortedInvoices = new List<Invoice>();
            // Sort the invoices by water usage in descending order and store them in the new list
            sortedInvoices = invoices.OrderByDescending(i => i.WATERUSAGE).ToList();
            // Set the invoices list to the sorted list
            invoices = sortedInvoices;
            // Clear the items in the ListView
            lvInvoice.Items.Clear();
            // Loop through the sorted invoices and add them to the ListView
            foreach (var invoice in sortedInvoices)
            {
                // Create a new ListViewItem for each invoice
                ListViewItem item = new ListViewItem(invoice.CUSTOMERNAME);
                // Add the invoice details to the ListViewItem
                item.SubItems.Add(invoice.LASTMONTHWATER.ToString());
                item.SubItems.Add(invoice.THISMONTHWATER.ToString());
                item.SubItems.Add(invoice.WATERUSAGE.ToString());
                item.SubItems.Add(invoice.TOTALCOST.ToString());
                // Add the ListViewItem to the ListView
                lvInvoice.Items.Add(item);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Create a new list to store the sorted invoices
            List<Invoice> sortedInvoices = new List<Invoice>();
            // Sort the invoices by water usage and store them in the new list
            sortedInvoices = invoices.OrderBy(i => i.WATERUSAGE).ToList();
            // Set the invoices list to the sorted list
            invoices = sortedInvoices;
            // Clear the items in the ListView
            lvInvoice.Items.Clear();
            // Loop through the sorted invoices and add them to the ListView
            foreach (var invoice in sortedInvoices)
            {
                // Create a new ListViewItem for each invoice
                ListViewItem item = new ListViewItem(invoice.CUSTOMERNAME);
                // Add the invoice details to the ListViewItem
                item.SubItems.Add(invoice.LASTMONTHWATER.ToString());
                item.SubItems.Add(invoice.THISMONTHWATER.ToString());
                item.SubItems.Add(invoice.WATERUSAGE.ToString());
                item.SubItems.Add(invoice.TOTALCOST.ToString());
                // Add the ListViewItem to the ListView
                lvInvoice.Items.Add(item);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Create a new list to store the sorted invoices
            List<Invoice> sortedInvoices = new List<Invoice>();
            // Sort the invoices by total cost in descending order and add them to the new list
            sortedInvoices = invoices.OrderByDescending(i => i.TOTALCOST).ToList();
            // Set the invoices list to the sorted list
            invoices = sortedInvoices;
            // Clear the items in the ListView
            lvInvoice.Items.Clear();
            // Loop through the sorted invoices and add them to the ListView
            foreach (var invoice in sortedInvoices)
            {
                // Create a new ListViewItem for each invoice
                ListViewItem item = new ListViewItem(invoice.CUSTOMERNAME);
                // Add the invoice details to the ListViewItem
                item.SubItems.Add(invoice.LASTMONTHWATER.ToString());
                item.SubItems.Add(invoice.THISMONTHWATER.ToString());
                item.SubItems.Add(invoice.WATERUSAGE.ToString());
                item.SubItems.Add(invoice.TOTALCOST.ToString());
                // Add the ListViewItem to the ListView
                lvInvoice.Items.Add(item);
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            // Create a new list to store the sorted invoices
            List<Invoice> sortedInvoices = new List<Invoice>();
            // Sort the invoices by total cost and store them in the new list
            sortedInvoices = invoices.OrderBy(i => i.TOTALCOST).ToList();
            // Set the invoices list to the sorted list
            invoices = sortedInvoices;
            // Clear the items in the ListView
            lvInvoice.Items.Clear();
            // Loop through the sorted invoices and add them to the ListView
            foreach (var invoice in sortedInvoices)
            {
                ListViewItem item = new ListViewItem(invoice.CUSTOMERNAME);
                item.SubItems.Add(invoice.LASTMONTHWATER.ToString());
                item.SubItems.Add(invoice.THISMONTHWATER.ToString());
                item.SubItems.Add(invoice.WATERUSAGE.ToString());
                item.SubItems.Add(invoice.TOTALCOST.ToString());
                lvInvoice.Items.Add(item);
            }
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            lvInvoice.Items.Clear();
            foreach (var invoice in invoices)
            {
                ListViewItem item = new ListViewItem(invoice.CUSTOMERNAME);
                item.SubItems.Add(invoice.LASTMONTHWATER.ToString());
                item.SubItems.Add(invoice.THISMONTHWATER.ToString());
                item.SubItems.Add(invoice.WATERUSAGE.ToString());
                item.SubItems.Add(invoice.TOTALCOST.ToString());
                lvInvoice.Items.Add(item);
            }
            lvInvoice.Sorting = SortOrder.Ascending;
            lvInvoice.Sort();
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            lvInvoice.Items.Clear();
            foreach (var invoice in invoices)
            {
                ListViewItem item = new ListViewItem(invoice.CUSTOMERNAME);
                item.SubItems.Add(invoice.LASTMONTHWATER.ToString());
                item.SubItems.Add(invoice.THISMONTHWATER.ToString());
                item.SubItems.Add(invoice.WATERUSAGE.ToString());
                item.SubItems.Add(invoice.TOTALCOST.ToString());
                lvInvoice.Items.Add(item);
            }
            lvInvoice.Sorting = SortOrder.Descending;
            lvInvoice.Sort();
        }
    }
}
