using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizontalLine hLine = new HorizontalLine(5, 10, 8, '+');
            hLine.Draw();

            Console.ReadLine();
        }

       

    }
}
;