using System.Collections;
using System.Text;

namespace StackProject
{
    internal class Program
    {

        static void PostFixExpression()
        {
            int FirstNum;
            int LastNum;
            float Result;
            string UserInput;
            Stack<int> S1 = new Stack<int>();

            Console.WriteLine("Enter the Profix Expression to calculate:");
            UserInput = Console.ReadLine();

            for (int i = 0; i < UserInput.Length; i++)
            {
                if (UserInput[i] == '*')
                {
                    FirstNum = S1.Pop();
                    LastNum = S1.Pop();
                    S1.Push(LastNum * FirstNum);
                }

                else if (UserInput[i] == '+')
                {
                    FirstNum = S1.Pop();
                    LastNum = S1.Pop();
                    S1.Push(LastNum * FirstNum);
                }

                else if (UserInput[i] == '-')
                {
                    FirstNum = S1.Pop();
                    LastNum = S1.Pop();
                    if (FirstNum <= LastNum)
                    {
                        S1.Push(LastNum - FirstNum);
                    }
                    else
                    {
                        S1.Push(FirstNum - LastNum);
                    }

                }

                else if (UserInput[i] == '/')
                {
                    FirstNum = S1.Pop();
                    LastNum = S1.Pop();
                    S1.Push(LastNum / FirstNum);
                }

                else
                {
                    S1.Push(UserInput[i] - '0');
                }
            }
            Result = S1.Pop();
            Console.WriteLine("Result = {0}", Result);
        }

        static void ReverseString()
        {
            StringBuilder Result = new StringBuilder();
            string UserInput;
            Stack<char> Stack = new Stack<char>();
            Console.WriteLine("Enter String to Reverse:");
            UserInput = Console.ReadLine();

            for (int i = 0; i < UserInput.Length ; i++)
            {
                Stack.Push(UserInput[i]);
            }
            Result.Clear();

            foreach (char c in Stack)
            {
                Result.Append(c.ToString());
            }
            Console.WriteLine("Result = {0}", Result);
        }

        static void CheckParenthesis()
        {
            string UserInput;
            Stack<char> Stack = new Stack<char> ();
            Console.WriteLine("Enter the parenthesis:");
            UserInput = Console.ReadLine();
            for (int i = 0; i < UserInput.Length; i++)
            {
                if (Stack.Count == 0)
                {
                    Stack.Push(UserInput[i]);
                }
                else
                {
                    if (Stack.Peek() == UserInput[i])
                    {
                        Stack.Push(UserInput[i]);
                    }
                    else
                    {
                        Stack.Pop();
                    }
                }

            }

            if (Stack.Count > 0)
            {
                Console.WriteLine("Parenthesis are not balanced");
            }
            else
            {
                Console.WriteLine("Parenthesis are balanced");
            }
        }




        static void Main(string[] args)
        {

        }

    }
}
