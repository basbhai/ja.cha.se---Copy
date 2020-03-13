using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ja.cha.se.Models;
using Microsoft.AspNetCore.Mvc;
using ja.cha.se.Controllers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ja.cha.se.Controllers
{
    public class loggedInMenusController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        /// <summary>
        /// Dependency injection of ICustomerRepository is required
        /// </summary>
        /// <returns></returns>

        public loggedInMenusController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
               
        // GET: /<controller>/
        [Route("LoggedInMenus")]

        // load page on request
     
   
        public ViewResult Customer(Customer customer)
        {
            Customer newCustomer = _customerRepository.Add(customer);
            return View();
        }

        // transfer input data to DB and redirect
       
        //public IActionResult Customer()
        //{

        //    return RedirectToAction("About");         

        //}




        public IActionResult AccountOpening()
        {
            return View();
        }
    }
}
