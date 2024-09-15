namespace Bai3_MayTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number1 = 0;
        double number2 = 0;
        String currentOperator = "";

        private void btn7_Click(object sender, EventArgs e)
        {

            txtInput.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtInput.Text += btn8.Text;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtInput.Text += btn9.Text;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtInput.Text += btn4.Text;

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtInput.Text += btn5.Text;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtInput.Text += btn6.Text;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtInput.Text += btn1.Text;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtInput.Text += btn2.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtInput.Text += btn3.Text;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtInput.Text += btn0.Text;

        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            txtInput.Text = (-double.Parse(txtInput.Text)).ToString();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtInput.Text += btnDot.Text;
        }


        private void calculate(string operator_name)
        {
            switch (operator_name)
            {
                case "+":
                    currentOperator = "+";
                    if (number1 != 0)
                    {
                        number2 = double.Parse(txtInput.Text);
                        txtInput.Text = (number1 + number2).ToString();
                        number1 = 0;
                        number2 = 0;
                    }
                    else
                    {
                        number1 = double.Parse(txtInput.Text);
                        txtInput.Clear();
                    }
                    break;
                case "-":
                    currentOperator = "-";
                    if (number1 != 0)
                    {
                        number2 = double.Parse(txtInput.Text);
                        txtInput.Text = (number1 - number2).ToString();
                        number1 = 0;
                        number2 = 0;
                    }
                    else
                    {
                        number1 = double.Parse(txtInput.Text);
                        txtInput.Clear();
                    }
                    break;
                case "*":
                    currentOperator = "*";
                    if (number1 != 0)
                    {
                        number2 = double.Parse(txtInput.Text);
                        txtInput.Text = (number1 * number2).ToString();
                        number1 = 0;
                        number2 = 0;
                    }
                    else
                    {
                        number1 = double.Parse(txtInput.Text);
                        txtInput.Clear();
                    }
                    break;
                 case "/":
                    currentOperator = "/";
                    if (number1 != 0)
                    {
                        if(number2 == 0)
                        {
                            txtInput.Text = (number1 / number2).ToString();
                            number1 = 0;
                            number2 = 0;
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero");
                            txtInput.Clear();
                        }
                    }
                    else
                    {
                        number1 = double.Parse(txtInput.Text);
                        txtInput.Clear();
                    }
                    break;
                default:
                    MessageBox.Show("Siuuuu");
                    break;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            calculate("+");

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            calculate("-");

        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            calculate("*");

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calculate("/");

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            calculate(currentOperator);
        }

        
    }
}
