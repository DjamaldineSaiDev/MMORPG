using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier.model
{
    public class Consumable : Item
    {
        private string effect;
        private int durataion;
        public override string ItemID => throw new NotImplementedException();

        public override string Name => throw new NotImplementedException();

        public override string Description => throw new NotImplementedException();

        public override string Rarity => throw new NotImplementedException();

        public override string Value => throw new NotImplementedException();

        public override bool Stackable => throw new NotImplementedException();

        public override void use()
        {
            throw new NotImplementedException();
        }

        public void consume(Character character) { }



    }
}
