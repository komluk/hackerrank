using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine(swap);
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