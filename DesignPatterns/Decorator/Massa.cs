using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    class Massa : Food
    {
        public Massa(string Name)
        {
            base.NameFood = !string.IsNullOrEmpty(Name)?Name :this.GetType().Name;
            base.PriceFood = 3.00;
        }
        public override void MakeFood()
        {
            Console.WriteLine("Make Massa");
        }

        public override void SetIngredients(Ingreditents ingreditents)
        {
            this.Ingreditents.Add(ingreditents);
        }
    }
}
