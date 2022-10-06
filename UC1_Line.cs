using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputeProblem
{
    class UC1_Line
    {
        public static void Main1()
        {   //line end points
            Double x1,y1,x2,y2,L1 ;
            Console.WriteLine("enter end points of line 01 starting point (x1,y1)and ending point (x2,y2) values");  
            x1=Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
           //Length of a Line (L1)= sqrt((x2 - x1) ^ 2 + (y2- y1) ^ 2)
            L1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("linelength is " + L1);
          }
        
    }
}
