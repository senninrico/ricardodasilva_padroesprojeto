using System;

namespace DesignPatterns.AbstractFactory
{
    class Land : Animal
    {
        public Land(string name, string color) : base(name, color)
        {

        }
        public override string GetColor()
        {
            return base.AnimalColor;
        }
        public override string GetName()
        {
            return base.AnimalName;
        }
    }
}
