using System.Collections.Generic;

namespace CSharpBrainfuck
{
    class IO
    {
        private IDictionary<int, int> input;
        private IList<int> output = new List<int>();
        private int inputPosition = 0;

        public IO(IDictionary<int, int> input)
        {
            this.input = input;
        }

        public IO(int[] input)
        {
            this.input = new Dictionary<int, int>();

            for (int i = 0; i < input.Length; i++)
            {
                this.input.Add(i, input[i]);
            }
        }

        public IEnumerable<int> GetOutput()
        {
            return output;
        }

        public int Read()
        {
            if (input.ContainsKey(inputPosition))
            {
                return input[inputPosition++];
            }
            else
            {
                return 0;
            }
        }

        public void Write(int value)
        {
            output.Add(value);
        }
    }
}
