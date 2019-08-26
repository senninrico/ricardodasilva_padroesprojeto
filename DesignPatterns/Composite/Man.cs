using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    class Man : People
    {
        public Man()
        {
            base.SetGender("Man");
        }

        public override void Display()
        {
            Console.WriteLine("- Man");
        }

    }

}
