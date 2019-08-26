using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    class Build
    {
        public void Construct(BuildingsBuilder buildingsBuilder)
        {
            buildingsBuilder.BuildPiso();
            buildingsBuilder.BuildAndar();
            buildingsBuilder.BuildParede();
            buildingsBuilder.BuildTeto();

        }
    }
}
