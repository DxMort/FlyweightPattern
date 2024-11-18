using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyeightPattern
{
    public class Character
    {
        public string Name { get; }
        public string Type { get; }
        public string Image { get; }

        public Character(string name, string type, string image)
        {
            Name = name;
            Type = type;
            Image = image;
        }
        public string Display()
        {
            return ($"Персонаж: {Name}, Тип: {Type}");
        }
    }
}