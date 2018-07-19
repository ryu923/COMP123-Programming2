using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalandarForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            const int DAYS_TO_ADD = 10;
            string newDate = "You selected " + monthCalendar1.SelectionStart.ToShortDateString();

            label1.Text = newDate + "\nTen days ahead is " + monthCalendar1.SelectionStart.AddDays(DAYS_TO_ADD).ToShortDateString();
        }
    }
}
