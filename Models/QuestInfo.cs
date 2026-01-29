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
        public string QuestName { get; set; }
        public string QuestHint { get; set; }
        public string QuestAnwser { get; set; }

        //public required string LocationHint { get; set; }
        //public required string QuestLocation { get; set; }

        public QuestType QuestType { get; set; }
        public bool QuestSuccess { get; set; }


        public QuestInfo(
            string QuestName,
            string QuestHint,
            string QuestAnwser,
            QuestType QuestType = QuestType.Manual,
            bool QuestSuccess = false
            ) 
        {
            this.QuestName = QuestName;
            this.QuestHint = QuestHint;
            this.QuestAnwser = QuestAnwser;
            this.QuestType = QuestType;
            this.QuestSuccess = QuestSuccess;
        }
    }
}
