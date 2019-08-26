using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public class Sites
    {
        private string url;
        private string nav;
        private Navegador Navegator;

        public Sites(string nav, string url)
        {
            this.url = url;
            this.nav = nav;
        }


        internal void Navegate()
        {
            switch (nav)
            {
                case "Firefox":
                    Navegator = new Firefox(new SiteAccess(url));
                    break;
                case "Chrome":
                default:
                    Navegator = new Chrome(new SiteAccess(url));
                    break;
                case "Edge":
                    Navegator = new Edge(new SiteAccess(url));
                    break;                                
            }

            Navegator.OpenUrl(url);
            Navegator.AccessNavegatior(nav);
        }
    }
}
