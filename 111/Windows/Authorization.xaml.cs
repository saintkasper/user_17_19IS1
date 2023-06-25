using _111.Classes;
using _111.Model;
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

namespace _111.Windows
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
            UserData.authorization = this;
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text.Length != 0 && Password.Text.Length != 0)
            {
                User user = App.context.Users.ToList().Find(u => u.Login == Login.Text && u.Passcode == Password.Text);
                if (user != null)
                {
                    ProductsWindow productsWindow = new ProductsWindow();
                    productsWindow.Show();
                    this.Hide();
                    MessageBox.Show($"Добро пожаловать {user.FullName}!");
                }
                else
                    MessageBox.Show("Вы ввели неверный логин или пароль!");
            }
            else
                MessageBox.Show("Заполните все поля!");
        }

        private void EnterAsGuest_Click(object sender, RoutedEventArgs e)
        {
            ProductsWindow productsWindow = new ProductsWindow();
            productsWindow.Show();
            this.Hide();
            MessageBox.Show($"Добро пожаловать!");
        }
    }
}
