using System.Collections;
using System.Text;

namespace StackProject
{
    internal class Program
    {

        // Stack Functions

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

        static void MaximumElements()
        {
            int Result;
            int UserInput;
            Stack<int> Stack = new Stack<int> ();
            Console.WriteLine("Enter the numbers, or type \"s\" to start operation:");
            while (int.TryParse(Console.ReadLine(), out UserInput))
            {
                Stack.Push(UserInput);
                Console.WriteLine("\nEnter the numbers, or type \"s\" to start operation:");
            }
            Result = Stack.Max();
            Console.WriteLine("Max value is {0}", Result);
        }

        static void QueueReverse()
        {
            int UserInput;
            StringBuilder sb = new StringBuilder ();
            Stack<int> Stack = new Stack<int> ();
            Queue<int> Queue = new Queue<int> ();
            Console.WriteLine("Enter the numbers oe type \"Exit\" to Exit:");

            while (int.TryParse(Console.ReadLine(), out UserInput))
            {
                Queue.Enqueue(UserInput);
                Console.WriteLine("\nEnter the next number");
            }
            Console.Clear();
            Console.WriteLine("Queue content before reversing");

            foreach (int i in Queue)
            {
                sb.Append(i).Append(" ");
            }
            Console.WriteLine(sb.ToString());
            while (Queue.Count > 0)
            {
                Stack.Push(Queue.Dequeue());
            }
            while (Stack.Count > 0)
            {
                Queue.Enqueue(Stack.Pop());
            }
            sb.Clear();
            Console.WriteLine("Queue content after reversing:");
            foreach (int i in Queue)
            {
                sb.Append(i).Append(" ");
            }
            Console.WriteLine(sb.ToString());
        }

        static void Main(string[] args)
        {

        }

    }
}
