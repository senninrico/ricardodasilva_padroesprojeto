namespace DesignPatterns.Bridge
{
    class Chrome : Navegador
    {

        public Chrome(WebSite webSite) : base(webSite)
        {

        }

        public override void Access()
        {
            AccessNavegatior("Chrome");
            OpenUrl(website.GetType().Name);
        }
    }
}
