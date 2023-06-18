using Carttttt.Data;
using Microsoft.AspNetCore.Mvc;

namespace Carttttt.Components
{
    public class ImageBar : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public ImageBar(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View("Index",_context.Categories.ToList());
        }
    }
}
