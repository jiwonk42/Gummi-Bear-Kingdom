using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gummi_bear_kingdom.Models;
using System.Linq;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace gummi_bear_kingdom.Controllers
{
    public class ProductsController : Controller
    {
        private GummiBearKingdomContext db = new GummiBearKingdomContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}
