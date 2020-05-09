using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Spell : SimpleState
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CastingTime { get; set; }
        public string Range { get; set; }
        public string Components { get; set; }
        public string Duration { get; set; }
        public string Materials { get; set; }
        public string Description { get; set; }
        public string Family { get; set; }
        public int Level { get; set; }
        public int Custom { get; set; } = 0;
        public virtual User Owner { get; set; }
        public virtual CharClass Class { get; set; }

        public virtual ICollection<Character> PreparedCharacter { get; set; }
        public virtual ICollection<Character> SpellbookCharacter { get; set; }
    }
}
