using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuiryForum.Models
{
    public class ApplicationUser : IdentityUser
    {
      
        /// <summary>
        /// The unique email associated with this account
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]


        public override string Email { get; set; }

        /// <summary>
        /// The first name of the user of the account.
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the user of the account. Not required.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The date the user of this account was born.
        /// </summary>
        [Required]
        [PersonalData]
        public DateTime DateOfBirth { get; set; }

        // TODO: Create a property for storing images that users upload

        /// <summary>
        /// A short description the user can use to describe
        /// themselves or display any other information that they want.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// True if the user has chosen to make their account private. This
        /// hides all user activity from being viewed on their profile.
        /// Default value is false.
        /// </summary>
        public bool IsPrivate { get; set; }

        //public ICollection<Question> UserQuestions { get; set; }

        /// <summary>
        /// List of users following this account.
        /// </summary>
        public virtual ICollection<AccountFollowers> Followers { get; set; }

        public virtual ICollection<AccountFollowers> Following { get; set; }
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
        public virtual ICollection<IdentityUserToken<string>> Tokens { get; set; }
        public virtual ICollection<IdentityUserRole<string>> UserRoles { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }

    public class ApplicationUserRole : IdentityRole
    {
        public String Description { get; set; }
    }
}
