using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aba";
            long n = 10;


            char[] c = s.ToCharArray();
            long a = 0;

            long repeat = n / s.Length;
            long rest = n % s.Length;

            for (int i = 0; i < c.Length; i++)
                if (c[i] == 'a')
                    a++;

            long ar = 0;
            for (int j = 0; j < rest; j++)
                if (c[j] == 'a')
                    ar++;

            long result = a * repeat + ar;

            Console.WriteLine(result);
        }
    }
}
