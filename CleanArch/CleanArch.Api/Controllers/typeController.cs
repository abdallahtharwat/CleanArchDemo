using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModel;
using CleanArch.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class typeController : ControllerBase
    {
        private readonly ItypeService  _itypeService;

        public typeController(ItypeService  itypeService)
        {
            _itypeService = itypeService;
        }


        [HttpGet]
        public IActionResult get()
        {
            var get = _itypeService.GetAll();
            return Ok(get);
        }

        [HttpPost]
        public IActionResult Post([FromBody] type   type)
        {
            _itypeService.add(type);
           
            return Ok(type);
        }


    }
}