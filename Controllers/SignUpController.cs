using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TRPTools.Models;
using TRPTools.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TRPTools.Controllers
{
    public class SignUpController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            SignUpViewModel vm = new SignUpViewModel();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Add(SignUpViewModel vm)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    Email = vm.Email,
                    Username = vm.Username,
                    Password = vm.Password,
                };
                return Redirect("/Hello/Index");
            }
            return View(vm);
        }
    }
}
