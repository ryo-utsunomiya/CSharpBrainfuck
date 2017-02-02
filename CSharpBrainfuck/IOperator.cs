namespace CSharpBrainfuck
{
    interface IOperator
    {
        void Execute(Memory memory, IO io);
    }
}
