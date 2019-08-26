namespace DesignPatterns.Bridge
{
    class Firefox : Navegador
    {

        public Firefox(WebSite webSite) : base(webSite)
        {

        }

        public override void Access()
        {
            AccessNavegatior("Firefox");
            OpenUrl(website.GetType().Name);
        }
    }
}
