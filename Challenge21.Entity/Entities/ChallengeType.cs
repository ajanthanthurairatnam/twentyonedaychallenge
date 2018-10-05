using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge21.Entity
{
    public class ChallengeType
    {
        public int ChallengeTypeID { get; set; }
        public string ChallengeTypeDescription { get; set; }
        public string ChallengeTypeNotes { get; set; }

        public ICollection<UserChallengeItem> UserChallengeItem { get; set; }
        public ICollection<UserChallenge> UserChallenge { get; set; }
    }
}
