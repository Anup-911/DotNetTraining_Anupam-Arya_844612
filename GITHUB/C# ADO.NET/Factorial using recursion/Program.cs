using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            Console.WriteLine("Factorial of {0} is: {1}", a, p.Fact(a));
            Console.ReadKey();
        }
        public int Fact(int x)
        {
            int fact;
            if(Fact(x) == 1)
            {
                fact = 1;
            }
            else
            {
                fact = x * (Fact(x) - 1);
            }
            return fact;
        }
    }
}
