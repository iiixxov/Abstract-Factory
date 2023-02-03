using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWater();
        public abstract AbstractBottle CreateBottle();
        public abstract AbstractCover CreateCover();
    }
}
