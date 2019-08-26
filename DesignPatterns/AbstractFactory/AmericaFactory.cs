namespace DesignPatterns.AbstractFactory
{
    class AmericaFactory : ContinentFactory

    {

        string defaultColor = "Green";
        public override Air CreateAir()
        {
            return new Bird("Andorinha",defaultColor) ;
        }

        public override Aquatic CreateAquatic()
        {
            return new Fish("Pintado",defaultColor);
        }

        public override Land CreateLand()
        {
            return new Cat("Persa",defaultColor);
        }
    }
}
