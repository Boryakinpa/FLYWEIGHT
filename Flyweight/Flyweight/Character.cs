using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal abstract class Character
    {
        protected string Name { get; set; } = string.Empty;
        protected string Class { get; set; } = string.Empty;
        protected string ImagePath { get; set; } = string.Empty;

        public abstract void ChangeLevel(int changeState);
        public abstract void ChangeHp(int changeState);

        protected Character(string _name, string _class, string _imagePath)
        {
            Name = _name;
            Class = _class;
            ImagePath = _imagePath;
        }
    }
}
