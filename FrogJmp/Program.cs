using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 10;
            int Y = 85;
            int D = 30;

            Console.WriteLine(solution(X, Y, D));
            Console.Read();
        }
        static int solution(int X, int Y, int D)
        {
            int count = ((Y - X) / D);
            if (((Y - X) % D) > 0)
                count++;
            return count;
        }
    }
}
