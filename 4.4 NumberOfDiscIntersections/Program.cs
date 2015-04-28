using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4_NumberOfDiscIntersections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[6];
            A[0] = 1;
            A[1] = 5;
            A[2] = 2;
            A[3] = 1;
            A[4] = 4;
            A[5] = 0;
            Console.WriteLine(solution(A));
            Console.Read();
        }
        static int solution(int[] A)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i+1; j < A.Length; j++)
                {
                    if (i + A[i] > j - A[j])
                        count++;
                }
            }

            return count;
        }
    }
}
