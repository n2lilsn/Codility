using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[4];
            A[0] = 4;
            A[1] = 1;
            A[2] = 3;
            A[3] = 2;

            Console.WriteLine(solution(A));
            Console.Read();
        }
        static int solution(int[] A)
        {
            int N = A.Length;
            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                if (A[i] > N)
                    return 0;
                else
                {
                    B[A[i] - 1]++;
                    if (B[A[i] - 1] > 1)
                        return 0;
                }
            }
            return 1;
        }
    }
}
