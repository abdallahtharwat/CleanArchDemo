using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModel;
using CleanArch.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService  _productService;

        public ProductController(IProductService  productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public IActionResult get()
        {
            var get = _productService.GetAll(includeproperties: "Category,type");
            return Ok(get);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product   product)
        {
            _productService.add(product);
           
            return Ok(product);
        }


    }
}