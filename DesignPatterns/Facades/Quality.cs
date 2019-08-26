using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facades
{
    class Quality
    {
        public void CheckQuality()
        {
            Console.WriteLine("Checking quality of product");

        }

        public void ValidateQuality()
        {
            Console.WriteLine("Validate Quality");
        }
    }
}
