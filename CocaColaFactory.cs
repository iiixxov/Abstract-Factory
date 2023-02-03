using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class CocaColaFactory : AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new CocaColaCover();
        }
    }
}
