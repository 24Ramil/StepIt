using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Moneyfy_ProjectWork.Views
{
    /// <summary>
    /// Interaction logic for IncomeView.xaml
    /// </summary>
    public partial class IncomeView : UserControl
    {
        public IncomeView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Content == "." && textBox.Text.Contains("."))
            {
                return;
            }
            textBox.Text += button.Content.ToString();
        }

        private void Button_Equals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string input = textBox.Text;
                double result = EvaluateExpression(input);

                textBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                textBox.Text = "Error";
                Console.WriteLine(ex.Message);
            }
        }
        private double EvaluateExpression(string expression)
        {
            try
            {
                System.Data.DataTable table = new System.Data.DataTable();
                return Convert.ToDouble(table.Compute(expression, string.Empty));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        private void Button_BackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }
        }

    }
}
