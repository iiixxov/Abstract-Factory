﻿using System;

namespace Abstract_Factory
{
    class Program
    {
        public static void Main()
        {
            Client client = null;

            client = new Client(new CocaColaFactory());
            client.Run();
            
            client = new Client(new PepsiFactory());
            client.Run();
        }
    }
}
