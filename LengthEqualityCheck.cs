using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComprasionComputationOops
{
    public class LengthEqualityCheck
    {
        public void CheckEqualLength()
        {
            double Lengthofline1 = 0;
            double Lengthofline2 = 0;

            Console.WriteLine("Enter first line points: ");
            Console.WriteLine("Enter the first point coordinate: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second point coordinate: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second line points: ");
            Console.WriteLine("Enter the first point coordinate: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second point coordinate: ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());

            Lengthofline1 = Math.Sqrt(Math.Pow((y2 - y1), 2) + Math.Pow((x2 - x1), 2));
            Lengthofline2 = Math.Sqrt(Math.Pow((y4 - y3), 2) + Math.Pow((x4 - x3), 2));

            Console.WriteLine("The Length of Line1 :" + Lengthofline1);
            Console.WriteLine("The Length of Line2 :" + Lengthofline2);

            if(Lengthofline2 == Lengthofline1)
            {
                Console.WriteLine("Both lines are equal.");
            }
            else
            {
                Console.WriteLine("Both lines are not equal.");
            }
        } 
    }
}
