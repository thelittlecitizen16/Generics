using Generics.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class UpperCaseBlock : IBlock<string>
    {
        public string Process(string input)
        {
            return input.ToUpper();
        }
    }
}
