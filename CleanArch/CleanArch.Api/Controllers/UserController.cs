using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModel;
using CleanArch.Domain.Models;
using CleanArch.Domain.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IApplicationUserService  _applicationUserService;
      

        public UserController(IApplicationUserService  applicationUserService)
        {
            _applicationUserService = applicationUserService;
           
        }


        [HttpGet]
        public IActionResult get()
        {
            var get = _applicationUserService.GetAll(includeproperties: "Company");

 

            return Ok(get);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ApplicationUser  applicationUser )
        {
            _applicationUserService.add(applicationUser);
           
            return Ok(applicationUser);
        }


    }
}