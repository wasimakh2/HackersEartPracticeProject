using System;

namespace HackersEartPracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b;
           int result= int.TryParse(a, out b)?int.Parse(a):0;


           for (int k = 1; k <=result; k++)
           {
               if (Check_Prime(k) == 1)
               {
                   Console.Write(k+" ");
               }
           }

           Console.ReadLine();
        }


        private static int Check_Prime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }
            if (i == number)
            {
                return 1;
            }
            return 0;
        }
    }
}

