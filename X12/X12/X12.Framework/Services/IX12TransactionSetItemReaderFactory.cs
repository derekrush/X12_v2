using System;
namespace X12.Framework.Services
{
    public interface IX12TransactionSetItemReaderFactory
    {
        IX12TransactionSetItemReader GetReader();
    }
}
