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

namespace Lab_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // запускаємо додаток по центу екрану
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            // встановлюємо фокус на поле textbox1                
            FocusManager.SetFocusedElement(this, textbox1);
        }

        // метод привітання користувача
        private void hello()
        {
            if (textbox1.Text.Equals(string.Empty))
                MessageBox.Show("Ви не ввели ім'я!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                MessageBox.Show("Привіт, " + textbox1.Text + "!", "Привітання",
                    MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            this.hello();
        }

        private void KeyPress_Enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.hello();
            }

        }

    }
}
