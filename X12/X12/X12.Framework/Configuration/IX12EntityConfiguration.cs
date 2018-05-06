using System;
namespace X12.Framework.Configuration
{
    public interface IX12EntityConfiguration
    {
        string Identifier { get; set; }
        string StorageType { get; set; }
    }
}
