using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using ServiceLayer.Interfaces;
using DomainLayer.Interfaces;
using ServiceLayer.Models;
using ServiceLayer.Services;
using RepositoryLayer;

namespace Marketplace_OA.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUsersService usersService;

        public AccountController()
        {
            var context = new MarketDBContext(); // Create an instance of your database context
            var usersRepo = new UsersRepo(context);
            usersService = new UsersService(usersRepo);
        }

        public AccountController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        //GET: Account
       [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UsersDTO userDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Call the service to register the user
                    usersService.RegisterUser(userDto); // Call the method to add user
                    ViewBag.SuccessMessage = "Registration successful! Please log in.";
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = "An error occurred while registering: " + ex.Message;
                }
            }

            // Return to the login page
            return View("Login");
        }

    }
}