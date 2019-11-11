using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuiryForum.Data;
using QuiryForum.Models;
using QuiryForum.Models.ViewModels;


namespace QuiryForum.Controllers
{
    public class PostsController : Controller
    {
        private readonly QuiryContext context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signIn;

        public PostsController(QuiryContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signIn)
        {
            this.context = context;
            this.userManager = userManager;
            this.signIn = signIn;
        }

         public async Task<IActionResult> Index() 
         {
             List<Question> allQuestions = await QuestionDB.GetAllQuestions(context);

             return View(allQuestions);
         }

        public async Task<IActionResult> ViewQuestion(int id)
        {
            Question q = await QuestionDB.GetQuestionByID(id, context);
            return View(q);
        }

        public async Task<IActionResult> Ask()
        {
            var askvm = new AskQuestionVM()
            {
                allCategories = await CategoryDB.GetAllCategories(context),
                Question = new Question()
            };

            return View(askvm);
        }

        [HttpPost]
        public async Task<IActionResult> Ask(AskQuestionVM vm)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await userManager.GetUserAsync(HttpContext.User);
                Question q = vm.Question;
                q.AddUser(user);
                q.Category = await CategoryDB.GetCategoryByID(q.CategoryID, context);
                
                await QuestionDB.AddAsync(q, context);
                
                return RedirectToAction("Index");
            };

            return View();
        }
    }
}