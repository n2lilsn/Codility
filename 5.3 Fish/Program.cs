using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3_Fish
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            int[] B = new int[5];

            A[0] = 4;
            A[1] = 3;
            A[2] = 2;
            A[3] = 1;
            A[4] = 5; 

            B[0] = 0;
            B[1] = 1;
            B[2] = 0;
            B[3] = 0;
            B[4] = 0;

            Console.WriteLine(solution(A,B));
            Console.Read();
        }
        static int solution(int[] A, int[] B)
        {
            Stack<int> kolejka = new Stack<int>();
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 0 && kolejka.Count == 0)
                    count++;
                else if (B[i] == 1)
                    kolejka.Push(i);
                else if (B[i] == 0 && kolejka.Count > 0)
                {
                    for (int j = kolejka.Count - 1; j >= 0; j--)
                    {
                        if (A[i] > A[kolejka.Peek()])
                            kolejka.Pop();
                        else
                            break;
                    }
                    if (kolejka.Count == 0)
                        count++;
                }
            }
            return count + kolejka.Count;
        }
    }
}
