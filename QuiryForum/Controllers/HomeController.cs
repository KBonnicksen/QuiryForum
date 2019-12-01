using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuiryForum.Models;
using QuiryForum.Data;
using QuiryForum.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace QuiryForum.Controllers
{
    public class HomeController : Controller
    {
        private readonly QuiryContext context;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(QuiryContext context, UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index(int? id)
        {
            HomePageVM vm = new HomePageVM();
            //int ID = id ?? -1;
            if (id != null)
            {
                Category c = await CategoryDB.GetCategoryByID((int)id, context);
                
                vm.questions = await QuestionDB.GetQuestionsByCategory((int)id, context);
                ViewData["CategoryTitle"] = c.CategoryName;
                return View(vm);
            }
             vm.questions = await QuestionDB.GetAllQuestions(context);
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Index(HomePageVM vm)
        {
            if (ModelState.IsValid)
            {
                Question q = vm.q;
                ApplicationUser user = await userManager.GetUserAsync(HttpContext.User);
                q.Category = await CategoryDB.GetCategoryByID(q.CategoryID, context);
                q.AddUser(user);
                await QuestionDB.AddAsync(q, context);

                return RedirectToAction("Index");
            };
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
