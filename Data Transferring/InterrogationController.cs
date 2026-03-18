using Microsoft.AspNetCore.Mvc;

namespace ASPNET6_Template.Controllers
{
    public class InterrogationController : Controller
    {
        //Implement your code here
        public ActionResult MemberName(int registrationnumber, string name){
            ViewBag.Details=registrationnumber+ " " +name;
            return View();
        }
        public ActionResult Problem(string problem){
            ViewData["Problem"]=problem;
            return View();
        }
        public ActionResult Solution(string solution){
            TempData["Solution"]=solution;
            return RedirectToAction("FinalSolution");
        }
        public ActionResult FinalSolution(){
            string final= TempData["solution"] as string;
            return View();
        }
    }
}
