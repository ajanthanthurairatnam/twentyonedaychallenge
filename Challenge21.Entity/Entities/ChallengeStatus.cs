using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge21.Entity
{
   public class ChallengeStatus
    {
         public int ChallengeStatusID { get; set; }
         public string ChallengeStatusDescription { get; set; }

        public ICollection<UserChallengeItem> UserChallengeItem { get; set; }
        public ICollection<UserChallenge> UserChallenge { get; set; }
    }
}
