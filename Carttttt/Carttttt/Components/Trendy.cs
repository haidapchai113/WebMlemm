using Carttttt.Data;
using Microsoft.AspNetCore.Mvc;

namespace Carttttt.Components
{
    public class Trendy: ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public Trendy(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Products.Where(p=>p.IsTrandy == true).ToList());
        }
    }
}
