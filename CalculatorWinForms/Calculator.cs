using System;
using System.Globalization;
using System.Windows.Forms;

namespace CalculatorWinForms
{
    public partial class Calculator : Form
    {
        decimal value1, value2;
        char operation = ' ';

        public Calculator()
        {
            InitializeComponent();
            ConfigBtn();
        }

        private void ConfigBtn()
        {
            btn0.Click += SetBtnText;
            btn1.Click += SetBtnText;
            btn2.Click += SetBtnText;
            btn3.Click += SetBtnText;
            btn4.Click += SetBtnText;
            btn5.Click += SetBtnText;
            btn6.Click += SetBtnText;
            btn7.Click += SetBtnText;
            btn8.Click += SetBtnText;
            btn9.Click += SetBtnText;
            btnPoint.Click += SetBtnText;

            btnAddition.Click += RecordOperation;
            btnSubtraction.Click += RecordOperation;
            btnDivision.Click += RecordOperation;
            btnMultiplication.Click += RecordOperation;

            btnEquals.Click += PerformeCalculation;
            btnCH.Click += ClearHistory;
            btnCE.Click += ClearEntries;
        }

        private void SetBtnText(object sender, EventArgs e)
        {
            Button btnClick = sender as Button;

            txtNumbers.Text += btnClick.Text;
        }

        private void RecordOperation(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumbers.Text))
                return;

            value1 = decimal.Parse(txtNumbers.Text, CultureInfo.InvariantCulture);

            Button btnClick = sender as Button;

            operation = btnClick.Text[0];

            txtOperation.Text = txtNumbers.Text + " " + btnClick.Text;

            txtNumbers.Text = "";
        }
        
        private void PerformeCalculation(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumbers.Text))
                 return;

            value2 = decimal.Parse(txtNumbers.Text, CultureInfo.InvariantCulture);

            Calculate();

            txtNumbers.Text = "";

        }

        private void Calculate()
        {
            string result = "";

            if (txtNumbers.Text != "")
            {
                if (operation == '/' && value2 == 0)
                {
                    MessageBox.Show("      There's no division by 0!");
                    return;
                }

                switch (operation)
                {
                    case '+': result = txtOperation.Text = Convert.ToString(value1 + value2); break;
                    case '-': result = txtOperation.Text = Convert.ToString(value1 - value2); break;
                    case 'x': result = txtOperation.Text = Convert.ToString(value1 * value2); break;
                    case '/': result = txtOperation.Text = Convert.ToString(value1 / value2); break;
                }
                
                listHistory.Items.Add($"{value1} {operation} {value2} = {result}");
            }
        }

        private void ClearEntries(object sender, EventArgs e)
        {
            txtOperation.Text = "";
            txtNumbers.Text = "";
            value1 = 0;
            value2 = 0;
        }

        private void ClearHistory(object sender, EventArgs e)
        {
            listHistory.Items.Clear();
        }
    }
}
