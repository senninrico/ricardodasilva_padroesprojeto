using System;

namespace DesignPatterns.Flyweight
{
    class Archive
    {
        public string name;

        public Archive(string name)
        {
            this.name = name;
        }

        public void MoveTo(string destiny)
        {
            Console.WriteLine($"Archive {name} is moved to {destiny}");
        }
    }
}
