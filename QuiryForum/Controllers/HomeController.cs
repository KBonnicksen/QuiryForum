using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuiryForum.Models;
using QuiryForum.Data;

namespace QuiryForum.Controllers
{
    public class HomeController : Controller
    {
        private readonly QuiryContext context;

        public HomeController(QuiryContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            int ID = id ?? -1;
            if (ID != -1)
            {
                Category c = await CategoryDB.GetCategoryByID(ID, context);

                ViewData["CategoryTitle"] = c.CategoryName;
                List<Question> questions = await QuestionDB.GetQuestionsByCategory(ID, context);
                return View(questions);
            }
            List<Question> allQuestions = await QuestionDB.GetAllQuestions(context);
            return View(allQuestions);
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
