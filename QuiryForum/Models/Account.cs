using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuiryForum.Models
{
    public class Account
    {
        public Account()
        {
            Followers = new List<Account>();
            Following = new List<Account>();
        }
        /* FOR USERNAMES
          [RegularExpression(@"^[\d\w]+$", 
            ErrorMessage = "Usernames can only contain A-Z, 0-9, and underscores")] 
            
                 [EmailAddress(ErrorMessage = "That doesn't look like an email to me")]

 */
        public virtual ICollection<Account> Followers { get; set; }

        public virtual ICollection<Account> Following { get; set; }
    }
}
