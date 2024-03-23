using Exchange_App.Model;
using Exchange_App.ViewModel;
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

namespace Exchange_App.View
{
    /// <summary>
    /// Interaction logic for ProductDetailsView.xaml
    /// </summary>
    public partial class ProductDetailsView : Window
    {
        public ProductDetailsView(Product currentProduct, User currentUser) 
        {
            InitializeComponent();
            this.DataContext = new ProductDetailsViewModel(currentProduct, currentUser);

            imageProduct.ImageSource = currentProduct.Images.First().ImageBitmap;
        }
    }
}
