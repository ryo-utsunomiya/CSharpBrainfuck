namespace CSharpBrainfuck.Operator
{
    class Change : IOperator
    {
        private int amount;

        public Change(int amount = 0)
        {
            this.amount = amount;
        }

        public void Execute(Memory memory, IO io)
        {
            memory.Write(memory.Read() + amount);
        }
    }
}
