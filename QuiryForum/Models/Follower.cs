using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuiryForum.Models
{
    public class Follower
    {
        public Follower(int followerID, int followingID)
        {
            FollowerID = followerID;
            FollowingID = followingID;
        }

        public int FollowerID { get; set; }

        public int FollowingID { get; set; }
    }
}
