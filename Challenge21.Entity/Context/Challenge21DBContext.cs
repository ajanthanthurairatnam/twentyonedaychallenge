using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge21.Entity
{
    public class Challenge21DBContext:DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<ChallengeStatus> ChallengeStatus { get; set; }
        public DbSet<ChallengeType> ChallengeType { get; set; }
        public DbSet<UserChallenge> UserChallenge { get; set; }
        public DbSet<UserChallengeItem> UserChallengeItem { get; set; }
    }
}
