using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier.model
{
    public class Race
    {
        private int raceId;
        private string name;
        private string description;
        private int bonusStrength;
        private int bonusAgillity;
        private int bonusIntelligence;
        private List<string> specialAbilities;


        public int GetBonus(string attribute)
        {
            return bonusAgillity;
        }
    }
}
