using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuiryForum.Models
{
    public class AccountFollowers
    {
        //[ForeignKey("UserID")]
        public ApplicationUser User { get; set; }
        public string UserID { get; set; }


        //[ForeignKey("FollowerID")]
        public ApplicationUser Follower { get; set; }
        public string FollowerID { get; set; }
    }
}
