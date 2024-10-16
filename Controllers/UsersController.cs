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
        //UserID works as Variable
       [Route("Profile/{UserID=1}/{UserName}")]
        public IActionResult GetUserProfile(int UserID, string UserName)
        {
            if(UserID == 1)
            {
            ViewBag.ID = UserID;
            ViewBag.Name = UserName;
            return View("~/Views/Users/Profile1.cshtml");
            }
            else if(UserID == 2)
            {
                ViewBag.ID = UserID;
                ViewBag.Name = UserName;
                return View("~/Views/Users/Profile2.cshtml");
            }
            else
            {
                ViewBag.ID = UserID;
                ViewBag.Name = UserName;
                return View("~/Views/Users/Profile1.cshtml");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}