﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuiryForum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuiryForum.Data
{
    /// <summary>
    /// DB helper for Questions
    /// </summary>
    public class QuestionDB
    {
        /// <summary>
        /// Adds a question post to the database. Automatically sets
        /// the ID.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task<Question> AddAsync(Question q, QuiryContext context)
        {
            q.PostingDate = DateTime.Now;
            await context.AddAsync(q);
            await context.SaveChangesAsync();
            return q;
        }

        public static async Task DeleteByID(int ID, QuiryContext context)
        {
            Question q = new Question()
            {
                QuestionID = ID
            };
            context.Entry(q).State = EntityState.Deleted;
            await context.SaveChangesAsync();
        }

        public static async Task<Question> EditQuestion(Question question, QuiryContext context)
        {
            context.Update(question);
            await context.SaveChangesAsync();
            return question;
        }

        /// <summary>
        /// Returns all questions in the database sorted by date posted
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task<List<Question>> GetAllQuestions(QuiryContext context)
        {
            List<Question> questions = await context.Questions
                                                 .OrderByDescending(q => q.PostingDate)
                                                 .ToListAsync();
            return questions;
        }

        /// <summary>
        /// Returns a question with the specified ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task<Question> GetQuestionByID(int id, QuiryContext context)
        {   
            Question q = await (context.Questions.Where(m => m.QuestionID == id)).SingleOrDefaultAsync();
            //q.User = AspNetUserManager.
            return q;
        }

        public static async Task<List<Question>> GetQuestionsByCategory(int id, QuiryContext context)
        {
            List<Question> q = await (context.Questions.Where(m => m.CategoryID == id)).ToListAsync();
            return q;
        }
    }
}
