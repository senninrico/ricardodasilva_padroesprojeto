using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facades
{
    class Financial
    {

        public void PrintInvoice(){
            Console.WriteLine("Print invoice");

        }

        public void FinancialReg()
        {
            Console.WriteLine("Create Financial Registry");
        }



    }
}
