using FashionShop.Data;
using FashionShop.Infrastructure;
using FashionShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FashionShop.Components
{
    public class CartWidget:ViewComponent
    {
         public IViewComponentResult Invoke()
         {
             return View(HttpContext.Session.GetJson<Cart>("cart"));
         
     }
    }
}
