﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CharClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int HitDice { get; set; }

        public virtual ICollection<Spell> Spells { get; set; }
    }
}
