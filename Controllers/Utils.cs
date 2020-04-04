using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class Utils
    {
        public static int CalculateModifier(int abilityScore)
        {
            float rawScore = (abilityScore - 10) / 2;
            return (int)Math.Floor(rawScore);
        }

        public static int CalculateProficiencyBonus(int level)
        {
            float rawScore = (level + 7) / 4;
            return (int)Math.Floor(rawScore);
        }

        public static List<string> GetSpellFamilies()
        {
            return new List<string>()
            {
                "Abjuración",
                "Conjuración",
                "Adivinación",
                "Encantamiento",
                "Evocación",
                "Ilusión",
                "Nigromancia",
                "Transmutación"
            };
        }
    }
}
