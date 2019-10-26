using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProblemSolving
{
    public class UnitTest1
    {
        [Fact]
        public void DiagonalDifference()
        {
            var arr = new List<List<int>>();
            arr.Add(new List<int>() { 1, 2, 3 });
            arr.Add(new List<int>() { 4, 5, 6 });
            arr.Add(new List<int>() { 7, 8, 9 });

            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    if (i == j)
                        sum1 += arr[i][j];

                    if (i + j == arr[i].Count - 1 || i + j == arr[j].Count - 1)
                        sum2 += arr[i][j];
                }
            }
            int result = Math.Abs(sum1 - sum2);
        }

        [Fact]
        public void PlusMinus()
        {
            int[] arr = new int[] { 1, 2, 3, 5 };

            int positive = 0;
            int negative = 0;
            int zero = 0;

            int total = arr.Length;

            for (int i = 0; i < total; i++)
            {
                if (arr[i] > 0)
                    positive++;
                else if (arr[i] < 0)
                    negative++;
                else
                    zero++;
            }

            Console.WriteLine((decimal)positive / total);
            Console.WriteLine((decimal)negative / total);
            Console.WriteLine((decimal)zero / total);
        }

        [Fact]
        public void Staircase()
        {
            int n = 6;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j >= n - 1)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        [Fact]
        public void MiniMaxSum()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            long min = arr[0];
            long max = arr[0];
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (min > arr[i])
                    min = arr[i];
                if (max < arr[i])
                    max = arr[i];
            }

            Console.Write(sum - max);
            Console.Write(" ");
            Console.Write(sum - min);
        }

        [Fact]
        public void BirthdayCakeCandles()
        {
            int[] ar = new int[] { 4, 3, 4, 1 };
            int number = 0;
            int max = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (max < ar[i])
                    max = ar[i];
            }

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == max)
                    number++;
            }

            Assert.Equal(2, number);
        }

        [Fact]
        public void TimeConversion()
        {
            string s = "07:45:22PM";

            int hh;
            int mm;
            int ss;
            string[] arr = s.Split(new string[] { ":", "AM", "PM" }, StringSplitOptions.RemoveEmptyEntries);

            int.TryParse(arr[0], out hh);
            int.TryParse(arr[1], out mm);
            int.TryParse(arr[2], out ss);

            if (s.Contains("PM") && hh != 12) hh += 12;
            if (s.Contains("AM") && hh == 12) hh = 0;

            string result = hh < 10 ? $"0{hh}:" : $"{hh}:";
            result += mm < 10 ? $"0{mm}:" : $"{mm}:";
            result += ss < 10 ? $"0{ss}" : $"{ss}";

            Assert.Equal("19:45:22", result);
        }
    }
}
