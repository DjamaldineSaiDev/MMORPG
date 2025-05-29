using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier.model
{
   public class Quest
    {
        private int questId;
        private string title;
        private string description;
        private string type;
        private int level;
        private int experience;
        private int goldReward;
        private string status;
        private List<string> objectives;

        public void Start(Character character)
        {

        }

        public void Complete(Character character) { }

        public void Abandon(Character character) { }
    }
}
