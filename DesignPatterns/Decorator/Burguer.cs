using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    class Burguer : Food
    {
        public Burguer(string Name)
        {
            base.NameFood = !string.IsNullOrEmpty(Name) ? Name : this.GetType().Name;
            base.PriceFood = 1.00;
        }
        public override void MakeFood()
        {
            Console.WriteLine("Make Burguer");

            base.Preparete();
            Console.WriteLine("Make Burguer - End");
            Console.WriteLine($"Total:{ PriceFood}");
        }

        public override void SetIngredients(Ingreditents ingreditents)
        {
            this.Ingreditents.Add(ingreditents);
        }
    }
}
