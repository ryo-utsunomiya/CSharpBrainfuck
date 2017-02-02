using System.Collections.Generic;

namespace CSharpBrainfuck.Operator
{
    class Loop : IOperator
    {
        private IEnumerable<IOperator> operators;

        public Loop(IEnumerable<IOperator> operators)
        {
            this.operators = operators;
        }

        public void Execute(Memory memory, IO io)
        {
            while (memory.Read() > 0)
            {
                ExecuteProgram(memory, io);
            }
        }

        public void ExecuteProgram(Memory memory, IO io)
        {
            foreach (var op in operators)
            {
                if (op != null)
                    op.Execute(memory, io);
            }
        }
    }
}
