namespace DesignPatterns.Bridge
{
    abstract class Navegador
    {
        protected WebSite website;

        public Navegador(WebSite website)
        {
            this.website = website;
        }

        public void AccessNavegatior(string nav)
        {
            website.AccessNavegatior(nav);
        }
        public void OpenUrl(string url)
        {
            website.AccessUrl(url);
        }

        public abstract void Access();
    }
}
