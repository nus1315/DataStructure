using System; //write this n dont write below again
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] arg)
        {
            //solve(4, "A", "C", "B");
            int n = 10;
            //Console.WriteLine($"Fibonacci({n}) = {Fibo(n)}");
            PrintFibonacci(0, 1, n);
            Console.ReadLine();
        }

        static void solve(int y, String S, String D, String A)
        {
            if (y == 1) return;
            // s-> a y-1
            solve(y - 1, S, A, D);
            //y
            Console.WriteLine("move " + (y - 1) + "from " + S + " to " + D);
            // a-> d y-1
            solve(y - 1, A, D, S);

        }
        static void count(int y)
        {
            if (y == 0) return;
            Console.WriteLine(y);
            count(y - 1);
        }

        /*static int Fibo(int n)
        {
            if (n == 1) return 1;
            if (n == 0) return 0;
            else
                return Fibo(n - 1) + Fibo(n - 2);
        }*/
        static void PrintFibonacci(int a, int b, int count)
        {
            if (count == 0)
                return;  // Base case: stop when count reaches 0

            // Print the current Fibonacci number
            Console.WriteLine(a);

            // Recursive call: move to the next Fibonacci number
            PrintFibonacci(b, a + b, count - 1);
        }
    }
}