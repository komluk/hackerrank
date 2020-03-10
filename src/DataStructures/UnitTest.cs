using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DataStructures
{
    public class UnitTest
    {
        [Fact]
        public void MatchingStrings()
        {
            string[] strings = new string[] { "aba", "baba", "aba", "xzxb" };

            string[] queries = new string[] { "aba", "xzxb", "ab" };


            var sList = strings.ToList();
            int[] ar = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                int count = strings.Count(x => x == queries[i]);
                ar[i] = count;
            }
        }

        [Fact]
        public void CountSwaps()
        {
            int[] a = new int[] { 3, 2, 1 };
            int n = a.Length;
            int swaps = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int left = a[j];
                        int right = a[j + 1];
                        a[j] = right;
                        a[j + 1] = left;
                        swaps++;
                    }
                }
            }
        }

    }
}
