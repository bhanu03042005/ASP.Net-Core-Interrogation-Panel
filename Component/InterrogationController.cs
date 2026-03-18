using Microsoft.AspNetCore.Mvc;

namespace ASPNET6_Template.Controllers
{
    public class InterrogationController : Controller
    {
        //Implement your code here
        public IActionResult GuideMe(){
                return View();
        }
        public ActionResult Form(){
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult Form(IFormCollection collection){
            try{
                return RedirectToAction(nameof(GuideMe));
            }
            catch{
                return View();
            }
        }
    }
}

