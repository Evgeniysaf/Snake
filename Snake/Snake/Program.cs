using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {


            Point p1 = new Point( 1, 3, '*');
         
            p1.Drow();

            Point p2 = new Point(4, 5, '#');

            p2.Drow();


            Point p3 = new Point(6, 7, '@');

            p3.Drow();

            Point p4 = new Point(3, 2, '%');

            p4.Drow();

            Point p5 = new Point(5, 6, '&');

            p5.Drow();






            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);
            numList.Add(4);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            int a = numList[3];
            int b = numList[4];

            foreach(int i in numList)
            {
                Console.WriteLine(i);

            }

            List<Point> Plist = new List<Point>();
            Plist.Add(p1);
            Plist.Add(p2);

            List<Point> dzList = new List<Point>();
            dzList.Add(p3);
            dzList.Add(p4);
            dzList.Add(p5);
      


            Console.ReadLine();
        }
    }
}
