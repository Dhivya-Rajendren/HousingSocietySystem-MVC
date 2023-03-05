using HousingSocietySystem_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HousingSocietySystem_MVC.Controllers
{
    public class FlatsController : Controller
    {
        private readonly HousingSocietyDbContext dbContext;

        public FlatsController(HousingSocietyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
           
            List<Flat> flats = dbContext.Flats.ToList();
            return View(flats);
        }

        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Flat flat)
        {
            
            dbContext.Flats.Add(flat);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
