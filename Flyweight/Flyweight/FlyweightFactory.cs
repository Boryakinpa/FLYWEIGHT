using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class FlyweightFactory
    {
        Hashtable characters = new Hashtable();
        public Character GetFlyweight(string key, string className, string imagePath)
        {
            if (!characters.ContainsKey(key))
                characters.Add(key, new ConcreteCharacter(key, className, imagePath));
            return characters[key] as Character;
        }
    }
}
