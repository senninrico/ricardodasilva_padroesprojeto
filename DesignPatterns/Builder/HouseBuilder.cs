using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
     class HouseBuilder : BuildingsBuilder
    {
        public HouseBuilder()
        {
            building = new Building("Casa");
        }
        public override void BuildAndar()
        {
            building["andar"] = "1";
        }

        public override void BuildParede()
        {
            building["parede"] = "Modelo 2 ";
        }

        public override void BuildPiso()
        {
            building["piso"] = "Liso";
        }

        public override void BuildTeto()
        {
            building["teto"] = "Liso com Iluminação";
        }

    }
}
