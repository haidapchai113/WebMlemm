using Carttttt.Data;
using Microsoft.AspNetCore.Mvc;

namespace Carttttt.Components
{
    public class NavBar : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public NavBar(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Categories.ToList());
        }

    }
}
