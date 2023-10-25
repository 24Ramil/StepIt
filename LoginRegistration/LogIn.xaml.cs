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
using System.Windows.Shapes;

namespace Login_Registration.Wpf
{
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (L_LoginTextBox.Text.Trim() == "" || L_PasswordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("NE PUSHU!\nZapolni vso potom najimay");
                return;
            }
            bool foundUser = JsonUser.JsonDesirialization(L_LoginTextBox.Text.Trim(), L_PasswordTextBox.Text.Trim());
            if (foundUser) 
            {
                //L_LoginTextBox.Focus();
                MessageBox.Show("Takoy user esty\nTi krasavchik!");
                L_LoginTextBox.Text = "";
                L_PasswordTextBox.Text = "";
            }
            else 
                MessageBox.Show("Slish! TI KTO?\nUydi otsyuda");

        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void Button_Forgout_Password_Click(object sender, RoutedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Close();
        }

    }
}
