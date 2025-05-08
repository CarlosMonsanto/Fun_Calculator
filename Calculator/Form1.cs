namespace Calculator
{
    public partial class Form1 : Form
    {
        string operatorSymbol = "";
        double firstNumber = 0;
        double result = 0;
        double secondNumber = 0;
        bool isOperatorClicked = false;

        public Form1()
        {
            InitializeComponent();
            txtDisplay.Text = "0";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || isOperatorClicked)
            {
                txtDisplay.Text = "0";
                isOperatorClicked = false;
            }
            else
                txtDisplay.Text += "0"; // assuming button10 is the 0 button
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || isOperatorClicked)
            {
                txtDisplay.Text = "1";
                isOperatorClicked = false;
            }
            else
                txtDisplay.Text += "1";
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            // 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || isOperatorClicked)
            {
                txtDisplay.Text = "2";
                isOperatorClicked = false;
            }
            else
                txtDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || isOperatorClicked)
            {
                txtDisplay.Text = "3";
                isOperatorClicked = false;
            }
            else
                txtDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || isOperatorClicked)
            {
                txtDisplay.Text = "4";
                isOperatorClicked = false;
            }
            else
                txtDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || isOperatorClicked)
            {
                txtDisplay.Text = "5";
                isOperatorClicked = false;
            }
            else
                txtDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || isOperatorClicked)
            {
                txtDisplay.Text = "6";
                isOperatorClicked = false;
            }
            else
                txtDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || isOperatorClicked)
            {
                txtDisplay.Text = "7";
                isOperatorClicked = false;
            }
            else
                txtDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || isOperatorClicked)
            {
                txtDisplay.Text = "8";
                isOperatorClicked = false;
            }
            else
                txtDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || isOperatorClicked)
            {
                txtDisplay.Text = "9";
                isOperatorClicked = false;
            }
            else
                txtDisplay.Text += "9";
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            if (result == 0)
                secondNumber = double.Parse(txtDisplay.Text);
            else
            {
                firstNumber = result;
            }
            switch (operatorSymbol)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                        break;
                    }
                    else
                        txtDisplay.Text = "Divide by 0 Error";
                    return;
            }
            txtDisplay.Text = result.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operatorSymbol = "+";
            isOperatorClicked = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operatorSymbol = "-";
            isOperatorClicked = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operatorSymbol = "*";
            isOperatorClicked = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operatorSymbol = "/";
            isOperatorClicked = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
            result = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
