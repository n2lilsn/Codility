using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_MaxProductOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[6];
            A[0] = -3;
            A[1] = 1;
            A[2] = 2;
            A[3] = -2;
            A[4] = 5;
            A[5] = 6;
            Console.WriteLine(solution(A));
            Console.Read();
        }
        static int solution(int[] A)
        {
            int max = int.MinValue;
            int c =A.Length / 3;
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < ; j++)
                {
                    
                }
                int t = A[i] * A[i + 1] * A[i + 2];
                if (max < t)
                    max = t;
            }
            return max;
        }
    }
}
