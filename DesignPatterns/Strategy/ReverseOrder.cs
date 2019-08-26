using System;
using System.Collections;

namespace DesignPatterns.Strategy
{
    class ReverseOrder : ArrayOrder

    {
        public override void Order(ArrayList list)
        {
            {
                Console.WriteLine("Reverse Order");
                ArrayList listr = list;
                listr.Reverse();

             
            }
        }

    }



}
