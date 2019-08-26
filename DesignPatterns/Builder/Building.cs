using System;
using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    class Building

    {
        private string _buildingType;
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();

       
        public Building(string buildingType)
        {
            this._buildingType = buildingType;
        }

       
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Tipo de Edificio: {0}", _buildingType);
            Console.WriteLine(" Andares : {0}", _parts["andar"]);
            Console.WriteLine(" Piso : {0}", _parts["piso"]);
            Console.WriteLine(" Parede: {0}", _parts["parede"]);
            Console.WriteLine(" Teto : {0}", _parts["teto"]);
        }
    }



}
