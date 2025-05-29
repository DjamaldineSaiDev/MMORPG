using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier
{
    public class Position
    {
        private float x;
        private float y;
        private float z;
        private string zoneId;


        public Position(float x, float y, float z, string zoneId)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.zoneId = zoneId;
        }

        public float DistanceTo(Position other) { return other.DistanceTo(this); }
    }
}
