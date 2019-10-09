using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuiryForum.Models
{
    public class Account
    {
        /// <summary>
        /// Creates a new Account object
        /// </summary>
        public Account()
        {
           // Followers = new List<FollowSet>();
           // Following = new List<FollowSet>();
        }

        [Key]
        public int AccountID { get; set; }

        [Required]
        [RegularExpression(@"^[\d\w]+$",
            ErrorMessage = "Usernames can only contain A-Z, 0-9, and underscores")]
        /// <summary>
        /// Unique username associated with the account that will be
        /// displayed next to all of the users posts.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The password associated with the account.
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// The unique email associated with this account
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

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
        public DateTime DateOfBirth { get; set; }

        // TODO: Create a property for storing images that users upload

        /// <summary>
        /// A short description the user can use to describe
        /// themselves or display any other information that they want.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// True if the user has verified the email associated with their account.
        /// Default value is false.
        /// </summary>
        public bool IsVerified { get; set; }

        /// <summary>
        /// True if the user has chosen to make their account private. This
        /// hides all user activity from being viewed on their profile.
        /// Default value is false.
        /// </summary>
        public bool IsPrivate { get; set; }

        /// <summary>
        /// List of users following this account.
        /// </summary>
        public virtual ICollection<AccountFollowers> Followers { get; set; }

        public virtual ICollection<AccountFollowers> Following { get; set; }
    }
}
