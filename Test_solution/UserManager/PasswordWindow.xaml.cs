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

namespace UserManager
{
    /// <summary>
    /// Логика взаимодействия для PasswordWindow.xaml
    /// </summary>
    public partial class PasswordWindow : Window
    {
        public PasswordWindow()
        {
            InitializeComponent();
            this.txtLogin.Focus();
            this.Closing += PasswordWindow_Closing;
        }

        private void PasswordWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LogOn()
        {
            string login = this.txtLogin.Text;
            string password = this.passwordBox.Password;

            App application = ((App)Application.Current);

            try
            {
                application.IdentifyUser(login, password);
                this.Hide();
                MainWindow mainWindow = new MainWindow();
                mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;

                mainWindow.Show();
            }
            catch
            {

            }
        }

        public void ReloadWindow()
        {
            this.txtLogin.Clear();
            this.passwordBox.Clear();
            this.ShowDialog();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            this.LogOn();
        }

        private void Cancle_Click(object sender, RoutedEventArgs e)
        {
            App application = ((App)Application.Current);
            this.Close();
            application.Shutdown();
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                this.LogOn();
        }
    }
}
