using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindShaulsTreasure.Models
{
    public enum QuestType { Manual, Automatic }

    public class QuestInfo
    {
        public required string QuestName { get; set; }

        public required string QuestHint { get; set; }
        public required string QuestAnwser { get; set; }

        //public required string LocationHint { get; set; }
        //public required string QuestLocation { get; set; }

        public QuestType QuestType { get; set; } = QuestType.Manual;
        public bool QuestSuccess { get; set; } = false;
    }
}
