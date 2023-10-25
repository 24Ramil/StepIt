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

    public partial class ForgotPassword : Window
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmailTextBox.Text == "" || LoginTextBox.Text == "")
            {
                MessageBox.Show("NE PUSHU!\nZapolni vso potom najimay");
                return;
            }
            Smtp_Client.SendPassword(EmailTextBox.Text, LoginTextBox.Text);
            MessageBox.Show("Parol otpravlen");
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
