using System;
using System.Collections.Generic;
using Xunit;

namespace Interview
{
    public partial class UnitTest
    {
        [Fact]
        public void Hourglasses()
        {
            int[,] arr = new int[,]
            {
                {1, 1, 1, 0, 0, 0},
                {0, 1, 0, 0, 0, 0},
                {1, 1, 1, 0, 0, 0},
                {0, 0, 2, 4, 4, 0},
                {0, 0, 0, 2, 0, 0},
                {0, 0, 1, 2, 4, 0}
            };

            var sumList = new List<int>();
            //sum of single hourglass & fill sumList
            for (int row = 0; row <= 3; row++)
                for (int col = 0; col <= 3; col++)
                {
                    int sum = 0;
                    sum += arr[row, col];
                    sum += arr[row, col + 1];
                    sum += arr[row, col + 2];
                    sum += arr[row + 1, col + 1];
                    sum += arr[row + 2, col];
                    sum += arr[row + 2, col + 1];
                    sum += arr[row + 2, col + 2];
                    sumList.Add(sum);
                }

            //find max sum
            int maxSum = sumList[0];
            foreach (var item in sumList)
                if (item > maxSum)
                    maxSum = item;

            Assert.Equal(19, maxSum);
        }


        [Fact]
        public void LeftRotation()
        {
            int n = 5;
            int d = 4;

            int[] a = new int[n];
            int[] left = new int[a.Length];

            for (int i = 0; i < n; i++)
            {
                int diff = 0;
                if (n - i > d)
                {
                    diff = n - (d + i);
                    left[i] = a[n - diff];
                }
                else
                {
                    diff = n - d;
                    left[i] = a[i - diff];

                }
            }
        }

        [Fact]
        public void MinimumSwaps()
        {
            int[] arr = new int[] { 4, 3, 1, 2 };
            int swap = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i] != i + 1)
                {
                    var temp = arr[arr[i] - 1];
                    arr[arr[i] - 1] = arr[i];
                    arr[i] = temp;
                    swap += 1;
                }
            }

            Assert.Equal(3, swap);
        }
    }
}