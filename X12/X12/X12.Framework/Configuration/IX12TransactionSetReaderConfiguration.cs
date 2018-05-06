using System;
namespace X12.Framework.Configuration
{
    public interface IX12TransactionSetReaderConfiguration : IX12EntityConfiguration
    {
        string ItemDelimiter { get; set; }
    }
}
