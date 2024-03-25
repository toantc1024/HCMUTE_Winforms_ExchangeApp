using Exchange_App.Model;
using Microsoft.Expression.Interactivity.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

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

        public int ProductID => _product.ProductID;

        public string ProductName => _product.ProductName;
        public double Original_price => _product.Original_price;
        public double Sell_price => _product.Sell_price;
        public string Info_des => _product.Info_des;

        public string Status_Des => _product.Status_des;
        //


        #region Commands
        private readonly ICommand _addProductToCartCommand;

        public ICommand AddProductToCartCommand {
            get
            {
                return _addProductToCartCommand ?? (new RelayCommand<int>((p) => { return true; }, (p) => {
                    // Check if the product is already in the cart
                    int productID = p;
                    if (_currentUser.CartItems.Any(x => x.ProductID == productID))
                    {
                        // increase quanitty
                        _currentUser.CartItems.First(x => x.ProductID == productID).Quantity++;
                    } else
                    {
                        _currentUser.CartItems.Add(new CartItem
                        {
                            ProductID = productID,
                            Quantity = 1,
                            User = _currentUser
                        });
                    }
                    
                    //submit changes to the database ado.net
                    DataProvider.Ins.DB.SaveChanges();

                })); 
            }
        }


        #endregion

    }


}
