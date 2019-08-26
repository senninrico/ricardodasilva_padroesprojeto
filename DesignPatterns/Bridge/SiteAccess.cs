using System;

namespace DesignPatterns.Bridge
{
    class SiteAccess : WebSite
    {
        private string url;

        public SiteAccess(string url)
        {
            this.url = url;
        }

        public void AccessNavegatior(string navegador)
        {
            Console.WriteLine(string.Format("Acessando pelo: {0}", navegador));
        }

        public void AccessUrl(string url)
        {
            Console.WriteLine(string.Format("Url: {0}", url));
        }
    }
}
