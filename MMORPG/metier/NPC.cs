using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier
{
    public class NPC
    {
        private string npcId;
        private string name;
        private string type;
        private Position position;
        private List<string> dialogue;
        private List<Quest> questsToGive;


        public NPC(string npcId, string name, string type, Position position, List<string> dialogue, List<Quest> quests)
        {
            this.npcId = npcId;
            this.name = name;
            this.type = type;
            this.position = position;
            this.dialogue = dialogue;
            this.questsToGive = quests;
        }

        public NPC()
        {
            this.npcId = "";
            this.name = "";
            this.type = "";
            this.position = new Position(0, 0, 0, "");
            this.dialogue = new List<string>();
            this.questsToGive = new List<Quest>();

        }

        public void Interact(Character character) { }

        public Quest GiveQuest(Character character)
        {
            throw new NotImplementedException();
        }

        public void Trade(Character character) {  throw new NotImplementedException(); }


    }
}
