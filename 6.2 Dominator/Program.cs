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
            int[] B = new int[3];
            B[0] = 13;
            B[1] = 12;
            B[2] = 1;

            Console.WriteLine(solution(B));
            Console.Read();
        }
        static int solution(int[] A)
        {
            int[] B = A.Distinct().ToArray();
            int max = 0;
            int maxv = 0;


            var test = (from xx in A
                        group xx by xx into g
                        let count = g.Count()
                        select new { 
                        });

            for (int i = 0; i < B.Length; i++)
            {
                int c = A.Count(o => o == B[i]);
                if (max < c)
                {
                    max = c;
                    maxv = B[i];
                }
            }
            double tmp = (double)max/A.Length;
            if (tmp > 0.5)
                return Array.IndexOf(A, maxv);
            else
                return -1;

        }
    }
}
