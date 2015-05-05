using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4_StoneWall
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] H = new int[9];
            H[0] = 8;
            H[1] = 8;
            H[2] = 5;
            H[3] = 7;
            H[4] = 9;
            H[5] = 8;
            H[6] = 7;
            H[7] = 4;
            H[8] = 8;
            int[] A = new int[4];
            A[0] = 2;
            A[1] = 1;
            A[2] = 5;
            A[3] = 2;
            Console.WriteLine(solution(A));
            Console.Read();

        }
        static int solution(int[] A)
        {
            int count = 0;
            Stack<int> stos = new Stack<int>();
            stos.Push(A[0]);

            for (int i = 1; i < A.Length; i++)
            {
                if (stos.Min() <= A[i])
                {
                    stos.Push(A[i]);
                }
                else if(stos.Min() > A[i])
                {
                    count += stos.Distinct().Count();
                    stos.Clear();
                    stos.Push(A[i]);
                }
            }

            return count+stos.Distinct().Count();
        }
    }
}
