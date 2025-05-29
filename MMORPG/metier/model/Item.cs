using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier.model
{
    public abstract class Item 
    {
        public abstract string ItemID { get; }
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract string Rarity { get; }
        public abstract string Value { get; }
        public abstract bool Stackable { get; }

        public abstract void use();
    }
}
