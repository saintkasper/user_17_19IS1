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
    /// Логика взаимодействия для ProductsWindow.xaml
    /// </summary>
    public partial class ProductsWindow : Window
    {
        public ProductsWindow()
        {
            InitializeComponent();
            UserData.productWindow = this;
            List<Category> category = App.context.Categories.ToList();
            Filter.Items.Add("Все категории");
            foreach (var item in category)
            {
                Filter.Items.Add(item.Title);
            }
            LoadData();
        }

        void LoadData()
        {
            Main.Children.Clear();
            List<Product> products = App.context.Products.ToList();
            if (Filter.SelectedIndex != 0)
            {
                products = products.Where(p => p.CategoryId == Filter.SelectedIndex).ToList();
            }
            if (Search.Text.Length != 0)
            {
                products = products.Where(p => p.Title.ToLower().Contains(Search.Text.ToLower())).ToList();
            }
            if (Asc.IsChecked == true)
            {
                products = products.OrderBy(p  => p.Cost).ToList();
            }
            else
                products = products.OrderByDescending(p => p.Cost).ToList();
            if (products.Count == 0)
            {
                MessageBox.Show("Товары не найдены");
                Search.Text = "";
                Filter.SelectedIndex = 0;
                LoadData();
            }
            foreach (var item in products)
            {
                Main.Children.Add(new UserControls.Product(item));
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            LoadData();
        }

        private void Filter_DropDownClosed(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Asc_Checked(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void Desc_Checked(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            UserData.authorization.Show();
        }
    }
}
