using CSharpBrainfuck.Operator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpBrainfuck
{
    class Parser
    {
        private IDictionary<char, IOperator> operators = new Dictionary<char, IOperator>()
        {
            { '+', new Change(1) },
            { '-', new Change(-1) },
            { '.', new Output() },
            { ',', new Input() },
            { '>', new Move(1) },
            { '<', new Move(-1) },
        };

        public Loop Parse(string program)
        {
            return new Loop(ParseProgram(program));
        }

        private IEnumerable<IOperator> ParseProgram(string program)
        {
            var ops = new List<IOperator>();
            int programPosition = 0;

            foreach (var c in program.ToCharArray())
            {
                ops.Add(GetOperator(program, ref programPosition));
                programPosition++;
            }

            return ops;
        }

        private IOperator GetOperator(string program, ref int position)
        {
            if (position >= program.Length)
            {
                return null;
            }

            if (operators.ContainsKey(program[position]))
            {
                return operators[program[position]];
            }
            else if (program[position] == ']')
            {
                throw new Exception($"Unmatch brace at pos {position}");
            }
            else if (program[position] == '[')
            {
                return ParseLoop(program, ref position);
            }

            return null;
        }

        public IOperator ParseLoop(string program, ref int position)
        {
            string pattern = @"\[(.+)\]";

            var match = Regex.Match(program, pattern);

            if (match.Success)
            {
                string partialProgram = match.Groups[1].Value;
                position += partialProgram.Length + 1;
                return Parse(partialProgram);
            }
            else
            {
                throw new Exception("Not matched in ParseLoop");
            }
        }
    }
}
