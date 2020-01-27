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
    public class OrderController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Add(AddOrderViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Order newUser = new Order
                {
                    //User = Where (u => u.UserID == AddOrderViewModel.UserID)   *** Not sure that's the right query for that 
                    //CupType = vm.CupType,
                    //Glitter = vm.Glitter
                };
                return Redirect("/Hello/Index");
            }
            return View(vm);
        }
    }
}
