using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier.model
{
    public class Guild
    {
        private string guildId;
        private string name;
        private string description;
        private int level;
        private int maxMembers;
        private DateTime creationDate;
        private List<Character> members;


        public Guild()
        {

        }

        public Guild(string guildId, string name, string description, int level, int maxMembers, DateTime creationDate, List<Character> members)
        {
            this.guildId = guildId;
            this.name = name;
            this.description = description;
            this.level = level;
            this.maxMembers = maxMembers;
            this.creationDate = creationDate;
            this.members = members;
        }

        public void Invite(Character character)
        {
            members.Add(character);
        }

        public void kick(Character character)
        {
           
        }

        public void Promote(Character character)
        {
            character.LevelUp();
        }

        public void Demote(Character character)
        {
        }
    }
}
