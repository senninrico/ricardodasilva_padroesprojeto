using System;

namespace DesignPatterns.AbstractFactory
{
    abstract class Animal
    {
        public string AnimalName { get; private set; }

        public string  AnimalColor { get; private set; }


        protected Animal(string name, string color)
        {
            this.AnimalName = name;
            this.AnimalColor = color;
        }

        public abstract string GetColor();
        public abstract string GetName();


    }
}
