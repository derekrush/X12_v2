using System;
using System.Collections.Generic;
using System.Linq;
using X12.Framework.Configuration;
using X12.Framework.Domain;

namespace X12.Framework.Services
{
    public class X12TransactionSetReader : IX12Reader<IList<IX12Entity>>
    {
        private readonly IX12EntityContainerConfiguration _containerConfig;
        private readonly Func<string, IX12TransactionSetItemReader> _itemReaderFactory;
        private readonly IList<IX12TransactionSetStaticItemReaderConfiguration> _itemReaderConfigs;

        public X12TransactionSetReader(
            IX12EntityContainerConfiguration containerConfig,

            Func<string, IX12TransactionSetItemReader> itemReaderFactory)
        {
            _containerConfig = containerConfig;
            _itemReaderFactory = itemReaderFactory;
        }

        public IList<IX12Entity> Read(string input)
        {
            var splits = input.Split(new[] { _containerConfig.ItemDelimiter }, StringSplitOptions.RemoveEmptyEntries);
            return splits.Select(i => _itemReaderFactory(i).Read(i)).ToArray();
        }

        object IX12Reader.Read(string input)
        {
            return Read(input);
        }
    }
}
