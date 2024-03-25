using Exchange_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Exchange_App.ViewModel
{
    public class CartViewModel :BaseViewModel
    {
        private User _currentUser;

        private List<object> _cartItems;

        public CartViewModel(User user)
        {
            CurrentUser = user;

            var custQuery = from cart in CurrentUser.CartItems
                            join product in DataProvider.Ins.DB.Products
                            on cart.ProductID equals product.ProductID
                            select new {
                                ProductID = product.ProductID,
                                Original_price = product.Original_price,
                                Sell_price = product.Sell_price,
                                ProductName = product.ProductName,
                                PreviewImage = product.GetPreviewImage,
                                Category = product.Category,
                                Product_Quantity = product.Quantity,
                                CartItemsID = cart.CartItemsID,
                                CartQuantity = cart.Quantity
                            };
                    MessageBox.Show("Cart Items: " + custQuery.Count().ToString() + " items in cart.");
            CartItems = custQuery.ToList<object>();
        }

        public User CurrentUser { get => _currentUser; set => _currentUser=value; }
        public List<object> CartItems { get => _cartItems; set => _cartItems=value; }
    }
}
