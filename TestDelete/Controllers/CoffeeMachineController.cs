using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestDelete.Data;
using TestDelete.Models;

namespace TestDelete.Controllers
{
    public class CoffeeMachineController(ILogger<CoffeeMachineController> logger, ApplicationDbContext context) : Controller
    {
        private readonly ILogger<CoffeeMachineController> _logger = logger;
        private readonly ApplicationDbContext _context = context;

        [HttpGet]
        public IActionResult OrderCoffee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderCoffee(Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            return View("OrderCoffee");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}