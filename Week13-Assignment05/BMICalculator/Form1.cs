using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Add namespace
using System.Threading;

namespace BMICalculator
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();

            Thread.Sleep(3000);

            InitializeComponent();

            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new Splash());
        }

        private void imperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            heightDisplayLabel.Text = "INCHES";
            wightDisplayLabel.Text = "POUNDS";
        }

        private void metricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            heightDisplayLabel.Text = "CM";
            wightDisplayLabel.Text = "KG";
        }

        public double ImperialBMIScaleCalculator()
        {
            double BMIScale = ((double)weightNumericUpDown.Value * 703) / Math.Pow((double)heightNumericUpDown.Value, 2);

            return BMIScale;
        }

        public double MetricBMIScaleCalculator()
        {
            double BMIScale = (double)weightNumericUpDown.Value / Math.Pow((double)heightNumericUpDown.Value, 2);

            return BMIScale;
        }

        private void BMIButton_Click(object sender, EventArgs e)
        {
            if(imperialRadioButton.Checked)
            {
                if(ImperialBMIScaleCalculator() < 18.5)
                {
                    ResultTextBox.Text = $"You are UNERWEIGHT! BMI is {ImperialBMIScaleCalculator():F2}";
                }
                else if(ImperialBMIScaleCalculator() >= 18.5 && ImperialBMIScaleCalculator() < 25)
                {
                    ResultTextBox.Text = $"You are NORMAL! BMI is {ImperialBMIScaleCalculator():F2}";
                }
                else if (ImperialBMIScaleCalculator() >= 25 && ImperialBMIScaleCalculator() < 30)
                {
                    ResultTextBox.Text = $"You are OVERWEIGHT! BMI is {ImperialBMIScaleCalculator():F2}";
                }
                else if (ImperialBMIScaleCalculator() >= 30)
                {
                    ResultTextBox.Text = $"You are OBESE! BMI is {ImperialBMIScaleCalculator():F2}";
                }
            }
            else if(metricRadioButton.Checked)
            {
                if (MetricBMIScaleCalculator() < 18.5)
                {
                    ResultTextBox.Text = $"You are UNERWEIGHT! BMI is {MetricBMIScaleCalculator():F2}";
                }
                else if (MetricBMIScaleCalculator() >= 18.5 && ImperialBMIScaleCalculator() < 25)
                {
                    ResultTextBox.Text = $"You are NORMAL! BMI is {MetricBMIScaleCalculator():F2}";
                }
                else if (MetricBMIScaleCalculator() >= 25 && ImperialBMIScaleCalculator() < 30)
                {
                    ResultTextBox.Text = $"You are OVERWEIGHT! BMI is {MetricBMIScaleCalculator():F2}";
                }
                else if (MetricBMIScaleCalculator() >= 30)
                {
                    ResultTextBox.Text = $"You are OBESE! BMI is {MetricBMIScaleCalculator():F2}";
                }
            }
        }
    }
}
