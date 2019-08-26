using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    class SchoolBuilder : BuildingsBuilder
    {

        public SchoolBuilder()
        {
            building = new Building("Escola");
        }
        public override void BuildAndar()
        {
            building["andar"] = "2";
        }

        public override void BuildParede()
        {
            building["parede"] = "Modelo 4 ";
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
