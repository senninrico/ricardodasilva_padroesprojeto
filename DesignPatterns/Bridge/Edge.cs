namespace DesignPatterns.Bridge
{
    class Edge : Navegador
    {

        public Edge(WebSite webSite) : base(webSite)
        {

        }

        public override void Access()
        {
            AccessNavegatior("Edge");
            OpenUrl(website.GetType().Name);
        }
    }
}
