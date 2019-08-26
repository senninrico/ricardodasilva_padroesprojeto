using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    class Ingreditents :Food
    {
        public double IngredientPrice;
        public double IngredientQuantity;
        public string IngredientName;

        public override void MakeFood()
        {
        
        }

        public override void SetIngredients(Ingreditents ingreditents)
        {
          
        }
    }

    class Cheese : Ingreditents
    {
        public Cheese( string name,double quantity, double price)
        {
            base.IngredientQuantity = quantity;
            base.IngredientName = name;
            base.IngredientPrice = price;
        }      
    }

    class Bread : Ingreditents
    {
        public Bread( string name, double quantity, double price)
        {
            base.IngredientQuantity = quantity;
            base.IngredientName = name;
            base.IngredientPrice = price;
        }      
    }

    class Steak : Ingreditents
    {
        public Steak( string name, double quantity, double price)
        {
            base.IngredientQuantity = quantity;
            base.IngredientName = name;
            base.IngredientPrice = price;
        }      
    }

    class Salada : Ingreditents
    {
        public Salada( string name, double quantity, double price)
        {
            base.IngredientQuantity = quantity;
            base.IngredientName = name;
            base.IngredientPrice = price;
        }      
    }
        class Sauce : Ingreditents
    {
        public Sauce( string name, double quantity, double price)
        {
            base.IngredientQuantity = quantity;
            base.IngredientName = name;
            base.IngredientPrice = price;
        }      
    }


    class Pasta : Ingreditents
    {
        public Pasta(string name, double quantity, double price)
        {
            base.IngredientQuantity = quantity;
            base.IngredientName = name;
            base.IngredientPrice = price;
        }
    }


    class Condiments : Ingreditents
    {
        public Condiments(string name, double quantity, double price)
        {
            base.IngredientQuantity = quantity;
            base.IngredientName = name;
            base.IngredientPrice = price;
        }
    }

    class Specialities : Ingreditents
    {
        public Specialities(string name, double quantity, double price)
        {
            base.IngredientQuantity = quantity;
            base.IngredientName = name;
            base.IngredientPrice = price;
        }
    }

    class Batter : Ingreditents
    {
        public Batter(string name, double quantity, double price)
        {
            base.IngredientQuantity = quantity;
            base.IngredientName = name;
            base.IngredientPrice = price;
        }
    }



}
