using Generics.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class DataFlow<T> : IDataFlow<T>
        where T : class
    {
        private List<IBlock<T>> _blocks;

        public DataFlow()
        {
            _blocks = new List<IBlock<T>>();
        }
        public void AddBlock(IBlock<T> block)
        {
            _blocks.Add(block);
        }

        public T RunFlow(T input)
        {
            foreach (var block in _blocks)
            {
                input = block.Process(input);
            }

            return input;
        }
    }
}
