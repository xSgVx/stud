using System;
using System.Text;

namespace for_testing_v3
{

    class Program
    {


        public static void Print(params object[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");
                Console.WriteLine(array.GetValue(i));
            }
        }



        public static void Main()
        {
            Print(1, 2);
            Print("a", 'b');
            Print(1, "a");
            Print(true, "a", 1);
        }

    }
}



