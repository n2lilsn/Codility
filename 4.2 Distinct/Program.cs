using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[6];
            A[0] = 2;
            A[1] = 1;
            A[2] = 1;
            A[3] = 2;
            A[4] = 3;
            A[5] = 1;
            Console.WriteLine(solution(A));
            Console.Read();
        }
        static int solution(int[] A)
        {
            A.Distinct();
            if (A.Count() == 0)
            {
                return 0;
            }
            else
            {
                Array.Sort(A);
                int count = 1, p = A[0];
                for (int i = 1; i < A.Length; i++)
                {
                    if (p != A[i])
                    {
                        count++;
                        p = A[i];
                    }
                }
                return count;
            }
        }
    }
}
