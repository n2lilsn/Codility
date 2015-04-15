using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[4];
            A[0] = 2;
            A[1] = 3;
            A[2] = 1;
            A[3] = 5;

            Console.WriteLine(solution(A));
            Console.Read();
        }
        static int solution(int[] A)
        {
            int min = int.MaxValue, suma = 0, lewa = 0;
            suma = A.Sum();
            for (int i = 1; i < A.Length; i++)
            {
                lewa += A[i - 1];
                int tmp = Math.Abs(lewa - (suma - lewa));
                if (tmp < min)
                    min = tmp;
            }
            return min;
        }
    }
}
