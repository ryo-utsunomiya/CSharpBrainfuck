namespace CSharpBrainfuck.Operator
{
    class Move : IOperator
    {
        private int direction;

        public Move(int direction = 0)
        {
            this.direction = direction;
        }

        public void Execute(Memory memory, IO io)
        {
            memory.Move(direction);
        }
    }
}
