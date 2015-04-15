using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_CountDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 6;
            int B = 11;
            int K = 2;
            Console.WriteLine(solution(A, B, K));
            Console.Read();
        }
        static int solution(int A, int B, int K)
        {
            if (A % K == 0)
                return (B - A) / K + 1;
            else
                return (B - (A - A % K)) / K;
        }
    }
}
