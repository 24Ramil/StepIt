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


namespace Login_Registration.Wpf
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_LogIn_Click(object sender, RoutedEventArgs e)
        {
            LogIn secondWindow = new LogIn();
            secondWindow.Show();
            this.Close();
        }

        private void Button_Register_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LoginTextBox.Text.Trim() == "" || PasswordTextBox.Text.Trim() == "" || ConfirmPasswordTextBox.Text.Trim() == "")
                {
                    MessageBox.Show("NE PUSHU!\nZapolni vso potom najimay");
                    return;
                }
                if (PasswordTextBox.Text.Trim() != ConfirmPasswordTextBox.Text.Trim())
                {
                    MessageBox.Show("Paroli ne sovpadayut!");
                    return;
                }

                User newUser = new User(LoginTextBox.Text.Trim(), PasswordTextBox.Text.Trim(), ConfirmPasswordTextBox.Text.Trim());
                JsonUser.JsonSerialization(newUser);
                MessageBox.Show("Vsyo Ok\nKrasavchik!");
                LoginTextBox.Text = "";
                PasswordTextBox.Text = "";
                ConfirmPasswordTextBox.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
