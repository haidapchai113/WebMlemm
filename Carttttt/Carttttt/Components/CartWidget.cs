using Carttttt.Infrastructure;
using Carttttt.Models;
using Microsoft.AspNetCore.Mvc;

namespace Carttttt.Components
{
    public class CartWidget: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(HttpContext.Session.GetJson<Cart>("cart"));
        }
    }
}
