using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermMissingElem
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
            int razem = 0, suma = 0;
            for (int i = 0; i < A.Length; i++)
            {
                razem += i + 1;
                suma += A[i];
            }
            razem += A.Length + 1;
            return razem - suma;
        }
    }
}
