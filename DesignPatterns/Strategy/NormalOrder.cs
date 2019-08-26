using System;
using System.Collections;

namespace DesignPatterns.Strategy
{
    class NormalOrder : ArrayOrder

    {
        public override void Order(ArrayList list)
        {
            Console.WriteLine("Normal Order");


        }
    }



}
