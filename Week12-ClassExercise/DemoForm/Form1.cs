using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SayHelloButton_Click(object sender, EventArgs e)
        {
            if(InputTextBox.Text.Length > 0)
            {
                MainLabel.Text = "Hello, " + InputTextBox.Text;
            }
            else
            {
                MainLabel.Text = "Hello, world!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
