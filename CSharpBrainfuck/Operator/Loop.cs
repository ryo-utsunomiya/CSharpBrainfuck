namespace CSharpBrainfuck.Operator
{
    class Input : IOperator
    {
        public void Execute(Memory memory, IO io)
        {
            memory.Write(io.Read());
        }
    }
}
