using System;
using Xunit;

namespace Interview
{
    public partial class UnitTest
    {
        [Fact]
        public void CountingValleys()
        {
            int n = 8;
            string s = "UDDDUDUU";

            int v = 0;
            int lvl = 0;
            char[] ar = s.ToCharArray();
            foreach (var c in ar)
            {
                if (c == 'U') lvl++;
                if (c == 'D') lvl--;

                if (lvl == 0 && c == 'U')
                    v++;
            }

            Console.Write(v);
        }

        [Fact]
        public void JumpingOnClouds()
        {
            var c = new int[] { 0, 0, 0, 0, 1, 0 };

            int jumps = -1;
            for (int i = 0; i < c.Length; i++)
            {
                jumps++;
                if (i < c.Length - 2 && c[i + 2] == 0)
                    i++;
            }

            Assert.Equal(3, jumps);
        }

        [Fact]
        public void RepeatedString()
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
            Assert.Equal(7, result);
        }
    }
}
