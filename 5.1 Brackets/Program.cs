using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "{[()()]}";

            Console.WriteLine(solution(S));
            Console.Read();
        }
        static int solution(string S)
        {
            Stack<int> kolejka = new Stack<int>();
            if (S == string.Empty)
                return 1;
            else
            {
                for (int i = 0; i < S.Length; i++)
                {
                    if (S[i] == '{')
                        kolejka.Push(1);
                    else if (S[i] == '[')
                        kolejka.Push(2);
                    else if (S[i] == '(')
                        kolejka.Push(3);

                    if (kolejka.Count > 0)
                    {
                        if (S[i] == '}' && kolejka.Peek() == 1)
                            kolejka.Pop();
                        else if (S[i] == ']' && kolejka.Peek() == 2)
                            kolejka.Pop();
                        else if (S[i] == ')' && kolejka.Peek() == 3)
                            kolejka.Pop();
                    }
                    else if (kolejka.Count == 0 && (S[i] == ')' || S[i] == '}' || S[i] == ']'))
                        return 0;
                }
            }
            return (kolejka.Count > 0) ? 0 : 1;
        }
    }
}
