using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3

{
    class Program
    {
        static int Find(int value, int[] arr)
        {
            int i = 0;
            while (arr[i] != value)
            {
            if (++i > arr.Length)
            throw new ArgumentException();
            }
            return i;
        }
        static void Main()
        {
            Console.WriteLine(Find(3, new int[] {5, 4, 3, 2, 1 }));
        }
    }
}
