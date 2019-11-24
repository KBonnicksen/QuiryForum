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
        private DateTime postingDate;

        public Post()
        {
            // Set the Account to the account logged in
            postingDate = DateTime.Now;
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
        public DateTime PostingDate { get => postingDate; }

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
        public Category Category { get; set; }

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
