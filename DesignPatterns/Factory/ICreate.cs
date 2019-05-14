using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface IFactory<T, UEnum>
        where UEnum: Enum
    {
        T Create(UEnum type);
    }
}
