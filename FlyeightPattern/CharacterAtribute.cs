using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlyeightPattern
{
    public class CharacterAtribute
    {
        public int Level { get; set; }
        public int Experience { get; set; }

        public CharacterAtribute(int level, int exp)
        {
            Level = level;
            Experience = exp;
        }
        public string DisplayAtribute()
        {
            return ($"Уровень: {Level}, Опыт: {Experience}");
        }
    }
}
