using System;

namespace JenkinsBuildTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = AddTwoNumbers(1, 2);

            Console.WriteLine(i);
        }

        private static int AddTwoNumbers(int i, int j)
        {
            return i + j;
        }
    }
}
