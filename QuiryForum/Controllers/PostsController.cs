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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="userManager"></param>
        /// <param name="signIn"></param>
        public PostsController(QuiryContext context, 
            UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signIn)
        {
            this.context = context;
            this.userManager = userManager;
            this.signIn = signIn;
        }

        /// <summary>
        /// Shows a list of all questions in the database with most recent at the top
        /// </summary>
        /// <returns></returns>
         public async Task<IActionResult> Index() 
         {
             List<Question> allQuestions = await QuestionDB.GetAllQuestions(context);

             return View(allQuestions);
         }

        /// <summary>
        /// Views a single question with all of its answers.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> ViewQuestion(int id)
        {
            Question q = await QuestionDB.GetQuestionByID(id, context);
            var qAndA = new ViewQuestionVM()
            {
                Question = q,
                Answers = await AnswerDB.GetAnswersToQuestion(q.QuestionID, context),
                NewAnswer = new Answer()
                {
                    QuestionID = q.QuestionID
                }
            };
            return View(qAndA);
        }

        /// <summary>
        /// Accepts an answer to the question on the page and returns the same page with 
        /// the new answer appended to the bottom.
        /// </summary>
        /// <param name="qAndA"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> ViewQuestion(ViewQuestionVM qAndA)
        {
            Answer a = qAndA.NewAnswer;
            if (ModelState.IsValid)
            {
                ApplicationUser user = await userManager.GetUserAsync(HttpContext.User);
                a.AddUser(user);
                await AnswerDB.AddAsync(a, context);
            }
            else
            {
                ViewData["ErrorMsg"] = "Sorry! we couldn't post your reply :( Maybe you didn't enter anything?";
            }
            return RedirectToAction("ViewQuestion", new { id = a.QuestionID });
        }

        /// <summary>
        /// Prompts the user to ask a new question and choose ethe category it belongs to
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Ask()
        {
            var askvm = new AskQuestionVM()
            {
                allCategories = await CategoryDB.GetAllCategories(context),
                Question = new Question()
            };

            return View(askvm);
        }

        /// <summary>
        /// Takes a new question, adds it to the database and returns to the question index page.
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Ask(AskQuestionVM vm)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await userManager.GetUserAsync(HttpContext.User);
                Question q = vm.Question;
                q.AddUser(user);
                Category c = await CategoryDB.GetCategoryByID(q.CategoryID, context);
                q.CategoryName = c.ToString();
                
                await QuestionDB.AddAsync(q, context);
                
                return RedirectToAction("Index");
            };

            return View();
        }
    }
}