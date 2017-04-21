using System;

namespace DesignAstackEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            const int initial = 1;
            const int max = 3;

            for(var i = initial; i<= max; i++)
                stack.Push(i);

           

            for(var i = initial; i <= max; i++)
                Console.WriteLine(stack.Pop());

            Console.ReadLine();
        }
    }
}