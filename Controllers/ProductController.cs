using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        CoffeeShopProductsContext db = new CoffeeShopProductsContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int ID)
        {
            List<Product> products= db.Products.ToList();
            return View(products[ID-1]);
        }
    }
}
