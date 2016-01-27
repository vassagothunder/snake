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
            point p1 = new point(1,3,'*');
           /* p1.x = 1;
            p1.y = 3;
            p1.sym = '*';*/
            p1.Draw();

            point p2 = new point(4,5,'x');
      /*      p2.x = 4;
            p2.y = 5;
            p2.sym = 'x';*/
            p2.Draw();


            /*  int x1 = 1;
              int y1 = 3;
              char sym1 = '*';
              Draw(x1, y1, sym1);

              int x2 = 4;
              int y2 = 5;
              char sym2 = 'x';

              Draw(x2, y2, sym2); */

            Console.ReadLine();


        }

  
    }
}
