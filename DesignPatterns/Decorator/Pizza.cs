using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    class Pizza : Food
    {
        public Pizza(string Name)
        {
            base.NameFood = !string.IsNullOrEmpty(Name) ? Name : this.GetType().Name;
            base.PriceFood = 2.00;
        }
        public override void MakeFood()
        {
            Console.WriteLine("Make Pizza");
            base.Preparete();
            Console.WriteLine("Make Pizza - End");
            Console.WriteLine($"Total:{ PriceFood}");

        }

        public override void SetIngredients(Ingreditents ingreditents)
        {
            this.Ingreditents.Add(ingreditents);
        }
    }
}
