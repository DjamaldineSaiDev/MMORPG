using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier.model
{
    public class Class
    {
        private string classId;
        private string name;
        private string description;
        private string primaryAttribute;
        private int baseHealth;
        private int baseMana;

        public Class()
        {
            classId = "";
            name = "";
            description = "";
            primaryAttribute = "";
            baseMana = 0;
            baseHealth = 0;
           

        }

        public List<Skill> GetSkill() { return new List<Skill>(); }
    }
}
