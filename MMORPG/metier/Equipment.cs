using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier
{
    public class Equipment : Item
    {

        private string equipmentSlot;
        private int durability;
        private Dictionary<string, int> bonusStats;
        public override string ItemID => throw new NotImplementedException();

        public override string Name => throw new NotImplementedException();

        public override string Description => throw new NotImplementedException();

        public override string Rarity => throw new NotImplementedException();

        public override string Value => throw new NotImplementedException();

        public override bool Stackable => throw new NotImplementedException();

        public Equipment(string equipmentSlot, int durability, Dictionary<string, int> bonusStats)
        {
            this.equipmentSlot = equipmentSlot;
            this.durability = durability;
            this.bonusStats = bonusStats;
        }

        public override void use()
        {
            throw new NotImplementedException();
        }

        public void Equip(Character character) { throw new NotImplementedException(); }
        public void Unequip(Character character) { throw new NotImplementedException(); }

        public void Repair() { throw new NotImplementedException(); }

        public void Use() { throw new NotImplementedException(); }
    }
}
