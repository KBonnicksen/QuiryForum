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
        public Account User { get; set; }
        public int? UserID { get; set; }


        //[ForeignKey("FollowerID")]
        public Account Follower { get; set; }
        public int? FollowerID { get; set; }
    }
}
