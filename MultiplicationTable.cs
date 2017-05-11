using System;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            int Parameter = 5;

            Table(Parameter);
        }
        static void Table(int n)
        {
            int Output;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Output = i * j;
                    if (Output > 99)
                    {
                       Console.WriteLine(" " + Output); 
                    }
                    else if (Output > 9)
                    {
                        Console.WriteLine("  " + Output);
                    }
                    else
                    {
                        Console.WriteLine("   " + Output);
                    }
                }
            }
        }
    }
}
