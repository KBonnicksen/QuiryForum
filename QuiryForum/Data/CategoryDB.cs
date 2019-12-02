using Microsoft.EntityFrameworkCore;
using QuiryForum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuiryForum.Data
{
    public class CategoryDB
    {
        public static async Task<List<Category>> GetAllCategories(QuiryContext context)
        {
            List<Category> categories = await context.Categories
                                                 .OrderByDescending(c => c.CategoryID)
                                                 .ToListAsync();
            return categories;
        }

        public static async Task<Category> GetCategoryByID(int id, QuiryContext context)
        {
            Category c = await (context.Categories.Where(m => m.CategoryID == id)).SingleOrDefaultAsync();
            return c;
        }

        public static async Task<Category> GetCategoryByName(string name, QuiryContext context)
        {
            Category c = await (context.Categories.Where(m => m.CategoryName == name)).SingleOrDefaultAsync();
            return c;
        }

        public static async Task<string> GetCategoryNameByID(int id, QuiryContext context)
        {
            Category c = await GetCategoryByID(id, context);
            return c.ToString();
        }

        public static async Task<string> GetColorByID(int id, QuiryContext context)
        {
            Category c = await GetCategoryByID(id, context);
            return c.Color;
        }
    }
}
