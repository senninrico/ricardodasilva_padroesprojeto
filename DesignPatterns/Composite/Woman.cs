using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    class Woman : People
    {

        private List<People> peoples;
        public Woman()
        {
            base.SetGender("Woman");
            this.peoples = new List<People>();
        }

        public void AddFiliation(People c)
        {
            base.SetLevel("Mother");
            peoples.Add(c);

        }

        public override void Display()
        {

            if (peoples.Count > 0)
            {

                Console.WriteLine("- Woman - Mother");
                Console.WriteLine("---Filiation---");
            }
            else
            {

                Console.WriteLine("- Woman");
            }

            foreach (People people in peoples)
            {

                Console.WriteLine($"-- {people.Gender}");
            }
        }

        public void RemoveFiliation(People c)
        {
            throw new NotImplementedException();
        }
    }
}
