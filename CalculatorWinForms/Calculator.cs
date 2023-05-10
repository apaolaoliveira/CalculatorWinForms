using System;
using System.Globalization;
using System.Windows.Forms;

namespace CalculatorWinForms
{
    public partial class Calculator : Form
    {
        decimal value1, value2;
        string operation = "";

        public Calculator()
        {
            InitializeComponent();
        }
        private void button0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            txtResult.Text += ".";
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                value1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operation = "ADDITION";
                lblOperation.Text = "+";
            }
            else
            {
                MessageBox.Show("Enter a value to perform the addition!");
            }
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                value1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operation = "SUBTRACTION";
                lblOperation.Text = "-";
            }
            else
            {
                MessageBox.Show("Enter a value to perform the subtraction!");
            }
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                value1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operation = "MULTIPLICATION";
                lblOperation.Text = "x";
            }
            else
            {
                MessageBox.Show("Enter a value to perform the multiplication!");
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                value1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operation = "DIVISION";
                lblOperation.Text = "/";
            }
            else
            {
                MessageBox.Show("Enter a value to perform the division!");
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            lblOperation.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            lblOperation.Text = "";
            value1 = 0;
            value2 = 0;
            listHistory.Items.Clear();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                value2 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                lblOperation.Text = "=";
                string mathOperator = "";
                string result = "";

                if (operation == "DIVISION" && value2 == 0)
                {
                    MessageBox.Show("      There's no division by 0!");
                    return;
                }

                switch (operation)
                {
                    case "ADDITION": result = txtResult.Text = Convert.ToString(value1 + value2); mathOperator = "+"; break;
                    case "SUBTRACTION": result = txtResult.Text = Convert.ToString(value1 - value2); mathOperator = "-"; break;
                    case "MULTIPLICATION": result = txtResult.Text = Convert.ToString(value1 * value2); mathOperator = "x"; break;
                    case "DIVISION": result = txtResult.Text = Convert.ToString(value1 / value2); mathOperator = "/"; break;
                }

                listHistory.Items.Add($"{value1} {mathOperator} {value2} = {result}");
            }
            else
            {
                MessageBox.Show("Enter two values to perform the result!");
            }
        }
    }
}
