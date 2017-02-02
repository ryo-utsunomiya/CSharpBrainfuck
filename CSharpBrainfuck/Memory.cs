using System.Collections.Generic;

namespace CSharpBrainfuck
{
    class Memory
    {
        private IDictionary<int, int> memory = new Dictionary<int, int>();
        private int position;

        public int Read()
        {
            if (memory.ContainsKey(position))
            {
                return memory[position];
            }
            else
            {
                return 0;
            }
        }

        public void Write(int value)
        {
            memory[position] = value;
        }

        public void Move(int amount)
        {
            position += amount;

            if (!memory.ContainsKey(position))
            {
                memory[position] = 0; // initialize
            }
        }
    }
}
