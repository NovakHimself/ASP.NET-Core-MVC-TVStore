using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TVStore.Models;

namespace TVStore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Buy(int id)
        {
            ViewBag.TVId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо, " + order.User + ", за покупку!";
        }

        TVContext db;
        public HomeController(TVContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.TVs.ToList());
        }
    }


}