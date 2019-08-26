using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{

    class OrdenedArray

    {
        private ArrayList _list = new ArrayList();
        private ArrayOrder _arrayOrder;

        public void SetOrderStrategy(ArrayOrder ordenedArray)
        {
            this._arrayOrder = ordenedArray;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Order()
        {
            _arrayOrder.Order(_list);

            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }



}
