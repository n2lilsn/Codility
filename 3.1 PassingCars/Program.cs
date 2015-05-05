using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_PassingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];

            A[0] = 0;
            A[1] = 1;
            A[2] = 0;
            A[3] = 1;
            A[4] = 1;

            Console.WriteLine(solution(A));
            Console.Read();
        }
        static int solution(int[] A)
        {
            int count = 0, l = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                    l++;
                else if (A[i] == 1)
                    count += l * 1;
                if (count > 1000000000)
                    return -1;
            }
            return count;
        }
    }
}
