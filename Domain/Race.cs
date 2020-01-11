using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Race
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }

        // Abilities bonus
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        // Subrace
        public Race SubRace { get; set; }
    }
}
