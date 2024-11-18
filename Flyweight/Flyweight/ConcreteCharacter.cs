using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class ConcreteCharacter : Character
    {
        internal int Hp { get; private set; } = 100;
        internal int Level { get; private set; } = 1;
        public ConcreteCharacter(string name, string _class, string _imagePath) : base(name, _class, _imagePath)
        {
        }

        public override void ChangeLevel(int changeState)
        {
            Level += changeState;
            Console.WriteLine($"Name: {Name}\nClass: {Class}\nHP: {Hp}\nLevel: {Level}\n");
            Drawer.Draw(ImagePath);
        }

        public override void ChangeHp(int changeState)
        {
            Hp += changeState;
            Console.WriteLine($"Name: {Name}\nClass: {Class}\nHP: {Hp}\nLevel: {Level}\n");
            Drawer.Draw(ImagePath);
        }
    }
}
