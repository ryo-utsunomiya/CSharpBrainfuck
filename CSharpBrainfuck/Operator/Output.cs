using System.Collections.Generic;

namespace CSharpBrainfuck.Operator
{
    class Output : IOperator
    {
        public void Execute(Memory memory, IO io)
        {
            io.Write(memory.Read());
        }
    }
}
