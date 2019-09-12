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
            int x1 = 6;
            int y1 = 3;
            char sym1 = '*';

            Console.SetCursorPosition(x1, y1);
            Console.Write( sym1 );


            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Console.SetCursorPosition(x2, y2);
            Console.Write( sym2 );


            int x3 = 6;
            int y3 = 7;
            char sym3 = '@';

            Console.SetCursorPosition(x3, y3);
            Console.Write(sym3);



            Console.ReadLine();
  
        }
    }
}
