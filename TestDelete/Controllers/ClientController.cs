using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDelete.Data;

namespace TestDelete.Controllers
{
    public class ClientController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly Data.IdentityContext _context;

        public ClientController(Data.IdentityContext context)
        {
            _context = context;
        }

        //public async Task<IActionResult> Index()
        //{
        //    var clients = await _context.Clients.ToListAsync();
        //    return View(clients);
        //}
    }
}
