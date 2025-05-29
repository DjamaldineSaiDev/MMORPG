using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier.model
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
            questsToGive = quests;
        }

        public NPC()
        {
            npcId = "";
            name = "";
            type = "";
            position = new Position(0, 0, 0, "");
            dialogue = new List<string>();
            questsToGive = new List<Quest>();

        }

        public void Interact(Character character) { }

        public Quest GiveQuest(Character character)
        {
            throw new NotImplementedException();
        }

        public void Trade(Character character) {  throw new NotImplementedException(); }


    }
}
