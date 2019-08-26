namespace DesignPatterns
{
    public class AnimalFactory
    {
        public static Animals Create(Animal animal)
        {
            return Create(animal.ToString());
        }

        private static Animals Create(string v)
        {
            switch (v)
            {
                default:
                case "Cachorro":
                    return new Dog();

                case "Gato":
                    return new Cat();

                case "Peixe":
                    return new Fish();

                case "Passarinho":
                    return new Bird();
            }
        }
    }
}
