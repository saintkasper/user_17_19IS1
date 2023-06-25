using _111.Classes;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace _111.UserControls
{
    /// <summary>
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : UserControl
    {
        public Product(Model.Product product)
        {
            InitializeComponent();
            Article.Text += product.Article;
            Stock.Text += product.Stock;
            Description.Text += product.Specification;
            Title.Text += product.Title;
            Cost.Text += (product.Cost - product.Cost * product.Dicsount / 100).ToString() + "руб.";

            try
            {
                BitmapImage img = new BitmapImage();
                MemoryStream ms = new MemoryStream(product.Image);
                img.BeginInit();
                img.StreamSource = ms;
                img.EndInit();
                Img.Source = img;
            }
            catch { }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            UserData.productWindow.Order.IsEnabled = true;
        }
    }
}
