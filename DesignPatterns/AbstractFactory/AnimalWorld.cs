using System;

namespace DesignPatterns.AbstractFactory
{
    class AnimalWorld

    {
        private Air air;
        private Land land;
        private Aquatic aquatic;


        public AnimalWorld(ContinentFactory factory)
        {
            land = factory.CreateLand();
            aquatic = factory.CreateAquatic();
            air = factory.CreateAir();
        }

        internal void Animais()
        {
            Console.WriteLine($"Animal:{land.GetName()} -- Color:{land.GetColor()}");
            Console.WriteLine($"Animal:{air.GetName()} -- Color:{air.GetColor()}");
            Console.WriteLine($"Animal:{aquatic.GetName()} -- Color:{aquatic.GetColor()}");
            
        }
    }
}
