using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
   public class ProxyRFBR :IProxyRFBR
    {
        private FinancialRFBR _financialRFBR = new FinancialRFBR();

        public string PayLegal(double docValue, double taxValue, string documentId)
        {
          return _financialRFBR.PayLegal(docValue, taxValue, documentId);
        }

        public string PayPhysical(double docValue, double taxValue, string documentId)
        {
          return _financialRFBR.PayPhysical(docValue, taxValue, documentId);
        }
    }
}
