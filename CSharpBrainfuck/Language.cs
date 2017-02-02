using System.Collections.Generic;

namespace CSharpBrainfuck
{
    class Language
    {
        public IEnumerable<int> Run(string program, int[] input = null)
        {
            if (input == null)
            {
                input = new int[] { };
            }

            var io = new IO(input);
            new Parser().Parse(program).ExecuteProgram(new Memory(), io);

            return io.GetOutput();
        }
    }
}
