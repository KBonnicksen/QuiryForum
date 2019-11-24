using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuiryForum.Models.ViewModels
{
    public class ViewQuestionVM
    {
        /// <summary>
        /// Single question being looked at
        /// </summary>
        public Question Question { get; set; }

        /// <summary>
        /// A list of answers to the selected question
        /// </summary>
        public List<Answer> Answers { get; set; }

        /// <summary>
        /// New answer appended to the answer list on httpPost
        /// </summary>
        public Answer NewAnswer { get; set; }
    }
}
