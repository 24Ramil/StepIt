using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Clicers numbers and operators
        
        private void zero_Click(object sender, EventArgs e)
        {
            solution.Text += zero.Text;
        }
        private void one_Click(object sender, EventArgs e)
        {
            solution.Text += one.Text;
        }
        private void two_Click(object sender, EventArgs e)
        {
            solution.Text += two.Text;
        }
        private void three_Click(object sender, EventArgs e)
        {
            solution.Text += three.Text;
        }
        private void four_Click(object sender, EventArgs e)
        {
            solution.Text += four.Text;
        }
        private void five_Click(object sender, EventArgs e)
        {
            solution.Text += five.Text;
        }
        private void six_Click(object sender, EventArgs e)
        {
            solution.Text += six.Text;
        }
        private void seven_Click(object sender, EventArgs e)
        {
            solution.Text += seven.Text;
        }
        private void eight_Click(object sender, EventArgs e)
        {
            solution.Text += eight.Text;
        }
        private void nine_Click(object sender, EventArgs e)
        {
            solution.Text += nine.Text;
        }
        private void plus_Click(object sender, EventArgs e)
        {
            solution.Text += plus.Text;
        }
        private void minus_Click(object sender, EventArgs e)
        {
            solution.Text += minus.Text;
        }
        private void multiply_Click(object sender, EventArgs e)
        {
            solution.Text += multiply.Text;
        }
        private void divide_Click(object sender, EventArgs e)
        {
            solution.Text += divide.Text;
        }
        private void factorial_Click(object sender, EventArgs e)
        {
            solution.Text += factorial.Text;
        }
        private void degree_Click(object sender, EventArgs e)
        {
            solution.Text += degree.Text;
        }
        private void symbolDot_Click(object sender, EventArgs e)
        {
            if (solution.Text.Length == 0)
                solution.Text += "0.";

            else if ((solution.Text.Contains(".")))
                solution.Text = solution.Text;

            else if (solution.Text.Length != 0)
                solution.Text += ".";
        }


        private void delete_Click(object sender, EventArgs e)
        {
            solution.Text = solution.Text.Remove(solution.Text.Length - 1);
        }
        private void deleteAll_Click(object sender, EventArgs e)
        {
            solution.Text = "";
        }
        private void egual_Click(object sender, EventArgs e)
        {
            solution.Text = Solution(solution.Text).ToString();
        }

        private static double Solution(string expression)
        {

            Queue<string> outputQueue = new Queue<string>();
            Stack<string> operatorStack = new Stack<string>();

            Dictionary<string, int> precedence = new Dictionary<string, int>
            {
                { "+", 1 },
                { "-", 1 },
                { "*", 2 },
                { "/", 2 },
                { "%", 3 },
                { "^", 3 }
            };

            string currentToken = "";

            for (int i = 0; i < expression.Length; i++)
            {
                char currentChar = expression[i];

                if (Char.IsDigit(currentChar))
                {
                    currentToken += currentChar;
                }
                else
                {
                    if (!string.IsNullOrEmpty(currentToken))
                    {
                        outputQueue.Enqueue(currentToken);
                        currentToken = "";
                    }

                    if (currentChar == '(')
                    {
                        operatorStack.Push(currentChar.ToString());
                    }
                    else if (currentChar == ')')
                    {
                        while (operatorStack.Count > 0 && operatorStack.Peek() != "(")
                        {
                            outputQueue.Enqueue(operatorStack.Pop());
                        }
                        operatorStack.Pop();
                    }
                    else if (precedence.ContainsKey(currentChar.ToString()))
                    {
                        while (operatorStack.Count > 0 && precedence.ContainsKey(operatorStack.Peek()) &&
                               precedence[operatorStack.Peek()] >= precedence[currentChar.ToString()])
                        {
                            outputQueue.Enqueue(operatorStack.Pop());
                        }
                        operatorStack.Push(currentChar.ToString());
                    }
                }
            }

            if (!string.IsNullOrEmpty(currentToken))
            {
                outputQueue.Enqueue(currentToken);
            }

            while (operatorStack.Count > 0)
            {
                outputQueue.Enqueue(operatorStack.Pop());
            }

            Stack<double> resultStack = new Stack<double>();

            foreach (string token in outputQueue)
            {
                if (double.TryParse(token, out double number))
                {
                    resultStack.Push(number);
                }
                else if (precedence.ContainsKey(token))
                {
                    double operand2 = resultStack.Pop();
                    double operand1 = resultStack.Pop();
                    double result = Operation(token, operand1, operand2);
                    resultStack.Push(result);
                }
            }

            double finalResult = resultStack.Pop();
            return finalResult;
        }

        private static double Operation(string operatorToken, double operand1, double operand2)
        {
            switch (operatorToken)
            {
                case "+":
                    return PlusMethod(operand1, operand2);

                case "-":
                    return MinusMethod(operand1, operand2);

                case "*":
                    return MultiplyMethod(operand1, operand2);

                case "/":
                    return DivedeMethod(operand1, operand2);

                case "%":
                    return ProcentMethod(operand1, operand2);

                case "^":
                    return DegreeMethod(operand1, operand2);

                default: return 1;
            }
        }


        //Methods operators
        public static double PlusMethod(double value1, double value2)
        {
            return (value1 + value2);
        }
        public static double MinusMethod(double value1, double value2)
        {
            return (value1 - value2);
        }
        public static double MultiplyMethod(double value1, double value2)
        {
            return (value1 * value2);
        }
        public static double DivedeMethod(double value1, double value2)
        {
            return (value1 / value2);
        }
        public static double DegreeMethod(double value1, double value2)
        {
            double result = 1;
            while (value2 > 0)
            {
                result *= value1;
                value2--;
            }
            return result;
        }

        // Она находит процент от числа(пример 10% от 100 => 10)
        public static double ProcentMethod(double value1, double value2)
        {
            return (value2 * value1) / 100;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }
}
