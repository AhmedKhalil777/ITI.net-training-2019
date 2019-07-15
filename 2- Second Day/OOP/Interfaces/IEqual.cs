using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IEqual<T>
    {
        bool Equals(T obj);
    }
}
