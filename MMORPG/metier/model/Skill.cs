using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier.model
{
    public class Skill
    {

        private string name;
        private int SkillId;
        private string description;
        private int manaCost;
        private int cooldown;
        private int damage;
        private int level;
        public Skill() { }

        public void Cast(Character target)
        {

        }
        public void upgrade() { }
    }
}
