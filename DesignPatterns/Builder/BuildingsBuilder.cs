using System.Text;

namespace DesignPatterns.Builder
{


    abstract class BuildingsBuilder

    {
        protected Building building;
        public Building Building
        {
            get { return building; }
        }
        public abstract void BuildAndar();
        public abstract void BuildPiso();
        public abstract void BuildParede();
        public abstract void BuildTeto();
    }



}
