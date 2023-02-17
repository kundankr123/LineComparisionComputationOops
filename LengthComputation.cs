using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComprasionComputationOops
{
    public class LengthComputation
    {
        public void CalculateLength()
        {
            double Lengthofline = 0;
            Console.WriteLine("Enter the first point coordinate: ");
            int x1=Convert.ToInt32(Console.ReadLine());
            int y1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second point coordinate: ");
            int x2=Convert.ToInt32(Console.ReadLine());
            int y2=Convert.ToInt32(Console.ReadLine());

            Lengthofline = Math.Sqrt(Math.Pow((y2 - y1), 2) + Math.Pow((x2 - x1), 2));

            Console.WriteLine("The length of line segment is: " + Lengthofline);
        }
    }
}
