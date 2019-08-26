using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    abstract class Food
    {
        public string NameFood;
        public double PriceFood;
        public List<Ingreditents> Ingreditents;


        public Food()
        {
            Ingreditents = new List<Ingreditents>();
        }

        public abstract void SetIngredients(Ingreditents ingreditents);
        public abstract void MakeFood();
        public void Preparete()
        {

                Console.WriteLine($"Making - {NameFood}");
            foreach (Ingreditents ingreditent in Ingreditents)
            {
                Console.WriteLine($"ADD {ingreditent.IngredientQuantity} - {ingreditent.IngredientName}");
                PriceFood += (ingreditent.IngredientPrice * ingreditent.IngredientQuantity);
            }

        }
    }
}
