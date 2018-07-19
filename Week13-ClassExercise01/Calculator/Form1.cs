using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeCalLabel.Text = "Standard Calculator";
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeCalLabel.Text = "Scientific Calculator";
        }

        private void programmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeCalLabel.Text = "Programmer Calculator";
        }

        private void ZeroLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
