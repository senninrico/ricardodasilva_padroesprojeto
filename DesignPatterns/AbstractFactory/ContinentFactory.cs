using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    abstract class ContinentFactory
    {
        public abstract Land CreateLand();
        public abstract Air CreateAir();
        public abstract Aquatic CreateAquatic();
    }
}
