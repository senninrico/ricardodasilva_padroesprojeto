using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    interface IProxyRFBR
    {

        string PayPhysical(double docValue, double taxValue, string documentId);
        string PayLegal(double docValue, double taxValue, string documentId);
    }
}
