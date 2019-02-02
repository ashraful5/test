using System;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class CoffeeShopUi : Form
    {
        public CoffeeShopUi()
        {
            InitializeComponent();
        }
        int totalPrice;
        private void saveButton_Click(object sender, EventArgs e)
        {
            string customerName = customerNameTextBox.Text;
            string contactNumber = contactNumberTextBox.Text;
            string address = addressTextBox.Text;
            string orderName = orderComboBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);

            if (orderComboBox.Text == "")
            {
                MessageBox.Show("Please Select an Order!");
                return;
            }
            else if (orderComboBox.Text == "Black")
            {
                // Pice of Black Coffee is 120 BDT
                totalPrice = quantity*120;
            }
            else if (orderComboBox.Text == "Cold")
            {
                // Pice of Cold Coffee is 100 BDT
                totalPrice = quantity * 100;
            }
            else if (orderComboBox.Text == "Hot")
            {
                // Pice of Hot Coffee is 90 BDT
                totalPrice = quantity * 90;
            }
            else if (orderComboBox.Text == "Regular")
            {
                // Pice of Regular Coffee is 80 BDT
                totalPrice = quantity * 80;
            }

            purchaseInfoRichTextBox.Text = "****  Purchase Information  ****" + "\n\n"
                + "Name: " + customerNameTextBox.Text + "\n" + "Contact No: " + contactNumberTextBox.Text
                + "\n" + "Address: " + addressTextBox.Text + "\n" + "Order: " + orderComboBox.Text + "\n"
                + "Quantity: " + quantityTextBox.Text + "\n\n" + "**** Total Price ****" + "\n" + totalPrice;
        }
    }
}
