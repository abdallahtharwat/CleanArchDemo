using CleanArch.Application.Interfaces;
using CleanArch.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Mvc.Controllers
{
    public class MenController : Controller
    {
        private readonly IProductService _productService;
        private readonly IShoppingCartService _shoppingCartService;

        public MenController( IProductService productService, IShoppingCartService shoppingCartService)
        {
      
            _productService = productService;
            _shoppingCartService = shoppingCartService;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> Productlist = _productService.GetAll(   includeproperties: "Category,type,productImages");
            return View(Productlist);
        }



    }
}
