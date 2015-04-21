using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_MissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[6];
            int[] B = new int[2];
            int[] C = new int[1];

            A[0] = -1;
            A[1] = -1;
            A[2] = -1;
            A[3] = -1000000;
            A[4] = -1;
            A[5] = -1;

            B[0] = 1;
            B[1] = 2;

            C[0] = int.MinValue;

            Console.WriteLine(solution(A));
            Console.Read();
        }
        static int solution(int[] A)
        {
            Array.Sort(A);
            int p = A[0];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != p)
                {
                    if (A[i] != p + 1)
                        return ++p;
                    else
                        p++;
                }
            }

            return A.Min() == int.MinValue ? int.MinValue : (A.Min() - 1);
        }
    }
}
