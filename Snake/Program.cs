using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {


            Point p1 = new Point(4, 2, '@');
            p1.Draw();

            Point p2 = new Point(5, 3, '#');
            p2.Draw();

            Point p3 = new Point(6, 4, '$');
            p3.Draw();

            Point p4 = new Point(7, 5, '%');
            p4.Draw();

            Point p5 = new Point(8, 6, '^');
            p5.Draw();

            Point p6 = new Point(9, 7, '&');
            p6.Draw();

            Point p7 = new Point(10, 8, '*');
            p7.Draw();

            Point p8 = new Point(11, 9, '+');
            p8.Draw();

            Point p9 = new Point(12, 10, '=');
            p9.Draw();


            List<int> numList = new List<int>();
            numList.Add(0);                             //Добавление элемента + значение в круглых скобках
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];                         //Обращение к элементу по номеру в квадратных скобках
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
                {
                Console.WriteLine(i);

                }

            // numList.Remove(0);

 



            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            List<Point> epList = new List<Point>();
            epList.Add(p1);
            epList.Add(p2);
            epList.Add(p3);
            epList.Add(p4);
            epList.Add(p5);
            epList.Add(p6);
            epList.Add(p7);
            epList.Add(p8);
            epList.Add(p9);

            List<int> eNum = new List<int>();
            eNum.Add(0);
            eNum.Add(1);
            eNum.Add(2);
            eNum.Add(3);
            eNum.Add(4);
            eNum.Add(5);
            eNum.Add(6);
            eNum.Add(7);
            eNum.Add(8);



            Console.ReadLine();
        }

       

    }
}
;