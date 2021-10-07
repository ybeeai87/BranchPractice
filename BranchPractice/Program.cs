using System;

namespace BranchPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Number1(4, 3);
        }
        static bool Number1(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is larger than {num2}");
                return true;

            }
            return false;
        }

        static void Number2(int num1, int num2)
        {

        }

    }
}
