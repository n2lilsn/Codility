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
            A[0] = 1;
            A[1] = 2;
            A[2] = 3;
            A[3] = 4;
            A[4] = 5;
            A[5] = 6;

            Console.WriteLine(solution(A));
            Console.Read();
        }
        public static int solution(int[] A)
        {
            int min = 1;
            Array.Sort(A);

            foreach (var item in A)
            {
                if (item > -1 && item == min)
                    min++;
            }
            return min;
        }
    }
}
