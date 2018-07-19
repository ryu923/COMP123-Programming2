using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxRadioButtonForm
{
    public partial class CheckBoxRadioButtonForm : Form
    {
        public CheckBoxRadioButtonForm()
        {
            InitializeComponent();
        }

        double price = 12.00;
        double TOPPING_PRICE = 1.25;

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            double price = 12.00;
            double TOPPING_PRICE = 1.25;

            if (checkBox4.Checked)
                price += TOPPING_PRICE;
            else
                price -= TOPPING_PRICE;

            outputLabel.Text = "Total is " + price.ToString("C");
        }

        private void deliverRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            const double DELIVERY_CHARGE = 2.00;

            if (deliverRadioButton.Checked)
                price += DELIVERY_CHARGE;
            else
                price -= DELIVERY_CHARGE;

            outputLabel.Text = "Total is " + price.ToString("C");
        }
    }
}
