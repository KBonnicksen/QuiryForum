using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuiryForum.Models
{
    /// <summary>
    /// Any post made by a user or administrator to the site.
    /// Includes both questions and answers.
    /// </summary>
    public class Post
    {

        public Post()
        {
            // Set the Account to the account logged in
        }

        //The ID of the Creator of the post
        public string UserId { get; set; }

        /// <summary>
        /// The username of the post poster
        /// </summary>
        public string PostedBy { get; set; }

        /// <summary>
        /// The account that created the post.
        /// </summary>
        //public ApplicationUser User { get; set; }

        /// <summary>
        /// Represents the date the post was created.
        /// </summary>
        public DateTime PostingDate { get; set; }

        /// <summary>
        /// The main content of the post. This is optional for 
        /// questions. Content is mandatory for answers.
        /// </summary>
        public string Content { get; set; }

        public void AddUser(ApplicationUser user)
        {
            UserId = user.Id;
            PostedBy = user.UserName;
        }

        public string FormattedDate()
        {
            DateTime now = DateTime.Now;
            if (PostingDate > now.AddHours(-1)) //within the last hour
            {
                int minutesAgo = Convert.ToInt32((now - PostingDate).TotalMinutes);
                return minutesAgo + " minutes ago";
            }
            if (PostingDate > now.AddHours(-24)) //within the last 24 hours
            {
                int hoursAgo = Convert.ToInt32((now - PostingDate).TotalHours);
                return hoursAgo + " hours ago";
            }
            else if (PostingDate > now.AddDays(-7)) //within the last week
            {
                int daysAgo = Convert.ToInt32((now - PostingDate).TotalDays);
                if(daysAgo > 1)
                    return daysAgo + " days ago";

                return "yesterday";
            }
            else if (PostingDate > now.AddMonths(-1)) //within the last month
            {
                int weeksAgo = Convert.ToInt32((now - PostingDate).TotalDays / 4);
                if(weeksAgo > 1)
                    return weeksAgo + " weeks ago";

                return "1 week ago";
            }
            else if (PostingDate > now.AddYears(-1)) //within the last year
            {
                int monthsAgo = Convert.ToInt32((now - PostingDate).TotalDays / 30);
                if (monthsAgo > 1)
                    return monthsAgo + " months ago";

                return "1 month ago";
            }
            else
            {
                int yearsAgo = Convert.ToInt32((now - PostingDate).TotalDays / 365);
                if (yearsAgo > 1)
                    return yearsAgo + " years ago";
                
                return "over 1 year ago";
            }
        }
    }

    /// <summary>
    /// Represents a question posted to the site by a user.
    /// </summary>
    public class Question : Post
    {
        public Question() : base()
        {
            Answers = new List<Answer>();
        }

        [Key]
        public int QuestionID { get; set; }

        [Required]
        [StringLength(300)]
        /// <summary>
        /// The title of the question
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A list of all of the answers users have posted for this question
        /// </summary>
        public virtual ICollection<Answer> Answers { get; set; }

        /// <summary>
        /// The category that the user has chosen for the question.
        /// </summary>
        public string CategoryName { get; set; }

        public int CategoryID { get; set; }
    }

    /// <summary>
    /// A single answer for a given question.
    /// </summary>
    public class Answer : Post
    {
        public Answer() : base()
        {
            Likes = 0;
            Dislikes = 0;
        }

        public int QuestionID { get; set; }

        [Key]
        public int AnswerID { get; set; }

        /// <summary>
        /// The question that this answer is answering.
        /// </summary>
        //public Question Question { get; set; }

        /// <summary>
        /// The amount of likes for the given answer.
        /// </summary>
        public int Likes { get; set; }

        /// <summary>
        /// The amount of dislikes for the given answer.
        /// </summary>
        public int Dislikes { get; set; }

        [Required]
        public new virtual string Content { get; set; }
    }
}
