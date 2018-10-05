using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge21.Entity
{
    public class UserChallenge
    {
        public int UserChallengeID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }

        public string UserChallengeDescription { get; set; }
        public DateTime UserChallengeEstimatedStartDate { get; set; }
        public DateTime UserChallengeEstimatedEndDate { get; set; }
      
        [ForeignKey("ChallengeType")]
        public int? ChallengeTypeID { get; set; }
        public ChallengeType ChallengeType { get; set; }

        public DateTime UserChallengeActualStartDate { get; set; }
        public DateTime UserChallengeActualEndDate { get; set; }
        public string UserChallengeCompletionNotes { get; set; }

        [ForeignKey("ChallengeStatus")]
        public int? ChallengeStatusID { get; set; }
        public ChallengeStatus ChallengeStatus { get; set; }

        public ICollection<UserChallengeItem> UserChallengeItem { get; set; }
    }
}
