using System;
using System.Collections.Generic;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            int BobSalary = 10000;
            int SallySalary = 12000;
            int BryceSalary = 13200;

            List<int> CurrentSalaries = new List<int>(); 

            CurrentSalaries.Add(BobSalary);
            CurrentSalaries.Add(SallySalary);
            CurrentSalaries.Add(BryceSalary);

            List<int> NewSalaries = new List<int>();
            NewSalaries = TenPercentRaise(CurrentSalaries);
        }
        static List<int> TenPercentRaise(List<int> list)
        {
            decimal update = 0.0;
            foreach (int i in list)
            {
                update = i * 0.1;
                i = i + update;
            }
            return list;
        } 
    }
}