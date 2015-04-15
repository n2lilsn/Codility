using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 8;
            int[] A = new int[N];
            A[0] = 1;
            A[1] = 3;
            A[2] = 1;
            A[3] = 4;
            A[4] = 2;
            A[5] = 3;
            A[6] = 5;
            A[7] = 4;
            Console.WriteLine(solution(5, A));
            Console.Read();
        }
        static int solution(int X, int[] A)
        {
            int[] t = new int[X];
            int count = 0;
            int max = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= X)
                {
                    if (t[A[i] - 1] > 0)
                    {
                        if (t[A[i] - 1] > i + 1)
                        {
                            t[A[i] - 1] = i + 1;
                            if (max < i)
                                max = i;
                        }
                    }
                    else
                    {
                        t[A[i] - 1] = i + 1;
                        count++;
                        if (max < i)
                            max = i;
                    }
                }
            }
            if (count != X)
                return -1;
            else
                return max;
        }
    }
}

