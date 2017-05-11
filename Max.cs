using System;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] VariableIntegers = {1, 6, 2, 5, 9, 10};

            int Result = Max(VariableIntegers);
            Console.WriteLine(Result);
        }
        static int Max(int[] array)
        {
            int Output = -2000000000;
            foreach(int i in array)
            {
                if (i > Output)
                {
                    Output = i;
                }
            }
            return Output;
        }
    }
}
