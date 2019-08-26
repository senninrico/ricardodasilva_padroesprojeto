namespace DesignPatterns.AbstractFactory
{
    class AfricaFactory : ContinentFactory

    {

        string defaultColor = "Yellow";
        public override Air CreateAir()
        {
            return new Bird("Andorinha Africana ", defaultColor);
        }

        public override Aquatic CreateAquatic()
        {
            return new Fish("Pintado Africano", defaultColor);
        }

        public override Land CreateLand()
        {
            return new Cat("Persa Africano", defaultColor);
        }
    }
}
