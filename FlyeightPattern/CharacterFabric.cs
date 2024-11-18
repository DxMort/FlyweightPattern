using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyeightPattern
{
    public class CharacterFabric
    {
        private Dictionary<string, Character> _characters = new Dictionary<string, Character>();

        public Character CreateCharacter(string name, string type, string image)
        {
            string key = $"{name}_{type}";

            if (_characters.ContainsKey(key))
            {
                MessageBox.Show("Такой персонаж уже существует");
                return _characters[key];
            }
            var newCharacter = new Character(name, type, image);
            _characters[key] = newCharacter;

            return newCharacter;
        }
    }
}