using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Interfaces
{
    public interface IBlock<T> where T : class
    {
        T Process(T input);
    }
}
