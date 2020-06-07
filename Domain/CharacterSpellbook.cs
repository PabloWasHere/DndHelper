using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CharacterSpellbook
    {
        public int CharacterId { get; set; }
        public Character Character { get; set; }

        public int SpellId { get; set; }
        public Spell Spell { get; set; } 
    }
}
