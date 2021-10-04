namespace hackerrank
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.fizzBuzz(n);
        }
        class Result
        {

            /*
             * Complete the 'fizzBuzz' function below.
             *
             * The function accepts INTEGER n as parameter.
             */

            public static void fizzBuzz(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    double remindarTothree = i % 3;

                    double remindarToFive = i % 5;


                    if (remindarToFive == 0 && remindarTothree == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    if (remindarTothree == 0 && remindarToFive > 0)
                    { Console.WriteLine("Fizz"); }
                    if (remindarToFive == 0 && remindarTothree > 0)
                    { Console.WriteLine("Buzz"); }
                    if (remindarToFive > 0 && remindarTothree > 0)
                    { Console.WriteLine(i); }
                }
                

            }

        }
    }
}
