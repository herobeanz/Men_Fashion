using FashionShop.Data;
using Microsoft.AspNetCore.Mvc;

namespace FashionShop.Components
{
    public class JustArrived:ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public JustArrived(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Products.Where(c => c.IsArrived == true).ToList());
        }
    }
}
