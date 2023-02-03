﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;
        private AbstractCover cover;
        public Client(AbstractFactory factory)
        {
            // Абстрагирование процессов инстанцирования.
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
            cover = factory.CreateCover();
        }
        public void Run()
        {
            // Абстрагирование вариантов использования.
            bottle.Interact(water);
            bottle.Interact(cover);
        }
    }
}
