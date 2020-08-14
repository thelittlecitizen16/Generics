using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class ReplaceAWithSixBlock : IBlock<string>
    {
        public string Process(string input)
        {
            while (input.Contains('A'))
            {
                input = input.Replace('A', '6');
            }

            return input;
        }
    }
}
