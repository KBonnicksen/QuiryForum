using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuiryForum.Models.ViewModels
{
    public class AskQuestionVM
    {
        public List<Category> allCategories { get; set; }
        public Question Question { get; set; }
    }
}
