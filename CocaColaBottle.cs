using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + " interacts with " + water);
        }

        public override void Interact(AbstractCover cover)
        {
            Console.WriteLine(this + " interacts with " + cover);
        }
    }
}
