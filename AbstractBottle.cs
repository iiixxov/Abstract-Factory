using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    abstract class AbstractBottle
    {
        public abstract void Interact(AbstractWater water);
        public abstract void Interact(AbstractCover cover);
    }
}
