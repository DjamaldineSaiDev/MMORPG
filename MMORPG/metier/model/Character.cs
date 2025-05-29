using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.metier.model
{
    public class Character
    {
        private string characterId;
        private string name;
        private int level;
        private long experience;
        private int health;
        private int mana;
        private int strength;
        private int agility;
        private int intelligence;
        private Position position;
        private Skill skill;
        private Class classe;
        private Race race;
        private Inventory inventory;



        private string CharacterId => characterId;
        private string Name { get => name; set => name = value; }
        private int Level { get => level; set => level = value; }
        private long Experience { get=> experience; set => experience = value; }
        private int Health { get => health; set => health = value; }
        private int Mana { get => health; set => health = value; }
        private int Strength { get => strength; set => strength = value; }
        private int Agility => agility;
        private int Intelligence { get => intelligence; set => intelligence = value; }
        private Position Position { get=> position; set => position = value; }



        public Character(string characterId, string name, int level, long experience, int health, int mana, int strength,
                         int agility, int intelligence, Position position, Skill skill, Class classe, Race race, Inventory inventory)
        {
            this.characterId = characterId;
            this.name = name;
            this.level = level;
            this.experience = experience;
            this.health = health;
            this.mana = mana;
            this.strength = strength;
            this.agility = agility;
            this.intelligence = intelligence;
            this.position = position;
            this.skill = skill;
            this.inventory = inventory;
            this.health = health;
            this.classe = classe;
            this.race = race;
           
        }

        public void LevelUp() { }

        public void TakeDamage(int damage)
        {
           health -= damage;
        }
        public void Heal(int amount)
        {
            health += amount;
        }

        public void Move(Position newPosition)
        {
            position = newPosition;
        }

        public void UseSkill(Skill skill)
        {
            this.skill = skill;
        }



    }
}
