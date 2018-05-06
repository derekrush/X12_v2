using System;
using X12.Framework.Configuration;
namespace X12.Framework.Domain
{
    public interface IX12Entity
    {
        IX12EntityConfiguration Configuration { get; }
        object Value { get; }
    }

    public interface IX12Entity<out T> : IX12Entity
    {
        new T Value { get; }
    }
}
