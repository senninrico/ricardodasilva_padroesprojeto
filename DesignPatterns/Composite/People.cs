using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    abstract class People
    {
        public string Gender;
        private string Level;
       

        public People(string gender)
        {
            this.Gender = gender;
        }

        public People()
        {
        }        
      
        public abstract void Display();
        public void SetGender(string gender)
        {
            this.Gender = gender;
        }
        public void SetLevel(string level)
        {
            this.Level = level;
        }
    }


   
   
}
