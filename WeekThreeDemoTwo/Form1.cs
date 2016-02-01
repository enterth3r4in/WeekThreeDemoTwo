using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekThreeDemoTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrderSummary_Click(object sender, EventArgs e)
        {
            try
            {
                int customerID = int.Parse(tbCustomerID.Text);
                string customerFirstName = tbCustomerFirstName.Text;
                string customerLastName = tbCustomerLastName.Text;

                string productDescription = tbProductDescription.Text;
                int productQuantity = int.Parse(tbProductQuantity.Text);
                double productWeight = double.Parse(tbProductWeight.Text);
                decimal productPrice = decimal.Parse(tbProductPrice.Text);

                decimal approximatePrice = productQuantity * productPrice;
                decimal totalWeight = productQuantity * (decimal)productWeight;
                decimal shippingCost = totalWeight * 0.89m;
                decimal totalPrice = (approximatePrice + shippingCost) * 1.0675m;

                tbOrderSummary.Text = "Customer Information: " + customerID.ToString() + " " + customerLastName + ", " + customerFirstName + "\r\n";
                tbOrderSummary.Text += "\r\nProduct Order Information: " + "\r\nProduct Description: " + productDescription + "\r\nQuantity: " + productQuantity.ToString() + "\r\nProduct Weight: " +
                    productWeight.ToString() + " lbs." +  "\r\nProduct Price: " + productPrice.ToString("c");
                tbOrderSummary.Text += "\r\n\r\nApproximate Order Price: " + approximatePrice.ToString("c") + "\r\nTotal Order Weight: " + totalWeight + " lbs." + 
                    "\r\nShipping Cost (0.89 cents per lb): " + shippingCost.ToString("c") + "\r\nFinal Price of Order: " + totalPrice.ToString("c");
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using the program!");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbCustomerID.Clear();
            tbCustomerFirstName.Clear();
            tbCustomerLastName.Clear();
            tbProductDescription.Clear();
            tbProductQuantity.Clear();
            tbProductWeight.Clear();
            tbProductPrice.Clear();
            tbOrderSummary.Clear();
        }
    }
}
