using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    class ParkingBuilder : BuildingsBuilder
    {
        public ParkingBuilder()
        {
            building = new Building("Estacionamento");
        }
        public override void BuildAndar()
        {
            building["andar"] = "1";
        }

        public override void BuildParede()
        {
            building["parede"] = "Sem paredes";
        }

        public override void BuildPiso()
        {
            building["piso"] = "Asfaltico";
        }

        public override void BuildTeto()
        {
            building["teto"] = "Cobertura";
        }
    }
}
