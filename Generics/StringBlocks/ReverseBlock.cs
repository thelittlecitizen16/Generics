using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class ReverseBlock : IBlock<string>
    {
        public string Process(string input)
        {
            return new string(input.Reverse().ToArray());
        }
    }
}
