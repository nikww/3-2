using System;
using System.Collections.Generic;

namespace ConsoleApp3
{

    public class HelloWorld
    {
        static void Main()
        {
            One one = new One(3, true);
            BaseClass base_1 = new One(4, true);
            Two two = new Two(3, 3, true);
            BaseClass base_2 = new Two(3, 4, true);
            Stepped stepped = new Stepped(3, true);
            BaseClass base_3 = new Stepped(4, true);

            BaseClass[] bases = {one, base_1, two, base_2, stepped, base_3 };
            for(int i = 0; i < 6; i++)
            {
                bases[i].mid_value();
                bases[i].array_output();
                Console.WriteLine();
            }

           

        }
    }


}