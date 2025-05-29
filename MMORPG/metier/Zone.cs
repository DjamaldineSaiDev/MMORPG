using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier
{
    public class Zone
    {
        private int zoneId;
        private string name;
        private string description;
        private string levelRange;
        private string climate;
        private List<Monster> monsters;
        private List<NPC> npcs;


        public Zone(int zoneId, string name, string description, string levelRange, string climate, List<Monster> monsters, List<NPC> npcs)
        {
            this.zoneId = zoneId;
            this.name = name;
            this.description = description;
            this.levelRange = levelRange;
            this.climate = climate;
            this.monsters = monsters;
            this.npcs = npcs;
        }

        public Zone()
        {
            this.zoneId = 0;
            this.name = "";
            this.description = "";
            this.levelRange = "";
            this.climate = "";
            this.npcs = new List<NPC>();
            this.monsters = new List<Monster>();
        }


    }
}
