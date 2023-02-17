using LineComprasionComputationOops;

namespace LineComparisionComputationOops
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation.");

            LengthComputation LineLength = new LengthComputation();
            LineLength.CalculateLength();
        }
    }
}