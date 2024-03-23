using Exchange_App.Model;
using Exchange_App.Tools;
using Exchange_App.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Exchange_App.ViewModel
{
    public class HomeViewModel :BaseViewModel
    {
        private User _currentUser;
        public ObservableCollection<Product> Products { get; set; }

        private Product _selectedProduct;

        public ICommand SetCountCommand;


        public HomeViewModel(User user, ICommand SetCount)
        {
            Products = new ObservableCollection<Product>();
            SetCountCommand = SetCount;
            _currentUser = user;
            LoadProducts();
        }

        public void LoadProducts()
        {
            Products = new ObservableCollection<Product>(DataProvider.Ins.DB.Products);
        }

        #region selected products
        public Product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                if (SelectedProduct != null)
                {
                    ProductDetailsView productDetailsView = new ProductDetailsView(SelectedProduct, _currentUser);
                    productDetailsView.ShowDialog();
                    _selectedProduct = null;
                }
                OnPropertyChanged("SelectedProduct");
            }
        }

        #endregion
    }
}
