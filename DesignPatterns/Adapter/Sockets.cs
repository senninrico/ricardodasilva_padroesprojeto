using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    class Sockets

    {
        protected string _name;
        protected string _comercialname;
        protected float _pinNumber;


        // Constructor

        public Sockets(string name)
        {
            this._name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("Socket: {0} ------ ", _name);
            
        }
    }
}


