using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuiryForum.Data;
using QuiryForum.Models;

namespace QuiryForum.Controllers
{
    public class PostsController : Controller
    {
        private readonly QuiryContext context;

        public PostsController(QuiryContext context)
        {
            this.context = context;
        }

        /* public async Task<IActionResult> Index() 
         {
             List<Question> allQuestions = await QuestionDB.GetAllQuestions(context);

             return View(allQuestions);
         }*/

        public IActionResult ViewQuestion(Question q)
        {
            return View(q);
        }

        public IActionResult Ask()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Ask(Question q)
        {
            if (ModelState.IsValid)
            {
                await QuestionDB.AddAsync(q, context);
                
                return RedirectToAction("Index");
            };

            return View();
        }
    }
}