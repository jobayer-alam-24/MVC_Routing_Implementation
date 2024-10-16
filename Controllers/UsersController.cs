using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MVC_Routing_Implementation.Controllers
{
    [Route("Users")]
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }
        [Route("~/Register")]
        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }
        
        [Route("Login")]
        [Route("~/Login")]
        public IActionResult UserLoginByID()
        {
            return View("~/Views/Users/Login.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}