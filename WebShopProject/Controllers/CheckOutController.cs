﻿using System;
using System.Linq;
using System.Web.Mvc;
using WebShopProject.DAL;
using WebShopProject.Models;

namespace MvcAffableBean.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private WebShopContext db = new WebShopContext();
        const String PromoCode = "FREE";

        public ActionResult AddressAndPayment()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult AddressAndPayment(FormCollection values)
        {
            var order = new CustomerOrder();

            TryUpdateModel(order);

            try
            {
                if (string.Equals(values["PromoCode"], PromoCode, StringComparison.OrdinalIgnoreCase) == false)
                {
                    return View(order);
                }
                else
                {
                    order.CustomerUserName = User.Identity.Name;
                    order.DateCreated = DateTime.Now;
                    db.CustomerOrders.Add(order);
                    db.SaveChanges();

                    var cart = ShoppingCart.GetCart(this.HttpContext);
                    cart.CreateOrder(order);
                    db.SaveChanges();
                    return RedirectToAction("Complete", new { id = order.Id });
                }
            }
            catch (Exception ex)
            {
                ex.InnerException.ToString();
                return View(order);
            }
        }

        public ActionResult Complete(int id)
        {
            bool isValid = db.CustomerOrders.Any(o => o.Id == id && o.CustomerUserName == User.Identity.Name);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }
    }
}