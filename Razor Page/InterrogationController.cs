using ASPNET6_Template.Data;
using ASPNET6_Template.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET6_Template.Controllers
{
    public class InterrogationController : Controller
    {
        // Implement code here
        InterrogationDbContext db;
        
        public InterrogationController(InterrogationDbContext _db){
            db= _db;
        }
        [HttpGet]
        public ActionResult Craft(){
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Craft(Problem model){
            try{
                db.Problems.Add(model);
                db.SaveChanges();
                return RedirectToAction("Catalog", "Interrogation");
            }
            catch {
                return RedirectToAction("Catalog", "Interrogation");
            }
        }
        public ActionResult Catalog(){
            return View(db.Problems.ToList());
        }
    }
}
