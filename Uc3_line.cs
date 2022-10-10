using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputeProblem
{
    internal class Uc3_line
    {
        public static void Main2()
        {   //line end points
            Double x1, y1, x2, y2, L1;
            Console.WriteLine("Enter end points of line 01 i.e starting point (x1,y1)and ending point (x2,y2) values");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            //Length of a Line (L1)= sqrt((x2 - x1) ^ 2 + (y2- y1) ^ 2)
            L1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("linelength is " + L1);
            Double a1, b1, a2, b2, L2;
            Console.WriteLine("Enter end points of line 02 i.e starting point (x1,y1)and ending point (x2,y2) values");
            a1 = Convert.ToInt32(Console.ReadLine());
            b1 = Convert.ToInt32(Console.ReadLine());
            a2 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());
            //Length of a Line (L1)= sqrt((x2 - x1) ^ 2 + (y2- y1) ^ 2)
            L2 = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            Console.WriteLine("linelength is " + L2);
            if (L1 == L2)
            {
                Console.WriteLine("line 01 and line 02 are equal and has equal length");
            }
            else if (L1 > L2)
            {
                Console.WriteLine("line 01 is greater  than line 02 ");
            }
            else
            {
                Console.WriteLine("line 02 is greater  than line 01 ");
            }

        }
    }
}
