using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier
{
    public class Monster
    {
        private string mosterId;
        private string name;
        private int level;
        private int health;
        private int damage;
        private int experience;
        private List<Item> lootTable;

        public Monster() { }

        public void Attack(Character target)
        {
            target.TakeDamage(damage);
        }

        public void Die()
        {
            this.health = 0;
        }

        public void DropLoot()
        {
            this.health = 0;

        }
    }
}
