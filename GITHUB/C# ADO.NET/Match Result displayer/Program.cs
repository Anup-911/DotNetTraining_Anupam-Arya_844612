using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace lower
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>(6);
            List<int> b = new List<int>(3);
            a.Add(5);
            a.Add(6);
            a.Add(6);
            b.Add(9);
            b.Add(3);
            b.Add(5);
            Zen z = new Zen();
            Console.WriteLine(z.Zeher(a, b));
            Console.ReadKey();

        }
    }
    class Zen
    { 
        public List<int> Zeher(List<int> a, List<int> b)
        {
            List<int> res = new List<int>(2);
            int x = 0;
            int y = 0;
            for (int i = 0; i < 3; i++)
            {
                if (a.ElementAt(i) > b.ElementAt(i))
                {
                    x++;
                }
                else if (a.ElementAt(i) < b.ElementAt(i))
                {
                    y++;
                }
            }
            res.Add(x);
            res.Add(y);
            return res;
        }
    }
}