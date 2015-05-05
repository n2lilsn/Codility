using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_Dominator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[8];
            A[0] = 3;
            A[1] = 4;
            A[2] = 3;
            A[3] = 2;
            A[4] = 3;
            A[5] = -1;
            A[6] = 3;
            A[7] = 3;

            int[] B = new int[1];
            B[0] = 3;

            Console.WriteLine(solution(A));
            Console.Read();
        }
        static int solution(int[] A)
        {
            if (A.Count() == 0)
                return -1;

            Dictionary<int, int> counts = A.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

            var max = counts.Max(o => o.Value);
            int value = counts.First(o => o.Value == max).Key;

            return ((double)max / A.Length) > 0.5 ? Array.IndexOf(A, value) : -1;
        }
    }
}