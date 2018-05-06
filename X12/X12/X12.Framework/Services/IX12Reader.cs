using System;
namespace X12.Framework.Services
{
    public interface IX12Reader
    {
        object Read(string input);
    }

    public interface IX12Reader<out T> : IX12Reader
    {
        new T Read(string input);
    }
}
