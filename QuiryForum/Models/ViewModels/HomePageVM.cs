using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuiryForum.Models.ViewModels
{
    public class HomePageVM
    {
        public IEnumerable<Question> questions { get; set; }
        public Question q { get; set; }
    }
}
