using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Character : SimpleState
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Race Race { get; set; }
        public CharClass Class { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int MaxHp { get; set; }
        public int CurrentHp { get; set; }

        public int Speed { get; set; }
        public int Proficiency { get; set; } // Depends on the level
        public int Initiative { get; set; } // Dexterity modifier
        public int ArmorClass { get; set; } // Default of 10
        public bool Inspiration { get; set; } // DM's choice

        // Abilities
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
    }
}
