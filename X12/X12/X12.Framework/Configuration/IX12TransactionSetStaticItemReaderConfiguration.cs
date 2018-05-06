using System;
namespace X12.Framework.Configuration
{
    public interface IX12TransactionSetStaticItemReaderConfiguration : IX12EntityConfiguration
    {
        int? Offset { get; set; }
        int Length { get; set; }
    }
}
