using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = new int[] { 4, 3, 1, 2 };
            // int swap = 0;
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     while (arr[i] != i + 1)
            //     {
            //         var temp = arr[arr[i] - 1];
            //         arr[arr[i] - 1] = arr[i];
            //         arr[i] = temp;
            //         swap += 1;
            //     }
            // }

            // Console.WriteLine(swap);

            int[] a = new int[] { 3, 2, 1 };
            int n = a.Length;
            int swaps = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        int min = a[j];
                        int max = a[j + 1];
                        a[j] = max;
                        a[j + 1] = min;
                        swaps++;
                    }
                }
            }

        }
    }
}


//   int ans = 0;
//     for (int i = q.size() - 1; i >= 0; i--) {
//         if (q[i] - (i + 1) > 2) {
//             cout << "Too chaotic" << endl;
//             return;
//         }
//         for (int j = max(0, q[i] - 2); j < i; j++)
//             if (q[j] > q[i]) ans++;
//     }
//     cout << ans << endl;