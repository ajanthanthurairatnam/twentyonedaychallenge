using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge21.Entity
{
    public class UserChallengeItem
    {
        public int UserChallengeItemID { get; set; }      
        [ForeignKey("UserChallenge")]
        public int UserChallengeID { get; set; }
        public UserChallenge UserChallenge { get; set; }
        public string UserChallengeItemDescription { get; set; }
     
        [ForeignKey("ChallengeType")]
        public int? ChallengeTypeID { get; set; }
        public ChallengeStatus ChallengeType { get; set; }

        public DateTime? UserChallengeItemEstimatedStartDate { get; set; }
        public DateTime? UserChallengeItemEstimatedEndDate { get; set; }
        public DateTime? UserChallengeItemActualStartDate { get; set; }
        public DateTime? UserChallengeItemActualEndDate { get; set; }
        public string UserChallengeItemCompletionNotes { get; set; }

        [ForeignKey("ChallengeStatus")]
        public int? ChallengeStatusID { get; set; }
        public ChallengeStatus ChallengeStatus { get; set; }

    }
}
