using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleMathClient.MathServiceReference;

namespace ConsoleMathClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press <Enter> to run the client....");
            Console.ReadLine();

            MathClient math = new MathClient();
            Console.WriteLine("Add of 3 and 2 = {0}", math.Add(3, 2));
            Console.WriteLine("Sub of 3 and 2 = {0}", math.Sub(3, 2));

            Complex no1 = new Complex();
            no1.Real = 3;
            no1.Imaginary = 3;

            Complex no2 = new Complex();
            no2.Real = 2;
            no2.Imaginary = 2;

            Complex result = new Complex();
            result = math.AddComplexNo(no1, no2);
            Console.WriteLine("Add of 3+3i and 2+2i = {0}+{1}i", result.Real, result.Imaginary);

            result = math.SubComplexNo(no1, no2);
            Console.WriteLine("Sub of 3+3i and 2+2i = {0}+{1}i", result.Real, result.Imaginary);

            Console.ReadLine();
        }
    }
}
