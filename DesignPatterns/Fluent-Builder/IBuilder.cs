using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface IBuilder<T>
    {
        T Build();
    }
}
