using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using QuiryForum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuiryForum.Data
{
    public class UserDB
    {
        //private static readonly UserManager<ApplicationUser> userManager;

        public UserDB(UserManager<ApplicationUser> userManager)
        {
            //userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>());
        }
        //private UserManager<ApplicationUser> _userManager = new UserManager<ApplicationUser>(IUser)
        /*public static async Task<ApplicationUser> GetUserByID(string id)
        {
            ApplicationUser user = User.
            return user;
        }*/
    }
}
