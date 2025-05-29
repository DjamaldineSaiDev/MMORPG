using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier.model
{
    public class Inventory
    {
        private int maxSlots;
        private List<Item> items;
        public Inventory()
        {
            maxSlots = 0;
            items = new List<Item>();
        }

        public bool AddItem(Item item)
        {
            throw new NotImplementedException();
        }
        public Item RemoveItem(Item item)
        {
            throw new NotImplementedException();
        }

        public Item FindItem(string itemId)
        {
            throw new NotImplementedException();
        } 
    }
}
