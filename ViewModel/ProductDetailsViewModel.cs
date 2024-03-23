using Exchange_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_App.ViewModel
{
    internal class ProductDetailsViewModel
    {
        private Product _product;
        private User _currentUser;

        public ProductDetailsViewModel(Product product, User currentUser)
        {
            _product = product;
            _currentUser = currentUser;
        }

        // extract all prop of _product to property
        public string ProductName => _product.ProductName;
        public double Original_price => _product.Original_price;
        public double Sell_price => _product.Sell_price;
        public string Info_des => _product.Info_des;

        public string Status_Des => _product.Status_des;
        //


    }   
}
