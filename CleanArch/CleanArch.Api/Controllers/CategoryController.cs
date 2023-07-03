using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModel;
using CleanArch.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService  categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet]
        public IActionResult get()
        {
            var get = _categoryService.GetAll();
            return Ok(get);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Category  category)
        {
            _categoryService.add(category);
           
            return Ok(category);
        }


    }
}