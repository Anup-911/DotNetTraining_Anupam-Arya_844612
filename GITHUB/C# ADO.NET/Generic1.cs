using System;
using System.Collections.Generic;

namespace GenericAppli
{
    public class GenericArray<T>
    {
        private T[] array;
        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }
        public void SetValue(int index, T value)
        {
            array[index] = value;
        }
        public T GetValue(int index)
        {
            return array[index];
        }
    }
    
    public class Test
    {
        public static void Main(string[] arghhh)
        {
            GenericArray<int> a = new GenericArray<int>(5);
            for(int c = 0; c < 5; c++)
            {
                a.SetValue(c, c*5);
                Console.Write("{0} ", a.GetValue());
            }
            Console.WriteLine();
            
            for(int c = 0; c < 5; c++)
            {
                a.SetValue(c, (char)(c + 97));
                Console.Write("{0}", a.GetValue());
            }
            Console.ReadKey();
        }
    }
}