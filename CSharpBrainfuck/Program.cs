using System;

namespace CSharpBrainfuck
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = @"++++++++++[>+++++++>++++++++++>+++>+<<<<-]>++.>+.+++++++..+++.>++.<<+++++++++++++++.>.+++.------.--------.>+.>.";
            var output = new Language().Run(helloWorld);

            foreach (var i in output)
            {
                Console.Write((char)i);
            }
        }
    }
}
