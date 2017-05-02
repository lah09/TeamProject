using System.Collections.Generic;
using WebShopProject.Models;

namespace WebShopProject.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}