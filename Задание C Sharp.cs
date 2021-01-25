using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        public static string[] YesNo = { "Yes", "No" };
        public delegate void MyDelegate(int[] Arr, int Counter);  
        public static MyDelegate[] MyDelegateArray = { Method, View };

        public static int[] MyArray = { 1, 2, 3, 4, 0, 5, 6, 7, 8, 9 };
        public static int M = 9;
        public static int Result = 1;

        public static void Method(int[] MyArray, int Counter)
        {
            Result *= MyArray[Counter++];
            MyDelegateArray[((Counter / M) + (1 + (((uint)(Result / (Result - 0.1))) * - 1))) % 2](MyArray, Counter);
        }

        public static void View(int[] MyArray, int Counter)
        {
            Console.WriteLine(YesNo[(uint)(Result / (Result - 0.1))]);
        }

        static void Main(string[] args)
        {
            Method(MyArray, 0);
            Console.ReadKey();
        }
    }
}
