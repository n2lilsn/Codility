using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_MissingInteger
{
    public class Program
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
            A[4] = 0;
            A[5] = -1;

            B[0] = int.MinValue;
            B[1] = int.MaxValue;

            C[0] = 2;

            Console.WriteLine(solution(C));
            Console.Read();
        }
        public static int solution(int[] A)
        {
            Array.Sort(A);
            List<int> B = A.ToList();
            B.RemoveAll(o => o < 0);
            if (B.Count() != A.Count())
            {
                int count = 0;
                for (int i = 0; i < B.Count; i++)
                {
                    if (B[i] == i)
                        count++;
                }
                return count;
            }
            else
            {
                int p = A[0];

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] != p)
                    {
                        if (A[i] != p + 1 && p >= 0)
                            return ++p;
                        else
                            p++;
                    }
                }
            }

            return B.Min() - 1;
        }
    }
}
