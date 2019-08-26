using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    class ComercialBuilder : BuildingsBuilder
    {
        public ComercialBuilder()
        {
            building = new Building("Comercial");
        }
        public override void BuildAndar()
        {
            building["andar"] = "1";
        }

        public override void BuildParede()
        {
            building["parede"] = "Modelo 1 - Frente aberta";
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
