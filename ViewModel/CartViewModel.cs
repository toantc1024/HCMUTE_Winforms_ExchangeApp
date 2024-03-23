using Exchange_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_App.ViewModel
{
    public class CartViewModel :BaseViewModel
    {
        private User _currentUser;

        public CartViewModel(User user)
        {
            CurrentUser = user;
        }

        public User CurrentUser { get => _currentUser; set => _currentUser=value; }
    }
}
