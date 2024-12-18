using AjaxExmaple.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxExmaple.Controllers
{
    public class CustomerController : Controller
    {
        List<CustomerModel> customers = new List<CustomerModel>();

        public CustomerController()
        {
            customers.Add(new CustomerModel() { Id = 0, Name = "diego" , Age=32 });
            customers.Add(new CustomerModel() { Id = 1, Name = "Daniel", Age = 55 });
            customers.Add(new CustomerModel() { Id = 2, Name = "Alejandro", Age = 44 });
            customers.Add(new CustomerModel() { Id = 3, Name = "Elena", Age = 22 });
            customers.Add(new CustomerModel() { Id = 4, Name = "pedro", Age = 55 });
            customers.Add(new CustomerModel() { Id = 5, Name = "pepe", Age = 44 });
            customers.Add(new CustomerModel() { Id = 6, Name = "paco", Age = 22 });
        }

        public IActionResult Index()
        {
            return View(customers);
        }

        public IActionResult ShowOnePerson(int Id)
        {
            CustomerModel c = customers.FirstOrDefault(x => x.Id==Id);
            return PartialView(c);
        }
        
    }
}
