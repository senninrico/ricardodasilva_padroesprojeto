using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facades
{
    class Distribuition
    {
        public void SeparateProduct()
        {
            Console.WriteLine("Send Product List To Distribuition");
        }

        public void SendProduct()
        {
            Console.WriteLine("Send Product");
        }
    }
}
