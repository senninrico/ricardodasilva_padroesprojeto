using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class FinancialRFBR : IProxyRFBR
    {
        public string PayLegal(double docValue, double taxValue, string documentId)
        {
            Console.WriteLine("Pagando Juridico");
            return "Paid";
        }

        public string PayPhysical(double docValue, double taxValue, string documentId)
        {
            Console.WriteLine("Pagando Fisico");
            return "Paid";
        }
    }
}
